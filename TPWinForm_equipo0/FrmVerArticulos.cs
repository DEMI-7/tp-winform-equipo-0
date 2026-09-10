using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TPWinForm_equipo0
{
    public partial class FrmVerArticulos : Form
    {
        public FrmVerArticulos()
        {
            InitializeComponent();
        }

        private void FrmVerArticulos_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            GrillaArticulos.DataSource = negocio.listar();

        }
    }
}
