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
        //string nombrePagina = "../Pagina/WebInicio.aspx";
        WcfSMarcacion.SCUsuarios Usuario = new WcfSMarcacion.SCUsuarios();
        WcfSMarcacion.Service1Client servicio = new WcfSMarcacion.Service1Client();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //ejecutandoce por primera vez
                if (Session["CodigoUsuario"] == "")
                {
                    Response.Redirect("..");
                }
            }
            if (IsPostBack)
            {
                Response.Redirect("/PaginasEmpleados/WebInicio.aspx");
            }

            //PanelContent.Visible = true;
            //PanelContent.Controls.Add(new LiteralControl("<iframe src=\"" + nombrePagina + "\" runat=\"server\"></iframe><br />"));
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Usuario = new WcfSMarcacion.SCUsuarios();
            Usuario = servicio.BusquedaDeUsuario(txtUsuario.Text.Trim(), txtClave.Text.Trim());

            if (Usuario != null)
            {
                Session.Add("CodigoUsuario", Usuario.CodigoUsuario);
            }
        }
    }
}