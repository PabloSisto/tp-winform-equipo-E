using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> listas = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            ImagenNegocio imagenNegocio = new ImagenNegocio();
            try
            {

               // datos.setearConsulta("SELECT a.Id,  a.Codigo, a.Nombre, a.Descripcion, a.Precio,  m.Descripcion   AS MarcaDescripcion, c.Descripcion   AS CategoriaDescripcion, i.ImagenUrl FROM ARTICULOS a INNER JOIN MARCAS m ON m.Id = a.IdMarca INNER JOIN CATEGORIAS  c ON c.Id = a.IdCategoria LEFT  JOIN IMAGENES    i ON i.IdArticulo = a.Id;");

                datos.setearConsulta(@"Select a.Id, a.Codigo, a.Nombre, a.Descripcion,a.Precio, 
                    c.Id IdCategoria, c.Descripcion CategoriaDescripcion,m.Id IdMarca, m.Descripcion MarcaDescripcion 
                    from ARTICULOS a inner join CATEGORIAS c on a.IdCategoria = c.Id 
                    inner join MARCAS m on a.IdMarca = m.Id");


                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {

                    Articulo articulo = new Articulo
                    {
                        IdArticulos = (int)datos.Lector["Id"],
                        Codigo = (string)datos.Lector["Codigo"],
                        Nombre = (string)datos.Lector["Nombre"],
                        Descripcion = (string)datos.Lector["Descripcion"],
                        precio = Convert.ToDouble(datos.Lector["Precio"]),
                        Categoria = new Categoria
                        {
                            IdCategoria = (int)datos.Lector["IdCategoria"],
                            Descripcion = (string)datos.Lector["CategoriaDescripcion"]
                        },
                        Marca = new Marca
                        {
                            IdMarca = (int)datos.Lector["IdMarca"],
                            Descripcion = (string)datos.Lector["MarcaDescripcion"]
                        },
                        MarcaDescripcion = (string)datos.Lector["MarcaDescripcion"],
                        CategoriaDescripcion = (string)datos.Lector["CategoriaDescripcion"],
                        Imagenes = imagenNegocio.ListarPorIdArticulo((int)datos.Lector["Id"])
                        
                    };
                    //articulo.ImagenUrl = articulo.Imagenes[0].Url;
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
            ImagenNegocio imagenNegocio = new ImagenNegocio();
            try
            {

                datos.setearConsulta(@"Select a.Id, a.Codigo, a.Nombre, a.Descripcion,a.Precio, 
                    c.Id IdCategoria, c.Descripcion CategoriaDescripcion,m.Id IdMarca, m.Descripcion MarcaDescripcion 
                    from ARTICULOS a inner join CATEGORIAS c on a.IdCategoria = c.Id 
                    inner join MARCAS m on a.IdMarca = m.Id 
                    WHERE a.Nombre LIKE @filtro;");

                datos.Comando.Parameters.Clear();
                datos.Comando.Parameters.AddWithValue("@filtro", $"%{texto}%");

                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo articulo = new Articulo
                    {
                        IdArticulos = (int)datos.Lector["Id"],
                        Codigo = (string)datos.Lector["Codigo"],
                        Nombre = (string)datos.Lector["Nombre"],
                        Descripcion = (string)datos.Lector["Descripcion"],
                        precio = Convert.ToDouble(datos.Lector["Precio"]),
                        MarcaDescripcion = (string)datos.Lector["MarcaDescripcion"],
                        CategoriaDescripcion = (string)datos.Lector["CategoriaDescripcion"],
                        Categoria = new Categoria
                        {
                            IdCategoria = (int)datos.Lector["IdCategoria"],
                            Descripcion = (string)datos.Lector["CategoriaDescripcion"]
                        },
                        Marca = new Marca
                        {
                            IdMarca = (int)datos.Lector["IdMarca"],
                            Descripcion = (string)datos.Lector["MarcaDescripcion"]
                        },
                        Imagenes = imagenNegocio.ListarPorIdArticulo((int)datos.Lector["Id"])
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

        public List<Articulo> buscarPorCodigo(string codigo)
        {
            List<Articulo> listas = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            ImagenNegocio imagenNegocio = new ImagenNegocio();
            try
            {
                /*
                datos.setearConsulta("SELECT a.Codigo, a.Nombre, a.Descripcion, a.Precio, "
                    + "m.Descripcion AS MarcaDescripcion, "
                    + "c.Descripcion AS CategoriaDescripcion "
                    + "FROM ARTICULOS a "
                    + "INNER JOIN MARCAS m ON m.Id = a.IdMarca "
                    + "INNER JOIN CATEGORIAS c ON c.Id = a.IdCategoria "
                    + "WHERE a.Codigo LIKE @filtro;");
                */
                datos.setearConsulta(@"Select a.Id, a.Codigo, a.Nombre, a.Descripcion,a.Precio, 
                    c.Id IdCategoria, c.Descripcion CategoriaDescripcion,m.Id IdMarca, m.Descripcion MarcaDescripcion 
                    from ARTICULOS a inner join CATEGORIAS c on a.IdCategoria = c.Id 
                    inner join MARCAS m on a.IdMarca = m.Id 
                    WHERE a.Codigo LIKE @filtro;");

                datos.Comando.Parameters.Clear();
                datos.Comando.Parameters.AddWithValue("@filtro", $"%{codigo}%");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo articulo = new Articulo
                    {
                        IdArticulos = (int)datos.Lector["Id"],
                        Codigo = (string)datos.Lector["Codigo"],
                        Nombre = (string)datos.Lector["Nombre"],
                        Descripcion = (string)datos.Lector["Descripcion"],
                        precio = Convert.ToDouble(datos.Lector["Precio"]),
                        Categoria = new Categoria
                        {
                            IdCategoria = (int)datos.Lector["IdCategoria"],
                            Descripcion = (string)datos.Lector["CategoriaDescripcion"]
                        },
                        Marca = new Marca
                        {
                            IdMarca = (int)datos.Lector["IdMarca"],
                            Descripcion = (string)datos.Lector["MarcaDescripcion"]
                        },
                        MarcaDescripcion = (string)datos.Lector["MarcaDescripcion"],
                        CategoriaDescripcion = (string)datos.Lector["CategoriaDescripcion"],
                        Imagenes = imagenNegocio.ListarPorIdArticulo((int)datos.Lector["Id"])
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

        public void eliminar(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("delete from ARTICULOS where id = @Id");
                datos.Comando.Parameters.AddWithValue("@id", id);
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
           

        public int AgregarArticulo(Articulo articulo)
        {
            int id;
            AccesoDatos bd = new AccesoDatos();

            try
            {
                bd.setearConsulta(@"INSERT INTO ARTICULOS (Codigo,Nombre,Descripcion,Precio,IdCategoria,IdMarca)
                                    OUTPUT INSERTED.Id 
                                    VALUES (@Codigo, @Nombre, @Descripcion ,@Precio , @IdCategoria, @IdMarca)");
                bd.setearParametro("@Codigo", articulo.Codigo);
                bd.setearParametro("@Nombre", articulo.Nombre);
                bd.setearParametro("@Descripcion", articulo.Descripcion);
                bd.setearParametro("@Precio", articulo.precio);
                bd.setearParametro("@IdCategoria", articulo.Categoria.IdCategoria);
                bd.setearParametro("@IdMarca", articulo.Marca.IdMarca);

                id = bd.EjecutarAccionYTraerId();

                return id;

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

        public void ModificarArticulo(Articulo articulo)
        {
            AccesoDatos bd = new AccesoDatos();

            try
            {
                bd.setearConsulta(@"UPDATE ARTICULOS 
                                    SET Codigo = @Codigo, Nombre = @Nombre, Descripcion = @Descripcion, IdMarca = @IdMarca, IdCategoria = @IdCategoria, Precio = @Precio
                                    WHERE Id = @IdArticulo;");
                bd.setearParametro("@IdArticulo", articulo.IdArticulos);
                bd.setearParametro("@Codigo", articulo.Codigo);
                bd.setearParametro("@Nombre", articulo.Nombre);
                bd.setearParametro("@Descripcion", articulo.Descripcion);
                bd.setearParametro("@IdMarca", articulo.Marca.IdMarca);
                bd.setearParametro("@IdCategoria", articulo.Categoria.IdCategoria);
                bd.setearParametro("@Precio", articulo.precio);

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

        public string obtenerDescripcion(string codigo)
        {
            AccesoDatos datos = new AccesoDatos();
            String descripcion;

            try
            {
                datos.setearConsulta("SELECT Descripcion FROM ARTICULOS WHERE Codigo = @codigo;");
                datos.Comando.Parameters.Clear();
                datos.Comando.Parameters.AddWithValue("@codigo", codigo);
                datos.ejecutarLectura();

                if (datos.Lector.Read())
                {
                    // descripcion = (string)datos.Lector["Descripcion"];
                    //   return descripcion;

                    return datos.Lector["Descripcion"].ToString();
                }
                ;

                return "Este articulo no tiene descripcion";
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