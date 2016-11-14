using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppSMarcacion.PaginasEmpleados
{
    public partial class WebInicio : System.Web.UI.Page
    {
        WcfSMarcacion.Service1Client servicio = new WcfSMarcacion.Service1Client();
        WcfSMarcacion.SCUsuarios usuario = new WcfSMarcacion.SCUsuarios();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //ejecutandoce por primera vez
                Response.Redirect("..");
            }
            else
            {
                CargarUsuario(Session["CodigoUsuario"].ToString());
                if (usuario != null)
                    txtNombre.Text = usuario.Nombre;

            }
        }

        private void CargarUsuario(string sCodigoUsuario)
        {
            usuario = servicio.BuscarUsuarioPorCodigoUsuario(int.Parse(sCodigoUsuario));
        }
    }
}