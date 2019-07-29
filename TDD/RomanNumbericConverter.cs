using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD
{
    class RomanNumeralConverter
    {
        //1 - I
        //5 - V
        //10 - X
        internal static string GetNumeral(int number)
        {

            string RomanNumber = string.Empty;
            int div3 = number % 3;
            int div5 = number % 5;
            int div10 = number % 10;

            if (number % 10 == 0)
            {
                RomanNumber = "X";
            }
            else if (number > 5 && number < 9)
            {
                RomanNumber = GetNumeral(5) + GetNumeral(number - 5);
            }
            else if (number % 5 == 0)
            {
                RomanNumber = "V";
            }
            else if (number == 4)
            {
                RomanNumber = "IV";
            }
            else if (number <= 3)
            {
                for (int i = 1; i < 4; i++)
                {
                    if (i <= number)
                        RomanNumber = RomanNumber + "I";
                }
            }
            return RomanNumber;
        }

        //internal static string GetNumeral(int number)
        //{
        //    string RomanNumber = string.Empty;
        //    //for (int i = 1; i <= number; i++)
        //    //{
        //        if ( i < 4)
        //        {
        //            RomanNumber += "I";
        //        }
        //        else if(i <=5 )
        //        {
        //            if (i % 5 == 0)
        //                RomanNumber = "V";
        //            //else if (i % 4 == 0)
        //            //    RomanNumber = "IV";
        //        }
        //    //}

        //    return RomanNumber;
        //}
    }
}
