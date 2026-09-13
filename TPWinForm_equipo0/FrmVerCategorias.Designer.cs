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
            ((System.ComponentModel.ISupportInitialize)GrillaCategorias).BeginInit();
            SuspendLayout();
            // 
            // GrillaCategorias
            // 
            GrillaCategorias.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GrillaCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GrillaCategorias.Location = new Point(12, 63);
            GrillaCategorias.Name = "GrillaCategorias";
            GrillaCategorias.Size = new Size(419, 375);
            GrillaCategorias.TabIndex = 0;
            GrillaCategorias.CellContentClick += GrillaCategorias_CellContentClick;
            // 
            // FrmVerCategorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(GrillaCategorias);
            Name = "FrmVerCategorias";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Categorias";
            WindowState = FormWindowState.Maximized;
            Load += FrmVerCategorias_Load;
            ((System.ComponentModel.ISupportInitialize)GrillaCategorias).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView GrillaCategorias;
    }
}