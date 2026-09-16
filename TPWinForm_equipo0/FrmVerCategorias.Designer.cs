namespace TPWinForm_equipo0
{
    partial class FrmVerCategorias
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
            GrillaCategorias = new DataGridView();
            btnBuscarCat = new Button();
            txtBuscarCat = new TextBox();
            btnBorrarCat = new Button();
            btnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)GrillaCategorias).BeginInit();
            SuspendLayout();
            // 
            // GrillaCategorias
            // 
            GrillaCategorias.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GrillaCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GrillaCategorias.Location = new Point(12, 67);
            GrillaCategorias.Name = "GrillaCategorias";
            GrillaCategorias.Size = new Size(644, 357);
            GrillaCategorias.TabIndex = 0;
            GrillaCategorias.CellContentClick += GrillaCategorias_CellContentClick;
            // 
            // btnBuscarCat
            // 
            btnBuscarCat.Font = new Font("Segoe UI", 9F);
            btnBuscarCat.Location = new Point(319, 14);
            btnBuscarCat.Name = "btnBuscarCat";
            btnBuscarCat.Size = new Size(112, 47);
            btnBuscarCat.TabIndex = 1;
            btnBuscarCat.Text = "Buscar Categoria";
            btnBuscarCat.UseVisualStyleBackColor = true;
            // 
            // txtBuscarCat
            // 
            txtBuscarCat.Location = new Point(12, 28);
            txtBuscarCat.Name = "txtBuscarCat";
            txtBuscarCat.Size = new Size(301, 23);
            txtBuscarCat.TabIndex = 2;
            // 
            // btnBorrarCat
            // 
            btnBorrarCat.Location = new Point(437, 14);
            btnBorrarCat.Name = "btnBorrarCat";
            btnBorrarCat.Size = new Size(112, 47);
            btnBorrarCat.TabIndex = 3;
            btnBorrarCat.Text = "Borrar Categoria";
            btnBorrarCat.UseVisualStyleBackColor = true;
            btnBorrarCat.Click += btnBorrarCat_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(555, 14);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(112, 47);
            btnVolver.TabIndex = 4;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // FrmVerCategorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(674, 450);
            Controls.Add(btnVolver);
            Controls.Add(btnBorrarCat);
            Controls.Add(txtBuscarCat);
            Controls.Add(btnBuscarCat);
            Controls.Add(GrillaCategorias);
            Name = "FrmVerCategorias";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Categorias";
            WindowState = FormWindowState.Maximized;
            Load += FrmVerCategorias_Load;
            ((System.ComponentModel.ISupportInitialize)GrillaCategorias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView GrillaCategorias;
        private Button btnBuscarCat;
        private TextBox txtBuscarCat;
        private Button btnBorrarCat;
        private Button btnVolver;
    }
}