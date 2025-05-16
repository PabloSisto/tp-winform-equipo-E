using System;
using System.Collections;
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
            FrmDatosArticulo ventanaAgregarArticulo = new FrmDatosArticulo();
            ventanaAgregarArticulo.ShowDialog();
        }

        private void btnModificarArt_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void FrmArticulo_Load(object sender, EventArgs e)
        {
            
            txtBuscar.Enabled = !rbTodos.Checked;

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            List<Articulo> listas;   
            
            if(rbTodos.Checked)
            {
                listas = negocio.listar();

            } else if(rbnombre.Checked)
            {
                listas = negocio.buscarPorNombre(txtBuscar.Text);
            }
            else
            {
                MessageBox.Show("Seleccione algun criterio para buscar.");
                return;
            }

            dgvArticulo.DataSource = listas;
            dgvArticulo.RowHeadersVisible = false;
            dgvArticulo.Columns["IdArticulos"].Visible = false;   //saco estas columnas del dgv
            dgvArticulo.Columns["Descripcion"].Visible = false;   
            dgvArticulo.Columns["MarcaDescripcion"].HeaderText = "Marca"; //renombro las columnas para el dgv
            dgvArticulo.Columns["CategoriaDescripcion"].HeaderText = "Categoría";

        }

        private void rbTodos_CheckedChanged(object sender, EventArgs e)
        {
           // txtBuscar.Enabled = !rbTodos.Checked;

            if (rbTodos.Checked)
            {
                txtBuscar.Enabled = false;
                txtBuscar.Text = "";
            }
            else if (rbnombre.Checked)
            {
                txtBuscar.Enabled = true;
                dgvArticulo.DataSource = null;
            }
            else if (rbCodigo.Checked)
            {
                txtBuscar.Enabled= true;
                dgvArticulo.DataSource = null;
            }
        }
    }
}
