namespace Loundry
{
    partial class frmmovimiento
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
            this.grpgrilla = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.dgvmovimientos = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvconsulta = new System.Windows.Forms.DataGridView();
            this.txttotalventa = new System.Windows.Forms.TextBox();
            this.labelGradient3 = new Loundry.LabelGradient();
            this.txtccliente = new System.Windows.Forms.TextBox();
            this.txtcprod = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbventas = new System.Windows.Forms.ComboBox();
            this.lblgcliente = new Loundry.LabelGradient();
            this.lblgproducto = new Loundry.LabelGradient();
            this.labelGradient2 = new Loundry.LabelGradient();
            this.labelGradient1 = new Loundry.LabelGradient();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpfechhasta = new System.Windows.Forms.DateTimePicker();
            this.dtpfechdesde = new System.Windows.Forms.DateTimePicker();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grpgrilla.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmovimientos)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvconsulta)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(10, 67);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(949, 440);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grpgrilla);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(941, 414);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Movimientos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // grpgrilla
            // 
            this.grpgrilla.Controls.Add(this.groupBox1);
            this.grpgrilla.Controls.Add(this.dgvmovimientos);
            this.grpgrilla.Location = new System.Drawing.Point(20, 20);
            this.grpgrilla.Name = "grpgrilla";
            this.grpgrilla.Size = new System.Drawing.Size(905, 381);
            this.grpgrilla.TabIndex = 12;
            this.grpgrilla.TabStop = false;
            this.grpgrilla.Text = "Movimientos";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnrefresh);
            this.groupBox1.Location = new System.Drawing.Point(6, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(65, 47);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acciones";
            // 
            // btnrefresh
            // 
            this.btnrefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnrefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnrefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrefresh.Image = global::Loundry.Properties.Resources.grefresca;
            this.btnrefresh.Location = new System.Drawing.Point(15, 18);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(30, 23);
            this.btnrefresh.TabIndex = 3;
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click_1);
            // 
            // dgvmovimientos
            // 
            this.dgvmovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmovimientos.Location = new System.Drawing.Point(6, 63);
            this.dgvmovimientos.Name = "dgvmovimientos";
            this.dgvmovimientos.Size = new System.Drawing.Size(893, 308);
            this.dgvmovimientos.TabIndex = 10;
            this.dgvmovimientos.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvmovimientos_DataError);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.txtccliente);
            this.tabPage2.Controls.Add(this.txtcprod);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.cmbventas);
            this.tabPage2.Controls.Add(this.lblgcliente);
            this.tabPage2.Controls.Add(this.lblgproducto);
            this.tabPage2.Controls.Add(this.labelGradient2);
            this.tabPage2.Controls.Add(this.labelGradient1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(941, 414);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consultas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvconsulta);
            this.groupBox3.Controls.Add(this.txttotalventa);
            this.groupBox3.Controls.Add(this.labelGradient3);
            this.groupBox3.Location = new System.Drawing.Point(21, 86);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(885, 309);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "...";
            // 
            // dgvconsulta
            // 
            this.dgvconsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvconsulta.Location = new System.Drawing.Point(10, 19);
            this.dgvconsulta.Name = "dgvconsulta";
            this.dgvconsulta.Size = new System.Drawing.Size(866, 258);
            this.dgvconsulta.TabIndex = 0;
            this.dgvconsulta.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvconsulta_DataError);
            // 
            // txttotalventa
            // 
            this.txttotalventa.Location = new System.Drawing.Point(774, 283);
            this.txttotalventa.Name = "txttotalventa";
            this.txttotalventa.Size = new System.Drawing.Size(100, 20);
            this.txttotalventa.TabIndex = 28;
            this.txttotalventa.Text = "0";
            this.txttotalventa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelGradient3
            // 
            this.labelGradient3.AutoSize = true;
            this.labelGradient3.BorderStyle = System.Windows.Forms.Border3DStyle.Adjust;
            this.labelGradient3.ForeColor = System.Drawing.Color.White;
            this.labelGradient3.GradientColorOne = System.Drawing.Color.Silver;
            this.labelGradient3.Location = new System.Drawing.Point(692, 290);
            this.labelGradient3.Name = "labelGradient3";
            this.labelGradient3.Size = new System.Drawing.Size(76, 13);
            this.labelGradient3.TabIndex = 29;
            this.labelGradient3.Text = "Total Vendido:";
            // 
            // txtccliente
            // 
            this.txtccliente.Location = new System.Drawing.Point(202, 60);
            this.txtccliente.Name = "txtccliente";
            this.txtccliente.Size = new System.Drawing.Size(52, 20);
            this.txtccliente.TabIndex = 27;
            this.toolTip1.SetToolTip(this.txtccliente, "Dbl click para seleccionar cliente a seguir");
            this.txtccliente.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtccliente_MouseDoubleClick);
            // 
            // txtcprod
            // 
            this.txtcprod.ForeColor = System.Drawing.Color.Black;
            this.txtcprod.Location = new System.Drawing.Point(175, 34);
            this.txtcprod.Name = "txtcprod";
            this.txtcprod.Size = new System.Drawing.Size(145, 20);
            this.txtcprod.TabIndex = 24;
            this.toolTip1.SetToolTip(this.txtcprod, "Doble click para seleccionar un producto a seguir");
            this.txtcprod.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtcprod_MouseDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Ventas";
            // 
            // cmbventas
            // 
            this.cmbventas.FormattingEnabled = true;
            this.cmbventas.Items.AddRange(new object[] {
            "",
            "Ventas por rubros",
            "Ventas por productos",
            "Ventas por cliente",
            "Venta Gral / Ganancia"});
            this.cmbventas.Location = new System.Drawing.Point(92, 7);
            this.cmbventas.Name = "cmbventas";
            this.cmbventas.Size = new System.Drawing.Size(238, 21);
            this.cmbventas.TabIndex = 21;
            this.cmbventas.SelectedIndexChanged += new System.EventHandler(this.cmbventas_SelectedIndexChanged);
            // 
            // lblgcliente
            // 
            this.lblgcliente.AutoSize = true;
            this.lblgcliente.BorderStyle = System.Windows.Forms.Border3DStyle.Adjust;
            this.lblgcliente.ForeColor = System.Drawing.Color.White;
            this.lblgcliente.GradientColorOne = System.Drawing.Color.Silver;
            this.lblgcliente.Location = new System.Drawing.Point(272, 67);
            this.lblgcliente.Name = "lblgcliente";
            this.lblgcliente.Size = new System.Drawing.Size(16, 13);
            this.lblgcliente.TabIndex = 31;
            this.lblgcliente.Text = "...";
            // 
            // lblgproducto
            // 
            this.lblgproducto.AutoSize = true;
            this.lblgproducto.BorderStyle = System.Windows.Forms.Border3DStyle.Adjust;
            this.lblgproducto.ForeColor = System.Drawing.Color.White;
            this.lblgproducto.GradientColorOne = System.Drawing.Color.Silver;
            this.lblgproducto.Location = new System.Drawing.Point(342, 41);
            this.lblgproducto.Name = "lblgproducto";
            this.lblgproducto.Size = new System.Drawing.Size(16, 13);
            this.lblgproducto.TabIndex = 30;
            this.lblgproducto.Text = "...";
            // 
            // labelGradient2
            // 
            this.labelGradient2.AutoSize = true;
            this.labelGradient2.BorderStyle = System.Windows.Forms.Border3DStyle.Adjust;
            this.labelGradient2.ForeColor = System.Drawing.Color.White;
            this.labelGradient2.GradientColorOne = System.Drawing.Color.Silver;
            this.labelGradient2.Location = new System.Drawing.Point(44, 67);
            this.labelGradient2.Name = "labelGradient2";
            this.labelGradient2.Size = new System.Drawing.Size(148, 13);
            this.labelGradient2.TabIndex = 26;
            this.labelGradient2.Text = "Productos vendidos a Cliente:";
            // 
            // labelGradient1
            // 
            this.labelGradient1.AutoSize = true;
            this.labelGradient1.BorderStyle = System.Windows.Forms.Border3DStyle.Adjust;
            this.labelGradient1.ForeColor = System.Drawing.Color.White;
            this.labelGradient1.GradientColorOne = System.Drawing.Color.Silver;
            this.labelGradient1.Location = new System.Drawing.Point(45, 41);
            this.labelGradient1.Name = "labelGradient1";
            this.labelGradient1.Size = new System.Drawing.Size(122, 13);
            this.labelGradient1.TabIndex = 25;
            this.labelGradient1.Text = "Movimiento de Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(423, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Fecha Hasta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Fecha Desde";
            // 
            // dtpfechhasta
            // 
            this.dtpfechhasta.Location = new System.Drawing.Point(500, 19);
            this.dtpfechhasta.Name = "dtpfechhasta";
            this.dtpfechhasta.Size = new System.Drawing.Size(238, 20);
            this.dtpfechhasta.TabIndex = 14;
            // 
            // dtpfechdesde
            // 
            this.dtpfechdesde.Location = new System.Drawing.Point(152, 19);
            this.dtpfechdesde.Name = "dtpfechdesde";
            this.dtpfechdesde.Size = new System.Drawing.Size(238, 20);
            this.dtpfechdesde.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dtpfechhasta);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dtpfechdesde);
            this.groupBox2.Location = new System.Drawing.Point(14, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(941, 57);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rango de fechas";
            // 
            // frmmovimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 519);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmmovimiento";
            this.Text = "Movimientos";
            this.Load += new System.EventHandler(this.frmmovimiento_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.grpgrilla.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvmovimientos)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvconsulta)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox grpgrilla;
        private System.Windows.Forms.DataGridView dgvmovimientos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpfechhasta;
        private System.Windows.Forms.DateTimePicker dtpfechdesde;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvconsulta;
        private System.Windows.Forms.ComboBox cmbventas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcprod;
        private System.Windows.Forms.TextBox txtccliente;
        private LabelGradient labelGradient2;
        private LabelGradient labelGradient1;
        private System.Windows.Forms.ToolTip toolTip1;
        private LabelGradient labelGradient3;
        private System.Windows.Forms.TextBox txttotalventa;
        private LabelGradient lblgproducto;
        private LabelGradient lblgcliente;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnrefresh;
    }
}