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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            this.сохранитьТаблицуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTXT = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCSV = new System.Windows.Forms.ToolStripMenuItem();
            this.helpButton = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutApp = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.labelTimer = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gridBottomTable = new System.Windows.Forms.DataGridView();
            this.checkBoxFindAll = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridLeftTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRightTable)).BeginInit();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBottomTable)).BeginInit();
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
            this.output.BackColor = System.Drawing.Color.Linen;
            this.output.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.output.Location = new System.Drawing.Point(12, 108);
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(555, 101);
            this.output.TabIndex = 5;
            this.output.Text = "";
            // 
            // radioButtonStandardMode
            // 
            this.radioButtonStandardMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonStandardMode.AutoSize = true;
            this.radioButtonStandardMode.Location = new System.Drawing.Point(293, 63);
            this.radioButtonStandardMode.Name = "radioButtonStandardMode";
            this.radioButtonStandardMode.Size = new System.Drawing.Size(96, 17);
            this.radioButtonStandardMode.TabIndex = 6;
            this.radioButtonStandardMode.Text = "Эксплуатация";
            this.radioButtonStandardMode.UseVisualStyleBackColor = true;
            this.radioButtonStandardMode.CheckedChanged += new System.EventHandler(this.radioButtonStandardMode_CheckedChanged);
            // 
            // radioButtonDemoMode
            // 
            this.radioButtonDemoMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonDemoMode.AutoSize = true;
            this.radioButtonDemoMode.Location = new System.Drawing.Point(415, 63);
            this.radioButtonDemoMode.Name = "radioButtonDemoMode";
            this.radioButtonDemoMode.Size = new System.Drawing.Size(101, 17);
            this.radioButtonDemoMode.TabIndex = 7;
            this.radioButtonDemoMode.Text = "Демонстрация";
            this.radioButtonDemoMode.UseVisualStyleBackColor = true;
            this.radioButtonDemoMode.CheckedChanged += new System.EventHandler(this.radioButtonDemoMode_CheckedChanged);
            // 
            // gridLeftTable
            // 
            this.gridLeftTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridLeftTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.gridLeftTable.BackgroundColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridLeftTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridLeftTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridLeftTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridLeftTable.Location = new System.Drawing.Point(12, 214);
            this.gridLeftTable.Name = "gridLeftTable";
            this.gridLeftTable.ReadOnly = true;
            this.gridLeftTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.gridLeftTable.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.gridLeftTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridLeftTable.ShowCellToolTips = false;
            this.gridLeftTable.Size = new System.Drawing.Size(248, 125);
            this.gridLeftTable.TabIndex = 8;
            // 
            // gridRightTable
            // 
            this.gridRightTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridRightTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.gridRightTable.BackgroundColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridRightTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridRightTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridRightTable.DefaultCellStyle = dataGridViewCellStyle4;
            this.gridRightTable.Location = new System.Drawing.Point(314, 214);
            this.gridRightTable.Name = "gridRightTable";
            this.gridRightTable.ReadOnly = true;
            this.gridRightTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.gridRightTable.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.gridRightTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridRightTable.ShowCellToolTips = false;
            this.gridRightTable.Size = new System.Drawing.Size(256, 125);
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
            this.сохранитьТаблицуToolStripMenuItem,
            this.helpButton,
            this.aboutApp});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(582, 24);
            this.menuStrip.TabIndex = 11;
            this.menuStrip.Text = "menuStrip1";
            // 
            // сохранитьТаблицуToolStripMenuItem
            // 
            this.сохранитьТаблицуToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveTXT,
            this.saveCSV});
            this.сохранитьТаблицуToolStripMenuItem.Name = "сохранитьТаблицуToolStripMenuItem";
            this.сохранитьТаблицуToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
            this.сохранитьТаблицуToolStripMenuItem.Text = "Сохранить таблицы";
            // 
            // saveTXT
            // 
            this.saveTXT.Name = "saveTXT";
            this.saveTXT.Size = new System.Drawing.Size(94, 22);
            this.saveTXT.Text = ".txt";
            this.saveTXT.Click += new System.EventHandler(this.saveTXT_Click);
            // 
            // saveCSV
            // 
            this.saveCSV.Name = "saveCSV";
            this.saveCSV.Size = new System.Drawing.Size(94, 22);
            this.saveCSV.Text = ".csv";
            this.saveCSV.Click += new System.EventHandler(this.saveCSV_Click);
            // 
            // helpButton
            // 
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(65, 20);
            this.helpButton.Text = "Справка";
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // aboutApp
            // 
            this.aboutApp.Name = "aboutApp";
            this.aboutApp.Size = new System.Drawing.Size(94, 20);
            this.aboutApp.Text = "О программе";
            this.aboutApp.Click += new System.EventHandler(this.aboutApp_Click);
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(12, 478);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(558, 23);
            this.progressBar.TabIndex = 12;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.ForeColor = System.Drawing.Color.Maroon;
            this.labelTimer.Location = new System.Drawing.Point(412, 92);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(49, 13);
            this.labelTimer.TabIndex = 13;
            this.labelTimer.Tag = "TTESSSF";
            this.labelTimer.Text = "0:0:0:0:0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(331, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Таймер";
            // 
            // gridBottomTable
            // 
            this.gridBottomTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridBottomTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.gridBottomTable.BackgroundColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridBottomTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gridBottomTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridBottomTable.DefaultCellStyle = dataGridViewCellStyle6;
            this.gridBottomTable.Location = new System.Drawing.Point(12, 345);
            this.gridBottomTable.Name = "gridBottomTable";
            this.gridBottomTable.ReadOnly = true;
            this.gridBottomTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.gridBottomTable.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.gridBottomTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridBottomTable.ShowCellToolTips = false;
            this.gridBottomTable.Size = new System.Drawing.Size(248, 125);
            this.gridBottomTable.TabIndex = 15;
            // 
            // checkBoxFindAll
            // 
            this.checkBoxFindAll.AutoSize = true;
            this.checkBoxFindAll.Location = new System.Drawing.Point(293, 40);
            this.checkBoxFindAll.Name = "checkBoxFindAll";
            this.checkBoxFindAll.Size = new System.Drawing.Size(158, 17);
            this.checkBoxFindAll.TabIndex = 16;
            this.checkBoxFindAll.Text = "Искать все перестановки";
            this.checkBoxFindAll.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(582, 510);
            this.Controls.Add(this.checkBoxFindAll);
            this.Controls.Add(this.gridBottomTable);
            this.Controls.Add(this.label2);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(618, 600);
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поиск изоморфизма полей Галуа характеристики 2";
            ((System.ComponentModel.ISupportInitialize)(this.gridLeftTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRightTable)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBottomTable)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem helpButton;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.ToolStripMenuItem сохранитьТаблицуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveTXT;
        private System.Windows.Forms.ToolStripMenuItem saveCSV;
        private System.Windows.Forms.ToolStripMenuItem aboutApp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gridBottomTable;
        private System.Windows.Forms.CheckBox checkBoxFindAll;
    }
}

