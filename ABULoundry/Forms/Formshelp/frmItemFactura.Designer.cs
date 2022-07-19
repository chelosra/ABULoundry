namespace Loundry
{
    partial class frmItemFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmItemFactura));
            this.btngrabaitem = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lblproductodet = new System.Windows.Forms.Label();
            this.txtpventa = new System.Windows.Forms.TextBox();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.txtcprod = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtxdto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrecioProducto = new System.Windows.Forms.TextBox();
            this.chkiva = new System.Windows.Forms.CheckBox();
            this.chkGrabaLp = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbLP = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAplica = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnProducto = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btngrabaitem
            // 
            this.btngrabaitem.BackColor = System.Drawing.Color.RoyalBlue;
            this.btngrabaitem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btngrabaitem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btngrabaitem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngrabaitem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngrabaitem.ForeColor = System.Drawing.Color.White;
            this.btngrabaitem.Location = new System.Drawing.Point(159, 114);
            this.btngrabaitem.Name = "btngrabaitem";
            this.btngrabaitem.Size = new System.Drawing.Size(144, 43);
            this.btngrabaitem.TabIndex = 18;
            this.btngrabaitem.Text = "Graba Item";
            this.btngrabaitem.UseVisualStyleBackColor = false;
            this.btngrabaitem.Click += new System.EventHandler(this.btngrabaitem_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Precio Venta";
            // 
            // lblproductodet
            // 
            this.lblproductodet.AutoSize = true;
            this.lblproductodet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproductodet.ForeColor = System.Drawing.Color.Coral;
            this.lblproductodet.Location = new System.Drawing.Point(5, 43);
            this.lblproductodet.Name = "lblproductodet";
            this.lblproductodet.Size = new System.Drawing.Size(19, 13);
            this.lblproductodet.TabIndex = 3;
            this.lblproductodet.Text = "...";
            // 
            // txtpventa
            // 
            this.txtpventa.Enabled = false;
            this.txtpventa.Location = new System.Drawing.Point(99, 98);
            this.txtpventa.Name = "txtpventa";
            this.txtpventa.Size = new System.Drawing.Size(54, 20);
            this.txtpventa.TabIndex = 9;
            this.txtpventa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtpventa.TextChanged += new System.EventHandler(this.txtpventa_TextChanged);
            this.txtpventa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpventa_KeyPress);
            // 
            // txtcantidad
            // 
            this.txtcantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcantidad.Location = new System.Drawing.Point(99, 65);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(54, 23);
            this.txtcantidad.TabIndex = 8;
            this.txtcantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtcantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcantidad_KeyPress);
            // 
            // txtcprod
            // 
            this.txtcprod.Enabled = false;
            this.txtcprod.Location = new System.Drawing.Point(75, 13);
            this.txtcprod.Name = "txtcprod";
            this.txtcprod.Size = new System.Drawing.Size(166, 20);
            this.txtcprod.TabIndex = 7;
            this.txtcprod.TextChanged += new System.EventHandler(this.txtcprod_TextChanged);
            this.txtcprod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcprod_KeyDown);
            this.txtcprod.Leave += new System.EventHandler(this.txtcprod_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Cantidad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Producto";
            // 
            // txtxdto
            // 
            this.txtxdto.Location = new System.Drawing.Point(211, 72);
            this.txtxdto.Name = "txtxdto";
            this.txtxdto.Size = new System.Drawing.Size(40, 20);
            this.txtxdto.TabIndex = 33;
            this.txtxdto.Text = "0";
            this.txtxdto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtxdto.Visible = false;
            this.txtxdto.TextChanged += new System.EventHandler(this.txtxdto_TextChanged);
            this.txtxdto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtxdto_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "% dto";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Precio Prod";
            // 
            // txtPrecioProducto
            // 
            this.txtPrecioProducto.Enabled = false;
            this.txtPrecioProducto.Location = new System.Drawing.Point(92, 46);
            this.txtPrecioProducto.Name = "txtPrecioProducto";
            this.txtPrecioProducto.Size = new System.Drawing.Size(54, 20);
            this.txtPrecioProducto.TabIndex = 36;
            this.txtPrecioProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrecioProducto.TextChanged += new System.EventHandler(this.txtPrecioProducto_TextChanged);
            // 
            // chkiva
            // 
            this.chkiva.AutoSize = true;
            this.chkiva.Enabled = false;
            this.chkiva.Location = new System.Drawing.Point(227, 49);
            this.chkiva.Name = "chkiva";
            this.chkiva.Size = new System.Drawing.Size(93, 17);
            this.chkiva.TabIndex = 38;
            this.chkiva.Text = "Aplica IVA x B";
            this.chkiva.UseVisualStyleBackColor = true;
            this.chkiva.Visible = false;
            this.chkiva.CheckedChanged += new System.EventHandler(this.chkiva_CheckedChanged);
            // 
            // chkGrabaLp
            // 
            this.chkGrabaLp.AutoSize = true;
            this.chkGrabaLp.Location = new System.Drawing.Point(200, 111);
            this.chkGrabaLp.Name = "chkGrabaLp";
            this.chkGrabaLp.Size = new System.Drawing.Size(109, 17);
            this.chkGrabaLp.TabIndex = 39;
            this.chkGrabaLp.Text = "Graba Historia LP";
            this.chkGrabaLp.UseVisualStyleBackColor = true;
            this.chkGrabaLp.Visible = false;
            this.chkGrabaLp.CheckedChanged += new System.EventHandler(this.chkGrabaLp_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Lista Precio";
            // 
            // cmbLP
            // 
            this.cmbLP.FormattingEnabled = true;
            this.cmbLP.Items.AddRange(new object[] {
            "Lista 0",
            "Lista 1",
            "Lista 2"});
            this.cmbLP.Location = new System.Drawing.Point(92, 19);
            this.cmbLP.Name = "cmbLP";
            this.cmbLP.Size = new System.Drawing.Size(54, 21);
            this.cmbLP.TabIndex = 41;
            this.cmbLP.SelectedIndexChanged += new System.EventHandler(this.cmbLP_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbLP);
            this.groupBox1.Controls.Add(this.chkGrabaLp);
            this.groupBox1.Controls.Add(this.txtPrecioProducto);
            this.groupBox1.Controls.Add(this.btnAplica);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtxdto);
            this.groupBox1.Controls.Add(this.chkiva);
            this.groupBox1.Location = new System.Drawing.Point(336, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(57, 110);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnAplica
            // 
            this.btnAplica.BackgroundImage = global::Loundry.Properties.Resources.list_check;
            this.btnAplica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAplica.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnAplica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAplica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAplica.Location = new System.Drawing.Point(257, 70);
            this.btnAplica.Name = "btnAplica";
            this.btnAplica.Size = new System.Drawing.Size(30, 23);
            this.btnAplica.TabIndex = 35;
            this.btnAplica.UseVisualStyleBackColor = true;
            this.btnAplica.Visible = false;
            this.btnAplica.Click += new System.EventHandler(this.btnAplica_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Loundry.Properties.Resources.interrogacion;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(309, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 145);
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // btnProducto
            // 
            this.btnProducto.BackgroundImage = global::Loundry.Properties.Resources.menu;
            this.btnProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducto.Location = new System.Drawing.Point(256, 12);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Size = new System.Drawing.Size(47, 44);
            this.btnProducto.TabIndex = 32;
            this.btnProducto.UseVisualStyleBackColor = true;
            this.btnProducto.Click += new System.EventHandler(this.btnProducto_Click);
            // 
            // frmItemFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 160);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnProducto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btngrabaitem);
            this.Controls.Add(this.lblproductodet);
            this.Controls.Add(this.txtcprod);
            this.Controls.Add(this.txtpventa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmItemFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Item Factura";
            this.Load += new System.EventHandler(this.frmItemFactura_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnProducto;
        private System.Windows.Forms.Button btngrabaitem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblproductodet;
        private System.Windows.Forms.TextBox txtpventa;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.TextBox txtcprod;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtxdto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAplica;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrecioProducto;
        private System.Windows.Forms.CheckBox chkiva;
        private System.Windows.Forms.CheckBox chkGrabaLp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbLP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}