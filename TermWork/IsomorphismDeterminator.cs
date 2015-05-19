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
        int[,] _table1;
        int[,] _table2;
        PermutationGenerator _permutationGenerator;

        public delegate void ProgressDelegate(int currentValue, int totalValue);
        public event ProgressDelegate ProgressChanged;

        public string Determinate()
        {
            int[] p = _permutationGenerator.NextPermutation();
            
            while (p != null)
            {
                bool permutationSuits = true;
                if(p != null)
                for (uint i = 1; i < p.Length; i++)
                {
                    for (uint j = i; j < p.Length; j++)
                    {
                        permutationSuits &= _table2[p[i], p[j]] == p[_table1[i, j]];
                        if (!permutationSuits) break;
                    }

                    if (!permutationSuits) break;
                }
                if (permutationSuits)
                {
                    return _stringFromPermutation(p);
                }
                ProgressChanged(1, p.Length);
                p = _permutationGenerator.NextPermutation();
            };

            //Probably input was not suitable
           // throw new Exception("Перестановка не найдена. Возможно входные данные не корректны");
            return "Нет результата";
        }
        private string _stringFromPermutation(int[] permutation)
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
            if (Table1.Size != Table2.Size) {
                throw new Exception("Степень многочленов не совпадает");
            }

            _table1 = Table1.Content();
            _table2 = Table2.Content();
            _permutationGenerator = new PermutationGenerator(_table1.GetUpperBound(0),Table1.NeutralPairs, Table2.NeutralPairs);
        }
    }
}
 