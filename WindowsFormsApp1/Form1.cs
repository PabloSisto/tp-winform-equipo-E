using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmArticulo : Form
    {
        public FrmArticulo()
        {
            InitializeComponent();
        }

        private void msAdmiistrarCategorias_Click(object sender, EventArgs e)
        {
            FrmCategoria ventanaCategoria = new FrmCategoria();
            ventanaCategoria.ShowDialog();
        }

        private void administrarMarcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMarca ventanaMarca = new FrmMarca();
            ventanaMarca.ShowDialog();
        }
    }
}
