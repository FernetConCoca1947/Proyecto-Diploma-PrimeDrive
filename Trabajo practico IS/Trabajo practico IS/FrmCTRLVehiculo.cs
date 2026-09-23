using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo_practico_IS
{
    public partial class FrmCTRLVehiculo : Form, BE.IObserver
    {
        private BLL.VEHICULO GestorVehiculos = new BLL.VEHICULO();
        private BLL.CATEGORIA GestorCategoria = new BLL.CATEGORIA();
        private BLL.SUCURSAL GestorSucursales= new BLL.SUCURSAL();
        private BLL.ESTADO GestorEstados = new BLL.ESTADO();
        BLL.IDIOMA gestorIdioma = new BLL.IDIOMA();
        private BE.VEHICULO vehiculoSeleccionado = null;
        public FrmCTRLVehiculo()
        {
            InitializeComponent();
        }
        private void FrmCTRLVehiculo_Load(object sender, EventArgs e)
        {
            Servicios.IDIOMAS.GetInstancia().Suscribir(this);
            CBXidiomas.SelectedIndexChanged -= CBXidiomas_SelectedIndexChanged;
            CBXidiomas.DataSource = gestorIdioma.Listar();
            CBXidiomas.DisplayMember = "Nombre";
            CBXidiomas.ValueMember = "Id";
            CBXidiomas.SelectedValue = Servicios.IDIOMAS.GetInstancia().IdIdiomaActual;
            CBXidiomas.SelectedIndexChanged += CBXidiomas_SelectedIndexChanged;
            ActualizarIdioma();
            EnlazarVehiculos();
        }

        public void EnlazarVehiculos()
        {
            var vehiculos = GestorVehiculos.Listar().AsEnumerable();

            //if (CKXmostrarInactivos.Checked == false)
            //{
            //    vehiculos = vehiculos.Where(cc => c. == true);
            //}

            DGV_Vehiculos.DataSource = null;
            DGV_Vehiculos.DataSource = vehiculos.ToList();
            DGV_Vehiculos.ReadOnly = true;

            if (DGV_Vehiculos.Columns["Id"] != null) DGV_Vehiculos.Columns["Id"].Visible = false;
            if (DGV_Vehiculos.Columns["Activo"] != null) DGV_Vehiculos.Columns["Activo"].Visible = false;
            //ActualizarEstadoBotones();
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

        private void LimpiarControles()
        {
            TXT_CtrlVehPatente.Text = "";
            TXT_CtrlVehMarca.Text = "";
            TXT_CtrlVehModelo.Text = "";
            NUM_KmActual.Value = 0;
            CBX_Categoria.SelectedIndex = -1;
            CBX_Sucursal.SelectedIndex = -1;
            CBX_Estado.SelectedIndex = -1;
            vehiculoSeleccionado = null;
        }

        private void BTNCtrlVehAlta_Click(object sender, EventArgs e)
        {
            try
            {
                BE.VEHICULO nuevoVehiculo = new BE.VEHICULO();
                nuevoVehiculo.Patente = TXT_CtrlVehPatente.Text;
                nuevoVehiculo.Marca = TXT_CtrlVehMarca.Text.Trim();
                nuevoVehiculo.Modelo = TXT_CtrlVehModelo.Text.Trim();
                nuevoVehiculo.KmActual = (int)NUM_KmActual.Value;
                nuevoVehiculo.Categoria = (BE.CATEGORIA)CBX_Categoria.SelectedItem;
                nuevoVehiculo.Sucursal = (BE.SUCURSAL)CBX_Sucursal.SelectedItem;
                nuevoVehiculo.Estado = (BE.ESTADO)CBX_Estado.SelectedItem;

                if (string.IsNullOrWhiteSpace(nuevoVehiculo.Patente))
                {
                    MessageBox.Show("La patente es obligatoria.");
                    return;
                }

                BE.VEHICULO inactivoDuplicado = GestorVehiculos.ObtenerInactivoDuplicado(nuevoVehiculo.Patente);

                if (inactivoDuplicado != null)
                {
                    DialogResult result = MessageBox.Show(
                        $"La patente {nuevoVehiculo.Patente} pertenece a un vehículo que fue dado de baja de la flota.\n\n¿Desea reactivarlo y devolverlo al estado 'Disponible' para conservar su historial de mantenimientos?",
                        "Vehículo Inactivo Detectado",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        GestorVehiculos.Reactivar(inactivoDuplicado);

                        MessageBox.Show("El vehículo ha sido reactivado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        EnlazarVehiculos();
                        LimpiarControles();
                        return;
                    }
                    else
                    {
                        return;
                    }
                }

                GestorVehiculos.Insertar(nuevoVehiculo);
                EnlazarVehiculos();
                LimpiarControles();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BTNCtrlVehBaja_Click(object sender, EventArgs e)
        {
            try
            {
                if (vehiculoSeleccionado != null)
                {
                    var result = MessageBox.Show($"Esta seguro que desea borrar: {vehiculoSeleccionado.Patente}?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        GestorVehiculos.Borrar(vehiculoSeleccionado);
                        EnlazarVehiculos();
                        LimpiarControles();
                        vehiculoSeleccionado = null;
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

        private void BTNCtrlVehModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (vehiculoSeleccionado == null)
                {
                    MessageBox.Show("Seleccione un cliente para modificar.");
                    return;
                }

                BE.VEHICULO nuevoVehiculo = new BE.VEHICULO();
                nuevoVehiculo.Patente = TXT_CtrlVehPatente.Text;
                nuevoVehiculo.Marca = TXT_CtrlVehMarca.Text.Trim();
                nuevoVehiculo.Modelo = TXT_CtrlVehModelo.Text.Trim();
                nuevoVehiculo.KmActual = (int)NUM_KmActual.Value;
                nuevoVehiculo.Categoria = (BE.CATEGORIA)CBX_Categoria.SelectedItem;
                nuevoVehiculo.Sucursal = (BE.SUCURSAL)CBX_Sucursal.SelectedItem;
                nuevoVehiculo.Estado = (BE.ESTADO)CBX_Estado.SelectedItem;

                GestorVehiculos.Modificar(vehiculoSeleccionado);

                EnlazarVehiculos();
                LimpiarControles();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BTNCtrlVehReactivar_Click(object sender, EventArgs e)
        {
            try
            {
                if (vehiculoSeleccionado != null && vehiculoSeleccionado.Estado.IdEstado == 4)
                {
                    var result = MessageBox.Show($"¿Desea reactivar el vehiculo: {vehiculoSeleccionado.Patente}?", "Confirmar Reactivación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        GestorVehiculos.Reactivar(vehiculoSeleccionado);
                        EnlazarVehiculos();
                        LimpiarControles();
                        vehiculoSeleccionado = null;
                        //ActualizarEstadoBotones();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error al Reactivar", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void DGV_Vehiculos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                vehiculoSeleccionado = DGV_Vehiculos.Rows[e.RowIndex].DataBoundItem as BE.VEHICULO;
                if (vehiculoSeleccionado != null)
                {
                    TXT_CtrlVehPatente.Text = vehiculoSeleccionado.Patente;
                    TXT_CtrlVehMarca.Text = vehiculoSeleccionado.Marca;
                    TXT_CtrlVehModelo.Text = vehiculoSeleccionado.Modelo;
                    NUM_KmActual.Value = vehiculoSeleccionado.KmActual;
                    AsignarComboBox(CBX_Categoria, vehiculoSeleccionado.Categoria.Id);
                    AsignarComboBox(CBX_Sucursal, vehiculoSeleccionado.Sucursal.Id);
                    AsignarComboBox(CBX_Estado, vehiculoSeleccionado.Estado.IdEstado);

                    //ActualizarEstadoBotones();
                }

            }
        }
        private void AsignarComboBox(ComboBox combo, int idBuscado)
        {
            foreach (var item in combo.Items)
            {
                // Reflexión básica para comparar IDs genéricamente, o casteos explícitos
                if (item is BE.CATEGORIA cat && cat.Id == idBuscado) combo.SelectedItem = item;
                else if (item is BE.SUCURSAL suc && suc.Id == idBuscado) combo.SelectedItem = item;
                else if (item is BE.ESTADO est && est.IdEstado == idBuscado) combo.SelectedItem = item;
            }
        }
    }
}
