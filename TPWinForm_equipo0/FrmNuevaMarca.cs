using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Dominio; 
    using Negocio;

namespace TPWinForm_equipo0
{
    public partial class FrmNuevaMarca : Form
    {
        public FrmNuevaMarca()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // probar borrar,  crashea. 
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                errorProvider1.SetError(txtNombre, "Error 404, Nombre no puede estar null ");
                return;
            }
            errorProvider1.Clear();

            // trim : saca espacios al final y principio; 
            string nombre = txtNombre.Text.Trim();
            MarcaNegocio negocio = new MarcaNegocio();

            try
            {
                if (negocio.Existe(nombre))
                {
                    errorProvider1.SetError(txtNombre, "Error 404, Marca ya existe en la base de datos");
                    return;
                }

                Marca nueva = new Marca();
                nueva.Nombre = nombre;

                negocio.Agregar(nueva);

                MessageBox.Show("Marca creada correctamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
