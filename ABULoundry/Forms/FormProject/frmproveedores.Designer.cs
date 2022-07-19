namespace Loundry
{
    partial class frmproveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmproveedores));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btngraba = new System.Windows.Forms.Button();
            this.btncancela = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btnborra = new System.Windows.Forms.Button();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.btnmodifica = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grpgrilla = new System.Windows.Forms.GroupBox();
            this.grpabm = new System.Windows.Forms.GroupBox();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.txtcelular = new System.Windows.Forms.TextBox();
            this.txtfax = new System.Windows.Forms.TextBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.txtcontacto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grpgrabasale = new System.Windows.Forms.GroupBox();
            this.txtrsocial = new System.Windows.Forms.TextBox();
            this.txtcprov = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvproveedor = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.mProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grpgrilla.SuspendLayout();
            this.grpabm.SuspendLayout();
            this.grpgrabasale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproveedor)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btngraba
            // 
            this.btngraba.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btngraba.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btngraba.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngraba.Image = global::Loundry.Properties.Resources.ggraba;
            this.btngraba.Location = new System.Drawing.Point(13, 9);
            this.btngraba.Name = "btngraba";
            this.btngraba.Size = new System.Drawing.Size(30, 23);
            this.btngraba.TabIndex = 10;
            this.toolTip1.SetToolTip(this.btngraba, "Graba");
            this.btngraba.UseVisualStyleBackColor = true;
            this.btngraba.Click += new System.EventHandler(this.btngraba_Click);
            // 
            // btncancela
            // 
            this.btncancela.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btncancela.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btncancela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancela.Image = global::Loundry.Properties.Resources.gsale;
            this.btncancela.Location = new System.Drawing.Point(49, 9);
            this.btncancela.Name = "btncancela";
            this.btncancela.Size = new System.Drawing.Size(30, 23);
            this.btncancela.TabIndex = 11;
            this.toolTip1.SetToolTip(this.btncancela, "Cancela");
            this.btncancela.UseVisualStyleBackColor = true;
            this.btncancela.Click += new System.EventHandler(this.btncancela_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnbuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.Image = global::Loundry.Properties.Resources.gbusqueda;
            this.btnbuscar.Location = new System.Drawing.Point(159, 18);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(30, 23);
            this.btnbuscar.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btnbuscar, "Busca");
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btnborra
            // 
            this.btnborra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnborra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnborra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnborra.Image = global::Loundry.Properties.Resources.borra;
            this.btnborra.Location = new System.Drawing.Point(123, 18);
            this.btnborra.Name = "btnborra";
            this.btnborra.Size = new System.Drawing.Size(30, 23);
            this.btnborra.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnborra, "Borra");
            this.btnborra.UseVisualStyleBackColor = true;
            this.btnborra.Click += new System.EventHandler(this.btnborra_Click);
            // 
            // btnrefresh
            // 
            this.btnrefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnrefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnrefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrefresh.Image = global::Loundry.Properties.Resources.grefresca;
            this.btnrefresh.Location = new System.Drawing.Point(12, 18);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(30, 23);
            this.btnrefresh.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnrefresh, "Actualiza");
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // btnmodifica
            // 
            this.btnmodifica.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnmodifica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnmodifica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmodifica.Image = global::Loundry.Properties.Resources.modifica;
            this.btnmodifica.Location = new System.Drawing.Point(86, 18);
            this.btnmodifica.Name = "btnmodifica";
            this.btnmodifica.Size = new System.Drawing.Size(30, 23);
            this.btnmodifica.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnmodifica, "Modifica");
            this.btnmodifica.UseVisualStyleBackColor = true;
            this.btnmodifica.Click += new System.EventHandler(this.btnmodifica_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnnuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnuevo.Image = global::Loundry.Properties.Resources.nuevo;
            this.btnnuevo.Location = new System.Drawing.Point(48, 18);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(30, 23);
            this.btnnuevo.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnnuevo, "Nuevo");
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 26);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(917, 534);
            this.tabControl1.TabIndex = 11;
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
            this.tabPage1.Text = "A/B/M Proveedores";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // grpgrilla
            // 
            this.grpgrilla.Controls.Add(this.grpabm);
            this.grpgrilla.Controls.Add(this.dgvproveedor);
            this.grpgrilla.Location = new System.Drawing.Point(9, 59);
            this.grpgrilla.Name = "grpgrilla";
            this.grpgrilla.Size = new System.Drawing.Size(885, 417);
            this.grpgrilla.TabIndex = 8;
            this.grpgrilla.TabStop = false;
            this.grpgrilla.Text = "Proveedores";
            // 
            // grpabm
            // 
            this.grpabm.Controls.Add(this.txtmail);
            this.grpabm.Controls.Add(this.txtcelular);
            this.grpabm.Controls.Add(this.txtfax);
            this.grpabm.Controls.Add(this.txttelefono);
            this.grpabm.Controls.Add(this.txtcontacto);
            this.grpabm.Controls.Add(this.label7);
            this.grpabm.Controls.Add(this.label6);
            this.grpabm.Controls.Add(this.label5);
            this.grpabm.Controls.Add(this.label4);
            this.grpabm.Controls.Add(this.label3);
            this.grpabm.Controls.Add(this.grpgrabasale);
            this.grpabm.Controls.Add(this.txtrsocial);
            this.grpabm.Controls.Add(this.txtcprov);
            this.grpabm.Controls.Add(this.label2);
            this.grpabm.Controls.Add(this.label1);
            this.grpabm.Location = new System.Drawing.Point(177, 95);
            this.grpabm.Name = "grpabm";
            this.grpabm.Size = new System.Drawing.Size(503, 248);
            this.grpabm.TabIndex = 2;
            this.grpabm.TabStop = false;
            this.grpabm.Text = "ALTA / MODIF de proveedores";
            this.grpabm.Visible = false;
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
            this.txtcelular.Location = new System.Drawing.Point(339, 135);
            this.txtcelular.Name = "txtcelular";
            this.txtcelular.Size = new System.Drawing.Size(138, 20);
            this.txtcelular.TabIndex = 8;
            // 
            // txtfax
            // 
            this.txtfax.Location = new System.Drawing.Point(182, 135);
            this.txtfax.Name = "txtfax";
            this.txtfax.Size = new System.Drawing.Size(138, 20);
            this.txtfax.TabIndex = 7;
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(20, 135);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(138, 20);
            this.txttelefono.TabIndex = 6;
            // 
            // txtcontacto
            // 
            this.txtcontacto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcontacto.Location = new System.Drawing.Point(93, 85);
            this.txtcontacto.Name = "txtcontacto";
            this.txtcontacto.Size = new System.Drawing.Size(260, 20);
            this.txtcontacto.TabIndex = 5;
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
            this.label6.Location = new System.Drawing.Point(336, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Celular:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(179, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Fax:";
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
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Contacto:";
            // 
            // grpgrabasale
            // 
            this.grpgrabasale.Controls.Add(this.btngraba);
            this.grpgrabasale.Controls.Add(this.btncancela);
            this.grpgrabasale.Location = new System.Drawing.Point(392, 183);
            this.grpgrabasale.Name = "grpgrabasale";
            this.grpgrabasale.Size = new System.Drawing.Size(85, 41);
            this.grpgrabasale.TabIndex = 11;
            this.grpgrabasale.TabStop = false;
            // 
            // txtrsocial
            // 
            this.txtrsocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtrsocial.Location = new System.Drawing.Point(100, 55);
            this.txtrsocial.Name = "txtrsocial";
            this.txtrsocial.Size = new System.Drawing.Size(260, 20);
            this.txtrsocial.TabIndex = 4;
            // 
            // txtcprov
            // 
            this.txtcprov.Location = new System.Drawing.Point(63, 27);
            this.txtcprov.Name = "txtcprov";
            this.txtcprov.Size = new System.Drawing.Size(120, 20);
            this.txtcprov.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Razón Social";
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
            // dgvproveedor
            // 
            this.dgvproveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproveedor.Location = new System.Drawing.Point(10, 31);
            this.dgvproveedor.Name = "dgvproveedor";
            this.dgvproveedor.Size = new System.Drawing.Size(862, 367);
            this.dgvproveedor.TabIndex = 1;
            this.dgvproveedor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvproveedor_CellClick);
            this.dgvproveedor.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvproveedor_DataError);
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
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mProductoToolStripMenuItem});
            this.menu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(939, 23);
            this.menu.TabIndex = 10;
            this.menu.Text = "menuStrip1";
            // 
            // mProductoToolStripMenuItem
            // 
            this.mProductoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarToolStripMenuItem});
            this.mProductoToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.mProductoToolStripMenuItem.MergeIndex = 3;
            this.mProductoToolStripMenuItem.Name = "mProductoToolStripMenuItem";
            this.mProductoToolStripMenuItem.Size = new System.Drawing.Size(84, 19);
            this.mProductoToolStripMenuItem.Text = "Proveedores";
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // frmproveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Loundry.Properties.Resources.fondologin;
            this.ClientSize = new System.Drawing.Size(939, 587);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmproveedores";
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.frmproveedores_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.grpgrilla.ResumeLayout(false);
            this.grpabm.ResumeLayout(false);
            this.grpabm.PerformLayout();
            this.grpgrabasale.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvproveedor)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btngraba;
        private System.Windows.Forms.Button btncancela;
        private System.Windows.Forms.Button btnborra;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Button btnmodifica;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox grpgrilla;
        private System.Windows.Forms.GroupBox grpabm;
        private System.Windows.Forms.GroupBox grpgrabasale;
        private System.Windows.Forms.TextBox txtrsocial;
        private System.Windows.Forms.TextBox txtcprov;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvproveedor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem mProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.TextBox txtcelular;
        private System.Windows.Forms.TextBox txtfax;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.TextBox txtcontacto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}