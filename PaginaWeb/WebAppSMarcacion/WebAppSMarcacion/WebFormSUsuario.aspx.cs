using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppSMarcacion
{
    public partial class WebFormSUsuario : System.Web.UI.Page
    {
        WcfSMarcacion.Service1Client wcfSMarcacion;
        WcfSMarcacion.SCUsuarios UserTemp;

        protected void Page_Load(object sender, EventArgs e)
        {
            wcfSMarcacion = new WcfSMarcacion.Service1Client();
            UserTemp = new WcfSMarcacion.SCUsuarios();
        }

        protected void btnBuscarUser_Click(object sender, EventArgs e)
        {
            UserTemp = wcfSMarcacion.BusquedaDeUsuario(txtNombre.Text.Trim(), txtClave.Text.Trim());

            if (UserTemp.CodigoUsuario != 0)
            {
                lblRespuesta.Text = "Usuario: " + UserTemp.Nombre + "; Clave: " + UserTemp.Clave;
            }
        }


    }
}