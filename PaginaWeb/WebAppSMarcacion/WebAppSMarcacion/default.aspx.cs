using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppSMarcacion
{
    public partial class _default : System.Web.UI.Page
    {
        string nombrePagina = "PaginaContenido/WebLogin.aspx";
        protected void Page_Load(object sender, EventArgs e)
        {
            //PagContent.Controls.Add(new LiteralControl("<iframe src=\"" +nombrePagina +"\"></iframe><br />"));
            PanelContent.Visible = true;
            PanelContent.Controls.Add(new LiteralControl("<iframe src=\"" + nombrePagina + "\" Width=\""+100+"%\"></iframe><br />"));
        }
    }
}