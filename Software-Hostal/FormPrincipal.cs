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

namespace Software_Hostal
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            btnRestaurar.Visible = false;
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
    }
}
