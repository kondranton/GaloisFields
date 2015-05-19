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
            this.components = new System.ComponentModel.Container();
            this.countButton = new System.Windows.Forms.Button();
            this.firstValueTextBox = new System.Windows.Forms.TextBox();
            this.secondValueTextBox = new System.Windows.Forms.TextBox();
            this.firstValueLabel = new System.Windows.Forms.Label();
            this.secondValueLabel = new System.Windows.Forms.Label();
            this.output = new System.Windows.Forms.RichTextBox();
            this.radioButtonStandardMode = new System.Windows.Forms.RadioButton();
            this.radioButtonDemoMode = new System.Windows.Forms.RadioButton();
            this.gridLeftTable = new System.Windows.Forms.DataGridView();
            this.gridRightTable = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.labelTimer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridLeftTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRightTable)).BeginInit();
            this.menuStrip.SuspendLayout();
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
            this.firstValueTextBox.Location = new System.Drawing.Point(12, 63);
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
            this.firstValueLabel.Location = new System.Drawing.Point(9, 47);
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
            this.output.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.output.Location = new System.Drawing.Point(12, 108);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(575, 101);
            this.output.TabIndex = 5;
            this.output.Text = "";
            // 
            // radioButtonStandardMode
            // 
            this.radioButtonStandardMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonStandardMode.AutoSize = true;
            this.radioButtonStandardMode.Location = new System.Drawing.Point(300, 63);
            this.radioButtonStandardMode.Name = "radioButtonStandardMode";
            this.radioButtonStandardMode.Size = new System.Drawing.Size(109, 17);
            this.radioButtonStandardMode.TabIndex = 6;
            this.radioButtonStandardMode.Text = "Обычный режим";
            this.radioButtonStandardMode.UseVisualStyleBackColor = true;
            this.radioButtonStandardMode.CheckedChanged += new System.EventHandler(this.radioButtonStandardMode_CheckedChanged);
            // 
            // radioButtonDemoMode
            // 
            this.radioButtonDemoMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonDemoMode.AutoSize = true;
            this.radioButtonDemoMode.Location = new System.Drawing.Point(415, 63);
            this.radioButtonDemoMode.Name = "radioButtonDemoMode";
            this.radioButtonDemoMode.Size = new System.Drawing.Size(164, 17);
            this.radioButtonDemoMode.TabIndex = 7;
            this.radioButtonDemoMode.Text = "Демонстрационный режим";
            this.radioButtonDemoMode.UseVisualStyleBackColor = true;
            this.radioButtonDemoMode.CheckedChanged += new System.EventHandler(this.radioButtonDemoMode_CheckedChanged);
            // 
            // gridLeftTable
            // 
            this.gridLeftTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridLeftTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.gridLeftTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLeftTable.Location = new System.Drawing.Point(12, 214);
            this.gridLeftTable.Name = "gridLeftTable";
            this.gridLeftTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.gridLeftTable.Size = new System.Drawing.Size(248, 140);
            this.gridLeftTable.TabIndex = 8;
            // 
            // gridRightTable
            // 
            this.gridRightTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridRightTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.gridRightTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRightTable.Location = new System.Drawing.Point(334, 214);
            this.gridRightTable.Name = "gridRightTable";
            this.gridRightTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.gridRightTable.Size = new System.Drawing.Size(256, 140);
            this.gridRightTable.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ответ:";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(602, 24);
            this.menuStrip.TabIndex = 11;
            this.menuStrip.Text = "menuStrip1";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(12, 363);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(578, 23);
            this.progressBar.TabIndex = 12;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Location = new System.Drawing.Point(412, 92);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(33, 13);
            this.labelTimer.TabIndex = 13;
            this.labelTimer.Text = "Timer";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 395);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridRightTable);
            this.Controls.Add(this.gridLeftTable);
            this.Controls.Add(this.radioButtonDemoMode);
            this.Controls.Add(this.radioButtonStandardMode);
            this.Controls.Add(this.output);
            this.Controls.Add(this.secondValueLabel);
            this.Controls.Add(this.firstValueLabel);
            this.Controls.Add(this.secondValueTextBox);
            this.Controls.Add(this.firstValueTextBox);
            this.Controls.Add(this.countButton);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "Поиск изоморфизма полей Галуа характеристики 2";
            ((System.ComponentModel.ISupportInitialize)(this.gridLeftTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRightTable)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
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
        private System.Windows.Forms.RadioButton radioButtonStandardMode;
        private System.Windows.Forms.RadioButton radioButtonDemoMode;
        private System.Windows.Forms.DataGridView gridLeftTable;
        private System.Windows.Forms.DataGridView gridRightTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label labelTimer;
    }
}

