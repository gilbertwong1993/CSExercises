using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace CSExercises
{
    public class Ex45
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Please enter a number");
            double s = Convert.ToDouble(Console.ReadLine());
            int i;
            double h;
            double f;
            double t;
            double ff;

            h = Math.Floor(s);
            for (i = 0; i < h; i++)
            {
                System.Console.WriteLine("100c");

            }



            if ((s - h) * 10 >= 5.0)
            {
                f = 1;
                System.Console.WriteLine("50c");

                double ti = (s - h) * 100 - 50;
                if (ti > 35)
                    t = 2;
                else if (ti > 15)
                    t = 1;
                else
                    t = 0;
                for (i = 0; i < t; i++)
                {
                    System.Console.WriteLine("20c");
                }

                ff = (ti - t * 20) / 3;
                for (i = 1; i < ff; i++)
                {
                    System.Console.WriteLine("5c");
                }


            }
            else
            {
                double ti = (s - h) * 100;
                if (ti > 35)
                    t = 2;
                else if (ti > 15)
                    t = 1;
                else
                    t = 0;
                for (i = 0; i < t; i++)
                {
                    System.Console.WriteLine("20c");
                }

                ff = (ti - t * 20) / 3;
                for (i = 0; i < ff; i++)
                {
                    System.Console.WriteLine("5c");
                }

            }



        }
    }
}
