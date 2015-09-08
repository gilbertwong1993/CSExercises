using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex38
    {
        public static void Main(string[] args)
        {
            string[] name = new string[5] { "John", "Venkat", "Mary", "Victor", "Betty" };
            int[] mark = new int[5] { 63, 29, 75, 82, 55 };
            int i, temp;
            string temp1;
            Console.WriteLine("Sort By Mark.");
            Console.WriteLine("- - - - - - - - - -");
            for (i = 0; i < mark.Length; i++)
            {
                for (int j = i + 1; j < mark.Length; j++)
                {
                    if (mark[j] > mark[i])
                    {
                        temp = mark[i];
                        mark[i] = mark[j];
                        mark[j] = temp;
                        temp1 = name[i];
                        name[i] = name[j];
                        name[j] = temp1;
                    }
                }
                Console.WriteLine(name[i] + "\t" + mark[i]);
            }
            Console.WriteLine("\n");
            Console.WriteLine("Sort By Name.");
            Console.WriteLine("- - - - - - - - - -");
            for (i = 0; i < name.Length; i++)
            {
                for (int j = i + 1; j < name.Length; j++)
                {
                    if (string.CompareOrdinal(name[i], name[j]) > 0)
                    {
                        temp1 = name[i];
                        name[i] = name[j];
                        name[j] = temp1;
                        temp = mark[i];
                        mark[i] = mark[j];
                        mark[j] = temp;
                    }
                }
                Console.WriteLine(name[i] + "\t" + mark[i]);
            }
        }
    }
}