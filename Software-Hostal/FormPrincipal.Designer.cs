namespace Software_Hostal
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.panelMenuVertical = new System.Windows.Forms.Panel();
            this.btnAgregarUsuario = new System.Windows.Forms.PictureBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.panelSubMenu = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnMetodoPago = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnHabitacion = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnVehiculo = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnReporte = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnAlmacen = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnEntradaProd = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnProductos = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnVentas = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.horaFecha = new System.Windows.Forms.Timer(this.components);
            this.globoTextoAU = new System.Windows.Forms.ToolTip(this.components);
            this.panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            this.panelMenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregarUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelSubMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnInicio)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(86)))), ((int)(((byte)(244)))));
            this.panelBarraTitulo.Controls.Add(this.lblFecha);
            this.panelBarraTitulo.Controls.Add(this.btnRestaurar);
            this.panelBarraTitulo.Controls.Add(this.lblHora);
            this.panelBarraTitulo.Controls.Add(this.btnCerrar);
            this.panelBarraTitulo.Controls.Add(this.btnMinimizar);
            this.panelBarraTitulo.Controls.Add(this.btnMaximizar);
            this.panelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelBarraTitulo.Name = "panelBarraTitulo";
            this.panelBarraTitulo.Size = new System.Drawing.Size(1300, 40);
            this.panelBarraTitulo.TabIndex = 0;
            this.panelBarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBarraTitulo_MouseDown);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblFecha.Location = new System.Drawing.Point(153, 5);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(86, 31);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "label2";
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.Location = new System.Drawing.Point(1210, 5);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(30, 30);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestaurar.TabIndex = 2;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblHora.Location = new System.Drawing.Point(7, 6);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(86, 31);
            this.lblHora.TabIndex = 2;
            this.lblHora.Text = "label1";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1259, 5);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(30, 30);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(1164, 5);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(30, 30);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 1;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(1210, 5);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(30, 30);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 0;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // panelMenuVertical
            // 
            this.panelMenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panelMenuVertical.Controls.Add(this.btnAgregarUsuario);
            this.panelMenuVertical.Controls.Add(this.lblEmail);
            this.panelMenuVertical.Controls.Add(this.lblUsername);
            this.panelMenuVertical.Controls.Add(this.lblPosition);
            this.panelMenuVertical.Controls.Add(this.pictureBox1);
            this.panelMenuVertical.Controls.Add(this.btnCerrarSesion);
            this.panelMenuVertical.Controls.Add(this.panelSubMenu);
            this.panelMenuVertical.Controls.Add(this.panel6);
            this.panelMenuVertical.Controls.Add(this.btnReporte);
            this.panelMenuVertical.Controls.Add(this.panel5);
            this.panelMenuVertical.Controls.Add(this.btnAlmacen);
            this.panelMenuVertical.Controls.Add(this.panel4);
            this.panelMenuVertical.Controls.Add(this.btnEntradaProd);
            this.panelMenuVertical.Controls.Add(this.panel3);
            this.panelMenuVertical.Controls.Add(this.btnProductos);
            this.panelMenuVertical.Controls.Add(this.panel2);
            this.panelMenuVertical.Controls.Add(this.btnVentas);
            this.panelMenuVertical.Controls.Add(this.panel1);
            this.panelMenuVertical.Controls.Add(this.btnClientes);
            this.panelMenuVertical.Controls.Add(this.btnInicio);
            this.panelMenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuVertical.Location = new System.Drawing.Point(0, 40);
            this.panelMenuVertical.Name = "panelMenuVertical";
            this.panelMenuVertical.Size = new System.Drawing.Size(220, 610);
            this.panelMenuVertical.TabIndex = 1;
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarUsuario.Image")));
            this.btnAgregarUsuario.Location = new System.Drawing.Point(0, 452);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(93, 81);
            this.btnAgregarUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAgregarUsuario.TabIndex = 14;
            this.btnAgregarUsuario.TabStop = false;
            this.btnAgregarUsuario.Visible = false;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblEmail.Location = new System.Drawing.Point(10, 541);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(43, 16);
            this.lblEmail.TabIndex = 16;
            this.lblEmail.Text = "Email";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblUsername.Location = new System.Drawing.Point(93, 505);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(58, 16);
            this.lblUsername.TabIndex = 15;
            this.lblUsername.Text = "Nombre";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPosition.Location = new System.Drawing.Point(94, 467);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(60, 16);
            this.lblPosition.TabIndex = 14;
            this.lblPosition.Text = "Posición";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 452);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(122)))), ((int)(((byte)(248)))));
            this.btnCerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(86)))), ((int)(((byte)(244)))));
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarSesion.Image")));
            this.btnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 567);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(220, 40);
            this.btnCerrarSesion.TabIndex = 12;
            this.btnCerrarSesion.Text = "CERRAR SESIÓN";
            this.btnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // panelSubMenu
            // 
            this.panelSubMenu.Controls.Add(this.panel10);
            this.panelSubMenu.Controls.Add(this.btnMetodoPago);
            this.panelSubMenu.Controls.Add(this.panel9);
            this.panelSubMenu.Controls.Add(this.btnHabitacion);
            this.panelSubMenu.Controls.Add(this.panel8);
            this.panelSubMenu.Controls.Add(this.btnVehiculo);
            this.panelSubMenu.Location = new System.Drawing.Point(53, 156);
            this.panelSubMenu.Name = "panelSubMenu";
            this.panelSubMenu.Size = new System.Drawing.Size(167, 136);
            this.panelSubMenu.TabIndex = 0;
            this.panelSubMenu.Visible = false;
            this.panelSubMenu.MouseLeave += new System.EventHandler(this.panelSubMenu_MouseLeave);
            this.panelSubMenu.MouseHover += new System.EventHandler(this.panelSubMenu_MouseHover);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(86)))), ((int)(((byte)(244)))));
            this.panel10.Location = new System.Drawing.Point(1, 94);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(10, 40);
            this.panel10.TabIndex = 17;
            this.panel10.MouseLeave += new System.EventHandler(this.panel10_MouseLeave);
            // 
            // btnMetodoPago
            // 
            this.btnMetodoPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnMetodoPago.FlatAppearance.BorderSize = 0;
            this.btnMetodoPago.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(122)))), ((int)(((byte)(248)))));
            this.btnMetodoPago.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(86)))), ((int)(((byte)(244)))));
            this.btnMetodoPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMetodoPago.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMetodoPago.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnMetodoPago.Image = ((System.Drawing.Image)(resources.GetObject("btnMetodoPago.Image")));
            this.btnMetodoPago.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMetodoPago.Location = new System.Drawing.Point(10, 94);
            this.btnMetodoPago.Name = "btnMetodoPago";
            this.btnMetodoPago.Size = new System.Drawing.Size(157, 40);
            this.btnMetodoPago.TabIndex = 16;
            this.btnMetodoPago.Text = "Metodo Pago";
            this.btnMetodoPago.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMetodoPago.UseVisualStyleBackColor = false;
            this.btnMetodoPago.MouseLeave += new System.EventHandler(this.btnMetodoPago_MouseLeave);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(86)))), ((int)(((byte)(244)))));
            this.panel9.Location = new System.Drawing.Point(1, 48);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(10, 40);
            this.panel9.TabIndex = 15;
            this.panel9.MouseLeave += new System.EventHandler(this.panel9_MouseLeave);
            // 
            // btnHabitacion
            // 
            this.btnHabitacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnHabitacion.FlatAppearance.BorderSize = 0;
            this.btnHabitacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(122)))), ((int)(((byte)(248)))));
            this.btnHabitacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(86)))), ((int)(((byte)(244)))));
            this.btnHabitacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHabitacion.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHabitacion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnHabitacion.Image = ((System.Drawing.Image)(resources.GetObject("btnHabitacion.Image")));
            this.btnHabitacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHabitacion.Location = new System.Drawing.Point(10, 48);
            this.btnHabitacion.Name = "btnHabitacion";
            this.btnHabitacion.Size = new System.Drawing.Size(157, 40);
            this.btnHabitacion.TabIndex = 14;
            this.btnHabitacion.Text = "Habitacion";
            this.btnHabitacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHabitacion.UseVisualStyleBackColor = false;
            this.btnHabitacion.MouseLeave += new System.EventHandler(this.btnHabitacion_MouseLeave);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(86)))), ((int)(((byte)(244)))));
            this.panel8.Location = new System.Drawing.Point(1, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(10, 40);
            this.panel8.TabIndex = 13;
            this.panel8.MouseLeave += new System.EventHandler(this.panel8_MouseLeave);
            // 
            // btnVehiculo
            // 
            this.btnVehiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnVehiculo.FlatAppearance.BorderSize = 0;
            this.btnVehiculo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(122)))), ((int)(((byte)(248)))));
            this.btnVehiculo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(86)))), ((int)(((byte)(244)))));
            this.btnVehiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVehiculo.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVehiculo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnVehiculo.Image = ((System.Drawing.Image)(resources.GetObject("btnVehiculo.Image")));
            this.btnVehiculo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVehiculo.Location = new System.Drawing.Point(10, 2);
            this.btnVehiculo.Name = "btnVehiculo";
            this.btnVehiculo.Size = new System.Drawing.Size(157, 40);
            this.btnVehiculo.TabIndex = 12;
            this.btnVehiculo.Text = "Vehiculo";
            this.btnVehiculo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVehiculo.UseVisualStyleBackColor = false;
            this.btnVehiculo.Click += new System.EventHandler(this.btnVehiculo_Click);
            this.btnVehiculo.MouseLeave += new System.EventHandler(this.btnVehiculo_MouseLeave);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(86)))), ((int)(((byte)(244)))));
            this.panel6.Location = new System.Drawing.Point(4, 393);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 40);
            this.panel6.TabIndex = 11;
            // 
            // btnReporte
            // 
            this.btnReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnReporte.FlatAppearance.BorderSize = 0;
            this.btnReporte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(122)))), ((int)(((byte)(248)))));
            this.btnReporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(86)))), ((int)(((byte)(244)))));
            this.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporte.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnReporte.Image = ((System.Drawing.Image)(resources.GetObject("btnReporte.Image")));
            this.btnReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporte.Location = new System.Drawing.Point(13, 393);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(207, 40);
            this.btnReporte.TabIndex = 10;
            this.btnReporte.Text = "REPORTES";
            this.btnReporte.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(86)))), ((int)(((byte)(244)))));
            this.panel5.Location = new System.Drawing.Point(4, 338);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 40);
            this.panel5.TabIndex = 9;
            // 
            // btnAlmacen
            // 
            this.btnAlmacen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnAlmacen.FlatAppearance.BorderSize = 0;
            this.btnAlmacen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(122)))), ((int)(((byte)(248)))));
            this.btnAlmacen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(86)))), ((int)(((byte)(244)))));
            this.btnAlmacen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlmacen.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlmacen.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAlmacen.Image = ((System.Drawing.Image)(resources.GetObject("btnAlmacen.Image")));
            this.btnAlmacen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlmacen.Location = new System.Drawing.Point(13, 338);
            this.btnAlmacen.Name = "btnAlmacen";
            this.btnAlmacen.Size = new System.Drawing.Size(207, 40);
            this.btnAlmacen.TabIndex = 8;
            this.btnAlmacen.Text = "ALMACEN";
            this.btnAlmacen.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(86)))), ((int)(((byte)(244)))));
            this.panel4.Location = new System.Drawing.Point(4, 283);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 40);
            this.panel4.TabIndex = 7;
            // 
            // btnEntradaProd
            // 
            this.btnEntradaProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnEntradaProd.FlatAppearance.BorderSize = 0;
            this.btnEntradaProd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(122)))), ((int)(((byte)(248)))));
            this.btnEntradaProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(86)))), ((int)(((byte)(244)))));
            this.btnEntradaProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntradaProd.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntradaProd.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEntradaProd.Image = ((System.Drawing.Image)(resources.GetObject("btnEntradaProd.Image")));
            this.btnEntradaProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEntradaProd.Location = new System.Drawing.Point(13, 283);
            this.btnEntradaProd.Name = "btnEntradaProd";
            this.btnEntradaProd.Size = new System.Drawing.Size(207, 40);
            this.btnEntradaProd.TabIndex = 6;
            this.btnEntradaProd.Text = "ENTRADA PROD.";
            this.btnEntradaProd.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(86)))), ((int)(((byte)(244)))));
            this.panel3.Location = new System.Drawing.Point(4, 228);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 40);
            this.panel3.TabIndex = 5;
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(122)))), ((int)(((byte)(248)))));
            this.btnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(86)))), ((int)(((byte)(244)))));
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnProductos.Image = ((System.Drawing.Image)(resources.GetObject("btnProductos.Image")));
            this.btnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.Location = new System.Drawing.Point(13, 228);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(207, 40);
            this.btnProductos.TabIndex = 4;
            this.btnProductos.Text = "PRODUCTOS";
            this.btnProductos.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(86)))), ((int)(((byte)(244)))));
            this.panel2.Location = new System.Drawing.Point(4, 172);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 40);
            this.panel2.TabIndex = 3;
            // 
            // btnVentas
            // 
            this.btnVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(122)))), ((int)(((byte)(248)))));
            this.btnVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(86)))), ((int)(((byte)(244)))));
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnVentas.Image = ((System.Drawing.Image)(resources.GetObject("btnVentas.Image")));
            this.btnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.Location = new System.Drawing.Point(13, 172);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(207, 40);
            this.btnVentas.TabIndex = 2;
            this.btnVentas.Text = "VENTA";
            this.btnVentas.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(86)))), ((int)(((byte)(244)))));
            this.panel1.Location = new System.Drawing.Point(4, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 40);
            this.panel1.TabIndex = 1;
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(122)))), ((int)(((byte)(248)))));
            this.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(86)))), ((int)(((byte)(244)))));
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnClientes.Image")));
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(13, 117);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(207, 40);
            this.btnClientes.TabIndex = 0;
            this.btnClientes.Text = "CLIENTES";
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            this.btnClientes.MouseLeave += new System.EventHandler(this.btnClientes_MouseLeave);
            this.btnClientes.MouseHover += new System.EventHandler(this.btnClientes_MouseHover);
            // 
            // btnInicio
            // 
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnInicio.Image = ((System.Drawing.Image)(resources.GetObject("btnInicio.Image")));
            this.btnInicio.Location = new System.Drawing.Point(0, 0);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(220, 115);
            this.btnInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnInicio.TabIndex = 0;
            this.btnInicio.TabStop = false;
            this.btnInicio.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(50)))), ((int)(((byte)(105)))));
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(220, 40);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1080, 610);
            this.panelContenedor.TabIndex = 2;
            this.panelContenedor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelContenedor_MouseDown);
            // 
            // horaFecha
            // 
            this.horaFecha.Enabled = true;
            this.horaFecha.Tick += new System.EventHandler(this.horaFecha_Tick);
            // 
            // globoTextoAU
            // 
            this.globoTextoAU.AutoPopDelay = 3000;
            this.globoTextoAU.InitialDelay = 500;
            this.globoTextoAU.IsBalloon = true;
            this.globoTextoAU.ReshowDelay = 100;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelMenuVertical);
            this.Controls.Add(this.panelBarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPrincipal";
            this.Text = "FormPrincipal";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.panelBarraTitulo.ResumeLayout(false);
            this.panelBarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            this.panelMenuVertical.ResumeLayout(false);
            this.panelMenuVertical.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregarUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelSubMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnInicio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBarraTitulo;
        private System.Windows.Forms.Panel panelMenuVertical;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.PictureBox btnInicio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnAlmacen;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnEntradaProd;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Panel panelSubMenu;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btnMetodoPago;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnHabitacion;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnVehiculo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer horaFecha;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.PictureBox btnAgregarUsuario;
        private System.Windows.Forms.ToolTip globoTextoAU;
    }
}