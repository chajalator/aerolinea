namespace Aerolinea
{
    partial class frmcontrolAvion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcontrolAvion));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtmodelo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtaerolinea = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grdaviones = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sALIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aGREGARTIPOAVIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificarAvion = new System.Windows.Forms.Button();
            this.btnBuscarAvion = new System.Windows.Forms.Button();
            this.btnGuardarAvion = new System.Windows.Forms.Button();
            this.txtmatricula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbtipoAvion = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbuscarAvion = new System.Windows.Forms.TextBox();
            this.cmbrefrescar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbelimiar = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdaviones)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbtipoAvion);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtmatricula);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtmodelo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtaerolinea);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 172);
            this.groupBox1.TabIndex = 135;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Aviones";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(45, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 19);
            this.label8.TabIndex = 134;
            this.label8.Text = "Matricula";
            // 
            // txtmodelo
            // 
            this.txtmodelo.Location = new System.Drawing.Point(146, 103);
            this.txtmodelo.Name = "txtmodelo";
            this.txtmodelo.Size = new System.Drawing.Size(121, 20);
            this.txtmodelo.TabIndex = 134;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(45, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 19);
            this.label6.TabIndex = 130;
            this.label6.Text = "Modelo";
            // 
            // txtaerolinea
            // 
            this.txtaerolinea.Location = new System.Drawing.Point(146, 67);
            this.txtaerolinea.Name = "txtaerolinea";
            this.txtaerolinea.Size = new System.Drawing.Size(121, 20);
            this.txtaerolinea.TabIndex = 133;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 19);
            this.label5.TabIndex = 129;
            this.label5.Text = "Aerolinea";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtbuscarAvion);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.grdaviones);
            this.groupBox2.Location = new System.Drawing.Point(12, 259);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(576, 194);
            this.groupBox2.TabIndex = 137;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Consulta Aviones";
            // 
            // grdaviones
            // 
            this.grdaviones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdaviones.Location = new System.Drawing.Point(16, 55);
            this.grdaviones.Name = "grdaviones";
            this.grdaviones.Size = new System.Drawing.Size(532, 133);
            this.grdaviones.TabIndex = 128;
            this.grdaviones.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sALIRToolStripMenuItem,
            this.aGREGARTIPOAVIONToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(630, 27);
            this.menuStrip1.TabIndex = 180;
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
            // aGREGARTIPOAVIONToolStripMenuItem
            // 
            this.aGREGARTIPOAVIONToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aGREGARTIPOAVIONToolStripMenuItem.Image = global::Aerolinea.Properties.Resources._1439252944_aeroplane;
            this.aGREGARTIPOAVIONToolStripMenuItem.Name = "aGREGARTIPOAVIONToolStripMenuItem";
            this.aGREGARTIPOAVIONToolStripMenuItem.Size = new System.Drawing.Size(182, 23);
            this.aGREGARTIPOAVIONToolStripMenuItem.Text = "AGREGAR TIPO AVION";
            this.aGREGARTIPOAVIONToolStripMenuItem.Click += new System.EventHandler(this.aGREGARTIPOAVIONToolStripMenuItem_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.Control;
            this.btnEliminar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(380, 154);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 50);
            this.btnEliminar.TabIndex = 178;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificarAvion
            // 
            this.btnModificarAvion.BackColor = System.Drawing.SystemColors.Control;
            this.btnModificarAvion.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarAvion.Image = ((System.Drawing.Image)(resources.GetObject("btnModificarAvion.Image")));
            this.btnModificarAvion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarAvion.Location = new System.Drawing.Point(486, 37);
            this.btnModificarAvion.Name = "btnModificarAvion";
            this.btnModificarAvion.Size = new System.Drawing.Size(100, 50);
            this.btnModificarAvion.TabIndex = 179;
            this.btnModificarAvion.Text = "Modificar";
            this.btnModificarAvion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificarAvion.UseVisualStyleBackColor = false;
            this.btnModificarAvion.Visible = false;
            // 
            // btnBuscarAvion
            // 
            this.btnBuscarAvion.BackColor = System.Drawing.SystemColors.Control;
            this.btnBuscarAvion.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarAvion.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarAvion.Image")));
            this.btnBuscarAvion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarAvion.Location = new System.Drawing.Point(380, 93);
            this.btnBuscarAvion.Name = "btnBuscarAvion";
            this.btnBuscarAvion.Size = new System.Drawing.Size(100, 50);
            this.btnBuscarAvion.TabIndex = 177;
            this.btnBuscarAvion.Text = "Buscar";
            this.btnBuscarAvion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarAvion.UseVisualStyleBackColor = false;
            this.btnBuscarAvion.Click += new System.EventHandler(this.btnBuscarAvion_Click);
            // 
            // btnGuardarAvion
            // 
            this.btnGuardarAvion.BackColor = System.Drawing.SystemColors.Control;
            this.btnGuardarAvion.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarAvion.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarAvion.Image")));
            this.btnGuardarAvion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarAvion.Location = new System.Drawing.Point(380, 37);
            this.btnGuardarAvion.Name = "btnGuardarAvion";
            this.btnGuardarAvion.Size = new System.Drawing.Size(100, 50);
            this.btnGuardarAvion.TabIndex = 176;
            this.btnGuardarAvion.Text = "Guardar";
            this.btnGuardarAvion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarAvion.UseVisualStyleBackColor = false;
            this.btnGuardarAvion.Click += new System.EventHandler(this.btnGuardarAvion_Click_2);
            // 
            // txtmatricula
            // 
            this.txtmatricula.Location = new System.Drawing.Point(148, 139);
            this.txtmatricula.Name = "txtmatricula";
            this.txtmatricula.Size = new System.Drawing.Size(119, 20);
            this.txtmatricula.TabIndex = 135;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 19);
            this.label1.TabIndex = 136;
            this.label1.Text = "Tipo Avion";
            // 
            // cmbtipoAvion
            // 
            this.cmbtipoAvion.FormattingEnabled = true;
            this.cmbtipoAvion.Location = new System.Drawing.Point(146, 24);
            this.cmbtipoAvion.Name = "cmbtipoAvion";
            this.cmbtipoAvion.Size = new System.Drawing.Size(121, 21);
            this.cmbtipoAvion.TabIndex = 132;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 135;
            this.label2.Text = "Buscar Avion";
            // 
            // txtbuscarAvion
            // 
            this.txtbuscarAvion.Location = new System.Drawing.Point(120, 21);
            this.txtbuscarAvion.Name = "txtbuscarAvion";
            this.txtbuscarAvion.Size = new System.Drawing.Size(241, 20);
            this.txtbuscarAvion.TabIndex = 137;
            // 
            // cmbrefrescar
            // 
            this.cmbrefrescar.BackColor = System.Drawing.SystemColors.Control;
            this.cmbrefrescar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbrefrescar.Image = global::Aerolinea.Properties.Resources.refresh;
            this.cmbrefrescar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmbrefrescar.Location = new System.Drawing.Point(486, 93);
            this.cmbrefrescar.Name = "cmbrefrescar";
            this.cmbrefrescar.Size = new System.Drawing.Size(100, 50);
            this.cmbrefrescar.TabIndex = 181;
            this.cmbrefrescar.Text = "Refrescar";
            this.cmbrefrescar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmbrefrescar.UseVisualStyleBackColor = false;
            this.cmbrefrescar.Click += new System.EventHandler(this.cmbrefrescar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 19);
            this.label3.TabIndex = 182;
            this.label3.Text = "Eliminar";
            // 
            // cmbelimiar
            // 
            this.cmbelimiar.FormattingEnabled = true;
            this.cmbelimiar.Location = new System.Drawing.Point(158, 228);
            this.cmbelimiar.Name = "cmbelimiar";
            this.cmbelimiar.Size = new System.Drawing.Size(121, 21);
            this.cmbelimiar.TabIndex = 136;
            // 
            // frmcontrolAvion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(630, 465);
            this.ControlBox = false;
            this.Controls.Add(this.cmbelimiar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbrefrescar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificarAvion);
            this.Controls.Add(this.btnBuscarAvion);
            this.Controls.Add(this.btnGuardarAvion);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmcontrolAvion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de Aviones";
            this.Load += new System.EventHandler(this.frmcontrolAvion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdaviones)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtmodelo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtaerolinea;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView grdaviones;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificarAvion;
        private System.Windows.Forms.Button btnBuscarAvion;
        private System.Windows.Forms.Button btnGuardarAvion;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sALIRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aGREGARTIPOAVIONToolStripMenuItem;
        private System.Windows.Forms.TextBox txtmatricula;
        private System.Windows.Forms.ComboBox cmbtipoAvion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbuscarAvion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmbrefrescar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbelimiar;

    }
}