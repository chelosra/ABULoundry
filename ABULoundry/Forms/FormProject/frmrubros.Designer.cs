namespace Loundry
{
    partial class frmrubros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmrubros));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.btnborra = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btnmodifica = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.granjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvrubros = new System.Windows.Forms.DataGridView();
            this.grpabm = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtxmayorista = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtxminorista = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtxmostrador = new System.Windows.Forms.TextBox();
            this.grpgrabasale = new System.Windows.Forms.GroupBox();
            this.btngraba = new System.Windows.Forms.Button();
            this.btncancela = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtxdescuento = new System.Windows.Forms.TextBox();
            this.txtdetalle = new System.Windows.Forms.TextBox();
            this.txtcrubro = new System.Windows.Forms.TextBox();
            this.grpgrilla = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrubros)).BeginInit();
            this.grpabm.SuspendLayout();
            this.grpgrabasale.SuspendLayout();
            this.grpgrilla.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnbuscar);
            this.groupBox1.Controls.Add(this.btnrefresh);
            this.groupBox1.Controls.Add(this.btnmodifica);
            this.groupBox1.Controls.Add(this.btnnuevo);
            this.groupBox1.Controls.Add(this.btnborra);
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
            this.btnbuscar.Location = new System.Drawing.Point(145, 18);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(30, 23);
            this.btnbuscar.TabIndex = 7;
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
            this.btnrefresh.Location = new System.Drawing.Point(8, 18);
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
            this.btnborra.Location = new System.Drawing.Point(109, 18);
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
            this.btnnuevo.Location = new System.Drawing.Point(39, 18);
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
            this.btnmodifica.Location = new System.Drawing.Point(73, 18);
            this.btnmodifica.Name = "btnmodifica";
            this.btnmodifica.Size = new System.Drawing.Size(30, 23);
            this.btnmodifica.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnmodifica, "Modifica");
            this.btnmodifica.UseVisualStyleBackColor = true;
            this.btnmodifica.Click += new System.EventHandler(this.btnmodifica_Click);
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.granjaToolStripMenuItem});
            this.menu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(480, 23);
            this.menu.TabIndex = 9;
            this.menu.Text = "menuStrip1";
            // 
            // granjaToolStripMenuItem
            // 
            this.granjaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarToolStripMenuItem});
            this.granjaToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.granjaToolStripMenuItem.MergeIndex = 3;
            this.granjaToolStripMenuItem.Name = "granjaToolStripMenuItem";
            this.granjaToolStripMenuItem.Size = new System.Drawing.Size(56, 19);
            this.granjaToolStripMenuItem.Text = "Rubros";
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // dgvrubros
            // 
            this.dgvrubros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvrubros.Location = new System.Drawing.Point(6, 19);
            this.dgvrubros.Name = "dgvrubros";
            this.dgvrubros.Size = new System.Drawing.Size(380, 297);
            this.dgvrubros.TabIndex = 10;
            this.dgvrubros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvrubros_CellClick);
            this.dgvrubros.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvrubros_DataError);
            // 
            // grpabm
            // 
            this.grpabm.Controls.Add(this.label6);
            this.grpabm.Controls.Add(this.txtxmayorista);
            this.grpabm.Controls.Add(this.label5);
            this.grpabm.Controls.Add(this.txtxminorista);
            this.grpabm.Controls.Add(this.label4);
            this.grpabm.Controls.Add(this.txtxmostrador);
            this.grpabm.Controls.Add(this.grpgrabasale);
            this.grpabm.Controls.Add(this.label3);
            this.grpabm.Controls.Add(this.label2);
            this.grpabm.Controls.Add(this.label1);
            this.grpabm.Controls.Add(this.txtxdescuento);
            this.grpabm.Controls.Add(this.txtdetalle);
            this.grpabm.Controls.Add(this.txtcrubro);
            this.grpabm.Location = new System.Drawing.Point(18, 49);
            this.grpabm.Name = "grpabm";
            this.grpabm.Size = new System.Drawing.Size(343, 218);
            this.grpabm.TabIndex = 11;
            this.grpabm.TabStop = false;
            this.grpabm.Text = "Alta / Modi Rubros";
            this.grpabm.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "% Precio Mayorista";
            this.label6.Visible = false;
            // 
            // txtxmayorista
            // 
            this.txtxmayorista.Location = new System.Drawing.Point(122, 157);
            this.txtxmayorista.Name = "txtxmayorista";
            this.txtxmayorista.Size = new System.Drawing.Size(52, 20);
            this.txtxmayorista.TabIndex = 17;
            this.txtxmayorista.Visible = false;
            this.txtxmayorista.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtxmayorista_KeyPress);
            this.txtxmayorista.Leave += new System.EventHandler(this.txtxmayorista_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "% Precio Minorista";
            this.label5.Visible = false;
            // 
            // txtxminorista
            // 
            this.txtxminorista.Location = new System.Drawing.Point(122, 131);
            this.txtxminorista.Name = "txtxminorista";
            this.txtxminorista.Size = new System.Drawing.Size(52, 20);
            this.txtxminorista.TabIndex = 15;
            this.txtxminorista.Visible = false;
            this.txtxminorista.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtxminorista_KeyPress);
            this.txtxminorista.Leave += new System.EventHandler(this.txtxminorista_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "% Precio Mostrador";
            this.label4.Visible = false;
            // 
            // txtxmostrador
            // 
            this.txtxmostrador.Location = new System.Drawing.Point(122, 99);
            this.txtxmostrador.Name = "txtxmostrador";
            this.txtxmostrador.Size = new System.Drawing.Size(52, 20);
            this.txtxmostrador.TabIndex = 13;
            this.txtxmostrador.Visible = false;
            this.txtxmostrador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtxmostrador_KeyPress);
            this.txtxmostrador.Leave += new System.EventHandler(this.txtxmostrador_Leave);
            // 
            // grpgrabasale
            // 
            this.grpgrabasale.Controls.Add(this.btncancela);
            this.grpgrabasale.Controls.Add(this.btngraba);
            this.grpgrabasale.Location = new System.Drawing.Point(257, 160);
            this.grpgrabasale.Name = "grpgrabasale";
            this.grpgrabasale.Size = new System.Drawing.Size(80, 39);
            this.grpgrabasale.TabIndex = 12;
            this.grpgrabasale.TabStop = false;
            // 
            // btngraba
            // 
            this.btngraba.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btngraba.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btngraba.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngraba.Image = global::Loundry.Properties.Resources.ggraba;
            this.btngraba.Location = new System.Drawing.Point(0, 10);
            this.btngraba.Name = "btngraba";
            this.btngraba.Size = new System.Drawing.Size(30, 23);
            this.btngraba.TabIndex = 7;
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
            this.btncancela.Location = new System.Drawing.Point(36, 10);
            this.btncancela.Name = "btncancela";
            this.btncancela.Size = new System.Drawing.Size(30, 23);
            this.btncancela.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btncancela, "Cancela");
            this.btncancela.UseVisualStyleBackColor = true;
            this.btncancela.Click += new System.EventHandler(this.btncancela_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "% Descuento";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Detalle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Código";
            // 
            // txtxdescuento
            // 
            this.txtxdescuento.Location = new System.Drawing.Point(105, 68);
            this.txtxdescuento.Name = "txtxdescuento";
            this.txtxdescuento.Size = new System.Drawing.Size(52, 20);
            this.txtxdescuento.TabIndex = 2;
            this.txtxdescuento.Visible = false;
            // 
            // txtdetalle
            // 
            this.txtdetalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtdetalle.Location = new System.Drawing.Point(105, 42);
            this.txtdetalle.Name = "txtdetalle";
            this.txtdetalle.Size = new System.Drawing.Size(176, 20);
            this.txtdetalle.TabIndex = 1;
            // 
            // txtcrubro
            // 
            this.txtcrubro.Location = new System.Drawing.Point(105, 16);
            this.txtcrubro.Name = "txtcrubro";
            this.txtcrubro.Size = new System.Drawing.Size(52, 20);
            this.txtcrubro.TabIndex = 0;
            this.txtcrubro.Leave += new System.EventHandler(this.txtcrubro_Leave);
            // 
            // grpgrilla
            // 
            this.grpgrilla.Controls.Add(this.grpabm);
            this.grpgrilla.Controls.Add(this.dgvrubros);
            this.grpgrilla.Location = new System.Drawing.Point(20, 59);
            this.grpgrilla.Name = "grpgrilla";
            this.grpgrilla.Size = new System.Drawing.Size(403, 330);
            this.grpgrilla.TabIndex = 12;
            this.grpgrilla.TabStop = false;
            this.grpgrilla.Text = "Rubros";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 26);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(453, 440);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grpgrilla);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(445, 414);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "A/B/M Rubros";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // frmrubros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Loundry.Properties.Resources.fondologin;
            this.ClientSize = new System.Drawing.Size(480, 479);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.Name = "frmrubros";
            this.Text = "Rubros";
            this.Load += new System.EventHandler(this.frmrubros_Load);
            this.groupBox1.ResumeLayout(false);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrubros)).EndInit();
            this.grpabm.ResumeLayout(false);
            this.grpabm.PerformLayout();
            this.grpgrabasale.ResumeLayout(false);
            this.grpgrilla.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnborra;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Button btnmodifica;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem granjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvrubros;
        private System.Windows.Forms.GroupBox grpabm;
        private System.Windows.Forms.TextBox txtxdescuento;
        private System.Windows.Forms.TextBox txtdetalle;
        private System.Windows.Forms.TextBox txtcrubro;
        private System.Windows.Forms.Button btngraba;
        private System.Windows.Forms.Button btncancela;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpgrabasale;
        private System.Windows.Forms.GroupBox grpgrilla;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtxmayorista;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtxminorista;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtxmostrador;
    }
}