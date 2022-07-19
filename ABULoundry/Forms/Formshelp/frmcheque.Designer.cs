namespace Loundry
{
    partial class frmcheque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcheque));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panelGradient3 = new PanelGradient.PanelGradient();
            this.btnaceptacheques = new System.Windows.Forms.Button();
            this.grpabm = new System.Windows.Forms.GroupBox();
            this.dtpfechcheque = new System.Windows.Forms.DateTimePicker();
            this.dtpfechform = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtimporte = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtnrocheque = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbanco = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnroform = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcform = new System.Windows.Forms.TextBox();
            this.grpgrabasale = new System.Windows.Forms.GroupBox();
            this.btngraba = new System.Windows.Forms.Button();
            this.btncancela = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcaja = new System.Windows.Forms.TextBox();
            this.txtccliente = new System.Windows.Forms.TextBox();
            this.labelGradient1 = new Loundry.LabelGradient();
            this.txtsubtotal = new System.Windows.Forms.TextBox();
            this.grpgrilla = new System.Windows.Forms.GroupBox();
            this.dgvcheques = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.btnborra = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btnmodifica = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panelGradient3.SuspendLayout();
            this.grpabm.SuspendLayout();
            this.grpgrabasale.SuspendLayout();
            this.grpgrilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcheques)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(704, 440);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.grpabm);
            this.tabPage1.Controls.Add(this.labelGradient1);
            this.tabPage1.Controls.Add(this.txtsubtotal);
            this.tabPage1.Controls.Add(this.grpgrilla);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(696, 414);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "A/B/M Cheques";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panelGradient3);
            this.groupBox2.Location = new System.Drawing.Point(631, 372);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(40, 36);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // panelGradient3
            // 
            this.panelGradient3.Controls.Add(this.btnaceptacheques);
            this.panelGradient3.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panelGradient3.Location = new System.Drawing.Point(1, 6);
            this.panelGradient3.Name = "panelGradient3";
            this.panelGradient3.Size = new System.Drawing.Size(43, 29);
            this.panelGradient3.TabIndex = 23;
            // 
            // btnaceptacheques
            // 
            this.btnaceptacheques.Image = global::Loundry.Properties.Resources.ggraba;
            this.btnaceptacheques.Location = new System.Drawing.Point(3, 3);
            this.btnaceptacheques.Name = "btnaceptacheques";
            this.btnaceptacheques.Size = new System.Drawing.Size(30, 23);
            this.btnaceptacheques.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btnaceptacheques, "Confirma el Ingreso de cheques");
            this.btnaceptacheques.UseVisualStyleBackColor = true;
            this.btnaceptacheques.Click += new System.EventHandler(this.btnaceptacheques_Click);
            // 
            // grpabm
            // 
            this.grpabm.Controls.Add(this.dtpfechcheque);
            this.grpabm.Controls.Add(this.dtpfechform);
            this.grpabm.Controls.Add(this.label9);
            this.grpabm.Controls.Add(this.label8);
            this.grpabm.Controls.Add(this.txtimporte);
            this.grpabm.Controls.Add(this.label7);
            this.grpabm.Controls.Add(this.txtnrocheque);
            this.grpabm.Controls.Add(this.label6);
            this.grpabm.Controls.Add(this.txtbanco);
            this.grpabm.Controls.Add(this.label5);
            this.grpabm.Controls.Add(this.txtnroform);
            this.grpabm.Controls.Add(this.label4);
            this.grpabm.Controls.Add(this.txtcform);
            this.grpabm.Controls.Add(this.grpgrabasale);
            this.grpabm.Controls.Add(this.label3);
            this.grpabm.Controls.Add(this.label2);
            this.grpabm.Controls.Add(this.label1);
            this.grpabm.Controls.Add(this.txtcaja);
            this.grpabm.Controls.Add(this.txtccliente);
            this.grpabm.Location = new System.Drawing.Point(199, 54);
            this.grpabm.Name = "grpabm";
            this.grpabm.Size = new System.Drawing.Size(439, 274);
            this.grpabm.TabIndex = 11;
            this.grpabm.TabStop = false;
            this.grpabm.Text = "Alta / Modi Cheques";
            this.grpabm.Visible = false;
            // 
            // dtpfechcheque
            // 
            this.dtpfechcheque.Location = new System.Drawing.Point(105, 191);
            this.dtpfechcheque.Name = "dtpfechcheque";
            this.dtpfechcheque.Size = new System.Drawing.Size(238, 20);
            this.dtpfechcheque.TabIndex = 26;
            this.toolTip1.SetToolTip(this.dtpfechcheque, "Fecha a Depositar");
            // 
            // dtpfechform
            // 
            this.dtpfechform.Location = new System.Drawing.Point(218, 13);
            this.dtpfechform.Name = "dtpfechform";
            this.dtpfechform.Size = new System.Drawing.Size(197, 20);
            this.dtpfechform.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 197);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Fecha Present:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Importe";
            // 
            // txtimporte
            // 
            this.txtimporte.Location = new System.Drawing.Point(85, 160);
            this.txtimporte.Name = "txtimporte";
            this.txtimporte.Size = new System.Drawing.Size(114, 20);
            this.txtimporte.TabIndex = 7;
            this.txtimporte.Text = "0";
            this.txtimporte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtimporte_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Nº Cheque";
            // 
            // txtnrocheque
            // 
            this.txtnrocheque.Location = new System.Drawing.Point(85, 130);
            this.txtnrocheque.Name = "txtnrocheque";
            this.txtnrocheque.Size = new System.Drawing.Size(158, 20);
            this.txtnrocheque.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Banco";
            // 
            // txtbanco
            // 
            this.txtbanco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbanco.Location = new System.Drawing.Point(64, 104);
            this.txtbanco.Name = "txtbanco";
            this.txtbanco.Size = new System.Drawing.Size(267, 20);
            this.txtbanco.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(163, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Nro Formulario";
            // 
            // txtnroform
            // 
            this.txtnroform.Enabled = false;
            this.txtnroform.Location = new System.Drawing.Point(244, 68);
            this.txtnroform.Name = "txtnroform";
            this.txtnroform.Size = new System.Drawing.Size(87, 20);
            this.txtnroform.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Formulario:";
            // 
            // txtcform
            // 
            this.txtcform.Enabled = false;
            this.txtcform.Location = new System.Drawing.Point(105, 68);
            this.txtcform.Name = "txtcform";
            this.txtcform.Size = new System.Drawing.Size(52, 20);
            this.txtcform.TabIndex = 3;
            // 
            // grpgrabasale
            // 
            this.grpgrabasale.Controls.Add(this.btngraba);
            this.grpgrabasale.Controls.Add(this.btncancela);
            this.grpgrabasale.Location = new System.Drawing.Point(257, 217);
            this.grpgrabasale.Name = "grpgrabasale";
            this.grpgrabasale.Size = new System.Drawing.Size(80, 52);
            this.grpgrabasale.TabIndex = 12;
            this.grpgrabasale.TabStop = false;
            // 
            // btngraba
            // 
            this.btngraba.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btngraba.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btngraba.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngraba.Image = global::Loundry.Properties.Resources.ggraba;
            this.btngraba.Location = new System.Drawing.Point(6, 19);
            this.btngraba.Name = "btngraba";
            this.btngraba.Size = new System.Drawing.Size(30, 23);
            this.btngraba.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btngraba, "Graba el Cheque");
            this.btngraba.UseVisualStyleBackColor = true;
            this.btngraba.Click += new System.EventHandler(this.btngraba_Click);
            // 
            // btncancela
            // 
            this.btncancela.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btncancela.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btncancela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancela.Image = global::Loundry.Properties.Resources.gsale;
            this.btncancela.Location = new System.Drawing.Point(44, 19);
            this.btncancela.Name = "btncancela";
            this.btncancela.Size = new System.Drawing.Size(30, 23);
            this.btncancela.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btncancela, "Cancela");
            this.btncancela.UseVisualStyleBackColor = true;
            this.btncancela.Click += new System.EventHandler(this.btncancela_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nº Caja";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Fecha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Cliente";
            // 
            // txtcaja
            // 
            this.txtcaja.Enabled = false;
            this.txtcaja.Location = new System.Drawing.Point(105, 42);
            this.txtcaja.Name = "txtcaja";
            this.txtcaja.Size = new System.Drawing.Size(52, 20);
            this.txtcaja.TabIndex = 2;
            // 
            // txtccliente
            // 
            this.txtccliente.Enabled = false;
            this.txtccliente.Location = new System.Drawing.Point(105, 16);
            this.txtccliente.Name = "txtccliente";
            this.txtccliente.Size = new System.Drawing.Size(52, 20);
            this.txtccliente.TabIndex = 0;
            // 
            // labelGradient1
            // 
            this.labelGradient1.AutoSize = true;
            this.labelGradient1.BorderStyle = System.Windows.Forms.Border3DStyle.Adjust;
            this.labelGradient1.ForeColor = System.Drawing.Color.White;
            this.labelGradient1.GradientColorOne = System.Drawing.Color.Silver;
            this.labelGradient1.Location = new System.Drawing.Point(553, 372);
            this.labelGradient1.Name = "labelGradient1";
            this.labelGradient1.Size = new System.Drawing.Size(50, 13);
            this.labelGradient1.TabIndex = 14;
            this.labelGradient1.Text = "SubTotal";
            // 
            // txtsubtotal
            // 
            this.txtsubtotal.Enabled = false;
            this.txtsubtotal.Location = new System.Drawing.Point(543, 388);
            this.txtsubtotal.Name = "txtsubtotal";
            this.txtsubtotal.Size = new System.Drawing.Size(72, 20);
            this.txtsubtotal.TabIndex = 13;
            // 
            // grpgrilla
            // 
            this.grpgrilla.Controls.Add(this.dgvcheques);
            this.grpgrilla.Location = new System.Drawing.Point(20, 59);
            this.grpgrilla.Name = "grpgrilla";
            this.grpgrilla.Size = new System.Drawing.Size(651, 307);
            this.grpgrilla.TabIndex = 12;
            this.grpgrilla.TabStop = false;
            this.grpgrilla.Text = "Cheques";
            // 
            // dgvcheques
            // 
            this.dgvcheques.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcheques.Location = new System.Drawing.Point(6, 19);
            this.dgvcheques.Name = "dgvcheques";
            this.dgvcheques.Size = new System.Drawing.Size(635, 275);
            this.dgvcheques.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnbuscar);
            this.groupBox1.Controls.Add(this.btnrefresh);
            this.groupBox1.Controls.Add(this.btnmodifica);
            this.groupBox1.Controls.Add(this.btnborra);
            this.groupBox1.Controls.Add(this.btnnuevo);
            this.groupBox1.Location = new System.Drawing.Point(20, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 47);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acciones";
            // 
            // btnbuscar
            // 
            this.btnbuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnbuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.Image = global::Loundry.Properties.Resources.gbusqueda;
            this.btnbuscar.Location = new System.Drawing.Point(143, 12);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(30, 23);
            this.btnbuscar.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btnbuscar, "Busca Cheque");
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btnrefresh
            // 
            this.btnrefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnrefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnrefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrefresh.Image = global::Loundry.Properties.Resources.grefresca;
            this.btnrefresh.Location = new System.Drawing.Point(6, 12);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(30, 23);
            this.btnrefresh.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnrefresh, "Actualiza");
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // btnborra
            // 
            this.btnborra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnborra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnborra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnborra.Image = global::Loundry.Properties.Resources.borra;
            this.btnborra.Location = new System.Drawing.Point(107, 12);
            this.btnborra.Name = "btnborra";
            this.btnborra.Size = new System.Drawing.Size(30, 23);
            this.btnborra.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnborra, "Borra Cheque");
            this.btnborra.UseVisualStyleBackColor = true;
            this.btnborra.Click += new System.EventHandler(this.btnborra_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnnuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnuevo.Image = global::Loundry.Properties.Resources.nuevo;
            this.btnnuevo.Location = new System.Drawing.Point(37, 12);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(30, 23);
            this.btnnuevo.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnnuevo, "Nuevo Cheque");
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // btnmodifica
            // 
            this.btnmodifica.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnmodifica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnmodifica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmodifica.Image = global::Loundry.Properties.Resources.modifica;
            this.btnmodifica.Location = new System.Drawing.Point(71, 12);
            this.btnmodifica.Name = "btnmodifica";
            this.btnmodifica.Size = new System.Drawing.Size(30, 23);
            this.btnmodifica.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnmodifica, "Modifica Cheque");
            this.btnmodifica.UseVisualStyleBackColor = true;
            this.btnmodifica.Click += new System.EventHandler(this.btnmodifica_Click);
            // 
            // frmcheque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 465);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmcheque";
            this.Text = "Ingreso de pago por cheque";
            this.Load += new System.EventHandler(this.frmcheque_Load);
            this.Leave += new System.EventHandler(this.frmcheque_Leave);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panelGradient3.ResumeLayout(false);
            this.grpabm.ResumeLayout(false);
            this.grpabm.PerformLayout();
            this.grpgrabasale.ResumeLayout(false);
            this.grpgrilla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcheques)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox grpgrilla;
        private System.Windows.Forms.GroupBox grpabm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbanco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnroform;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcform;
        private System.Windows.Forms.GroupBox grpgrabasale;
        private System.Windows.Forms.Button btngraba;
        private System.Windows.Forms.Button btncancela;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcaja;
        private System.Windows.Forms.TextBox txtccliente;
        private System.Windows.Forms.DataGridView dgvcheques;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Button btnborra;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btnmodifica;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtimporte;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtnrocheque;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpfechform;
        private System.Windows.Forms.DateTimePicker dtpfechcheque;
        private LabelGradient labelGradient1;
        private System.Windows.Forms.TextBox txtsubtotal;
        private System.Windows.Forms.GroupBox groupBox2;
        private PanelGradient.PanelGradient panelGradient3;
        private System.Windows.Forms.Button btnaceptacheques;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}