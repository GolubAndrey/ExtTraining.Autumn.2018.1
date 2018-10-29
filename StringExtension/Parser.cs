using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExtension
{
    public static class Parser
    {
        const int numberForConvertingToUpperRegister = 32;
        const int numberOfSymbolF = 70;
        static char[] sybmolsArray = { '0','1','2','3','4','5','6','7','8','9','A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K' };

        /*private int InndexInArray(char symbol)
        {
            for (int i=0;i<sybmolsArray.Length;i++)
            {
                if (symbol==sybmolsArray[i])
                {
                    return i;
                }
            }
            return -1;
        }*/

        //Checking input number
        private static bool CheckingNumber(string source,int @base)
        {
            char[] tempArray = new char[@base];
            Array.Copy(sybmolsArray, tempArray, @base);
            for (int i=0;i<source.Length;i++)
            {
                if (Array.IndexOf(tempArray, CheckingOnLowerSymbol(source[i])) == -1)
                    return false;
            }
            return true;
        }

        //Checking symbols on lower register and converting them to the upper
        private static char CheckingOnLowerSymbol(char symbol)
        {
            char result = symbol;
            if ((int)result > numberOfSymbolF)
            {
                result = Convert.ToChar((int)result - numberForConvertingToUpperRegister);
            }
            return result;
        }


        private static int ConvertToDecimalSystem(string source,int @base)
        {
            int counter = 0;
            int result = 0;
            for (int i=source.Length-1;i>=0;i--)
            {
                try
                {
                    result = checked(result + Array.IndexOf(sybmolsArray, CheckingOnLowerSymbol(source[i])) * (int)Math.Pow(@base, counter));
                }
                catch (OverflowException ex)
                {
                    return -1;
                }
                counter++;
            }
            return result;
        }
        public static int ToDecimal(this string source, int @base)
        {
            if (source==null)
            {
                throw new ArgumentNullException("Null source number");
            }
            if (@base>16 || @base <2)
            {
                throw new ArgumentOutOfRangeException("Base not in range 2<=base<=16");
            }
            if (!CheckingNumber(source,@base))
            {
                throw new ArgumentException("Invalid string");
            }
            int result = ConvertToDecimalSystem(source, @base);
            if (result==-1)
            {
                throw new ArgumentException();
            }
            return result;
        }
    }
}
