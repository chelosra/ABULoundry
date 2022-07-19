namespace Loundry
{
    partial class frmFtp
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
            this.components = new System.ComponentModel.Container();
            this.txtFtpCarpeta = new System.Windows.Forms.TextBox();
            this.lstArchivos = new System.Windows.Forms.ListBox();
            this.btnCreaDirectorios = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSubeReportes = new System.Windows.Forms.Button();
            this.btnBajaReportes = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFtpCarpeta
            // 
            this.txtFtpCarpeta.Location = new System.Drawing.Point(6, 94);
            this.txtFtpCarpeta.Name = "txtFtpCarpeta";
            this.txtFtpCarpeta.Size = new System.Drawing.Size(307, 20);
            this.txtFtpCarpeta.TabIndex = 1;
            // 
            // lstArchivos
            // 
            this.lstArchivos.FormattingEnabled = true;
            this.lstArchivos.Items.AddRange(new object[] {
            "Listprecio.rdlc",
            "Ncredito.rdlc",
            "Factura.rdlc",
            "conf.xml"});
            this.lstArchivos.Location = new System.Drawing.Point(6, 19);
            this.lstArchivos.Name = "lstArchivos";
            this.lstArchivos.Size = new System.Drawing.Size(307, 95);
            this.lstArchivos.TabIndex = 4;
            // 
            // btnCreaDirectorios
            // 
            this.btnCreaDirectorios.Location = new System.Drawing.Point(82, 12);
            this.btnCreaDirectorios.Name = "btnCreaDirectorios";
            this.btnCreaDirectorios.Size = new System.Drawing.Size(200, 23);
            this.btnCreaDirectorios.TabIndex = 5;
            this.btnCreaDirectorios.Text = "Crea Directorios";
            this.toolTip1.SetToolTip(this.btnCreaDirectorios, "Crea las carpetas del sistema");
            this.btnCreaDirectorios.UseVisualStyleBackColor = true;
            this.btnCreaDirectorios.Visible = false;
            this.btnCreaDirectorios.Click += new System.EventHandler(this.btnCreaDirectorios_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstArchivos);
            this.groupBox1.Controls.Add(this.btnSubeReportes);
            this.groupBox1.Controls.Add(this.btnBajaReportes);
            this.groupBox1.Controls.Add(this.txtFtpCarpeta);
            this.groupBox1.Location = new System.Drawing.Point(5, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 125);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ftp";
            // 
            // btnSubeReportes
            // 
            this.btnSubeReportes.Image = global::Loundry.Properties.Resources.list_greenarw;
            this.btnSubeReportes.Location = new System.Drawing.Point(319, 19);
            this.btnSubeReportes.Name = "btnSubeReportes";
            this.btnSubeReportes.Size = new System.Drawing.Size(30, 23);
            this.btnSubeReportes.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnSubeReportes, "Sube archivos al Servidor");
            this.btnSubeReportes.UseVisualStyleBackColor = true;
            this.btnSubeReportes.Visible = false;
            this.btnSubeReportes.Click += new System.EventHandler(this.btnSubeReportes_Click);
            // 
            // btnBajaReportes
            // 
            this.btnBajaReportes.Image = global::Loundry.Properties.Resources.link_more;
            this.btnBajaReportes.Location = new System.Drawing.Point(315, 91);
            this.btnBajaReportes.Name = "btnBajaReportes";
            this.btnBajaReportes.Size = new System.Drawing.Size(34, 23);
            this.btnBajaReportes.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnBajaReportes, "Baja los archivos del servidor");
            this.btnBajaReportes.UseVisualStyleBackColor = true;
            this.btnBajaReportes.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // frmFtp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 176);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCreaDirectorios);
            this.Name = "frmFtp";
            this.Text = "frmFtp";
            this.Load += new System.EventHandler(this.frmFtp_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtFtpCarpeta;
        private System.Windows.Forms.Button btnSubeReportes;
        private System.Windows.Forms.Button btnBajaReportes;
        private System.Windows.Forms.ListBox lstArchivos;
        private System.Windows.Forms.Button btnCreaDirectorios;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}