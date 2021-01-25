
namespace AWK
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.timePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.inSpecifiedTime = new System.Windows.Forms.RadioButton();
            this.inGivenTime = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.timePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(15, 17);
            this.maskedTextBox1.Mask = "00:00:00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 23);
            this.maskedTextBox1.TabIndex = 0;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(12, 123);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(260, 23);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Rozpocznij";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // timePanel
            // 
            this.timePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timePanel.Controls.Add(this.maskedTextBox1);
            this.timePanel.Location = new System.Drawing.Point(141, 39);
            this.timePanel.Name = "timePanel";
            this.timePanel.Size = new System.Drawing.Size(131, 55);
            this.timePanel.TabIndex = 2;
            this.timePanel.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Czas";
            // 
            // inSpecifiedTime
            // 
            this.inSpecifiedTime.AutoSize = true;
            this.inSpecifiedTime.Location = new System.Drawing.Point(12, 50);
            this.inSpecifiedTime.Name = "inSpecifiedTime";
            this.inSpecifiedTime.Size = new System.Drawing.Size(115, 19);
            this.inSpecifiedTime.TabIndex = 3;
            this.inSpecifiedTime.TabStop = true;
            this.inSpecifiedTime.Text = "za określony czas";
            this.inSpecifiedTime.UseVisualStyleBackColor = true;
            // 
            // inGivenTime
            // 
            this.inGivenTime.AutoSize = true;
            this.inGivenTime.Location = new System.Drawing.Point(12, 75);
            this.inGivenTime.Name = "inGivenTime";
            this.inGivenTime.Size = new System.Drawing.Size(126, 19);
            this.inGivenTime.TabIndex = 4;
            this.inGivenTime.TabStop = true;
            this.inGivenTime.Text = "o podanej godzinie";
            this.inGivenTime.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Wyłącz";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 158);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inGivenTime);
            this.Controls.Add(this.inSpecifiedTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.timePanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(300, 197);
            this.MinimumSize = new System.Drawing.Size(300, 197);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AWK";
            this.timePanel.ResumeLayout(false);
            this.timePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Panel timePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton inSpecifiedTime;
        private System.Windows.Forms.RadioButton inGivenTime;
        private System.Windows.Forms.Label label2;
    }
}

