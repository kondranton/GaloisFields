using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GF2Lib
{
    public class FieldTable
    {
        public Polynomial Divisor;
        public Pairs NeutralPairs;

        public enum FieldTableType
        {
            Addition,
            Multiplication
        }
        public int[,] Content(FieldTableType type) {
                NeutralPairs = new Pairs(Size / 2 - 1);
                int[,] contentArray = new int[Size, Size];
                //Upper triangular filling of the table
                for(uint i = 1; i<contentArray.GetUpperBound(0)+1;i++)
                    for (uint j = i; j < contentArray.GetUpperBound(1) + 1; j++) {

                        Polynomial horizontalValue = new Polynomial(i);
                        Polynomial verticalValue = new Polynomial(j);

                        if(type == FieldTableType.Multiplication)
                        contentArray[i, j] = (int)(horizontalValue * verticalValue % Divisor).IntegerRepresentation;
                        else
                        contentArray[i, j] = (int)(horizontalValue + verticalValue % Divisor).IntegerRepresentation;
                       

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
        public int Size
        {
            get { return 1 << (Divisor.powerOfTheGreatestMember); }
        }

        public FieldTable(Polynomial polynomialForTable)
        {
            this.Divisor = polynomialForTable;

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
            if (!this.IsFull)
            {
                PairArray[spareItemIndex++] = new Tuple<uint, uint>(item1, item2);
            }
        }
        public void SwapValuesAtIndex(int index)
        {
            Tuple<uint,uint> chosenPair = PairArray[index];
            PairArray[index] = new Tuple<uint,uint>(chosenPair.Item2,chosenPair.Item1);
        }
        public bool IsFull
        {
            get { return PairArray[Length - 1] != null; }
        }
          public int Length
        {
            get { return PairArray.Length; }
        }
        public Tuple<uint, uint> this[int i]
        {
            get { return PairArray[i]; }
            set { PairArray[i] = value; }
        }
    }
}
