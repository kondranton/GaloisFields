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

                IsomorphismDeterminator determinator = new IsomorphismDeterminator(table1, table2);
                IsomorphismDeterminator.Determinate(0);

                string outputString = "";
                foreach (var item in IsomorphismDeterminator.suitablePermutation)
                {
                    outputString += item.ToString();
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
