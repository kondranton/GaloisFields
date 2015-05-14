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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.gridLeftTable = new System.Windows.Forms.DataGridView();
            this.gridRightTable = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridLeftTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRightTable)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // countButton
            // 
            this.countButton.Location = new System.Drawing.Point(214, 63);
            this.countButton.Name = "countButton";
            this.countButton.Size = new System.Drawing.Size(75, 23);
            this.countButton.TabIndex = 0;
            this.countButton.Text = "Вычислить";
            this.countButton.UseVisualStyleBackColor = true;
            this.countButton.Click += new System.EventHandler(this.countButton_Click);
            // 
            // firstValueTextBox
            // 
            this.firstValueTextBox.Location = new System.Drawing.Point(15, 63);
            this.firstValueTextBox.Name = "firstValueTextBox";
            this.firstValueTextBox.Size = new System.Drawing.Size(94, 20);
            this.firstValueTextBox.TabIndex = 1;
            // 
            // secondValueTextBox
            // 
            this.secondValueTextBox.Location = new System.Drawing.Point(118, 63);
            this.secondValueTextBox.Name = "secondValueTextBox";
            this.secondValueTextBox.Size = new System.Drawing.Size(90, 20);
            this.secondValueTextBox.TabIndex = 2;
            // 
            // firstValueLabel
            // 
            this.firstValueLabel.AutoSize = true;
            this.firstValueLabel.Location = new System.Drawing.Point(12, 47);
            this.firstValueLabel.Name = "firstValueLabel";
            this.firstValueLabel.Size = new System.Drawing.Size(97, 13);
            this.firstValueLabel.TabIndex = 3;
            this.firstValueLabel.Text = "Первый полином:";
            // 
            // secondValueLabel
            // 
            this.secondValueLabel.AutoSize = true;
            this.secondValueLabel.Location = new System.Drawing.Point(115, 47);
            this.secondValueLabel.Name = "secondValueLabel";
            this.secondValueLabel.Size = new System.Drawing.Size(93, 13);
            this.secondValueLabel.TabIndex = 4;
            this.secondValueLabel.Text = "Второй полином:";
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(15, 359);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(274, 92);
            this.output.TabIndex = 5;
            this.output.Text = "";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(300, 63);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(109, 17);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Обычный режим";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(415, 63);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(164, 17);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Демонстрационный режим";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // gridLeftTable
            // 
            this.gridLeftTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridLeftTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.gridLeftTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLeftTable.Location = new System.Drawing.Point(15, 92);
            this.gridLeftTable.Name = "gridLeftTable";
            this.gridLeftTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.gridLeftTable.Size = new System.Drawing.Size(274, 248);
            this.gridLeftTable.TabIndex = 8;
            // 
            // gridRightTable
            // 
            this.gridRightTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridRightTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.gridRightTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRightTable.Location = new System.Drawing.Point(300, 92);
            this.gridRightTable.Name = "gridRightTable";
            this.gridRightTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.gridRightTable.Size = new System.Drawing.Size(274, 248);
            this.gridRightTable.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ответ:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(602, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 492);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridRightTable);
            this.Controls.Add(this.gridLeftTable);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.output);
            this.Controls.Add(this.secondValueLabel);
            this.Controls.Add(this.firstValueLabel);
            this.Controls.Add(this.secondValueTextBox);
            this.Controls.Add(this.firstValueTextBox);
            this.Controls.Add(this.countButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Поиск изоморфизма полей Галуа характеристики 2";
            ((System.ComponentModel.ISupportInitialize)(this.gridLeftTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRightTable)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.DataGridView gridLeftTable;
        private System.Windows.Forms.DataGridView gridRightTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
    }
}

