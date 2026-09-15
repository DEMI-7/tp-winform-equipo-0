namespace TPWinForm_equipo0
{
    partial class FrmVerArticulos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVerArticulos));
            BtnEditar = new Button();
            PbxImagenArticulo = new PictureBox();
            GrillaArticulos = new DataGridView();
            TxtBuscador = new TextBox();
            BtnBuscar = new Button();
            BtnAnteriorImagen = new Button();
            BtnSiguienteImagen = new Button();
            ((System.ComponentModel.ISupportInitialize)PbxImagenArticulo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GrillaArticulos).BeginInit();
            SuspendLayout();
            // 
            // BtnEditar
            // 
            BtnEditar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEditar.FlatStyle = FlatStyle.Flat;
            BtnEditar.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnEditar.Location = new Point(481, 381);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(204, 64);
            BtnEditar.TabIndex = 0;
            BtnEditar.Text = "Editar";
            BtnEditar.UseVisualStyleBackColor = true;
            BtnEditar.Click += BtnEditar_Click;
            // 
            // PbxImagenArticulo
            // 
            PbxImagenArticulo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PbxImagenArticulo.BorderStyle = BorderStyle.FixedSingle;
            PbxImagenArticulo.Location = new Point(369, 12);
            PbxImagenArticulo.Name = "PbxImagenArticulo";
            PbxImagenArticulo.Size = new Size(419, 363);
            PbxImagenArticulo.SizeMode = PictureBoxSizeMode.Zoom;
            PbxImagenArticulo.TabIndex = 2;
            PbxImagenArticulo.TabStop = false;
            // 
            // GrillaArticulos
            // 
            GrillaArticulos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GrillaArticulos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GrillaArticulos.EditMode = DataGridViewEditMode.EditProgrammatically;
            GrillaArticulos.Location = new Point(12, 60);
            GrillaArticulos.MultiSelect = false;
            GrillaArticulos.Name = "GrillaArticulos";
            GrillaArticulos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GrillaArticulos.Size = new Size(351, 356);
            GrillaArticulos.TabIndex = 1;
            GrillaArticulos.CellContentClick += GrillaArticulos_CellContentClick;
            GrillaArticulos.SelectionChanged += GrillaArticulos_SelectionChanged;
            // 
            // TxtBuscador
            // 
            TxtBuscador.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtBuscador.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtBuscador.Location = new Point(12, 12);
            TxtBuscador.Name = "TxtBuscador";
            TxtBuscador.Size = new Size(257, 35);
            TxtBuscador.TabIndex = 3;
            TxtBuscador.TextChanged += TxtBuscador_TextChanged;
            // 
            // BtnBuscar
            // 
            BtnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnBuscar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnBuscar.Location = new Point(275, 6);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(88, 48);
            BtnBuscar.TabIndex = 4;
            BtnBuscar.Text = "Buscar";
            BtnBuscar.UseVisualStyleBackColor = true;
            BtnBuscar.Click += BtnBuscar_Click;
            // 
            // BtnAnteriorImagen
            // 
            BtnAnteriorImagen.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnAnteriorImagen.FlatStyle = FlatStyle.Flat;
            BtnAnteriorImagen.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnAnteriorImagen.Location = new Point(411, 381);
            BtnAnteriorImagen.Name = "BtnAnteriorImagen";
            BtnAnteriorImagen.Size = new Size(64, 64);
            BtnAnteriorImagen.TabIndex = 5;
            BtnAnteriorImagen.Text = "<";
            BtnAnteriorImagen.UseVisualStyleBackColor = true;
            BtnAnteriorImagen.Click += BtnAnteriorImagen_Click;
            // 
            // BtnSiguienteImagen
            // 
            BtnSiguienteImagen.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSiguienteImagen.FlatStyle = FlatStyle.Flat;
            BtnSiguienteImagen.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold);
            BtnSiguienteImagen.Location = new Point(691, 381);
            BtnSiguienteImagen.Name = "BtnSiguienteImagen";
            BtnSiguienteImagen.Size = new Size(64, 64);
            BtnSiguienteImagen.TabIndex = 6;
            BtnSiguienteImagen.Text = ">";
            BtnSiguienteImagen.UseVisualStyleBackColor = true;
            BtnSiguienteImagen.Click += BtnSiguienteImagen_Click;
            // 
            // FrmVerArticulos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnSiguienteImagen);
            Controls.Add(BtnAnteriorImagen);
            Controls.Add(BtnBuscar);
            Controls.Add(TxtBuscador);
            Controls.Add(PbxImagenArticulo);
            Controls.Add(GrillaArticulos);
            Controls.Add(BtnEditar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmVerArticulos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ver Articulos";
            WindowState = FormWindowState.Maximized;
            Load += FrmVerArticulos_Load;
            ((System.ComponentModel.ISupportInitialize)PbxImagenArticulo).EndInit();
            ((System.ComponentModel.ISupportInitialize)GrillaArticulos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnEditar;
        private PictureBox PbxImagenArticulo;
        private DataGridView GrillaArticulos;
        private TextBox TxtBuscador;
        private Button BtnBuscar;
        private Button BtnAnteriorImagen;
        private Button BtnSiguienteImagen;
    }
}