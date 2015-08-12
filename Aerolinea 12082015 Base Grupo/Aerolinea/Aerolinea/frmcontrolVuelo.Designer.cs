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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbOrigen = new System.Windows.Forms.ComboBox();
            this.cmbDestino = new System.Windows.Forms.ComboBox();
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
            this.cmbCodAvion = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sALIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbOrigen);
            this.groupBox1.Controls.Add(this.cmbDestino);
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
            this.groupBox1.Controls.Add(this.cmbCodAvion);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(699, 386);
            this.groupBox1.TabIndex = 173;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Asignar Vuelo";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cmbOrigen
            // 
            this.cmbOrigen.FormattingEnabled = true;
            this.cmbOrigen.Location = new System.Drawing.Point(133, 81);
            this.cmbOrigen.Name = "cmbOrigen";
            this.cmbOrigen.Size = new System.Drawing.Size(121, 21);
            this.cmbOrigen.TabIndex = 160;
            // 
            // cmbDestino
            // 
            this.cmbDestino.FormattingEnabled = true;
            this.cmbDestino.Location = new System.Drawing.Point(363, 80);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(121, 21);
            this.cmbDestino.TabIndex = 159;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 19);
            this.label2.TabIndex = 158;
            this.label2.Text = "Código Avión:";
            // 
            // mtxhoraLlegada
            // 
            this.mtxhoraLlegada.Location = new System.Drawing.Point(363, 142);
            this.mtxhoraLlegada.Mask = "0000/00/00 00:00";
            this.mtxhoraLlegada.Name = "mtxhoraLlegada";
            this.mtxhoraLlegada.Size = new System.Drawing.Size(100, 20);
            this.mtxhoraLlegada.TabIndex = 156;
            // 
            // mtxhoraDespegue
            // 
            this.mtxhoraDespegue.Location = new System.Drawing.Point(133, 142);
            this.mtxhoraDespegue.Mask = "0000/00/00 00:00";
            this.mtxhoraDespegue.Name = "mtxhoraDespegue";
            this.mtxhoraDespegue.Size = new System.Drawing.Size(100, 20);
            this.mtxhoraDespegue.TabIndex = 155;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(36, 211);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 19);
            this.label12.TabIndex = 154;
            this.label12.Text = "Busca:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(109, 212);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(306, 20);
            this.txtBuscar.TabIndex = 141;
            // 
            // grdVuelo
            // 
            this.grdVuelo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdVuelo.Location = new System.Drawing.Point(35, 243);
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
            this.label11.Location = new System.Drawing.Point(262, 143);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 19);
            this.label11.TabIndex = 152;
            this.label11.Text = "Hora Llegada:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 141);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 19);
            this.label10.TabIndex = 151;
            this.label10.Text = "Hora Despegue:";
            // 
            // dtFechaVuelo
            // 
            this.dtFechaVuelo.CustomFormat = "yyyy-MM-dd";
            this.dtFechaVuelo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFechaVuelo.Location = new System.Drawing.Point(133, 108);
            this.dtFechaVuelo.Name = "dtFechaVuelo";
            this.dtFechaVuelo.Size = new System.Drawing.Size(200, 20);
            this.dtFechaVuelo.TabIndex = 140;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 19);
            this.label9.TabIndex = 150;
            this.label9.Text = "Fecha Del Vuelo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(33, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 19);
            this.label8.TabIndex = 149;
            this.label8.Text = "Orígen:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(286, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 19);
            this.label7.TabIndex = 148;
            this.label7.Text = "Destino:";
            // 
            // cmbCodAvion
            // 
            this.cmbCodAvion.FormattingEnabled = true;
            this.cmbCodAvion.Location = new System.Drawing.Point(133, 54);
            this.cmbCodAvion.Name = "cmbCodAvion";
            this.cmbCodAvion.Size = new System.Drawing.Size(121, 21);
            this.cmbCodAvion.TabIndex = 139;
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
        private System.Windows.Forms.ComboBox cmbOrigen;
        private System.Windows.Forms.ComboBox cmbDestino;
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
        private System.Windows.Forms.ComboBox cmbCodAvion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem aGREGARLOCALIZACIÓNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sALIRToolStripMenuItem;
    }
}