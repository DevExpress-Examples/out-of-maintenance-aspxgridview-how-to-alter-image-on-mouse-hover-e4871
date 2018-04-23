using DevExpress.Web.ASPxEditors;
using DevExpress.Web.ASPxGridView;
using DevExpress.XtraCharts.Web;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPxGridVIew {
    public partial class Default : System.Web.UI.Page {
        protected void Page_Init(object sender, EventArgs e) {
            ASPxGridView1.DataSource = DataHelper.GenerateData();
            ASPxGridView1.DataBind();
        }

        protected void ASPxImage1_Load(object sender, EventArgs e) {
            ASPxImage image = (ASPxImage)sender;
            GridViewDataItemTemplateContainer c = (GridViewDataItemTemplateContainer)image.NamingContainer;
            string imageUrl = DataBinder.Eval(c.DataItem, "ImageUrl").ToString();
            string altImageUrl = DataBinder.Eval(c.DataItem, "AltImageUrl").ToString();
            image.ClientSideEvents.Init = string.Format("function(s, e) {{ OnImageInit(s, e, '{0}', '{1}'); }}", imageUrl, altImageUrl);
        }
    }
}