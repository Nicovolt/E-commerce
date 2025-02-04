using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
namespace Negocio
{
    public class ArticuloNegocio
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
                    aux.IDmarca= datos.Lector["id_marca"] != DBNull.Value ? (int)datos.Lector["id_marca"] : 0;
                    aux.IDcategoria = datos.Lector["id_categoria"] != DBNull.Value ? (int)datos.Lector["id_categoria"] : 0;

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

        public void Agregar(Articulo art)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {

            datos.setearConsulta("insert into Articulo(nombre,descripcion,precio,id_categoria,stock) values(@nombre,@descip,@precio,@idCat,@stock);");
            datos.setearParametro("@nombre", art.Nombre);
            datos.setearParametro("@descip", art.Descripcion);
            datos.setearParametro("@precio", art.precio);
            datos.setearParametro("@idCat", art.IDcategoria);
            datos.setearParametro("@stock", art.Stock);

            datos.ejecutarLectura();

            }
            catch (Exception ex)
            {

                throw new Exception("Error al agregar el producto: " + ex.Message);
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

    }
}
