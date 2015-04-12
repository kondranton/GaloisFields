using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportingLib
{
    public class PolynomialValidatior
    {
        string firstValue, secondValue;
        
        public ulong[] getValidatedValues()
        {

            ulong[] resultValues = new ulong[2];
           
            try 
            {
                resultValues[0] = ToUlong(firstValue); 
                resultValues[1] = ToUlong(secondValue);
            }
            catch
            {
                throw new Exception("Введены некорректные значения!");
            }
            return resultValues;
        }
        public PolynomialValidatior(string firstValue, string secondValue)
        {
            this.firstValue = firstValue;
            this.secondValue = secondValue;
        }

        private ulong ToUlong(string stringToParse){
            return ulong.Parse(stringToParse);
        }

        

    }
}
