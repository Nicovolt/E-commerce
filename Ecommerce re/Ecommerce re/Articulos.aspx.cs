using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace Ecommerce_re
{
    public partial class Formulario_web1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
            CargarCombos();
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
            Articulo art = new Articulo();
            ArticuloNegocio negocio = new ArticuloNegocio();

            art.Nombre = txtNombre.Text;
            art.Descripcion = txtDescripcion.Text;
            art.precio = decimal.Parse(txtPrecio.Text);
            art.IDcategoria = int.Parse(ddlCategoria.SelectedValue);
            art.IDmarca = int.Parse(ddlMarca.SelectedValue);
            art.Stock = int.Parse(txtStock.Text);

                negocio.Agregar(art);

                MostrarExito("Producto agregado exitosamente");
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void CargarCombos()
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            ddlCategoria.DataSource = categoriaNegocio.ListarCategorias();
            ddlCategoria.DataTextField = "nombre";
            ddlCategoria.DataValueField = "id_categoria";
            ddlCategoria.DataBind();
            ddlCategoria.Items.Insert(0, new ListItem("Seleccione una categoria", ""));

            MarcaNegocio MarcaNegocio = new MarcaNegocio();
            ddlMarca.DataSource = MarcaNegocio.ListarMarcas();
            ddlMarca.DataTextField = "nombre";
            ddlMarca.DataValueField = "id_marca";
            ddlMarca.DataBind();
            ddlMarca.Items.Insert(0, new ListItem("Seleccione una marca", ""));
        }

        private void MostrarExito(string mensaje)
        {
            ScriptManager.RegisterStartupScript(this, GetType(), "success",
               $"Swal.fire({{" +
               $"  icon: 'success'," +
               $"  title: '¡Éxito!'," +
               $"  text: '{mensaje}'," +
               $"  confirmButtonColor: '#3085d6'" +
               $"}}).then((result) => {{" +
               $"  if (result.isConfirmed) {{" +
               $"    window.location = 'Default.aspx';" +
               $"  }}" +
               $"}});", true);
        }

    }
}