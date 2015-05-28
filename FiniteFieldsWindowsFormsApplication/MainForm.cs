using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GF2Lib;

namespace FiniteFieldsWindowsFormsApplication
{
      
    public partial class MainForm : Form
    {

        private bool isCalculating;
        private bool demoModeIsOn;
        private bool cancelationRequested;

        public MainForm()
        {
            InitializeComponent();
            radioButtonStandardMode.Checked = true;
            
            //Initial field values
            isCalculating = false;
            demoModeIsOn = false;
        }

        private void countButton_Click(object sender, EventArgs e)
        {
             if (!isCalculating)
             {
                 isCalculating = true;
                 output.Text = "Производим вычисления...";
                 countButton.Text = "Отменить";
                 timerStart();
                 freezingEnabled(false);
                 performCalculationsAsync();
             }
             else
             {
                 timerStop();
                 freezingEnabled(true);
                 countButton.Text = "Вычислить";
             }
        }
        private void freezingEnabled(bool state)
        {
            radioButtonDemoMode.Enabled = state;
            radioButtonStandardMode.Enabled = state;
            checkBoxFindAll.Enabled = state;
            cancelationRequested = state;
        }
        async private void performCalculationsAsync()
        {

            try
            {
                FieldTable table1;
                FieldTable table2;
                getTablesFromTexts(out table1, out table2);

                if (demoModeIsOn)
                {
                    int[,] tableContentMult1 = table1.Content(FieldTable.FieldTableType.Multiplication);
                    int[,] tableContentMult2 = table2.Content(FieldTable.FieldTableType.Multiplication);
                    int[,] tableContentAdd = table1.Content(FieldTable.FieldTableType.Addition);

                    fillGrid(gridLeftTable,tableContentMult1);
                    fillGrid(gridRightTable,tableContentMult2);
                    fillGrid(gridBottomTable,tableContentAdd);
                }


                //Determining of the sutable permutation
                IsomorphismDeterminator determinator = new IsomorphismDeterminator(table1, table2);
                determinator.ProgressChanged +=
                    (currentValue, totalValue) =>
                    {
                        if (progressBar.InvokeRequired)
                        {
                            progressBar.Invoke(new MethodInvoker(() => progressBar.Value = (int)((double)currentValue / (double)totalValue * 100)));
                            determinator.CancelationRequested = cancelationRequested;
                        }
                    };
                if (checkBoxFindAll.Checked) 
                {
                    string[] resultingPermutations = await Task.Run(() => determinator.DetermineAll());
                    output.Lines = resultingPermutations;
                }
                else
                {
                    string resultingPermutation = await Task.Run(() => determinator.Determine());
                    output.Text = resultingPermutation;
                }
              
               
            }
            catch (OverflowException)
            {
                output.Text = "";
                MessageBox.Show("Введены слишком большие числа");
            }
            catch (Exception processionException)
            {
                output.Text = "";
                MessageBox.Show(processionException.Message);
            }
            finally
            {
                countButton.PerformClick();
                isCalculating = false;
            }
        }

        private void fillGrid(DataGridView grid, int[,] content)
        {
            grid.Rows.Clear();
            grid.Columns.Clear();
            grid.TopLeftHeaderCell.Value = content[1,1].ToString();
            int size = content.GetUpperBound(0) + 1;
            // Name the columns
            for (int i = 2; i < size; i++)
            {
                string nextColumnHeaderName = content[1, i].ToString();
                grid.Columns.Add(nextColumnHeaderName, nextColumnHeaderName);
            }

            //Add rows to the tables
            for (int i = 2; i < size; i++)
            {
                string[] row = new string[size];
                for (int j = 2; j < size; j++)
                {
                    row[j - 2] = content[i, j].ToString();
                }
                grid.Rows.Add(row);
                grid.Rows[i - 2].HeaderCell.Value = i.ToString();
            }
        }
        bool formIsMaximized = true;
        private void radioButtonStandardMode_CheckedChanged(object sender, EventArgs e)
        {
            demoModeIsOn = false;
            if (formIsMaximized)
            {
                formIsMaximized = false;
                changeFormHeight(false);
            }
            setInputState(true);
        }

        private void radioButtonDemoMode_CheckedChanged(object sender, EventArgs e)
        {
            demoModeIsOn = true;
            if (!formIsMaximized)
            {
                formIsMaximized = true;
                changeFormHeight(true);
            }
            int demoValue1 = 11;
            int demoValue2 = 13;
            firstValueTextBox.Text = demoValue1.ToString();
            secondValueTextBox.Text = demoValue2.ToString();
            setInputState(false);
        }

        private void setInputState(bool state)
        {
            firstValueTextBox.Enabled = state;
            secondValueTextBox.Enabled = state;
        }

        private void changeFormHeight(bool increase)
        {
            int spred = 5;
            int difference = gridLeftTable.Height + spred + gridBottomTable.Height;
            this.Height += increase? difference: -difference;
            if (increase)
            {
                gridLeftTable.Show();
                gridRightTable.Show();
            }
            else
            {
                gridLeftTable.Hide();
                gridRightTable.Hide();
            }
        }

        DateTime timerStartTime;
        private void timer_Tick(object sender, EventArgs e)
        {
            DateTime timerCurrentTime = DateTime.Now;
            TimeSpan timeSpan = timerCurrentTime.Subtract(timerStartTime);
            int days = timeSpan.Days;
            int hours = timeSpan.Hours;
            int minutes = timeSpan.Minutes;
            int seconds = timeSpan.Seconds;
            int milliseconds = timeSpan.Milliseconds;
            labelTimer.Text = String.Format("{0}:{1}:{2}:{3}:{4}",days, hours, minutes, seconds, milliseconds);
        }
     
        private void timerStart()
        {
            timerStartTime = DateTime.Now;
            timer.Start();
        }
        private void timerStop()
        {
            timer.Stop();
            timer_Tick(timer, null);
        }

        private void aboutApp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программу выполнил \nСтудент 1 курса ВШЭ ФКН ПИ \nКондрашов Антон Андреевич \nв 2014-2015 учебном году");
        }

        private void saveTXT_Click(object sender, EventArgs e)
        {
            try
            {
                saveTables(IOManager.TableSaveMode.TXT);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Введены слишком большие числа");
            }
            catch (Exception fail)
            {
                MessageBox.Show(fail.Message);
            }
            
           
        }

        private void saveCSV_Click(object sender, EventArgs e)
        {
            try
            {
                saveTables(IOManager.TableSaveMode.CSV);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Введены слишком большие числа");
            }
            catch (Exception fail)
            {
                MessageBox.Show(fail.Message);
            }
        }

        private void getTablesFromTexts(out FieldTable table1, out FieldTable table2)
        {
            Tuple<ulong, ulong> validValues = IOManager.GetValidInput(firstValueTextBox.Text, secondValueTextBox.Text);
            Polynomial polynomial1 = new Polynomial(validValues.Item1);
            Polynomial polynomial2 = new Polynomial(validValues.Item2);

            table1 = new FieldTable(polynomial1);
            table2 = new FieldTable(polynomial2);
        }
        private void saveTables(IOManager.TableSaveMode savingMode)
        {
            FieldTable table1;
            FieldTable table2;
            getTablesFromTexts(out table1, out table2);
            string tableName1 = IOManager.CreateTableFile(table1, savingMode, FieldTable.FieldTableType.Multiplication);
            string tableName2 = IOManager.CreateTableFile(table2, savingMode, FieldTable.FieldTableType.Multiplication);
            string tableName3 = IOManager.CreateTableFile(table1, savingMode, FieldTable.FieldTableType.Addition);
            MessageBox.Show("Таблицы сохранены на рабочем столе \nпод именами " + tableName1 + ", " + tableName2 + " и " + tableName3);
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            string message = "Многочлены степеней 1-5:\n1 : 2, 3\n2 : 7\n3 : 11, 13\n4 : 19, 25, 31\n5 : 37, 41, 47, 55, 59, 61";
            MessageBox.Show(message);
        }
    }
}
