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
    public partial class FormCalle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Solo ejecutar la lógica en el primer carga de la página
            if (!IsPostBack)
            {
                if (Request.QueryString["id"] != null)
                {
                    btnModificar.Visible = true;
                    btnEliminar.Visible = true;
                    btnAceptar.Visible = false;

                    int id = int.Parse(Request.QueryString["id"]);

                    List<Direccion> listaSession = (List<Direccion>)Session["listaDirecciones"];
                    Direccion direccionSeleccionada = listaSession.Find(x => x.Id == id);

                    txtId.Text = direccionSeleccionada.Id.ToString();
                    txtCalle.Text = direccionSeleccionada.Calle;
                    txtAltura.Text = direccionSeleccionada.Altura.ToString();
                }
                else
                {
                    txtId.Text = ObtenerId().ToString();
                }   
            }
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            string calle = txtCalle.Text;
            string alturastr = txtAltura.Text;
            int altura;

            if (int.TryParse(alturastr, out altura))
            {
                Direccion nuevaDireccion = new Direccion { Id = ObtenerId(), Calle = calle, Altura = altura };

                List<Direccion> listaEnSesion = (List<Direccion>)Session["listaDirecciones"];
                listaEnSesion.Add(nuevaDireccion);

                Response.Redirect("Default.aspx");
            }
            else
            {
                lblError.Text = "Este campo solo recibe números.";
                return;
            }

        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            string calle = txtCalle.Text;
            string alturastr = txtAltura.Text;
            int altura;

            if (int.TryParse(alturastr, out altura))
            {
                // Obtiene la lista en sesión y la agrega a una nueva lista
                List<Direccion> listaSession = (List<Direccion>)Session["listaDirecciones"];

                // Obtiene el id que se está enviando por url
                int idDireccion = int.Parse(Request.QueryString["id"]);

                // Encuentra la dirección en la lista
                Direccion direccionSeleccionada = listaSession.Find(x => x.Id == idDireccion);

                // Modifica los atributos de la dirección seleccionada
                direccionSeleccionada.Calle = calle;
                direccionSeleccionada.Altura = altura;

                Response.Redirect("Default.aspx");
            }
            else
            {
                lblError.Text = "Este campo solo recibe números.";
                return;
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            int idDireccion = int.Parse(Request.QueryString["id"]);
            List<Direccion> listaSession = (List<Direccion>)Session["listaDirecciones"];

            Direccion direccionEliminar = listaSession.Find(x => x.Id == idDireccion);
            listaSession.Remove(direccionEliminar);

            Response.Redirect("Default.aspx");
        }

        private int ObtenerId()
        {
            try
            {
                List<Direccion> listaSession = (List<Direccion>)Session["listaDirecciones"];
                int ultimoId = 0;

                if (listaSession.Any())
                {
                    ultimoId = listaSession.Max(x => x.Id);
                }

                return ultimoId + 1;

            }
            catch (Exception ex)
            {
                throw new Exception("Erro al obtener el ID: " + ex.Message, ex);
            }
        } 
    }
}