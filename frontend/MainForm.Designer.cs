
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
            this.btnExecuteSoapRequest = new System.Windows.Forms.Button();
            this.soapBox = new System.Windows.Forms.TextBox();
            this.restBox = new System.Windows.Forms.TextBox();
            this.btnExecuteRestRequest = new System.Windows.Forms.Button();
            this.cbRestContentType = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tbRestQuery = new System.Windows.Forms.TextBox();
            this.cbRestFunction = new System.Windows.Forms.ComboBox();
            this.tbRestBody = new System.Windows.Forms.TextBox();
            this.tbSoapParameter = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnExecuteSoapRequest
            // 
            this.btnExecuteSoapRequest.Location = new System.Drawing.Point(13, 12);
            this.btnExecuteSoapRequest.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExecuteSoapRequest.Name = "btnExecuteSoapRequest";
            this.btnExecuteSoapRequest.Size = new System.Drawing.Size(85, 52);
            this.btnExecuteSoapRequest.TabIndex = 0;
            this.btnExecuteSoapRequest.Text = "SOAP";
            this.btnExecuteSoapRequest.UseVisualStyleBackColor = true;
            this.btnExecuteSoapRequest.Click += new System.EventHandler(this.BtnExecuteSoapRequest_Click);
            // 
            // soapBox
            // 
            this.soapBox.Location = new System.Drawing.Point(106, 12);
            this.soapBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.soapBox.Multiline = true;
            this.soapBox.Name = "soapBox";
            this.soapBox.ReadOnly = true;
            this.soapBox.Size = new System.Drawing.Size(162, 52);
            this.soapBox.TabIndex = 1;
            // 
            // restBox
            // 
            this.restBox.Location = new System.Drawing.Point(106, 70);
            this.restBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.restBox.Multiline = true;
            this.restBox.Name = "restBox";
            this.restBox.ReadOnly = true;
            this.restBox.Size = new System.Drawing.Size(162, 52);
            this.restBox.TabIndex = 2;
            // 
            // btnExecuteRestRequest
            // 
            this.btnExecuteRestRequest.Location = new System.Drawing.Point(13, 70);
            this.btnExecuteRestRequest.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExecuteRestRequest.Name = "btnExecuteRestRequest";
            this.btnExecuteRestRequest.Size = new System.Drawing.Size(85, 52);
            this.btnExecuteRestRequest.TabIndex = 3;
            this.btnExecuteRestRequest.Text = "REST";
            this.btnExecuteRestRequest.UseVisualStyleBackColor = true;
            this.btnExecuteRestRequest.Click += new System.EventHandler(this.BtnExecuteRestRequest_Click);
            // 
            // cbRestContentType
            // 
            this.cbRestContentType.DisplayMember = "application/json";
            this.cbRestContentType.FormattingEnabled = true;
            this.cbRestContentType.Items.AddRange(new object[] {
            "application/json",
            "application/xml",
            "text/json",
            "text/xml"});
            this.cbRestContentType.Location = new System.Drawing.Point(390, 70);
            this.cbRestContentType.Name = "cbRestContentType";
            this.cbRestContentType.Size = new System.Drawing.Size(154, 23);
            this.cbRestContentType.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(276, 70);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(107, 23);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Content Type";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(276, 99);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(107, 23);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "Function";
            // 
            // tbRestQuery
            // 
            this.tbRestQuery.Enabled = false;
            this.tbRestQuery.Location = new System.Drawing.Point(551, 99);
            this.tbRestQuery.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbRestQuery.Multiline = true;
            this.tbRestQuery.Name = "tbRestQuery";
            this.tbRestQuery.ReadOnly = true;
            this.tbRestQuery.Size = new System.Drawing.Size(369, 23);
            this.tbRestQuery.TabIndex = 7;
            this.tbRestQuery.Text = "Query Parameter";
            // 
            // cbRestFunction
            // 
            this.cbRestFunction.FormattingEnabled = true;
            this.cbRestFunction.Location = new System.Drawing.Point(390, 99);
            this.cbRestFunction.Name = "cbRestFunction";
            this.cbRestFunction.Size = new System.Drawing.Size(154, 23);
            this.cbRestFunction.TabIndex = 8;
            // 
            // tbRestBody
            // 
            this.tbRestBody.Enabled = false;
            this.tbRestBody.Location = new System.Drawing.Point(551, 128);
            this.tbRestBody.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbRestBody.Multiline = true;
            this.tbRestBody.Name = "tbRestBody";
            this.tbRestBody.ReadOnly = true;
            this.tbRestBody.Size = new System.Drawing.Size(369, 210);
            this.tbRestBody.TabIndex = 9;
            this.tbRestBody.Text = "Body";
            // 
            // tbSoapParameter
            // 
            this.tbSoapParameter.Enabled = false;
            this.tbSoapParameter.Location = new System.Drawing.Point(551, 12);
            this.tbSoapParameter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbSoapParameter.Multiline = true;
            this.tbSoapParameter.Name = "tbSoapParameter";
            this.tbSoapParameter.ReadOnly = true;
            this.tbSoapParameter.Size = new System.Drawing.Size(369, 23);
            this.tbSoapParameter.TabIndex = 10;
            this.tbSoapParameter.Text = "Soap Parameter";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.tbSoapParameter);
            this.Controls.Add(this.tbRestBody);
            this.Controls.Add(this.cbRestFunction);
            this.Controls.Add(this.tbRestQuery);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cbRestContentType);
            this.Controls.Add(this.btnExecuteRestRequest);
            this.Controls.Add(this.restBox);
            this.Controls.Add(this.soapBox);
            this.Controls.Add(this.btnExecuteSoapRequest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.Text = "Visual Studio Stockholm Syndrome Generator [v0.1]";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExecuteSoapRequest;
        private System.Windows.Forms.TextBox soapBox;
        private TextBox restBox;
        private Button btnExecuteRestRequest;
        private ComboBox cbRestContentType;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox tbRestQuery;
        private ComboBox cbRestFunction;
        private TextBox tbRestBody;
        private TextBox tbSoapParameter;
    }
}

