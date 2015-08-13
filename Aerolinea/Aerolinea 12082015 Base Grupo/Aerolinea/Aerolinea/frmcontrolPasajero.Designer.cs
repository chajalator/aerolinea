namespace Aerolinea
{
    partial class frmcontrolPasajero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcontrolPasajero));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtnoPasaporte = new System.Windows.Forms.MaskedTextBox();
            this.txtEdadPasajero = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefonoPasajero = new System.Windows.Forms.MaskedTextBox();
            this.lstCorreoPasajero = new System.Windows.Forms.ListBox();
            this.lstTelefonoPasajero = new System.Windows.Forms.ListBox();
            this.dtpasajero = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.txtdpiPasajero = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCorreoPasajero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDireccionPasajero = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtApellidoPasajero = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomPasajero = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtBusquedaPasajero = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.grdPasajeros = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cmbcodPasajero = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.grdcorreoPasajero = new System.Windows.Forms.DataGridView();
            this.grdtelefonoPasajero = new System.Windows.Forms.DataGridView();
            this.btnBuscarPasajero = new System.Windows.Forms.Button();
            this.btnEliminarPasajero = new System.Windows.Forms.Button();
            this.btnModificarPasajero = new System.Windows.Forms.Button();
            this.btnGuardarPasajero = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lstmodificoPasajero = new System.Windows.Forms.ListBox();
            this.cmbeliminarPasajero = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sALIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnrefrescarBd = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPasajeros)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdcorreoPasajero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdtelefonoPasajero)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(347, -4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 23);
            this.label1.TabIndex = 127;
            this.label1.Text = "Registro de Pasajeros";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnAceptar);
            this.groupBox1.Controls.Add(this.txtnoPasaporte);
            this.groupBox1.Controls.Add(this.txtEdadPasajero);
            this.groupBox1.Controls.Add(this.txtTelefonoPasajero);
            this.groupBox1.Controls.Add(this.lstCorreoPasajero);
            this.groupBox1.Controls.Add(this.lstTelefonoPasajero);
            this.groupBox1.Controls.Add(this.dtpasajero);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtdpiPasajero);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtCorreoPasajero);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtDireccionPasajero);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtApellidoPasajero);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNomPasajero);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(16, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(722, 232);
            this.groupBox1.TabIndex = 169;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Pasajero";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.Image = global::Aerolinea.Properties.Resources.aceptar;
            this.button1.Location = new System.Drawing.Point(355, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 23);
            this.button1.TabIndex = 193;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = global::Aerolinea.Properties.Resources.aceptar;
            this.btnAceptar.Location = new System.Drawing.Point(355, 72);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(25, 23);
            this.btnAceptar.TabIndex = 192;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtnoPasaporte
            // 
            this.txtnoPasaporte.Location = new System.Drawing.Point(433, 205);
            this.txtnoPasaporte.Mask = "99999999999999";
            this.txtnoPasaporte.Name = "txtnoPasaporte";
            this.txtnoPasaporte.Size = new System.Drawing.Size(270, 20);
            this.txtnoPasaporte.TabIndex = 8;
            // 
            // txtEdadPasajero
            // 
            this.txtEdadPasajero.Location = new System.Drawing.Point(134, 175);
            this.txtEdadPasajero.Mask = "9999";
            this.txtEdadPasajero.Name = "txtEdadPasajero";
            this.txtEdadPasajero.Size = new System.Drawing.Size(160, 20);
            this.txtEdadPasajero.TabIndex = 6;
            // 
            // txtTelefonoPasajero
            // 
            this.txtTelefonoPasajero.Location = new System.Drawing.Point(134, 73);
            this.txtTelefonoPasajero.Mask = "00000000";
            this.txtTelefonoPasajero.Name = "txtTelefonoPasajero";
            this.txtTelefonoPasajero.Size = new System.Drawing.Size(211, 20);
            this.txtTelefonoPasajero.TabIndex = 4;
            // 
            // lstCorreoPasajero
            // 
            this.lstCorreoPasajero.FormattingEnabled = true;
            this.lstCorreoPasajero.Location = new System.Drawing.Point(134, 124);
            this.lstCorreoPasajero.Name = "lstCorreoPasajero";
            this.lstCorreoPasajero.Size = new System.Drawing.Size(569, 43);
            this.lstCorreoPasajero.TabIndex = 188;
            // 
            // lstTelefonoPasajero
            // 
            this.lstTelefonoPasajero.FormattingEnabled = true;
            this.lstTelefonoPasajero.Location = new System.Drawing.Point(386, 72);
            this.lstTelefonoPasajero.Name = "lstTelefonoPasajero";
            this.lstTelefonoPasajero.Size = new System.Drawing.Size(317, 43);
            this.lstTelefonoPasajero.TabIndex = 187;
            // 
            // dtpasajero
            // 
            this.dtpasajero.CustomFormat = "yyyy-MM-dd";
            this.dtpasajero.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpasajero.Location = new System.Drawing.Point(432, 177);
            this.dtpasajero.Name = "dtpasajero";
            this.dtpasajero.Size = new System.Drawing.Size(271, 20);
            this.dtpasajero.TabIndex = 100;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(297, 172);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 19);
            this.label11.TabIndex = 186;
            this.label11.Text = "Fecha  Nacimiento:";
            // 
            // txtdpiPasajero
            // 
            this.txtdpiPasajero.Location = new System.Drawing.Point(134, 206);
            this.txtdpiPasajero.Mask = "0000-00000-0000";
            this.txtdpiPasajero.Name = "txtdpiPasajero";
            this.txtdpiPasajero.Size = new System.Drawing.Size(160, 20);
            this.txtdpiPasajero.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(28, 206);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 19);
            this.label10.TabIndex = 182;
            this.label10.Text = "DPI:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(300, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 19);
            this.label7.TabIndex = 177;
            this.label7.Text = "No. Pasaporte:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 19);
            this.label6.TabIndex = 176;
            this.label6.Text = "Edad:";
            // 
            // txtCorreoPasajero
            // 
            this.txtCorreoPasajero.Location = new System.Drawing.Point(134, 98);
            this.txtCorreoPasajero.Name = "txtCorreoPasajero";
            this.txtCorreoPasajero.Size = new System.Drawing.Size(211, 20);
            this.txtCorreoPasajero.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 19);
            this.label2.TabIndex = 174;
            this.label2.Text = "Correo Electrónico:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 19);
            this.label8.TabIndex = 173;
            this.label8.Text = "Teléfono:";
            // 
            // txtDireccionPasajero
            // 
            this.txtDireccionPasajero.Location = new System.Drawing.Point(134, 46);
            this.txtDireccionPasajero.Name = "txtDireccionPasajero";
            this.txtDireccionPasajero.Size = new System.Drawing.Size(569, 20);
            this.txtDireccionPasajero.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 19);
            this.label5.TabIndex = 170;
            this.label5.Text = "Dirección";
            // 
            // txtApellidoPasajero
            // 
            this.txtApellidoPasajero.Location = new System.Drawing.Point(464, 20);
            this.txtApellidoPasajero.Name = "txtApellidoPasajero";
            this.txtApellidoPasajero.Size = new System.Drawing.Size(239, 20);
            this.txtApellidoPasajero.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(373, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 19);
            this.label4.TabIndex = 168;
            this.label4.Text = "Apellido:";
            // 
            // txtNomPasajero
            // 
            this.txtNomPasajero.Location = new System.Drawing.Point(134, 19);
            this.txtNomPasajero.Name = "txtNomPasajero";
            this.txtNomPasajero.Size = new System.Drawing.Size(211, 20);
            this.txtNomPasajero.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 19);
            this.label3.TabIndex = 166;
            this.label3.Text = "Nombre:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tabControl1);
            this.groupBox2.Location = new System.Drawing.Point(16, 305);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(886, 226);
            this.groupBox2.TabIndex = 170;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Consulta Pasajero";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(6, 19);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(865, 207);
            this.tabControl1.TabIndex = 171;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtBusquedaPasajero);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.grdPasajeros);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(857, 181);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Datos Pasajeros";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtBusquedaPasajero
            // 
            this.txtBusquedaPasajero.Location = new System.Drawing.Point(80, 15);
            this.txtBusquedaPasajero.Name = "txtBusquedaPasajero";
            this.txtBusquedaPasajero.Size = new System.Drawing.Size(443, 20);
            this.txtBusquedaPasajero.TabIndex = 171;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 19);
            this.label9.TabIndex = 172;
            this.label9.Text = "Buscar:";
            // 
            // grdPasajeros
            // 
            this.grdPasajeros.AllowUserToDeleteRows = false;
            this.grdPasajeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPasajeros.Location = new System.Drawing.Point(6, 53);
            this.grdPasajeros.Name = "grdPasajeros";
            this.grdPasajeros.Size = new System.Drawing.Size(845, 122);
            this.grdPasajeros.TabIndex = 170;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cmbcodPasajero);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.grdcorreoPasajero);
            this.tabPage2.Controls.Add(this.grdtelefonoPasajero);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(857, 181);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Datos Adicionales";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cmbcodPasajero
            // 
            this.cmbcodPasajero.FormattingEnabled = true;
            this.cmbcodPasajero.Location = new System.Drawing.Point(304, 13);
            this.cmbcodPasajero.Name = "cmbcodPasajero";
            this.cmbcodPasajero.Size = new System.Drawing.Size(121, 21);
            this.cmbcodPasajero.TabIndex = 176;
            this.cmbcodPasajero.SelectedIndexChanged += new System.EventHandler(this.cmbcodPasajero_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(26, 13);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(248, 19);
            this.label14.TabIndex = 173;
            this.label14.Text = "Buscar: (Ingrese Código de Pasajero)";
            // 
            // grdcorreoPasajero
            // 
            this.grdcorreoPasajero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdcorreoPasajero.Location = new System.Drawing.Point(367, 40);
            this.grdcorreoPasajero.Name = "grdcorreoPasajero";
            this.grdcorreoPasajero.Size = new System.Drawing.Size(448, 126);
            this.grdcorreoPasajero.TabIndex = 1;
            // 
            // grdtelefonoPasajero
            // 
            this.grdtelefonoPasajero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdtelefonoPasajero.Location = new System.Drawing.Point(80, 40);
            this.grdtelefonoPasajero.Name = "grdtelefonoPasajero";
            this.grdtelefonoPasajero.Size = new System.Drawing.Size(265, 126);
            this.grdtelefonoPasajero.TabIndex = 0;
            // 
            // btnBuscarPasajero
            // 
            this.btnBuscarPasajero.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPasajero.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarPasajero.Image")));
            this.btnBuscarPasajero.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarPasajero.Location = new System.Drawing.Point(744, 125);
            this.btnBuscarPasajero.Name = "btnBuscarPasajero";
            this.btnBuscarPasajero.Size = new System.Drawing.Size(110, 50);
            this.btnBuscarPasajero.TabIndex = 13;
            this.btnBuscarPasajero.Text = "Buscar";
            this.btnBuscarPasajero.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarPasajero.UseVisualStyleBackColor = true;
            this.btnBuscarPasajero.Click += new System.EventHandler(this.btnBuscarPasajero_Click);
            // 
            // btnEliminarPasajero
            // 
            this.btnEliminarPasajero.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarPasajero.Image = global::Aerolinea.Properties.Resources.eliminar;
            this.btnEliminarPasajero.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarPasajero.Location = new System.Drawing.Point(744, 233);
            this.btnEliminarPasajero.Name = "btnEliminarPasajero";
            this.btnEliminarPasajero.Size = new System.Drawing.Size(110, 50);
            this.btnEliminarPasajero.TabIndex = 15;
            this.btnEliminarPasajero.Text = "Eliminar";
            this.btnEliminarPasajero.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarPasajero.UseVisualStyleBackColor = true;
            this.btnEliminarPasajero.Click += new System.EventHandler(this.btnEliminarPasajero_Click);
            // 
            // btnModificarPasajero
            // 
            this.btnModificarPasajero.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarPasajero.Image = ((System.Drawing.Image)(resources.GetObject("btnModificarPasajero.Image")));
            this.btnModificarPasajero.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarPasajero.Location = new System.Drawing.Point(744, 177);
            this.btnModificarPasajero.Name = "btnModificarPasajero";
            this.btnModificarPasajero.Size = new System.Drawing.Size(110, 50);
            this.btnModificarPasajero.TabIndex = 14;
            this.btnModificarPasajero.Text = "Modificar";
            this.btnModificarPasajero.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificarPasajero.UseVisualStyleBackColor = true;
            this.btnModificarPasajero.Click += new System.EventHandler(this.btnModificarPasajero_Click);
            // 
            // btnGuardarPasajero
            // 
            this.btnGuardarPasajero.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarPasajero.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarPasajero.Image")));
            this.btnGuardarPasajero.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarPasajero.Location = new System.Drawing.Point(744, 72);
            this.btnGuardarPasajero.Name = "btnGuardarPasajero";
            this.btnGuardarPasajero.Size = new System.Drawing.Size(110, 50);
            this.btnGuardarPasajero.TabIndex = 12;
            this.btnGuardarPasajero.Text = "Guardar";
            this.btnGuardarPasajero.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarPasajero.UseVisualStyleBackColor = true;
            this.btnGuardarPasajero.Click += new System.EventHandler(this.btnGuardarPasajero_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstmodificoPasajero);
            this.groupBox3.Controls.Add(this.cmbeliminarPasajero);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(317, 260);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(391, 80);
            this.groupBox3.TabIndex = 171;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Modificar/Eliminar";
            // 
            // lstmodificoPasajero
            // 
            this.lstmodificoPasajero.FormattingEnabled = true;
            this.lstmodificoPasajero.Location = new System.Drawing.Point(105, 13);
            this.lstmodificoPasajero.Name = "lstmodificoPasajero";
            this.lstmodificoPasajero.Size = new System.Drawing.Size(257, 30);
            this.lstmodificoPasajero.TabIndex = 183;
            this.lstmodificoPasajero.SelectedIndexChanged += new System.EventHandler(this.lstmodificoPasajero_SelectedIndexChanged_1);
            // 
            // cmbeliminarPasajero
            // 
            this.cmbeliminarPasajero.FormattingEnabled = true;
            this.cmbeliminarPasajero.Location = new System.Drawing.Point(105, 49);
            this.cmbeliminarPasajero.Name = "cmbeliminarPasajero";
            this.cmbeliminarPasajero.Size = new System.Drawing.Size(257, 21);
            this.cmbeliminarPasajero.TabIndex = 181;
            this.cmbeliminarPasajero.Text = "Seleccione Código a Eliminar";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(25, 48);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 19);
            this.label13.TabIndex = 182;
            this.label13.Text = "Eliminar:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(25, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 19);
            this.label12.TabIndex = 180;
            this.label12.Text = "Modificar:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sALIRToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(914, 27);
            this.menuStrip1.TabIndex = 181;
            this.menuStrip1.Text = "menuStrip1";
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
            // btnrefrescarBd
            // 
            this.btnrefrescarBd.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrefrescarBd.Image = global::Aerolinea.Properties.Resources.refresh;
            this.btnrefrescarBd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnrefrescarBd.Location = new System.Drawing.Point(744, 286);
            this.btnrefrescarBd.Name = "btnrefrescarBd";
            this.btnrefrescarBd.Size = new System.Drawing.Size(110, 50);
            this.btnrefrescarBd.TabIndex = 172;
            this.btnrefrescarBd.Text = "RefrescarBD";
            this.btnrefrescarBd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnrefrescarBd.UseVisualStyleBackColor = true;
            this.btnrefrescarBd.Click += new System.EventHandler(this.btnrefrescarBd_Click);
            // 
            // frmcontrolPasajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(914, 543);
            this.ControlBox = false;
            this.Controls.Add(this.btnrefrescarBd);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBuscarPasajero);
            this.Controls.Add(this.btnEliminarPasajero);
            this.Controls.Add(this.btnModificarPasajero);
            this.Controls.Add(this.btnGuardarPasajero);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(930, 582);
            this.MinimumSize = new System.Drawing.Size(930, 582);
            this.Name = "frmcontrolPasajero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro Pasajero";
            this.Load += new System.EventHandler(this.ingresoPasajero_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPasajeros)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdcorreoPasajero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdtelefonoPasajero)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardarPasajero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminarPasajero;
        private System.Windows.Forms.Button btnModificarPasajero;
        private System.Windows.Forms.Button btnBuscarPasajero;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCorreoPasajero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDireccionPasajero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtApellidoPasajero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNomPasajero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpasajero;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox txtdpiPasajero;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView grdPasajeros;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView grdcorreoPasajero;
        private System.Windows.Forms.DataGridView grdtelefonoPasajero;
        private System.Windows.Forms.TextBox txtBusquedaPasajero;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lstmodificoPasajero;
        private System.Windows.Forms.ComboBox cmbeliminarPasajero;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sALIRToolStripMenuItem;
        private System.Windows.Forms.Button btnrefrescarBd;
        private System.Windows.Forms.ListBox lstTelefonoPasajero;
        private System.Windows.Forms.ListBox lstCorreoPasajero;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.MaskedTextBox txtnoPasaporte;
        private System.Windows.Forms.MaskedTextBox txtEdadPasajero;
        private System.Windows.Forms.MaskedTextBox txtTelefonoPasajero;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbcodPasajero;

    }
}