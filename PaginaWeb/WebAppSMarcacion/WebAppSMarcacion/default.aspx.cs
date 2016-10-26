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
        string nombreOpciones = "PaginaOpciones/Opciones01.aspx";
        protected void Page_Load(object sender, EventArgs e)
        {
            //PagContent.Controls.Add(new LiteralControl("<iframe src=\"" +nombrePagina +"\"></iframe><br />"));
            PanelContent.Controls.Add(new LiteralControl("<iframe src=\"" + nombrePagina + "\"></iframe><br />"));
            PanelOpciones.Controls.Add(new LiteralControl("<iframe src=\"" + nombreOpciones + "\"></iframe><br />"));
        }
    }
}