namespace Loundry
{
    partial class frmconfiguracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmconfiguracion));
            this.panelGradient1 = new PanelGradient.PanelGradient();
            this.btnlimpiabases = new System.Windows.Forms.Button();
            this.txtdatabase = new System.Windows.Forms.TextBox();
            this.txtdirectorio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnomarch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btncrea = new System.Windows.Forms.Button();
            this.txtpassword = new System.Windows.Forms.MaskedTextBox();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.txtservidor = new System.Windows.Forms.TextBox();
            this.btnCreaDirectorios = new System.Windows.Forms.Button();
            this.panelGradient1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelGradient1
            // 
            this.panelGradient1.Controls.Add(this.btnCreaDirectorios);
            this.panelGradient1.Controls.Add(this.btnlimpiabases);
            this.panelGradient1.Controls.Add(this.txtdatabase);
            this.panelGradient1.Controls.Add(this.txtdirectorio);
            this.panelGradient1.Controls.Add(this.label1);
            this.panelGradient1.Controls.Add(this.label6);
            this.panelGradient1.Controls.Add(this.label2);
            this.panelGradient1.Controls.Add(this.txtnomarch);
            this.panelGradient1.Controls.Add(this.label3);
            this.panelGradient1.Controls.Add(this.label5);
            this.panelGradient1.Controls.Add(this.label4);
            this.panelGradient1.Controls.Add(this.btncrea);
            this.panelGradient1.Controls.Add(this.txtpassword);
            this.panelGradient1.Controls.Add(this.txtusuario);
            this.panelGradient1.Controls.Add(this.txtservidor);
            this.panelGradient1.GradientColorOne = System.Drawing.Color.Silver;
            this.panelGradient1.GradientColorTwo = System.Drawing.Color.Lavender;
            this.panelGradient1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panelGradient1.Location = new System.Drawing.Point(12, 12);
            this.panelGradient1.Name = "panelGradient1";
            this.panelGradient1.Size = new System.Drawing.Size(329, 205);
            this.panelGradient1.TabIndex = 12;
            // 
            // btnlimpiabases
            // 
            this.btnlimpiabases.Location = new System.Drawing.Point(236, 12);
            this.btnlimpiabases.Name = "btnlimpiabases";
            this.btnlimpiabases.Size = new System.Drawing.Size(75, 23);
            this.btnlimpiabases.TabIndex = 12;
            this.btnlimpiabases.Text = "Limpiar";
            this.btnlimpiabases.UseVisualStyleBackColor = true;
            this.btnlimpiabases.Click += new System.EventHandler(this.btnlimpiabases_Click);
            // 
            // txtdatabase
            // 
            this.txtdatabase.Location = new System.Drawing.Point(119, 38);
            this.txtdatabase.Name = "txtdatabase";
            this.txtdatabase.Size = new System.Drawing.Size(100, 20);
            this.txtdatabase.TabIndex = 1;
            // 
            // txtdirectorio
            // 
            this.txtdirectorio.Location = new System.Drawing.Point(119, 116);
            this.txtdirectorio.Name = "txtdirectorio";
            this.txtdirectorio.Size = new System.Drawing.Size(100, 20);
            this.txtdirectorio.TabIndex = 4;
            this.txtdirectorio.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Servidor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Directorio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Database";
            // 
            // txtnomarch
            // 
            this.txtnomarch.Location = new System.Drawing.Point(119, 142);
            this.txtnomarch.Name = "txtnomarch";
            this.txtnomarch.Size = new System.Drawing.Size(100, 20);
            this.txtnomarch.TabIndex = 5;
            this.txtnomarch.TextChanged += new System.EventHandler(this.txtnomarch_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Usuario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nombre Archivo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // btncrea
            // 
            this.btncrea.Location = new System.Drawing.Point(189, 168);
            this.btncrea.Name = "btncrea";
            this.btncrea.Size = new System.Drawing.Size(122, 23);
            this.btncrea.TabIndex = 6;
            this.btncrea.Text = "Crea configuración";
            this.btncrea.UseVisualStyleBackColor = true;
            this.btncrea.Click += new System.EventHandler(this.btncrea_Click);
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(119, 90);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(100, 20);
            this.txtpassword.TabIndex = 3;
            this.txtpassword.UseSystemPasswordChar = true;
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(119, 64);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(100, 20);
            this.txtusuario.TabIndex = 2;
            // 
            // txtservidor
            // 
            this.txtservidor.Location = new System.Drawing.Point(119, 12);
            this.txtservidor.Name = "txtservidor";
            this.txtservidor.Size = new System.Drawing.Size(100, 20);
            this.txtservidor.TabIndex = 0;
            // 
            // btnCreaDirectorios
            // 
            this.btnCreaDirectorios.Location = new System.Drawing.Point(236, 41);
            this.btnCreaDirectorios.Name = "btnCreaDirectorios";
            this.btnCreaDirectorios.Size = new System.Drawing.Size(75, 23);
            this.btnCreaDirectorios.TabIndex = 13;
            this.btnCreaDirectorios.Text = "CreaDirectorios";
            this.btnCreaDirectorios.UseVisualStyleBackColor = true;
            this.btnCreaDirectorios.Click += new System.EventHandler(this.btnCreaDirectorios_Click);
            // 
            // frmconfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Loundry.Properties.Resources.fondologin;
            this.ClientSize = new System.Drawing.Size(357, 229);
            this.Controls.Add(this.panelGradient1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmconfiguracion";
            this.Text = "Configuración";
            this.Load += new System.EventHandler(this.frmconfiguracion_Load);
            this.Leave += new System.EventHandler(this.frmconfiguracion_Leave);
            this.panelGradient1.ResumeLayout(false);
            this.panelGradient1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtpassword;
        private System.Windows.Forms.TextBox txtservidor;
        private System.Windows.Forms.TextBox txtdatabase;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Button btncrea;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnomarch;
        private System.Windows.Forms.TextBox txtdirectorio;
        private System.Windows.Forms.Label label6;
        private PanelGradient.PanelGradient panelGradient1;
        private System.Windows.Forms.Button btnlimpiabases;
        private System.Windows.Forms.Button btnCreaDirectorios;
    }
}