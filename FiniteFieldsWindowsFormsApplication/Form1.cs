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
        public MainForm()
        {
            InitializeComponent();
        }

        private ulong ToUlongBitRepresentation(string stringToParse)
        {
            return Convert.ToUInt64(Convert.ToString(uint.Parse(stringToParse), 2));
        }

        private void countButton_Click(object sender, EventArgs e)
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

                

                int[,] tableContent1 = table1.Content;
                int[,] tableContent2 = table2.Content;
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
                                leftTableRow[j-1] = tableContent1[i, j].ToString();
                                rightTableRow[j-1] = tableContent2[i, j].ToString();
                        }
                        gridLeftTable.Rows.Add(leftTableRow);
                        gridRightTable.Rows.Add(rightTableRow);
                    }

                //Determining of the sutable permutation
                IsomorphismDeterminator determinator = new IsomorphismDeterminator(table1, table2);
                int[] resultingPermutation = determinator.Determinate();

                // Permutation output
                string outputString = "";
                for (int i = 1; i < resultingPermutation.Length; i++)
                {
                    int number = resultingPermutation[i];
                    outputString += number.ToString();
                }
                    output.Text = outputString;
            }
            //}
            //catch (Exception processionException)
            //{
            //    MessageBox.Show(processionException.Message);
            //}


        }


    }
}
