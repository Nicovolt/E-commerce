using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecommerce_re
{
    public partial class Formulario_web11 : System.Web.UI.Page
    {

        public List<Articulo> listarArticulo {  get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            listarArticulo = negocio.listar();
            repArticulos.DataSource = listarArticulo;
            repArticulos.DataBind();
        }

        protected void repArticulos_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

        }
    }
}