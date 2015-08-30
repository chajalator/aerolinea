namespace Aerolinea
{
    partial class frmreporteReservacion
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
            this.label8 = new System.Windows.Forms.Label();
            this.gbCodigo = new System.Windows.Forms.GroupBox();
            this.dgwReporte = new System.Windows.Forms.DataGridView();
            this.gbCodigo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwReporte)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(241, 32);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(177, 23);
            this.label8.TabIndex = 28;
            this.label8.Text = "Boletos mas vendidos";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gbCodigo
            // 
            this.gbCodigo.Controls.Add(this.dgwReporte);
            this.gbCodigo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCodigo.Location = new System.Drawing.Point(30, 86);
            this.gbCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.gbCodigo.Name = "gbCodigo";
            this.gbCodigo.Padding = new System.Windows.Forms.Padding(4);
            this.gbCodigo.Size = new System.Drawing.Size(509, 176);
            this.gbCodigo.TabIndex = 29;
            this.gbCodigo.TabStop = false;
            this.gbCodigo.Text = "Boleteria";
            this.gbCodigo.Enter += new System.EventHandler(this.gbCodigo_Enter);
            // 
            // dgwReporte
            // 
            this.dgwReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwReporte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwReporte.Location = new System.Drawing.Point(4, 24);
            this.dgwReporte.Margin = new System.Windows.Forms.Padding(4);
            this.dgwReporte.Name = "dgwReporte";
            this.dgwReporte.Size = new System.Drawing.Size(501, 148);
            this.dgwReporte.TabIndex = 30;
            this.dgwReporte.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // frmreporteReservacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 344);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.gbCodigo);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmreporteReservacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmreporteReservacion";
            this.Load += new System.EventHandler(this.frmreporteReservacion_Load);
            this.gbCodigo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwReporte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gbCodigo;
        private System.Windows.Forms.DataGridView dgwReporte;
    }
}