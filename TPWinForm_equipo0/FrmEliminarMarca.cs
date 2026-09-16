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
    public partial class FrmEliminarMarca : Form
    {
        public FrmEliminarMarca()
        {
            InitializeComponent();
        }

        private void FrmEliminarMarca_Load(object sender, EventArgs e)
        {
            cargamosGrilla(); 

        }

        private void cargamosGrilla()
        {
            MarcaNegocio negocio = new MarcaNegocio();
            try
            {
                
                List <Marca> lista = negocio.Listar();
                dgvMarcas.DataSource = lista;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las marcas: " + ex.Message,
                 "Error ## ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
                                    // editar O REVISAR by eze
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvMarcas.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una marca para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var seleccionada = dgvMarcas.CurrentRow.DataBoundItem as Marca;
            if (seleccionada == null)
            {
                MessageBox.Show("Seleccione una marca válida.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MarcaNegocio negocio = new MarcaNegocio();

            try
            { 

            if (negocio.tieneArticulosAsociados(seleccionada.Id))
            {
                MessageBox.Show(
           "No se puede eliminar la marca \"" + seleccionada.Nombre + "\" " + "porque tiene articulos asociados.\n\n" +
           "Primero elimina o reasigna esos artículos.",
           "No se puede eliminar",
           MessageBoxButtons.OK,
           MessageBoxIcon.Warning  );
                return;
            }  
            
            DialogResult     respuesta = MessageBox.Show
                ("¿Esta seguro de que desea eliminar la marca \"" + seleccionada.Nombre + "\"?",
                 "Confirmar eliminación",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question);

            if (respuesta != DialogResult.Yes) return; 
             
            negocio.Eliminar(seleccionada.Id);


            MessageBox.Show("Marca eliminada correctamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            cargamosGrilla(); // actualizamos la grilla después de eliminar

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la marca: " + ex.Message,
                 "Error #404 ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
