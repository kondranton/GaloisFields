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
        int[,] FirstTableContent;
        int[,] SecondTableContent;
        PermutationGenerator PermutationGenerator;

        public int[] Determinate()
        {
            int[] p = PermutationGenerator.NextPermutation();
            while (p != null)
            {
                bool foundSuitablePermutation = true;
                p = PermutationGenerator.NextPermutation();
                for (uint i = 1; i < p.Length; i++)
                {
                    for (uint j = i; j < p.Length; j++)
                    {
                        foundSuitablePermutation &= SecondTableContent[p[i], p[j]] == p[FirstTableContent[i, j]];
                        if (!foundSuitablePermutation) break;
                    }
                    if (!foundSuitablePermutation) break;
                }
                if (foundSuitablePermutation)
                {
                    return p;
                }
            }

            //Probably input was not suitable
            throw new Exception("Перестановка не найдена. Возможно Входные данные не корректны");
        }
        public IsomorphismDeterminator(FieldTable FirstTable, FieldTable SecondTable) 
        {
            if (FirstTable.Size != SecondTable.Size) {
                throw new Exception("Степень многочленов не совпадает");
            }

            FirstTableContent = FirstTable.Content;
            SecondTableContent = SecondTable.Content;
            PermutationGenerator = new PermutationGenerator(FirstTableContent.GetUpperBound(0));
        }
    }
}
 