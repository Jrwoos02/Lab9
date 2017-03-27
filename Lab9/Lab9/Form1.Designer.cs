namespace Lab9
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
            this.yearButton = new System.Windows.Forms.Button();
            this.monthButton = new System.Windows.Forms.Button();
            this.updateDayButton = new System.Windows.Forms.Button();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.monthTextBox = new System.Windows.Forms.TextBox();
            this.dayTextBox = new System.Windows.Forms.TextBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // yearButton
            // 
            this.yearButton.Location = new System.Drawing.Point(122, 84);
            this.yearButton.Name = "yearButton";
            this.yearButton.Size = new System.Drawing.Size(90, 23);
            this.yearButton.TabIndex = 0;
            this.yearButton.Text = "Update Year";
            this.yearButton.UseVisualStyleBackColor = true;
            this.yearButton.Click += new System.EventHandler(this.yearButton_Click);
            // 
            // monthButton
            // 
            this.monthButton.Location = new System.Drawing.Point(122, 59);
            this.monthButton.Name = "monthButton";
            this.monthButton.Size = new System.Drawing.Size(90, 23);
            this.monthButton.TabIndex = 1;
            this.monthButton.Text = "Update Month";
            this.monthButton.UseVisualStyleBackColor = true;
            this.monthButton.Click += new System.EventHandler(this.monthButton_Click);
            // 
            // updateDayButton
            // 
            this.updateDayButton.Location = new System.Drawing.Point(122, 35);
            this.updateDayButton.Name = "updateDayButton";
            this.updateDayButton.Size = new System.Drawing.Size(90, 23);
            this.updateDayButton.TabIndex = 2;
            this.updateDayButton.Text = "Update Day";
            this.updateDayButton.UseVisualStyleBackColor = true;
            this.updateDayButton.Click += new System.EventHandler(this.updateDayButton_Click);
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(16, 87);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(100, 20);
            this.yearTextBox.TabIndex = 3;
            // 
            // monthTextBox
            // 
            this.monthTextBox.Location = new System.Drawing.Point(16, 61);
            this.monthTextBox.Name = "monthTextBox";
            this.monthTextBox.Size = new System.Drawing.Size(100, 20);
            this.monthTextBox.TabIndex = 4;
            // 
            // dayTextBox
            // 
            this.dayTextBox.Location = new System.Drawing.Point(16, 35);
            this.dayTextBox.Name = "dayTextBox";
            this.dayTextBox.Size = new System.Drawing.Size(100, 20);
            this.dayTextBox.TabIndex = 5;
            // 
            // dateLabel
            // 
            this.dateLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dateLabel.Location = new System.Drawing.Point(16, 9);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(100, 23);
            this.dateLabel.TabIndex = 6;
            this.dateLabel.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 113);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.dayTextBox);
            this.Controls.Add(this.monthTextBox);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.updateDayButton);
            this.Controls.Add(this.monthButton);
            this.Controls.Add(this.yearButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button yearButton;
        private System.Windows.Forms.Button monthButton;
        private System.Windows.Forms.Button updateDayButton;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.TextBox monthTextBox;
        private System.Windows.Forms.TextBox dayTextBox;
        private System.Windows.Forms.Label dateLabel;
    }
}

