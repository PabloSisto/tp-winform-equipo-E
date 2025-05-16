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
        Articulo a = new Articulo();

        public List<Articulo> listar()
        {
            List<Articulo> listas = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta( "SELECT a.Codigo,a.Nombre,a.Descripcion,a.Precio,"
                    + "m.Descripcion AS MarcaDescripcion,"
                    + "c.Descripcion AS CategoriaDescripcion "
                    + "FROM ARTICULOS a "
                    + "INNER JOIN MARCAS m ON m.Id = a.IdMarca "
                    + "INNER JOIN CATEGORIAS c ON c.Id = a.IdCategoria;");

                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    var articulo = new Articulo
                    {
                        Codigo = (string)datos.Lector["Codigo"],
                        Nombre = (string)datos.Lector["Nombre"],
                        Descripcion = (string)datos.Lector["Descripcion"],
                        precio = Convert.ToDouble(datos.Lector["Precio"]),
                        MarcaDescripcion = (string)datos.Lector["MarcaDescripcion"],
                        CategoriaDescripcion = (string)datos.Lector["CategoriaDescripcion"]
                    };
                    
                    listas.Add(articulo);
                }

                return listas;
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

        public List<Articulo> buscarPorNombre(String texto)
        {
            List<Articulo> listas = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta(" SELECT a.Codigo, a.Nombre, a.Descripcion, a.Precio, " 
                    + " m.Descripcion AS MarcaDescripcion, "
                    + " c.Descripcion AS CategoriaDescripcion "
                    + " FROM ARTICULOS a "
                    + " INNER JOIN MARCAS m ON m.Id = a.IdMarca "
                    + " INNER JOIN CATEGORIAS c ON c.Id = a.IdCategoria "
                    + " WHERE a.Nombre LIKE @filtro; ");

                datos.Comando.Parameters.Clear();
                datos.Comando.Parameters.AddWithValue("@filtro", $"%{texto}%");

                datos.ejecutarLectura();

                while(datos.Lector.Read())
                {
                    Articulo articulo = new Articulo()
                    {
                       Codigo = (string)datos.Lector["Codigo"],
                       Nombre = (string)datos.Lector["Nombre"],
                       Descripcion = (string)datos.Lector["Descripcion"],
                       precio = Convert.ToDouble(datos.Lector["Precio"]),
                       MarcaDescripcion = (string)datos.Lector["MarcaDescripcion"],
                       CategoriaDescripcion = (string)datos.Lector["CategoriaDescripcion"]
                    };
                    listas.Add(articulo);
                }

                return listas;
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
