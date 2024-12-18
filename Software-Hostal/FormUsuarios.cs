using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Hostal
{
    public partial class FormUsuarios : Form
    {
        public FormUsuarios()
        {
            InitializeComponent();
            listarUsuarios();
            this.StartPosition = FormStartPosition.CenterScreen;
            txtID.Enabled = false;
            dgvUsuarios.ReadOnly = false;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CambiarEncabezados()
        {
            dgvUsuarios.Columns["UsersID"].HeaderText = "ID";
            dgvUsuarios.Columns["LoginName"].HeaderText = "Login";
            dgvUsuarios.Columns["Contraseña"].HeaderText = "Contraseña";
            dgvUsuarios.Columns["Nombre"].HeaderText = "Nombre";
            dgvUsuarios.Columns["Apellido"].HeaderText = "Apellido";
            dgvUsuarios.Columns["Posicion"].HeaderText = "Posicion";
            dgvUsuarios.Columns["Email"].HeaderText = "E-mail";
        }

        public void listarUsuarios()
        {
            dgvUsuarios.DataSource = logUsers.Instancia.ListarUsuarios();
            CambiarEncabezados();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entUsers p = new entUsers();
                p.LoginName = txtLogin.Text;
                p.Contraseña = txtContraseña.Text;
                p.Nombre = txtNombre.Text;
                p.Apellido = txtApellido.Text;
                p.Posicion = txtPosicion.Text;
                p.Email = txtEmail.Text;    
                logUsers.Instancia.InsertarUsuarios(p);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar.." + ex);
            }
            Limpiar();
            listarUsuarios();
        }
        private void Limpiar() 
        {
            txtLogin.Text = "";
            txtContraseña.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtPosicion.Text = "";
            txtEmail.Text = "";
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entUsers p = new entUsers();
                p.UsersID = int.Parse(txtID.Text.Trim());
                p.LoginName = txtLogin.Text;
                p.Contraseña = txtContraseña.Text;
                p.Nombre = txtNombre.Text;
                p.Apellido = txtApellido.Text;
                p.Posicion = txtPosicion.Text;
                p.Email = txtEmail.Text;
                logUsers.Instancia.ModificarUsuarios(p);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar..." + ex);
            }
            Limpiar();
            listarUsuarios();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                entUsers u = new entUsers();
                u.UsersID = int.Parse(txtID.Text.Trim()); 
                logUsers.Instancia.EliminarUsuario(u.UsersID);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar usuario... " + ex);
            }
             Limpiar();         
             listarUsuarios();  
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            FormPrincipal p = new FormPrincipal();
            p.Show();
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FormUsuarios_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvUsuarios.Rows[e.RowIndex];
            txtID.Text = fila.Cells[0].Value.ToString();
            txtLogin.Text = fila.Cells[1].Value.ToString();
            txtContraseña.Text = fila.Cells[2].Value.ToString();
            txtNombre.Text = fila.Cells[3].Value.ToString();
            txtApellido.Text = fila.Cells[4].Value.ToString();
            txtPosicion.Text = fila.Cells[5].Value.ToString();
            txtEmail.Text = fila.Cells[6].Value.ToString();
        }
    }
}
