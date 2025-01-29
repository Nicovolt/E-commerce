using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
namespace Negocio
{
    internal class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();


            try
            {
                datos.setearConsulta("SELECT id_articulo, nombre, precio, stock, id_marca, id_categoria FROM Articulo");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.IdArticulo = (int)datos.Lector["id_articulo"];
                    aux.Nombre = (string)datos.Lector["nombre"];
                    aux.precio = (decimal)datos.Lector["precio"];
                    aux.Stock = (int)datos.Lector["stock"];
                    aux.IDmarca = (int)datos.Lector["id_marca"];
                    aux.IDcategoria = (int)datos.Lector["id_categoria"];

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

    }
}
