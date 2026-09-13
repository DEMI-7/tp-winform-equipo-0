using Dominio;
using Negocio;


namespace TPWinForm_equipo0
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            // Codigo para cambiar el color del fondo.
            foreach (Control control in this.Controls)
            {
                if (control is MdiClient)
                {
                    control.BackColor = Color.White;
                    break;
                }
            }

            // Configuracion inicial botones menu principal
            PnlOpcionesArticulos.Visible = false;
            PnlOpcionesCategorias.Visible = false;
            PnlOpcionesMarcas.Visible = false;
        }

        private void BtnArticulos_Click(object sender, EventArgs e)
        {
            bool esVisible = PnlOpcionesArticulos.Visible;

            PnlOpcionesCategorias.Visible = false;
            PnlOpcionesMarcas.Visible = false;

            PnlOpcionesArticulos.Visible = !esVisible;
        }

        private void BtnMarcas_Click(object sender, EventArgs e)
        {
            bool esVisible = PnlOpcionesMarcas.Visible;

            PnlOpcionesCategorias.Visible = false;
            PnlOpcionesArticulos.Visible = false;

            PnlOpcionesMarcas.Visible = !esVisible;
        }

        private void BtnCategorias_Click(object sender, EventArgs e)
        {
            bool esVisible = PnlOpcionesCategorias.Visible;

            PnlOpcionesMarcas.Visible = false;
            PnlOpcionesArticulos.Visible = false;

            PnlOpcionesCategorias.Visible = !esVisible;
        }

        private void BtnVerArticulos_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(FrmVerArticulos))
                {
                    return;
                }
            }

            CerrarFormulariosHijos();


            FrmVerArticulos ventana = new FrmVerArticulos();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void btnNuevaMarca_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(FrmNuevaMarca))
                {
                    return;
                }
            }

            FrmNuevaMarca ventana = new FrmNuevaMarca();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void CerrarFormulariosHijos()
        {
            // borrara formularios que sean hijos para solo permitir que exista el que abramos ultimo
            foreach (var item in this.MdiChildren)
            {
                item.Close();
            }
        }
    }

}
