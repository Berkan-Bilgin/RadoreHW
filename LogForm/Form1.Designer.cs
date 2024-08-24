namespace LogForm
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
            this.LogType = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.Label();
            this.LogTypeComboBox = new System.Windows.Forms.ComboBox();
            this.StatusTextBox = new System.Windows.Forms.TextBox();
            this.LogFormButton = new System.Windows.Forms.Button();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.ResultMessageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LogType
            // 
            this.LogType.AutoSize = true;
            this.LogType.Location = new System.Drawing.Point(230, 71);
            this.LogType.Name = "LogType";
            this.LogType.Size = new System.Drawing.Size(49, 13);
            this.LogType.TabIndex = 0;
            this.LogType.Text = "LogType";
            this.LogType.Click += new System.EventHandler(this.label1_Click);
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(230, 125);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(37, 13);
            this.Status.TabIndex = 1;
            this.Status.Text = "Status";
            this.Status.Click += new System.EventHandler(this.label2_Click);
            // 
            // LogTypeComboBox
            // 
            this.LogTypeComboBox.FormattingEnabled = true;
            this.LogTypeComboBox.Items.AddRange(new object[] {
            "DbLog",
            "XmlLog",
            "JsonLog",
            "MySQLLog"});
            this.LogTypeComboBox.Location = new System.Drawing.Point(322, 71);
            this.LogTypeComboBox.Name = "LogTypeComboBox";
            this.LogTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.LogTypeComboBox.TabIndex = 2;
            // 
            // StatusTextBox
            // 
            this.StatusTextBox.Location = new System.Drawing.Point(322, 118);
            this.StatusTextBox.Name = "StatusTextBox";
            this.StatusTextBox.Size = new System.Drawing.Size(121, 20);
            this.StatusTextBox.TabIndex = 3;
            // 
            // LogFormButton
            // 
            this.LogFormButton.Location = new System.Drawing.Point(368, 172);
            this.LogFormButton.Name = "LogFormButton";
            this.LogFormButton.Size = new System.Drawing.Size(75, 23);
            this.LogFormButton.TabIndex = 4;
            this.LogFormButton.Text = "Save Log";
            this.LogFormButton.UseVisualStyleBackColor = true;
            this.LogFormButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(230, 234);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(40, 13);
            this.ResultLabel.TabIndex = 5;
            this.ResultLabel.Text = "Result:";
            // 
            // ResultMessageLabel
            // 
            this.ResultMessageLabel.AutoSize = true;
            this.ResultMessageLabel.Location = new System.Drawing.Point(319, 234);
            this.ResultMessageLabel.Name = "ResultMessageLabel";
            this.ResultMessageLabel.Size = new System.Drawing.Size(144, 13);
            this.ResultMessageLabel.TabIndex = 6;
            this.ResultMessageLabel.Text = "<Buraya Log Mesjı düsecek>";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ResultMessageLabel);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.LogFormButton);
            this.Controls.Add(this.StatusTextBox);
            this.Controls.Add(this.LogTypeComboBox);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.LogType);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LogType;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.ComboBox LogTypeComboBox;
        private System.Windows.Forms.TextBox StatusTextBox;
        private System.Windows.Forms.Button LogFormButton;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Label ResultMessageLabel;
    }
}

