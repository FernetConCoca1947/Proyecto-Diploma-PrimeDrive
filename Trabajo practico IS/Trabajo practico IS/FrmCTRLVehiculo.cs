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
        private BLL.IDIOMA gestorIdioma = new BLL.IDIOMA();
        private BE.VEHICULO vehiculoSeleccionado = null;
        private List<BE.VEHICULO> listaVehiculosOriginal;
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
            CargarFiltros();
            CargarComboBoxes();
            EnlazarVehiculos();
        }

        public void EnlazarVehiculos()
        {
            try
            {
                listaVehiculosOriginal = GestorVehiculos.Listar();

                AplicarFiltros();

                if (DGV_Vehiculos.Columns["Id"] != null) DGV_Vehiculos.Columns["Id"].Visible = false;
                if (DGV_Vehiculos.Columns["Activo"] != null) DGV_Vehiculos.Columns["Activo"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la flota: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AplicarFiltros()
        {
            if (listaVehiculosOriginal == null) return;

            var listaFiltrada = listaVehiculosOriginal.AsEnumerable();

            string busquedaPatente = TXT_FiltroPatente.Text.Trim().ToUpper();
            if (!string.IsNullOrWhiteSpace(busquedaPatente))
            {
                listaFiltrada = listaFiltrada.Where(v => v.Patente.Contains(busquedaPatente));
            }

            if (CBX_FiltroEstadoVeh.SelectedIndex > 0)
            {
                var estadoSel = (BE.ESTADO)CBX_FiltroEstadoVeh.SelectedItem;
                listaFiltrada = listaFiltrada.Where(v => v.Estado.IdEstado == estadoSel.IdEstado);
            }

            if (CBX_FiltroCategoriaVeh.SelectedIndex > 0)
            {
                var categoriaSel = (BE.CATEGORIA)CBX_FiltroCategoriaVeh.SelectedItem;
                listaFiltrada = listaFiltrada.Where(v => v.Categoria.Id == categoriaSel.Id);
            }

            DGV_Vehiculos.DataSource = null;
            DGV_Vehiculos.DataSource = listaFiltrada.ToList();

            DGV_Vehiculos.ClearSelection();
            ActualizarEstadoBotones();
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
                        ActualizarEstadoBotones();
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
                ActualizarEstadoBotones();
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

        private void BTNCtrlVehModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (vehiculoSeleccionado == null)
                {
                    MessageBox.Show("Seleccione un cliente para modificar.");
                    return;
                }

                vehiculoSeleccionado.Patente = TXT_CtrlVehPatente.Text;
                vehiculoSeleccionado.Marca = TXT_CtrlVehMarca.Text.Trim();
                vehiculoSeleccionado.Modelo = TXT_CtrlVehModelo.Text.Trim();
                vehiculoSeleccionado.KmActual = (int)NUM_KmActual.Value;
                vehiculoSeleccionado.Categoria = (BE.CATEGORIA)CBX_Categoria.SelectedItem;
                vehiculoSeleccionado.Sucursal = (BE.SUCURSAL)CBX_Sucursal.SelectedItem;
                vehiculoSeleccionado.Estado = (BE.ESTADO)CBX_Estado.SelectedItem;

                GestorVehiculos.Modificar(vehiculoSeleccionado);

                EnlazarVehiculos();
                LimpiarControles();
                ActualizarEstadoBotones();
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
                        ActualizarEstadoBotones();
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

                    ActualizarEstadoBotones();
                }

            }
        }

        private void CargarComboBoxes()
        {
            CBX_Categoria.DataSource = GestorCategoria.Listar();

            CBX_Sucursal.DataSource = GestorSucursales.Listar();

            CBX_Estado.DataSource = GestorEstados.ListarPorAmbito("Vehiculo");
        }
        private void AsignarComboBox(ComboBox combo, int idBuscado)
        {
            foreach (var item in combo.Items)
            {
                if (item is BE.CATEGORIA cat && cat.Id == idBuscado) combo.SelectedItem = item;
                else if (item is BE.SUCURSAL suc && suc.Id == idBuscado) combo.SelectedItem = item;
                else if (item is BE.ESTADO est && est.IdEstado == idBuscado) combo.SelectedItem = item;
            }
        }

        private void ActualizarEstadoBotones()
        {

            if (vehiculoSeleccionado == null)
            {
                BTNCtrlVehAlta.Enabled = true;

                BTNCtrlVehModificar.Enabled = false;
                BTNCtrlVehBaja.Enabled = false;
                BTNCtrlVehReactivar.Enabled = false;
            }
            else
            {

                if (vehiculoSeleccionado.Estado.IdEstado == 4)
                {
                    BTNCtrlVehReactivar.Enabled = true;

                    BTNCtrlVehAlta.Enabled = false;
                    BTNCtrlVehModificar.Enabled = false;
                    BTNCtrlVehBaja.Enabled = false;
                }

                else
                {
                    BTNCtrlVehModificar.Enabled = true;
                    BTNCtrlVehBaja.Enabled = true;

                    BTNCtrlVehAlta.Enabled = false;
                    BTNCtrlVehReactivar.Enabled = false;
                }
            }
        }
        private void CargarFiltros()
        {
            List<BE.ESTADO> listaEstados = GestorEstados.ListarPorAmbito("Vehiculo");

            listaEstados.Insert(0, new BE.ESTADO { IdEstado = 0, Nombre = "Todos" });

            CBX_FiltroEstadoVeh.DataSource = listaEstados;
            CBX_FiltroEstadoVeh.DisplayMember = "Nombre";
            CBX_FiltroEstadoVeh.ValueMember = "IdEstado";
            CBX_FiltroEstadoVeh.SelectedIndex = 0;

            List<BE.CATEGORIA> listaCategorias = GestorCategoria.Listar();
            listaCategorias.Insert(0, new BE.CATEGORIA { Id = 0, Nombre = "Todas" });

            CBX_FiltroCategoriaVeh.DataSource = listaCategorias;
            CBX_FiltroCategoriaVeh.DisplayMember = "Nombre";
            CBX_FiltroCategoriaVeh.ValueMember = "Id";
            CBX_FiltroCategoriaVeh.SelectedIndex = 0;
        }

        private void FrmCTRLVehiculo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Servicios.IDIOMAS.GetInstancia().Desuscribir(this);
        }

        private void TXT_FiltroPatente_TextChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void CBX_FiltroEstadoVeh_SelectedIndexChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void CBX_FiltroCategoriaVeh_SelectedIndexChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
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
