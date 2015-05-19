using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SupportingLib;

namespace FiniteFieldsWindowsFormsApplication
{
      
    public partial class MainForm : Form
    {
        const int millisecondsInSecond = 100;
        const int timeConst = 60;

        public MainForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            radioButtonStandardMode.Checked = true;
            timer.Interval = millisecondsInSecond;
           
        }

        private ulong ToUlongBitRepresentation(string stringToParse)
        {
            return Convert.ToUInt64(Convert.ToString(uint.Parse(stringToParse), 2));
        }
        private void countButton_Click(object sender, EventArgs e)
        {
            timer.Start();
            PerformCalculationsAsync();
        }
        async private void PerformCalculationsAsync()
        {
            PolynomialValidatior polynomialValidator = new PolynomialValidatior(firstValueTextBox.Text, secondValueTextBox.Text);

            //Try to get valid values
            //try
            //{
            checked
            {
                ulong[] validValues = polynomialValidator.getValidatedValues();
                Polynomial polynomial1 = new Polynomial(validValues[0]);
                Polynomial polynomial2 = new Polynomial(validValues[1]);

                FieldTable table1 = new FieldTable(polynomial1);
                FieldTable table2 = new FieldTable(polynomial2);



                int[,] tableContent1 = table1.Content();
                int[,] tableContent2 = table2.Content();
                int size = tableContent1.GetUpperBound(0) + 1;

                // Name the columns
                for (int i = 1; i < size; i++)
                {
                    string leftTableHeaderName = tableContent1[1, i].ToString();
                    string rightTableHeaderName = tableContent2[1, i].ToString();
                    gridLeftTable.Columns.Add(leftTableHeaderName, leftTableHeaderName);
                    gridRightTable.Columns.Add(rightTableHeaderName, rightTableHeaderName);
                }

                //Add rows to the tables
                for (int i = 2; i < size; i++)
                {
                    string[] leftTableRow = new string[size];
                    string[] rightTableRow = new string[size];
                    for (int j = 1; j < size; j++)
                    {
                        leftTableRow[j - 1] = tableContent1[i, j].ToString();
                        rightTableRow[j - 1] = tableContent2[i, j].ToString();
                    }
                    gridLeftTable.Rows.Add(leftTableRow);
                    gridRightTable.Rows.Add(rightTableRow);
                }

                
                //Determining of the sutable permutation
                IsomorphismDeterminator determinator = new IsomorphismDeterminator(table1, table2);
                determinator.ProgressChanged +=
                    (currentValue, totalValue) =>
                    {
                        progressBar.Value = (int)((double)currentValue/(double)totalValue*100);
                    };
                string resultingPermutation = await Task.Run(() => determinator.Determinate());
                
                // Permutation output
                output.Text = resultingPermutation;
                timer.Stop();
            }
            //}
            //catch (Exception processionException)
            //{
            //    MessageBox.Show(processionException.Message);
            //}
        }

        private void radioButtonStandardMode_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.ActiveForm.Height -= gridLeftTable.Height;
            gridLeftTable.Hide();
            gridRightTable.Hide();
            
        }

        private void radioButtonDemoMode_CheckedChanged(object sender, EventArgs e)
        {
            gridLeftTable.Show();
            gridRightTable.Show();
            MainForm.ActiveForm.Height += gridLeftTable.Height;
        }

      
        long tenthsSecondsFromStart = 0;
        private void timer_Tick(object sender, EventArgs e)
        {
            tenthsSecondsFromStart += 1;
            long hours = tenthsSecondsFromStart / (timeConst*timeConst) /10;
            long minutes = (tenthsSecondsFromStart / timeConst / 10) % timeConst;
            long seconds = (tenthsSecondsFromStart/10) % timeConst;
            long tenths = tenthsSecondsFromStart % 10;
            
            labelTimer.Text = String.Format("{0}:{1}:{2}:{3}", hours, minutes, seconds,tenths);
        }

       
    }
}
