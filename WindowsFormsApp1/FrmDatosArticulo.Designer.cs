
namespace WindowsFormsApp1
{
    partial class FrmDatosArticulo
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
            this.lblAgregarArticulo = new System.Windows.Forms.Label();
            this.lblAgregarCodigo = new System.Windows.Forms.Label();
            this.txtAgregarCodigo = new System.Windows.Forms.TextBox();
            this.lblAgregarNombre = new System.Windows.Forms.Label();
            this.lblAgregarMarca = new System.Windows.Forms.Label();
            this.lblAgregarCategoria = new System.Windows.Forms.Label();
            this.lblAgregarPrecio = new System.Windows.Forms.Label();
            this.lblAgregarDescripcion = new System.Windows.Forms.Label();
            this.lblAgregarImagenes = new System.Windows.Forms.Label();
            this.txtAgregarNombre = new System.Windows.Forms.TextBox();
            this.cmbAgregarMarca = new System.Windows.Forms.ComboBox();
            this.cmbAgregarCategoria = new System.Windows.Forms.ComboBox();
            this.txtAgregarPrecio = new System.Windows.Forms.TextBox();
            this.txtAgregarDescripcion = new System.Windows.Forms.TextBox();
            this.txtAgregarImagen = new System.Windows.Forms.TextBox();
            this.picAgregarImagen = new System.Windows.Forms.PictureBox();
            this.btnAgregarImagen = new System.Windows.Forms.Button();
            this.btnQuitarImagen = new System.Windows.Forms.Button();
            this.btnAceptarAgregarArticulo = new System.Windows.Forms.Button();
            this.btnCancelarAgregarArticulo = new System.Windows.Forms.Button();
            this.btnImagenAnterior = new System.Windows.Forms.Button();
            this.btnImagenSiguiente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picAgregarImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAgregarArticulo
            // 
            this.lblAgregarArticulo.AutoSize = true;
            this.lblAgregarArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarArticulo.Location = new System.Drawing.Point(40, 25);
            this.lblAgregarArticulo.Name = "lblAgregarArticulo";
            this.lblAgregarArticulo.Size = new System.Drawing.Size(75, 20);
            this.lblAgregarArticulo.TabIndex = 0;
            this.lblAgregarArticulo.Text = "Articulo:";
            // 
            // lblAgregarCodigo
            // 
            this.lblAgregarCodigo.AutoSize = true;
            this.lblAgregarCodigo.Location = new System.Drawing.Point(47, 62);
            this.lblAgregarCodigo.Name = "lblAgregarCodigo";
            this.lblAgregarCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblAgregarCodigo.TabIndex = 1;
            this.lblAgregarCodigo.Text = "Codigo:";
            // 
            // txtAgregarCodigo
            // 
            this.txtAgregarCodigo.Location = new System.Drawing.Point(119, 62);
            this.txtAgregarCodigo.Name = "txtAgregarCodigo";
            this.txtAgregarCodigo.Size = new System.Drawing.Size(190, 20);
            this.txtAgregarCodigo.TabIndex = 2;
            // 
            // lblAgregarNombre
            // 
            this.lblAgregarNombre.AutoSize = true;
            this.lblAgregarNombre.Location = new System.Drawing.Point(47, 93);
            this.lblAgregarNombre.Name = "lblAgregarNombre";
            this.lblAgregarNombre.Size = new System.Drawing.Size(47, 13);
            this.lblAgregarNombre.TabIndex = 3;
            this.lblAgregarNombre.Text = "Nombre:";
            // 
            // lblAgregarMarca
            // 
            this.lblAgregarMarca.AutoSize = true;
            this.lblAgregarMarca.Location = new System.Drawing.Point(47, 124);
            this.lblAgregarMarca.Name = "lblAgregarMarca";
            this.lblAgregarMarca.Size = new System.Drawing.Size(40, 13);
            this.lblAgregarMarca.TabIndex = 4;
            this.lblAgregarMarca.Text = "Marca:";
            // 
            // lblAgregarCategoria
            // 
            this.lblAgregarCategoria.AutoSize = true;
            this.lblAgregarCategoria.Location = new System.Drawing.Point(47, 156);
            this.lblAgregarCategoria.Name = "lblAgregarCategoria";
            this.lblAgregarCategoria.Size = new System.Drawing.Size(55, 13);
            this.lblAgregarCategoria.TabIndex = 5;
            this.lblAgregarCategoria.Text = "Categoria:";
            // 
            // lblAgregarPrecio
            // 
            this.lblAgregarPrecio.AutoSize = true;
            this.lblAgregarPrecio.Location = new System.Drawing.Point(47, 186);
            this.lblAgregarPrecio.Name = "lblAgregarPrecio";
            this.lblAgregarPrecio.Size = new System.Drawing.Size(40, 13);
            this.lblAgregarPrecio.TabIndex = 6;
            this.lblAgregarPrecio.Text = "Precio:";
            // 
            // lblAgregarDescripcion
            // 
            this.lblAgregarDescripcion.AutoSize = true;
            this.lblAgregarDescripcion.Location = new System.Drawing.Point(47, 219);
            this.lblAgregarDescripcion.Name = "lblAgregarDescripcion";
            this.lblAgregarDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblAgregarDescripcion.TabIndex = 7;
            this.lblAgregarDescripcion.Text = "Descripcion:";
            // 
            // lblAgregarImagenes
            // 
            this.lblAgregarImagenes.AutoSize = true;
            this.lblAgregarImagenes.Location = new System.Drawing.Point(47, 290);
            this.lblAgregarImagenes.Name = "lblAgregarImagenes";
            this.lblAgregarImagenes.Size = new System.Drawing.Size(53, 13);
            this.lblAgregarImagenes.TabIndex = 8;
            this.lblAgregarImagenes.Text = "Imagenes";
            // 
            // txtAgregarNombre
            // 
            this.txtAgregarNombre.Location = new System.Drawing.Point(119, 93);
            this.txtAgregarNombre.Name = "txtAgregarNombre";
            this.txtAgregarNombre.Size = new System.Drawing.Size(190, 20);
            this.txtAgregarNombre.TabIndex = 9;
            // 
            // cmbAgregarMarca
            // 
            this.cmbAgregarMarca.FormattingEnabled = true;
            this.cmbAgregarMarca.Location = new System.Drawing.Point(119, 124);
            this.cmbAgregarMarca.Name = "cmbAgregarMarca";
            this.cmbAgregarMarca.Size = new System.Drawing.Size(190, 21);
            this.cmbAgregarMarca.TabIndex = 10;
            // 
            // cmbAgregarCategoria
            // 
            this.cmbAgregarCategoria.FormattingEnabled = true;
            this.cmbAgregarCategoria.Location = new System.Drawing.Point(119, 156);
            this.cmbAgregarCategoria.Name = "cmbAgregarCategoria";
            this.cmbAgregarCategoria.Size = new System.Drawing.Size(190, 21);
            this.cmbAgregarCategoria.TabIndex = 11;
            // 
            // txtAgregarPrecio
            // 
            this.txtAgregarPrecio.Location = new System.Drawing.Point(119, 186);
            this.txtAgregarPrecio.Name = "txtAgregarPrecio";
            this.txtAgregarPrecio.Size = new System.Drawing.Size(190, 20);
            this.txtAgregarPrecio.TabIndex = 12;
            // 
            // txtAgregarDescripcion
            // 
            this.txtAgregarDescripcion.Location = new System.Drawing.Point(119, 219);
            this.txtAgregarDescripcion.Multiline = true;
            this.txtAgregarDescripcion.Name = "txtAgregarDescripcion";
            this.txtAgregarDescripcion.Size = new System.Drawing.Size(190, 61);
            this.txtAgregarDescripcion.TabIndex = 13;
            // 
            // txtAgregarImagen
            // 
            this.txtAgregarImagen.Location = new System.Drawing.Point(119, 290);
            this.txtAgregarImagen.Name = "txtAgregarImagen";
            this.txtAgregarImagen.Size = new System.Drawing.Size(190, 20);
            this.txtAgregarImagen.TabIndex = 14;
            // 
            // picAgregarImagen
            // 
            this.picAgregarImagen.Location = new System.Drawing.Point(119, 348);
            this.picAgregarImagen.Name = "picAgregarImagen";
            this.picAgregarImagen.Size = new System.Drawing.Size(190, 190);
            this.picAgregarImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAgregarImagen.TabIndex = 16;
            this.picAgregarImagen.TabStop = false;
            // 
            // btnAgregarImagen
            // 
            this.btnAgregarImagen.Location = new System.Drawing.Point(119, 316);
            this.btnAgregarImagen.Name = "btnAgregarImagen";
            this.btnAgregarImagen.Size = new System.Drawing.Size(57, 23);
            this.btnAgregarImagen.TabIndex = 17;
            this.btnAgregarImagen.Text = "Agregar";
            this.btnAgregarImagen.UseVisualStyleBackColor = true;
            // 
            // btnQuitarImagen
            // 
            this.btnQuitarImagen.Location = new System.Drawing.Point(252, 316);
            this.btnQuitarImagen.Name = "btnQuitarImagen";
            this.btnQuitarImagen.Size = new System.Drawing.Size(57, 23);
            this.btnQuitarImagen.TabIndex = 18;
            this.btnQuitarImagen.Text = "Quitar";
            this.btnQuitarImagen.UseVisualStyleBackColor = true;
            // 
            // btnAceptarAgregarArticulo
            // 
            this.btnAceptarAgregarArticulo.Location = new System.Drawing.Point(153, 556);
            this.btnAceptarAgregarArticulo.Name = "btnAceptarAgregarArticulo";
            this.btnAceptarAgregarArticulo.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarAgregarArticulo.TabIndex = 19;
            this.btnAceptarAgregarArticulo.Text = "Aceptar";
            this.btnAceptarAgregarArticulo.UseVisualStyleBackColor = true;
            this.btnAceptarAgregarArticulo.Click += new System.EventHandler(this.btnAceptarAgregarArticulo_Click);
            // 
            // btnCancelarAgregarArticulo
            // 
            this.btnCancelarAgregarArticulo.Location = new System.Drawing.Point(234, 556);
            this.btnCancelarAgregarArticulo.Name = "btnCancelarAgregarArticulo";
            this.btnCancelarAgregarArticulo.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarAgregarArticulo.TabIndex = 20;
            this.btnCancelarAgregarArticulo.Text = "Cancelar";
            this.btnCancelarAgregarArticulo.UseVisualStyleBackColor = true;
            this.btnCancelarAgregarArticulo.Click += new System.EventHandler(this.btnCancelarAgregarArticulo_Click);
            // 
            // btnImagenAnterior
            // 
            this.btnImagenAnterior.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnImagenAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImagenAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImagenAnterior.Location = new System.Drawing.Point(180, 316);
            this.btnImagenAnterior.Name = "btnImagenAnterior";
            this.btnImagenAnterior.Size = new System.Drawing.Size(30, 23);
            this.btnImagenAnterior.TabIndex = 21;
            this.btnImagenAnterior.Text = "<";
            this.btnImagenAnterior.UseVisualStyleBackColor = false;
            // 
            // btnImagenSiguiente
            // 
            this.btnImagenSiguiente.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnImagenSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImagenSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImagenSiguiente.Location = new System.Drawing.Point(216, 316);
            this.btnImagenSiguiente.Name = "btnImagenSiguiente";
            this.btnImagenSiguiente.Size = new System.Drawing.Size(30, 23);
            this.btnImagenSiguiente.TabIndex = 22;
            this.btnImagenSiguiente.Text = ">";
            this.btnImagenSiguiente.UseVisualStyleBackColor = false;
            // 
            // FrmAgregarArticulo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(387, 592);
            this.Controls.Add(this.btnImagenSiguiente);
            this.Controls.Add(this.btnImagenAnterior);
            this.Controls.Add(this.btnCancelarAgregarArticulo);
            this.Controls.Add(this.btnAceptarAgregarArticulo);
            this.Controls.Add(this.btnQuitarImagen);
            this.Controls.Add(this.btnAgregarImagen);
            this.Controls.Add(this.picAgregarImagen);
            this.Controls.Add(this.txtAgregarImagen);
            this.Controls.Add(this.txtAgregarDescripcion);
            this.Controls.Add(this.txtAgregarPrecio);
            this.Controls.Add(this.cmbAgregarCategoria);
            this.Controls.Add(this.cmbAgregarMarca);
            this.Controls.Add(this.txtAgregarNombre);
            this.Controls.Add(this.lblAgregarImagenes);
            this.Controls.Add(this.lblAgregarDescripcion);
            this.Controls.Add(this.lblAgregarPrecio);
            this.Controls.Add(this.lblAgregarCategoria);
            this.Controls.Add(this.lblAgregarMarca);
            this.Controls.Add(this.lblAgregarNombre);
            this.Controls.Add(this.txtAgregarCodigo);
            this.Controls.Add(this.lblAgregarCodigo);
            this.Controls.Add(this.lblAgregarArticulo);
            this.Name = "FrmAgregarArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Articulo";
            this.Load += new System.EventHandler(this.FrmAgregarArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAgregarImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAgregarArticulo;
        private System.Windows.Forms.Label lblAgregarCodigo;
        private System.Windows.Forms.TextBox txtAgregarCodigo;
        private System.Windows.Forms.Label lblAgregarNombre;
        private System.Windows.Forms.Label lblAgregarMarca;
        private System.Windows.Forms.Label lblAgregarCategoria;
        private System.Windows.Forms.Label lblAgregarPrecio;
        private System.Windows.Forms.Label lblAgregarDescripcion;
        private System.Windows.Forms.Label lblAgregarImagenes;
        private System.Windows.Forms.TextBox txtAgregarNombre;
        private System.Windows.Forms.ComboBox cmbAgregarMarca;
        private System.Windows.Forms.ComboBox cmbAgregarCategoria;
        private System.Windows.Forms.TextBox txtAgregarPrecio;
        private System.Windows.Forms.TextBox txtAgregarDescripcion;
        private System.Windows.Forms.TextBox txtAgregarImagen;
        private System.Windows.Forms.PictureBox picAgregarImagen;
        private System.Windows.Forms.Button btnAgregarImagen;
        private System.Windows.Forms.Button btnQuitarImagen;
        private System.Windows.Forms.Button btnAceptarAgregarArticulo;
        private System.Windows.Forms.Button btnCancelarAgregarArticulo;
        private System.Windows.Forms.Button btnImagenAnterior;
        private System.Windows.Forms.Button btnImagenSiguiente;
    }
}