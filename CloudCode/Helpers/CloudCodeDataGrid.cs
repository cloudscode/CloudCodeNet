using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Text;
using CloudCode.Web.Controls;
namespace CloudCode.Helpers
{
    public static class CloudCodeDataGrid
    {
        public static MvcHtmlString RenderCloudCodeDataGrid(this HtmlHelper html, CloudCode.Web.Controls.CloudCodeDataGrid dataGrid)
        {
            string control = dataGrid.CreateControl();
                return MvcHtmlString.Create(control);
        }
    }
}