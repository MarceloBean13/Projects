using System;
using System.Text;
using System.Text.RegularExpressions;

namespace StringToCamelCase
{
    class CompareMargin
    {
        static void Main(string[] args)
        {

        }

        public static int CloseCompare(double a, double b, double margin = 0)
        {

            if (a < b)
            {
                if (margin >= b - a && margin != 0 )
                    return 0;
                return -1;
            }
            else if (a > b)
            {
                if (margin >= a - b && margin != 0)
                    return 0;
                return 1;
            }
            else
                return 0;
        }
    }
}
