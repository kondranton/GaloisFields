using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SupportingLib;

namespace SupportingLib
{
    public class IsomorphismDeterminator
    {
        public static ulong[] p;
        public static ulong[] suitablePermutation;
        static ulong[,] FirstTable;
        static ulong[,] SecondTable;

        static uint permutationLength;
        static bool[] used;
        public static void Determinate(int pos)
        {
            if (pos == permutationLength)
            {
                bool foundSuitablePermutation = true;
                for (ulong i = 1; i < (ulong)p.LongLength; i++)
                    for (ulong j = i+1; j < (ulong)p.LongLength; j++)
                    {
                        foundSuitablePermutation &= FirstTable[p[i-1], p[j-1]] == p[SecondTable[i, j]-1];
                    }
                if (foundSuitablePermutation)
                {
                    suitablePermutation = new ulong[p.Length];
                    Array.Copy(p, suitablePermutation, p.Length);
         
                }
                return;
            }
            for (int i = 0; i < permutationLength; i++)
            {
                if (!used[i])
                {
                    used[i] = true;
                    p[pos] =(uint)i+1;

                    //Recursive call
                    Determinate(pos + 1);

                    p[pos] = 1; // debug only
                    used[i] = false;
                }
            }
        }
        public IsomorphismDeterminator(FieldTable FirstTable, FieldTable SecondTable) 
        {
            if (FirstTable.Size != SecondTable.Size) {
                throw new Exception("Степень многочленов не совпадает");
            }

            IsomorphismDeterminator.FirstTable = FirstTable.Content;
            IsomorphismDeterminator.SecondTable = SecondTable.Content;
            p = new ulong[IsomorphismDeterminator.FirstTable.GetUpperBound(0)];

            permutationLength = (uint)p.Length;
            used = new bool[permutationLength];
        }
    }
}
 