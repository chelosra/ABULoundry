namespace Loundry
{
    partial class Frmcreausu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmcreausu));
            this.panelGradient1 = new PanelGradient.PanelGradient();
            this.mpassr = new System.Windows.Forms.MaskedTextBox();
            this.msector = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.musu = new System.Windows.Forms.TextBox();
            this.mpass = new System.Windows.Forms.MaskedTextBox();
            this.panelGradient1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelGradient1
            // 
            this.panelGradient1.Controls.Add(this.mpassr);
            this.panelGradient1.Controls.Add(this.msector);
            this.panelGradient1.Controls.Add(this.label1);
            this.panelGradient1.Controls.Add(this.label4);
            this.panelGradient1.Controls.Add(this.label2);
            this.panelGradient1.Controls.Add(this.button1);
            this.panelGradient1.Controls.Add(this.label3);
            this.panelGradient1.Controls.Add(this.musu);
            this.panelGradient1.Controls.Add(this.mpass);
            this.panelGradient1.GradientColorOne = System.Drawing.Color.Silver;
            this.panelGradient1.GradientColorTwo = System.Drawing.Color.Lavender;
            this.panelGradient1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panelGradient1.Location = new System.Drawing.Point(26, 12);
            this.panelGradient1.Name = "panelGradient1";
            this.panelGradient1.Size = new System.Drawing.Size(376, 164);
            this.panelGradient1.TabIndex = 10;
            // 
            // mpassr
            // 
            this.mpassr.Location = new System.Drawing.Point(153, 69);
            this.mpassr.Name = "mpassr";
            this.mpassr.PasswordChar = '*';
            this.mpassr.Size = new System.Drawing.Size(206, 20);
            this.mpassr.TabIndex = 2;
            // 
            // msector
            // 
            this.msector.FormattingEnabled = true;
            this.msector.Items.AddRange(new object[] {
            "",
            "Administrador",
            "Usuario"});
            this.msector.Location = new System.Drawing.Point(153, 96);
            this.msector.Name = "msector";
            this.msector.Size = new System.Drawing.Size(121, 21);
            this.msector.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Acceso:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // button1
            // 
            this.button1.Image = global::Loundry.Properties.Resources.ggraba;
            this.button1.Location = new System.Drawing.Point(310, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 23);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Repite Password";
            // 
            // musu
            // 
            this.musu.Location = new System.Drawing.Point(153, 13);
            this.musu.Name = "musu";
            this.musu.Size = new System.Drawing.Size(206, 20);
            this.musu.TabIndex = 0;
            this.musu.TextChanged += new System.EventHandler(this.musu_TextChanged);
            // 
            // mpass
            // 
            this.mpass.Location = new System.Drawing.Point(153, 40);
            this.mpass.Name = "mpass";
            this.mpass.PasswordChar = '*';
            this.mpass.Size = new System.Drawing.Size(206, 20);
            this.mpass.TabIndex = 1;
            // 
            // Frmcreausu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Loundry.Properties.Resources.fondologin;
            this.ClientSize = new System.Drawing.Size(429, 193);
            this.Controls.Add(this.panelGradient1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frmcreausu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crea usuario";
            this.Load += new System.EventHandler(this.Frmcreausu_Load);
            this.panelGradient1.ResumeLayout(false);
            this.panelGradient1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mpass;
        private System.Windows.Forms.MaskedTextBox mpassr;
        private System.Windows.Forms.TextBox musu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox msector;
        private PanelGradient.PanelGradient panelGradient1;
    }
}