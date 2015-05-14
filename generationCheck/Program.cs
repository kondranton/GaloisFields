using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SupportingLib;

namespace generationCheck
{
    class Program
    {
        public static void Main(){
            PermutationGenerator generator = new PermutationGenerator(4);
            int[] permutation = generator.NextPermutation();
            while(permutation!=null)
            {
            foreach(int n in permutation)
            {
                Console.Write(n);
            }
            Console.WriteLine();
            permutation = generator.NextPermutation();
            }


            Console.ReadLine();
}
    }
}
