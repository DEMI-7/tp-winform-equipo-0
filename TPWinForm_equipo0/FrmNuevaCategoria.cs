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
    public partial class FrmNuevaCategoria : Form
    {
        public FrmNuevaCategoria()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmNuevaCategoria_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregarCat_Click(object sender, EventArgs e)
        {
            Categoria nueva = new Categoria();
            CategoriaNegocio negocio = new CategoriaNegocio();
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombreCat.Text))
                {
                    MessageBox.Show("Debe ingresar un nombre de categoria.");
                    return;
                }
                nueva.Nombre = txtNombreCat.Text;
                negocio.Agregar(nueva);
                MessageBox.Show("Categoria agregada correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la categoria." + ex.ToString);
            }
        }

        private void btnVolverCat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
