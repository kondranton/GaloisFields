namespace FiniteFieldsWindowsFormsApplication
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
            this.countButton = new System.Windows.Forms.Button();
            this.firstValueTextBox = new System.Windows.Forms.TextBox();
            this.secondValueTextBox = new System.Windows.Forms.TextBox();
            this.firstValueLabel = new System.Windows.Forms.Label();
            this.secondValueLabel = new System.Windows.Forms.Label();
            this.output = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // countButton
            // 
            this.countButton.Location = new System.Drawing.Point(362, 120);
            this.countButton.Name = "countButton";
            this.countButton.Size = new System.Drawing.Size(75, 23);
            this.countButton.TabIndex = 0;
            this.countButton.Text = "Вычислить";
            this.countButton.UseVisualStyleBackColor = true;
            this.countButton.Click += new System.EventHandler(this.countButton_Click);
            // 
            // firstValueTextBox
            // 
            this.firstValueTextBox.Location = new System.Drawing.Point(67, 120);
            this.firstValueTextBox.Name = "firstValueTextBox";
            this.firstValueTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstValueTextBox.TabIndex = 1;
            // 
            // secondValueTextBox
            // 
            this.secondValueTextBox.Location = new System.Drawing.Point(214, 120);
            this.secondValueTextBox.Name = "secondValueTextBox";
            this.secondValueTextBox.Size = new System.Drawing.Size(100, 20);
            this.secondValueTextBox.TabIndex = 2;
            // 
            // firstValueLabel
            // 
            this.firstValueLabel.AutoSize = true;
            this.firstValueLabel.Location = new System.Drawing.Point(64, 83);
            this.firstValueLabel.Name = "firstValueLabel";
            this.firstValueLabel.Size = new System.Drawing.Size(97, 13);
            this.firstValueLabel.TabIndex = 3;
            this.firstValueLabel.Text = "Первый полином:";
            // 
            // secondValueLabel
            // 
            this.secondValueLabel.AutoSize = true;
            this.secondValueLabel.Location = new System.Drawing.Point(211, 83);
            this.secondValueLabel.Name = "secondValueLabel";
            this.secondValueLabel.Size = new System.Drawing.Size(93, 13);
            this.secondValueLabel.TabIndex = 4;
            this.secondValueLabel.Text = "Второй полином:";
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(67, 166);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(247, 83);
            this.output.TabIndex = 5;
            this.output.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 261);
            this.Controls.Add(this.output);
            this.Controls.Add(this.secondValueLabel);
            this.Controls.Add(this.firstValueLabel);
            this.Controls.Add(this.secondValueTextBox);
            this.Controls.Add(this.firstValueTextBox);
            this.Controls.Add(this.countButton);
            this.Name = "Form1";
            this.Text = "Поиск изоморфизма полей Галуа характеристики 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button countButton;
        private System.Windows.Forms.TextBox firstValueTextBox;
        private System.Windows.Forms.TextBox secondValueTextBox;
        private System.Windows.Forms.Label firstValueLabel;
        private System.Windows.Forms.Label secondValueLabel;
        private System.Windows.Forms.RichTextBox output;
    }
}

