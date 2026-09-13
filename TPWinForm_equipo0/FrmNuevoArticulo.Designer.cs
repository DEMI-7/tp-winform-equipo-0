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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNuevoArticulo));
            BtnAceptar = new Button();
            LblNombre = new Label();
            LblDescripcion = new Label();
            LblCodigo = new Label();
            LblMarca = new Label();
            LblCategoria = new Label();
            LblPrecio = new Label();
            TbxCodigo = new TextBox();
            TbxNombre = new TextBox();
            TbxDescripcion = new TextBox();
            TbxPrecio = new TextBox();
            PbxImagenArticulo = new PictureBox();
            LblUrlImagen = new Label();
            TbxUrlImagen = new TextBox();
            BtnCancelar = new Button();
            ComboMarca = new ComboBox();
            ComboCategoria = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)PbxImagenArticulo).BeginInit();
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
            // TbxCodigo
            // 
            TbxCodigo.Anchor = AnchorStyles.Left;
            TbxCodigo.Font = new Font("Segoe UI", 15.75F);
            TbxCodigo.Location = new Point(218, 47);
            TbxCodigo.Name = "TbxCodigo";
            TbxCodigo.Size = new Size(635, 35);
            TbxCodigo.TabIndex = 7;
            // 
            // TbxNombre
            // 
            TbxNombre.Anchor = AnchorStyles.Left;
            TbxNombre.Font = new Font("Segoe UI", 15.75F);
            TbxNombre.Location = new Point(218, 111);
            TbxNombre.Name = "TbxNombre";
            TbxNombre.Size = new Size(635, 35);
            TbxNombre.TabIndex = 8;
            // 
            // TbxDescripcion
            // 
            TbxDescripcion.Anchor = AnchorStyles.Left;
            TbxDescripcion.Font = new Font("Segoe UI", 15.75F);
            TbxDescripcion.Location = new Point(218, 167);
            TbxDescripcion.Name = "TbxDescripcion";
            TbxDescripcion.Size = new Size(635, 35);
            TbxDescripcion.TabIndex = 9;
            // 
            // TbxPrecio
            // 
            TbxPrecio.Anchor = AnchorStyles.Left;
            TbxPrecio.Font = new Font("Segoe UI", 15.75F);
            TbxPrecio.Location = new Point(218, 347);
            TbxPrecio.Name = "TbxPrecio";
            TbxPrecio.Size = new Size(635, 35);
            TbxPrecio.TabIndex = 10;
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
            // TbxUrlImagen
            // 
            TbxUrlImagen.Anchor = AnchorStyles.Left;
            TbxUrlImagen.Font = new Font("Segoe UI", 15.75F);
            TbxUrlImagen.Location = new Point(218, 407);
            TbxUrlImagen.Name = "TbxUrlImagen";
            TbxUrlImagen.Size = new Size(635, 35);
            TbxUrlImagen.TabIndex = 13;
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
            // FrmNuevoArticulo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1321, 593);
            Controls.Add(ComboCategoria);
            Controls.Add(ComboMarca);
            Controls.Add(BtnCancelar);
            Controls.Add(TbxUrlImagen);
            Controls.Add(LblUrlImagen);
            Controls.Add(PbxImagenArticulo);
            Controls.Add(TbxPrecio);
            Controls.Add(TbxDescripcion);
            Controls.Add(TbxNombre);
            Controls.Add(TbxCodigo);
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
            ((System.ComponentModel.ISupportInitialize)PbxImagenArticulo).EndInit();
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
        private TextBox TbxCodigo;
        private TextBox TbxNombre;
        private TextBox TbxDescripcion;
        private TextBox TbxPrecio;
        private PictureBox PbxImagenArticulo;
        private Label LblUrlImagen;
        private TextBox TbxUrlImagen;
        private Button BtnCancelar;
        private ComboBox ComboMarca;
        private ComboBox ComboCategoria;
    }
}