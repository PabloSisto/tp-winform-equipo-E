using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace WindowsFormsApp1
{
    public partial class FrmDatosArticulo : Form
    {
        public FrmDatosArticulo()
        {
            InitializeComponent();
        }

        private void btnAceptarAgregarArticulo_Click(object sender, EventArgs e)
        {
            //TODO
        }

        

        private void FrmAgregarArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

            try
            {
                picAgregarImagen.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT-ytBNU72ZNhsQfEFpoW2iLtpl80L4ug8AJg&s");
                cmbAgregarCategoria.DataSource = marcaNegocio.listar();
                cmbAgregarMarca.DataSource = categoriaNegocio.listar();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        private void btnCancelarAgregarArticulo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
