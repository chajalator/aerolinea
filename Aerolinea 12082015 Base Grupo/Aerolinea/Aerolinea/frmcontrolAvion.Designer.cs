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
            this.txtdescripcionAvion = new System.Windows.Forms.TextBox();
            this.txtNoFilas = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNoAsientos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grdaviones = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificarAvion = new System.Windows.Forms.Button();
            this.btnBuscarAvion = new System.Windows.Forms.Button();
            this.btnGuardarAvion = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sALIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdaviones)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtdescripcionAvion);
            this.groupBox1.Controls.Add(this.txtNoFilas);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtNoAsientos);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 213);
            this.groupBox1.TabIndex = 174;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Aviones";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 19);
            this.label8.TabIndex = 134;
            this.label8.Text = "Descripción:";
            // 
            // txtdescripcionAvion
            // 
            this.txtdescripcionAvion.Location = new System.Drawing.Point(120, 54);
            this.txtdescripcionAvion.Multiline = true;
            this.txtdescripcionAvion.Name = "txtdescripcionAvion";
            this.txtdescripcionAvion.Size = new System.Drawing.Size(323, 137);
            this.txtdescripcionAvion.TabIndex = 125;
            // 
            // txtNoFilas
            // 
            this.txtNoFilas.Location = new System.Drawing.Point(322, 28);
            this.txtNoFilas.Name = "txtNoFilas";
            this.txtNoFilas.Size = new System.Drawing.Size(121, 20);
            this.txtNoFilas.TabIndex = 124;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(247, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 19);
            this.label6.TabIndex = 130;
            this.label6.Text = "No. Filas:";
            // 
            // txtNoAsientos
            // 
            this.txtNoAsientos.Location = new System.Drawing.Point(120, 29);
            this.txtNoAsientos.Name = "txtNoAsientos";
            this.txtNoAsientos.Size = new System.Drawing.Size(121, 20);
            this.txtNoAsientos.TabIndex = 123;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 19);
            this.label5.TabIndex = 129;
            this.label5.Text = "No. Asientos:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grdaviones);
            this.groupBox2.Location = new System.Drawing.Point(12, 261);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(621, 112);
            this.groupBox2.TabIndex = 175;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Consulta Aviones";
            // 
            // grdaviones
            // 
            this.grdaviones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdaviones.Location = new System.Drawing.Point(95, 19);
            this.grdaviones.Name = "grdaviones";
            this.grdaviones.Size = new System.Drawing.Size(413, 76);
            this.grdaviones.TabIndex = 128;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.Control;
            this.btnEliminar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(507, 203);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 50);
            this.btnEliminar.TabIndex = 179;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Visible = false;
            // 
            // btnModificarAvion
            // 
            this.btnModificarAvion.BackColor = System.Drawing.SystemColors.Control;
            this.btnModificarAvion.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarAvion.Image = ((System.Drawing.Image)(resources.GetObject("btnModificarAvion.Image")));
            this.btnModificarAvion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarAvion.Location = new System.Drawing.Point(507, 147);
            this.btnModificarAvion.Name = "btnModificarAvion";
            this.btnModificarAvion.Size = new System.Drawing.Size(100, 50);
            this.btnModificarAvion.TabIndex = 178;
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
            this.btnBuscarAvion.Location = new System.Drawing.Point(507, 93);
            this.btnBuscarAvion.Name = "btnBuscarAvion";
            this.btnBuscarAvion.Size = new System.Drawing.Size(100, 50);
            this.btnBuscarAvion.TabIndex = 177;
            this.btnBuscarAvion.Text = "Buscar";
            this.btnBuscarAvion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarAvion.UseVisualStyleBackColor = false;
            this.btnBuscarAvion.Visible = false;
            // 
            // btnGuardarAvion
            // 
            this.btnGuardarAvion.BackColor = System.Drawing.SystemColors.Control;
            this.btnGuardarAvion.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarAvion.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarAvion.Image")));
            this.btnGuardarAvion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarAvion.Location = new System.Drawing.Point(507, 37);
            this.btnGuardarAvion.Name = "btnGuardarAvion";
            this.btnGuardarAvion.Size = new System.Drawing.Size(100, 50);
            this.btnGuardarAvion.TabIndex = 176;
            this.btnGuardarAvion.Text = "Guardar";
            this.btnGuardarAvion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarAvion.UseVisualStyleBackColor = false;
            this.btnGuardarAvion.Click += new System.EventHandler(this.btnGuardarAvion_Click_2);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sALIRToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(645, 27);
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
            // frmcontrolAvion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(645, 385);
            this.ControlBox = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.grdaviones)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtdescripcionAvion;
        private System.Windows.Forms.TextBox txtNoFilas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNoAsientos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView grdaviones;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificarAvion;
        private System.Windows.Forms.Button btnBuscarAvion;
        private System.Windows.Forms.Button btnGuardarAvion;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sALIRToolStripMenuItem;

    }
}