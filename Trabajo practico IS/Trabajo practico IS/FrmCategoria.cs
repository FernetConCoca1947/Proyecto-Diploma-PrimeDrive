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
    public partial class FrmCategoria : Form
    {
        BLL.CATEGORIA GestorCategoria = new BLL.CATEGORIA();
        BLL.IDIOMA GestorIdiomas = new BLL.IDIOMA();
        BE.CATEGORIA CategoriaSeleccionada;
        public FrmCategoria()
        {
            InitializeComponent();
        }

        private void FrmCategoria_Load(object sender, EventArgs e)
        {


            EnlazarCategorias();
        }

        public void EnlazarCategorias()
        {
            var categorias = GestorCategoria.Listar().AsEnumerable();

            if (CKXmostrarInactivos.Checked == false)
            {
                categorias = categorias.Where(c => c.Activo == true);
            }

            DGV_Categorias.DataSource = null;
            DGV_Categorias.DataSource = categorias.ToList();
            DGV_Categorias.ReadOnly = true;

            if (DGV_Categorias.Columns["Id"] != null) DGV_Categorias.Columns["Id"].Visible = false;
            if (DGV_Categorias.Columns["Activo"] != null) DGV_Categorias.Columns["Activo"].Visible = false;
            //ActualizarEstadoBotones();
        }

        private void BTNCategoriaAlta_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TXT_CtrlCatNombre.Text) ||
                    string.IsNullOrWhiteSpace(TXT_CtrlCatTarifa.Text))
                {
                    MessageBox.Show("Debe completar todos los datos obligatorios.");
                    return;
                }

                //if (!Regex.IsMatch(TXT_CtrlCliDNI.Text, @"^\d{8}$"))
                //{
                //    MessageBox.Show("DNI inválido. Ingrese 8 números.");
                //    return;
                //}

                //if (!Regex.IsMatch(TXT_CtrlCliEmail.Text, @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$"))
                //{
                //    MessageBox.Show("Email inválido.");
                //    return;
                //}

                //if (!Regex.IsMatch(TXT_CtrlCliTelefono.Text, @"^\d+$"))
                //{
                //    MessageBox.Show("El teléfono solo debe contener números.");
                //    return;
                //}

                BE.CATEGORIA nuevaCategoria = new BE.CATEGORIA();
                nuevaCategoria.Nombre = TXT_CtrlCatNombre.Text;
                nuevaCategoria.TarifaDiaria = decimal.Parse(TXT_CtrlCatTarifa.Text.ToString());
                nuevaCategoria.Activo = true;

                BE.CATEGORIA inactivoDuplicado = GestorCategoria.ObtenerInactivoDuplicado(nuevaCategoria);

                if (inactivoDuplicado != null)
                {
                    DialogResult result = MessageBox.Show(
                        "El nombre ingresado pertenece a una categoria que fue dada de baja.\n\n¿Desea reactivarla para conservar su historial en el sistema en lugar de crear uno nuevo?",
                        "Categoria Inactiva Detectada",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        GestorCategoria.Reactivar(inactivoDuplicado);
                        MessageBox.Show("El cliente ha sido reactivado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        EnlazarCategorias();
                        //LimpiarControles();
                        return;
                    }
                    else
                    {
                        return;
                    }
                }

                GestorCategoria.Insertar(nuevaCategoria);

                MessageBox.Show("categoria registrada exitosamente.", "Alta Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                EnlazarCategorias();
                //LimpiarControles();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTNCategoriaBaja_Click(object sender, EventArgs e)
        {
            try
            {
                if (CategoriaSeleccionada != null)
                {
                    var result = MessageBox.Show($"Esta seguro que desea borrar: {CategoriaSeleccionada.Nombre}?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        GestorCategoria.Borrar(CategoriaSeleccionada);
                        EnlazarCategorias();
                        //LimpiarControles();
                        CategoriaSeleccionada = null;
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

        private void BTNCategoriaModificar_Click(object sender, EventArgs e)
        {

        }

        private void BTNCategoriaReactivar_Click(object sender, EventArgs e)
        {

        }

        private void DGV_Categorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                CategoriaSeleccionada = DGV_Categorias.Rows[e.RowIndex].DataBoundItem as BE.CATEGORIA;
                if (CategoriaSeleccionada != null)
                {
                    TXT_CtrlCatNombre.Text = CategoriaSeleccionada.Nombre;
                    TXT_CtrlCatTarifa.Text = CategoriaSeleccionada.TarifaDiaria.ToString();

                    //ActualizarEstadoBotones();
                }

            }
        }
    }
}
