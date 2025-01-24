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
    public partial class FormMetodoPago : Form
    {
        public FormMetodoPago()
        {
            InitializeComponent();
            txtID.Enabled = false;
            dgvMetodoPago.ReadOnly = true;
            listarMetodoPago();
        }
        private void CambiarEncabezados()
        {
            dgvMetodoPago.Columns["MétododepagoID"].HeaderText = "ID";
            dgvMetodoPago.Columns["Descripcion"].HeaderText = "Descripcion";
            dgvMetodoPago.Columns["Estado"].HeaderText = "Estado";
        }
        public void listarMetodoPago()
        {
            dgvMetodoPago.DataSource = logMetodoPago.Instancia.ListarMetodoPago();
            CambiarEncabezados();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entMetodoPago m = new entMetodoPago();
                m.Descripcion = txtMetodoPago.Text;
                m.Estado = cbxEstado.Checked;
                logMetodoPago.Instancia.InsertarMetodoPago(m);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar..." + ex);
            }
            Limpiar();
            listarMetodoPago();
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entMetodoPago m = new entMetodoPago();
                m.MétododepagoID = int.Parse(txtID.Text.Trim());
                m.Descripcion = txtMetodoPago.Text;
                m.Estado = cbxEstado.Checked;
                logMetodoPago.Instancia.ModificarMetodoPago(m);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar..." + ex);
            }
            Limpiar();
            listarMetodoPago();
        }
        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entMetodoPago m = new entMetodoPago();
                m.MétododepagoID = int.Parse(txtID.Text.Trim());
                m.Estado = cbxEstado.Checked;
                logMetodoPago.Instancia.DeshabilitaMetodoPago(m);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al deshabilitar..." + ex);
            }
            Limpiar();
            listarMetodoPago();
        }

        private void Limpiar()
        {
            txtID.Text = " ";
            txtMetodoPago.Text = " ";
        }

        private void dgvMetodoPago_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >=0) 
            {
                DataGridViewRow fila = dgvMetodoPago.Rows[e.RowIndex];
                txtID.Text = fila.Cells[0].Value.ToString();
                txtMetodoPago.Text = fila.Cells[1].Value.ToString();
                cbxEstado.Checked = Convert.ToBoolean(fila.Cells[2].Value);
            }
        }
    }
}
