﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that takes an integer as input and prints the square of that number.
//Program written by Gilbert Wong
namespace CSExercises
{
    public class Ex02
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The square of the number is {0}.", A * A);
        }
    }
}
