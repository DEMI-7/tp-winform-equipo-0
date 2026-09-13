using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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

            try
            {
                nuevo.Codigo = TbxCodigo.Text;
                nuevo.Nombre = TbxNombre.Text;
                nuevo.Descripcion = TbxDescripcion.Text;
                nuevo.Precio = decimal.Parse(TbxPrecio.Text);
                nuevo.listaImagenes.Add(new Imagen());
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
