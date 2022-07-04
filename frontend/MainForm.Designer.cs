
namespace frontend
{
    partial class MainForm
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
            this.BtnExecuteSoapRequest = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnExecuteSoapRequest
            // 
            this.BtnExecuteSoapRequest.Location = new System.Drawing.Point(65, 35);
            this.BtnExecuteSoapRequest.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnExecuteSoapRequest.Name = "BtnExecuteSoapRequest";
            this.BtnExecuteSoapRequest.Size = new System.Drawing.Size(85, 61);
            this.BtnExecuteSoapRequest.TabIndex = 0;
            this.BtnExecuteSoapRequest.Text = "SOAP";
            this.BtnExecuteSoapRequest.UseVisualStyleBackColor = true;
            this.BtnExecuteSoapRequest.Click += new System.EventHandler(this.BtnExecuteSoapRequest_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(158, 35);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(162, 61);
            this.textBox1.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BtnExecuteSoapRequest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.Text = "Visual Studio Stockholm Syndrome Generator [v0.1]";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnExecuteSoapRequest;
        private System.Windows.Forms.TextBox textBox1;
    }
}

