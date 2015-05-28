using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GF2Lib
{
    public class Polynomial
    {
        private ulong integerRepresentation;

        public Polynomial(uint integerRepresentation) : this((ulong)integerRepresentation) { }

        public Polynomial(ulong integerRepresentation)
        {
            this.integerRepresentation = integerRepresentation;
        }
        public Polynomial() : this(0) { }

        private int this[int position]
        {
            get
            {
                if ((integerRepresentation | (1UL << position)) == integerRepresentation)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }

        }

        
        public int powerOfTheGreatestMember
        {
            get
            {
                int power = 0;
                for (int i = 0; i < 32; i++)
                {
                    if (this[i] == 1) power = i;
                }
                return power;
            }
        }

        public ulong IntegerRepresentation
        {
            get { return integerRepresentation; }
        }

        private static Polynomial Multiply(Polynomial a, Polynomial b)
        {
            if (a == null || b == null)
            {
                throw new ArgumentNullException("Provided argument is null");
            }

            ulong result = 0;
            for (int i = 0; i < 32; ++i)
            {
                if (a[i] == 0)
                {
                    continue;
                }

                result ^= (b.IntegerRepresentation << i);
            }

            return new Polynomial(result);
        }
        private static Polynomial DivideForRemainder(Polynomial dividend, Polynomial divisor)
        {
            if (dividend == null || divisor == null)
            {
                throw new ArgumentNullException("Значения не верны");
            }

            int mod = divisor.powerOfTheGreatestMember;

            Polynomial dividendMutatingToRemainder = dividend.Clone();
            while (dividendMutatingToRemainder.powerOfTheGreatestMember >= mod)
            {
                int powerDifference = dividendMutatingToRemainder.powerOfTheGreatestMember - divisor.powerOfTheGreatestMember;
                dividendMutatingToRemainder.integerRepresentation ^= (divisor.integerRepresentation << powerDifference);
            }

            return dividendMutatingToRemainder;
        }
        private static Polynomial Sum(Polynomial left, Polynomial right)
        {
            return new Polynomial(left.IntegerRepresentation ^ right.IntegerRepresentation);
        }

        /// <summary>
        /// Creates a full clone of an instance of polynomial
        /// </summary>
        /// <returns></returns>
        public Polynomial Clone()
        {
            return new Polynomial(this.IntegerRepresentation);
        }

        public static Polynomial operator *(Polynomial a, Polynomial b)
        {
            return Polynomial.Multiply(a, b);
        }

        public static Polynomial operator %(Polynomial a, Polynomial b)
        {
            return Polynomial.DivideForRemainder(a, b);
        }
        public static Polynomial operator +(Polynomial a, Polynomial b)
        {
            return Polynomial.Sum(a, b);
        }

        public override string ToString()
        {
            return string.Format("{0}", integerRepresentation);
        }
    }
}