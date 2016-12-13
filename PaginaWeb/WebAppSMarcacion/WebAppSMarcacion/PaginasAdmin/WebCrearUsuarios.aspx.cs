using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppSMarcacion.PaginasAdmin
{
    public partial class WebCrearUsuarios : System.Web.UI.Page
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
        }

        protected void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            string dato = txtNombre.Text.Trim();
            bool temp = false;
            temp = servicio.CrearUsuario(dato);
            if (temp)
            {
                Response.Redirect(Request.RawUrl);
            }
            else
            {
                lbRespond.Text = "no se logro crear el usuario";
            }
        }
    }
}