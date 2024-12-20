using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using CapaEntidad;

namespace Software_Hostal
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            btnRestaurar.Visible = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            globoTextoAU.SetToolTip(btnAgregarUsuario,"Click Aquí, para agregar un nuevo usuario");
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Normal;
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelContenedor_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClientes_MouseHover(object sender, EventArgs e)
        {
            panelSubMenu.Visible = true;
        }

        private void OcultarSubMenuSiFuera()
        {
            Point posicionPuntero = Cursor.Position;

            // Verificar si el puntero está fuera de los controles relevantes
            if (!btnClientes.ClientRectangle.Contains(btnClientes.PointToClient(posicionPuntero)) &&
                !panelSubMenu.ClientRectangle.Contains(panelSubMenu.PointToClient(posicionPuntero)))
            {
                panelSubMenu.Visible = false; // Ocultar el submenú
            }
        }

        private void MostrarSubmenu()
        {
            Point posicionPuntero = Cursor.Position;

            // Verificar si el puntero está fuera de los controles relevantes
            if (!btnClientes.ClientRectangle.Contains(btnClientes.PointToClient(posicionPuntero)) &&
                !panelSubMenu.ClientRectangle.Contains(panelSubMenu.PointToClient(posicionPuntero)))
            {
                panelSubMenu.Visible = true; // Mostrar el submenú
            }
        }

        private void panelSubMenu_MouseLeave(object sender, EventArgs e)
        {
            OcultarSubMenuSiFuera();
        }

        private void panelSubMenu_MouseHover(object sender, EventArgs e)
        {
            MostrarSubmenu();
        }

        private void btnVehiculo_MouseLeave(object sender, EventArgs e)
        {
            OcultarSubMenuSiFuera();
        }

        private void btnHabitacion_MouseLeave(object sender, EventArgs e)
        {
            OcultarSubMenuSiFuera();
        }

        private void btnMetodoPago_MouseLeave(object sender, EventArgs e)
        {
            OcultarSubMenuSiFuera();
        }

        private void panel8_MouseLeave(object sender, EventArgs e)
        {
            OcultarSubMenuSiFuera();
        }

        private void panel9_MouseLeave(object sender, EventArgs e)
        {
            OcultarSubMenuSiFuera();
        }

        private void panel10_MouseLeave(object sender, EventArgs e)
        {
            OcultarSubMenuSiFuera();
        }

        private void btnClientes_MouseLeave(object sender, EventArgs e)
        {
            OcultarSubMenuSiFuera();
        }

        //---------------------------------------------------------------------------------------
        private void AbrirFormEnPanel(object formhija)
        {
            if (this.panelContenedor.Controls.Count > 0) 
            {
                this.panelContenedor.Controls.RemoveAt(0);
            }
                
            Form fh = formhija as Form;
            fh.TopLevel = false;    
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormCliente());
        }

        private void horaFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void btnVehiculo_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormVehiculo());
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro de cerrar sesión?", "WARNING",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                FormLogin login = new FormLogin();
                login.Show();

                this.Close();
            }
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            LoadUserData();
            //Manejar permisos
            if (entUsuario.Position == entPosiciones.Recepcionista) 
            {
                btnEntradaProd.Visible = false;
                btnAlmacen.Visible = false;
                btnReporte.Visible = false;
                panel4.Visible = false;
                panel5.Visible = false;
                panel6.Visible = false;
            }
            if (entUsuario.Position == entPosiciones.Administrador) 
            {
                pictureBox1.Visible = false;
                btnAgregarUsuario.Visible = true;
            }
        }
        private void LoadUserData()
        {
            lblUsername.Text = entUsuario.FirstName + ", " + entUsuario.LastName;
            lblPosition.Text = entUsuario.Position;
            lblEmail.Text = entUsuario.Email;
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            FormUsuarios formUsuarios = new FormUsuarios();
            formUsuarios.Show();
            this.Close();
        }
    }
}
