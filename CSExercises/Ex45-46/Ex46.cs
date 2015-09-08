using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace CSExercises
{
    public class Ex46
    {
        public static void Main(string[] args)
        {
            int i;
            int j;
            // int [] n = new int[10]{0,1,2,3,4,5,6,7,8,9};
            int[] count1 = new int[10];
            int[] number = new int[50];

            Random rnd = new Random();


            for (i = 0; i < 50; i++)
            {
                number[i] = rnd.Next(0, 9);
                count1[number[i]]++;

            }

            System.Console.WriteLine("Number\tCount");
            for (i = 0; i < 10; i++)
            {
                System.Console.WriteLine(number[i] + "\t" + count1[i]);
            }

            System.Console.WriteLine("- - - - - - - - - - - - - -");
            System.Console.WriteLine("Number");

            for (i = 0; i < 10; i++)
            {

                System.Console.Write(number[i] + "\t");
                for (j = 0; j < number[i]; j++)
                {
                    System.Console.Write("*");
                }
                System.Console.WriteLine("\n");
            }

            System.Console.WriteLine("- - - - - - - - - - - - - -");


            int[] count2 = new int[11];
            int[] number2 = new int[50];

            for (i = 0; i < 50; i++)
            {
                number2[i] = rnd.Next(-5, 5);
                count2[number2[i] + 5]++;

            }

            System.Console.WriteLine("Number\tCount");
            for (i = 0; i < 11; i++)
            {
                System.Console.WriteLine(i - 5 + "\t" + count2[i]);
            }

            System.Console.WriteLine("- - - - - - - - - - - - - -");
            System.Console.WriteLine("Number");

            for (i = 0; i < 11; i++)
            {

                System.Console.Write(i - 5 + "\t");
                for (j = 0; j < count2[i]; j++)
                {
                    System.Console.Write("*");
                }
                System.Console.WriteLine("\n");
            }

        }
    }
}
