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
        public List<Categoria> listar()
        {
            List<Categoria> categorias = new List<Categoria>();
            AccesoDatos db = new AccesoDatos();

            try
            {
                db.setearConsulta("SELECT Id, Descripcion FROM CATEGORIAS;");
                db.ejecutarLectura();

                while (db.Lector.Read())
                {
                    Categoria categoria = new Categoria();
                    categoria.IdCategoria = (int)db.Lector["Id"];
                    categoria.Descripcion = (string)db.Lector["Descripcion"];

                    categorias.Add(categoria);
                }

                return categorias;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                db.cerrarConexion();
            }
        }
        public void agregar(Categoria nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("insert into CATEGORIAS(Descripcion) values('" + nuevo.Descripcion + "')");


                datos.ejecutarAccion();
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
        public void eliminar(string descripcion)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("delete from Categorias where descripcion = @descripcion");
                datos.Comando.Parameters.AddWithValue("@descripcion", descripcion);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
