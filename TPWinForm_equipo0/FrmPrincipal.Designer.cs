namespace TPWinForm_equipo0
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            PnlPrincipal = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            BtnArticulos = new Button();
            PnlOpcionesArticulos = new Panel();
            BtnVerArticulos = new Button();
            BtnEliminarArticulo = new Button();
            BtnNuevoArticulo = new Button();
            BtnMarcas = new Button();
            PnlOpcionesMarcas = new Panel();
            BtnVerMarcas = new Button();
            BtnEliminarMarca = new Button();
            btnNuevaMarca = new Button();
            BtnCategorias = new Button();
            PnlOpcionesCategorias = new Panel();
            BtnVerCategorias = new Button();
            BtnNuevaCategoria = new Button();
            PbxLogo = new PictureBox();
            bindingSource1 = new BindingSource(components);
            PnlPrincipal.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            PnlOpcionesArticulos.SuspendLayout();
            PnlOpcionesMarcas.SuspendLayout();
            PnlOpcionesCategorias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PbxLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // PnlPrincipal
            // 
            PnlPrincipal.BackColor = Color.DodgerBlue;
            PnlPrincipal.Controls.Add(flowLayoutPanel1);
            PnlPrincipal.Controls.Add(PbxLogo);
            PnlPrincipal.Dock = DockStyle.Left;
            PnlPrincipal.Location = new Point(0, 0);
            PnlPrincipal.Name = "PnlPrincipal";
            PnlPrincipal.Size = new Size(232, 898);
            PnlPrincipal.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(BtnArticulos);
            flowLayoutPanel1.Controls.Add(PnlOpcionesArticulos);
            flowLayoutPanel1.Controls.Add(BtnMarcas);
            flowLayoutPanel1.Controls.Add(PnlOpcionesMarcas);
            flowLayoutPanel1.Controls.Add(BtnCategorias);
            flowLayoutPanel1.Controls.Add(PnlOpcionesCategorias);
            flowLayoutPanel1.Location = new Point(12, 240);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(220, 625);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // BtnArticulos
            // 
            BtnArticulos.BackColor = Color.White;
            BtnArticulos.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            BtnArticulos.ForeColor = SystemColors.HotTrack;
            BtnArticulos.Location = new Point(5, 3);
            BtnArticulos.Margin = new Padding(5, 3, 3, 3);
            BtnArticulos.Name = "BtnArticulos";
            BtnArticulos.Size = new Size(200, 37);
            BtnArticulos.TabIndex = 1;
            BtnArticulos.Text = "Artículos";
            BtnArticulos.UseVisualStyleBackColor = false;
            BtnArticulos.Click += BtnArticulos_Click;
            // 
            // PnlOpcionesArticulos
            // 
            PnlOpcionesArticulos.Controls.Add(BtnVerArticulos);
            PnlOpcionesArticulos.Controls.Add(BtnEliminarArticulo);
            PnlOpcionesArticulos.Controls.Add(BtnNuevoArticulo);
            PnlOpcionesArticulos.Location = new Point(3, 43);
            PnlOpcionesArticulos.Margin = new Padding(3, 0, 3, 3);
            PnlOpcionesArticulos.Name = "PnlOpcionesArticulos";
            PnlOpcionesArticulos.Size = new Size(183, 125);
            PnlOpcionesArticulos.TabIndex = 0;
            // 
            // BtnVerArticulos
            // 
            BtnVerArticulos.BackColor = Color.White;
            BtnVerArticulos.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            BtnVerArticulos.ForeColor = SystemColors.HotTrack;
            BtnVerArticulos.Location = new Point(2, 3);
            BtnVerArticulos.Name = "BtnVerArticulos";
            BtnVerArticulos.Size = new Size(170, 37);
            BtnVerArticulos.TabIndex = 2;
            BtnVerArticulos.Text = "Ver artículos";
            BtnVerArticulos.UseVisualStyleBackColor = false;
            BtnVerArticulos.Click += BtnVerArticulos_Click;
            // 
            // BtnEliminarArticulo
            // 
            BtnEliminarArticulo.BackColor = Color.White;
            BtnEliminarArticulo.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            BtnEliminarArticulo.ForeColor = SystemColors.HotTrack;
            BtnEliminarArticulo.Location = new Point(2, 85);
            BtnEliminarArticulo.Name = "BtnEliminarArticulo";
            BtnEliminarArticulo.Size = new Size(170, 37);
            BtnEliminarArticulo.TabIndex = 2;
            BtnEliminarArticulo.Text = "Eliminar artículo";
            BtnEliminarArticulo.UseVisualStyleBackColor = false;
            BtnEliminarArticulo.Click += BtnEliminarArticulo_Click;
            // 
            // BtnNuevoArticulo
            // 
            BtnNuevoArticulo.BackColor = Color.White;
            BtnNuevoArticulo.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            BtnNuevoArticulo.ForeColor = SystemColors.HotTrack;
            BtnNuevoArticulo.Location = new Point(2, 44);
            BtnNuevoArticulo.Name = "BtnNuevoArticulo";
            BtnNuevoArticulo.Size = new Size(170, 37);
            BtnNuevoArticulo.TabIndex = 1;
            BtnNuevoArticulo.Text = "Nuevo artículo";
            BtnNuevoArticulo.UseVisualStyleBackColor = false;
            BtnNuevoArticulo.Click += BtnNuevoArticulo_Click;
            // 
            // BtnMarcas
            // 
            BtnMarcas.BackColor = Color.White;
            BtnMarcas.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            BtnMarcas.ForeColor = SystemColors.HotTrack;
            BtnMarcas.Location = new Point(5, 174);
            BtnMarcas.Margin = new Padding(5, 3, 3, 3);
            BtnMarcas.Name = "BtnMarcas";
            BtnMarcas.Size = new Size(200, 37);
            BtnMarcas.TabIndex = 2;
            BtnMarcas.Text = "Marcas";
            BtnMarcas.UseVisualStyleBackColor = false;
            BtnMarcas.Click += BtnMarcas_Click;
            // 
            // PnlOpcionesMarcas
            // 
            PnlOpcionesMarcas.Controls.Add(BtnVerMarcas);
            PnlOpcionesMarcas.Controls.Add(BtnEliminarMarca);
            PnlOpcionesMarcas.Controls.Add(btnNuevaMarca);
            PnlOpcionesMarcas.Location = new Point(3, 214);
            PnlOpcionesMarcas.Margin = new Padding(3, 0, 3, 3);
            PnlOpcionesMarcas.Name = "PnlOpcionesMarcas";
            PnlOpcionesMarcas.Size = new Size(183, 125);
            PnlOpcionesMarcas.TabIndex = 10;
            // 
            // BtnVerMarcas
            // 
            BtnVerMarcas.BackColor = Color.White;
            BtnVerMarcas.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            BtnVerMarcas.ForeColor = SystemColors.HotTrack;
            BtnVerMarcas.Location = new Point(2, 3);
            BtnVerMarcas.Name = "BtnVerMarcas";
            BtnVerMarcas.Size = new Size(170, 37);
            BtnVerMarcas.TabIndex = 0;
            BtnVerMarcas.Text = "Ver marcas";
            BtnVerMarcas.UseVisualStyleBackColor = false;
            BtnVerMarcas.Click += BtnVerMarcas_Click;
            // 
            // BtnEliminarMarca
            // 
            BtnEliminarMarca.BackColor = Color.White;
            BtnEliminarMarca.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            BtnEliminarMarca.ForeColor = SystemColors.HotTrack;
            BtnEliminarMarca.Location = new Point(2, 85);
            BtnEliminarMarca.Name = "BtnEliminarMarca";
            BtnEliminarMarca.Size = new Size(170, 37);
            BtnEliminarMarca.TabIndex = 2;
            BtnEliminarMarca.Text = "Eliminar marca";
            BtnEliminarMarca.UseVisualStyleBackColor = false;
            BtnEliminarMarca.Click += BtnEliminarMarca_Click;
            // 
            // btnNuevaMarca
            // 
            btnNuevaMarca.BackColor = Color.White;
            btnNuevaMarca.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            btnNuevaMarca.ForeColor = SystemColors.HotTrack;
            btnNuevaMarca.Location = new Point(2, 44);
            btnNuevaMarca.Name = "btnNuevaMarca";
            btnNuevaMarca.Size = new Size(170, 37);
            btnNuevaMarca.TabIndex = 1;
            btnNuevaMarca.Text = "Nueva marca";
            btnNuevaMarca.UseVisualStyleBackColor = false;
            btnNuevaMarca.Click += btnNuevaMarca_Click;
            // 
            // BtnCategorias
            // 
            BtnCategorias.BackColor = Color.White;
            BtnCategorias.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            BtnCategorias.ForeColor = SystemColors.HotTrack;
            BtnCategorias.Location = new Point(5, 345);
            BtnCategorias.Margin = new Padding(5, 3, 3, 3);
            BtnCategorias.Name = "BtnCategorias";
            BtnCategorias.Size = new Size(200, 37);
            BtnCategorias.TabIndex = 0;
            BtnCategorias.Text = "Categorías";
            BtnCategorias.UseVisualStyleBackColor = false;
            BtnCategorias.Click += BtnCategorias_Click;
            // 
            // PnlOpcionesCategorias
            // 
            PnlOpcionesCategorias.Controls.Add(BtnVerCategorias);
            PnlOpcionesCategorias.Controls.Add(BtnNuevaCategoria);
            PnlOpcionesCategorias.Location = new Point(3, 385);
            PnlOpcionesCategorias.Margin = new Padding(3, 0, 3, 3);
            PnlOpcionesCategorias.Name = "PnlOpcionesCategorias";
            PnlOpcionesCategorias.Size = new Size(183, 93);
            PnlOpcionesCategorias.TabIndex = 10;
            // 
            // BtnVerCategorias
            // 
            BtnVerCategorias.BackColor = Color.White;
            BtnVerCategorias.Font = new Font("Segoe UI Semibold", 12.7F);
            BtnVerCategorias.ForeColor = SystemColors.HotTrack;
            BtnVerCategorias.Location = new Point(2, 3);
            BtnVerCategorias.Name = "BtnVerCategorias";
            BtnVerCategorias.Size = new Size(170, 37);
            BtnVerCategorias.TabIndex = 0;
            BtnVerCategorias.Text = "Ver categorías";
            BtnVerCategorias.UseVisualStyleBackColor = false;
            BtnVerCategorias.Click += BtnVerCategorias_Click;
            // 
            // BtnNuevaCategoria
            // 
            BtnNuevaCategoria.BackColor = Color.White;
            BtnNuevaCategoria.Font = new Font("Segoe UI Semibold", 12.7F);
            BtnNuevaCategoria.ForeColor = SystemColors.HotTrack;
            BtnNuevaCategoria.Location = new Point(2, 46);
            BtnNuevaCategoria.Name = "BtnNuevaCategoria";
            BtnNuevaCategoria.Size = new Size(170, 37);
            BtnNuevaCategoria.TabIndex = 1;
            BtnNuevaCategoria.Text = "Nueva categoría";
            BtnNuevaCategoria.UseVisualStyleBackColor = false;
            BtnNuevaCategoria.Click += BtnNuevaCategoria_Click;
            // 
            // PbxLogo
            // 
            PbxLogo.Image = Properties.Resources.LogoVentaOKBorde;
            PbxLogo.Location = new Point(0, 0);
            PbxLogo.Name = "PbxLogo";
            PbxLogo.Size = new Size(232, 234);
            PbxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            PbxLogo.TabIndex = 0;
            PbxLogo.TabStop = false;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 898);
            Controls.Add(PnlPrincipal);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MinimumSize = new Size(1080, 720);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " Venta OK";
            WindowState = FormWindowState.Maximized;
            Load += FrmPrincipal_Load;
            PnlPrincipal.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            PnlOpcionesArticulos.ResumeLayout(false);
            PnlOpcionesMarcas.ResumeLayout(false);
            PnlOpcionesCategorias.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PbxLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel PnlPrincipal;
        private PictureBox PbxLogo;
        private BindingSource bindingSource1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button BtnArticulos;
        private Panel PnlOpcionesArticulos;
        private Button BtnVerArticulos;
        private Button BtnEliminarArticulo;
        private Button BtnNuevoArticulo;
        private Button BtnMarcas;
        private Button BtnCategorias;
        private Panel PnlOpcionesMarcas;
        private Button BtnVerMarcas;
        private Button BtnEliminarMarca;
        private Button btnNuevaMarca;
        private Panel PnlOpcionesCategorias;
        private Button BtnVerCategorias;
        private Button BtnNuevaCategoria;
    }
}
