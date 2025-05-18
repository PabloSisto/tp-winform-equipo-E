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
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lbBuscar = new System.Windows.Forms.Label();
            this.btnAgregarArt = new System.Windows.Forms.Button();
            this.btnModificarArt = new System.Windows.Forms.Button();
            this.btnEliminarArt = new System.Windows.Forms.Button();
            this.btnDetalleArt = new System.Windows.Forms.Button();
            this.rbCodigo = new System.Windows.Forms.RadioButton();
            this.rbnombre = new System.Windows.Forms.RadioButton();
            this.goxCriterios = new System.Windows.Forms.GroupBox();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.msAdmiistrarCategorias = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarMarcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dgvArticulo = new System.Windows.Forms.DataGridView();
            this.pxbArticulo = new System.Windows.Forms.PictureBox();
            this.goxCriterios.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxbArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(309, 59);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(461, 22);
            this.txtBuscar.TabIndex = 1;
            // 
            // lbBuscar
            // 
            this.lbBuscar.AutoSize = true;
            this.lbBuscar.Location = new System.Drawing.Point(179, 62);
            this.lbBuscar.Name = "lbBuscar";
            this.lbBuscar.Size = new System.Drawing.Size(103, 16);
            this.lbBuscar.TabIndex = 2;
            this.lbBuscar.Text = "Buscar Articulos";
            // 
            // btnAgregarArt
            // 
            this.btnAgregarArt.Location = new System.Drawing.Point(176, 592);
            this.btnAgregarArt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarArt.Name = "btnAgregarArt";
            this.btnAgregarArt.Size = new System.Drawing.Size(116, 43);
            this.btnAgregarArt.TabIndex = 3;
            this.btnAgregarArt.Text = "Agregar";
            this.btnAgregarArt.UseVisualStyleBackColor = true;
            this.btnAgregarArt.Click += new System.EventHandler(this.btnAgregarArt_Click);
            // 
            // btnModificarArt
            // 
            this.btnModificarArt.Location = new System.Drawing.Point(341, 592);
            this.btnModificarArt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificarArt.Name = "btnModificarArt";
            this.btnModificarArt.Size = new System.Drawing.Size(116, 43);
            this.btnModificarArt.TabIndex = 4;
            this.btnModificarArt.Text = "Modificar";
            this.btnModificarArt.UseVisualStyleBackColor = true;
            this.btnModificarArt.Click += new System.EventHandler(this.btnModificarArt_Click);
            // 
            // btnEliminarArt
            // 
            this.btnEliminarArt.Location = new System.Drawing.Point(512, 592);
            this.btnEliminarArt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarArt.Name = "btnEliminarArt";
            this.btnEliminarArt.Size = new System.Drawing.Size(116, 43);
            this.btnEliminarArt.TabIndex = 5;
            this.btnEliminarArt.Text = "Eliminar";
            this.btnEliminarArt.UseVisualStyleBackColor = true;
            this.btnEliminarArt.Click += new System.EventHandler(this.btnEliminarArt_Click);
            // 
            // btnDetalleArt
            // 
            this.btnDetalleArt.Location = new System.Drawing.Point(699, 592);
            this.btnDetalleArt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDetalleArt.Name = "btnDetalleArt";
            this.btnDetalleArt.Size = new System.Drawing.Size(116, 43);
            this.btnDetalleArt.TabIndex = 6;
            this.btnDetalleArt.Text = "Detalle";
            this.btnDetalleArt.UseVisualStyleBackColor = true;
            this.btnDetalleArt.Click += new System.EventHandler(this.btnDetalleArt_Click);
            // 
            // rbCodigo
            // 
            this.rbCodigo.AutoSize = true;
            this.rbCodigo.Location = new System.Drawing.Point(297, 43);
            this.rbCodigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbCodigo.Name = "rbCodigo";
            this.rbCodigo.Size = new System.Drawing.Size(82, 24);
            this.rbCodigo.TabIndex = 8;
            this.rbCodigo.Text = "Codigo";
            this.rbCodigo.UseVisualStyleBackColor = true;
            this.rbCodigo.CheckedChanged += new System.EventHandler(this.rbTodos_CheckedChanged);
            // 
            // rbnombre
            // 
            this.rbnombre.AutoSize = true;
            this.rbnombre.Location = new System.Drawing.Point(167, 43);
            this.rbnombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbnombre.Name = "rbnombre";
            this.rbnombre.Size = new System.Drawing.Size(89, 24);
            this.rbnombre.TabIndex = 9;
            this.rbnombre.Text = "Nombre";
            this.rbnombre.UseVisualStyleBackColor = true;
            this.rbnombre.CheckedChanged += new System.EventHandler(this.rbTodos_CheckedChanged);
            // 
            // goxCriterios
            // 
            this.goxCriterios.Controls.Add(this.rbTodos);
            this.goxCriterios.Controls.Add(this.rbCodigo);
            this.goxCriterios.Controls.Add(this.rbnombre);
            this.goxCriterios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goxCriterios.Location = new System.Drawing.Point(328, 119);
            this.goxCriterios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.goxCriterios.Name = "goxCriterios";
            this.goxCriterios.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.goxCriterios.Size = new System.Drawing.Size(407, 100);
            this.goxCriterios.TabIndex = 12;
            this.goxCriterios.TabStop = false;
            this.goxCriterios.Text = "Criterios de Busqueda";
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.Checked = true;
            this.rbTodos.Location = new System.Drawing.Point(32, 43);
            this.rbTodos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(76, 24);
            this.rbTodos.TabIndex = 10;
            this.rbTodos.TabStop = true;
            this.rbTodos.Text = "Todos";
            this.rbTodos.UseVisualStyleBackColor = true;
            this.rbTodos.CheckedChanged += new System.EventHandler(this.rbTodos_CheckedChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(860, 50);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(125, 38);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
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
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msAdmiistrarCategorias,
            this.administrarMarcasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1225, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dgvArticulo
            // 
            this.dgvArticulo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArticulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulo.Location = new System.Drawing.Point(45, 242);
            this.dgvArticulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvArticulo.MultiSelect = false;
            this.dgvArticulo.Name = "dgvArticulo";
            this.dgvArticulo.RowHeadersWidth = 51;
            this.dgvArticulo.RowTemplate.Height = 24;
            this.dgvArticulo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulo.Size = new System.Drawing.Size(824, 309);
            this.dgvArticulo.TabIndex = 14;
            // 
            // pxbArticulo
            // 
            this.pxbArticulo.Location = new System.Drawing.Point(955, 287);
            this.pxbArticulo.Name = "pxbArticulo";
            this.pxbArticulo.Size = new System.Drawing.Size(230, 203);
            this.pxbArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pxbArticulo.TabIndex = 15;
            this.pxbArticulo.TabStop = false;
            // 
            // FrmArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1225, 632);
            this.Controls.Add(this.pxbArticulo);
            this.Controls.Add(this.dgvArticulo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.goxCriterios);
            this.Controls.Add(this.btnDetalleArt);
            this.Controls.Add(this.btnEliminarArt);
            this.Controls.Add(this.btnModificarArt);
            this.Controls.Add(this.btnAgregarArt);
            this.Controls.Add(this.lbBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1262, 728);
            this.MinimumSize = new System.Drawing.Size(741, 574);
            this.Name = "FrmArticulo";
            this.Text = "App Catalogo";
            this.Load += new System.EventHandler(this.FrmArticulo_Load);
            this.goxCriterios.ResumeLayout(false);
            this.goxCriterios.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxbArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lbBuscar;
        private System.Windows.Forms.Button btnAgregarArt;
        private System.Windows.Forms.Button btnModificarArt;
        private System.Windows.Forms.Button btnEliminarArt;
        private System.Windows.Forms.Button btnDetalleArt;
        private System.Windows.Forms.RadioButton rbCodigo;
        private System.Windows.Forms.RadioButton rbnombre;
        private System.Windows.Forms.GroupBox goxCriterios;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ToolStripMenuItem msAdmiistrarCategorias;
        private System.Windows.Forms.ToolStripMenuItem administrarMarcasToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView dgvArticulo;
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.PictureBox pxbArticulo;
    }
}