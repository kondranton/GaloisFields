using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GF2Lib
{
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
            Tuple<uint, uint> chosenPair = PairArray[index];
            PairArray[index] = new Tuple<uint, uint>(chosenPair.Item2, chosenPair.Item1);
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
