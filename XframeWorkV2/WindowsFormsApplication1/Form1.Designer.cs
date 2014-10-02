namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.xpremaTextBox1 = new Xprema.Controllers.XpremaTextBox();
            this.SuspendLayout();
            // 
            // xpremaTextBox1
            // 
            this.xpremaTextBox1.AutoSize = true;
            this.xpremaTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.xpremaTextBox1.Location = new System.Drawing.Point(80, 65);
            this.xpremaTextBox1.Name = "xpremaTextBox1";
            this.xpremaTextBox1.Size = new System.Drawing.Size(328, 23);
            this.xpremaTextBox1.TabIndex = 0;
            this.xpremaTextBox1.Value = "samer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(817, 423);
            this.Controls.Add(this.xpremaTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Xprema.Controllers.XpremaTextBox xpremaTextBox1;

    }
}

