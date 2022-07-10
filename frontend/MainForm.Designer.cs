
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnTask1 = new System.Windows.Forms.Button();
            this.task1Output = new System.Windows.Forms.TextBox();
            this.task1Input = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnTask2 = new System.Windows.Forms.Button();
            this.task2Output = new System.Windows.Forms.TextBox();
            this.task2Input = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnTask3 = new System.Windows.Forms.Button();
            this.task3Output = new System.Windows.Forms.TextBox();
            this.task3Input = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnTask4 = new System.Windows.Forms.Button();
            this.task4Output = new System.Windows.Forms.TextBox();
            this.task4Input = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.task5Actions = new System.Windows.Forms.ComboBox();
            this.btnTask5 = new System.Windows.Forms.Button();
            this.task5Output = new System.Windows.Forms.TextBox();
            this.task5Input = new System.Windows.Forms.TextBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.btnTask6Authorized = new System.Windows.Forms.Button();
            this.btnTask6Unauthorized = new System.Windows.Forms.Button();
            this.task6Output = new System.Windows.Forms.TextBox();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.endLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(933, 519);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tabPage1.Controls.Add(this.btnTask1);
            this.tabPage1.Controls.Add(this.task1Output);
            this.tabPage1.Controls.Add(this.task1Input);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(925, 491);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Zadatak 1";
            this.tabPage1.Enter += new System.EventHandler(this.tabPage1_Enter);
            // 
            // btnTask1
            // 
            this.btnTask1.Location = new System.Drawing.Point(5, 29);
            this.btnTask1.Name = "btnTask1";
            this.btnTask1.Size = new System.Drawing.Size(78, 48);
            this.btnTask1.TabIndex = 2;
            this.btnTask1.Text = "XSD";
            this.btnTask1.UseVisualStyleBackColor = true;
            this.btnTask1.Click += new System.EventHandler(this.btnTask1_Click);
            // 
            // task1Output
            // 
            this.task1Output.Enabled = false;
            this.task1Output.Location = new System.Drawing.Point(466, 29);
            this.task1Output.Multiline = true;
            this.task1Output.Name = "task1Output";
            this.task1Output.ReadOnly = true;
            this.task1Output.Size = new System.Drawing.Size(363, 454);
            this.task1Output.TabIndex = 1;
            // 
            // task1Input
            // 
            this.task1Input.Location = new System.Drawing.Point(89, 29);
            this.task1Input.Multiline = true;
            this.task1Input.Name = "task1Input";
            this.task1Input.Size = new System.Drawing.Size(363, 456);
            this.task1Input.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tabPage2.Controls.Add(this.btnTask2);
            this.tabPage2.Controls.Add(this.task2Output);
            this.tabPage2.Controls.Add(this.task2Input);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(925, 491);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Zadatak 2";
            this.tabPage2.Enter += new System.EventHandler(this.tabPage2_Enter);
            // 
            // btnTask2
            // 
            this.btnTask2.Location = new System.Drawing.Point(20, 16);
            this.btnTask2.Name = "btnTask2";
            this.btnTask2.Size = new System.Drawing.Size(78, 48);
            this.btnTask2.TabIndex = 5;
            this.btnTask2.Text = "RNG";
            this.btnTask2.UseVisualStyleBackColor = true;
            this.btnTask2.Click += new System.EventHandler(this.btnTask2_Click);
            // 
            // task2Output
            // 
            this.task2Output.Enabled = false;
            this.task2Output.Location = new System.Drawing.Point(481, 16);
            this.task2Output.Multiline = true;
            this.task2Output.Name = "task2Output";
            this.task2Output.ReadOnly = true;
            this.task2Output.Size = new System.Drawing.Size(363, 454);
            this.task2Output.TabIndex = 4;
            // 
            // task2Input
            // 
            this.task2Input.Location = new System.Drawing.Point(104, 16);
            this.task2Input.Multiline = true;
            this.task2Input.Name = "task2Input";
            this.task2Input.Size = new System.Drawing.Size(363, 456);
            this.task2Input.TabIndex = 3;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPage3.Controls.Add(this.btnTask3);
            this.tabPage3.Controls.Add(this.task3Output);
            this.tabPage3.Controls.Add(this.task3Input);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(925, 491);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Zadatak 3";
            this.tabPage3.Enter += new System.EventHandler(this.tabPage3_Enter);
            // 
            // btnTask3
            // 
            this.btnTask3.Location = new System.Drawing.Point(50, 17);
            this.btnTask3.Name = "btnTask3";
            this.btnTask3.Size = new System.Drawing.Size(78, 48);
            this.btnTask3.TabIndex = 8;
            this.btnTask3.Text = "SOAP";
            this.btnTask3.UseVisualStyleBackColor = true;
            this.btnTask3.Click += new System.EventHandler(this.btnTask3_Click);
            // 
            // task3Output
            // 
            this.task3Output.Enabled = false;
            this.task3Output.Location = new System.Drawing.Point(511, 17);
            this.task3Output.Multiline = true;
            this.task3Output.Name = "task3Output";
            this.task3Output.ReadOnly = true;
            this.task3Output.Size = new System.Drawing.Size(363, 454);
            this.task3Output.TabIndex = 7;
            // 
            // task3Input
            // 
            this.task3Input.Location = new System.Drawing.Point(134, 17);
            this.task3Input.Multiline = true;
            this.task3Input.Name = "task3Input";
            this.task3Input.Size = new System.Drawing.Size(363, 456);
            this.task3Input.TabIndex = 6;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPage4.Controls.Add(this.btnTask4);
            this.tabPage4.Controls.Add(this.task4Output);
            this.tabPage4.Controls.Add(this.task4Input);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(925, 491);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Zadatak 4";
            this.tabPage4.Enter += new System.EventHandler(this.tabPage4_Enter);
            // 
            // btnTask4
            // 
            this.btnTask4.Location = new System.Drawing.Point(50, 17);
            this.btnTask4.Name = "btnTask4";
            this.btnTask4.Size = new System.Drawing.Size(78, 48);
            this.btnTask4.TabIndex = 11;
            this.btnTask4.Text = "XSD (Again)";
            this.btnTask4.UseVisualStyleBackColor = true;
            this.btnTask4.Click += new System.EventHandler(this.btnTask4_Click);
            // 
            // task4Output
            // 
            this.task4Output.Enabled = false;
            this.task4Output.Location = new System.Drawing.Point(511, 17);
            this.task4Output.Multiline = true;
            this.task4Output.Name = "task4Output";
            this.task4Output.ReadOnly = true;
            this.task4Output.Size = new System.Drawing.Size(363, 454);
            this.task4Output.TabIndex = 10;
            // 
            // task4Input
            // 
            this.task4Input.Location = new System.Drawing.Point(134, 17);
            this.task4Input.Multiline = true;
            this.task4Input.Name = "task4Input";
            this.task4Input.Size = new System.Drawing.Size(363, 456);
            this.task4Input.TabIndex = 9;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPage5.Controls.Add(this.task5Actions);
            this.tabPage5.Controls.Add(this.btnTask5);
            this.tabPage5.Controls.Add(this.task5Output);
            this.tabPage5.Controls.Add(this.task5Input);
            this.tabPage5.Location = new System.Drawing.Point(4, 24);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(925, 491);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Zadatak 5";
            this.tabPage5.Enter += new System.EventHandler(this.tabPage5_Enter);
            // 
            // task5Actions
            // 
            this.task5Actions.FormattingEnabled = true;
            this.task5Actions.Items.AddRange(new object[] {
            "firstcity",
            "listcities",
            "cityname"});
            this.task5Actions.Location = new System.Drawing.Point(7, 71);
            this.task5Actions.Name = "task5Actions";
            this.task5Actions.Size = new System.Drawing.Size(121, 23);
            this.task5Actions.TabIndex = 12;
            this.task5Actions.SelectedIndexChanged += new System.EventHandler(this.task5Actions_SelectedIndexChanged);
            // 
            // btnTask5
            // 
            this.btnTask5.Location = new System.Drawing.Point(8, 17);
            this.btnTask5.Name = "btnTask5";
            this.btnTask5.Size = new System.Drawing.Size(120, 48);
            this.btnTask5.TabIndex = 11;
            this.btnTask5.Text = "XML-RPC";
            this.btnTask5.UseVisualStyleBackColor = true;
            this.btnTask5.Click += new System.EventHandler(this.btnTask5_Click);
            // 
            // task5Output
            // 
            this.task5Output.Enabled = false;
            this.task5Output.Location = new System.Drawing.Point(511, 17);
            this.task5Output.Multiline = true;
            this.task5Output.Name = "task5Output";
            this.task5Output.ReadOnly = true;
            this.task5Output.Size = new System.Drawing.Size(363, 454);
            this.task5Output.TabIndex = 10;
            // 
            // task5Input
            // 
            this.task5Input.Location = new System.Drawing.Point(134, 17);
            this.task5Input.Multiline = true;
            this.task5Input.Name = "task5Input";
            this.task5Input.Size = new System.Drawing.Size(363, 456);
            this.task5Input.TabIndex = 9;
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tabPage6.Controls.Add(this.btnTask6Authorized);
            this.tabPage6.Controls.Add(this.btnTask6Unauthorized);
            this.tabPage6.Controls.Add(this.task6Output);
            this.tabPage6.Location = new System.Drawing.Point(4, 24);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(925, 491);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Zadatak 6";
            this.tabPage6.Enter += new System.EventHandler(this.tabPage6_Enter);
            // 
            // btnTask6Authorized
            // 
            this.btnTask6Authorized.Location = new System.Drawing.Point(8, 71);
            this.btnTask6Authorized.Name = "btnTask6Authorized";
            this.btnTask6Authorized.Size = new System.Drawing.Size(122, 48);
            this.btnTask6Authorized.TabIndex = 15;
            this.btnTask6Authorized.Text = "Authorized";
            this.btnTask6Authorized.UseVisualStyleBackColor = true;
            this.btnTask6Authorized.Click += new System.EventHandler(this.btnTask6Authorized_Click);
            // 
            // btnTask6Unauthorized
            // 
            this.btnTask6Unauthorized.Location = new System.Drawing.Point(8, 17);
            this.btnTask6Unauthorized.Name = "btnTask6Unauthorized";
            this.btnTask6Unauthorized.Size = new System.Drawing.Size(122, 48);
            this.btnTask6Unauthorized.TabIndex = 14;
            this.btnTask6Unauthorized.Text = "Unauthorized";
            this.btnTask6Unauthorized.UseVisualStyleBackColor = true;
            this.btnTask6Unauthorized.Click += new System.EventHandler(this.btnTask6Unauthorized_Click);
            // 
            // task6Output
            // 
            this.task6Output.Enabled = false;
            this.task6Output.Location = new System.Drawing.Point(136, 17);
            this.task6Output.Multiline = true;
            this.task6Output.Name = "task6Output";
            this.task6Output.ReadOnly = true;
            this.task6Output.Size = new System.Drawing.Size(738, 454);
            this.task6Output.TabIndex = 13;
            // 
            // tabPage7
            // 
            this.tabPage7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tabPage7.Controls.Add(this.endLabel);
            this.tabPage7.Location = new System.Drawing.Point(4, 24);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(925, 491);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Zadatak 7";
            this.tabPage7.Enter += new System.EventHandler(this.tabPage7_Enter);
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.endLabel.ForeColor = System.Drawing.Color.Red;
            this.endLabel.Location = new System.Drawing.Point(8, 172);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(6918, 128);
            this.endLabel.TabIndex = 0;
            this.endLabel.Text = "🥳🥳🎉🎉🎊🎊🎈💃🥳🎊🪅🪅🪅🥳🥳🎉🎉🎊🎊🎈💃🥳🎊🪅🪅🪅🥳🥳🎉🎉🎊🎊🎈💃🥳🎊🪅🪅🪅🥳🥳" +
    "🎉🎉🎊🎊🎈💃🥳🎊🪅🪅🪅";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.Text = "Visual Studio Stockholm Syndrome Generator [v0.1]";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private TabPage tabPage7;
        private Button btnTask1;
        private TextBox task1Output;
        private TextBox task1Input;
        private Button btnTask2;
        private TextBox task2Output;
        private TextBox task2Input;
        private Button btnTask3;
        private TextBox task3Output;
        private TextBox task3Input;
        private Button btnTask4;
        private TextBox task4Output;
        private TextBox task4Input;
        private Button btnTask5;
        private TextBox task5Output;
        private TextBox task5Input;
        private Button btnTask6Unauthorized;
        private TextBox task6Output;
        private Button btnTask6Authorized;
        private Label endLabel;
        private ComboBox task5Actions;
    }
}

