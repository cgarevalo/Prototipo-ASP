using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Dominio;

namespace Aplicacion
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["listaDirecciones"] == null)
            {
                DireccionNegocio negocio = new DireccionNegocio();
                Session.Add("listaDirecciones", negocio.ListarDirecciones());
            }

            dgvDirecciones.DataSource = Session["listaDirecciones"];
            dgvDirecciones.DataBind();
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Response.Redirect("FormCalle.aspx");
        }

        protected void dgvDirecciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = dgvDirecciones.SelectedDataKey.Value.ToString();
            Response.Redirect("FormCalle.aspx?id=" + id);
        }
    }
}