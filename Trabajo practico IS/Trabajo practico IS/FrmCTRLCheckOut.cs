using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo_practico_IS
{
    public partial class FrmCTRLCheckOut : Form , BE.IObserver
    {
        BLL.IDIOMA gestorIdioma = new BLL.IDIOMA();
        public FrmCTRLCheckOut()
        {
            InitializeComponent();
        }
        private void FrmCTRLCheckOut_Load(object sender, EventArgs e)
        {
            CBXidiomas.SelectedIndexChanged -= CBXidiomas_SelectedIndexChanged;
            CBXidiomas.DataSource = gestorIdioma.Listar();
            CBXidiomas.DisplayMember = "Nombre";
            CBXidiomas.ValueMember = "Id";
            CBXidiomas.SelectedValue = Servicios.IDIOMAS.GetInstancia().IdIdiomaActual;
            CBXidiomas.SelectedIndexChanged += CBXidiomas_SelectedIndexChanged;
        }

        public void ActualizarIdioma()
        {
            var traducciones = Servicios.IDIOMAS.GetInstancia().Traducciones;
            TraducirControles(this.Controls, traducciones);
            if (traducciones.TryGetValue($"{this.Name}_Titulo", out string textoTitulo)) this.Text = textoTitulo;
            if (CBXidiomas.Items.Count > 0)
            {
                CBXidiomas.SelectedIndexChanged -= CBXidiomas_SelectedIndexChanged;
                CBXidiomas.SelectedValue = Servicios.IDIOMAS.GetInstancia().IdIdiomaActual;
                CBXidiomas.SelectedIndexChanged += CBXidiomas_SelectedIndexChanged;
            }
        }
        public void TraducirControles(Control.ControlCollection controles, Dictionary<string, string> traducciones)
        {
            foreach (Control control in controles)
            {
                string clave = $"{this.Name}_{control.Name}";
                if (traducciones.TryGetValue(clave, out string textoTraducido)) control.Text = textoTraducido;
                if (control.HasChildren) TraducirControles(control.Controls, traducciones);
            }
        }

        private void CBXidiomas_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (CBXidiomas.SelectedValue != null && int.TryParse(CBXidiomas.SelectedValue.ToString(), out int idIdioma))
                {
                    BLL.IDIOMA gestorIdioma = new BLL.IDIOMA();
                    var traducciones = gestorIdioma.ObtenerTraducciones(idIdioma);
                    Servicios.IDIOMAS.GetInstancia().CambiarIdioma(idIdioma, traducciones);

                    if (Servicios.SESION.GetInstancia().usuactual != null)
                    {
                        BLL.USUARIO gestorUsu = new BLL.USUARIO();
                        gestorUsu.ActualizarIdiomaUsuario(Servicios.SESION.GetInstancia().usuactual, idIdioma);
                        Servicios.SESION.GetInstancia().usuactual.IdIdioma = idIdioma;
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
