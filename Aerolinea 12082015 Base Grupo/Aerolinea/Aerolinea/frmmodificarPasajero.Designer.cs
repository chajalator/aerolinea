namespace Aerolinea
{
    partial class frmmodificarPasajero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmmodificarPasajero));
            this.cmbmodificoPasajero = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtnoPasaporte = new System.Windows.Forms.MaskedTextBox();
            this.txtEdadPasajero = new System.Windows.Forms.MaskedTextBox();
            this.dtpasajero = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.txtdpiPasajero = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDireccionPasajero = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtApellidoPasajero = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomPasajero = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbestadoPasajero = new System.Windows.Forms.ComboBox();
            this.cmbcodigoModificar = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txtTelefonoPasajero = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.sALIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBuscarPasajero = new System.Windows.Forms.Button();
            this.btnGuardarPasajero = new System.Windows.Forms.Button();
            this.btnagregarCorreo = new System.Windows.Forms.Button();
            this.btnbuscarCodModificar = new System.Windows.Forms.Button();
            this.btneliminarCorreo = new System.Windows.Forms.Button();
            this.btnmodificarCorreo = new System.Windows.Forms.Button();
            this.cmbcorreosPasajero = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.radnuevoCorreo = new System.Windows.Forms.RadioButton();
            this.radmodificarCorreo = new System.Windows.Forms.RadioButton();
            this.radeliminarCorreo = new System.Windows.Forms.RadioButton();
            this.txtCorreoPasajero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rEFRESCARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radeliminarTelefono = new System.Windows.Forms.RadioButton();
            this.radmodificarTelefono = new System.Windows.Forms.RadioButton();
            this.radnuevoTelefono = new System.Windows.Forms.RadioButton();
            this.btnmodificarTelefono = new System.Windows.Forms.Button();
            this.btneliminarTelefono = new System.Windows.Forms.Button();
            this.btnnuevoTelefono = new System.Windows.Forms.Button();
            this.cmbtelefonosPasajero = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbmodificoPasajero
            // 
            this.cmbmodificoPasajero.FormattingEnabled = true;
            this.cmbmodificoPasajero.Location = new System.Drawing.Point(187, 17);
            this.cmbmodificoPasajero.Name = "cmbmodificoPasajero";
            this.cmbmodificoPasajero.Size = new System.Drawing.Size(178, 21);
            this.cmbmodificoPasajero.TabIndex = 186;
            this.cmbmodificoPasajero.Text = "Seleccione Código a Modificar";
            this.cmbmodificoPasajero.SelectedIndexChanged += new System.EventHandler(this.cmbmodificoPasajero_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(107, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 19);
            this.label12.TabIndex = 185;
            this.label12.Text = "Modificar:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Location = new System.Drawing.Point(12, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(668, 333);
            this.groupBox1.TabIndex = 187;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Pasajero";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(234, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 23);
            this.label1.TabIndex = 127;
            this.label1.Text = "Modificar Pasajero";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(6, 19);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(656, 324);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnBuscarPasajero);
            this.tabPage1.Controls.Add(this.btnGuardarPasajero);
            this.tabPage1.Controls.Add(this.cmbestadoPasajero);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.cmbmodificoPasajero);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.txtnoPasaporte);
            this.tabPage1.Controls.Add(this.txtEdadPasajero);
            this.tabPage1.Controls.Add(this.dtpasajero);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.txtdpiPasajero);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txtDireccionPasajero);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtApellidoPasajero);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtNomPasajero);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(648, 298);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Datos Básicos";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tabControl2);
            this.tabPage2.Controls.Add(this.btnbuscarCodModificar);
            this.tabPage2.Controls.Add(this.cmbcodigoModificar);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(648, 298);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Datos Adicionales";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtnoPasaporte
            // 
            this.txtnoPasaporte.Location = new System.Drawing.Point(160, 221);
            this.txtnoPasaporte.Mask = "99999999999999";
            this.txtnoPasaporte.Name = "txtnoPasaporte";
            this.txtnoPasaporte.Size = new System.Drawing.Size(270, 20);
            this.txtnoPasaporte.TabIndex = 201;
            // 
            // txtEdadPasajero
            // 
            this.txtEdadPasajero.Location = new System.Drawing.Point(160, 125);
            this.txtEdadPasajero.Mask = "9999";
            this.txtEdadPasajero.Name = "txtEdadPasajero";
            this.txtEdadPasajero.Size = new System.Drawing.Size(160, 20);
            this.txtEdadPasajero.TabIndex = 199;
            // 
            // dtpasajero
            // 
            this.dtpasajero.CustomFormat = "yyyy-MM-dd";
            this.dtpasajero.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpasajero.Location = new System.Drawing.Point(187, 161);
            this.dtpasajero.Name = "dtpasajero";
            this.dtpasajero.Size = new System.Drawing.Size(271, 20);
            this.dtpasajero.TabIndex = 202;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(52, 156);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 19);
            this.label11.TabIndex = 211;
            this.label11.Text = "Fecha  Nacimiento:";
            // 
            // txtdpiPasajero
            // 
            this.txtdpiPasajero.Location = new System.Drawing.Point(160, 189);
            this.txtdpiPasajero.Mask = "0000-00000-0000";
            this.txtdpiPasajero.Name = "txtdpiPasajero";
            this.txtdpiPasajero.Size = new System.Drawing.Size(160, 20);
            this.txtdpiPasajero.TabIndex = 200;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(52, 188);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 19);
            this.label10.TabIndex = 210;
            this.label10.Text = "DPI:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(50, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 19);
            this.label7.TabIndex = 209;
            this.label7.Text = "No. Pasaporte:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(52, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 19);
            this.label6.TabIndex = 208;
            this.label6.Text = "Edad:";
            // 
            // txtDireccionPasajero
            // 
            this.txtDireccionPasajero.Location = new System.Drawing.Point(160, 99);
            this.txtDireccionPasajero.Name = "txtDireccionPasajero";
            this.txtDireccionPasajero.Size = new System.Drawing.Size(239, 20);
            this.txtDireccionPasajero.TabIndex = 196;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 19);
            this.label5.TabIndex = 205;
            this.label5.Text = "Dirección";
            // 
            // txtApellidoPasajero
            // 
            this.txtApellidoPasajero.Location = new System.Drawing.Point(160, 70);
            this.txtApellidoPasajero.Name = "txtApellidoPasajero";
            this.txtApellidoPasajero.Size = new System.Drawing.Size(239, 20);
            this.txtApellidoPasajero.TabIndex = 195;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 19);
            this.label4.TabIndex = 204;
            this.label4.Text = "Apellido:";
            // 
            // txtNomPasajero
            // 
            this.txtNomPasajero.Location = new System.Drawing.Point(160, 44);
            this.txtNomPasajero.Name = "txtNomPasajero";
            this.txtNomPasajero.Size = new System.Drawing.Size(239, 20);
            this.txtNomPasajero.TabIndex = 194;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 19);
            this.label3.TabIndex = 203;
            this.label3.Text = "Nombre:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sALIRToolStripMenuItem,
            this.rEFRESCARToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(692, 27);
            this.menuStrip1.TabIndex = 188;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(52, 251);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 19);
            this.label9.TabIndex = 212;
            this.label9.Text = "No. Pasaporte:";
            // 
            // cmbestadoPasajero
            // 
            this.cmbestadoPasajero.FormattingEnabled = true;
            this.cmbestadoPasajero.Items.AddRange(new object[] {
            "ACTIVO",
            "INACTIVO"});
            this.cmbestadoPasajero.Location = new System.Drawing.Point(160, 252);
            this.cmbestadoPasajero.Name = "cmbestadoPasajero";
            this.cmbestadoPasajero.Size = new System.Drawing.Size(160, 21);
            this.cmbestadoPasajero.TabIndex = 213;
            // 
            // cmbcodigoModificar
            // 
            this.cmbcodigoModificar.FormattingEnabled = true;
            this.cmbcodigoModificar.Location = new System.Drawing.Point(95, 24);
            this.cmbcodigoModificar.Name = "cmbcodigoModificar";
            this.cmbcodigoModificar.Size = new System.Drawing.Size(178, 21);
            this.cmbcodigoModificar.TabIndex = 225;
            this.cmbcodigoModificar.Text = "Seleccione Código a Modificar";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(15, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 19);
            this.label13.TabIndex = 224;
            this.label13.Text = "Modificar:";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(19, 73);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(609, 213);
            this.tabControl2.TabIndex = 227;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.cmbtelefonosPasajero);
            this.tabPage3.Controls.Add(this.radeliminarTelefono);
            this.tabPage3.Controls.Add(this.radmodificarTelefono);
            this.tabPage3.Controls.Add(this.radnuevoTelefono);
            this.tabPage3.Controls.Add(this.btnmodificarTelefono);
            this.tabPage3.Controls.Add(this.btneliminarTelefono);
            this.tabPage3.Controls.Add(this.btnnuevoTelefono);
            this.tabPage3.Controls.Add(this.txtTelefonoPasajero);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(601, 187);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Teléfono";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.txtCorreoPasajero);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.radeliminarCorreo);
            this.tabPage4.Controls.Add(this.radmodificarCorreo);
            this.tabPage4.Controls.Add(this.radnuevoCorreo);
            this.tabPage4.Controls.Add(this.label14);
            this.tabPage4.Controls.Add(this.cmbcorreosPasajero);
            this.tabPage4.Controls.Add(this.btnmodificarCorreo);
            this.tabPage4.Controls.Add(this.btneliminarCorreo);
            this.tabPage4.Controls.Add(this.btnagregarCorreo);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(601, 187);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Correo";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // txtTelefonoPasajero
            // 
            this.txtTelefonoPasajero.Location = new System.Drawing.Point(176, 55);
            this.txtTelefonoPasajero.Mask = "00000000";
            this.txtTelefonoPasajero.Name = "txtTelefonoPasajero";
            this.txtTelefonoPasajero.Size = new System.Drawing.Size(211, 20);
            this.txtTelefonoPasajero.TabIndex = 224;
            this.txtTelefonoPasajero.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(54, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 19);
            this.label8.TabIndex = 226;
            this.label8.Text = "Teléfono:";
            this.label8.Visible = false;
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
            // btnBuscarPasajero
            // 
            this.btnBuscarPasajero.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPasajero.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarPasajero.Image")));
            this.btnBuscarPasajero.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarPasajero.Location = new System.Drawing.Point(424, 12);
            this.btnBuscarPasajero.Name = "btnBuscarPasajero";
            this.btnBuscarPasajero.Size = new System.Drawing.Size(110, 50);
            this.btnBuscarPasajero.TabIndex = 215;
            this.btnBuscarPasajero.Text = "Buscar";
            this.btnBuscarPasajero.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarPasajero.UseVisualStyleBackColor = true;
            this.btnBuscarPasajero.Click += new System.EventHandler(this.btnBuscarPasajero_Click);
            // 
            // btnGuardarPasajero
            // 
            this.btnGuardarPasajero.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarPasajero.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarPasajero.Image")));
            this.btnGuardarPasajero.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarPasajero.Location = new System.Drawing.Point(516, 99);
            this.btnGuardarPasajero.Name = "btnGuardarPasajero";
            this.btnGuardarPasajero.Size = new System.Drawing.Size(110, 50);
            this.btnGuardarPasajero.TabIndex = 214;
            this.btnGuardarPasajero.Text = "Guardar";
            this.btnGuardarPasajero.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarPasajero.UseVisualStyleBackColor = true;
            this.btnGuardarPasajero.Click += new System.EventHandler(this.btnGuardarPasajero_Click);
            // 
            // btnagregarCorreo
            // 
            this.btnagregarCorreo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregarCorreo.Image = global::Aerolinea.Properties.Resources.agregar_correo;
            this.btnagregarCorreo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnagregarCorreo.Location = new System.Drawing.Point(471, 15);
            this.btnagregarCorreo.Name = "btnagregarCorreo";
            this.btnagregarCorreo.Size = new System.Drawing.Size(110, 50);
            this.btnagregarCorreo.TabIndex = 233;
            this.btnagregarCorreo.Text = " Correo";
            this.btnagregarCorreo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnagregarCorreo.UseVisualStyleBackColor = true;
            this.btnagregarCorreo.Visible = false;
            this.btnagregarCorreo.Click += new System.EventHandler(this.btnagregarCorreo_Click);
            // 
            // btnbuscarCodModificar
            // 
            this.btnbuscarCodModificar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscarCodModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnbuscarCodModificar.Image")));
            this.btnbuscarCodModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbuscarCodModificar.Location = new System.Drawing.Point(322, 8);
            this.btnbuscarCodModificar.Name = "btnbuscarCodModificar";
            this.btnbuscarCodModificar.Size = new System.Drawing.Size(110, 50);
            this.btnbuscarCodModificar.TabIndex = 226;
            this.btnbuscarCodModificar.Text = "Buscar";
            this.btnbuscarCodModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnbuscarCodModificar.UseVisualStyleBackColor = true;
            this.btnbuscarCodModificar.Click += new System.EventHandler(this.btnbuscarCodModificar_Click);
            // 
            // btneliminarCorreo
            // 
            this.btneliminarCorreo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminarCorreo.Image = global::Aerolinea.Properties.Resources.eliminar_correo;
            this.btneliminarCorreo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btneliminarCorreo.Location = new System.Drawing.Point(471, 126);
            this.btneliminarCorreo.Name = "btneliminarCorreo";
            this.btneliminarCorreo.Size = new System.Drawing.Size(110, 50);
            this.btneliminarCorreo.TabIndex = 234;
            this.btneliminarCorreo.Text = "Correo";
            this.btneliminarCorreo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btneliminarCorreo.UseVisualStyleBackColor = true;
            this.btneliminarCorreo.Visible = false;
            this.btneliminarCorreo.Click += new System.EventHandler(this.btneliminarCorreo_Click);
            // 
            // btnmodificarCorreo
            // 
            this.btnmodificarCorreo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodificarCorreo.Image = global::Aerolinea.Properties.Resources.modificar_correo;
            this.btnmodificarCorreo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmodificarCorreo.Location = new System.Drawing.Point(471, 70);
            this.btnmodificarCorreo.Name = "btnmodificarCorreo";
            this.btnmodificarCorreo.Size = new System.Drawing.Size(110, 50);
            this.btnmodificarCorreo.TabIndex = 235;
            this.btnmodificarCorreo.Text = "Correo";
            this.btnmodificarCorreo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnmodificarCorreo.UseVisualStyleBackColor = true;
            this.btnmodificarCorreo.Visible = false;
            this.btnmodificarCorreo.Click += new System.EventHandler(this.btnmodificarCorreo_Click);
            // 
            // cmbcorreosPasajero
            // 
            this.cmbcorreosPasajero.FormattingEnabled = true;
            this.cmbcorreosPasajero.Location = new System.Drawing.Point(195, 101);
            this.cmbcorreosPasajero.Name = "cmbcorreosPasajero";
            this.cmbcorreosPasajero.Size = new System.Drawing.Size(209, 21);
            this.cmbcorreosPasajero.TabIndex = 236;
            this.cmbcorreosPasajero.Visible = false;
            this.cmbcorreosPasajero.SelectedIndexChanged += new System.EventHandler(this.cmbcorreosPasajero_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(57, 103);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(132, 19);
            this.label14.TabIndex = 237;
            this.label14.Text = "Correo Electrónico:";
            this.label14.Visible = false;
            // 
            // radnuevoCorreo
            // 
            this.radnuevoCorreo.AutoSize = true;
            this.radnuevoCorreo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radnuevoCorreo.Location = new System.Drawing.Point(44, 15);
            this.radnuevoCorreo.Name = "radnuevoCorreo";
            this.radnuevoCorreo.Size = new System.Drawing.Size(115, 23);
            this.radnuevoCorreo.TabIndex = 238;
            this.radnuevoCorreo.TabStop = true;
            this.radnuevoCorreo.Text = "Nuevo Correo";
            this.radnuevoCorreo.UseVisualStyleBackColor = true;
            this.radnuevoCorreo.CheckedChanged += new System.EventHandler(this.radnuevoCorreo_CheckedChanged);
            // 
            // radmodificarCorreo
            // 
            this.radmodificarCorreo.AutoSize = true;
            this.radmodificarCorreo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radmodificarCorreo.Location = new System.Drawing.Point(165, 15);
            this.radmodificarCorreo.Name = "radmodificarCorreo";
            this.radmodificarCorreo.Size = new System.Drawing.Size(135, 23);
            this.radmodificarCorreo.TabIndex = 239;
            this.radmodificarCorreo.TabStop = true;
            this.radmodificarCorreo.Text = "Modificar Correo";
            this.radmodificarCorreo.UseVisualStyleBackColor = true;
            this.radmodificarCorreo.CheckedChanged += new System.EventHandler(this.radmodificarCorreo_CheckedChanged);
            // 
            // radeliminarCorreo
            // 
            this.radeliminarCorreo.AutoSize = true;
            this.radeliminarCorreo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radeliminarCorreo.Location = new System.Drawing.Point(299, 15);
            this.radeliminarCorreo.Name = "radeliminarCorreo";
            this.radeliminarCorreo.Size = new System.Drawing.Size(127, 23);
            this.radeliminarCorreo.TabIndex = 240;
            this.radeliminarCorreo.TabStop = true;
            this.radeliminarCorreo.Text = "Eliminar Correo";
            this.radeliminarCorreo.UseVisualStyleBackColor = true;
            this.radeliminarCorreo.CheckedChanged += new System.EventHandler(this.radeliminarCorreo_CheckedChanged);
            // 
            // txtCorreoPasajero
            // 
            this.txtCorreoPasajero.Location = new System.Drawing.Point(193, 71);
            this.txtCorreoPasajero.Name = "txtCorreoPasajero";
            this.txtCorreoPasajero.Size = new System.Drawing.Size(235, 20);
            this.txtCorreoPasajero.TabIndex = 241;
            this.txtCorreoPasajero.Visible = false;
            this.txtCorreoPasajero.WordWrap = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 19);
            this.label2.TabIndex = 242;
            this.label2.Text = "Nuevo Correo Electrónico:";
            this.label2.Visible = false;
            // 
            // rEFRESCARToolStripMenuItem
            // 
            this.rEFRESCARToolStripMenuItem.Image = global::Aerolinea.Properties.Resources.refresh;
            this.rEFRESCARToolStripMenuItem.Name = "rEFRESCARToolStripMenuItem";
            this.rEFRESCARToolStripMenuItem.Size = new System.Drawing.Size(99, 23);
            this.rEFRESCARToolStripMenuItem.Text = "REFRESCAR ";
            this.rEFRESCARToolStripMenuItem.Click += new System.EventHandler(this.rEFRESCARToolStripMenuItem_Click);
            // 
            // radeliminarTelefono
            // 
            this.radeliminarTelefono.AutoSize = true;
            this.radeliminarTelefono.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radeliminarTelefono.Location = new System.Drawing.Point(307, 13);
            this.radeliminarTelefono.Name = "radeliminarTelefono";
            this.radeliminarTelefono.Size = new System.Drawing.Size(140, 23);
            this.radeliminarTelefono.TabIndex = 246;
            this.radeliminarTelefono.TabStop = true;
            this.radeliminarTelefono.Text = "Eliminar Teléfono";
            this.radeliminarTelefono.UseVisualStyleBackColor = true;
            this.radeliminarTelefono.CheckedChanged += new System.EventHandler(this.radeliminarTelefono_CheckedChanged);
            // 
            // radmodificarTelefono
            // 
            this.radmodificarTelefono.AutoSize = true;
            this.radmodificarTelefono.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radmodificarTelefono.Location = new System.Drawing.Point(153, 13);
            this.radmodificarTelefono.Name = "radmodificarTelefono";
            this.radmodificarTelefono.Size = new System.Drawing.Size(148, 23);
            this.radmodificarTelefono.TabIndex = 245;
            this.radmodificarTelefono.TabStop = true;
            this.radmodificarTelefono.Text = "Modificar Teléfono";
            this.radmodificarTelefono.UseVisualStyleBackColor = true;
            this.radmodificarTelefono.CheckedChanged += new System.EventHandler(this.radmodificarTelefono_CheckedChanged);
            // 
            // radnuevoTelefono
            // 
            this.radnuevoTelefono.AutoSize = true;
            this.radnuevoTelefono.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radnuevoTelefono.Location = new System.Drawing.Point(32, 13);
            this.radnuevoTelefono.Name = "radnuevoTelefono";
            this.radnuevoTelefono.Size = new System.Drawing.Size(128, 23);
            this.radnuevoTelefono.TabIndex = 244;
            this.radnuevoTelefono.TabStop = true;
            this.radnuevoTelefono.Text = "Nuevo Teléfono";
            this.radnuevoTelefono.UseVisualStyleBackColor = true;
            this.radnuevoTelefono.CheckedChanged += new System.EventHandler(this.radnuevoTelefono_CheckedChanged);
            // 
            // btnmodificarTelefono
            // 
            this.btnmodificarTelefono.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodificarTelefono.Image = global::Aerolinea.Properties.Resources.editar;
            this.btnmodificarTelefono.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmodificarTelefono.Location = new System.Drawing.Point(459, 68);
            this.btnmodificarTelefono.Name = "btnmodificarTelefono";
            this.btnmodificarTelefono.Size = new System.Drawing.Size(110, 50);
            this.btnmodificarTelefono.TabIndex = 243;
            this.btnmodificarTelefono.Text = "Teléfono";
            this.btnmodificarTelefono.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnmodificarTelefono.UseVisualStyleBackColor = true;
            this.btnmodificarTelefono.Visible = false;
            this.btnmodificarTelefono.Click += new System.EventHandler(this.btnmodificarTelefono_Click);
            // 
            // btneliminarTelefono
            // 
            this.btneliminarTelefono.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminarTelefono.Image = global::Aerolinea.Properties.Resources.eliminar;
            this.btneliminarTelefono.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btneliminarTelefono.Location = new System.Drawing.Point(459, 124);
            this.btneliminarTelefono.Name = "btneliminarTelefono";
            this.btneliminarTelefono.Size = new System.Drawing.Size(110, 50);
            this.btneliminarTelefono.TabIndex = 242;
            this.btneliminarTelefono.Text = "Teléfono";
            this.btneliminarTelefono.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btneliminarTelefono.UseVisualStyleBackColor = true;
            this.btneliminarTelefono.Visible = false;
            this.btneliminarTelefono.Click += new System.EventHandler(this.btneliminarTelefono_Click);
            // 
            // btnnuevoTelefono
            // 
            this.btnnuevoTelefono.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnuevoTelefono.Image = global::Aerolinea.Properties.Resources.guardar;
            this.btnnuevoTelefono.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnnuevoTelefono.Location = new System.Drawing.Point(459, 13);
            this.btnnuevoTelefono.Name = "btnnuevoTelefono";
            this.btnnuevoTelefono.Size = new System.Drawing.Size(110, 50);
            this.btnnuevoTelefono.TabIndex = 241;
            this.btnnuevoTelefono.Text = "Teléfono";
            this.btnnuevoTelefono.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnnuevoTelefono.UseVisualStyleBackColor = true;
            this.btnnuevoTelefono.Visible = false;
            this.btnnuevoTelefono.Click += new System.EventHandler(this.btnnuevoTelefono_Click);
            // 
            // cmbtelefonosPasajero
            // 
            this.cmbtelefonosPasajero.FormattingEnabled = true;
            this.cmbtelefonosPasajero.Location = new System.Drawing.Point(176, 81);
            this.cmbtelefonosPasajero.Name = "cmbtelefonosPasajero";
            this.cmbtelefonosPasajero.Size = new System.Drawing.Size(209, 21);
            this.cmbtelefonosPasajero.TabIndex = 247;
            this.cmbtelefonosPasajero.Visible = false;
            this.cmbtelefonosPasajero.SelectedIndexChanged += new System.EventHandler(this.cmbtelefonosPasajero_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(54, 83);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 19);
            this.label15.TabIndex = 248;
            this.label15.Text = "Teléfono:";
            this.label15.Visible = false;
            // 
            // frmmodificarPasajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(692, 412);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(602, 451);
            this.Name = "frmmodificarPasajero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Pasajero";
            this.Load += new System.EventHandler(this.frmmodificarPasajero_Load);
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbmodificoPasajero;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.MaskedTextBox txtnoPasaporte;
        private System.Windows.Forms.MaskedTextBox txtEdadPasajero;
        private System.Windows.Forms.DateTimePicker dtpasajero;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox txtdpiPasajero;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDireccionPasajero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtApellidoPasajero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNomPasajero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sALIRToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmbestadoPasajero;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnBuscarPasajero;
        private System.Windows.Forms.Button btnGuardarPasajero;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.MaskedTextBox txtTelefonoPasajero;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnagregarCorreo;
        private System.Windows.Forms.Button btnbuscarCodModificar;
        private System.Windows.Forms.ComboBox cmbcodigoModificar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbcorreosPasajero;
        private System.Windows.Forms.Button btnmodificarCorreo;
        private System.Windows.Forms.Button btneliminarCorreo;
        private System.Windows.Forms.TextBox txtCorreoPasajero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radeliminarCorreo;
        private System.Windows.Forms.RadioButton radmodificarCorreo;
        private System.Windows.Forms.RadioButton radnuevoCorreo;
        private System.Windows.Forms.ToolStripMenuItem rEFRESCARToolStripMenuItem;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbtelefonosPasajero;
        private System.Windows.Forms.RadioButton radeliminarTelefono;
        private System.Windows.Forms.RadioButton radmodificarTelefono;
        private System.Windows.Forms.RadioButton radnuevoTelefono;
        private System.Windows.Forms.Button btnmodificarTelefono;
        private System.Windows.Forms.Button btneliminarTelefono;
        private System.Windows.Forms.Button btnnuevoTelefono;
    }
}