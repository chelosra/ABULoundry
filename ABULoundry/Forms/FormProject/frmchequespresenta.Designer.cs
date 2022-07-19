namespace Loundry
{
    partial class frmchequespresenta
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grpabm = new System.Windows.Forms.GroupBox();
            this.cmbpresentado = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
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
            this.grpgrilla = new System.Windows.Forms.GroupBox();
            this.dgvcheques = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.btnmodifica = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvconsulta = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.txtsubtotal = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtcliente = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbestado = new System.Windows.Forms.ComboBox();
            this.lblgcliente = new Loundry.LabelGradient();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpfechhasta = new System.Windows.Forms.DateTimePicker();
            this.dtpfechdesde = new System.Windows.Forms.DateTimePicker();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grpabm.SuspendLayout();
            this.grpgrabasale.SuspendLayout();
            this.grpgrilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcheques)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvconsulta)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 67);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1057, 440);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grpabm);
            this.tabPage1.Controls.Add(this.grpgrilla);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1049, 414);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cheques/Depósitos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // grpabm
            // 
            this.grpabm.Controls.Add(this.cmbpresentado);
            this.grpabm.Controls.Add(this.label10);
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
            this.grpabm.Location = new System.Drawing.Point(269, 59);
            this.grpabm.Name = "grpabm";
            this.grpabm.Size = new System.Drawing.Size(439, 274);
            this.grpabm.TabIndex = 13;
            this.grpabm.TabStop = false;
            this.grpabm.Text = "Presentación de Cheques";
            this.grpabm.Visible = false;
            // 
            // cmbpresentado
            // 
            this.cmbpresentado.FormattingEnabled = true;
            this.cmbpresentado.Items.AddRange(new object[] {
            "SI",
            "NO",
            "RECHAZADO"});
            this.cmbpresentado.Location = new System.Drawing.Point(89, 230);
            this.cmbpresentado.Name = "cmbpresentado";
            this.cmbpresentado.Size = new System.Drawing.Size(149, 21);
            this.cmbpresentado.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 230);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Presentado";
            // 
            // dtpfechcheque
            // 
            this.dtpfechcheque.Enabled = false;
            this.dtpfechcheque.Location = new System.Drawing.Point(105, 191);
            this.dtpfechcheque.Name = "dtpfechcheque";
            this.dtpfechcheque.Size = new System.Drawing.Size(238, 20);
            this.dtpfechcheque.TabIndex = 26;
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
            this.txtimporte.Enabled = false;
            this.txtimporte.Location = new System.Drawing.Point(85, 160);
            this.txtimporte.Name = "txtimporte";
            this.txtimporte.Size = new System.Drawing.Size(114, 20);
            this.txtimporte.TabIndex = 7;
            this.txtimporte.Text = "0";
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
            this.txtnrocheque.Enabled = false;
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
            this.txtbanco.Enabled = false;
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
            this.btngraba.Location = new System.Drawing.Point(6, 13);
            this.btngraba.Name = "btngraba";
            this.btngraba.Size = new System.Drawing.Size(30, 23);
            this.btngraba.TabIndex = 8;
            this.btngraba.UseVisualStyleBackColor = true;
            this.btngraba.Click += new System.EventHandler(this.btngraba_Click);
            // 
            // btncancela
            // 
            this.btncancela.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btncancela.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btncancela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancela.Image = global::Loundry.Properties.Resources.gsale;
            this.btncancela.Location = new System.Drawing.Point(44, 13);
            this.btncancela.Name = "btncancela";
            this.btncancela.Size = new System.Drawing.Size(30, 23);
            this.btncancela.TabIndex = 9;
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
            // grpgrilla
            // 
            this.grpgrilla.Controls.Add(this.dgvcheques);
            this.grpgrilla.Location = new System.Drawing.Point(20, 59);
            this.grpgrilla.Name = "grpgrilla";
            this.grpgrilla.Size = new System.Drawing.Size(1012, 330);
            this.grpgrilla.TabIndex = 12;
            this.grpgrilla.TabStop = false;
            this.grpgrilla.Text = "Cheques";
            // 
            // dgvcheques
            // 
            this.dgvcheques.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcheques.Location = new System.Drawing.Point(6, 19);
            this.dgvcheques.Name = "dgvcheques";
            this.dgvcheques.Size = new System.Drawing.Size(990, 277);
            this.dgvcheques.TabIndex = 10;
            this.dgvcheques.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvcheques_DataError);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnbuscar);
            this.groupBox1.Controls.Add(this.btnmodifica);
            this.groupBox1.Controls.Add(this.btnrefresh);
            this.groupBox1.Location = new System.Drawing.Point(20, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(121, 47);
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
            this.btnbuscar.Location = new System.Drawing.Point(83, 18);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(30, 23);
            this.btnbuscar.TabIndex = 7;
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btnrefresh
            // 
            this.btnrefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnrefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnrefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrefresh.Image = global::Loundry.Properties.Resources.grefresca;
            this.btnrefresh.Location = new System.Drawing.Point(11, 18);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(30, 23);
            this.btnrefresh.TabIndex = 3;
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // btnmodifica
            // 
            this.btnmodifica.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnmodifica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnmodifica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmodifica.Image = global::Loundry.Properties.Resources.modifica;
            this.btnmodifica.Location = new System.Drawing.Point(47, 18);
            this.btnmodifica.Name = "btnmodifica";
            this.btnmodifica.Size = new System.Drawing.Size(30, 23);
            this.btnmodifica.TabIndex = 5;
            this.btnmodifica.UseVisualStyleBackColor = true;
            this.btnmodifica.Click += new System.EventHandler(this.btnmodifica_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.txtcliente);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.cmbestado);
            this.tabPage2.Controls.Add(this.lblgcliente);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1049, 414);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consultas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvconsulta);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txtsubtotal);
            this.groupBox2.Location = new System.Drawing.Point(25, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1004, 292);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "...";
            // 
            // dgvconsulta
            // 
            this.dgvconsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvconsulta.Location = new System.Drawing.Point(17, 19);
            this.dgvconsulta.Name = "dgvconsulta";
            this.dgvconsulta.Size = new System.Drawing.Size(970, 234);
            this.dgvconsulta.TabIndex = 21;
            this.dgvconsulta.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvconsulta_DataError);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(775, 266);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(104, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "Importe en cheques:";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // txtsubtotal
            // 
            this.txtsubtotal.Enabled = false;
            this.txtsubtotal.Location = new System.Drawing.Point(885, 259);
            this.txtsubtotal.Name = "txtsubtotal";
            this.txtsubtotal.Size = new System.Drawing.Size(100, 20);
            this.txtsubtotal.TabIndex = 28;
            this.txtsubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtsubtotal.TextChanged += new System.EventHandler(this.txtsubtotal_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(22, 72);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "Cliente:";
            // 
            // txtcliente
            // 
            this.txtcliente.Location = new System.Drawing.Point(73, 69);
            this.txtcliente.Name = "txtcliente";
            this.txtcliente.Size = new System.Drawing.Size(75, 20);
            this.txtcliente.TabIndex = 25;
            this.toolTip1.SetToolTip(this.txtcliente, "Dbl click para ver Clientes");
            this.txtcliente.TextChanged += new System.EventHandler(this.txtcliente_TextChanged);
            this.txtcliente.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtcliente_MouseDoubleClick);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(22, 48);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Estado del Cheque";
            // 
            // cmbestado
            // 
            this.cmbestado.FormattingEnabled = true;
            this.cmbestado.Items.AddRange(new object[] {
            "     ",
            "SI PRESENTADO",
            "NO PRESENTADO",
            "RECHAZADO"});
            this.cmbestado.Location = new System.Drawing.Point(129, 42);
            this.cmbestado.Name = "cmbestado";
            this.cmbestado.Size = new System.Drawing.Size(238, 21);
            this.cmbestado.TabIndex = 23;
            this.cmbestado.SelectedIndexChanged += new System.EventHandler(this.cmbestado_SelectedIndexChanged);
            // 
            // lblgcliente
            // 
            this.lblgcliente.AutoSize = true;
            this.lblgcliente.BorderStyle = System.Windows.Forms.Border3DStyle.Adjust;
            this.lblgcliente.ForeColor = System.Drawing.Color.White;
            this.lblgcliente.GradientColorOne = System.Drawing.Color.Silver;
            this.lblgcliente.Location = new System.Drawing.Point(164, 72);
            this.lblgcliente.Name = "lblgcliente";
            this.lblgcliente.Size = new System.Drawing.Size(16, 13);
            this.lblgcliente.TabIndex = 27;
            this.lblgcliente.Text = "...";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(379, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Fecha Hasta";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Fecha Desde";
            // 
            // dtpfechhasta
            // 
            this.dtpfechhasta.Location = new System.Drawing.Point(456, 19);
            this.dtpfechhasta.Name = "dtpfechhasta";
            this.dtpfechhasta.Size = new System.Drawing.Size(238, 20);
            this.dtpfechhasta.TabIndex = 18;
            // 
            // dtpfechdesde
            // 
            this.dtpfechdesde.Location = new System.Drawing.Point(108, 19);
            this.dtpfechdesde.Name = "dtpfechdesde";
            this.dtpfechdesde.Size = new System.Drawing.Size(238, 20);
            this.dtpfechdesde.TabIndex = 17;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtpfechhasta);
            this.groupBox3.Controls.Add(this.dtpfechdesde);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(12, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1053, 57);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rango de Fechas";
            // 
            // frmchequespresenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 540);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmchequespresenta";
            this.Text = "Cheques";
            this.Load += new System.EventHandler(this.frmchequespresenta_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.grpabm.ResumeLayout(false);
            this.grpabm.PerformLayout();
            this.grpgrabasale.ResumeLayout(false);
            this.grpgrilla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcheques)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvconsulta)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox grpgrilla;
        private System.Windows.Forms.DataGridView dgvcheques;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Button btnmodifica;
        private System.Windows.Forms.GroupBox grpabm;
        private System.Windows.Forms.DateTimePicker dtpfechcheque;
        private System.Windows.Forms.DateTimePicker dtpfechform;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtimporte;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtnrocheque;
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
        private System.Windows.Forms.ComboBox cmbpresentado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpfechhasta;
        private System.Windows.Forms.DateTimePicker dtpfechdesde;
        private System.Windows.Forms.DataGridView dgvconsulta;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbestado;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtcliente;
        private System.Windows.Forms.ToolTip toolTip1;
        private LabelGradient lblgcliente;
        private System.Windows.Forms.TextBox txtsubtotal;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}