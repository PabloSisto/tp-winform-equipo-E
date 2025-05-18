using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmCategoria : Form
    {
        private Categoria categoria = null;
        List<Categoria> categoriaList;
        public FrmCategoria()
        {
            InitializeComponent();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();

            try
            {
                categoriaList = negocio.listar();
                dgvCat.DataSource = categoriaList;
                dgvCat.Columns["IdCategoria"].Visible = false;
                dgvCat.RowHeadersVisible = false;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            Categoria seleccionado;
            DialogResult respuesta = MessageBox.Show("¿Eliminar Categoria?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (respuesta == DialogResult.Yes)
            {
                seleccionado = (Categoria)dgvCat.CurrentRow.DataBoundItem;
                negocio.eliminar(seleccionado.Descripcion);
                dgvCat.DataSource = dgvCat;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();

            try
            {
                if (categoria == null)
                {
                    Categoria categoria = new Categoria();
                    categoria.Descripcion = txtAgregar.Text;


                    negocio.agregar(categoria);
                    MessageBox.Show("agregado exitosamente..");
                    dgvCat.DataSource = dgvCat;

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }
    }
}
