
$(function () {
    //Startup code
    $("#tabs").tabs();
    
    // Don't allow browser caching of forms
    $.ajaxSetup({ cache: false });

    $("#callBack").dialog({
        
        autoOpen: false,
        modal: true,
        title: 'Update record.',
        draggable: false,
        width: 580,
        height: 400,
        buttons: [
            {
                text: "Save Record",
                click: selectAll,
                id: "save"
            },
            {
                text: "Close",
                click: function () {
                    $(this).dialog("close");
                }
            }
        ]
        ,
        open: function () {
            
            }
        });
    
    $('#CallViewModel_CallBackDate').appendDtpicker({
        "inline": false,
        "allowWdays": [0, 1, 2, 3, 4, 5, 6], // 0: Sun, 1: Mon, 2: Tue, 3: Wed, 4: Thr, 5: Fri, 6: Sat
        "closeOnSelected": true,
        "dateFormat": "DD/MM/YYYY hh:mm",
        "futureOnly": true,
        "todayButton": false,
        "animation": true,
        "autodateOnStart": false,
        "calendarMouseScroll": false
    });
    
    var d = new Date();
    $("#CallViewModel_CallBackDate").handleDtpicker("setDate", new Date(d.getFullYear(), d.getMonth() + 1, d.getDate(), 0, 0, 0));
  
    $(".processRecord").click(function () {
        $("#callBack").dialog("open");
        return false;
    });
    
    $('div#callBack').bind('dialogclose', function () {
        $('#CallViewModel_CallBackDate').handleDtpicker('hide');
    });
    setjQueryDateValidation();
});
        
function setjQueryDateValidation() {
    $.validator.addMethod('date',
    function (value, element) {
        if (this.optional(element)) {
            return true;
        }
        var ok = true;
        try {
            $.datepicker.parseDate('dd/mm/yy', value);
        }
        catch (err) {
            ok = false;
        }
        return ok;
    });
    $(".datefield").datepicker({ dateFormat: 'dd/mm/yy', changeYear: true });    
}

$(window).resize(function () {
    $("#callBack").dialog("option", "position", "center");
});

function selectAll() {
    
    $('#callBack').parent().appendTo($('form:first'));
    
    $("form").removeData("validator");
    $("form").removeData("unobtrusiveValidation");
    $.validator.unobtrusive.parse("form");
    
    $("#frmInterview").validate();
    
    if ($("#frmInterview").valid()) {
        //Select all items in any listbox not drop downs
        $('select').each(function (idx, element) {
            if ($(this).attr('multiple') == 'multiple') {
                $(element).find("option").each(function () {
                    $(this).prop("selected", true);
                });
            }
        });
        
        $("form").submit();
    }
    $(document.body).append($("#callBack").parent());
}

function changeColor(status, ctrl) {

    if (status == "on") {
        $('#' + $(ctrl).attr("id") + "_Label").removeClass("resetQuestion");
        $('#' + $(ctrl).attr("id") + "_Label").addClass("currentQuestion");
    }
    else {
        $('#' + $(ctrl).attr("id") + "_Label").removeClass("currentQuestion");
        $('#' + $(ctrl).attr("id") + "_Label").addClass("resetQuestion");
    }

}
function addItem(ddl, lb) {
        var selectedText = $(ddl).find(":selected").text();
        if (selectedText == "") return;
        
        var alreadyInList;
        $(lb).find("option").each(function() {
            if ($(this).text() == selectedText) {
                alreadyInList = true;
            }
        });

        if (!alreadyInList && selectedText != "")
            $(lb).append("<option value=" + $(ddl).find(":selected").val() + ">" + $(ddl).find(":selected").text() + "</option>");
        return;
}

function removeItem(ddl) {
    $(ddl).find(':selected').remove();
}


function removeNestedForm(element, container, deleteElement) {
    var $container = $(element).parents(container);

    $container.find(deleteElement).val('True');

    $container.hide();

    $container.find(':input[data-val=true]').each(function () {
        $(this).removeAttr('data-val');
    });
    
    resetValidation();
}

function addNestedForm(container, counter, ticks, content) {

    var nextIndex = $(counter).length;

    var pattern = new RegExp(ticks, "gi");

    content = content.replace(pattern, nextIndex);

    $(container).append(content);
    
    resetValidation();

}
function resetValidation() {
    // can't add validation to a form, must clear validation and rebuild
    var form = $("#frmInterview").closest("form");
    form.removeData('validator');
    form.removeData('unobtrusiveValidation');
    $.validator.unobtrusive.parse(form);
}
/*
 * The form attribute can be used to associate a submit button with a form, even
 * if the button is not a child of the <form> itself.
 * 
 * This polyfill uses a support check taken from Modernizr and polyfills the
 * functionality using jQuery.
 */
(function () {
    // Via Modernizr
    function formAttributeSupport() {
        var form = document.createElement("form"),
            input = document.createElement("input"),
            div = document.createElement("div"),
            id = "formtest" + (new Date().getTime()),
            attr,
            bool = false;

        form.id = id;

        // IE6/7 confuses the form idl attribute and the form content attribute
        if (document.createAttribute) {
            attr = document.createAttribute ("form");
            attr.nodeValue = id;
            input.setAttributeNode(attr);
            div.appendChild(form);
            div.appendChild(input);

            document.documentElement.appendChild(div);

            bool = form.elements.length === 1 && input.form == form;

            div.parentNode.removeChild(div);
        }

        return bool;
    };

    if (!formAttributeSupport()) {
        $(document)
            .on("click", "[type=submit][form]", function (event) {
                event.preventDefault();
                var formId = $(this).attr("form"),
                $form = $("#" + formId).submit();
            })
            .on("keypress", "form input", function (event) {
                var $form;
                if (event.keyCode == 13) {
                    $form = $(this).parents("form");
                    if ($form.find("[type=submit]").length == 0 &&
                        $("[type=submit][form=" + $(this).attr("form") + "]").length > 0) {
                        $form.submit();
                    }
                }
            });
    }
}());
