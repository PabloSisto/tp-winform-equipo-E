using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Dominio
{
    public class Imagenes
    {
        public int IdImagen { get; set; }
        public string Url { get; set; }
        public Articulo articulo { get; set; }
        
    }
}
