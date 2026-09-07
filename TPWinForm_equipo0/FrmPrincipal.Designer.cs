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
            MenuBarraSuperior = new MenuStrip();
            articulosToolStripMenuItem = new ToolStripMenuItem();
            verArticulosToolStripMenuItem = new ToolStripMenuItem();
            nuevoArticuloToolStripMenuItem = new ToolStripMenuItem();
            eliminarArticuloToolStripMenuItem = new ToolStripMenuItem();
            marcasToolStripMenuItem = new ToolStripMenuItem();
            verMarcasToolStripMenuItem = new ToolStripMenuItem();
            nuevaMarcaToolStripMenuItem = new ToolStripMenuItem();
            eliminarMarcaToolStripMenuItem = new ToolStripMenuItem();
            categoriasToolStripMenuItem = new ToolStripMenuItem();
            verCategoriasToolStripMenuItem = new ToolStripMenuItem();
            nuevaCategoriaToolStripMenuItem = new ToolStripMenuItem();
            eliminarCategoriaToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            bindingSource1 = new BindingSource(components);
            MenuBarraSuperior.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // MenuBarraSuperior
            // 
            MenuBarraSuperior.Items.AddRange(new ToolStripItem[] { articulosToolStripMenuItem, marcasToolStripMenuItem, categoriasToolStripMenuItem });
            MenuBarraSuperior.Location = new Point(0, 0);
            MenuBarraSuperior.Name = "MenuBarraSuperior";
            MenuBarraSuperior.Size = new Size(1064, 24);
            MenuBarraSuperior.TabIndex = 1;
            MenuBarraSuperior.Text = "menuStrip1";
            // 
            // articulosToolStripMenuItem
            // 
            articulosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { verArticulosToolStripMenuItem, nuevoArticuloToolStripMenuItem, eliminarArticuloToolStripMenuItem });
            articulosToolStripMenuItem.Name = "articulosToolStripMenuItem";
            articulosToolStripMenuItem.Size = new Size(66, 20);
            articulosToolStripMenuItem.Text = "Articulos";
            // 
            // verArticulosToolStripMenuItem
            // 
            verArticulosToolStripMenuItem.Name = "verArticulosToolStripMenuItem";
            verArticulosToolStripMenuItem.Size = new Size(162, 22);
            verArticulosToolStripMenuItem.Text = "Ver Articulos";
            // 
            // nuevoArticuloToolStripMenuItem
            // 
            nuevoArticuloToolStripMenuItem.Name = "nuevoArticuloToolStripMenuItem";
            nuevoArticuloToolStripMenuItem.Size = new Size(162, 22);
            nuevoArticuloToolStripMenuItem.Text = "Nuevo Articulo";
            // 
            // eliminarArticuloToolStripMenuItem
            // 
            eliminarArticuloToolStripMenuItem.Name = "eliminarArticuloToolStripMenuItem";
            eliminarArticuloToolStripMenuItem.Size = new Size(162, 22);
            eliminarArticuloToolStripMenuItem.Text = "Eliminar Articulo";
            // 
            // marcasToolStripMenuItem
            // 
            marcasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { verMarcasToolStripMenuItem, nuevaMarcaToolStripMenuItem, eliminarMarcaToolStripMenuItem });
            marcasToolStripMenuItem.Name = "marcasToolStripMenuItem";
            marcasToolStripMenuItem.Size = new Size(57, 20);
            marcasToolStripMenuItem.Text = "Marcas";
            // 
            // verMarcasToolStripMenuItem
            // 
            verMarcasToolStripMenuItem.Name = "verMarcasToolStripMenuItem";
            verMarcasToolStripMenuItem.Size = new Size(153, 22);
            verMarcasToolStripMenuItem.Text = "Ver Marcas";
            // 
            // nuevaMarcaToolStripMenuItem
            // 
            nuevaMarcaToolStripMenuItem.Name = "nuevaMarcaToolStripMenuItem";
            nuevaMarcaToolStripMenuItem.Size = new Size(153, 22);
            nuevaMarcaToolStripMenuItem.Text = "Nueva Marca";
            // 
            // eliminarMarcaToolStripMenuItem
            // 
            eliminarMarcaToolStripMenuItem.Name = "eliminarMarcaToolStripMenuItem";
            eliminarMarcaToolStripMenuItem.Size = new Size(153, 22);
            eliminarMarcaToolStripMenuItem.Text = "Eliminar Marca";
            // 
            // categoriasToolStripMenuItem
            // 
            categoriasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { verCategoriasToolStripMenuItem, nuevaCategoriaToolStripMenuItem, eliminarCategoriaToolStripMenuItem });
            categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            categoriasToolStripMenuItem.Size = new Size(75, 20);
            categoriasToolStripMenuItem.Text = "Categorias";
            // 
            // verCategoriasToolStripMenuItem
            // 
            verCategoriasToolStripMenuItem.Name = "verCategoriasToolStripMenuItem";
            verCategoriasToolStripMenuItem.Size = new Size(171, 22);
            verCategoriasToolStripMenuItem.Text = "Ver Categorias";
            // 
            // nuevaCategoriaToolStripMenuItem
            // 
            nuevaCategoriaToolStripMenuItem.Name = "nuevaCategoriaToolStripMenuItem";
            nuevaCategoriaToolStripMenuItem.Size = new Size(171, 22);
            nuevaCategoriaToolStripMenuItem.Text = "Nueva Categoria";
            // 
            // eliminarCategoriaToolStripMenuItem
            // 
            eliminarCategoriaToolStripMenuItem.Name = "eliminarCategoriaToolStripMenuItem";
            eliminarCategoriaToolStripMenuItem.Size = new Size(171, 22);
            eliminarCategoriaToolStripMenuItem.Text = "Eliminar Categoria";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(8, 102, 213);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(143, 657);
            panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LogoVentaOKBorde;
            pictureBox1.Location = new Point(3, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(140, 141);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 681);
            Controls.Add(panel1);
            Controls.Add(MenuBarraSuperior);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = MenuBarraSuperior;
            MinimumSize = new Size(1080, 720);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " Venta OK";
            Load += FrmPrincipal_Load;
            MenuBarraSuperior.ResumeLayout(false);
            MenuBarraSuperior.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip MenuBarraSuperior;
        private ToolStripMenuItem articulosToolStripMenuItem;
        private ToolStripMenuItem verArticulosToolStripMenuItem;
        private ToolStripMenuItem nuevoArticuloToolStripMenuItem;
        private ToolStripMenuItem eliminarArticuloToolStripMenuItem;
        private ToolStripMenuItem marcasToolStripMenuItem;
        private ToolStripMenuItem verMarcasToolStripMenuItem;
        private ToolStripMenuItem nuevaMarcaToolStripMenuItem;
        private ToolStripMenuItem eliminarMarcaToolStripMenuItem;
        private ToolStripMenuItem categoriasToolStripMenuItem;
        private ToolStripMenuItem verCategoriasToolStripMenuItem;
        private ToolStripMenuItem nuevaCategoriaToolStripMenuItem;
        private ToolStripMenuItem eliminarCategoriaToolStripMenuItem;
        private Panel panel1;
        private PictureBox pictureBox1;
        private BindingSource bindingSource1;
    }
}
