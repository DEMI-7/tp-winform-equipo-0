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
            Marca seleccionada = (Marca)dgvMarcas.CurrentRow.DataBoundItem;

            DialogResult respuesta = MessageBox.Show($"¿Está seguro que desea eliminar la marca '{seleccionada.Nombre}'?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
             
            if (respuesta != DialogResult.Yes)
            {
                return; //el user  cancelo ; 
            }  
            MarcaNegocio negocio = new MarcaNegocio();

            try
            {
                negocio.Eliminar(seleccionada.Id);
                MessageBox.Show("Marca eliminada correctamente.", "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                cargamosGrilla(); // actualizamos la grilla después de eliminar
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la marca: " + ex.Message,
                                "Error ## ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
