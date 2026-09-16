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
        private void CargarCategoria()
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            try
            {

                GrillaCategorias.DataSource = negocio.Listar();
                GrillaCategorias.Columns["Id"]!.Visible = false;
            }
            catch (Exception ex) { MessageBox.Show("Error al cargar las categorias: " + ex.ToString()); }

        }


        private void btnBorrarCat_Click(object sender, EventArgs e)
        {
            Categoria seleccionada;
            CategoriaNegocio negocio = new CategoriaNegocio();

            try
            {   // busque hacer para que sea el seleccionado
                seleccionada = (Categoria)GrillaCategorias.CurrentRow.DataBoundItem; 
                if (negocio.CategoriaEnUso(seleccionada.Id))
                {
                    MessageBox.Show("No se puede eliminar, categoria en uso");
                    return;
                }
                //este tambien lo busque, como poner cartel de si o no
                DialogResult respuesta = MessageBox.Show(
                    "¿Está seguro que desea eliminar la categoría?",
                    "Eliminar categoría",
                    MessageBoxButtons.YesNo);
                if(respuesta == DialogResult.Yes)
                {
                    negocio.Eliminar(seleccionada.Id);
                    MessageBox.Show("Categoria eliminada correctamente");
                    CargarCategoria(); //actualiza la bd
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la categoria" + ex.ToString());
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
