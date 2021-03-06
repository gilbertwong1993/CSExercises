using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSExercises
{
    public class Ex43
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Decimal\tHex");
            System.Console.WriteLine("-  -  -  -  -  ");
            int n;
            for (n = 1; n < 101; n++)
            {
                System.Console.WriteLine("{0}\t{1}", n, Hex(n));
            }

        }
        public static string Hex(int i)
        {
            string s = "";
            string h = "";

            do
            {
                int rem = i % 16;
                i /= 16;
                if (rem < 10)
                    s += rem;
                else if (rem == 10)
                    s += "A";
                else if (rem == 11)
                    s += "B";
                else if (rem == 12)
                    s += "C";
                else if (rem == 13)
                    s += "D";
                else if (rem == 14)
                    s += "E";
                else if (rem == 15)
                    s += "F";
            } while (i != 0);

            for (int j = s.Length - 1; j >= 0; j--)
            {
                h += s.Substring(j, 1);
            }
            return h;

        }
    }
}
