namespace Aerolinea
{
    partial class frmcontrolVuelo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcontrolVuelo));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aGREGARLOCALIZACIÓNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sALIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbaeropuerto = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmborigen = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbembarque = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbterminal = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbtipoVuelo = new System.Windows.Forms.ComboBox();
            this.cmbdestino = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mtxhoraLlegada = new System.Windows.Forms.MaskedTextBox();
            this.mtxhoraDespegue = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.grdVuelo = new System.Windows.Forms.DataGridView();
            this.btnEliminarVuelo = new System.Windows.Forms.Button();
            this.btnModificarVuelo = new System.Windows.Forms.Button();
            this.btnBuscarVuelo = new System.Windows.Forms.Button();
            this.btnGuardarVuelo = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtFechaVuelo = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbaerolinea = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdVuelo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aGREGARLOCALIZACIÓNToolStripMenuItem,
            this.sALIRToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(723, 27);
            this.menuStrip1.TabIndex = 172;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aGREGARLOCALIZACIÓNToolStripMenuItem
            // 
            this.aGREGARLOCALIZACIÓNToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aGREGARLOCALIZACIÓNToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aGREGARLOCALIZACIÓNToolStripMenuItem.Image")));
            this.aGREGARLOCALIZACIÓNToolStripMenuItem.Name = "aGREGARLOCALIZACIÓNToolStripMenuItem";
            this.aGREGARLOCALIZACIÓNToolStripMenuItem.Size = new System.Drawing.Size(203, 23);
            this.aGREGARLOCALIZACIÓNToolStripMenuItem.Text = "AGREGAR LOCALIZACIÓN";
            this.aGREGARLOCALIZACIÓNToolStripMenuItem.Click += new System.EventHandler(this.aGREGARLOCALIZACIÓNToolStripMenuItem_Click);
            // 
            // sALIRToolStripMenuItem
            // 
            this.sALIRToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.sALIRToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sALIRToolStripMenuItem.Image = global::Aerolinea.Properties.Resources.salir1;
            this.sALIRToolStripMenuItem.Name = "sALIRToolStripMenuItem";
            this.sALIRToolStripMenuItem.Size = new System.Drawing.Size(73, 23);
            this.sALIRToolStripMenuItem.Text = "SALIR";
            this.sALIRToolStripMenuItem.Click += new System.EventHandler(this.sALIRToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbaeropuerto);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmborigen);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbembarque);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbterminal);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbtipoVuelo);
            this.groupBox1.Controls.Add(this.cmbdestino);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.mtxhoraLlegada);
            this.groupBox1.Controls.Add(this.mtxhoraDespegue);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtBuscar);
            this.groupBox1.Controls.Add(this.grdVuelo);
            this.groupBox1.Controls.Add(this.btnEliminarVuelo);
            this.groupBox1.Controls.Add(this.btnModificarVuelo);
            this.groupBox1.Controls.Add(this.btnBuscarVuelo);
            this.groupBox1.Controls.Add(this.btnGuardarVuelo);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.dtFechaVuelo);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cmbaerolinea);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(684, 386);
            this.groupBox1.TabIndex = 173;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Asignar Vuelo";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cmbaeropuerto
            // 
            this.cmbaeropuerto.FormattingEnabled = true;
            this.cmbaeropuerto.Location = new System.Drawing.Point(363, 185);
            this.cmbaeropuerto.Name = "cmbaeropuerto";
            this.cmbaeropuerto.Size = new System.Drawing.Size(121, 21);
            this.cmbaeropuerto.TabIndex = 168;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(275, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 19);
            this.label6.TabIndex = 167;
            this.label6.Text = "Aeropuerto";
            // 
            // cmborigen
            // 
            this.cmborigen.FormattingEnabled = true;
            this.cmborigen.Location = new System.Drawing.Point(133, 155);
            this.cmborigen.Name = "cmborigen";
            this.cmborigen.Size = new System.Drawing.Size(121, 21);
            this.cmborigen.TabIndex = 166;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 19);
            this.label5.TabIndex = 165;
            this.label5.Text = "Origen:";
            // 
            // cmbembarque
            // 
            this.cmbembarque.FormattingEnabled = true;
            this.cmbembarque.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbembarque.Location = new System.Drawing.Point(290, 101);
            this.cmbembarque.Name = "cmbembarque";
            this.cmbembarque.Size = new System.Drawing.Size(43, 21);
            this.cmbembarque.TabIndex = 164;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(201, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 19);
            this.label4.TabIndex = 163;
            this.label4.Text = "Embarque:";
            // 
            // cmbterminal
            // 
            this.cmbterminal.FormattingEnabled = true;
            this.cmbterminal.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbterminal.Location = new System.Drawing.Point(133, 101);
            this.cmbterminal.Name = "cmbterminal";
            this.cmbterminal.Size = new System.Drawing.Size(43, 21);
            this.cmbterminal.TabIndex = 162;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 161;
            this.label3.Text = "Terminal:";
            // 
            // cmbtipoVuelo
            // 
            this.cmbtipoVuelo.FormattingEnabled = true;
            this.cmbtipoVuelo.Location = new System.Drawing.Point(351, 128);
            this.cmbtipoVuelo.Name = "cmbtipoVuelo";
            this.cmbtipoVuelo.Size = new System.Drawing.Size(121, 21);
            this.cmbtipoVuelo.TabIndex = 160;
            // 
            // cmbdestino
            // 
            this.cmbdestino.FormattingEnabled = true;
            this.cmbdestino.Location = new System.Drawing.Point(133, 183);
            this.cmbdestino.Name = "cmbdestino";
            this.cmbdestino.Size = new System.Drawing.Size(121, 21);
            this.cmbdestino.TabIndex = 159;
            this.cmbdestino.SelectedIndexChanged += new System.EventHandler(this.cmbdestino_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 158;
            this.label2.Text = "Aerolinea:";
            // 
            // mtxhoraLlegada
            // 
            this.mtxhoraLlegada.Location = new System.Drawing.Point(363, 72);
            this.mtxhoraLlegada.Mask = "0000/00/00 00:00";
            this.mtxhoraLlegada.Name = "mtxhoraLlegada";
            this.mtxhoraLlegada.Size = new System.Drawing.Size(100, 20);
            this.mtxhoraLlegada.TabIndex = 156;
            // 
            // mtxhoraDespegue
            // 
            this.mtxhoraDespegue.Location = new System.Drawing.Point(133, 72);
            this.mtxhoraDespegue.Mask = "0000/00/00 00:00";
            this.mtxhoraDespegue.Name = "mtxhoraDespegue";
            this.mtxhoraDespegue.Size = new System.Drawing.Size(100, 20);
            this.mtxhoraDespegue.TabIndex = 155;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(35, 226);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 19);
            this.label12.TabIndex = 154;
            this.label12.Text = "Busca:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(108, 227);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(306, 20);
            this.txtBuscar.TabIndex = 141;
            // 
            // grdVuelo
            // 
            this.grdVuelo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdVuelo.Location = new System.Drawing.Point(16, 257);
            this.grdVuelo.Name = "grdVuelo";
            this.grdVuelo.Size = new System.Drawing.Size(649, 123);
            this.grdVuelo.TabIndex = 153;
            // 
            // btnEliminarVuelo
            // 
            this.btnEliminarVuelo.BackColor = System.Drawing.SystemColors.Control;
            this.btnEliminarVuelo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarVuelo.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarVuelo.Image")));
            this.btnEliminarVuelo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarVuelo.Location = new System.Drawing.Point(558, 182);
            this.btnEliminarVuelo.Name = "btnEliminarVuelo";
            this.btnEliminarVuelo.Size = new System.Drawing.Size(100, 50);
            this.btnEliminarVuelo.TabIndex = 145;
            this.btnEliminarVuelo.Text = "Eliminar";
            this.btnEliminarVuelo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarVuelo.UseVisualStyleBackColor = false;
            this.btnEliminarVuelo.Click += new System.EventHandler(this.btnEliminarVuelo_Click);
            // 
            // btnModificarVuelo
            // 
            this.btnModificarVuelo.BackColor = System.Drawing.SystemColors.Control;
            this.btnModificarVuelo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarVuelo.Image = ((System.Drawing.Image)(resources.GetObject("btnModificarVuelo.Image")));
            this.btnModificarVuelo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarVuelo.Location = new System.Drawing.Point(558, 126);
            this.btnModificarVuelo.Name = "btnModificarVuelo";
            this.btnModificarVuelo.Size = new System.Drawing.Size(100, 50);
            this.btnModificarVuelo.TabIndex = 144;
            this.btnModificarVuelo.Text = "Modificar";
            this.btnModificarVuelo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificarVuelo.UseVisualStyleBackColor = false;
            this.btnModificarVuelo.Click += new System.EventHandler(this.btnModificarVuelo_Click);
            // 
            // btnBuscarVuelo
            // 
            this.btnBuscarVuelo.BackColor = System.Drawing.SystemColors.Control;
            this.btnBuscarVuelo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarVuelo.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarVuelo.Image")));
            this.btnBuscarVuelo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarVuelo.Location = new System.Drawing.Point(558, 72);
            this.btnBuscarVuelo.Name = "btnBuscarVuelo";
            this.btnBuscarVuelo.Size = new System.Drawing.Size(100, 50);
            this.btnBuscarVuelo.TabIndex = 143;
            this.btnBuscarVuelo.Text = "Buscar";
            this.btnBuscarVuelo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarVuelo.UseVisualStyleBackColor = false;
            this.btnBuscarVuelo.Click += new System.EventHandler(this.btnBuscarVuelo_Click_1);
            // 
            // btnGuardarVuelo
            // 
            this.btnGuardarVuelo.BackColor = System.Drawing.SystemColors.Control;
            this.btnGuardarVuelo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarVuelo.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarVuelo.Image")));
            this.btnGuardarVuelo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarVuelo.Location = new System.Drawing.Point(558, 16);
            this.btnGuardarVuelo.Name = "btnGuardarVuelo";
            this.btnGuardarVuelo.Size = new System.Drawing.Size(100, 50);
            this.btnGuardarVuelo.TabIndex = 142;
            this.btnGuardarVuelo.Text = "Guardar";
            this.btnGuardarVuelo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarVuelo.UseVisualStyleBackColor = false;
            this.btnGuardarVuelo.Click += new System.EventHandler(this.btnGuardarVuelo_Click_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(262, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 19);
            this.label11.TabIndex = 152;
            this.label11.Text = "Hora Llegada:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 19);
            this.label10.TabIndex = 151;
            this.label10.Text = "Hora Despegue:";
            // 
            // dtFechaVuelo
            // 
            this.dtFechaVuelo.CustomFormat = "yyyy-MM-dd";
            this.dtFechaVuelo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFechaVuelo.Location = new System.Drawing.Point(133, 46);
            this.dtFechaVuelo.Name = "dtFechaVuelo";
            this.dtFechaVuelo.Size = new System.Drawing.Size(200, 20);
            this.dtFechaVuelo.TabIndex = 140;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 19);
            this.label9.TabIndex = 150;
            this.label9.Text = "Fecha Del Vuelo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(263, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 19);
            this.label8.TabIndex = 149;
            this.label8.Text = "Tipo Vuelo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 19);
            this.label7.TabIndex = 148;
            this.label7.Text = "Destino:";
            // 
            // cmbaerolinea
            // 
            this.cmbaerolinea.FormattingEnabled = true;
            this.cmbaerolinea.Location = new System.Drawing.Point(133, 128);
            this.cmbaerolinea.Name = "cmbaerolinea";
            this.cmbaerolinea.Size = new System.Drawing.Size(121, 21);
            this.cmbaerolinea.TabIndex = 139;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(230, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 23);
            this.label1.TabIndex = 146;
            this.label1.Text = "Asignacion de Vuelos";
            // 
            // frmcontrolVuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(723, 438);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(739, 477);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(739, 477);
            this.Name = "frmcontrolVuelo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control Vuelo";
            this.Load += new System.EventHandler(this.frmcontrolVuelo_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdVuelo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbtipoVuelo;
        private System.Windows.Forms.ComboBox cmbdestino;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtxhoraLlegada;
        private System.Windows.Forms.MaskedTextBox mtxhoraDespegue;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView grdVuelo;
        private System.Windows.Forms.Button btnEliminarVuelo;
        private System.Windows.Forms.Button btnModificarVuelo;
        private System.Windows.Forms.Button btnBuscarVuelo;
        private System.Windows.Forms.Button btnGuardarVuelo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtFechaVuelo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbaerolinea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem aGREGARLOCALIZACIÓNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sALIRToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmbterminal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbaeropuerto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmborigen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbembarque;
        private System.Windows.Forms.Label label4;
    }
}