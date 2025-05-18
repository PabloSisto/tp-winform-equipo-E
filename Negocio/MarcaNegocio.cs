using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class MarcaNegocio
    {
        public List<Marca> listar()
        {
            List<Marca> marcas = new List<Marca>();
            AccesoDatos db = new AccesoDatos();

            try
            {
                db.setearConsulta("SELECT Id, Descripcion FROM MARCAS;");
                db.ejecutarLectura();

                while (db.Lector.Read())
                {
                    Marca marca = new Marca();
                    marca.IdMarca = (int)db.Lector["Id"];
                    marca.Descripcion = (string)db.Lector["Descripcion"];
                    
                    marcas.Add(marca);
                }

                return marcas;
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
        public void agregar(Marca nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("insert into MARCAS(Descripcion) values('" + nuevo.Descripcion + "')");


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
                datos.setearConsulta("delete from Marcas where descripcion = @descripcion");
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
