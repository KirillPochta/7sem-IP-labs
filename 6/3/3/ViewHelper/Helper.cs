using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _3.ViewHelper
{
    public static class Helper
    {
        public static MvcHtmlString AddPhoneForm(this HtmlHelper html)
        {
            TagBuilder form = new TagBuilder("form");
            form.MergeAttribute("method", "post");
            form.MergeAttribute("action", "/Dict/AddSave");

            TagBuilder table = new TagBuilder("table");
            TagBuilder tr1 = new TagBuilder("tr");
            TagBuilder td1 = new TagBuilder("td");
            TagBuilder p1 = new TagBuilder("p");
            TagBuilder br = new TagBuilder("br");
            p1.SetInnerText("Enter your Name");
            td1.InnerHtml = p1.ToString();


            TagBuilder td2 = new TagBuilder("td");
            TagBuilder surnameInput = new TagBuilder("input");
            surnameInput.MergeAttribute("type", "text");
            surnameInput.MergeAttribute("name", "Name");
            td2.InnerHtml = surnameInput.ToString();

            tr1.InnerHtml = td1.ToString() + td2.ToString();



            TagBuilder tr2 = new TagBuilder("tr");
            TagBuilder td3 = new TagBuilder("td");
            TagBuilder p2 = new TagBuilder("p");
            p2.SetInnerText("Enter phone number");
            td3.InnerHtml = p2.ToString();


            TagBuilder td4 = new TagBuilder("td");
            TagBuilder phoneInput = new TagBuilder("input");
            phoneInput.MergeAttribute("type", "text");
            phoneInput.MergeAttribute("name", "Number");
            td4.InnerHtml = phoneInput.ToString();

            tr2.InnerHtml = td3.ToString() + td4.ToString();

            TagBuilder tr3 = new TagBuilder("tr");
            TagBuilder td5 = new TagBuilder("td");
            TagBuilder submitButton = new TagBuilder("button");
            submitButton.MergeAttribute("type", "submit");
            submitButton.SetInnerText("Send");
            td5.InnerHtml = submitButton.ToString();
            tr3.InnerHtml = td5.ToString();

            table.InnerHtml = tr1.ToString() + tr2.ToString() + tr3.ToString();
            form.InnerHtml = table.ToString();
            return new MvcHtmlString(form.ToString());
        }
        public static MvcHtmlString UpdatePhoneForm(this HtmlHelper helper, string id, string number, string name)
        {
            TagBuilder form = new TagBuilder("form");
            form.MergeAttribute("method", "post");
            form.MergeAttribute("action", "/Dict/UpdateSave");


            TagBuilder hiddenInput = new TagBuilder("input");
            hiddenInput.MergeAttribute("type", "hidden");
            hiddenInput.MergeAttribute("name", "id");
            hiddenInput.MergeAttribute("value", id);

            TagBuilder br = new TagBuilder("br");
            TagBuilder p1 = new TagBuilder("p");
            p1.SetInnerText("Enter new Name");




            TagBuilder surnameInput = new TagBuilder("input");
            surnameInput.MergeAttribute("type", "text");
            surnameInput.MergeAttribute("name", "Name");
            surnameInput.InnerHtml = name;




            TagBuilder p2 = new TagBuilder("p");
            p2.SetInnerText("Enter new phone number");




            TagBuilder phoneInput = new TagBuilder("input");
            phoneInput.MergeAttribute("type", "text");
            phoneInput.MergeAttribute("name", "Number");
            phoneInput.InnerHtml = number;



            TagBuilder submitButton = new TagBuilder("button");
            submitButton.MergeAttribute("type", "submit");
            submitButton.SetInnerText("Send");

            form.InnerHtml = hiddenInput.ToString() + br.ToString(TagRenderMode.SelfClosing) + p1.ToString() + surnameInput.ToString()  +
                p2.ToString() + phoneInput.ToString() + br.ToString(TagRenderMode.SelfClosing) + br.ToString(TagRenderMode.SelfClosing) + submitButton.ToString();

            return new MvcHtmlString(form.ToString());
        }
    }
}