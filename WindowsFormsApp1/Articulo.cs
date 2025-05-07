using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Articulo
    {
        private int IdArticulos {  get; }
        private string Codigo { get; set; }
        private string Nombre { get; set; }
        private string Descripcion { get; set; }
        private double precio { get; set; }

        private Marca marca { get; set; }
        private Categoria categoria { get; set; }

    }
}
