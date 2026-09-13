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
    public partial class FrmVerCategorias : Form
    {
        public FrmVerCategorias()
        {
            InitializeComponent();
        }
        private void FrmVerCategorias_Load(object sender, EventArgs e)
        { CargarCategoria(); }


        private void GrillaCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void CargarCategoria() { 
            CategoriaNegocio negocio = new CategoriaNegocio();
            try
            {

                GrillaCategorias.DataSource = negocio.Listar();
                GrillaCategorias.Columns["Id"]!.Visible = false;
            }
            catch (Exception ex){ MessageBox.Show("Error al cargar las categorias: " + ex.ToString()); }

        }
    }
}
