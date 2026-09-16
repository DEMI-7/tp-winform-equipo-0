namespace TPWinForm_equipo0
{
    partial class FrmNuevaCategoria
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
            lblNuevaCat = new Label();
            txtNombreCat = new TextBox();
            btnAgregarCat = new Button();
            btnVolverCat = new Button();
            SuspendLayout();
            // 
            // lblNuevaCat
            // 
            lblNuevaCat.AutoSize = true;
            lblNuevaCat.Font = new Font("Consolas", 14F, FontStyle.Bold);
            lblNuevaCat.Location = new Point(28, 19);
            lblNuevaCat.Name = "lblNuevaCat";
            lblNuevaCat.Size = new Size(260, 22);
            lblNuevaCat.TabIndex = 0;
            lblNuevaCat.Text = "Ingresar nueva categoria:";
            lblNuevaCat.Click += label1_Click;
            // 
            // txtNombreCat
            // 
            txtNombreCat.Location = new Point(55, 55);
            txtNombreCat.Name = "txtNombreCat";
            txtNombreCat.Size = new Size(205, 23);
            txtNombreCat.TabIndex = 1;
            // 
            // btnAgregarCat
            // 
            btnAgregarCat.Location = new Point(28, 94);
            btnAgregarCat.Name = "btnAgregarCat";
            btnAgregarCat.Size = new Size(83, 36);
            btnAgregarCat.TabIndex = 2;
            btnAgregarCat.Text = "Agregar";
            btnAgregarCat.UseVisualStyleBackColor = true;
            btnAgregarCat.Click += btnAgregarCat_Click;
            // 
            // btnVolverCat
            // 
            btnVolverCat.Location = new Point(205, 94);
            btnVolverCat.Name = "btnVolverCat";
            btnVolverCat.Size = new Size(83, 36);
            btnVolverCat.TabIndex = 3;
            btnVolverCat.Text = "Volver";
            btnVolverCat.UseVisualStyleBackColor = true;
            btnVolverCat.Click += btnVolverCat_Click;
            // 
            // FrmNuevaCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVolverCat);
            Controls.Add(btnAgregarCat);
            Controls.Add(txtNombreCat);
            Controls.Add(lblNuevaCat);
            Name = "FrmNuevaCategoria";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nueva Categoria";
            WindowState = FormWindowState.Maximized;
            Load += FrmNuevaCategoria_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNuevaCat;
        private TextBox txtNombreCat;
        private Button btnAgregarCat;
        private Button btnVolverCat;
    }
}