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
        int indiceImagenActual = 0;

        private List<Articulo> listaArticulos = null!;
        public FrmVerArticulos()
        {
            InitializeComponent();
        }

        private void FrmVerArticulos_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void GrillaArticulos_SelectionChanged(object sender, EventArgs e)
        {
            // cuando seleccionamos otro articulo el indice de imagen seleccionada se pone en 0 para la nueva seleccion
            indiceImagenActual = 0;

            if (GrillaArticulos.CurrentRow != null && GrillaArticulos.CurrentRow.DataBoundItem != null)
            {
                Articulo seleccion = (Articulo)GrillaArticulos.CurrentRow.DataBoundItem;
                if (!(seleccion.listaImagenes.Count == 0))
                {
                    CargarImagen(seleccion.listaImagenes[0].Url);
                }
                else
                {
                    PbxImagenArticulo.Image = Properties.Resources.PlaceHolder;
                }
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

        private void CargarGrilla()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                listaArticulos = negocio.Listar();
                GrillaArticulos.DataSource = listaArticulos;

                CargarImagen(listaArticulos[0].listaImagenes[0].Url);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la grilla" + ex.ToString());
            }
        }

        private void GrillaArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TxtBuscador_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnRecargar_Click(object sender, EventArgs e)
        {
            CargarGrilla();
            TxtBuscador.Focus();
        }

        // Cambia a la imagen anterior teniendo en cuenta el caso limite que ya estemos en la primer imagen, te llevaria a la ultima
        private void BtnAnteriorImagen_Click(object sender, EventArgs e)
        {
            if (GrillaArticulos.CurrentRow != null && GrillaArticulos.CurrentRow.DataBoundItem != null)
            {
                Articulo seleccion = (Articulo)GrillaArticulos.CurrentRow.DataBoundItem;

                if (!(seleccion.listaImagenes.Count == 0))
                {
                    if ((indiceImagenActual - 1) < 0)
                    {
                        indiceImagenActual = seleccion.listaImagenes.Count() - 1;
                    }
                    else
                    {
                        indiceImagenActual--;
                    }

                    CargarImagen(seleccion.listaImagenes[indiceImagenActual].Url);
                }
                else
                {
                    PbxImagenArticulo.Image = Properties.Resources.PlaceHolder;
                }
            }
        }

        // Cambia a la imagen anterior, el caso limite si estamos en la ultima imagen te llevaria a la primera
        private void BtnSiguienteImagen_Click(object sender, EventArgs e)
        {
            if (GrillaArticulos.CurrentRow != null && GrillaArticulos.CurrentRow.DataBoundItem != null)
            {
                Articulo seleccion = (Articulo)GrillaArticulos.CurrentRow.DataBoundItem;

                if (!(seleccion.listaImagenes.Count == 0))
                {
                    if ((indiceImagenActual + 1) > seleccion.listaImagenes.Count() - 1)
                    {
                        indiceImagenActual = 0;
                    }
                    else
                    {
                        indiceImagenActual++;
                    }

                    CargarImagen(seleccion.listaImagenes[indiceImagenActual].Url);
                }
                else
                {
                    PbxImagenArticulo.Image = Properties.Resources.PlaceHolder;
                }
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(FrmNuevoArticulo))
                {
                    return;
                }
            }

            Articulo seleccion;
            seleccion = (Articulo)GrillaArticulos.CurrentRow!.DataBoundItem!;

            FrmNuevoArticulo editar = new FrmNuevoArticulo(seleccion);

            editar.Size = this.Size;
            editar.StartPosition = FormStartPosition.CenterScreen;
            editar.ShowDialog();
            CargarGrilla();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (GrillaArticulos.CurrentRow != null && GrillaArticulos.CurrentRow.DataBoundItem != null)
            {
                DialogResult respuesta = MessageBox.Show("¿Seguro que vas a borrar este artículo?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    try
                    {
                        Articulo seleccionado = (Articulo)GrillaArticulos.CurrentRow.DataBoundItem;
                        ImagenNegocio imagenNegocio = new ImagenNegocio();
                        ArticuloNegocio articuloNegocio = new ArticuloNegocio();

                        imagenNegocio.EliminarImagenPorArticulo(seleccionado.Id);
                        articuloNegocio.EliminarArticulo(seleccionado);

                        MessageBox.Show("Articulo Eliminado exitosamente.");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error al eliminar el artículo.");
                    }

                    CargarGrilla();
                }

            }
        }
    }
}
