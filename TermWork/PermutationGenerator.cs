using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportingLib
{
    public class PermutationGenerator
    {

        private int[] p;
        private int permutationLength;

        private bool IsOrderedPair(int left, int right)
        {
            return left < right;
        }
        private void SwapNumbers(int a, int b)
        {
            int c = p[a];
            p[a] = p[b];
            p[b] = c;
        }
        private int[] Iterate()
        {
            if (p == null)
            {
                //There is no permutation yet
                Initialize();
                return p;
            }
            //Previous permutation exists
            for (int i = p.Length - 1; i > 1; i--)
            {
                if (IsOrderedPair(p[i - 1], p[i]))
                {
                    int tearingNumberIndex = i - 1;
                    int length = (p.Length-1) - tearingNumberIndex;
                    
                    //Reorder the tail
                    Array.Sort(p, i, p.Length - i);

                    //Search for number to swap with tearing number
                    for (int j = i; j < p.Length; j++)
                    {
                        //The number should be greater than tearing
                        if (IsOrderedPair(p[tearingNumberIndex], p[j]))
                        {
                            SwapNumbers(tearingNumberIndex, j);
                            break;
                        }
                            
                    }
                    return p;
                }
            }

            //There is no suitable permutations left
            return null;
        }
        private void Initialize()
        {
            p = new int[permutationLength + 1];
            for (int i = 1; i < p.Length; i++) p[i] = i;
        }
        public int[] NextPermutation()
        {
            return Iterate();
        }
        public PermutationGenerator( int permutationLength)
        {
            this.permutationLength = permutationLength;
        }
    }
}
