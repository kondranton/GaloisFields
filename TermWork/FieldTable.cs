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
        public Pairs NeutralPairs;

        private int SizeOfGaloisField
        {
            get { return 1 << (divisor.powerOfTheGreatestMember); }
        }
        public int[,] Content() {
                NeutralPairs = new Pairs(SizeOfGaloisField / 2 - 1);
                int size = SizeOfGaloisField;
                int[,] contentArray = new int[size, size];
                for(uint i = 1; i<contentArray.GetUpperBound(0)+1;i++)
                    for (uint j = i; j < contentArray.GetUpperBound(1) + 1; j++) {
 
                        Polynomial horizontalValue = new Polynomial(i);
                        Polynomial verticalValue = new Polynomial(j);

                        contentArray[i, j] = (int)(horizontalValue * verticalValue % divisor).IntegerRepresentation;
                        
                    }
                //Symmetric filling of the rest of the table
                for (uint i = 1; i < contentArray.GetUpperBound(0) + 1; i++)
                    for (uint j = i + 1; j < contentArray.GetUpperBound(1) + 1; j++)
                    { 
                        if (contentArray[i, j] == 1) NeutralPairs.AddPair(i, j);
                        contentArray[j, i] = contentArray[i, j];
                    }
                        

                return contentArray;
        }

        

        public FieldTable(Polynomial polynomialForTable) 
        {
            this.divisor = polynomialForTable;
           
        }
        public int Size{
            get {
               return SizeOfGaloisField;
            }
    }
        public string[] ToStrings()
        {
            string[] printableArray = new string[Content().GetUpperBound(0)];
            for (int i = 1; i< Content().GetUpperBound(0)+1; i++){
                string line = "";
                for (int j = 1; j < Content().GetUpperBound(1) + 1; j++)
                {
                    line += String.Format("{0,3} ", Content()[i, j]);
                }
                printableArray[i - 1] = line;
            }
            return printableArray;
        }
    }
    public class Pairs
    {
        public Tuple<uint, uint>[] PairArray;
        private uint spareItemIndex = 0;
        public Pairs(int quantity)
        {
            PairArray = new Tuple<uint, uint>[quantity];
        }
        public void AddPair(uint item1, uint item2)
        {
            PairArray[spareItemIndex++] = new Tuple<uint,uint>(item1,item2);
        }
        public int Length
        {
            get { return PairArray.Length; }
        }
        public void SwapValuesAtIndex(int index)
        {
            Tuple<uint,uint> chosenPair = PairArray[index];
            PairArray[index] = new Tuple<uint,uint>(chosenPair.Item2,chosenPair.Item1);
        }
        public Tuple<uint, uint> this[int i]
        {
            get { return PairArray[i]; }
            set { PairArray[i] = value; }
        }
    }
}
