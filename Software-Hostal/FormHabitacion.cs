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
    public partial class FormHabitacion : Form
    {
        public FormHabitacion()
        {
            InitializeComponent();
            txtID.Enabled = false;
            dgvHabitacion.ReadOnly = true;
            listarHabitaciones();
        }
        private void CambiarEncabezados()
        {
            dgvHabitacion.Columns["HabitacionesID"].HeaderText = "ID";
            dgvHabitacion.Columns["NumHabitacion"].HeaderText = "Habitación";
            dgvHabitacion.Columns["Estado"].HeaderText = "Estado";
        }
        public void listarHabitaciones()
        {
            dgvHabitacion.DataSource = logHabitaciones.Instancia.ListarHabitaciones();
            CambiarEncabezados();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entHabitaciones v = new entHabitaciones();
                v.NumHabitacion = txtHabitacion.Text;
                v.Estado = cbxEstado.Checked;
                logHabitaciones.Instancia.InsertaHabitaciones(v);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar..." + ex);
            }
            Limpiar();
            listarHabitaciones();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entHabitaciones v = new entHabitaciones();
                v.HabitacionesID = int.Parse(txtID.Text.Trim());
                v.NumHabitacion = txtHabitacion.Text;
                v.Estado = cbxEstado.Checked;
                logHabitaciones.Instancia.ModificarHabitaciones(v);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar..." + ex);
            }
            Limpiar();
            listarHabitaciones();
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entHabitaciones v = new entHabitaciones();
                v.HabitacionesID = int.Parse(txtID.Text.Trim());
                v.Estado = cbxEstado.Checked;
                logHabitaciones.Instancia.DeshabilitarHabitaciones(v);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al deshabilitar..." + ex);
            }
            Limpiar();
            listarHabitaciones();
        }
        private void Limpiar()
        {
            txtID.Text = " ";
            txtHabitacion.Text = " ";
        }

        private void dgvHabitacion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                DataGridViewRow fila = dgvHabitacion.Rows[e.RowIndex];
                txtID.Text = fila.Cells[0].Value.ToString();
                txtHabitacion.Text = fila.Cells[1].Value.ToString();
                cbxEstado.Checked = Convert.ToBoolean(fila.Cells[2].Value);
            }
        }
    }
}
