
$(function () {
    //Startup code
    $("#tabs").tabs();
    $("#save").click(selectAll);
    $("#callBack").dialog({ autoOpen: false, modal: true, title: 'Set a call back.', draggable: true, width: 550, height :400 });

    $('#CallViewModel_CallBackDate').appendDtpicker({
        "inline": false,
        "allowWdays": [0, 1, 2, 3, 4, 5, 6], // 0: Sun, 1: Mon, 2: Tue, 3: Wed, 4: Thr, 5: Fri, 6: Sat
        "closeOnSelected": true,
        "dateFormat": "DD/MM/YYYY hh:mm",
        "futureOnly": true
    });
    
    var d = new Date();
    $("#CallViewModel_CallBackDate").handleDtpicker("setDate", new Date(d.getFullYear(), d.getMonth() + 1, d.getDate(), 0, 0, 0));
    $(".processRecord").click(function () {
        $("#callBack").dialog("open");
        return false;
    });
});
            
$(window).resize(function () {
    $("#dialog").dialog("option", "position", "center");
});

function selectAll() {
    //Select all items in any listbox not drop downs
    $('select').each(function (idx, element) {
        if ($(this).attr('multiple') == 'multiple') {
            $(element).find("option").each(function() {
                $(this).prop("selected", true);
            });
        }
    });
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

        // do something

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

    $container.find(deleteElement).val("True");

    $container.hide();

    $container.find(":input[data-val=true]").each(function () {
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
    $("form").removeData("validator");
    $("form").removeData("unobtrusiveValidation");
    $.validator.unobtrusive.parse("form");
}
