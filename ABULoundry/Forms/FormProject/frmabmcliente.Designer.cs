namespace Loundry
{
    partial class frmabmcliente
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
            this.grpabm = new System.Windows.Forms.GroupBox();
            this.btngraba = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.cmbCondIva = new System.Windows.Forms.ComboBox();
            this.btnConsultaCuit = new System.Windows.Forms.Button();
            this.txtcuit = new System.Windows.Forms.TextBox();
            this.txtdni = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmblprecio = new System.Windows.Forms.ComboBox();
            this.cmbResponsable = new System.Windows.Forms.ComboBox();
            this.cmbdocumento = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdomicilio = new System.Windows.Forms.TextBox();
            this.txtrsocial = new System.Windows.Forms.TextBox();
            this.txtccliente = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.grpabm.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpabm
            // 
            this.grpabm.Controls.Add(this.richTextBox1);
            this.grpabm.Controls.Add(this.btngraba);
            this.grpabm.Controls.Add(this.label19);
            this.grpabm.Controls.Add(this.cmbCondIva);
            this.grpabm.Controls.Add(this.btnConsultaCuit);
            this.grpabm.Controls.Add(this.txtcuit);
            this.grpabm.Controls.Add(this.txtdni);
            this.grpabm.Controls.Add(this.label10);
            this.grpabm.Controls.Add(this.cmblprecio);
            this.grpabm.Controls.Add(this.cmbResponsable);
            this.grpabm.Controls.Add(this.cmbdocumento);
            this.grpabm.Controls.Add(this.label9);
            this.grpabm.Controls.Add(this.label8);
            this.grpabm.Controls.Add(this.txtmail);
            this.grpabm.Controls.Add(this.label7);
            this.grpabm.Controls.Add(this.txttelefono);
            this.grpabm.Controls.Add(this.label6);
            this.grpabm.Controls.Add(this.label5);
            this.grpabm.Controls.Add(this.label4);
            this.grpabm.Controls.Add(this.label3);
            this.grpabm.Controls.Add(this.label2);
            this.grpabm.Controls.Add(this.label1);
            this.grpabm.Controls.Add(this.txtdomicilio);
            this.grpabm.Controls.Add(this.txtrsocial);
            this.grpabm.Controls.Add(this.txtccliente);
            this.grpabm.Location = new System.Drawing.Point(12, 12);
            this.grpabm.Name = "grpabm";
            this.grpabm.Size = new System.Drawing.Size(661, 315);
            this.grpabm.TabIndex = 12;
            this.grpabm.TabStop = false;
            this.grpabm.Text = "Alta / Modi Clientes";
            // 
            // btngraba
            // 
            this.btngraba.FlatAppearance.BorderSize = 3;
            this.btngraba.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btngraba.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btngraba.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngraba.Image = global::Loundry.Properties.Resources.ggraba;
            this.btngraba.Location = new System.Drawing.Point(585, 286);
            this.btngraba.Name = "btngraba";
            this.btngraba.Size = new System.Drawing.Size(30, 23);
            this.btngraba.TabIndex = 10;
            this.btngraba.UseVisualStyleBackColor = true;
            this.btngraba.Click += new System.EventHandler(this.btngraba_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(227, 132);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(94, 13);
            this.label19.TabIndex = 38;
            this.label19.Text = "Condición del  IVA";
            // 
            // cmbCondIva
            // 
            this.cmbCondIva.FormattingEnabled = true;
            this.cmbCondIva.Location = new System.Drawing.Point(226, 152);
            this.cmbCondIva.Name = "cmbCondIva";
            this.cmbCondIva.Size = new System.Drawing.Size(109, 21);
            this.cmbCondIva.TabIndex = 37;
            // 
            // btnConsultaCuit
            // 
            this.btnConsultaCuit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnConsultaCuit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnConsultaCuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaCuit.Location = new System.Drawing.Point(165, 14);
            this.btnConsultaCuit.Name = "btnConsultaCuit";
            this.btnConsultaCuit.Size = new System.Drawing.Size(110, 23);
            this.btnConsultaCuit.TabIndex = 26;
            this.btnConsultaCuit.Text = "Consulta CUIT";
            this.btnConsultaCuit.UseVisualStyleBackColor = true;
            this.btnConsultaCuit.Visible = false;
            this.btnConsultaCuit.Click += new System.EventHandler(this.btnConsultaCuit_Click);
            // 
            // txtcuit
            // 
            this.txtcuit.Location = new System.Drawing.Point(26, 104);
            this.txtcuit.MaxLength = 11;
            this.txtcuit.Name = "txtcuit";
            this.txtcuit.Size = new System.Drawing.Size(130, 20);
            this.txtcuit.TabIndex = 27;
            this.txtcuit.TextChanged += new System.EventHandler(this.Txtcuit_TextChanged);
            // 
            // txtdni
            // 
            this.txtdni.Location = new System.Drawing.Point(190, 104);
            this.txtdni.MaxLength = 8;
            this.txtdni.Name = "txtdni";
            this.txtdni.Size = new System.Drawing.Size(115, 20);
            this.txtdni.TabIndex = 7;
            this.txtdni.TextChanged += new System.EventHandler(this.Txtdni_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(187, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Nro. DNI:";
            // 
            // cmblprecio
            // 
            this.cmblprecio.Enabled = false;
            this.cmblprecio.FormattingEnabled = true;
            this.cmblprecio.Items.AddRange(new object[] {
            "0-Mostrador",
            "1-Minorista",
            "2-Mayorista"});
            this.cmblprecio.Location = new System.Drawing.Point(27, 251);
            this.cmblprecio.Name = "cmblprecio";
            this.cmblprecio.Size = new System.Drawing.Size(142, 21);
            this.cmblprecio.TabIndex = 9;
            // 
            // cmbResponsable
            // 
            this.cmbResponsable.FormattingEnabled = true;
            this.cmbResponsable.Location = new System.Drawing.Point(26, 152);
            this.cmbResponsable.Name = "cmbResponsable";
            this.cmbResponsable.Size = new System.Drawing.Size(185, 21);
            this.cmbResponsable.TabIndex = 8;
            this.cmbResponsable.SelectedIndexChanged += new System.EventHandler(this.CmbResponsable_SelectedIndexChanged);
            // 
            // cmbdocumento
            // 
            this.cmbdocumento.FormattingEnabled = true;
            this.cmbdocumento.Items.AddRange(new object[] {
            "",
            "DNI",
            "CUIT"});
            this.cmbdocumento.Location = new System.Drawing.Point(569, 14);
            this.cmbdocumento.Name = "cmbdocumento";
            this.cmbdocumento.Size = new System.Drawing.Size(86, 21);
            this.cmbdocumento.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 232);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Lista de Precio:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(214, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "email";
            // 
            // txtmail
            // 
            this.txtmail.Location = new System.Drawing.Point(217, 208);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(235, 20);
            this.txtmail.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Teléfono";
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(26, 208);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(159, 20);
            this.txttelefono.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "IVA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Nro CUIT:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(409, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Documento con el que factura:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Domicilio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Razón Social:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Código:";
            // 
            // txtdomicilio
            // 
            this.txtdomicilio.Location = new System.Drawing.Point(299, 56);
            this.txtdomicilio.Name = "txtdomicilio";
            this.txtdomicilio.Size = new System.Drawing.Size(329, 20);
            this.txtdomicilio.TabIndex = 2;
            // 
            // txtrsocial
            // 
            this.txtrsocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtrsocial.Location = new System.Drawing.Point(26, 56);
            this.txtrsocial.Name = "txtrsocial";
            this.txtrsocial.Size = new System.Drawing.Size(235, 20);
            this.txtrsocial.TabIndex = 1;
            // 
            // txtccliente
            // 
            this.txtccliente.Location = new System.Drawing.Point(105, 16);
            this.txtccliente.Name = "txtccliente";
            this.txtccliente.Size = new System.Drawing.Size(52, 20);
            this.txtccliente.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Moccasin;
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(351, 132);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(212, 53);
            this.richTextBox1.TabIndex = 39;
            this.richTextBox1.Text = "La condición del IVA:\n  -Si es Consumidor Final debe ser 03-0%\n  -Si es Exento de" +
    "be ser 02-EXENTO";
            // 
            // frmabmcliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 341);
            this.Controls.Add(this.grpabm);
            this.Name = "frmabmcliente";
            this.Text = "frmabmcliente";
            this.Load += new System.EventHandler(this.frmabmcliente_Load);
            this.grpabm.ResumeLayout(false);
            this.grpabm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpabm;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cmbCondIva;
        private System.Windows.Forms.Button btnConsultaCuit;
        private System.Windows.Forms.TextBox txtcuit;
        private System.Windows.Forms.TextBox txtdni;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmblprecio;
        private System.Windows.Forms.ComboBox cmbResponsable;
        private System.Windows.Forms.ComboBox cmbdocumento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btngraba;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdomicilio;
        private System.Windows.Forms.TextBox txtrsocial;
        private System.Windows.Forms.TextBox txtccliente;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}