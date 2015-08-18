namespace Aerolinea
{
    partial class frmrealizacionPago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmrealizacionPago));
            this.txtTarjeta = new System.Windows.Forms.TextBox();
            this.txtMontoEf = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbTipoPago = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grdReservacion = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPagar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.cmbCodCliente = new System.Windows.Forms.ComboBox();
            this.cmbNoReservacion = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rEGRESARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sALIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.grdReservacion)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTarjeta
            // 
            this.txtTarjeta.Location = new System.Drawing.Point(330, 399);
            this.txtTarjeta.Name = "txtTarjeta";
            this.txtTarjeta.Size = new System.Drawing.Size(100, 20);
            this.txtTarjeta.TabIndex = 26;
            // 
            // txtMontoEf
            // 
            this.txtMontoEf.Location = new System.Drawing.Point(330, 355);
            this.txtMontoEf.Name = "txtMontoEf";
            this.txtMontoEf.Size = new System.Drawing.Size(100, 20);
            this.txtMontoEf.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(204, 400);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 19);
            this.label6.TabIndex = 24;
            this.label6.Text = "No. Tarjeta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(204, 356);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 19);
            this.label5.TabIndex = 23;
            this.label5.Text = "Monto Efectivo";
            // 
            // cmbTipoPago
            // 
            this.cmbTipoPago.FormattingEnabled = true;
            this.cmbTipoPago.Location = new System.Drawing.Point(53, 390);
            this.cmbTipoPago.Name = "cmbTipoPago";
            this.cmbTipoPago.Size = new System.Drawing.Size(93, 21);
            this.cmbTipoPago.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 19);
            this.label4.TabIndex = 21;
            this.label4.Text = "Tipo de Pago";
            // 
            // grdReservacion
            // 
            this.grdReservacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdReservacion.Location = new System.Drawing.Point(53, 187);
            this.grdReservacion.Name = "grdReservacion";
            this.grdReservacion.Size = new System.Drawing.Size(467, 146);
            this.grdReservacion.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "Ingrese No. Reservacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "Ingrese Codigo Cliente";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(189, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "Realizacion de Pagos de Reservaciones";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnPagar
            // 
            this.btnPagar.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnPagar.Image = ((System.Drawing.Image)(resources.GetObject("btnPagar.Image")));
            this.btnPagar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPagar.Location = new System.Drawing.Point(528, 369);
            this.btnPagar.MaximumSize = new System.Drawing.Size(110, 50);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(110, 50);
            this.btnPagar.TabIndex = 27;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPagar.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnConsultar.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultar.Image")));
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.Location = new System.Drawing.Point(410, 101);
            this.btnConsultar.MaximumSize = new System.Drawing.Size(110, 50);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(110, 50);
            this.btnConsultar.TabIndex = 19;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // cmbCodCliente
            // 
            this.cmbCodCliente.FormattingEnabled = true;
            this.cmbCodCliente.Location = new System.Drawing.Point(219, 93);
            this.cmbCodCliente.Name = "cmbCodCliente";
            this.cmbCodCliente.Size = new System.Drawing.Size(158, 21);
            this.cmbCodCliente.TabIndex = 30;
            // 
            // cmbNoReservacion
            // 
            this.cmbNoReservacion.FormattingEnabled = true;
            this.cmbNoReservacion.Location = new System.Drawing.Point(221, 139);
            this.cmbNoReservacion.Name = "cmbNoReservacion";
            this.cmbNoReservacion.Size = new System.Drawing.Size(156, 21);
            this.cmbNoReservacion.TabIndex = 31;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rEGRESARToolStripMenuItem,
            this.sALIRToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(651, 27);
            this.menuStrip1.TabIndex = 172;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rEGRESARToolStripMenuItem
            // 
            this.rEGRESARToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("rEGRESARToolStripMenuItem.Image")));
            this.rEGRESARToolStripMenuItem.Name = "rEGRESARToolStripMenuItem";
            this.rEGRESARToolStripMenuItem.Size = new System.Drawing.Size(106, 23);
            this.rEGRESARToolStripMenuItem.Text = "REGRESAR";
            // 
            // sALIRToolStripMenuItem
            // 
            this.sALIRToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.sALIRToolStripMenuItem.Image = global::Aerolinea.Properties.Resources.salir;
            this.sALIRToolStripMenuItem.Name = "sALIRToolStripMenuItem";
            this.sALIRToolStripMenuItem.Size = new System.Drawing.Size(73, 23);
            this.sALIRToolStripMenuItem.Text = "SALIR";
            this.sALIRToolStripMenuItem.Click += new System.EventHandler(this.sALIRToolStripMenuItem_Click);
            // 
            // frmrealizacionPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(651, 447);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.cmbNoReservacion);
            this.Controls.Add(this.cmbCodCliente);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.txtTarjeta);
            this.Controls.Add(this.txtMontoEf);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbTipoPago);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grdReservacion);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(667, 486);
            this.MinimumSize = new System.Drawing.Size(667, 486);
            this.Name = "frmrealizacionPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Realización Pago";
            ((System.ComponentModel.ISupportInitialize)(this.grdReservacion)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.TextBox txtTarjeta;
        private System.Windows.Forms.TextBox txtMontoEf;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbTipoPago;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView grdReservacion;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCodCliente;
        private System.Windows.Forms.ComboBox cmbNoReservacion;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rEGRESARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sALIRToolStripMenuItem;
    }
}