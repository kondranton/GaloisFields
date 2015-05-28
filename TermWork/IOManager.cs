using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GF2Lib
{
    public class IOManager
    {
        //Input
        public static Tuple<ulong, ulong> GetValidInput(string value1, string value2)
        {


            Tuple<ulong, ulong> resultValues;
            try
            {
                resultValues = new Tuple<ulong, ulong>(toUlong(value1), toUlong(value2));
            }
            catch
            {
                throw new Exception("Все поля должны содержать целочисленные значения!");
            }
            return resultValues;
        }
        private static ulong toUlong(string stringToParse)
        {
            return ulong.Parse(stringToParse);
        }

        //Output
        static private StreamWriter writer;

        public enum TableSaveMode
        {
            CSV,
            TXT
        }

        static public string CreateTableFile(FieldTable fieldTable, TableSaveMode savingMode, FieldTable.FieldTableType tableType)
        {
            string filenamePrefix = "GFTable";
            string fileExtension = "";
            string wordSeparator = "";
            string sumMark = "Sum";
            switch(savingMode)
            {
                case TableSaveMode.CSV:
                    fileExtension = ".csv";
                    wordSeparator = ";";
                    break;
                case TableSaveMode.TXT:
                    fileExtension = ".txt";
                    wordSeparator = " ";
                    break;
            }

            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string fileName = "";
            if(tableType == FieldTable.FieldTableType.Multiplication) 
                fileName = filenamePrefix + fieldTable.Divisor.IntegerRepresentation + fileExtension;
            else fileName = filenamePrefix + sumMark + fieldTable.Size + fileExtension;

            writer = new StreamWriter(path+"\\"+fileName);

            using (writer)
            {
                //Index of the last element in the line
                int tableBorderIndex = fieldTable.Size - 1;
                for (int i = 1; i < tableBorderIndex; i++)
                {
                    writer.Write(i + wordSeparator);
                }
                writer.Write(tableBorderIndex + "\n");

                int[,] tableContent = fieldTable.Content(tableType);
                for (int i = 1; i < fieldTable.Size; i++)
                {
                    for (int j = 1; j < tableBorderIndex; j++)
                    {
                        writer.Write(tableContent[i, j] + wordSeparator);
                    }
                    writer.Write(tableContent[i, tableBorderIndex] + "\n");
                }
            }
            return fileName;
        }
    }
}
