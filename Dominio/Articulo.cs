using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulo
    {
        public int IdArticulos { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public double precio { get; set; }

        public string MarcaDescripcion { get; set; }
        public string CategoriaDescripcion { get; set; }
        public Marca Marca {  get; set; }
        public Categoria Categoria { get; set; }
        public List<Imagen> Imagenes { get; set; }

        public string ImagenUrl { get; set; }   
    }
}
