using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GF2Lib
{
    public class PermutationGenerator
    {

        private int[] p;
        private int permutationLength;
        private int inversions;
        private Pairs pairs1;
        private Pairs pairs2;
        private int[] indexArray;
        public long PossiblePermutationQuantity;

        private int[] iterate()
        {
            if (p == null)
            {
                initializePermutation();
                updatePermutation();
                return p;
            }//There is no permutation yet

                //Previous permutation exists
                for (int i = indexArray.Length - 1; i > 0; i--)
                {
                    if (inOrder(indexArray[i - 1], indexArray[i]))
                    {
                        int tearingNumberIndex = i-1;

                        //Reorder the tail of permutation
                        int startingIndex = tearingNumberIndex + 1;
                        int sortingLength = indexArray.Length - tearingNumberIndex - 1;
                        Array.Sort(indexArray, startingIndex, sortingLength);

                        //Search for the number to swap with tearing number
                        for (int j = tearingNumberIndex; j < indexArray.Length; j++)
                        {
                            //The number should be greater than tearing
                            if (inOrder(indexArray[tearingNumberIndex], indexArray[j]))
                            {
                                swapValues(tearingNumberIndex, j, indexArray);
                                break;
                            }
                        }
                        updatePermutation();
                        return p;
                    }
                }
                int inversionIndex = nextInversionIndex();
                if (inversions == 2 << (permutationLength / 2 - 1))
                    return null; //There is no suitable permutations left

                pairs1.SwapValuesAtIndex(inversionIndex);
                resetIndexArray();
                updatePermutation();
                return p;
        }
        private void swapValues(int a, int b, int[] array)
        {
            int c = array[a];
            array[a] = array[b];
            array[b] = c;
        }
        private bool inOrder(int left, int right)
        {
            return left < right;
        }
        private int nextInversionIndex()
        {
            int previousInversions = inversions++;
            return indexOfFlag(inversions, previousInversions);
        }
        private int indexOfFlag(int minuend, int subtrahend)
        {
            for (int i = 0; i < 16; i++)
            {
                if (flagAtPosition(i, minuend))
                    if (!flagAtPosition(i, subtrahend))
                        return i;
            }
            return -1;
        }
        private bool flagAtPosition(int position, int flagKeeper)
        {
            if ((flagKeeper | (1 << position)) == flagKeeper)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void updatePermutation()
        {
            for (int i = 0; i < pairs1.Length; i++)
            {
                p[pairs1[indexArray[i]].Item1] = (int)pairs2[i].Item1;
                p[pairs1[indexArray[i]].Item2] = (int)pairs2[i].Item2;
            }
        }
        private void initializePermutation()
        {
            p = new int[permutationLength + 1];
            for (int i = 1; i < p.Length; i++) p[i] = i;
            resetIndexArray();
        }
        private void resetIndexArray()
        {
            for (int i = 0; i < indexArray.Length; i++) indexArray[i] = i;
        }
        private long factorial(long fact)
        {
            if (fact == 1) return 1;
            return factorial(fact - 1) * fact;
        }
        public int[] NextPermutation()
        {
            return iterate();
        }
       
        public PermutationGenerator(int permutationLength , Pairs pairs1, Pairs pairs2)
        {
            if (!pairs1.IsFull || !pairs2.IsFull) throw new Exception("Введенные многочлены не являются неприводимыми.");
            this.pairs1 = pairs1;
            this.pairs2 = pairs2;
            indexArray = new int[pairs1.Length];
            inversions = 0;
            this.permutationLength = permutationLength;
            unchecked 
            { 
                PossiblePermutationQuantity = (2 << (permutationLength / 2 - 1))*factorial((permutationLength / 2));
            }
        }
    }
}
