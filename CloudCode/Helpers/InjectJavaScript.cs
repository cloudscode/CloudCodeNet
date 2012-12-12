using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CloudCode.Helpers
{
    public static class InjectJavaScript
    {
        public static MvcHtmlString RenderJavascript(this HtmlHelper html, string js)
        {
            return MvcHtmlString.Create(js);
        }

    }
}