using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*The ABC Company pays its employees salary plus benefits.
 The benefits are calculated as a percentage of the salary.
 The company pays every employee 10% housing allowance and 3% transport allowance.
 Write a  program that takes the salary as input and prints the total income
  (salary + housing allowance + transport allowrance) as output.
 Format the output in currency output.*/
//Program written by Gilbert Wong
namespace CSExercises
{
    public class Ex07
    {
        public static void Main(string[] args)
        {
            double salary,housingallowrance,transportallowrance,total;
            Console.WriteLine("Enter the salary");
            salary = Convert.ToDouble(Console.ReadLine());
            housingallowrance = salary/10;
            transportallowrance = salary * 0.03;
            total = salary+housingallowrance+transportallowrance;
            string A = String.Format("Total income:{0:C}", total);
            Console.WriteLine(A);
        }
    }
}
