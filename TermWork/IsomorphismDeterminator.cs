using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GF2Lib;

namespace GF2Lib
{
    public class IsomorphismDeterminator
    {
        public const string CANCELLATION_TOKEN = "Операция отменена";

        private int[,] table1product;
        private int[,] table2product;
        private int[,] table1sum;
        private int[,] table2sum;

        private PermutationGenerator permutationGenerator;
        private long permutationsChecked = 0;
        public bool CancelationRequested;


        public delegate void ProgressDelegate(long currentValue, long totalValue);
        public event ProgressDelegate ProgressChanged;

        public string Determine()
        {
            int[] p = permutationGenerator.NextPermutation();

            while (p != null)
            {
                if (!CancelationRequested)
                {
                    bool permutationSuits = true;
                    if (p != null)
                        for (uint i = 1; i < p.Length; i++)
                        {
                            for (uint j = i; j < p.Length; j++)
                            {
                                permutationSuits &= table2product[p[i], p[j]] == p[table1product[i, j]];
                                permutationSuits &= table2sum[p[i], p[j]] == p[table1sum[i, j]];
                                if (!permutationSuits) break;
                            }

                            if (!permutationSuits) break;
                        }

                    ProgressChanged(++permutationsChecked, permutationGenerator.PossiblePermutationQuantity);
                    if (permutationSuits)
                    {
                        return stringFromPermutation(p);
                    }
                    p = permutationGenerator.NextPermutation();
                }
                else
                {
                    return CANCELLATION_TOKEN;
                }
            };
            return null;
        }

        private string stringFromPermutation(int[] permutation)
        {
            string outputString = "";
            for (int i = 1; i < permutation.Length; i++)
            {
                int number = permutation[i];
                outputString += number.ToString() + " ";
            }
            return outputString;
        }
        public IsomorphismDeterminator(FieldTable Table1, FieldTable Table2)
        {
            if (Table1.Size != Table2.Size)
            {
                throw new Exception("Степень многочленов не совпадает");
            }

            table1product = Table1.Content(FieldTable.FieldTableType.Multiplication);
            table2product = Table2.Content(FieldTable.FieldTableType.Multiplication);
            table1sum = Table1.Content(FieldTable.FieldTableType.Addition);
            table2sum = Table2.Content(FieldTable.FieldTableType.Addition);

            permutationGenerator = new PermutationGenerator(table1product.GetUpperBound(0), Table1.NeutralPairs, Table2.NeutralPairs);
        }
    }
}
