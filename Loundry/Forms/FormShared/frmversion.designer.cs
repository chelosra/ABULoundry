namespace Loundry
{
    partial class frmVersion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVersion));
            this.rTBox = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblgversion = new Loundry.LabelGradient();
            this.SuspendLayout();
            // 
            // rTBox
            // 
            this.rTBox.Location = new System.Drawing.Point(12, 90);
            this.rTBox.Name = "rTBox";
            this.rTBox.ReadOnly = true;
            this.rTBox.Size = new System.Drawing.Size(249, 252);
            this.rTBox.TabIndex = 1;
            this.rTBox.Text = "\nv:1.0.0.7\n=====\ncomprobante asociado en notas de credito";
            this.rTBox.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(76, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Link a la AFIP";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblgversion
            // 
            this.lblgversion.AutoSize = true;
            this.lblgversion.BorderStyle = System.Windows.Forms.Border3DStyle.Adjust;
            this.lblgversion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgversion.ForeColor = System.Drawing.Color.White;
            this.lblgversion.GradientColorOne = System.Drawing.Color.Blue;
            this.lblgversion.GradientColorTwo = System.Drawing.Color.LightSteelBlue;
            this.lblgversion.Location = new System.Drawing.Point(72, 28);
            this.lblgversion.Name = "lblgversion";
            this.lblgversion.Size = new System.Drawing.Size(125, 20);
            this.lblgversion.TabIndex = 0;
            this.lblgversion.Text = "Versión: 1.0.0.";
            // 
            // frmVersion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 356);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rTBox);
            this.Controls.Add(this.lblgversion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVersion";
            this.Text = "Versión de la Aplicación";
            this.Load += new System.EventHandler(this.frmVersion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private LabelGradient lblgversion;
        private System.Windows.Forms.RichTextBox rTBox;
        private System.Windows.Forms.Button button1;
    }
}