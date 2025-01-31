using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class CategoriaNegocio
    {
        public List<Categoria> ListarCategorias()
        {
            AccesoDatos datos = new AccesoDatos();
            List<Categoria> lista = new List<Categoria>();
            datos.setearConsulta("select * from Categoria");
            try
            {
                datos.ejecutarAccion();
                while (datos.Lector.Read())
                {
                    Categoria categoria = new Categoria();

                    categoria.id_categoria = (int)datos.Lector["id_categoria"];
                    categoria.nombre = (string)datos.Lector["nombre"];

                    lista.Add(categoria);

                }
                return lista;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                datos.cerrarConexion();
            }

        }
    }
}
