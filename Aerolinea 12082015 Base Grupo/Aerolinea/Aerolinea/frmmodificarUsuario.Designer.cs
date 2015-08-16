namespace Aerolinea
{
    partial class frmmodificarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmmodificarUsuario));
            this.groupBoxDatosUsuario = new System.Windows.Forms.GroupBox();
            this.cmbModificarEstado = new System.Windows.Forms.ComboBox();
            this.lblestado = new System.Windows.Forms.Label();
            this.cmbSeleccionartipoModificar = new System.Windows.Forms.ComboBox();
            this.lblModificarTipo = new System.Windows.Forms.Label();
            this.txtPasswordModificar = new System.Windows.Forms.TextBox();
            this.txtUserModificar = new System.Windows.Forms.TextBox();
            this.txtApellidoModificar = new System.Windows.Forms.TextBox();
            this.txtNombreModificar = new System.Windows.Forms.TextBox();
            this.labelApellidoModificar = new System.Windows.Forms.Label();
            this.labelUserModificar = new System.Windows.Forms.Label();
            this.labelPassModificar = new System.Windows.Forms.Label();
            this.labelNombreModificar = new System.Windows.Forms.Label();
            this.btnGuardarUsuario = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sALIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbusuarioModificar = new System.Windows.Forms.ComboBox();
            this.btnBuscarUsuario = new System.Windows.Forms.Button();
            this.grpbusquedaModificar = new System.Windows.Forms.GroupBox();
            this.groupBoxDatosUsuario.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.grpbusquedaModificar.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDatosUsuario
            // 
            this.groupBoxDatosUsuario.Controls.Add(this.cmbModificarEstado);
            this.groupBoxDatosUsuario.Controls.Add(this.lblestado);
            this.groupBoxDatosUsuario.Controls.Add(this.cmbSeleccionartipoModificar);
            this.groupBoxDatosUsuario.Controls.Add(this.lblModificarTipo);
            this.groupBoxDatosUsuario.Controls.Add(this.txtPasswordModificar);
            this.groupBoxDatosUsuario.Controls.Add(this.txtUserModificar);
            this.groupBoxDatosUsuario.Controls.Add(this.txtApellidoModificar);
            this.groupBoxDatosUsuario.Controls.Add(this.txtNombreModificar);
            this.groupBoxDatosUsuario.Controls.Add(this.labelApellidoModificar);
            this.groupBoxDatosUsuario.Controls.Add(this.labelUserModificar);
            this.groupBoxDatosUsuario.Controls.Add(this.labelPassModificar);
            this.groupBoxDatosUsuario.Controls.Add(this.labelNombreModificar);
            this.groupBoxDatosUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDatosUsuario.Location = new System.Drawing.Point(12, 104);
            this.groupBoxDatosUsuario.Name = "groupBoxDatosUsuario";
            this.groupBoxDatosUsuario.Size = new System.Drawing.Size(334, 268);
            this.groupBoxDatosUsuario.TabIndex = 2;
            this.groupBoxDatosUsuario.TabStop = false;
            this.groupBoxDatosUsuario.Text = "Datos de Usuario";
            // 
            // cmbModificarEstado
            // 
            this.cmbModificarEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbModificarEstado.FormattingEnabled = true;
            this.cmbModificarEstado.Items.AddRange(new object[] {
            "ACTIVO",
            "INACTIVO"});
            this.cmbModificarEstado.Location = new System.Drawing.Point(110, 185);
            this.cmbModificarEstado.Name = "cmbModificarEstado";
            this.cmbModificarEstado.Size = new System.Drawing.Size(100, 24);
            this.cmbModificarEstado.TabIndex = 10;
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblestado.Location = new System.Drawing.Point(19, 185);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(68, 20);
            this.lblestado.TabIndex = 9;
            this.lblestado.Text = "Estado: ";
            // 
            // cmbSeleccionartipoModificar
            // 
            this.cmbSeleccionartipoModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSeleccionartipoModificar.FormattingEnabled = true;
            this.cmbSeleccionartipoModificar.Items.AddRange(new object[] {
            "ACTIVO",
            "INACTIVO"});
            this.cmbSeleccionartipoModificar.Location = new System.Drawing.Point(110, 222);
            this.cmbSeleccionartipoModificar.Name = "cmbSeleccionartipoModificar";
            this.cmbSeleccionartipoModificar.Size = new System.Drawing.Size(100, 24);
            this.cmbSeleccionartipoModificar.TabIndex = 1;
            // 
            // lblModificarTipo
            // 
            this.lblModificarTipo.AutoSize = true;
            this.lblModificarTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificarTipo.Location = new System.Drawing.Point(0, 226);
            this.lblModificarTipo.Name = "lblModificarTipo";
            this.lblModificarTipo.Size = new System.Drawing.Size(106, 20);
            this.lblModificarTipo.TabIndex = 8;
            this.lblModificarTipo.Text = "Tipo Usuario: ";
            // 
            // txtPasswordModificar
            // 
            this.txtPasswordModificar.Location = new System.Drawing.Point(110, 150);
            this.txtPasswordModificar.Name = "txtPasswordModificar";
            this.txtPasswordModificar.PasswordChar = '*';
            this.txtPasswordModificar.Size = new System.Drawing.Size(100, 21);
            this.txtPasswordModificar.TabIndex = 7;
            // 
            // txtUserModificar
            // 
            this.txtUserModificar.Location = new System.Drawing.Point(110, 107);
            this.txtUserModificar.Name = "txtUserModificar";
            this.txtUserModificar.Size = new System.Drawing.Size(100, 21);
            this.txtUserModificar.TabIndex = 6;
            // 
            // txtApellidoModificar
            // 
            this.txtApellidoModificar.Location = new System.Drawing.Point(110, 69);
            this.txtApellidoModificar.Name = "txtApellidoModificar";
            this.txtApellidoModificar.Size = new System.Drawing.Size(100, 21);
            this.txtApellidoModificar.TabIndex = 5;
            // 
            // txtNombreModificar
            // 
            this.txtNombreModificar.Location = new System.Drawing.Point(110, 31);
            this.txtNombreModificar.Name = "txtNombreModificar";
            this.txtNombreModificar.Size = new System.Drawing.Size(100, 21);
            this.txtNombreModificar.TabIndex = 4;
            // 
            // labelApellidoModificar
            // 
            this.labelApellidoModificar.AutoSize = true;
            this.labelApellidoModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApellidoModificar.Location = new System.Drawing.Point(19, 71);
            this.labelApellidoModificar.Name = "labelApellidoModificar";
            this.labelApellidoModificar.Size = new System.Drawing.Size(73, 20);
            this.labelApellidoModificar.TabIndex = 3;
            this.labelApellidoModificar.Text = "Apellido: ";
            // 
            // labelUserModificar
            // 
            this.labelUserModificar.AutoSize = true;
            this.labelUserModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserModificar.Location = new System.Drawing.Point(19, 107);
            this.labelUserModificar.Name = "labelUserModificar";
            this.labelUserModificar.Size = new System.Drawing.Size(68, 20);
            this.labelUserModificar.TabIndex = 2;
            this.labelUserModificar.Text = "Usuario:";
            // 
            // labelPassModificar
            // 
            this.labelPassModificar.AutoSize = true;
            this.labelPassModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassModificar.Location = new System.Drawing.Point(19, 150);
            this.labelPassModificar.Name = "labelPassModificar";
            this.labelPassModificar.Size = new System.Drawing.Size(86, 20);
            this.labelPassModificar.TabIndex = 1;
            this.labelPassModificar.Text = "Password: ";
            // 
            // labelNombreModificar
            // 
            this.labelNombreModificar.AutoSize = true;
            this.labelNombreModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreModificar.Location = new System.Drawing.Point(19, 31);
            this.labelNombreModificar.Name = "labelNombreModificar";
            this.labelNombreModificar.Size = new System.Drawing.Size(69, 20);
            this.labelNombreModificar.TabIndex = 0;
            this.labelNombreModificar.Text = "Nombre:";
            // 
            // btnGuardarUsuario
            // 
            this.btnGuardarUsuario.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarUsuario.Image")));
            this.btnGuardarUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarUsuario.Location = new System.Drawing.Point(357, 316);
            this.btnGuardarUsuario.Name = "btnGuardarUsuario";
            this.btnGuardarUsuario.Size = new System.Drawing.Size(110, 50);
            this.btnGuardarUsuario.TabIndex = 17;
            this.btnGuardarUsuario.Text = "Guardar";
            this.btnGuardarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarUsuario.UseVisualStyleBackColor = true;
            this.btnGuardarUsuario.Click += new System.EventHandler(this.btnGuardarUsuario_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sALIRToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(479, 27);
            this.menuStrip1.TabIndex = 182;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 16);
            this.label1.TabIndex = 183;
            this.label1.Text = "Seleccione Usuario: ";
            // 
            // cmbusuarioModificar
            // 
            this.cmbusuarioModificar.FormattingEnabled = true;
            this.cmbusuarioModificar.Location = new System.Drawing.Point(144, 32);
            this.cmbusuarioModificar.Name = "cmbusuarioModificar";
            this.cmbusuarioModificar.Size = new System.Drawing.Size(121, 21);
            this.cmbusuarioModificar.TabIndex = 184;
            // 
            // btnBuscarUsuario
            // 
            this.btnBuscarUsuario.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarUsuario.Image")));
            this.btnBuscarUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarUsuario.Location = new System.Drawing.Point(357, 46);
            this.btnBuscarUsuario.Name = "btnBuscarUsuario";
            this.btnBuscarUsuario.Size = new System.Drawing.Size(110, 50);
            this.btnBuscarUsuario.TabIndex = 185;
            this.btnBuscarUsuario.Text = "Buscar";
            this.btnBuscarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarUsuario.UseVisualStyleBackColor = true;
            this.btnBuscarUsuario.Click += new System.EventHandler(this.btnBuscarUsuario_Click);
            // 
            // grpbusquedaModificar
            // 
            this.grpbusquedaModificar.Controls.Add(this.label1);
            this.grpbusquedaModificar.Controls.Add(this.cmbusuarioModificar);
            this.grpbusquedaModificar.Location = new System.Drawing.Point(12, 30);
            this.grpbusquedaModificar.Name = "grpbusquedaModificar";
            this.grpbusquedaModificar.Size = new System.Drawing.Size(334, 72);
            this.grpbusquedaModificar.TabIndex = 186;
            this.grpbusquedaModificar.TabStop = false;
            this.grpbusquedaModificar.Text = "Busqueda Usuario";
            // 
            // frmmodificarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 384);
            this.ControlBox = false;
            this.Controls.Add(this.grpbusquedaModificar);
            this.Controls.Add(this.btnBuscarUsuario);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnGuardarUsuario);
            this.Controls.Add(this.groupBoxDatosUsuario);
            this.Name = "frmmodificarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Usuario";
            this.Load += new System.EventHandler(this.frmmodificarUsuario_Load);
            this.groupBoxDatosUsuario.ResumeLayout(false);
            this.groupBoxDatosUsuario.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpbusquedaModificar.ResumeLayout(false);
            this.grpbusquedaModificar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.GroupBox groupBoxDatosUsuario;
        public System.Windows.Forms.ComboBox cmbSeleccionartipoModificar;
        private System.Windows.Forms.Label lblModificarTipo;
        private System.Windows.Forms.TextBox txtPasswordModificar;
        private System.Windows.Forms.TextBox txtUserModificar;
        private System.Windows.Forms.TextBox txtApellidoModificar;
        private System.Windows.Forms.TextBox txtNombreModificar;
        private System.Windows.Forms.Label labelApellidoModificar;
        private System.Windows.Forms.Label labelUserModificar;
        private System.Windows.Forms.Label labelPassModificar;
        private System.Windows.Forms.Label labelNombreModificar;
        private System.Windows.Forms.Button btnGuardarUsuario;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sALIRToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbusuarioModificar;
        private System.Windows.Forms.Button btnBuscarUsuario;
        private System.Windows.Forms.Label lblestado;
        public System.Windows.Forms.ComboBox cmbModificarEstado;
        private System.Windows.Forms.GroupBox grpbusquedaModificar;
    }
}