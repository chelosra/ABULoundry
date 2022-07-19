namespace Loundry
{
    partial class frmCreaDatabase
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnCrea = new System.Windows.Forms.Button();
            this.grp = new System.Windows.Forms.GroupBox();
            this.btnCancela = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.btnCreaanio = new System.Windows.Forms.Button();
            this.txtcrubro = new System.Windows.Forms.TextBox();
            this.btnBorraDatabase = new System.Windows.Forms.Button();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.picture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.grp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 12);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(366, 214);
            this.dgv.TabIndex = 63;
            this.dgv.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgv_MouseClick);
            // 
            // btnCrea
            // 
            this.btnCrea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCrea.Location = new System.Drawing.Point(12, 202);
            this.btnCrea.Name = "btnCrea";
            this.btnCrea.Size = new System.Drawing.Size(99, 24);
            this.btnCrea.TabIndex = 64;
            this.btnCrea.Text = "Agrega Database";
            this.btnCrea.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCrea.UseVisualStyleBackColor = true;
            this.btnCrea.Click += new System.EventHandler(this.btnCrea_Click);
            // 
            // grp
            // 
            this.grp.Controls.Add(this.btnCancela);
            this.grp.Controls.Add(this.label2);
            this.grp.Controls.Add(this.label1);
            this.grp.Controls.Add(this.txtDetalle);
            this.grp.Controls.Add(this.btnCreaanio);
            this.grp.Controls.Add(this.txtcrubro);
            this.grp.Location = new System.Drawing.Point(102, 36);
            this.grp.Name = "grp";
            this.grp.Size = new System.Drawing.Size(200, 137);
            this.grp.TabIndex = 65;
            this.grp.TabStop = false;
            this.grp.Text = "Ingrese el año";
            this.grp.Visible = false;
            // 
            // btnCancela
            // 
            this.btnCancela.BackgroundImage = global::Loundry.Properties.Resources.list_check;
            this.btnCancela.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancela.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnCancela.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCancela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancela.Location = new System.Drawing.Point(118, 109);
            this.btnCancela.Name = "btnCancela";
            this.btnCancela.Size = new System.Drawing.Size(29, 24);
            this.btnCancela.TabIndex = 63;
            this.btnCancela.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancela.UseVisualStyleBackColor = true;
            this.btnCancela.Click += new System.EventHandler(this.btnCancela_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Código:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese año:";
            // 
            // txtDetalle
            // 
            this.txtDetalle.Location = new System.Drawing.Point(82, 60);
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(100, 20);
            this.txtDetalle.TabIndex = 1;
            // 
            // btnCreaanio
            // 
            this.btnCreaanio.BackgroundImage = global::Loundry.Properties.Resources.list_check;
            this.btnCreaanio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCreaanio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnCreaanio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCreaanio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreaanio.Location = new System.Drawing.Point(153, 109);
            this.btnCreaanio.Name = "btnCreaanio";
            this.btnCreaanio.Size = new System.Drawing.Size(29, 24);
            this.btnCreaanio.TabIndex = 62;
            this.btnCreaanio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCreaanio.UseVisualStyleBackColor = true;
            this.btnCreaanio.Click += new System.EventHandler(this.btnCreaanio_Click);
            // 
            // txtcrubro
            // 
            this.txtcrubro.Location = new System.Drawing.Point(82, 19);
            this.txtcrubro.Name = "txtcrubro";
            this.txtcrubro.Size = new System.Drawing.Size(100, 20);
            this.txtcrubro.TabIndex = 0;
            this.txtcrubro.TextChanged += new System.EventHandler(this.txtcrubro_TextChanged);
            this.txtcrubro.Leave += new System.EventHandler(this.txtcrubro_Leave);
            // 
            // btnBorraDatabase
            // 
            this.btnBorraDatabase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBorraDatabase.Location = new System.Drawing.Point(112, 202);
            this.btnBorraDatabase.Name = "btnBorraDatabase";
            this.btnBorraDatabase.Size = new System.Drawing.Size(99, 24);
            this.btnBorraDatabase.TabIndex = 66;
            this.btnBorraDatabase.Text = "Borra Database";
            this.btnBorraDatabase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBorraDatabase.UseVisualStyleBackColor = true;
            this.btnBorraDatabase.Click += new System.EventHandler(this.btnBorraDatabase_Click);
            // 
            // btnBackup
            // 
            this.btnBackup.Location = new System.Drawing.Point(217, 203);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(75, 23);
            this.btnBackup.TabIndex = 67;
            this.btnBackup.Text = "Backup";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(298, 203);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(75, 23);
            this.btnRestore.TabIndex = 68;
            this.btnRestore.Text = "Restore";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // picture
            // 
            this.picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picture.Image = global::Loundry.Properties.Resources.loading_lightbox;
            this.picture.Location = new System.Drawing.Point(174, 232);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(27, 29);
            this.picture.TabIndex = 69;
            this.picture.TabStop = false;
            this.picture.Visible = false;
            // 
            // frmCreaDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 261);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.grp);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.btnBackup);
            this.Controls.Add(this.btnBorraDatabase);
            this.Controls.Add(this.btnCrea);
            this.Name = "frmCreaDatabase";
            this.Text = "Períodos";
            this.Load += new System.EventHandler(this.frmCreaDatabase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.grp.ResumeLayout(false);
            this.grp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreaanio;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnCrea;
        private System.Windows.Forms.GroupBox grp;
        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.TextBox txtcrubro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancela;
        private System.Windows.Forms.Button btnBorraDatabase;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.PictureBox picture;
    }
}