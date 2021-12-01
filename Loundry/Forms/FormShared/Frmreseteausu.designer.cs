namespace Loundry
{
    partial class Frmreseteausu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmreseteausu));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.musu = new System.Windows.Forms.TextBox();
            this.mclave = new System.Windows.Forms.MaskedTextBox();
            this.mclaver = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panelGradient1 = new PanelGradient.PanelGradient();
            this.panelGradient1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nueva Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Repita Nueva Password";
            // 
            // musu
            // 
            this.musu.Location = new System.Drawing.Point(155, 14);
            this.musu.Name = "musu";
            this.musu.Size = new System.Drawing.Size(254, 20);
            this.musu.TabIndex = 0;
            this.musu.TextChanged += new System.EventHandler(this.musu_TextChanged);
            // 
            // mclave
            // 
            this.mclave.Enabled = false;
            this.mclave.Location = new System.Drawing.Point(155, 41);
            this.mclave.Name = "mclave";
            this.mclave.PasswordChar = '*';
            this.mclave.Size = new System.Drawing.Size(254, 20);
            this.mclave.TabIndex = 1;
            // 
            // mclaver
            // 
            this.mclaver.Enabled = false;
            this.mclaver.Location = new System.Drawing.Point(155, 75);
            this.mclaver.Name = "mclaver";
            this.mclaver.PasswordChar = '*';
            this.mclaver.Size = new System.Drawing.Size(254, 20);
            this.mclaver.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Image = global::Loundry.Properties.Resources.ggraba;
            this.button1.Location = new System.Drawing.Point(378, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 23);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelGradient1
            // 
            this.panelGradient1.Controls.Add(this.musu);
            this.panelGradient1.Controls.Add(this.button1);
            this.panelGradient1.Controls.Add(this.label1);
            this.panelGradient1.Controls.Add(this.mclaver);
            this.panelGradient1.Controls.Add(this.label2);
            this.panelGradient1.Controls.Add(this.mclave);
            this.panelGradient1.Controls.Add(this.label3);
            this.panelGradient1.GradientColorOne = System.Drawing.Color.Silver;
            this.panelGradient1.GradientColorTwo = System.Drawing.Color.Lavender;
            this.panelGradient1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panelGradient1.Location = new System.Drawing.Point(12, 12);
            this.panelGradient1.Name = "panelGradient1";
            this.panelGradient1.Size = new System.Drawing.Size(423, 151);
            this.panelGradient1.TabIndex = 7;
            // 
            // Frmreseteausu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Loundry.Properties.Resources.fondologin;
            this.ClientSize = new System.Drawing.Size(447, 184);
            this.Controls.Add(this.panelGradient1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frmreseteausu";
            this.Text = "Reseteo de usuario";
            this.Load += new System.EventHandler(this.Frmreseteausu_Load);
            this.panelGradient1.ResumeLayout(false);
            this.panelGradient1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox musu;
        private System.Windows.Forms.MaskedTextBox mclave;
        private System.Windows.Forms.MaskedTextBox mclaver;
        private System.Windows.Forms.Button button1;
        private PanelGradient.PanelGradient panelGradient1;
    }
}