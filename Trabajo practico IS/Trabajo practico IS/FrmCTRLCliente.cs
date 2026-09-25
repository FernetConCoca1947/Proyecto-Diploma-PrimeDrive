using Servicios;
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
            ActualizarEstadoBotones();
        }

        public void EnlazarClientes()
        {
            var clientes = GestorClientes.Listar().AsEnumerable();

            if (CKXmostrarInactivos.Checked == false)
            {
                clientes = clientes.Where(c => c.Activo == true);
            }

            DGV_CtrlCliClientes.DataSource = null;
            DGV_CtrlCliClientes.DataSource = clientes.ToList();
            DGV_CtrlCliClientes.ReadOnly = true;

            if (DGV_CtrlCliClientes.Columns["Id"] != null) DGV_CtrlCliClientes.Columns["Id"].Visible = false;
            if (DGV_CtrlCliClientes.Columns["Activo"] != null) DGV_CtrlCliClientes.Columns["Activo"].Visible = false;
            ActualizarEstadoBotones();
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
                if (string.IsNullOrWhiteSpace(TXT_CtrlCLiNombre.Text) ||
                    string.IsNullOrWhiteSpace(TXT_CtrlCliApellido.Text) ||
                    string.IsNullOrWhiteSpace(TXT_CtrlCliDNI.Text) ||
                    string.IsNullOrWhiteSpace(TXT_CtrlCliEmail.Text) ||
                    string.IsNullOrWhiteSpace(TXT_CtrlCliTelefono.Text) ||
                    string.IsNullOrWhiteSpace(TXT_CtrlCliLicencia.Text))
                {
                    MessageBox.Show("Debe completar todos los datos obligatorios.");
                    return;
                }

                if (!Regex.IsMatch(TXT_CtrlCliDNI.Text, @"^\d{8}$"))
                {
                    MessageBox.Show("DNI inválido. Ingrese 8 números.");
                    return;
                }

                if (!Regex.IsMatch(TXT_CtrlCliEmail.Text, @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$"))
                {
                    MessageBox.Show("Email inválido.");
                    return;
                }

                if (!Regex.IsMatch(TXT_CtrlCliTelefono.Text, @"^\d+$"))
                {
                    MessageBox.Show("El teléfono solo debe contener números.");
                    return;
                }

                BE.CLIENTE nuevoCliente = new BE.CLIENTE();
                nuevoCliente.Nombre = TXT_CtrlCLiNombre.Text;
                nuevoCliente.Apellido = TXT_CtrlCliApellido.Text;
                nuevoCliente.DNI = int.Parse(TXT_CtrlCliDNI.Text);
                nuevoCliente.Email = TXT_CtrlCliEmail.Text;
                nuevoCliente.Telefono = TXT_CtrlCliTelefono.Text;
                nuevoCliente.NumeroLicenciaConducir = TXT_CtrlCliLicencia.Text;
                nuevoCliente.FechaVencimientoLicencia = dateTimeVencimiento.Value.Date;

                BE.CLIENTE inactivoDuplicado = GestorClientes.ObtenerInactivoDuplicado(nuevoCliente);

                if (inactivoDuplicado != null)
                {
                    DialogResult result = MessageBox.Show(
                        "El DNI ingresado pertenece a un cliente que fue dado de baja.\n\n¿Desea reactivarlo para conservar su historial en el sistema en lugar de crear uno nuevo?",
                        "Cliente Inactivo Detectado",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        GestorClientes.Reactivar(inactivoDuplicado);
                        MessageBox.Show("El cliente ha sido reactivado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        EnlazarClientes();
                        LimpiarControles();
                        return;
                    }
                    else
                    {
                        return;
                    }
                }

                GestorClientes.Insertar(nuevoCliente);

                MessageBox.Show("Cliente registrado exitosamente.", "Alta Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                EnlazarClientes();
                LimpiarControles();
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
                        LimpiarControles();
                        ClienteSeleccionado = null;
                        ActualizarEstadoBotones();
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
            try
            {
                if (ClienteSeleccionado == null)
                {
                    MessageBox.Show("Seleccione un cliente para modificar.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(TXT_CtrlCLiNombre.Text) ||
                    string.IsNullOrWhiteSpace(TXT_CtrlCliApellido.Text) ||
                    string.IsNullOrWhiteSpace(TXT_CtrlCliDNI.Text) ||
                    string.IsNullOrWhiteSpace(TXT_CtrlCliEmail.Text) ||
                    string.IsNullOrWhiteSpace(TXT_CtrlCliTelefono.Text) ||
                    string.IsNullOrWhiteSpace(TXT_CtrlCliLicencia.Text))
                {
                    MessageBox.Show("Debe completar todos los datos obligatorios.");
                    return;
                }

                if (!Regex.IsMatch(TXT_CtrlCliDNI.Text, @"^\d{8}$"))
                {
                    MessageBox.Show("DNI inválido. Ingrese 8 números.");
                    return;
                }

                if (!Regex.IsMatch(TXT_CtrlCliEmail.Text, @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$"))
                {
                    MessageBox.Show("Email inválido.");
                    return;
                }

                if (!Regex.IsMatch(TXT_CtrlCliTelefono.Text, @"^\d+$"))
                {
                    MessageBox.Show("El teléfono solo debe contener números.");
                    return;
                }

                ClienteSeleccionado.Nombre = TXT_CtrlCLiNombre.Text;
                ClienteSeleccionado.Apellido = TXT_CtrlCliApellido.Text;
                ClienteSeleccionado.Email = TXT_CtrlCliEmail.Text;
                ClienteSeleccionado.Telefono = TXT_CtrlCliTelefono.Text;
                ClienteSeleccionado.NumeroLicenciaConducir = TXT_CtrlCliLicencia.Text;
                ClienteSeleccionado.FechaVencimientoLicencia = dateTimeVencimiento.Value.Date;

                GestorClientes.Modificar(ClienteSeleccionado);

                EnlazarClientes();
                LimpiarControles();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BTNCtrlCliReactivar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ClienteSeleccionado != null && ClienteSeleccionado.Activo == false)
                {
                    var result = MessageBox.Show($"¿Desea reactivar el producto: {ClienteSeleccionado.Nombre}?", "Confirmar Reactivación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        GestorClientes.Reactivar(ClienteSeleccionado);
                        EnlazarClientes();
                        LimpiarControles();
                        ClienteSeleccionado = null;
                        ActualizarEstadoBotones();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error al Reactivar", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void DGV_CtrlCliClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ClienteSeleccionado = DGV_CtrlCliClientes.Rows[e.RowIndex].DataBoundItem as BE.CLIENTE;
                if (ClienteSeleccionado != null)
                {
                    TXT_CtrlCLiNombre.Text = ClienteSeleccionado.Nombre;
                    TXT_CtrlCliApellido.Text = ClienteSeleccionado.Apellido;
                    TXT_CtrlCliDNI.Text = ClienteSeleccionado.DNI.ToString();
                    TXT_CtrlCliEmail.Text = ClienteSeleccionado.Email;
                    TXT_CtrlCliTelefono.Text = ClienteSeleccionado.Telefono.ToString();
                    TXT_CtrlCliLicencia.Text = ClienteSeleccionado.NumeroLicenciaConducir.ToString();
                    dateTimeVencimiento.Value = ClienteSeleccionado.FechaVencimientoLicencia;

                    ActualizarEstadoBotones();
                }

            }
        }

        private void ActualizarEstadoBotones()
        {
            if (ClienteSeleccionado == null)
            {
                BTNCtrlCliModificar.Enabled = false;
                BTNCtrlCliBaja.Enabled = false;
                BTNCtrlCliReactivar.Enabled = false;
                return;
            }
            if (ClienteSeleccionado.Activo == false)
            {
                BTNCtrlCliModificar.Enabled = false;
                BTNCtrlCliBaja.Enabled = false;
                BTNCtrlCliReactivar.Enabled = true;
            }
            else
            {
                BTNCtrlCliModificar.Enabled = true;
                BTNCtrlCliBaja.Enabled = true;
                BTNCtrlCliReactivar.Enabled = false;
            }
        }
        private void LimpiarControles()
        {
            TXT_CtrlCLiNombre.Text = "";
            TXT_CtrlCliApellido.Text = "";
            TXT_CtrlCliDNI.Text = "";
            TXT_CtrlCliEmail.Text = "";
            TXT_CtrlCliTelefono.Text = "";
            TXT_CtrlCliLicencia.Text = "";
            dateTimeVencimiento.Value = DateTime.Now.Date;
        }

        private void CKXmostrarInactivos_CheckedChanged(object sender, EventArgs e)
        {
            EnlazarClientes();
            LimpiarControles();
            ClienteSeleccionado = null;
        }

        private void FrmCTRLCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            Servicios.IDIOMAS.GetInstancia().Desuscribir(this);
        }

        private void BTNvolveralmenu_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Desea volver al menu principal?", "Atención",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
