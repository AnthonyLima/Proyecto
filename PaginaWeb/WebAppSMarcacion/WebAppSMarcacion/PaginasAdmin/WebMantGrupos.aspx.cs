using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace WebAppSMarcacion.PaginasAdmin
{
    public partial class WebMantGrupos : System.Web.UI.Page
    {
        WcfSMarcacion.Service1Client servicio = new WcfSMarcacion.Service1Client();
        WcfSMarcacion.SCUsuarios usuario = new WcfSMarcacion.SCUsuarios();
        WcfSMarcacion.SCGrupos Grupos = new WcfSMarcacion.SCGrupos();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["CodigoUsuarios"] != null)
            {
                //si existe informacion de un codigo de usuario
                CargarUsuario(Session["CodigoUsuarios"].ToString().Trim());
                CargarLista();
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

        private void CargarLista()
        {
            DataSet ds = new DataSet();
            ds = servicio.BuscarTodosGrupo();
            dtLista.DataSource = ds;
            dtLista.DataBind();
        }

        protected void btnCrearGrupo_Click(object sender, EventArgs e)
        {

        }
    }
}