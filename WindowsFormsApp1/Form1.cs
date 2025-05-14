using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

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

        private void btnAgregarArt_Click(object sender, EventArgs e)
        {
            FrmAgregarArticulo ventanaAgregarArticulo = new FrmAgregarArticulo();
            ventanaAgregarArticulo.ShowDialog();
        }

        private void btnModificarArt_Click(object sender, EventArgs e)
        {
            FrmModificarArticulo ventanaModificarArticulo = new FrmModificarArticulo();
            ventanaModificarArticulo.ShowDialog();
        }

        private void FrmArticulo_Load(object sender, EventArgs e)
        {
            //FrmAgregarArticulo v = new FrmAgregarArticulo();
            //v.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(rbTodos.Checked)
            {
                ArticuloNegocio negocio = new ArticuloNegocio();
                List<Articulo> lista = negocio.listar();

                MessageBox.Show($"Se recuperaron {lista.Count} artículos.");
                dgvArticulo.DataSource = lista;

                dgvArticulo.Columns["Descripcion"].Visible = false;
                dgvArticulo.Columns["marca"].Visible = false;
                dgvArticulo.Columns["categoria"].Visible = false;

            }

        }
    }
}
