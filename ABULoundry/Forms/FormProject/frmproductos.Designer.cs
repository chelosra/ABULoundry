namespace Loundry
{
    partial class frmproductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmproductos));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.mProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grpgrilla = new System.Windows.Forms.GroupBox();
            this.grpabm = new System.Windows.Forms.GroupBox();
            this.txtxmayorista = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtxminorista = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtxmostrador = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtpventa2 = new System.Windows.Forms.TextBox();
            this.txtpventa1 = new System.Windows.Forms.TextBox();
            this.txtpventa = new System.Windows.Forms.TextBox();
            this.txtpcosto = new System.Windows.Forms.TextBox();
            this.txtstact = new System.Windows.Forms.TextBox();
            this.txtstmin = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grpgrabasale = new System.Windows.Forms.GroupBox();
            this.btncancela = new System.Windows.Forms.Button();
            this.btngraba = new System.Windows.Forms.Button();
            this.cmbcrubro = new System.Windows.Forms.ComboBox();
            this.cmbrubro = new System.Windows.Forms.ComboBox();
            this.txtdetalle = new System.Windows.Forms.TextBox();
            this.txtcprod = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvproductos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.btnborra = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btnmodifica = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.grpaccion2 = new System.Windows.Forms.GroupBox();
            this.btnimprime = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.labelGradient2 = new Loundry.LabelGradient();
            this.cmbconsulta = new System.Windows.Forms.ComboBox();
            this.txtccliente = new System.Windows.Forms.TextBox();
            this.lblgrsocial = new Loundry.LabelGradient();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvconsulta = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.grpAumentoPrecio = new System.Windows.Forms.GroupBox();
            this.pgBarPrecio = new System.Windows.Forms.ProgressBar();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbRubroPrecio = new System.Windows.Forms.ComboBox();
            this.btnAumento = new System.Windows.Forms.Button();
            this.cmbCrubroPrecio = new System.Windows.Forms.ComboBox();
            this.txtPcostoaumento = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menu.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grpgrilla.SuspendLayout();
            this.grpabm.SuspendLayout();
            this.grpgrabasale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproductos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grpaccion2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvconsulta)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.grpAumentoPrecio.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mProductoToolStripMenuItem});
            this.menu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(929, 23);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            this.menu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menu_ItemClicked);
            // 
            // mProductoToolStripMenuItem
            // 
            this.mProductoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarToolStripMenuItem});
            this.mProductoToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.mProductoToolStripMenuItem.MergeIndex = 3;
            this.mProductoToolStripMenuItem.Name = "mProductoToolStripMenuItem";
            this.mProductoToolStripMenuItem.Size = new System.Drawing.Size(68, 19);
            this.mProductoToolStripMenuItem.Text = "Producto";
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grpgrilla);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(909, 508);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "A/B/M Productos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // grpgrilla
            // 
            this.grpgrilla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpgrilla.Controls.Add(this.grpabm);
            this.grpgrilla.Controls.Add(this.dgvproductos);
            this.grpgrilla.Location = new System.Drawing.Point(9, 59);
            this.grpgrilla.Name = "grpgrilla";
            this.grpgrilla.Size = new System.Drawing.Size(885, 417);
            this.grpgrilla.TabIndex = 8;
            this.grpgrilla.TabStop = false;
            this.grpgrilla.Text = "Productos";
            // 
            // grpabm
            // 
            this.grpabm.Controls.Add(this.txtxmayorista);
            this.grpabm.Controls.Add(this.label12);
            this.grpabm.Controls.Add(this.txtxminorista);
            this.grpabm.Controls.Add(this.label11);
            this.grpabm.Controls.Add(this.txtxmostrador);
            this.grpabm.Controls.Add(this.label10);
            this.grpabm.Controls.Add(this.txtpventa2);
            this.grpabm.Controls.Add(this.txtpventa1);
            this.grpabm.Controls.Add(this.txtpventa);
            this.grpabm.Controls.Add(this.txtpcosto);
            this.grpabm.Controls.Add(this.txtstact);
            this.grpabm.Controls.Add(this.txtstmin);
            this.grpabm.Controls.Add(this.label9);
            this.grpabm.Controls.Add(this.label8);
            this.grpabm.Controls.Add(this.label7);
            this.grpabm.Controls.Add(this.label6);
            this.grpabm.Controls.Add(this.label5);
            this.grpabm.Controls.Add(this.label4);
            this.grpabm.Controls.Add(this.grpgrabasale);
            this.grpabm.Controls.Add(this.cmbcrubro);
            this.grpabm.Controls.Add(this.cmbrubro);
            this.grpabm.Controls.Add(this.txtdetalle);
            this.grpabm.Controls.Add(this.txtcprod);
            this.grpabm.Controls.Add(this.label3);
            this.grpabm.Controls.Add(this.label2);
            this.grpabm.Controls.Add(this.label1);
            this.grpabm.Location = new System.Drawing.Point(177, 50);
            this.grpabm.Name = "grpabm";
            this.grpabm.Size = new System.Drawing.Size(503, 295);
            this.grpabm.TabIndex = 2;
            this.grpabm.TabStop = false;
            this.grpabm.Text = "ALTA / MODIF de producos";
            this.grpabm.Visible = false;
            // 
            // txtxmayorista
            // 
            this.txtxmayorista.Enabled = false;
            this.txtxmayorista.Location = new System.Drawing.Point(367, 130);
            this.txtxmayorista.Name = "txtxmayorista";
            this.txtxmayorista.Size = new System.Drawing.Size(33, 20);
            this.txtxmayorista.TabIndex = 12;
            this.txtxmayorista.Text = "0";
            this.txtxmayorista.TextChanged += new System.EventHandler(this.txtpcosto_TextChanged);
            this.txtxmayorista.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtxmayorista_KeyPress);
            this.txtxmayorista.Leave += new System.EventHandler(this.txtxmayorista_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(347, 114);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "% Mayorista";
            // 
            // txtxminorista
            // 
            this.txtxminorista.Enabled = false;
            this.txtxminorista.Location = new System.Drawing.Point(205, 130);
            this.txtxminorista.Name = "txtxminorista";
            this.txtxminorista.Size = new System.Drawing.Size(33, 20);
            this.txtxminorista.TabIndex = 11;
            this.txtxminorista.Text = "0";
            this.txtxminorista.TextChanged += new System.EventHandler(this.txtpcosto_TextChanged);
            this.txtxminorista.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtxminorista_KeyPress);
            this.txtxminorista.Leave += new System.EventHandler(this.txtxminorista_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(185, 114);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "% Minorista";
            // 
            // txtxmostrador
            // 
            this.txtxmostrador.Enabled = false;
            this.txtxmostrador.Location = new System.Drawing.Point(38, 130);
            this.txtxmostrador.Name = "txtxmostrador";
            this.txtxmostrador.Size = new System.Drawing.Size(37, 20);
            this.txtxmostrador.TabIndex = 10;
            this.txtxmostrador.Text = "0";
            this.txtxmostrador.TextChanged += new System.EventHandler(this.txtpcosto_TextChanged);
            this.txtxmostrador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtxmostrador_KeyPress);
            this.txtxmostrador.Leave += new System.EventHandler(this.txtxmostrador_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "%Monstrador";
            // 
            // txtpventa2
            // 
            this.txtpventa2.Enabled = false;
            this.txtpventa2.Location = new System.Drawing.Point(350, 220);
            this.txtpventa2.Name = "txtpventa2";
            this.txtpventa2.Size = new System.Drawing.Size(84, 20);
            this.txtpventa2.TabIndex = 18;
            this.txtpventa2.Text = "0";
            this.txtpventa2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpventa2_KeyPress);
            this.txtpventa2.Leave += new System.EventHandler(this.txtpventa2_Leave);
            // 
            // txtpventa1
            // 
            this.txtpventa1.Enabled = false;
            this.txtpventa1.Location = new System.Drawing.Point(188, 220);
            this.txtpventa1.Name = "txtpventa1";
            this.txtpventa1.Size = new System.Drawing.Size(83, 20);
            this.txtpventa1.TabIndex = 17;
            this.txtpventa1.Text = "0";
            this.txtpventa1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpventa1_KeyPress);
            this.txtpventa1.Leave += new System.EventHandler(this.txtpventa1_Leave);
            // 
            // txtpventa
            // 
            this.txtpventa.Enabled = false;
            this.txtpventa.Location = new System.Drawing.Point(20, 219);
            this.txtpventa.Name = "txtpventa";
            this.txtpventa.Size = new System.Drawing.Size(83, 20);
            this.txtpventa.TabIndex = 16;
            this.txtpventa.Text = "0";
            this.txtpventa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpventa_KeyPress);
            this.txtpventa.Leave += new System.EventHandler(this.txtpventa_Leave);
            // 
            // txtpcosto
            // 
            this.txtpcosto.Location = new System.Drawing.Point(350, 174);
            this.txtpcosto.Name = "txtpcosto";
            this.txtpcosto.Size = new System.Drawing.Size(84, 20);
            this.txtpcosto.TabIndex = 15;
            this.txtpcosto.Text = "0";
            this.txtpcosto.TextChanged += new System.EventHandler(this.txtpcosto_TextChanged);
            this.txtpcosto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpcosto_KeyPress);
            this.txtpcosto.Leave += new System.EventHandler(this.txtpcosto_Leave);
            // 
            // txtstact
            // 
            this.txtstact.Location = new System.Drawing.Point(188, 174);
            this.txtstact.Name = "txtstact";
            this.txtstact.Size = new System.Drawing.Size(83, 20);
            this.txtstact.TabIndex = 14;
            this.txtstact.Text = "0";
            this.txtstact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtstact_KeyPress);
            this.txtstact.Layout += new System.Windows.Forms.LayoutEventHandler(this.txtstact_Layout);
            // 
            // txtstmin
            // 
            this.txtstmin.Enabled = false;
            this.txtstmin.Location = new System.Drawing.Point(21, 174);
            this.txtstmin.Name = "txtstmin";
            this.txtstmin.Size = new System.Drawing.Size(83, 20);
            this.txtstmin.TabIndex = 13;
            this.txtstmin.Text = "0";
            this.txtstmin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtstmin_KeyPress);
            this.txtstmin.Leave += new System.EventHandler(this.txtstmin_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(347, 203);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Precio Vta May:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(185, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Precio Vta Min";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Precio Vta Most:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(347, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Precio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(186, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Stock Actual:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Stock Min:";
            // 
            // grpgrabasale
            // 
            this.grpgrabasale.Controls.Add(this.btncancela);
            this.grpgrabasale.Controls.Add(this.btngraba);
            this.grpgrabasale.Location = new System.Drawing.Point(412, 234);
            this.grpgrabasale.Name = "grpgrabasale";
            this.grpgrabasale.Size = new System.Drawing.Size(85, 51);
            this.grpgrabasale.TabIndex = 11;
            this.grpgrabasale.TabStop = false;
            // 
            // btncancela
            // 
            this.btncancela.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btncancela.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btncancela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancela.Image = global::Loundry.Properties.Resources.gsale;
            this.btncancela.Location = new System.Drawing.Point(49, 19);
            this.btncancela.Name = "btncancela";
            this.btncancela.Size = new System.Drawing.Size(30, 23);
            this.btncancela.TabIndex = 20;
            this.toolTip1.SetToolTip(this.btncancela, "Cancela");
            this.btncancela.UseVisualStyleBackColor = true;
            this.btncancela.Click += new System.EventHandler(this.btncancela_Click);
            // 
            // btngraba
            // 
            this.btngraba.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btngraba.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btngraba.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngraba.Image = global::Loundry.Properties.Resources.ggraba;
            this.btngraba.Location = new System.Drawing.Point(13, 19);
            this.btngraba.Name = "btngraba";
            this.btngraba.Size = new System.Drawing.Size(30, 23);
            this.btngraba.TabIndex = 19;
            this.toolTip1.SetToolTip(this.btngraba, "Graba");
            this.btngraba.UseVisualStyleBackColor = true;
            this.btngraba.Click += new System.EventHandler(this.btngraba_Click);
            // 
            // cmbcrubro
            // 
            this.cmbcrubro.FormattingEnabled = true;
            this.cmbcrubro.Location = new System.Drawing.Point(376, 81);
            this.cmbcrubro.Name = "cmbcrubro";
            this.cmbcrubro.Size = new System.Drawing.Size(121, 21);
            this.cmbcrubro.TabIndex = 10;
            this.cmbcrubro.Visible = false;
            this.cmbcrubro.SelectedIndexChanged += new System.EventHandler(this.cmbcrubro_SelectedIndexChanged);
            // 
            // cmbrubro
            // 
            this.cmbrubro.FormattingEnabled = true;
            this.cmbrubro.Location = new System.Drawing.Point(63, 81);
            this.cmbrubro.Name = "cmbrubro";
            this.cmbrubro.Size = new System.Drawing.Size(357, 21);
            this.cmbrubro.TabIndex = 9;
            this.toolTip1.SetToolTip(this.cmbrubro, "Clickear en la flecha para ver los distintos rubros existentes");
            this.cmbrubro.SelectedIndexChanged += new System.EventHandler(this.cmbrubro_SelectedIndexChanged);
            // 
            // txtdetalle
            // 
            this.txtdetalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtdetalle.Location = new System.Drawing.Point(63, 55);
            this.txtdetalle.Name = "txtdetalle";
            this.txtdetalle.Size = new System.Drawing.Size(434, 20);
            this.txtdetalle.TabIndex = 4;
            // 
            // txtcprod
            // 
            this.txtcprod.Location = new System.Drawing.Point(63, 27);
            this.txtcprod.Name = "txtcprod";
            this.txtcprod.Size = new System.Drawing.Size(167, 20);
            this.txtcprod.TabIndex = 3;
            this.txtcprod.Leave += new System.EventHandler(this.txtcodigo_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rubro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Detalle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // dgvproductos
            // 
            this.dgvproductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvproductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproductos.Location = new System.Drawing.Point(10, 19);
            this.dgvproductos.Name = "dgvproductos";
            this.dgvproductos.Size = new System.Drawing.Size(862, 367);
            this.dgvproductos.TabIndex = 1;
            this.dgvproductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvproductos_CellClick);
            this.dgvproductos.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvproductos_DataError);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnbuscar);
            this.groupBox1.Controls.Add(this.btnmodifica);
            this.groupBox1.Controls.Add(this.btnrefresh);
            this.groupBox1.Controls.Add(this.btnnuevo);
            this.groupBox1.Controls.Add(this.btnborra);
            this.groupBox1.Location = new System.Drawing.Point(9, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 56);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acciones";
            // 
            // btnbuscar
            // 
            this.btnbuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnbuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.Image = global::Loundry.Properties.Resources.gbusqueda;
            this.btnbuscar.Location = new System.Drawing.Point(155, 19);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(30, 23);
            this.btnbuscar.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btnbuscar, "Busca");
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btnrefresh
            // 
            this.btnrefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnrefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnrefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrefresh.Image = global::Loundry.Properties.Resources.grefresca;
            this.btnrefresh.Location = new System.Drawing.Point(11, 19);
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
            this.btnborra.Location = new System.Drawing.Point(119, 19);
            this.btnborra.Name = "btnborra";
            this.btnborra.Size = new System.Drawing.Size(30, 23);
            this.btnborra.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnborra, "Borra");
            this.btnborra.UseVisualStyleBackColor = true;
            this.btnborra.Click += new System.EventHandler(this.btnborra_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnnuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnuevo.Image = global::Loundry.Properties.Resources.nuevo;
            this.btnnuevo.Location = new System.Drawing.Point(47, 19);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(30, 23);
            this.btnnuevo.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnnuevo, "Nuevo");
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // btnmodifica
            // 
            this.btnmodifica.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnmodifica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnmodifica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmodifica.Image = global::Loundry.Properties.Resources.modifica;
            this.btnmodifica.Location = new System.Drawing.Point(83, 19);
            this.btnmodifica.Name = "btnmodifica";
            this.btnmodifica.Size = new System.Drawing.Size(30, 23);
            this.btnmodifica.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnmodifica, "Modifica");
            this.btnmodifica.UseVisualStyleBackColor = true;
            this.btnmodifica.Click += new System.EventHandler(this.btnmodifica_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(5, 26);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(917, 534);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(909, 508);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consultas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.grpaccion2);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.labelGradient2);
            this.groupBox3.Controls.Add(this.cmbconsulta);
            this.groupBox3.Controls.Add(this.txtccliente);
            this.groupBox3.Controls.Add(this.lblgrsocial);
            this.groupBox3.Location = new System.Drawing.Point(14, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(873, 76);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Opciones de consulta";
            // 
            // grpaccion2
            // 
            this.grpaccion2.Controls.Add(this.btnimprime);
            this.grpaccion2.Location = new System.Drawing.Point(786, 19);
            this.grpaccion2.Name = "grpaccion2";
            this.grpaccion2.Size = new System.Drawing.Size(77, 45);
            this.grpaccion2.TabIndex = 32;
            this.grpaccion2.TabStop = false;
            this.grpaccion2.Text = "Acciones";
            this.grpaccion2.Visible = false;
            // 
            // btnimprime
            // 
            this.btnimprime.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnimprime.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnimprime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnimprime.Image = global::Loundry.Properties.Resources.gimprime1;
            this.btnimprime.Location = new System.Drawing.Point(23, 15);
            this.btnimprime.Name = "btnimprime";
            this.btnimprime.Size = new System.Drawing.Size(30, 23);
            this.btnimprime.TabIndex = 21;
            this.toolTip1.SetToolTip(this.btnimprime, "Imprime");
            this.btnimprime.UseVisualStyleBackColor = true;
            this.btnimprime.Click += new System.EventHandler(this.btnimprime_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(64, 44);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 13);
            this.label13.TabIndex = 34;
            this.label13.Text = "Consultas";
            // 
            // labelGradient2
            // 
            this.labelGradient2.AutoSize = true;
            this.labelGradient2.BorderStyle = System.Windows.Forms.Border3DStyle.Adjust;
            this.labelGradient2.ForeColor = System.Drawing.Color.White;
            this.labelGradient2.GradientColorOne = System.Drawing.Color.Silver;
            this.labelGradient2.Location = new System.Drawing.Point(61, 19);
            this.labelGradient2.Name = "labelGradient2";
            this.labelGradient2.Size = new System.Drawing.Size(126, 13);
            this.labelGradient2.TabIndex = 29;
            this.labelGradient2.Text = "Lis. Precios Clientes:";
            // 
            // cmbconsulta
            // 
            this.cmbconsulta.FormattingEnabled = true;
            this.cmbconsulta.Items.AddRange(new object[] {
            "",
            "Productos con Stock al límite",
            "Productos s/precio de costo"});
            this.cmbconsulta.Location = new System.Drawing.Point(193, 43);
            this.cmbconsulta.Name = "cmbconsulta";
            this.cmbconsulta.Size = new System.Drawing.Size(302, 21);
            this.cmbconsulta.TabIndex = 33;
            this.cmbconsulta.SelectedIndexChanged += new System.EventHandler(this.cmbconsulta_SelectedIndexChanged);
            // 
            // txtccliente
            // 
            this.txtccliente.Location = new System.Drawing.Point(193, 16);
            this.txtccliente.Name = "txtccliente";
            this.txtccliente.Size = new System.Drawing.Size(52, 20);
            this.txtccliente.TabIndex = 30;
            this.toolTip1.SetToolTip(this.txtccliente, "Dbl click para seleccionar cliente a seguir");
            this.txtccliente.TextChanged += new System.EventHandler(this.txtccliente_TextChanged);
            this.txtccliente.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtccliente_MouseDoubleClick);
            // 
            // lblgrsocial
            // 
            this.lblgrsocial.AutoSize = true;
            this.lblgrsocial.BorderStyle = System.Windows.Forms.Border3DStyle.Adjust;
            this.lblgrsocial.ForeColor = System.Drawing.Color.White;
            this.lblgrsocial.GradientColorOne = System.Drawing.Color.Silver;
            this.lblgrsocial.Location = new System.Drawing.Point(250, 19);
            this.lblgrsocial.Name = "lblgrsocial";
            this.lblgrsocial.Size = new System.Drawing.Size(19, 13);
            this.lblgrsocial.TabIndex = 31;
            this.lblgrsocial.Text = "...";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvconsulta);
            this.groupBox2.Location = new System.Drawing.Point(14, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(873, 421);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "...";
            // 
            // dgvconsulta
            // 
            this.dgvconsulta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvconsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvconsulta.Location = new System.Drawing.Point(6, 19);
            this.dgvconsulta.Name = "dgvconsulta";
            this.dgvconsulta.Size = new System.Drawing.Size(848, 396);
            this.dgvconsulta.TabIndex = 28;
            this.dgvconsulta.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvconsulta_DataError);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.grpAumentoPrecio);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(909, 508);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Actualización de precios por Rubro";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // grpAumentoPrecio
            // 
            this.grpAumentoPrecio.Controls.Add(this.pgBarPrecio);
            this.grpAumentoPrecio.Controls.Add(this.label16);
            this.grpAumentoPrecio.Controls.Add(this.label15);
            this.grpAumentoPrecio.Controls.Add(this.cmbRubroPrecio);
            this.grpAumentoPrecio.Controls.Add(this.btnAumento);
            this.grpAumentoPrecio.Controls.Add(this.cmbCrubroPrecio);
            this.grpAumentoPrecio.Controls.Add(this.txtPcostoaumento);
            this.grpAumentoPrecio.Controls.Add(this.label14);
            this.grpAumentoPrecio.Location = new System.Drawing.Point(98, 44);
            this.grpAumentoPrecio.Name = "grpAumentoPrecio";
            this.grpAumentoPrecio.Size = new System.Drawing.Size(540, 203);
            this.grpAumentoPrecio.TabIndex = 31;
            this.grpAumentoPrecio.TabStop = false;
            this.grpAumentoPrecio.Text = "Actualiza Precio de costo y despues cada producto por su porcentaje de lista";
            // 
            // pgBarPrecio
            // 
            this.pgBarPrecio.Location = new System.Drawing.Point(169, 185);
            this.pgBarPrecio.Name = "pgBarPrecio";
            this.pgBarPrecio.Size = new System.Drawing.Size(357, 10);
            this.pgBarPrecio.TabIndex = 32;
            this.pgBarPrecio.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(208, 100);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(16, 13);
            this.label16.TabIndex = 36;
            this.label16.Text = "%";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(11, 62);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(108, 13);
            this.label15.TabIndex = 35;
            this.label15.Text = "Seleccione Rubro";
            // 
            // cmbRubroPrecio
            // 
            this.cmbRubroPrecio.FormattingEnabled = true;
            this.cmbRubroPrecio.Location = new System.Drawing.Point(169, 54);
            this.cmbRubroPrecio.Name = "cmbRubroPrecio";
            this.cmbRubroPrecio.Size = new System.Drawing.Size(357, 21);
            this.cmbRubroPrecio.TabIndex = 11;
            this.toolTip1.SetToolTip(this.cmbRubroPrecio, "Clickear en la flecha para ver los distintos rubros existentes");
            this.cmbRubroPrecio.SelectedIndexChanged += new System.EventHandler(this.cmbRubroPrecio_SelectedIndexChanged);
            // 
            // btnAumento
            // 
            this.btnAumento.Location = new System.Drawing.Point(451, 156);
            this.btnAumento.Name = "btnAumento";
            this.btnAumento.Size = new System.Drawing.Size(75, 23);
            this.btnAumento.TabIndex = 30;
            this.btnAumento.Text = "Aumento";
            this.btnAumento.UseVisualStyleBackColor = true;
            this.btnAumento.Click += new System.EventHandler(this.btnAumento_Click);
            // 
            // cmbCrubroPrecio
            // 
            this.cmbCrubroPrecio.FormattingEnabled = true;
            this.cmbCrubroPrecio.Location = new System.Drawing.Point(299, 81);
            this.cmbCrubroPrecio.Name = "cmbCrubroPrecio";
            this.cmbCrubroPrecio.Size = new System.Drawing.Size(121, 21);
            this.cmbCrubroPrecio.TabIndex = 12;
            this.cmbCrubroPrecio.Visible = false;
            // 
            // txtPcostoaumento
            // 
            this.txtPcostoaumento.Location = new System.Drawing.Point(169, 97);
            this.txtPcostoaumento.Name = "txtPcostoaumento";
            this.txtPcostoaumento.Size = new System.Drawing.Size(33, 20);
            this.txtPcostoaumento.TabIndex = 28;
            this.txtPcostoaumento.Text = "0";
            this.txtPcostoaumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPcostoaumento_KeyPress);
            this.txtPcostoaumento.Leave += new System.EventHandler(this.txtPcostoaumento_Leave);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(11, 100);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(145, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "% Aumento Precio Costo";
            // 
            // frmproductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Loundry.Properties.Resources.fondologin;
            this.ClientSize = new System.Drawing.Size(929, 601);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.Name = "frmproductos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.frmproductos_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.grpgrilla.ResumeLayout(false);
            this.grpabm.ResumeLayout(false);
            this.grpabm.PerformLayout();
            this.grpgrabasale.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvproductos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grpaccion2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvconsulta)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.grpAumentoPrecio.ResumeLayout(false);
            this.grpAumentoPrecio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem mProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox grpgrilla;
        private System.Windows.Forms.GroupBox grpabm;
        private System.Windows.Forms.GroupBox grpgrabasale;
        private System.Windows.Forms.Button btngraba;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btncancela;
        private System.Windows.Forms.ComboBox cmbcrubro;
        private System.Windows.Forms.ComboBox cmbrubro;
        private System.Windows.Forms.TextBox txtdetalle;
        private System.Windows.Forms.TextBox txtcprod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvproductos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnborra;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Button btnmodifica;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox txtpventa2;
        private System.Windows.Forms.TextBox txtpventa1;
        private System.Windows.Forms.TextBox txtpventa;
        private System.Windows.Forms.TextBox txtpcosto;
        private System.Windows.Forms.TextBox txtstact;
        private System.Windows.Forms.TextBox txtstmin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtxmayorista;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtxminorista;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtxmostrador;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtccliente;
        private LabelGradient labelGradient2;
        private System.Windows.Forms.DataGridView dgvconsulta;
        private LabelGradient lblgrsocial;
        private System.Windows.Forms.GroupBox grpaccion2;
        private System.Windows.Forms.Button btnimprime;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbconsulta;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox cmbCrubroPrecio;
        private System.Windows.Forms.ComboBox cmbRubroPrecio;
        private System.Windows.Forms.Button btnAumento;
        private System.Windows.Forms.TextBox txtPcostoaumento;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox grpAumentoPrecio;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ProgressBar pgBarPrecio;
    }
}