using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportingLib
{
    public class FieldTable
    {
        public Polynomial divisor;

        private int getSizeOfGaloisField()
        {
            return 1 << (divisor.powerOfTheGreatestMember);
        }
        public int[,] Content {
            get{
                int size = getSizeOfGaloisField();
                int[,] contentArray = new int[size, size];
                for(uint i = 1; i<contentArray.GetUpperBound(0)+1;i++)
                    for (uint j = 1; j < contentArray.GetUpperBound(1) + 1; j++) {
 
                        Polynomial horizontalValue = new Polynomial(i);
                        Polynomial verticalValue = new Polynomial(j);

                        contentArray[i, j] = (int)(horizontalValue * verticalValue % divisor).IntegerRepresentation;
                    }
                return contentArray;
            }
        }

        public FieldTable(Polynomial polynomialForTable) 
        {
            this.divisor = polynomialForTable;
        }
        public int Size{
            get {
               return Content.GetUpperBound(0)+1;
            }
    }
        public string[] ToStrings()
        {
            string[] printableArray = new string[Content.GetUpperBound(0)];
            for (int i = 1; i< Content.GetUpperBound(0)+1; i++){
                string line = "";
                for (int j = 1; j < Content.GetUpperBound(1) + 1; j++)
                {
                    line += String.Format("{0,3} ", Content[i, j]);
                }
                printableArray[i - 1] = line;
            }
            return printableArray;
        }
    }
}
