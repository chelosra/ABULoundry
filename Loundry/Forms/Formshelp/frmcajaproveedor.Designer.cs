namespace Loundry
{
    partial class frmcajaproveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcajaproveedor));
            this.grpclientes = new System.Windows.Forms.GroupBox();
            this.dgvproveedor = new System.Windows.Forms.DataGridView();
            this.grpgrabasale = new System.Windows.Forms.GroupBox();
            this.btnbuscaclie = new System.Windows.Forms.Button();
            this.btnrefreshclie = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.grpclientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproveedor)).BeginInit();
            this.grpgrabasale.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpclientes
            // 
            this.grpclientes.Controls.Add(this.dgvproveedor);
            this.grpclientes.Controls.Add(this.grpgrabasale);
            this.grpclientes.Location = new System.Drawing.Point(3, 12);
            this.grpclientes.Name = "grpclientes";
            this.grpclientes.Size = new System.Drawing.Size(655, 278);
            this.grpclientes.TabIndex = 7;
            this.grpclientes.TabStop = false;
            this.grpclientes.Text = "Proveedores";
            this.toolTip1.SetToolTip(this.grpclientes, "Doble click para seleccionar proveedor");
            // 
            // dgvproveedor
            // 
            this.dgvproveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproveedor.Location = new System.Drawing.Point(6, 67);
            this.dgvproveedor.Name = "dgvproveedor";
            this.dgvproveedor.Size = new System.Drawing.Size(643, 205);
            this.dgvproveedor.TabIndex = 13;
            this.toolTip1.SetToolTip(this.dgvproveedor, "Doble Click para Seleccionar");
            this.dgvproveedor.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvproveedor_CellMouseDoubleClick);
            // 
            // grpgrabasale
            // 
            this.grpgrabasale.Controls.Add(this.btnbuscaclie);
            this.grpgrabasale.Controls.Add(this.btnrefreshclie);
            this.grpgrabasale.Location = new System.Drawing.Point(6, 17);
            this.grpgrabasale.Name = "grpgrabasale";
            this.grpgrabasale.Size = new System.Drawing.Size(90, 44);
            this.grpgrabasale.TabIndex = 12;
            this.grpgrabasale.TabStop = false;
            // 
            // btnbuscaclie
            // 
            this.btnbuscaclie.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnbuscaclie.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnbuscaclie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscaclie.Image = global::Loundry.Properties.Resources.gbusqueda;
            this.btnbuscaclie.Location = new System.Drawing.Point(41, 15);
            this.btnbuscaclie.Name = "btnbuscaclie";
            this.btnbuscaclie.Size = new System.Drawing.Size(30, 23);
            this.btnbuscaclie.TabIndex = 12;
            this.toolTip1.SetToolTip(this.btnbuscaclie, "Busca Proveedor");
            this.btnbuscaclie.UseVisualStyleBackColor = true;
            this.btnbuscaclie.Click += new System.EventHandler(this.btnbuscaclie_Click);
            // 
            // btnrefreshclie
            // 
            this.btnrefreshclie.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnrefreshclie.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnrefreshclie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrefreshclie.Image = global::Loundry.Properties.Resources.grefresca;
            this.btnrefreshclie.Location = new System.Drawing.Point(5, 14);
            this.btnrefreshclie.Name = "btnrefreshclie";
            this.btnrefreshclie.Size = new System.Drawing.Size(30, 23);
            this.btnrefreshclie.TabIndex = 10;
            this.toolTip1.SetToolTip(this.btnrefreshclie, "Actualiza");
            this.btnrefreshclie.UseVisualStyleBackColor = true;
            this.btnrefreshclie.Click += new System.EventHandler(this.btnrefreshclie_Click);
            // 
            // frmcajaproveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 299);
            this.Controls.Add(this.grpclientes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmcajaproveedor";
            this.Text = "Seleccione Proveedor";
            this.Load += new System.EventHandler(this.frmcajaproveedor_Load);
            this.grpclientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvproveedor)).EndInit();
            this.grpgrabasale.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpclientes;
        private System.Windows.Forms.DataGridView dgvproveedor;
        private System.Windows.Forms.GroupBox grpgrabasale;
        private System.Windows.Forms.Button btnbuscaclie;
        private System.Windows.Forms.Button btnrefreshclie;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}