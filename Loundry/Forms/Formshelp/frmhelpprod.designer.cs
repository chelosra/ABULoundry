namespace Loundry
{
    partial class frmhelpprod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmhelpprod));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnBuscaCprod = new System.Windows.Forms.Button();
            this.btnbusca = new System.Windows.Forms.Button();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnBuscaCprod);
            this.groupBox3.Controls.Add(this.btnbusca);
            this.groupBox3.Controls.Add(this.btnrefresh);
            this.groupBox3.Location = new System.Drawing.Point(9, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(81, 47);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Acciones";
            // 
            // btnBuscaCprod
            // 
            this.btnBuscaCprod.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnBuscaCprod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBuscaCprod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscaCprod.Image = global::Loundry.Properties.Resources.gbusqueda;
            this.btnBuscaCprod.Location = new System.Drawing.Point(80, 16);
            this.btnBuscaCprod.Name = "btnBuscaCprod";
            this.btnBuscaCprod.Size = new System.Drawing.Size(30, 23);
            this.btnBuscaCprod.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btnBuscaCprod, "Busca por Código");
            this.btnBuscaCprod.UseVisualStyleBackColor = true;
            this.btnBuscaCprod.Click += new System.EventHandler(this.btnBuscaCprod_Click);
            // 
            // btnbusca
            // 
            this.btnbusca.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnbusca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnbusca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbusca.Image = global::Loundry.Properties.Resources.gbusqueda;
            this.btnbusca.Location = new System.Drawing.Point(44, 16);
            this.btnbusca.Name = "btnbusca";
            this.btnbusca.Size = new System.Drawing.Size(30, 23);
            this.btnbusca.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btnbusca, "Busca por Descripción");
            this.btnbusca.UseVisualStyleBackColor = true;
            this.btnbusca.Click += new System.EventHandler(this.btnbusca_Click);
            // 
            // btnrefresh
            // 
            this.btnrefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnrefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnrefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrefresh.Image = global::Loundry.Properties.Resources.grefresca;
            this.btnrefresh.Location = new System.Drawing.Point(10, 17);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(30, 23);
            this.btnrefresh.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnrefresh, "Refresh");
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.button3_Click);
            // 
            // dgv
            // 
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 50);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(349, 221);
            this.dgv.TabIndex = 0;
            this.toolTip1.SetToolTip(this.dgv, "Doble Click para agregar a Factura");
            this.dgv.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_CellMouseDoubleClick);
            // 
            // frmhelpprod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 283);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dgv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmhelpprod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Seleccione Producto";
            this.Load += new System.EventHandler(this.frmhelpprod_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnbusca;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnBuscaCprod;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}