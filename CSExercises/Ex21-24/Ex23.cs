using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//C#Exercises No.23
//Program written by Gilbert Wong
namespace CSExercises
{
    public class Ex23
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Let's guess a number(0-9)!");
            string A = Console.ReadLine();
            int m = Convert.ToInt32(A);
            Random r = new Random();
            int n = r.Next(0,10);
            int i = 1;
               while (m != n)
               {
                  Console.WriteLine("Try Again!");
                  m = Convert.ToInt32(Console.ReadLine());
                  i = i + 1;
               }
                  if (i <= 2)
                  {
                  Console.WriteLine("You are a Wizard!");
                  }
                  else if (i <= 5 ) 
                  {
                  Console.WriteLine("You are a good guess!");
                  }
                  else 
                  {
                  Console.WriteLine("You are lousy!");
                  }
        }
    }
}
