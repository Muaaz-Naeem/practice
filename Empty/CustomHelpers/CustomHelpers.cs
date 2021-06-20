using Empty.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.UI.HtmlControls;

namespace Empty.CustomHelpers
{
    public static class CustomHelpers
    {
        public static IHtmlString Custom(this HtmlHelper helper, string value, string type, string classes, string placeHolder)
        {
            TagBuilder tb = new TagBuilder("input");                                                                                                                                                                                                
            tb.Attributes.Add("type", type);
            tb.Attributes.Add("value", value);
            tb.Attributes.Add("class", classes);
            tb.Attributes.Add("placeholder", placeHolder);
            return new MvcHtmlString(tb.ToString());
        }

        public static MvcHtmlString CustomFor<TModel, TValue>(this HtmlHelper<TModel> html, Expression<Func<TModel, TValue>> expression, string classes)
         {
            var fieldName = ExpressionHelper.GetExpressionText(expression);
            var fullBindingName = html.ViewContext.ViewData.TemplateInfo.GetFullHtmlFieldName(fieldName);
            var fieldId = TagBuilder.CreateSanitizedId(fullBindingName);

            var metadata = ModelMetadata.FromLambdaExpression(expression, html.ViewData);
            var value = metadata.Model;

            TagBuilder tag = new TagBuilder("input");
            tag.Attributes.Add("name", fullBindingName);
            tag.Attributes.Add("id", fieldId);
            tag.Attributes.Add("type", "text");
            tag.Attributes.Add("class", classes);
            tag.Attributes.Add("value", value == null ? "" : value.ToString());

            var validationAttributes = html.GetUnobtrusiveValidationAttributes(fullBindingName, metadata);
            foreach (var key in validationAttributes.Keys)
            {
                tag.Attributes.Add(key, validationAttributes[key].ToString());
            }



            return new MvcHtmlString(tag.ToString(TagRenderMode.SelfClosing));

        }


       public static IHtmlString CustomTable(this HtmlHelper helper ,List<string> list)
        {

           



            TagBuilder tb = new TagBuilder("table");

            //RouteValueDictionary htmlAttrs = HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes);

            //foreach (var attribute in htmlAttrs)
            //{
            //    tb.Attributes.Add(attribute.Key, attribute.Value.ToString());
            //}


            tb.Attributes.Add("class", "table table-bordered table-striped table-hover ");
            TagBuilder thead = new TagBuilder("thead");
            thead.Attributes.Add("class", "thead-dark");
            TagBuilder tr = new TagBuilder("tr");
            TagBuilder th = new TagBuilder("th");

            th.InnerHtml = "Sr#";
            tr.InnerHtml = th.ToString();

            th.InnerHtml = "Details";
            tr.InnerHtml += th.ToString();

            thead.InnerHtml = tr.ToString();

            tb.InnerHtml = tb.InnerHtml.ToString() + thead.ToString();


            //for (int i = 0; i < list.Count; i++)
            //{
            //    tr = new TagBuilder("tr");
            //    td = new TagBuilder("td");

            //    td.InnerHtml = "" + (i + 1);

            //    TagBuilder td1 = new TagBuilder("td");
            //    td1.InnerHtml = list[i];

            //    tr.InnerHtml = td.ToString() + td1.ToString();
            //    tb.InnerHtml = tb.InnerHtml.ToString() + tr.ToString();

            //}

            return new MvcHtmlString(tb.ToString());



        }
        

        public static IHtmlString CustomTbl<T>(this HtmlHelper helper , List<T> list)
        {
            //var fields = typeof(Student).GetProperties().Select(f => f.Name).ToList();
            var listType = typeof(T);
               
            var fields = listType.GetProperties().Select(f => f.Name).ToList();

            
            TagBuilder tb = new TagBuilder("table");
            tb.Attributes.Add("class", "table table-bordered table-striped table-hover ");

            TagBuilder thead = new TagBuilder("thead");
            thead.Attributes.Add("class", "thead-dark");

            TagBuilder tr = new TagBuilder("tr");
            TagBuilder th = new TagBuilder("th");

            foreach (var field in fields)
            {

                th = new TagBuilder("th");
                th.InnerHtml = field;
                tr.InnerHtml += th.ToString();
            }

            thead.InnerHtml = tr.ToString();
            tb.InnerHtml = thead.ToString();

            TagBuilder td = new TagBuilder("td");

            foreach (var row in list)
            {
                tr = new TagBuilder("tr");

                foreach (var item in listType.GetProperties())
                {
                    td = new TagBuilder("td");

                    var value = item.GetValue(row, null) == null ? "no value" : item.GetValue(row, null);
                    td.InnerHtml = value.ToString() ;
                    tr.InnerHtml += td.ToString();
                }
                //for (int i = 0; i < fields.Count; i++)
                //{
                   
                //}


                tb.InnerHtml += tr.ToString();


            }
 
            return new MvcHtmlString(tb.ToString());

        }
    }
}