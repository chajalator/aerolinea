namespace Aerolinea
{
    partial class frmtipoAvion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmtipoAvion));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rEGRESARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabtipoAvion = new System.Windows.Forms.TabControl();
            this.tabpTipoAvion = new System.Windows.Forms.TabPage();
            this.tabpTipoVuelo = new System.Windows.Forms.TabPage();
            this.lblavion = new System.Windows.Forms.Label();
            this.txtavion = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grdavion = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbuscarAvion = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtbuscarVuelo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grdVuelo = new System.Windows.Forms.DataGridView();
            this.txtvuelo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRefrescarTipo = new System.Windows.Forms.Button();
            this.btnBuscarTipo = new System.Windows.Forms.Button();
            this.btnGuardarTipo = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabtipoAvion.SuspendLayout();
            this.tabpTipoAvion.SuspendLayout();
            this.tabpTipoVuelo.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdavion)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdVuelo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rEGRESARToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(612, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rEGRESARToolStripMenuItem
            // 
            this.rEGRESARToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rEGRESARToolStripMenuItem.Image = global::Aerolinea.Properties.Resources.anterior;
            this.rEGRESARToolStripMenuItem.Name = "rEGRESARToolStripMenuItem";
            this.rEGRESARToolStripMenuItem.Size = new System.Drawing.Size(106, 23);
            this.rEGRESARToolStripMenuItem.Text = "REGRESAR";
            this.rEGRESARToolStripMenuItem.Click += new System.EventHandler(this.rEGRESARToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabtipoAvion);
            this.groupBox1.Location = new System.Drawing.Point(15, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 310);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Tipo Avion";
            // 
            // tabtipoAvion
            // 
            this.tabtipoAvion.Controls.Add(this.tabpTipoAvion);
            this.tabtipoAvion.Controls.Add(this.tabpTipoVuelo);
            this.tabtipoAvion.Location = new System.Drawing.Point(24, 28);
            this.tabtipoAvion.Name = "tabtipoAvion";
            this.tabtipoAvion.SelectedIndex = 0;
            this.tabtipoAvion.Size = new System.Drawing.Size(430, 276);
            this.tabtipoAvion.TabIndex = 0;
            // 
            // tabpTipoAvion
            // 
            this.tabpTipoAvion.Controls.Add(this.groupBox2);
            this.tabpTipoAvion.Controls.Add(this.txtavion);
            this.tabpTipoAvion.Controls.Add(this.lblavion);
            this.tabpTipoAvion.Location = new System.Drawing.Point(4, 22);
            this.tabpTipoAvion.Name = "tabpTipoAvion";
            this.tabpTipoAvion.Size = new System.Drawing.Size(422, 250);
            this.tabpTipoAvion.TabIndex = 0;
            this.tabpTipoAvion.Text = "Tipo Avion";
            this.tabpTipoAvion.UseVisualStyleBackColor = true;
            // 
            // tabpTipoVuelo
            // 
            this.tabpTipoVuelo.Controls.Add(this.groupBox3);
            this.tabpTipoVuelo.Controls.Add(this.txtvuelo);
            this.tabpTipoVuelo.Controls.Add(this.label3);
            this.tabpTipoVuelo.Location = new System.Drawing.Point(4, 22);
            this.tabpTipoVuelo.Name = "tabpTipoVuelo";
            this.tabpTipoVuelo.Size = new System.Drawing.Size(422, 250);
            this.tabpTipoVuelo.TabIndex = 0;
            this.tabpTipoVuelo.Text = "Tipo Vuelo";
            this.tabpTipoVuelo.UseVisualStyleBackColor = true;
            // 
            // lblavion
            // 
            this.lblavion.AutoSize = true;
            this.lblavion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblavion.Location = new System.Drawing.Point(17, 17);
            this.lblavion.Name = "lblavion";
            this.lblavion.Size = new System.Drawing.Size(45, 19);
            this.lblavion.TabIndex = 0;
            this.lblavion.Text = "Avion";
            // 
            // txtavion
            // 
            this.txtavion.Location = new System.Drawing.Point(69, 16);
            this.txtavion.Name = "txtavion";
            this.txtavion.Size = new System.Drawing.Size(166, 20);
            this.txtavion.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtbuscarAvion);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.grdavion);
            this.groupBox2.Location = new System.Drawing.Point(21, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(371, 178);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Consulta Tipo Avion";
            // 
            // grdavion
            // 
            this.grdavion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdavion.Location = new System.Drawing.Point(36, 70);
            this.grdavion.Name = "grdavion";
            this.grdavion.Size = new System.Drawing.Size(269, 94);
            this.grdavion.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar Avion";
            // 
            // txtbuscarAvion
            // 
            this.txtbuscarAvion.Location = new System.Drawing.Point(120, 28);
            this.txtbuscarAvion.Name = "txtbuscarAvion";
            this.txtbuscarAvion.Size = new System.Drawing.Size(197, 20);
            this.txtbuscarAvion.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtbuscarVuelo);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.grdVuelo);
            this.groupBox3.Location = new System.Drawing.Point(21, 54);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(371, 178);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Consulta Tipo Vuelo";
            // 
            // txtbuscarVuelo
            // 
            this.txtbuscarVuelo.Location = new System.Drawing.Point(120, 28);
            this.txtbuscarVuelo.Name = "txtbuscarVuelo";
            this.txtbuscarVuelo.Size = new System.Drawing.Size(197, 20);
            this.txtbuscarVuelo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Buscar Vuelo";
            // 
            // grdVuelo
            // 
            this.grdVuelo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdVuelo.Location = new System.Drawing.Point(36, 70);
            this.grdVuelo.Name = "grdVuelo";
            this.grdVuelo.Size = new System.Drawing.Size(269, 94);
            this.grdVuelo.TabIndex = 0;
            // 
            // txtvuelo
            // 
            this.txtvuelo.Location = new System.Drawing.Point(69, 16);
            this.txtvuelo.Name = "txtvuelo";
            this.txtvuelo.Size = new System.Drawing.Size(166, 20);
            this.txtvuelo.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Vuelo";
            // 
            // btnRefrescarTipo
            // 
            this.btnRefrescarTipo.BackColor = System.Drawing.SystemColors.Control;
            this.btnRefrescarTipo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefrescarTipo.Image = global::Aerolinea.Properties.Resources.refresh;
            this.btnRefrescarTipo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefrescarTipo.Location = new System.Drawing.Point(500, 171);
            this.btnRefrescarTipo.Name = "btnRefrescarTipo";
            this.btnRefrescarTipo.Size = new System.Drawing.Size(100, 50);
            this.btnRefrescarTipo.TabIndex = 187;
            this.btnRefrescarTipo.Text = "Refrescar";
            this.btnRefrescarTipo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefrescarTipo.UseVisualStyleBackColor = false;
            this.btnRefrescarTipo.Click += new System.EventHandler(this.btnRefrescarTipo_Click);
            // 
            // btnBuscarTipo
            // 
            this.btnBuscarTipo.BackColor = System.Drawing.SystemColors.Control;
            this.btnBuscarTipo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarTipo.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarTipo.Image")));
            this.btnBuscarTipo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarTipo.Location = new System.Drawing.Point(500, 115);
            this.btnBuscarTipo.Name = "btnBuscarTipo";
            this.btnBuscarTipo.Size = new System.Drawing.Size(100, 50);
            this.btnBuscarTipo.TabIndex = 186;
            this.btnBuscarTipo.Text = "Buscar";
            this.btnBuscarTipo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarTipo.UseVisualStyleBackColor = false;
            this.btnBuscarTipo.Click += new System.EventHandler(this.btnBuscarTipo_Click);
            // 
            // btnGuardarTipo
            // 
            this.btnGuardarTipo.BackColor = System.Drawing.SystemColors.Control;
            this.btnGuardarTipo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarTipo.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarTipo.Image")));
            this.btnGuardarTipo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarTipo.Location = new System.Drawing.Point(500, 59);
            this.btnGuardarTipo.Name = "btnGuardarTipo";
            this.btnGuardarTipo.Size = new System.Drawing.Size(100, 50);
            this.btnGuardarTipo.TabIndex = 185;
            this.btnGuardarTipo.Text = "Guardar";
            this.btnGuardarTipo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarTipo.UseVisualStyleBackColor = false;
            this.btnGuardarTipo.Click += new System.EventHandler(this.btnGuardarTipo_Click);
            // 
            // frmtipoAvion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(612, 369);
            this.ControlBox = false;
            this.Controls.Add(this.btnRefrescarTipo);
            this.Controls.Add(this.btnBuscarTipo);
            this.Controls.Add(this.btnGuardarTipo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(628, 408);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(628, 408);
            this.Name = "frmtipoAvion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipo Avion";
            this.Load += new System.EventHandler(this.frmtipoAvion_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabtipoAvion.ResumeLayout(false);
            this.tabpTipoAvion.ResumeLayout(false);
            this.tabpTipoAvion.PerformLayout();
            this.tabpTipoVuelo.ResumeLayout(false);
            this.tabpTipoVuelo.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdavion)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdVuelo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rEGRESARToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabtipoAvion;
        private System.Windows.Forms.TabPage tabpTipoAvion;
        private System.Windows.Forms.TabPage tabpTipoVuelo;
        private System.Windows.Forms.Label lblavion;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtbuscarAvion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdavion;
        private System.Windows.Forms.TextBox txtavion;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtbuscarVuelo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grdVuelo;
        private System.Windows.Forms.TextBox txtvuelo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRefrescarTipo;
        private System.Windows.Forms.Button btnBuscarTipo;
        private System.Windows.Forms.Button btnGuardarTipo;
    }
}