namespace Aerolinea
{
    partial class frmcontrolLocalizaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcontrolLocalizaciones));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rEGRESARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBuscarLocalizacion = new System.Windows.Forms.TextBox();
            this.grdLocacion = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabLocalizacion = new System.Windows.Forms.TabControl();
            this.tabpLocalizacion = new System.Windows.Forms.TabPage();
            this.txtLugar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabpaeropuerto = new System.Windows.Forms.TabPage();
            this.cmbLugar = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAeropuerto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtBuscarAeropuerto = new System.Windows.Forms.TextBox();
            this.grdAeropuerto = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBuscarLocalización = new System.Windows.Forms.Button();
            this.btnGuardarAvion = new System.Windows.Forms.Button();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdLocacion)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabLocalizacion.SuspendLayout();
            this.tabpLocalizacion.SuspendLayout();
            this.tabpaeropuerto.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAeropuerto)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rEGRESARToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(789, 27);
            this.menuStrip1.TabIndex = 172;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rEGRESARToolStripMenuItem
            // 
            this.rEGRESARToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rEGRESARToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("rEGRESARToolStripMenuItem.Image")));
            this.rEGRESARToolStripMenuItem.Name = "rEGRESARToolStripMenuItem";
            this.rEGRESARToolStripMenuItem.Size = new System.Drawing.Size(106, 23);
            this.rEGRESARToolStripMenuItem.Text = "REGRESAR";
            this.rEGRESARToolStripMenuItem.Click += new System.EventHandler(this.rEGRESARToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBuscarLocalizacion);
            this.groupBox2.Controls.Add(this.grdLocacion);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(10, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(543, 174);
            this.groupBox2.TabIndex = 181;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Consulta Localizaciones";
            // 
            // txtBuscarLocalizacion
            // 
            this.txtBuscarLocalizacion.Location = new System.Drawing.Point(71, 26);
            this.txtBuscarLocalizacion.Name = "txtBuscarLocalizacion";
            this.txtBuscarLocalizacion.Size = new System.Drawing.Size(434, 20);
            this.txtBuscarLocalizacion.TabIndex = 3;
            // 
            // grdLocacion
            // 
            this.grdLocacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdLocacion.Location = new System.Drawing.Point(131, 52);
            this.grdLocacion.Name = "grdLocacion";
            this.grdLocacion.Size = new System.Drawing.Size(296, 116);
            this.grdLocacion.TabIndex = 185;
            this.grdLocacion.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Buscar:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabLocalizacion);
            this.groupBox1.Location = new System.Drawing.Point(29, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(625, 305);
            this.groupBox1.TabIndex = 180;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Localización";
            // 
            // tabLocalizacion
            // 
            this.tabLocalizacion.Controls.Add(this.tabpLocalizacion);
            this.tabLocalizacion.Controls.Add(this.tabpaeropuerto);
            this.tabLocalizacion.Location = new System.Drawing.Point(20, 22);
            this.tabLocalizacion.Name = "tabLocalizacion";
            this.tabLocalizacion.SelectedIndex = 0;
            this.tabLocalizacion.Size = new System.Drawing.Size(586, 278);
            this.tabLocalizacion.TabIndex = 0;
            // 
            // tabpLocalizacion
            // 
            this.tabpLocalizacion.Controls.Add(this.txtLugar);
            this.tabpLocalizacion.Controls.Add(this.label1);
            this.tabpLocalizacion.Controls.Add(this.groupBox2);
            this.tabpLocalizacion.Location = new System.Drawing.Point(4, 22);
            this.tabpLocalizacion.Name = "tabpLocalizacion";
            this.tabpLocalizacion.Padding = new System.Windows.Forms.Padding(3);
            this.tabpLocalizacion.Size = new System.Drawing.Size(578, 252);
            this.tabpLocalizacion.TabIndex = 0;
            this.tabpLocalizacion.Text = "Localización";
            this.tabpLocalizacion.UseVisualStyleBackColor = true;
            this.tabpLocalizacion.Click += new System.EventHandler(this.tabpLocalizacion_Click);
            // 
            // txtLugar
            // 
            this.txtLugar.Location = new System.Drawing.Point(78, 10);
            this.txtLugar.Name = "txtLugar";
            this.txtLugar.Size = new System.Drawing.Size(434, 20);
            this.txtLugar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lugar:";
            // 
            // tabpaeropuerto
            // 
            this.tabpaeropuerto.Controls.Add(this.cmbLugar);
            this.tabpaeropuerto.Controls.Add(this.label5);
            this.tabpaeropuerto.Controls.Add(this.txtAeropuerto);
            this.tabpaeropuerto.Controls.Add(this.label3);
            this.tabpaeropuerto.Controls.Add(this.groupBox3);
            this.tabpaeropuerto.Location = new System.Drawing.Point(4, 22);
            this.tabpaeropuerto.Name = "tabpaeropuerto";
            this.tabpaeropuerto.Padding = new System.Windows.Forms.Padding(3);
            this.tabpaeropuerto.Size = new System.Drawing.Size(578, 252);
            this.tabpaeropuerto.TabIndex = 1;
            this.tabpaeropuerto.Text = "Aeropuerto";
            this.tabpaeropuerto.UseVisualStyleBackColor = true;
            this.tabpaeropuerto.Click += new System.EventHandler(this.tabpaeropuerto_Click);
            // 
            // cmbLugar
            // 
            this.cmbLugar.FormattingEnabled = true;
            this.cmbLugar.Location = new System.Drawing.Point(127, 10);
            this.cmbLugar.Name = "cmbLugar";
            this.cmbLugar.Size = new System.Drawing.Size(121, 21);
            this.cmbLugar.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 19);
            this.label5.TabIndex = 185;
            this.label5.Text = "Aeropuerto";
            // 
            // txtAeropuerto
            // 
            this.txtAeropuerto.Location = new System.Drawing.Point(127, 35);
            this.txtAeropuerto.Name = "txtAeropuerto";
            this.txtAeropuerto.Size = new System.Drawing.Size(310, 20);
            this.txtAeropuerto.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 19);
            this.label3.TabIndex = 182;
            this.label3.Text = "Lugar:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtBuscarAeropuerto);
            this.groupBox3.Controls.Add(this.grdAeropuerto);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(10, 61);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(543, 185);
            this.groupBox3.TabIndex = 184;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Consulta Aeropuerto";
            // 
            // txtBuscarAeropuerto
            // 
            this.txtBuscarAeropuerto.Location = new System.Drawing.Point(71, 26);
            this.txtBuscarAeropuerto.Name = "txtBuscarAeropuerto";
            this.txtBuscarAeropuerto.Size = new System.Drawing.Size(434, 20);
            this.txtBuscarAeropuerto.TabIndex = 5;
            // 
            // grdAeropuerto
            // 
            this.grdAeropuerto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAeropuerto.Location = new System.Drawing.Point(131, 52);
            this.grdAeropuerto.Name = "grdAeropuerto";
            this.grdAeropuerto.Size = new System.Drawing.Size(296, 114);
            this.grdAeropuerto.TabIndex = 128;
            this.grdAeropuerto.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Buscar:";
            // 
            // btnBuscarLocalización
            // 
            this.btnBuscarLocalización.BackColor = System.Drawing.SystemColors.Control;
            this.btnBuscarLocalización.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarLocalización.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarLocalización.Image")));
            this.btnBuscarLocalización.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarLocalización.Location = new System.Drawing.Point(673, 111);
            this.btnBuscarLocalización.Name = "btnBuscarLocalización";
            this.btnBuscarLocalización.Size = new System.Drawing.Size(100, 50);
            this.btnBuscarLocalización.TabIndex = 183;
            this.btnBuscarLocalización.Text = "Buscar";
            this.btnBuscarLocalización.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarLocalización.UseVisualStyleBackColor = false;
            this.btnBuscarLocalización.Click += new System.EventHandler(this.btnBuscarLocalización_Click);
            // 
            // btnGuardarAvion
            // 
            this.btnGuardarAvion.BackColor = System.Drawing.SystemColors.Control;
            this.btnGuardarAvion.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarAvion.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarAvion.Image")));
            this.btnGuardarAvion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarAvion.Location = new System.Drawing.Point(673, 55);
            this.btnGuardarAvion.Name = "btnGuardarAvion";
            this.btnGuardarAvion.Size = new System.Drawing.Size(100, 50);
            this.btnGuardarAvion.TabIndex = 182;
            this.btnGuardarAvion.Text = "Guardar";
            this.btnGuardarAvion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarAvion.UseVisualStyleBackColor = false;
            this.btnGuardarAvion.Click += new System.EventHandler(this.btnGuardarAvion_Click);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.BackColor = System.Drawing.SystemColors.Control;
            this.btnRefrescar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefrescar.Image = global::Aerolinea.Properties.Resources.refresh;
            this.btnRefrescar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefrescar.Location = new System.Drawing.Point(673, 167);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(100, 50);
            this.btnRefrescar.TabIndex = 184;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefrescar.UseVisualStyleBackColor = false;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // frmcontrolLocalizaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(789, 342);
            this.ControlBox = false;
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.btnBuscarLocalización);
            this.Controls.Add(this.btnGuardarAvion);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(805, 381);
            this.MinimumSize = new System.Drawing.Size(805, 381);
            this.Name = "frmcontrolLocalizaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Localizaciones ";
            this.Load += new System.EventHandler(this.frmcontrolLocalizaciones_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdLocacion)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tabLocalizacion.ResumeLayout(false);
            this.tabpLocalizacion.ResumeLayout(false);
            this.tabpLocalizacion.PerformLayout();
            this.tabpaeropuerto.ResumeLayout(false);
            this.tabpaeropuerto.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAeropuerto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rEGRESARToolStripMenuItem;
        private System.Windows.Forms.Button btnBuscarLocalización;
        private System.Windows.Forms.Button btnGuardarAvion;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView grdLocacion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtLugar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscarLocalizacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabLocalizacion;
        private System.Windows.Forms.TabPage tabpLocalizacion;
        private System.Windows.Forms.TabPage tabpaeropuerto;
        private System.Windows.Forms.TextBox txtAeropuerto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtBuscarAeropuerto;
        private System.Windows.Forms.DataGridView grdAeropuerto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbLugar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRefrescar;
    }
}