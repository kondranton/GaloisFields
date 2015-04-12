using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SupportingLib;

namespace generationCheck
{
    public class IsomorphismDeterminator
    {
     public static uint[] p;
        public static uint[] suitablePermutation;
        static Polynomial divisor1;
        static Polynomial divisor2;

        static uint permutationLength;
        static bool[] used;
        static bool flag = false;
        public static void Determinate(int pos)
        {
            if (flag) return;
            if (pos == permutationLength)
            {
                bool foundSuitablePermutation = true;
                for (int i = 0; i < permutationLength; i++)
                {
                    Console.Write(p[i]);
                }
                Console.WriteLine();
                    for (uint i = 1; i < p.LongLength; i++)
                        for (uint j = 1; j < p.LongLength; j++)
                        {
                            Polynomial leftLeftMult = new Polynomial(p[i-1]);
                            Polynomial leftRightMult = new Polynomial(p[j-1]);
                            Polynomial rightLeft = new Polynomial(i);
                            Polynomial rightRight = new Polynomial(j);

                            foundSuitablePermutation &= (leftLeftMult * leftRightMult % divisor1).IntegerRepresentation == p[(rightLeft * rightRight % divisor2).IntegerRepresentation-1];
                        }
                if (foundSuitablePermutation)
                {
                    suitablePermutation = new uint[p.Length];
                    Array.Copy(p, suitablePermutation, p.Length);
                    flag = true;
                }
                
                return;
            }
            for (int i = 0; i < permutationLength; i++)
            {
                if (!used[i])
                {
                    used[i] = true;
                    p[pos] = (uint)(i + 1);

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
            p = new uint[FirstTable.Size-1];
            divisor1 = FirstTable.divisor;
            divisor2 = SecondTable.divisor;
            permutationLength = (uint)p.Length;
            used = new bool[permutationLength];
        }
        public static void Main(){
        PolynomialValidatior polynomialValidator = new PolynomialValidatior(Console.ReadLine(), Console.ReadLine());

            //Try to get valid values
            //try
            //{
                ulong[] validValues = polynomialValidator.getValidatedValues();
                Polynomial polynomial1 = new Polynomial(validValues[0]);
                Polynomial polynomial2 = new Polynomial(validValues[1]);

                FieldTable table1 = new FieldTable(polynomial1);
                FieldTable table2 = new FieldTable(polynomial2);

                IsomorphismDeterminator determinator = new IsomorphismDeterminator(table1, table2);
                IsomorphismDeterminator.Determinate(0);
                for (int i = 0; i < permutationLength; i++)
                {
                    Console.Write(IsomorphismDeterminator.suitablePermutation[i]);
                }
                    Console.ReadLine();
        }
    }

}
