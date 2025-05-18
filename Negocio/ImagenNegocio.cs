using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class ImagenNegocio
    {
        public List<Imagen> ListarPorIdArticulo(int IdArticulo)
        {
            List<Imagen> imagenes = new List<Imagen>();
            AccesoDatos bd = new AccesoDatos();

            try
            {
                bd.setearConsulta("select Id,ImagenUrl from IMAGENES WHERE IdArticulo = @IdArticulo;");
                bd.setearParametro("@IdArticulo", IdArticulo);
                bd.ejecutarLectura();

                while (bd.Lector.Read())
                {
                    Imagen imagen = new Imagen()
                    {
                        IdImagen = (int)bd.Lector["Id"],
                        Url = (string)bd.Lector["ImagenUrl"]
                    };

                    imagenes.Add(imagen);
                }
                return imagenes;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                bd.cerrarConexion();
            }
        }
        
        
        //Inserta a BD las url de las imagenes de un articulo
        public void AgregarImagenes( List<Imagen> imagenes)
        {

            if (imagenes == null || !imagenes.Any())
                return;

            AccesoDatos bd = new AccesoDatos();

            try
            {
                foreach (Imagen imagen in imagenes)
                {
                    bd.setearConsulta(@"INSERT INTO IMAGENES (IdArticulo, ImagenUrl) 
                                    VALUES (@IdArticulo, @UrlImagen)");
                    bd.setearParametro("@IdArticulo", imagen.IdArticulo);
                    bd.setearParametro("@UrlImagen", imagen.Url);
                    bd.ejecutarAccion();

                    bd.limpiarParametros();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally 
            {
                bd.cerrarConexion();
            };

        }

        public void ModificarImagenes(List<Imagen> imagenes, int idArticulo)
        {
            try
            {
                EliminarImagenesDeArticulo(idArticulo);
                AgregarImagenes(imagenes);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void EliminarImagenesDeArticulo(int idArticulo)
        {
            AccesoDatos bd = new AccesoDatos();

            try
            {
                bd.setearConsulta("DELETE FROM IMAGENES WHERE IdArticulo = @idArticulo;");
                bd.setearParametro("@idArticulo", idArticulo);
                bd.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                bd.cerrarConexion();
            }
        }
    }
}
