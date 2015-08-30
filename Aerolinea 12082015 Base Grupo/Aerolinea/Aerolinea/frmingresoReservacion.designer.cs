namespace Aerolinea
{
    partial class frmingresoReservacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmingresoReservacion));
            this.gbCodigo = new System.Windows.Forms.GroupBox();
            this.txtReservacion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CbSeleccionCodigo = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gbDatoPersonal = new System.Windows.Forms.GroupBox();
            this.txtFechaReserva = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtPasaporte = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDpi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApellido1 = new System.Windows.Forms.TextBox();
            this.txtTelefono1 = new System.Windows.Forms.TextBox();
            this.txtNombre1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnReservar = new System.Windows.Forms.Button();
            this.gbExtras = new System.Windows.Forms.GroupBox();
            this.cbRequerimiento = new System.Windows.Forms.ComboBox();
            this.lbExtras = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtTelefonoExtra = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNombreExtra = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCodDestino = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.CbDestino = new System.Windows.Forms.ComboBox();
            this.txtHoraDespegue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtHoraAterrizaje = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtLugarSalida = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sALIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gbCodigo.SuspendLayout();
            this.gbDatoPersonal.SuspendLayout();
            this.gbExtras.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCodigo
            // 
            this.gbCodigo.Controls.Add(this.txtReservacion);
            this.gbCodigo.Controls.Add(this.label9);
            this.gbCodigo.Controls.Add(this.CbSeleccionCodigo);
            this.gbCodigo.Controls.Add(this.label16);
            this.gbCodigo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCodigo.Location = new System.Drawing.Point(21, 42);
            this.gbCodigo.Name = "gbCodigo";
            this.gbCodigo.Size = new System.Drawing.Size(522, 80);
            this.gbCodigo.TabIndex = 27;
            this.gbCodigo.TabStop = false;
            this.gbCodigo.Text = "Seleccion Cliente";
            // 
            // txtReservacion
            // 
            this.txtReservacion.Location = new System.Drawing.Point(393, 31);
            this.txtReservacion.Name = "txtReservacion";
            this.txtReservacion.Size = new System.Drawing.Size(107, 27);
            this.txtReservacion.TabIndex = 27;
            this.txtReservacion.TextChanged += new System.EventHandler(this.txtReservacion_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(283, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 19);
            this.label9.TabIndex = 26;
            this.label9.Text = "Codigo Cliente";
            // 
            // CbSeleccionCodigo
            // 
            this.CbSeleccionCodigo.FormattingEnabled = true;
            this.CbSeleccionCodigo.Items.AddRange(new object[] {
            "Codigo",
            "Nombre"});
            this.CbSeleccionCodigo.Location = new System.Drawing.Point(133, 34);
            this.CbSeleccionCodigo.Name = "CbSeleccionCodigo";
            this.CbSeleccionCodigo.Size = new System.Drawing.Size(144, 27);
            this.CbSeleccionCodigo.TabIndex = 25;
            this.CbSeleccionCodigo.SelectedIndexChanged += new System.EventHandler(this.CbSeleccionCodigo_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(17, 34);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(110, 19);
            this.label16.TabIndex = 22;
            this.label16.Text = "Nombre Cliente";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(515, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(237, 23);
            this.label8.TabIndex = 26;
            this.label8.Text = "Ingreso de nueva reservación";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // gbDatoPersonal
            // 
            this.gbDatoPersonal.Controls.Add(this.txtFechaReserva);
            this.gbDatoPersonal.Controls.Add(this.label14);
            this.gbDatoPersonal.Controls.Add(this.txtFecha);
            this.gbDatoPersonal.Controls.Add(this.label21);
            this.gbDatoPersonal.Controls.Add(this.txtPasaporte);
            this.gbDatoPersonal.Controls.Add(this.label20);
            this.gbDatoPersonal.Controls.Add(this.label19);
            this.gbDatoPersonal.Controls.Add(this.txtDireccion);
            this.gbDatoPersonal.Controls.Add(this.label3);
            this.gbDatoPersonal.Controls.Add(this.label7);
            this.gbDatoPersonal.Controls.Add(this.txtDpi);
            this.gbDatoPersonal.Controls.Add(this.label5);
            this.gbDatoPersonal.Controls.Add(this.txtEmail);
            this.gbDatoPersonal.Controls.Add(this.label6);
            this.gbDatoPersonal.Controls.Add(this.txtEdad);
            this.gbDatoPersonal.Controls.Add(this.label4);
            this.gbDatoPersonal.Controls.Add(this.txtApellido1);
            this.gbDatoPersonal.Controls.Add(this.txtTelefono1);
            this.gbDatoPersonal.Controls.Add(this.txtNombre1);
            this.gbDatoPersonal.Controls.Add(this.label2);
            this.gbDatoPersonal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatoPersonal.Location = new System.Drawing.Point(21, 128);
            this.gbDatoPersonal.Name = "gbDatoPersonal";
            this.gbDatoPersonal.Size = new System.Drawing.Size(1043, 160);
            this.gbDatoPersonal.TabIndex = 25;
            this.gbDatoPersonal.TabStop = false;
            this.gbDatoPersonal.Text = "Datos personales";
            // 
            // txtFechaReserva
            // 
            this.txtFechaReserva.Location = new System.Drawing.Point(137, 118);
            this.txtFechaReserva.Name = "txtFechaReserva";
            this.txtFechaReserva.Size = new System.Drawing.Size(270, 27);
            this.txtFechaReserva.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 118);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(130, 19);
            this.label14.TabIndex = 24;
            this.label14.Text = "Fecha Reservacion";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(787, 26);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(219, 27);
            this.txtFecha.TabIndex = 23;
            this.txtFecha.TextChanged += new System.EventHandler(this.txtFecha_TextChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(422, 95);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(100, 19);
            this.label21.TabIndex = 22;
            this.label21.Text = "No. Pasaporte";
            // 
            // txtPasaporte
            // 
            this.txtPasaporte.Location = new System.Drawing.Point(528, 92);
            this.txtPasaporte.Name = "txtPasaporte";
            this.txtPasaporte.Size = new System.Drawing.Size(93, 27);
            this.txtPasaporte.TabIndex = 21;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(638, 26);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(143, 19);
            this.label20.TabIndex = 20;
            this.label20.Text = "Fecha de nacimiento";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(12, 88);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(70, 19);
            this.label19.TabIndex = 18;
            this.label19.Text = "Direccion";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(81, 88);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(326, 27);
            this.txtDireccion.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "Apellidos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(638, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "E- mail";
            // 
            // txtDpi
            // 
            this.txtDpi.Location = new System.Drawing.Point(469, 59);
            this.txtDpi.Name = "txtDpi";
            this.txtDpi.Size = new System.Drawing.Size(152, 27);
            this.txtDpi.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(638, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Telefono";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(709, 92);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(297, 27);
            this.txtEmail.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(422, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "DPI";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(469, 23);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(152, 27);
            this.txtEdad.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(422, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Edad";
            // 
            // txtApellido1
            // 
            this.txtApellido1.Location = new System.Drawing.Point(81, 55);
            this.txtApellido1.Name = "txtApellido1";
            this.txtApellido1.Size = new System.Drawing.Size(326, 27);
            this.txtApellido1.TabIndex = 6;
            // 
            // txtTelefono1
            // 
            this.txtTelefono1.Location = new System.Drawing.Point(709, 59);
            this.txtTelefono1.Name = "txtTelefono1";
            this.txtTelefono1.Size = new System.Drawing.Size(297, 27);
            this.txtTelefono1.TabIndex = 10;
            // 
            // txtNombre1
            // 
            this.txtNombre1.Location = new System.Drawing.Point(81, 23);
            this.txtNombre1.Name = "txtNombre1";
            this.txtNombre1.Size = new System.Drawing.Size(326, 27);
            this.txtNombre1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombres";
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnModificar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(1070, 171);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnModificar.Size = new System.Drawing.Size(110, 50);
            this.btnModificar.TabIndex = 34;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnReservar
            // 
            this.btnReservar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReservar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReservar.Image = ((System.Drawing.Image)(resources.GetObject("btnReservar.Image")));
            this.btnReservar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReservar.Location = new System.Drawing.Point(1070, 284);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnReservar.Size = new System.Drawing.Size(110, 50);
            this.btnReservar.TabIndex = 33;
            this.btnReservar.Text = "Finalizar Reservacion";
            this.btnReservar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReservar.UseVisualStyleBackColor = true;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // gbExtras
            // 
            this.gbExtras.Controls.Add(this.cbRequerimiento);
            this.gbExtras.Controls.Add(this.lbExtras);
            this.gbExtras.Controls.Add(this.label15);
            this.gbExtras.Controls.Add(this.txtTelefonoExtra);
            this.gbExtras.Controls.Add(this.label13);
            this.gbExtras.Controls.Add(this.txtNombreExtra);
            this.gbExtras.Controls.Add(this.label10);
            this.gbExtras.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbExtras.Location = new System.Drawing.Point(549, 322);
            this.gbExtras.Name = "gbExtras";
            this.gbExtras.Size = new System.Drawing.Size(486, 167);
            this.gbExtras.TabIndex = 30;
            this.gbExtras.TabStop = false;
            this.gbExtras.Text = "Extras  ";
            // 
            // cbRequerimiento
            // 
            this.cbRequerimiento.FormattingEnabled = true;
            this.cbRequerimiento.Items.AddRange(new object[] {
            "Hepatitis",
            "Diabetes",
            "Asma",
            "Obesidad",
            "Anorexia",
            "Gripe Cronica",
            "Transtornos de sueño"});
            this.cbRequerimiento.Location = new System.Drawing.Point(198, 33);
            this.cbRequerimiento.Name = "cbRequerimiento";
            this.cbRequerimiento.Size = new System.Drawing.Size(251, 27);
            this.cbRequerimiento.TabIndex = 27;
            // 
            // lbExtras
            // 
            this.lbExtras.AutoSize = true;
            this.lbExtras.Location = new System.Drawing.Point(8, 36);
            this.lbExtras.Name = "lbExtras";
            this.lbExtras.Size = new System.Drawing.Size(184, 19);
            this.lbExtras.TabIndex = 26;
            this.lbExtras.Text = "Requerimientos especiales";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 74);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 19);
            this.label15.TabIndex = 25;
            this.label15.Text = "Llamar a:";
            // 
            // txtTelefonoExtra
            // 
            this.txtTelefonoExtra.Location = new System.Drawing.Point(101, 100);
            this.txtTelefonoExtra.Name = "txtTelefonoExtra";
            this.txtTelefonoExtra.Size = new System.Drawing.Size(348, 27);
            this.txtTelefonoExtra.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 108);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 19);
            this.label13.TabIndex = 21;
            this.label13.Text = "Telefono";
            // 
            // txtNombreExtra
            // 
            this.txtNombreExtra.Location = new System.Drawing.Point(101, 66);
            this.txtNombreExtra.Name = "txtNombreExtra";
            this.txtNombreExtra.Size = new System.Drawing.Size(348, 27);
            this.txtNombreExtra.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 19);
            this.label10.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCodDestino);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.CbDestino);
            this.groupBox1.Controls.Add(this.txtHoraDespegue);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtHoraAterrizaje);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.txtLugarSalida);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 307);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(522, 273);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Control de vuelo";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtCodDestino
            // 
            this.txtCodDestino.Location = new System.Drawing.Point(426, 48);
            this.txtCodDestino.Name = "txtCodDestino";
            this.txtCodDestino.Size = new System.Drawing.Size(74, 27);
            this.txtCodDestino.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(317, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 19);
            this.label12.TabIndex = 27;
            this.label12.Text = "Codigo Destino";
            // 
            // CbDestino
            // 
            this.CbDestino.FormattingEnabled = true;
            this.CbDestino.Items.AddRange(new object[] {
            "codigo",
            "nombre"});
            this.CbDestino.Location = new System.Drawing.Point(77, 48);
            this.CbDestino.Name = "CbDestino";
            this.CbDestino.Size = new System.Drawing.Size(223, 27);
            this.CbDestino.TabIndex = 18;
            this.CbDestino.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // txtHoraDespegue
            // 
            this.txtHoraDespegue.Location = new System.Drawing.Point(156, 123);
            this.txtHoraDespegue.Name = "txtHoraDespegue";
            this.txtHoraDespegue.Size = new System.Drawing.Size(344, 27);
            this.txtHoraDespegue.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nombre Aeropuerto";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 155);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 19);
            this.label11.TabIndex = 11;
            this.label11.Text = "Hora Aterrizaje";
            // 
            // txtHoraAterrizaje
            // 
            this.txtHoraAterrizaje.Location = new System.Drawing.Point(156, 155);
            this.txtHoraAterrizaje.Name = "txtHoraAterrizaje";
            this.txtHoraAterrizaje.Size = new System.Drawing.Size(344, 27);
            this.txtHoraAterrizaje.TabIndex = 8;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 125);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(109, 19);
            this.label17.TabIndex = 7;
            this.label17.Text = "Hora Despegue";
            // 
            // txtLugarSalida
            // 
            this.txtLugarSalida.Location = new System.Drawing.Point(156, 87);
            this.txtLugarSalida.Name = "txtLugarSalida";
            this.txtLugarSalida.Size = new System.Drawing.Size(344, 27);
            this.txtLugarSalida.TabIndex = 6;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(12, 51);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 19);
            this.label18.TabIndex = 2;
            this.label18.Text = "Destino";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sALIRToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1192, 27);
            this.menuStrip1.TabIndex = 181;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // sALIRToolStripMenuItem
            // 
            this.sALIRToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.sALIRToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sALIRToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sALIRToolStripMenuItem.Image")));
            this.sALIRToolStripMenuItem.Name = "sALIRToolStripMenuItem";
            this.sALIRToolStripMenuItem.Size = new System.Drawing.Size(73, 23);
            this.sALIRToolStripMenuItem.Text = "SALIR";
            this.sALIRToolStripMenuItem.Click += new System.EventHandler(this.sALIRToolStripMenuItem_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnActualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizar.Location = new System.Drawing.Point(1070, 343);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnActualizar.Size = new System.Drawing.Size(110, 50);
            this.btnActualizar.TabIndex = 182;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(578, 64);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(192, 50);
            this.button1.TabIndex = 183;
            this.button1.Text = "Probar conexion";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(1070, 227);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button2.Size = new System.Drawing.Size(110, 50);
            this.button2.TabIndex = 184;
            this.button2.Text = "Continuar Reservacion";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmingresoReservacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1192, 574);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnReservar);
            this.Controls.Add(this.gbExtras);
            this.Controls.Add(this.gbCodigo);
            this.Controls.Add(this.gbDatoPersonal);
            this.MaximizeBox = false;
            this.Name = "frmingresoReservacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrIngresoReservacion";
            this.Load += new System.EventHandler(this.frmingresoReservacion_Load);
            this.gbCodigo.ResumeLayout(false);
            this.gbCodigo.PerformLayout();
            this.gbDatoPersonal.ResumeLayout(false);
            this.gbDatoPersonal.PerformLayout();
            this.gbExtras.ResumeLayout(false);
            this.gbExtras.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCodigo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox gbDatoPersonal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDpi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTelefono1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtApellido1;
        private System.Windows.Forms.TextBox txtNombre1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.GroupBox gbExtras;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtTelefonoExtra;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtNombreExtra;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtHoraAterrizaje;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtLugarSalida;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtPasaporte;
        private System.Windows.Forms.TextBox txtHoraDespegue;
        private System.Windows.Forms.ComboBox CbSeleccionCodigo;
        private System.Windows.Forms.ComboBox CbDestino;
        private System.Windows.Forms.TextBox txtReservacion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sALIRToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbRequerimiento;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.TextBox txtCodDestino;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbExtras;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtFechaReserva;

    }
}