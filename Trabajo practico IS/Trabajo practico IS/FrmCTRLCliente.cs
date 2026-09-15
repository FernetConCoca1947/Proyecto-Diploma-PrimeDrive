using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo_practico_IS
{
    public partial class FrmCTRLCliente : Form, BE.IObserver
    {
        BLL.BITACORA GestorBitacora = new BLL.BITACORA();
        BLL.CLIENTE GestorClientes = new BLL.CLIENTE();
        BLL.IDIOMA gestorIdioma = new BLL.IDIOMA();
        BE.CLIENTE ClienteSeleccionado = null;
        public FrmCTRLCliente()
        {
            InitializeComponent();
        }

        private void FrmCTRLCliente_Load(object sender, EventArgs e)
        {
            Servicios.IDIOMAS.GetInstancia().Suscribir(this);
            CBXidiomas.SelectedIndexChanged -= CBXidiomas_SelectedIndexChanged;
            CBXidiomas.DataSource = gestorIdioma.Listar();
            CBXidiomas.DisplayMember = "Nombre";
            CBXidiomas.ValueMember = "Id";
            CBXidiomas.SelectedValue = Servicios.IDIOMAS.GetInstancia().IdIdiomaActual;
            CBXidiomas.SelectedIndexChanged += CBXidiomas_SelectedIndexChanged;
            ActualizarIdioma();
            EnlazarClientes();
        }

        public void EnlazarClientes()
        {
            var clientes = GestorClientes.Listar().AsEnumerable();

            //if (CKXmostrarInactivos.Checked == false)
            //{
            //    productos = productos.Where(p => p.Activo == true);
            //}

            DGV_CtrlCliClientes.DataSource = null;
            DGV_CtrlCliClientes.DataSource = clientes.ToList();
            DGV_CtrlCliClientes.ReadOnly = true;

            if (DGV_CtrlCliClientes.Columns["Id"] != null) DGV_CtrlCliClientes.Columns["Id"].Visible = false;
            if (DGV_CtrlCliClientes.Columns["Activo"] != null) DGV_CtrlCliClientes.Columns["Activo"].Visible = false;

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

        private void BTNCtrlCliAlta_Click(object sender, EventArgs e)
        {

            try
            {
                if (!(string.IsNullOrEmpty(TXT_CtrlCliApellido.Text) || string.IsNullOrEmpty(TXT_CtrlCliApellido.Text) || string.IsNullOrEmpty(TXT_CtrlCliDNI.Text) || string.IsNullOrEmpty(TXT_CtrlCliEmail.Text) || string.IsNullOrEmpty(TXT_CtrlCliTelefono.Text) || string.IsNullOrEmpty(TXT_CtrlCliLicencia.Text)))
                {
                    if (!Regex.IsMatch(TXT_CtrlCliDNI.Text, @"^\d{8}$"))
                    {
                        MessageBox.Show("DNI inválido.");
                        return;
                    }

                    if (!Regex.IsMatch(TXT_CtrlCliEmail.Text, @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$"))
                    {
                        MessageBox.Show("Email inválido.");
                        return;
                    }
                    BE.CLIENTE nuevoCliente = new BE.CLIENTE();
                    nuevoCliente.Nombre = TXT_CtrlCLiNombre.Text;
                    nuevoCliente.Apellido = TXT_CtrlCliApellido.Text;
                    nuevoCliente.DNI = int.Parse(TXT_CtrlCliDNI.Text);
                    nuevoCliente.Email = TXT_CtrlCliEmail.Text;
                    nuevoCliente.Telefono = int.Parse(TXT_CtrlCliTelefono.Text);
                    nuevoCliente.NumeroLicenciaConducir = TXT_CtrlCliLicencia.Text;
                    nuevoCliente.FechaVencimientoLicencia = dateTimeVencimiento.Value.Date;


                    BE.CLIENTE inactivoDuplicado = GestorClientes.ObtenerInactivoDuplicado(nuevoCliente);

                    if (inactivoDuplicado != null)
                    {
                        var result = MessageBox.Show("El DNI ingresado pertenece a un cliente que fue dado de baja.\n\n¿Desea reactivarlo para conservar su historial en el sistema en lugar de crear uno nuevo?",
                                                     "Cliente Inactivo Detectado",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            GestorClientes.Reactivar(inactivoDuplicado);
                            MessageBox.Show("El cliente ha sido reactivado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            EnlazarClientes();
                            //LimpiarControles();
                            return;
                        }
                        else
                        {
                            return;
                        }
                    }

                    GestorClientes.Insertar(nuevoCliente);

                    EnlazarClientes();
                    //LimpiarControles();
                }
                else
                {
                    throw new Exception("Debe completar todos los datos");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BTNCtrlCliBaja_Click(object sender, EventArgs e)
        {
            try
            {
                if (ClienteSeleccionado != null)
                {
                    var result = MessageBox.Show($"Esta seguro que desea borrar: {ClienteSeleccionado.Nombre}, {ClienteSeleccionado.Apellido}?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        GestorClientes.Borrar(ClienteSeleccionado);
                        EnlazarClientes();
                        //LimpiarControles();
                        ClienteSeleccionado = null;
                        //ActualizarEstadoBotones();
                    }
                }
                else
                {
                    throw new Exception("Seleccione un cliente para borrar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BTNCtrlCliModificar_Click(object sender, EventArgs e)
        {

        }

        private void BTNCtrlCliReactivar_Click(object sender, EventArgs e)
        {

        }

        private void DGV_CtrlCliClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ClienteSeleccionado = DGV_CtrlCliClientes.Rows[e.RowIndex].DataBoundItem as BE.CLIENTE;
                //if (productoSeleccionado != null)
                //{
                //    TXT_ProductoNombre.Text = productoSeleccionado.Nombre;
                //    NUD_PrecioProd.Value = productoSeleccionado.Precio;
                //    NUD_StockProd.Value = productoSeleccionado.Stock;

                //    ActualizarEstadoBotones();
                //}

            }
        }
    }
}
