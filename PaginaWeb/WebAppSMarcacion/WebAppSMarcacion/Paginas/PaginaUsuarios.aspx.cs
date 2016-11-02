using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppSMarcacion.Paginas
{
    public partial class PaginaUsuarios : System.Web.UI.Page
    {

        string nombrePagina = "../PaginaContenido/WebLogin.aspx";
        protected void Page_Load(object sender, EventArgs e)
        {


            PanelContent.Visible = true;
            PanelContent.Controls.Add(new LiteralControl("<iframe src=\"" + nombrePagina + "\" runat=\"server\"></iframe><br />"));
        }
    }
}