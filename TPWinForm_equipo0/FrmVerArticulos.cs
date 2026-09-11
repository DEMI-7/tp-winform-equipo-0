using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TPWinForm_equipo0
{
    public partial class FrmVerArticulos : Form
    {
        public FrmVerArticulos()
        {
            InitializeComponent();
        }

        private void FrmVerArticulos_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            
            try
            {
                GrillaArticulos.DataSource = negocio.listar();

                // Le cambio el nombre a esas columnas para que se vea mejor y ademas oculto el Id interno de la base de datos
                // usar "!" es para asegurarle a la funcion que no recibira un valor nulo
                GrillaArticulos.Columns["MarcaProducto"]!.HeaderText = "Marca";
                GrillaArticulos.Columns["CategoriaProducto"]!.HeaderText = "Categoria";

                GrillaArticulos.Columns["Id"]!.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la grilla" + ex.ToString());
            }

        }
    }
}
