using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//C#Exercises No.21
//Program written by Gilbert Wong
namespace CSExercises
{
    public class Ex21
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer");
            int A = Convert.ToInt32(Console.ReadLine());
            while(A != 88)
            {
                Console.WriteLine("Enter an integer again");
                A = Convert.ToInt32(Console.ReadLine());
            }
                Console.WriteLine("Lucky you...");
        }
    }
}

