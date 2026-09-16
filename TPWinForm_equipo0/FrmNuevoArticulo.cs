using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Negocio;
using Microsoft.IdentityModel.Abstractions;

namespace TPWinForm_equipo0
{
    public partial class FrmNuevoArticulo : Form
    {

        // La binding list es una lista que actualiza automaticamente la grilla
        // tuve que usarla porque me daba un error la lista comun al actualizarla a mano
        // fue la unica forma de solucionarlo, igual funciona igual que una lista para nuestro caso y no nos cambia en nada mas
        private BindingList<Imagen> imagenesArticulo = new BindingList<Imagen>();

        private Articulo articulo = null!;

        public FrmNuevoArticulo()
        {
            InitializeComponent();
        }

        public FrmNuevoArticulo(Articulo seleccionado)
        {
            InitializeComponent();
            this.articulo = seleccionado;
            Text = "Editar articulo";
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            //Articulo nuevo = new Articulo();

            ArticuloNegocio negocio = new ArticuloNegocio();
            ImagenNegocio negocioImagen = new ImagenNegocio();

            if (string.IsNullOrWhiteSpace(TxtCodigo.Text))
            {
                MessageBox.Show("El campo Código es obligatorio.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtCodigo.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(TxtNombre.Text))
            {
                MessageBox.Show("El campo Nombre es obligatorio.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtCodigo.Focus();
                return;
            }
            if (articulo == null && negocio.ObtenerIdPorCodigo(TxtCodigo.Text) != 0)
            {
                MessageBox.Show("El Codigo ya esta en uso.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtCodigo.Focus();
                return;
            }
            else if (articulo != null && articulo.Codigo != TxtCodigo.Text)
            {
                if (negocio.ObtenerIdPorCodigo(TxtCodigo.Text) != 0)
                {
                    MessageBox.Show("El Codigo ya esta en uso.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TxtCodigo.Focus();
                    return;
                }
            }


            try
            {
                if (articulo == null)
                {
                    articulo = new Articulo();
                }

                articulo.Codigo = TxtCodigo.Text;
                articulo.Nombre = TxtNombre.Text;
                articulo.Descripcion = TxtDescripcion.Text;
                articulo.CategoriaProducto = (Categoria)ComboCategoria.SelectedItem!;
                articulo.MarcaProducto = (Marca)ComboMarca.SelectedItem!;
                if (string.IsNullOrWhiteSpace(TxtPrecio.Text))
                {
                    articulo.Precio = 0;
                }
                else if (decimal.TryParse(TxtPrecio.Text, out decimal precioIngresado))
                {
                    articulo.Precio = precioIngresado;
                }
                else
                {
                    MessageBox.Show("El precio ingresado no es valido, solo se permiten números.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (articulo.Id != 0)
                {
                    try
                    {
                        negocio.Modificar(articulo);
                        negocioImagen.Modificar(articulo.Id, imagenesArticulo.ToList());

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error al modificar");
                    }

                }
                else
                {
                    negocio.NuevoRegistro(articulo);

                    // en este bloque guardamos las imagenes
                    int idNuevoArticulo = negocio.ObtenerIdPorCodigo(articulo.Codigo);

                    if (idNuevoArticulo > 0 && imagenesArticulo.Count > 0)
                    {

                        try
                        {
                            foreach (Imagen img in imagenesArticulo)
                            {
                                negocioImagen.GuardarImagen(idNuevoArticulo, img.Url);
                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Las imagenes no se agregaron correctamente");
                        }
                    }
                    MessageBox.Show("Agregado exitosamente");
                }

                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmNuevoArticulo_Load(object sender, EventArgs e)
        {
            // Cargamos los datos de los combo box categoria y marca

            List<Categoria> listaCategorias;
            List<Marca> listaMarcas;

            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            MarcaNegocio marcaNegocio = new MarcaNegocio();

            try
            {
                listaCategorias = categoriaNegocio.Listar();
                listaMarcas = marcaNegocio.Listar();

                ComboCategoria.DataSource = listaCategorias;
                ComboCategoria.ValueMember = "Id";
                ComboCategoria.DisplayMember = "Nombre";

                ComboMarca.DataSource = listaMarcas;
                ComboMarca.ValueMember = "Id";
                ComboMarca.DisplayMember = "Nombre";

                if (articulo != null)
                {
                    TxtCodigo.Text = articulo.Codigo;
                    TxtNombre.Text = articulo.Nombre;
                    TxtDescripcion.Text = articulo.Descripcion;
                    TxtPrecio.Text = articulo.Precio.ToString();

                    if (!(articulo.listaImagenes.Count == 0))
                    {
                        CargarImagen(articulo.listaImagenes[0].Url);
                    }
                    else
                    {
                        PbxImagenArticulo.Image = Properties.Resources.PlaceHolder;
                    }

                    imagenesArticulo = new BindingList<Imagen>(articulo.listaImagenes);

                    ComboCategoria.SelectedValue = articulo.CategoriaProducto.Id;
                    ComboMarca.SelectedValue = articulo.MarcaProducto.Id;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            PbxImagenArticulo.Image = Properties.Resources.PlaceHolder;

            GrillaUrlImagenes.DataSource = imagenesArticulo;
        }

        private bool CargarImagen(string imagen)
        {
            try
            {
                PbxImagenArticulo.Load(imagen);
                return true;
            }
            catch (Exception)
            {
                PbxImagenArticulo.Image = Properties.Resources.PlaceHolder;
                return false;
            }
        }

        // Al darle al enter del teclado intenta cargar la imagen y la suma a la grilla
        private void TxtUrlImagen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                string nuevaUrl = TxtUrlImagen.Text.Trim();

                if (string.IsNullOrEmpty(nuevaUrl))
                {
                    return;
                }
                else if (CargarImagen(nuevaUrl))
                {
                    imagenesArticulo.Add(new Imagen(nuevaUrl));

                    TxtUrlImagen.Clear();
                    TxtUrlImagen.Focus();
                }
                else
                {
                    TxtUrlImagen.Clear();
                    TxtUrlImagen.Focus();
                    ErrorUrlImagen.SetError(TxtUrlImagen, "La URL no es válida o es inaccesible.");
                }
            }
        }

        // Pega lo que tenga el portapapeles en el campo url imagen
        private void BtnPegar_Click(object sender, EventArgs e)
        {
            ErrorUrlImagen.SetError(TxtUrlImagen, "");

            if (Clipboard.ContainsText() && !string.IsNullOrWhiteSpace(Clipboard.GetText()))
            {
                TxtUrlImagen.Text = Clipboard.GetText().Trim();
                TxtUrlImagen.Focus();
                TxtUrlImagen.SelectionStart = TxtUrlImagen.Text.Length;
            }
            else
            {
                ErrorUrlImagen.SetError(TxtUrlImagen, "El portapapeles no contiene texto o una URL válida.");
            }
        }

        // Al tocar el boton que dice "enter" hace lo mismo que con el teclado
        private void BtnEnter_Click(object sender, EventArgs e)
        {
            string nuevaUrl = TxtUrlImagen.Text.Trim();

            if (string.IsNullOrEmpty(nuevaUrl))
            {
                return;
            }
            else if (CargarImagen(nuevaUrl))
            {
                imagenesArticulo.Add(new Imagen(nuevaUrl));

                TxtUrlImagen.Clear();
                TxtUrlImagen.Focus();
            }
            else
            {
                TxtUrlImagen.Clear();
                TxtUrlImagen.Focus();
                ErrorUrlImagen.SetError(TxtUrlImagen, "La URL no es válida o es inaccesible.");
            }
        }

        // Cambiar imagen en la seleccion de la grilla
        private void GrillaUrlImagenes_SelectionChanged(object sender, EventArgs e)
        {
            if (GrillaUrlImagenes.CurrentRow != null && GrillaUrlImagenes.CurrentRow.DataBoundItem != null)
            {
                Imagen seleccion = (Imagen)GrillaUrlImagenes.CurrentRow.DataBoundItem;

                CargarImagen(seleccion.Url);

            }
        }

        private void BtnEliminarImagen_Click(object sender, EventArgs e)
        {
            if (GrillaUrlImagenes.CurrentRow != null && GrillaUrlImagenes.CurrentRow.DataBoundItem != null)
            {
                DialogResult respuesta = MessageBox.Show("¿Seguro que vas a borrar esta foto?", "Confirmar eliminación",MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    Imagen seleccion = (Imagen)GrillaUrlImagenes.CurrentRow.DataBoundItem;
                    imagenesArticulo.Remove(seleccion);

                    if (!(imagenesArticulo.Count == 0))
                    {
                        CargarImagen(imagenesArticulo[0].Url);
                    }
                    else
                    {
                        PbxImagenArticulo.Image = Properties.Resources.PlaceHolder;
                    }
                }
            }
        }
    }
}
