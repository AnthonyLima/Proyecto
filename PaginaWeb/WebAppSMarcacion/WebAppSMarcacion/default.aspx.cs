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
        string nombrePagina = "../PaginaContenido/WebInicio.aspx";
        

        protected void Page_Load(object sender, EventArgs e)
        {
            //if (IsPostBack == false)
            //{
            //    if (Session("CodigoUsuario") == "")
            //    {
            //        nombrePagina = "../PaginaContenido/WebLogin.aspx";
            //    }
            //    else
            //    {
            //        nombrePagina = "../PaginaContenido/WebInicio.aspx";
            //    }
            //}

            PanelContent.Visible = true;
            PanelContent.Controls.Add(new LiteralControl("<iframe src=\"" + nombrePagina + "\" runat=\"server\"></iframe><br />"));
        }
    }
}