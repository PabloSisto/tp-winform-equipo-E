namespace WindowsFormsApp1
{
    partial class FrmModificarArticulo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblModificarArticulo = new System.Windows.Forms.Label();
            this.lblModificarCodigo = new System.Windows.Forms.Label();
            this.txtModificarCodigo = new System.Windows.Forms.TextBox();
            this.lblModificarNombre = new System.Windows.Forms.Label();
            this.lblModificarMarca = new System.Windows.Forms.Label();
            this.lblModificarCategoria = new System.Windows.Forms.Label();
            this.lblModificarPrecio = new System.Windows.Forms.Label();
            this.lblModificarDescripcion = new System.Windows.Forms.Label();
            this.lblModificarImagenes = new System.Windows.Forms.Label();
            this.txtModificarNombre = new System.Windows.Forms.TextBox();
            this.cmbModificarMarca = new System.Windows.Forms.ComboBox();
            this.cmbModificarCategoria = new System.Windows.Forms.ComboBox();
            this.txtModificarPrecio = new System.Windows.Forms.TextBox();
            this.txtModificarDescripcion = new System.Windows.Forms.TextBox();
            this.txtModificarImagen = new System.Windows.Forms.TextBox();
            this.lstModificarImagenes = new System.Windows.Forms.ListBox();
            this.picModificarImagen = new System.Windows.Forms.PictureBox();
            this.btnModificarAgregarImagen = new System.Windows.Forms.Button();
            this.btnModificarQuitarImagen = new System.Windows.Forms.Button();
            this.btnAceptarModificarArticulo = new System.Windows.Forms.Button();
            this.btnCancelarModificarArticulo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picModificarImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblModificarArticulo
            // 
            this.lblModificarArticulo.AutoSize = true;
            this.lblModificarArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificarArticulo.Location = new System.Drawing.Point(40, 25);
            this.lblModificarArticulo.Name = "lblModificarArticulo";
            this.lblModificarArticulo.Size = new System.Drawing.Size(153, 20);
            this.lblModificarArticulo.TabIndex = 0;
            this.lblModificarArticulo.Text = "Modificar Articulo:";
            // 
            // lblModificarCodigo
            // 
            this.lblModificarCodigo.AutoSize = true;
            this.lblModificarCodigo.Location = new System.Drawing.Point(44, 62);
            this.lblModificarCodigo.Name = "lblModificarCodigo";
            this.lblModificarCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblModificarCodigo.TabIndex = 1;
            this.lblModificarCodigo.Text = "Codigo:";
            // 
            // txtModificarCodigo
            // 
            this.txtModificarCodigo.Location = new System.Drawing.Point(110, 62);
            this.txtModificarCodigo.Name = "txtModificarCodigo";
            this.txtModificarCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtModificarCodigo.TabIndex = 2;
            // 
            // lblModificarNombre
            // 
            this.lblModificarNombre.AutoSize = true;
            this.lblModificarNombre.Location = new System.Drawing.Point(47, 93);
            this.lblModificarNombre.Name = "lblModificarNombre";
            this.lblModificarNombre.Size = new System.Drawing.Size(47, 13);
            this.lblModificarNombre.TabIndex = 3;
            this.lblModificarNombre.Text = "Nombre:";
            // 
            // lblModificarMarca
            // 
            this.lblModificarMarca.AutoSize = true;
            this.lblModificarMarca.Location = new System.Drawing.Point(47, 124);
            this.lblModificarMarca.Name = "lblModificarMarca";
            this.lblModificarMarca.Size = new System.Drawing.Size(40, 13);
            this.lblModificarMarca.TabIndex = 4;
            this.lblModificarMarca.Text = "Marca:";
            // 
            // lblModificarCategoria
            // 
            this.lblModificarCategoria.AutoSize = true;
            this.lblModificarCategoria.Location = new System.Drawing.Point(47, 156);
            this.lblModificarCategoria.Name = "lblModificarCategoria";
            this.lblModificarCategoria.Size = new System.Drawing.Size(55, 13);
            this.lblModificarCategoria.TabIndex = 5;
            this.lblModificarCategoria.Text = "Categoria:";
            // 
            // lblModificarPrecio
            // 
            this.lblModificarPrecio.AutoSize = true;
            this.lblModificarPrecio.Location = new System.Drawing.Point(47, 186);
            this.lblModificarPrecio.Name = "lblModificarPrecio";
            this.lblModificarPrecio.Size = new System.Drawing.Size(40, 13);
            this.lblModificarPrecio.TabIndex = 6;
            this.lblModificarPrecio.Text = "Precio:";
            // 
            // lblModificarDescripcion
            // 
            this.lblModificarDescripcion.AutoSize = true;
            this.lblModificarDescripcion.Location = new System.Drawing.Point(47, 219);
            this.lblModificarDescripcion.Name = "lblModificarDescripcion";
            this.lblModificarDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblModificarDescripcion.TabIndex = 7;
            this.lblModificarDescripcion.Text = "Descripcion:";
            // 
            // lblModificarImagenes
            // 
            this.lblModificarImagenes.AutoSize = true;
            this.lblModificarImagenes.Location = new System.Drawing.Point(47, 290);
            this.lblModificarImagenes.Name = "lblModificarImagenes";
            this.lblModificarImagenes.Size = new System.Drawing.Size(53, 13);
            this.lblModificarImagenes.TabIndex = 8;
            this.lblModificarImagenes.Text = "Imagenes";
            // 
            // txtModificarNombre
            // 
            this.txtModificarNombre.Location = new System.Drawing.Point(110, 93);
            this.txtModificarNombre.Name = "txtModificarNombre";
            this.txtModificarNombre.Size = new System.Drawing.Size(100, 20);
            this.txtModificarNombre.TabIndex = 9;
            // 
            // cmbModificarMarca
            // 
            this.cmbModificarMarca.FormattingEnabled = true;
            this.cmbModificarMarca.Location = new System.Drawing.Point(110, 124);
            this.cmbModificarMarca.Name = "cmbModificarMarca";
            this.cmbModificarMarca.Size = new System.Drawing.Size(121, 21);
            this.cmbModificarMarca.TabIndex = 10;
            // 
            // cmbModificarCategoria
            // 
            this.cmbModificarCategoria.FormattingEnabled = true;
            this.cmbModificarCategoria.Location = new System.Drawing.Point(110, 156);
            this.cmbModificarCategoria.Name = "cmbModificarCategoria";
            this.cmbModificarCategoria.Size = new System.Drawing.Size(121, 21);
            this.cmbModificarCategoria.TabIndex = 11;
            // 
            // txtModificarPrecio
            // 
            this.txtModificarPrecio.Location = new System.Drawing.Point(110, 186);
            this.txtModificarPrecio.Name = "txtModificarPrecio";
            this.txtModificarPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtModificarPrecio.TabIndex = 12;
            // 
            // txtModificarDescripcion
            // 
            this.txtModificarDescripcion.Location = new System.Drawing.Point(110, 219);
            this.txtModificarDescripcion.Multiline = true;
            this.txtModificarDescripcion.Name = "txtModificarDescripcion";
            this.txtModificarDescripcion.Size = new System.Drawing.Size(297, 61);
            this.txtModificarDescripcion.TabIndex = 13;
            // 
            // txtModificarImagen
            // 
            this.txtModificarImagen.Location = new System.Drawing.Point(110, 290);
            this.txtModificarImagen.Name = "txtModificarImagen";
            this.txtModificarImagen.Size = new System.Drawing.Size(189, 20);
            this.txtModificarImagen.TabIndex = 14;
            // 
            // lstModificarImagenes
            // 
            this.lstModificarImagenes.FormattingEnabled = true;
            this.lstModificarImagenes.Location = new System.Drawing.Point(110, 354);
            this.lstModificarImagenes.Name = "lstModificarImagenes";
            this.lstModificarImagenes.Size = new System.Drawing.Size(189, 121);
            this.lstModificarImagenes.TabIndex = 15;
            // 
            // picModificarImagen
            // 
            this.picModificarImagen.Location = new System.Drawing.Point(325, 301);
            this.picModificarImagen.Name = "picModificarImagen";
            this.picModificarImagen.Size = new System.Drawing.Size(149, 165);
            this.picModificarImagen.TabIndex = 16;
            this.picModificarImagen.TabStop = false;
            // 
            // btnModificarAgregarImagen
            // 
            this.btnModificarAgregarImagen.Location = new System.Drawing.Point(110, 319);
            this.btnModificarAgregarImagen.Name = "btnModificarAgregarImagen";
            this.btnModificarAgregarImagen.Size = new System.Drawing.Size(75, 23);
            this.btnModificarAgregarImagen.TabIndex = 17;
            this.btnModificarAgregarImagen.Text = "Agregar";
            this.btnModificarAgregarImagen.UseVisualStyleBackColor = true;
            // 
            // btnModificarQuitarImagen
            // 
            this.btnModificarQuitarImagen.Location = new System.Drawing.Point(224, 319);
            this.btnModificarQuitarImagen.Name = "btnModificarQuitarImagen";
            this.btnModificarQuitarImagen.Size = new System.Drawing.Size(75, 23);
            this.btnModificarQuitarImagen.TabIndex = 18;
            this.btnModificarQuitarImagen.Text = "Quitar";
            this.btnModificarQuitarImagen.UseVisualStyleBackColor = true;
            // 
            // btnAceptarModificarArticulo
            // 
            this.btnAceptarModificarArticulo.Location = new System.Drawing.Point(110, 500);
            this.btnAceptarModificarArticulo.Name = "btnAceptarModificarArticulo";
            this.btnAceptarModificarArticulo.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarModificarArticulo.TabIndex = 19;
            this.btnAceptarModificarArticulo.Text = "Aceptar";
            this.btnAceptarModificarArticulo.UseVisualStyleBackColor = true;
            // 
            // btnCancelarModificarArticulo
            // 
            this.btnCancelarModificarArticulo.Location = new System.Drawing.Point(198, 500);
            this.btnCancelarModificarArticulo.Name = "btnCancelarModificarArticulo";
            this.btnCancelarModificarArticulo.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarModificarArticulo.TabIndex = 20;
            this.btnCancelarModificarArticulo.Text = "Cancelar";
            this.btnCancelarModificarArticulo.UseVisualStyleBackColor = true;
            // 
            // FrmModificarArticulo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(516, 535);
            this.Controls.Add(this.btnCancelarModificarArticulo);
            this.Controls.Add(this.btnAceptarModificarArticulo);
            this.Controls.Add(this.btnModificarQuitarImagen);
            this.Controls.Add(this.btnModificarAgregarImagen);
            this.Controls.Add(this.picModificarImagen);
            this.Controls.Add(this.lstModificarImagenes);
            this.Controls.Add(this.txtModificarImagen);
            this.Controls.Add(this.txtModificarDescripcion);
            this.Controls.Add(this.txtModificarPrecio);
            this.Controls.Add(this.cmbModificarCategoria);
            this.Controls.Add(this.cmbModificarMarca);
            this.Controls.Add(this.txtModificarNombre);
            this.Controls.Add(this.lblModificarImagenes);
            this.Controls.Add(this.lblModificarDescripcion);
            this.Controls.Add(this.lblModificarPrecio);
            this.Controls.Add(this.lblModificarCategoria);
            this.Controls.Add(this.lblModificarMarca);
            this.Controls.Add(this.lblModificarNombre);
            this.Controls.Add(this.txtModificarCodigo);
            this.Controls.Add(this.lblModificarCodigo);
            this.Controls.Add(this.lblModificarArticulo);
            this.Name = "FrmModificarArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Articulo";
            ((System.ComponentModel.ISupportInitialize)(this.picModificarImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblModificarArticulo;
        private System.Windows.Forms.Label lblModificarCodigo;
        private System.Windows.Forms.TextBox txtModificarCodigo;
        private System.Windows.Forms.Label lblModificarNombre;
        private System.Windows.Forms.Label lblModificarMarca;
        private System.Windows.Forms.Label lblModificarCategoria;
        private System.Windows.Forms.Label lblModificarPrecio;
        private System.Windows.Forms.Label lblModificarDescripcion;
        private System.Windows.Forms.Label lblModificarImagenes;
        private System.Windows.Forms.TextBox txtModificarNombre;
        private System.Windows.Forms.ComboBox cmbModificarMarca;
        private System.Windows.Forms.ComboBox cmbModificarCategoria;
        private System.Windows.Forms.TextBox txtModificarPrecio;
        private System.Windows.Forms.TextBox txtModificarDescripcion;
        private System.Windows.Forms.TextBox txtModificarImagen;
        private System.Windows.Forms.ListBox lstModificarImagenes;
        private System.Windows.Forms.PictureBox picModificarImagen;
        private System.Windows.Forms.Button btnModificarAgregarImagen;
        private System.Windows.Forms.Button btnModificarQuitarImagen;
        private System.Windows.Forms.Button btnAceptarModificarArticulo;
        private System.Windows.Forms.Button btnCancelarModificarArticulo;
    }
}