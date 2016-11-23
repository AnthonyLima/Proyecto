using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppSMarcacion.PaginasAdmin
{
    public partial class WebMantGrupos : System.Web.UI.Page
    {
        WcfSMarcacion.Service1Client servicio = new WcfSMarcacion.Service1Client();
        WcfSMarcacion.SCUsuarios usuario = new WcfSMarcacion.SCUsuarios();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["CodigoUsuarios"] != null)
            {
                //si existe informacion de un codigo de usuario
                CargarUsuario(Session["CodigoUsuarios"].ToString().Trim());
            }
            else
            {
                //regresar al menu principal
                Response.Redirect(".");

            }
        }

        private void CargarUsuario(string sCodigoUsuario)
        {
            //se debe convertir de un string a integer
            usuario = new WcfSMarcacion.SCUsuarios();
            usuario = servicio.BuscarUsuarioPorCodigoUsuario(int.Parse(sCodigoUsuario));
            if (usuario.CodigoUsuarios > 0)
            {
                txtNombre.Text = usuario.Nombre;
            }
        }

        protected void btnCrearGrupo_Click(object sender, EventArgs e)
        {

        }
    }
}