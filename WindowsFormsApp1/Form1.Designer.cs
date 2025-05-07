namespace WindowsFormsApp1
{
    partial class FrmArticulo
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.msAdmiistrarCategorias = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarMarcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lbBuscar = new System.Windows.Forms.Label();
            this.btnAgregarArt = new System.Windows.Forms.Button();
            this.btnModificarArt = new System.Windows.Forms.Button();
            this.btnEliminarArt = new System.Windows.Forms.Button();
            this.btnDetalleArt = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.rbCodigo = new System.Windows.Forms.RadioButton();
            this.rbnombre = new System.Windows.Forms.RadioButton();
            this.rbPrecio = new System.Windows.Forms.RadioButton();
            this.rbDescripcion = new System.Windows.Forms.RadioButton();
            this.goxCriterios = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.goxCriterios.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msAdmiistrarCategorias,
            this.administrarMarcasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1047, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // msAdmiistrarCategorias
            // 
            this.msAdmiistrarCategorias.Name = "msAdmiistrarCategorias";
            this.msAdmiistrarCategorias.Size = new System.Drawing.Size(175, 24);
            this.msAdmiistrarCategorias.Text = "Administrar Categorias";
            this.msAdmiistrarCategorias.Click += new System.EventHandler(this.msAdmiistrarCategorias_Click);
            // 
            // administrarMarcasToolStripMenuItem
            // 
            this.administrarMarcasToolStripMenuItem.Name = "administrarMarcasToolStripMenuItem";
            this.administrarMarcasToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.administrarMarcasToolStripMenuItem.Text = "Administrar Marcas";
            this.administrarMarcasToolStripMenuItem.Click += new System.EventHandler(this.administrarMarcasToolStripMenuItem_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(309, 59);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(461, 22);
            this.txtBuscar.TabIndex = 1;
            // 
            // lbBuscar
            // 
            this.lbBuscar.AutoSize = true;
            this.lbBuscar.Location = new System.Drawing.Point(178, 62);
            this.lbBuscar.Name = "lbBuscar";
            this.lbBuscar.Size = new System.Drawing.Size(103, 16);
            this.lbBuscar.TabIndex = 2;
            this.lbBuscar.Text = "Buscar Articulos";
            // 
            // btnAgregarArt
            // 
            this.btnAgregarArt.Location = new System.Drawing.Point(176, 592);
            this.btnAgregarArt.Name = "btnAgregarArt";
            this.btnAgregarArt.Size = new System.Drawing.Size(116, 43);
            this.btnAgregarArt.TabIndex = 3;
            this.btnAgregarArt.Text = "Agregar";
            this.btnAgregarArt.UseVisualStyleBackColor = true;
            // 
            // btnModificarArt
            // 
            this.btnModificarArt.Location = new System.Drawing.Point(341, 592);
            this.btnModificarArt.Name = "btnModificarArt";
            this.btnModificarArt.Size = new System.Drawing.Size(116, 43);
            this.btnModificarArt.TabIndex = 4;
            this.btnModificarArt.Text = "Modificar";
            this.btnModificarArt.UseVisualStyleBackColor = true;
            // 
            // btnEliminarArt
            // 
            this.btnEliminarArt.Location = new System.Drawing.Point(512, 592);
            this.btnEliminarArt.Name = "btnEliminarArt";
            this.btnEliminarArt.Size = new System.Drawing.Size(116, 43);
            this.btnEliminarArt.TabIndex = 5;
            this.btnEliminarArt.Text = "Eliminar";
            this.btnEliminarArt.UseVisualStyleBackColor = true;
            // 
            // btnDetalleArt
            // 
            this.btnDetalleArt.Location = new System.Drawing.Point(698, 592);
            this.btnDetalleArt.Name = "btnDetalleArt";
            this.btnDetalleArt.Size = new System.Drawing.Size(116, 43);
            this.btnDetalleArt.TabIndex = 6;
            this.btnDetalleArt.Text = "Detalle";
            this.btnDetalleArt.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(161, 232);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(665, 324);
            this.listBox1.TabIndex = 7;
            // 
            // rbCodigo
            // 
            this.rbCodigo.AutoSize = true;
            this.rbCodigo.Checked = true;
            this.rbCodigo.Location = new System.Drawing.Point(35, 43);
            this.rbCodigo.Name = "rbCodigo";
            this.rbCodigo.Size = new System.Drawing.Size(82, 24);
            this.rbCodigo.TabIndex = 8;
            this.rbCodigo.TabStop = true;
            this.rbCodigo.Text = "Codigo";
            this.rbCodigo.UseVisualStyleBackColor = true;
            // 
            // rbnombre
            // 
            this.rbnombre.AutoSize = true;
            this.rbnombre.Location = new System.Drawing.Point(167, 43);
            this.rbnombre.Name = "rbnombre";
            this.rbnombre.Size = new System.Drawing.Size(89, 24);
            this.rbnombre.TabIndex = 9;
            this.rbnombre.Text = "Nombre";
            this.rbnombre.UseVisualStyleBackColor = true;
            // 
            // rbPrecio
            // 
            this.rbPrecio.AutoSize = true;
            this.rbPrecio.Location = new System.Drawing.Point(305, 43);
            this.rbPrecio.Name = "rbPrecio";
            this.rbPrecio.Size = new System.Drawing.Size(78, 24);
            this.rbPrecio.TabIndex = 10;
            this.rbPrecio.Text = "Precio";
            this.rbPrecio.UseVisualStyleBackColor = true;
            // 
            // rbDescripcion
            // 
            this.rbDescripcion.AutoSize = true;
            this.rbDescripcion.Location = new System.Drawing.Point(434, 43);
            this.rbDescripcion.Name = "rbDescripcion";
            this.rbDescripcion.Size = new System.Drawing.Size(120, 24);
            this.rbDescripcion.TabIndex = 11;
            this.rbDescripcion.Text = "Descripcion";
            this.rbDescripcion.UseVisualStyleBackColor = true;
            // 
            // goxCriterios
            // 
            this.goxCriterios.Controls.Add(this.rbPrecio);
            this.goxCriterios.Controls.Add(this.rbCodigo);
            this.goxCriterios.Controls.Add(this.rbnombre);
            this.goxCriterios.Controls.Add(this.rbDescripcion);
            this.goxCriterios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goxCriterios.Location = new System.Drawing.Point(248, 108);
            this.goxCriterios.Name = "goxCriterios";
            this.goxCriterios.Size = new System.Drawing.Size(578, 100);
            this.goxCriterios.TabIndex = 12;
            this.goxCriterios.TabStop = false;
            this.goxCriterios.Text = "Criterios de Busqueda";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(860, 51);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(126, 38);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // FrmArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1047, 684);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.goxCriterios);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnDetalleArt);
            this.Controls.Add(this.btnEliminarArt);
            this.Controls.Add(this.btnModificarArt);
            this.Controls.Add(this.btnAgregarArt);
            this.Controls.Add(this.lbBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1264, 731);
            this.MinimumSize = new System.Drawing.Size(742, 577);
            this.Name = "FrmArticulo";
            this.Text = "App Catalogo";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.goxCriterios.ResumeLayout(false);
            this.goxCriterios.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem msAdmiistrarCategorias;
        private System.Windows.Forms.ToolStripMenuItem administrarMarcasToolStripMenuItem;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lbBuscar;
        private System.Windows.Forms.Button btnAgregarArt;
        private System.Windows.Forms.Button btnModificarArt;
        private System.Windows.Forms.Button btnEliminarArt;
        private System.Windows.Forms.Button btnDetalleArt;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RadioButton rbCodigo;
        private System.Windows.Forms.RadioButton rbnombre;
        private System.Windows.Forms.RadioButton rbPrecio;
        private System.Windows.Forms.RadioButton rbDescripcion;
        private System.Windows.Forms.GroupBox goxCriterios;
        private System.Windows.Forms.Button btnBuscar;
    }
}

