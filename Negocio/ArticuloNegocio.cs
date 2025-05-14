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
                datos.setearConsulta("select id, Codigo, nombre, precio from ARTICULOS;");
                datos.ejecutarLectura();

                while(datos.Lector.Read())
                {
                    Articulo articulo = new Articulo();
                    articulo.IdArticulos = (int)datos.Lector["id"];
                    articulo.Codigo = (string)datos.Lector["Codigo"];
                    articulo.Nombre = (string)datos.Lector["nombre"];
                    articulo.precio = Convert.ToDouble(datos.Lector["precio"]);

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
