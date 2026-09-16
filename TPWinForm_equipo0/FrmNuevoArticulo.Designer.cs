namespace TPWinForm_equipo0
{
    partial class FrmNuevoArticulo
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNuevoArticulo));
            BtnAceptar = new Button();
            LblNombre = new Label();
            LblDescripcion = new Label();
            LblCodigo = new Label();
            LblMarca = new Label();
            LblCategoria = new Label();
            LblPrecio = new Label();
            TxtCodigo = new TextBox();
            TxtNombre = new TextBox();
            TxtDescripcion = new TextBox();
            TxtPrecio = new TextBox();
            PbxImagenArticulo = new PictureBox();
            LblUrlImagen = new Label();
            TxtUrlImagen = new TextBox();
            BtnCancelar = new Button();
            ComboMarca = new ComboBox();
            ComboCategoria = new ComboBox();
            GrillaUrlImagenes = new DataGridView();
            BtnPegar = new Button();
            BtnEnter = new Button();
            ErrorUrlImagen = new ErrorProvider(components);
            BtnEliminarImagen = new Button();
            ((System.ComponentModel.ISupportInitialize)PbxImagenArticulo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GrillaUrlImagenes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ErrorUrlImagen).BeginInit();
            SuspendLayout();
            // 
            // BtnAceptar
            // 
            BtnAceptar.Anchor = AnchorStyles.Left;
            BtnAceptar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnAceptar.Location = new Point(713, 505);
            BtnAceptar.Name = "BtnAceptar";
            BtnAceptar.Size = new Size(140, 40);
            BtnAceptar.TabIndex = 0;
            BtnAceptar.Text = "Aceptar";
            BtnAceptar.UseVisualStyleBackColor = true;
            BtnAceptar.Click += BtnAceptar_Click;
            // 
            // LblNombre
            // 
            LblNombre.Anchor = AnchorStyles.Left;
            LblNombre.AutoSize = true;
            LblNombre.Font = new Font("Segoe UI", 15.75F);
            LblNombre.Location = new Point(118, 110);
            LblNombre.Name = "LblNombre";
            LblNombre.Size = new Size(94, 30);
            LblNombre.TabIndex = 1;
            LblNombre.Text = "Nombre:";
            // 
            // LblDescripcion
            // 
            LblDescripcion.Anchor = AnchorStyles.Left;
            LblDescripcion.AutoSize = true;
            LblDescripcion.Font = new Font("Segoe UI", 15.75F);
            LblDescripcion.Location = new Point(86, 170);
            LblDescripcion.Name = "LblDescripcion";
            LblDescripcion.Size = new Size(126, 30);
            LblDescripcion.TabIndex = 2;
            LblDescripcion.Text = "Descripción:";
            // 
            // LblCodigo
            // 
            LblCodigo.Anchor = AnchorStyles.Left;
            LblCodigo.AutoSize = true;
            LblCodigo.Font = new Font("Segoe UI", 15.75F);
            LblCodigo.Location = new Point(128, 50);
            LblCodigo.Name = "LblCodigo";
            LblCodigo.Size = new Size(84, 30);
            LblCodigo.TabIndex = 3;
            LblCodigo.Text = "Código:";
            // 
            // LblMarca
            // 
            LblMarca.Anchor = AnchorStyles.Left;
            LblMarca.AutoSize = true;
            LblMarca.Font = new Font("Segoe UI", 15.75F);
            LblMarca.Location = new Point(136, 230);
            LblMarca.Name = "LblMarca";
            LblMarca.Size = new Size(76, 30);
            LblMarca.TabIndex = 4;
            LblMarca.Text = "Marca:";
            // 
            // LblCategoria
            // 
            LblCategoria.Anchor = AnchorStyles.Left;
            LblCategoria.AutoSize = true;
            LblCategoria.Font = new Font("Segoe UI", 15.75F);
            LblCategoria.Location = new Point(105, 290);
            LblCategoria.Name = "LblCategoria";
            LblCategoria.Size = new Size(107, 30);
            LblCategoria.TabIndex = 5;
            LblCategoria.Text = "Categoria:";
            // 
            // LblPrecio
            // 
            LblPrecio.Anchor = AnchorStyles.Left;
            LblPrecio.AutoSize = true;
            LblPrecio.Font = new Font("Segoe UI", 15.75F);
            LblPrecio.Location = new Point(137, 350);
            LblPrecio.Name = "LblPrecio";
            LblPrecio.Size = new Size(75, 30);
            LblPrecio.TabIndex = 6;
            LblPrecio.Text = "Precio:";
            // 
            // TxtCodigo
            // 
            TxtCodigo.Anchor = AnchorStyles.Left;
            TxtCodigo.Font = new Font("Segoe UI", 15.75F);
            TxtCodigo.Location = new Point(218, 47);
            TxtCodigo.Name = "TxtCodigo";
            TxtCodigo.Size = new Size(635, 35);
            TxtCodigo.TabIndex = 7;
            // 
            // TxtNombre
            // 
            TxtNombre.Anchor = AnchorStyles.Left;
            TxtNombre.Font = new Font("Segoe UI", 15.75F);
            TxtNombre.Location = new Point(218, 111);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(635, 35);
            TxtNombre.TabIndex = 8;
            // 
            // TxtDescripcion
            // 
            TxtDescripcion.Anchor = AnchorStyles.Left;
            TxtDescripcion.Font = new Font("Segoe UI", 15.75F);
            TxtDescripcion.Location = new Point(218, 167);
            TxtDescripcion.Name = "TxtDescripcion";
            TxtDescripcion.Size = new Size(635, 35);
            TxtDescripcion.TabIndex = 9;
            // 
            // TxtPrecio
            // 
            TxtPrecio.Anchor = AnchorStyles.Left;
            TxtPrecio.Font = new Font("Segoe UI", 15.75F);
            TxtPrecio.Location = new Point(218, 347);
            TxtPrecio.Name = "TxtPrecio";
            TxtPrecio.Size = new Size(635, 35);
            TxtPrecio.TabIndex = 10;
            // 
            // PbxImagenArticulo
            // 
            PbxImagenArticulo.Anchor = AnchorStyles.Left;
            PbxImagenArticulo.BorderStyle = BorderStyle.FixedSingle;
            PbxImagenArticulo.Location = new Point(880, 47);
            PbxImagenArticulo.Name = "PbxImagenArticulo";
            PbxImagenArticulo.Size = new Size(395, 395);
            PbxImagenArticulo.SizeMode = PictureBoxSizeMode.Zoom;
            PbxImagenArticulo.TabIndex = 11;
            PbxImagenArticulo.TabStop = false;
            // 
            // LblUrlImagen
            // 
            LblUrlImagen.Anchor = AnchorStyles.Left;
            LblUrlImagen.AutoSize = true;
            LblUrlImagen.Font = new Font("Segoe UI", 15.75F);
            LblUrlImagen.Location = new Point(93, 410);
            LblUrlImagen.Name = "LblUrlImagen";
            LblUrlImagen.Size = new Size(119, 30);
            LblUrlImagen.TabIndex = 12;
            LblUrlImagen.Text = "Url imagen:";
            // 
            // TxtUrlImagen
            // 
            TxtUrlImagen.Anchor = AnchorStyles.Left;
            TxtUrlImagen.Font = new Font("Segoe UI", 15.75F);
            TxtUrlImagen.Location = new Point(218, 407);
            TxtUrlImagen.Name = "TxtUrlImagen";
            TxtUrlImagen.Size = new Size(635, 35);
            TxtUrlImagen.TabIndex = 13;
            TxtUrlImagen.KeyDown += TxtUrlImagen_KeyDown;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Anchor = AnchorStyles.Left;
            BtnCancelar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnCancelar.Location = new Point(880, 505);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(140, 40);
            BtnCancelar.TabIndex = 14;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // ComboMarca
            // 
            ComboMarca.Anchor = AnchorStyles.Left;
            ComboMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboMarca.Font = new Font("Segoe UI", 15.75F);
            ComboMarca.FormattingEnabled = true;
            ComboMarca.Location = new Point(218, 227);
            ComboMarca.Name = "ComboMarca";
            ComboMarca.Size = new Size(379, 38);
            ComboMarca.TabIndex = 15;
            // 
            // ComboCategoria
            // 
            ComboCategoria.Anchor = AnchorStyles.Left;
            ComboCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboCategoria.Font = new Font("Segoe UI", 15.75F);
            ComboCategoria.FormattingEnabled = true;
            ComboCategoria.Location = new Point(218, 287);
            ComboCategoria.Name = "ComboCategoria";
            ComboCategoria.Size = new Size(379, 38);
            ComboCategoria.TabIndex = 16;
            // 
            // GrillaUrlImagenes
            // 
            GrillaUrlImagenes.Anchor = AnchorStyles.Left;
            GrillaUrlImagenes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GrillaUrlImagenes.EditMode = DataGridViewEditMode.EditProgrammatically;
            GrillaUrlImagenes.Location = new Point(1281, 47);
            GrillaUrlImagenes.MultiSelect = false;
            GrillaUrlImagenes.Name = "GrillaUrlImagenes";
            GrillaUrlImagenes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GrillaUrlImagenes.Size = new Size(259, 395);
            GrillaUrlImagenes.TabIndex = 17;
            GrillaUrlImagenes.SelectionChanged += GrillaUrlImagenes_SelectionChanged;
            // 
            // BtnPegar
            // 
            BtnPegar.Anchor = AnchorStyles.Left;
            BtnPegar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnPegar.Location = new Point(218, 448);
            BtnPegar.Name = "BtnPegar";
            BtnPegar.Size = new Size(80, 30);
            BtnPegar.TabIndex = 18;
            BtnPegar.Text = "Pegar URL";
            BtnPegar.UseVisualStyleBackColor = true;
            BtnPegar.Click += BtnPegar_Click;
            // 
            // BtnEnter
            // 
            BtnEnter.Anchor = AnchorStyles.Left;
            BtnEnter.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnEnter.Location = new Point(334, 448);
            BtnEnter.Name = "BtnEnter";
            BtnEnter.Size = new Size(80, 30);
            BtnEnter.TabIndex = 19;
            BtnEnter.Text = "Enter";
            BtnEnter.UseVisualStyleBackColor = true;
            BtnEnter.Click += BtnEnter_Click;
            // 
            // ErrorUrlImagen
            // 
            ErrorUrlImagen.ContainerControl = this;
            // 
            // BtnEliminarImagen
            // 
            BtnEliminarImagen.Anchor = AnchorStyles.Left;
            BtnEliminarImagen.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            BtnEliminarImagen.Location = new Point(1319, 448);
            BtnEliminarImagen.Name = "BtnEliminarImagen";
            BtnEliminarImagen.Size = new Size(190, 30);
            BtnEliminarImagen.TabIndex = 20;
            BtnEliminarImagen.Text = "Eliminar imagen";
            BtnEliminarImagen.UseVisualStyleBackColor = true;
            BtnEliminarImagen.Click += BtnEliminarImagen_Click;
            // 
            // FrmNuevoArticulo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1684, 593);
            Controls.Add(BtnEliminarImagen);
            Controls.Add(BtnEnter);
            Controls.Add(BtnPegar);
            Controls.Add(GrillaUrlImagenes);
            Controls.Add(ComboCategoria);
            Controls.Add(ComboMarca);
            Controls.Add(BtnCancelar);
            Controls.Add(TxtUrlImagen);
            Controls.Add(LblUrlImagen);
            Controls.Add(PbxImagenArticulo);
            Controls.Add(TxtPrecio);
            Controls.Add(TxtDescripcion);
            Controls.Add(TxtNombre);
            Controls.Add(TxtCodigo);
            Controls.Add(LblPrecio);
            Controls.Add(LblCategoria);
            Controls.Add(LblMarca);
            Controls.Add(LblCodigo);
            Controls.Add(LblDescripcion);
            Controls.Add(LblNombre);
            Controls.Add(BtnAceptar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1337, 632);
            Name = "FrmNuevoArticulo";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Nuevo articulo";
            Load += FrmNuevoArticulo_Load;
            ((System.ComponentModel.ISupportInitialize)PbxImagenArticulo).EndInit();
            ((System.ComponentModel.ISupportInitialize)GrillaUrlImagenes).EndInit();
            ((System.ComponentModel.ISupportInitialize)ErrorUrlImagen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnAceptar;
        private Label LblNombre;
        private Label LblDescripcion;
        private Label LblCodigo;
        private Label LblMarca;
        private Label LblCategoria;
        private Label LblPrecio;
        private TextBox TxtCodigo;
        private TextBox TxtNombre;
        private TextBox TxtDescripcion;
        private TextBox TxtPrecio;
        private PictureBox PbxImagenArticulo;
        private Label LblUrlImagen;
        private TextBox TxtUrlImagen;
        private Button BtnCancelar;
        private ComboBox ComboMarca;
        private ComboBox ComboCategoria;
        private DataGridView GrillaUrlImagenes;
        private Button BtnPegar;
        private Button BtnEnter;
        private ErrorProvider ErrorUrlImagen;
        private Button BtnEliminarImagen;
    }
}