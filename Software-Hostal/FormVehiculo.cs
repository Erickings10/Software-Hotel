using CapaDatos;
using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Hostal
{
    public partial class FormVehiculo : Form
    {
        public FormVehiculo()
        {
            InitializeComponent();
            txtID.Enabled = false;
            listarVehiculos();
            dgvVehiculos.ReadOnly = true;
        }
        private void CambiarEncabezados()
        {
            dgvVehiculos.Columns["VehiculoID"].HeaderText = "ID";
            dgvVehiculos.Columns["TipoVehiculo"].HeaderText = "Vehiculo";
            dgvVehiculos.Columns["Estado"].HeaderText = "Estado";
        }
        public void listarVehiculos()
        {
            dgvVehiculos.DataSource = logVehiculo.Instancia.ListarVehiculos();
            CambiarEncabezados();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entVehiculos v = new entVehiculos();
                v.TipoVehiculo = txtVehiculo.Text;
                v.Estado = cbxEstado.Checked;
                logVehiculo.Instancia.InsertaVehiculos(v);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar..." + ex);
            }
            Limpiar();
            listarVehiculos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entVehiculos v = new entVehiculos();
                v.VehiculoID = int.Parse(txtID.Text.Trim());
                v.TipoVehiculo = txtVehiculo.Text;
                v.Estado = cbxEstado.Checked;
                logVehiculo.Instancia.ModificarVehiculos(v);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar..." + ex);
            }
            Limpiar();
            listarVehiculos();
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entVehiculos v = new entVehiculos();
                v.VehiculoID = int.Parse(txtID.Text.Trim());
                v.Estado = cbxEstado.Checked;
                logVehiculo.Instancia.DeshabilitarVehiculos(v);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al deshabilitar..." + ex);
            }
            Limpiar();
            listarVehiculos();
        }
        private void Limpiar()
        {
            txtID.Text = " ";
            txtVehiculo.Text = " ";
        }

        private void dgvVehiculos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                DataGridViewRow fila = dgvVehiculos.Rows[e.RowIndex];
                txtID.Text = fila.Cells[0].Value.ToString();
                txtVehiculo.Text = fila.Cells[1].Value.ToString();
                cbxEstado.Checked = Convert.ToBoolean(fila.Cells[2].Value);
            }
        }
    }
}
