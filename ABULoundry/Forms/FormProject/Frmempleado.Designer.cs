namespace Loundry
{
    partial class Frmempleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmempleado));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.mEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grpgrilla = new System.Windows.Forms.GroupBox();
            this.grpabm = new System.Windows.Forms.GroupBox();
            this.txtcargo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.txtcelular = new System.Windows.Forms.TextBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grpgrabasale = new System.Windows.Forms.GroupBox();
            this.btngraba = new System.Windows.Forms.Button();
            this.btncancela = new System.Windows.Forms.Button();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.txtcempl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvempleado = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btnborra = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.btnmodifica = new System.Windows.Forms.Button();
            this.menu.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grpgrilla.SuspendLayout();
            this.grpabm.SuspendLayout();
            this.grpgrabasale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvempleado)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mEmpleadoToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(944, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            this.menu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // mEmpleadoToolStripMenuItem
            // 
            this.mEmpleadoToolStripMenuItem.Name = "mEmpleadoToolStripMenuItem";
            this.mEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.mEmpleadoToolStripMenuItem.Text = "mEmpleado";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(917, 534);
            this.tabControl1.TabIndex = 12;
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
            this.tabPage1.Text = "A/B/M Empleados";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // grpgrilla
            // 
            this.grpgrilla.Controls.Add(this.grpabm);
            this.grpgrilla.Controls.Add(this.dgvempleado);
            this.grpgrilla.Location = new System.Drawing.Point(9, 59);
            this.grpgrilla.Name = "grpgrilla";
            this.grpgrilla.Size = new System.Drawing.Size(885, 417);
            this.grpgrilla.TabIndex = 8;
            this.grpgrilla.TabStop = false;
            this.grpgrilla.Text = "Empleados";
            // 
            // grpabm
            // 
            this.grpabm.Controls.Add(this.txtcargo);
            this.grpabm.Controls.Add(this.label5);
            this.grpabm.Controls.Add(this.txtmail);
            this.grpabm.Controls.Add(this.txtcelular);
            this.grpabm.Controls.Add(this.txttelefono);
            this.grpabm.Controls.Add(this.txtnombre);
            this.grpabm.Controls.Add(this.label7);
            this.grpabm.Controls.Add(this.label6);
            this.grpabm.Controls.Add(this.label4);
            this.grpabm.Controls.Add(this.label3);
            this.grpabm.Controls.Add(this.grpgrabasale);
            this.grpabm.Controls.Add(this.txtapellido);
            this.grpabm.Controls.Add(this.txtcempl);
            this.grpabm.Controls.Add(this.label2);
            this.grpabm.Controls.Add(this.label1);
            this.grpabm.Location = new System.Drawing.Point(177, 95);
            this.grpabm.Name = "grpabm";
            this.grpabm.Size = new System.Drawing.Size(503, 248);
            this.grpabm.TabIndex = 2;
            this.grpabm.TabStop = false;
            this.grpabm.Text = "ALTA / MODIF de empleados";
            this.grpabm.Visible = false;
            // 
            // txtcargo
            // 
            this.txtcargo.Enabled = false;
            this.txtcargo.Location = new System.Drawing.Point(63, 206);
            this.txtcargo.Name = "txtcargo";
            this.txtcargo.Size = new System.Drawing.Size(65, 20);
            this.txtcargo.TabIndex = 17;
            this.txtcargo.Text = "CAJERO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Cargo";
            // 
            // txtmail
            // 
            this.txtmail.Location = new System.Drawing.Point(57, 167);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(250, 20);
            this.txtmail.TabIndex = 9;
            // 
            // txtcelular
            // 
            this.txtcelular.Location = new System.Drawing.Point(184, 135);
            this.txtcelular.Name = "txtcelular";
            this.txtcelular.Size = new System.Drawing.Size(138, 20);
            this.txtcelular.TabIndex = 8;
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(20, 135);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(138, 20);
            this.txttelefono.TabIndex = 6;
            // 
            // txtnombre
            // 
            this.txtnombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnombre.Location = new System.Drawing.Point(93, 85);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(260, 20);
            this.txtnombre.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(181, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Celular:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Teléfono:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nombre:";
            // 
            // grpgrabasale
            // 
            this.grpgrabasale.Controls.Add(this.btngraba);
            this.grpgrabasale.Controls.Add(this.btncancela);
            this.grpgrabasale.Location = new System.Drawing.Point(392, 183);
            this.grpgrabasale.Name = "grpgrabasale";
            this.grpgrabasale.Size = new System.Drawing.Size(85, 59);
            this.grpgrabasale.TabIndex = 11;
            this.grpgrabasale.TabStop = false;
            // 
            // btngraba
            // 
            this.btngraba.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btngraba.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btngraba.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngraba.Image = global::Loundry.Properties.Resources.ggraba;
            this.btngraba.Location = new System.Drawing.Point(13, 16);
            this.btngraba.Name = "btngraba";
            this.btngraba.Size = new System.Drawing.Size(30, 23);
            this.btngraba.TabIndex = 10;
            this.btngraba.UseVisualStyleBackColor = true;
            this.btngraba.Click += new System.EventHandler(this.btngraba_Click);
            // 
            // btncancela
            // 
            this.btncancela.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btncancela.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btncancela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancela.Image = global::Loundry.Properties.Resources.gsale;
            this.btncancela.Location = new System.Drawing.Point(49, 16);
            this.btncancela.Name = "btncancela";
            this.btncancela.Size = new System.Drawing.Size(30, 23);
            this.btncancela.TabIndex = 11;
            this.btncancela.UseVisualStyleBackColor = true;
            this.btncancela.Click += new System.EventHandler(this.btncancela_Click);
            // 
            // txtapellido
            // 
            this.txtapellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtapellido.Location = new System.Drawing.Point(100, 55);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(260, 20);
            this.txtapellido.TabIndex = 4;
            // 
            // txtcempl
            // 
            this.txtcempl.Location = new System.Drawing.Point(63, 27);
            this.txtcempl.Name = "txtcempl";
            this.txtcempl.Size = new System.Drawing.Size(120, 20);
            this.txtcempl.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido:";
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
            // dgvempleado
            // 
            this.dgvempleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvempleado.Location = new System.Drawing.Point(10, 31);
            this.dgvempleado.Name = "dgvempleado";
            this.dgvempleado.Size = new System.Drawing.Size(862, 367);
            this.dgvempleado.TabIndex = 1;
            this.dgvempleado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvempleado_CellClick);
            this.dgvempleado.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvempleado_DataError);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnbuscar);
            this.groupBox1.Controls.Add(this.btnmodifica);
            this.groupBox1.Controls.Add(this.btnborra);
            this.groupBox1.Controls.Add(this.btnrefresh);
            this.groupBox1.Controls.Add(this.btnnuevo);
            this.groupBox1.Location = new System.Drawing.Point(15, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(196, 47);
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
            this.btnbuscar.Location = new System.Drawing.Point(156, 18);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(30, 23);
            this.btnbuscar.TabIndex = 9;
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btnborra
            // 
            this.btnborra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnborra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnborra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnborra.Image = global::Loundry.Properties.Resources.borra;
            this.btnborra.Location = new System.Drawing.Point(120, 18);
            this.btnborra.Name = "btnborra";
            this.btnborra.Size = new System.Drawing.Size(30, 23);
            this.btnborra.TabIndex = 6;
            this.btnborra.UseVisualStyleBackColor = true;
            this.btnborra.Click += new System.EventHandler(this.btnborra_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnnuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnuevo.Image = global::Loundry.Properties.Resources.nuevo;
            this.btnnuevo.Location = new System.Drawing.Point(45, 18);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(30, 23);
            this.btnnuevo.TabIndex = 4;
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // btnrefresh
            // 
            this.btnrefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnrefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnrefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrefresh.Image = global::Loundry.Properties.Resources.grefresca;
            this.btnrefresh.Location = new System.Drawing.Point(9, 18);
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
            this.btnmodifica.Location = new System.Drawing.Point(83, 18);
            this.btnmodifica.Name = "btnmodifica";
            this.btnmodifica.Size = new System.Drawing.Size(30, 23);
            this.btnmodifica.TabIndex = 5;
            this.btnmodifica.UseVisualStyleBackColor = true;
            this.btnmodifica.Click += new System.EventHandler(this.btnmodifica_Click);
            // 
            // Frmempleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Loundry.Properties.Resources.fondologin;
            this.ClientSize = new System.Drawing.Size(944, 559);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.Name = "Frmempleado";
            this.Text = "Empleado";
            this.Load += new System.EventHandler(this.Frmempleado_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.grpgrilla.ResumeLayout(false);
            this.grpabm.ResumeLayout(false);
            this.grpabm.PerformLayout();
            this.grpgrabasale.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvempleado)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem mEmpleadoToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox grpgrilla;
        private System.Windows.Forms.GroupBox grpabm;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.TextBox txtcelular;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpgrabasale;
        private System.Windows.Forms.Button btngraba;
        private System.Windows.Forms.Button btncancela;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.TextBox txtcempl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvempleado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btnborra;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Button btnmodifica;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.TextBox txtcargo;
        private System.Windows.Forms.Label label5;
    }
}