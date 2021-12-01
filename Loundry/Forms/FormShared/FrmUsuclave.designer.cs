namespace Loundry
{
    partial class FrmUsuclave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuclave));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mClave = new System.Windows.Forms.MaskedTextBox();
            this.mclaven = new System.Windows.Forms.MaskedTextBox();
            this.mclaver = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Image = global::Loundry.Properties.Resources.ggraba;
            this.button1.Location = new System.Drawing.Point(236, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 25);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Image = global::Loundry.Properties.Resources.gsale;
            this.button2.Location = new System.Drawing.Point(288, 126);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 25);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese su Clave Actual";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingrese Nueva Clave";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Repita la Nueva Clave";
            // 
            // mClave
            // 
            this.mClave.Location = new System.Drawing.Point(190, 19);
            this.mClave.Name = "mClave";
            this.mClave.PasswordChar = '*';
            this.mClave.Size = new System.Drawing.Size(144, 20);
            this.mClave.TabIndex = 8;
            this.mClave.TextChanged += new System.EventHandler(this.maskedTextBox1_TextChanged);
            // 
            // mclaven
            // 
            this.mclaven.Location = new System.Drawing.Point(190, 51);
            this.mclaven.Name = "mclaven";
            this.mclaven.PasswordChar = '*';
            this.mclaven.Size = new System.Drawing.Size(144, 20);
            this.mclaven.TabIndex = 9;
            // 
            // mclaver
            // 
            this.mclaver.Location = new System.Drawing.Point(190, 85);
            this.mclaver.Name = "mclaver";
            this.mclaver.PasswordChar = '*';
            this.mclaver.Size = new System.Drawing.Size(144, 20);
            this.mclaver.TabIndex = 10;
            // 
            // FrmUsuclave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Loundry.Properties.Resources.fondologin;
            this.ClientSize = new System.Drawing.Size(345, 164);
            this.Controls.Add(this.mclaver);
            this.Controls.Add(this.mclaven);
            this.Controls.Add(this.mClave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmUsuclave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambio de password";
            this.Leave += new System.EventHandler(this.FrmUsuclave_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mClave;
        private System.Windows.Forms.MaskedTextBox mclaven;
        private System.Windows.Forms.MaskedTextBox mclaver;
    }
}