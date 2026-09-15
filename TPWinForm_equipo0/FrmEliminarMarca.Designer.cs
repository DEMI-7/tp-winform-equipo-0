namespace TPWinForm_equipo0
{
    partial class FrmEliminarMarca
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
            lblTitulo = new Label();
            lblAyuda = new Label();
            dgvMarcas = new DataGridView();
            btnEliminar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMarcas).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 13F);
            lblTitulo.Location = new Point(23, 18);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(128, 22);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Eliminar Marca";
            // 
            // lblAyuda
            // 
            lblAyuda.AutoSize = true;
            lblAyuda.Font = new Font("Segoe UI", 11F);
            lblAyuda.Location = new Point(46, 70);
            lblAyuda.Name = "lblAyuda";
            lblAyuda.Size = new Size(276, 20);
            lblAyuda.TabIndex = 1;
            lblAyuda.Text = "Selecciona la marca que queres eliminar";
            // 
            // dgvMarcas
            // 
            dgvMarcas.AllowUserToAddRows = false;
            dgvMarcas.AllowUserToDeleteRows = false;
            dgvMarcas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvMarcas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMarcas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMarcas.Location = new Point(37, 99);
            dgvMarcas.MultiSelect = false;
            dgvMarcas.Name = "dgvMarcas";
            dgvMarcas.ReadOnly = true;
            dgvMarcas.RowHeadersVisible = false;
            dgvMarcas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMarcas.Size = new Size(595, 248);
            dgvMarcas.TabIndex = 2;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(255, 128, 128);
            btnEliminar.ForeColor = SystemColors.ButtonFace;
            btnEliminar.Location = new Point(57, 364);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(156, 30);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar seleccionada";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(235, 364);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(87, 30);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmEliminarMarca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnEliminar);
            Controls.Add(dgvMarcas);
            Controls.Add(lblAyuda);
            Controls.Add(lblTitulo);
            Name = "FrmEliminarMarca";
            Text = "FrmEliminarMarca";
            Load += FrmEliminarMarca_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMarcas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblAyuda;
        private DataGridView dgvMarcas;
        private Button btnEliminar;
        private Button btnCancelar;
    }
}