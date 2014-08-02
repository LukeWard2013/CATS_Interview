using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq.Expressions;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using CATS_Interview.View_Models;

namespace CATS_Interview.HTML_Helpers
{
    public static class HtmlHelpers
    {

        public static MvcHtmlString LinkToAddNestedItem<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression, string linkText, string containerElement, string counterElement, IEnumerable<SelectListItem> contactPositions,string cssClass = null ) where TProperty : IEnumerable<object>
        {
            // a fake index to replace with a real index
            string ticks = Guid.NewGuid().ToString();

            // pull the name and type from the passed in expression
            string collectionProperty = ExpressionHelper.GetExpressionText(expression);

            var nestedObject = (ContactViewModel) Activator.CreateInstance(typeof(TProperty).GetGenericArguments()[0]);
            nestedObject.ContactPositionOptions = contactPositions;
            // save the field prefix name so we can reset it when we're doing
            string oldPrefix = htmlHelper.ViewData.TemplateInfo.HtmlFieldPrefix;

            // if the prefix isn't empty, then prepare to append to it by appending another delimiter
            if (!string.IsNullOrEmpty(oldPrefix))
            {
                htmlHelper.ViewData.TemplateInfo.HtmlFieldPrefix += ".";
            }

            // append the collection name and our fake index to the prefix name before rendering
            htmlHelper.ViewData.TemplateInfo.HtmlFieldPrefix += string.Format("{0}[{1}]", collectionProperty, ticks);

            string partial = htmlHelper.EditorFor(x => nestedObject).ToHtmlString();

            // done rendering, reset prefix to old name
            htmlHelper.ViewData.TemplateInfo.HtmlFieldPrefix = oldPrefix;

            // strip out the fake name injected in (our name was all in the prefix)
            partial = Regex.Replace(partial, @"[\._]?nestedObject", "");

            partial = HttpUtility.JavaScriptStringEncode(partial);

            // create the link to render
            var js = string.Format("javascript:addNestedForm('{0}','{1}','{2}','{3}');return false;", containerElement, counterElement, ticks, partial);

            TagBuilder a = new TagBuilder("a");

            a.Attributes.Add("href", "javascript:void(0)");

            a.Attributes.Add("onclick", js);

            if (cssClass != null)
            {
                a.AddCssClass(cssClass);
            }
            a.InnerHtml = linkText;

            return MvcHtmlString.Create(a.ToString(TagRenderMode.Normal));
        
        }

        public static IHtmlString LinkToRemoveNestedItem(this HtmlHelper htmlHelper, string linkText, string container, string deleteElement)
        {

            var js = string.Format("javascript:removeNestedForm(this,'{0}','{1}');return false;", container, deleteElement);

            var tb = new TagBuilder("a");

            tb.Attributes.Add("href", "#");

            tb.Attributes.Add("onclick", js);

            tb.InnerHtml = linkText;

            var tag = tb.ToString(TagRenderMode.Normal);

            return MvcHtmlString.Create(tag);

        }
    }
}