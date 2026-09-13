using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Negocio;

namespace TPWinForm_equipo0
{
    public partial class FrmNuevoArticulo : Form
    {
        public FrmNuevoArticulo()
        {
            InitializeComponent();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            Articulo nuevo = new Articulo();

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


            try
            {
                nuevo.Codigo = TxtCodigo.Text;
                nuevo.Nombre = TxtNombre.Text;
                nuevo.Descripcion = TxtDescripcion.Text;
                nuevo.CategoriaProducto = (Categoria)ComboCategoria.SelectedItem!;
                nuevo.MarcaProducto = (Marca)ComboMarca.SelectedItem!;
                if (string.IsNullOrWhiteSpace(TxtPrecio.Text))
                {
                    nuevo.Precio = 0;
                }
                else if (decimal.TryParse(TxtPrecio.Text, out decimal precioIngresado))
                {
                    nuevo.Precio = precioIngresado;
                }
                else
                {
                    MessageBox.Show("El precio ingresado no es valido, solo se permiten números.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                ArticuloNegocio negocio = new ArticuloNegocio();
                negocio.NuevoRegistro(nuevo);
                MessageBox.Show("Agregado exitosamente");
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

            List<Categoria> listaCategorias = new List<Categoria>();
            List<Marca> listaMarcas = new List<Marca>();

            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            MarcaNegocio marcaNegocio = new MarcaNegocio();

            try
            {
                listaCategorias = categoriaNegocio.Listar();
                listaMarcas = marcaNegocio.Listar();

                ComboCategoria.DataSource = listaCategorias;
                ComboMarca.DataSource = listaMarcas;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
