using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SupportingLib
{
    class FileServer
    {
        public FileServer(ulong[] isomorphism) {
            this.isomorphism = isomorphism;
        }

        private StreamWriter writer;

        ulong[] isomorphism;
        
        public void Write() 
        {
            if (writer == null) writer = new StreamWriter("log.txt");

            //Variable for the first line of permutation values
            uint standardRowElement = 1;
            string firstRowOfPermutation = "";
            string secondRowOfPermutation = "";
            foreach (var member in isomorphism)
            {
                //Cast to string
                string firstRowAdditionalElement = (standardRowElement++).ToString();
                string secondRowAdditionalElement = member.ToString();
                
                //Decide which element will define the width of the column
                int firstLength = firstRowAdditionalElement.Length;
                int secondLength = secondRowAdditionalElement.Length;
                int maxLength = firstLength > secondLength ? firstLength : secondLength;
               
                //Add formatted elements to rows
                firstRowOfPermutation += String.Format("|{0,{1}}|", firstRowAdditionalElement, maxLength);
                secondRowOfPermutation += String.Format("|{0,{1}}|", secondRowAdditionalElement, maxLength);
            }

            //Write in file
            writer.WriteLine(firstRowOfPermutation);
            writer.WriteLine(secondRowOfPermutation);
                  
                    writer.Flush();
            writer.Close();
        }
    }
}
