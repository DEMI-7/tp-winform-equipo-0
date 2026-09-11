using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TPWinForm_equipo0.Properties;

namespace TPWinForm_equipo0
{
    public partial class FrmVerArticulos : Form
    {
        private List<Articulo> listaArticulos = null!;
        public FrmVerArticulos()
        {
            InitializeComponent();
        }

        private void FrmVerArticulos_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                listaArticulos = negocio.Listar();
                GrillaArticulos.DataSource = listaArticulos;

                // Le cambio el nombre a esas columnas para que se vea mejor y ademas oculto el Id interno de la base de datos
                // usar "!" es para asegurarle a la funcion que no recibira un valor nulo
                GrillaArticulos.Columns["MarcaProducto"]!.HeaderText = "Marca";
                GrillaArticulos.Columns["CategoriaProducto"]!.HeaderText = "Categoria";

                GrillaArticulos.Columns["Id"]!.Visible = false;

                CargarImagen(listaArticulos[0].listaImagenes[0].Url);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la grilla" + ex.ToString());
            }

        }

        private void GrillaArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (GrillaArticulos.CurrentRow != null && GrillaArticulos.CurrentRow.DataBoundItem != null)
            {
                Articulo seleccion = (Articulo)GrillaArticulos.CurrentRow.DataBoundItem;
                CargarImagen(seleccion.listaImagenes[0].Url);
            }
        }

        private void CargarImagen(string imagen)
        {
            try
            {
                PbxImagenArticulo.Load(imagen);
            }
            catch (Exception)
            {
                PbxImagenArticulo.Image = Properties.Resources.PlaceHolder;
            }
        }
    }
}
