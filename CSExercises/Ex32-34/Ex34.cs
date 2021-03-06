using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex34
    {
        public static void Main(string[] args)
        {
            int[,] score = new int[12, 4] { { 56, 84, 68, 29 },
                                            { 94, 73, 31, 89 },
                                            { 41, 63, 36, 90 },
                                            { 99, 9, 18, 17 },
                                            { 62, 3, 65, 75 },
                                            { 40, 96, 53, 23 },
                                            { 81, 15, 27, 30 },
                                            { 21, 70, 100, 22 },
                                            { 88, 50, 13, 12 },
                                            { 48, 54, 52, 78 },
                                            { 64, 71, 67, 25 },
                                            { 16, 93, 46, 72 } };
            int[] each = new int[12];
            for (int i = 0; i < 12; i++)
            {
                each[i] = score[i, 0] + score[i, 1] + score[i, 2] + score[i, 3];
                Console.WriteLine("The total mark of No {0} student is {1}", i, each[i]);
            }
            double firstscore = 0, secondscore = 0, thirdscore = 0, fourthscore = 0;
            for (int i = 0; i < 12; i++)
            {
                firstscore = firstscore + score[i, 0];
                secondscore = secondscore + score[i, 1];
                thirdscore = thirdscore + score[i, 2];
                fourthscore = fourthscore + score[i, 3];
            }
            firstscore = firstscore / 12;
            secondscore = secondscore / 12;
            thirdscore = thirdscore / 12;
            fourthscore = fourthscore / 12;
            Console.WriteLine("The average of first subject is " + firstscore);
            Console.WriteLine("The average of second subject is " + secondscore);
            Console.WriteLine("The average of third subject is " + thirdscore);
            Console.WriteLine("The average of fourth subject is " + fourthscore);
            double v1 = 0, v2 = 0, v3 = 0, v4 = 0;
            for (int i = 0; i < 12; i++)
            {
                v1 = v1 + Math.Pow(score[i, 0] - firstscore, 2);
                v2 = v2 + Math.Pow(score[i, 1] - secondscore, 2);
                v3 = v3 + Math.Pow(score[i, 2] - thirdscore, 2);
                v4 = v4 + Math.Pow(score[i, 3] - fourthscore, 2);
            }
            Console.WriteLine("The variance of first subject is " + v1 / 12);
            Console.WriteLine("The variance of second subject is " + v2 / 12);
            Console.WriteLine("The variance of third subject is " + v3 / 12);
            Console.WriteLine("The variance of fourth subject is " + v4 / 12);
            double total = (firstscore + secondscore + thirdscore + fourthscore) / 4;
            Console.WriteLine("The average of whole subject is " + total);
        }
    }
}
