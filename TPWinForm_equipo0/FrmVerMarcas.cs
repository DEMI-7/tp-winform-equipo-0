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
    public partial class FrmVerMarcas : Form
    {
        public FrmVerMarcas()
        {
            InitializeComponent();
        }

        private void FrmVerMarcas_Load(object sender, EventArgs e)
        {
           cargarGrilla ();

        }

        private void cargarGrilla()
        {
            MarcaNegocio negocio = new MarcaNegocio();
            try
            {
                List <Marca> lista = negocio.Listar();
                dgvMarcas.DataSource = lista;


            }
            catch (Exception ex)
            {
                MessageBox.Show( "Error al cargar las marcas: " + ex.Message,
                 "Error ## ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }   

        }

    }
}
