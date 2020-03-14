using System;

namespace Recursive_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
       
            Console.WriteLine("\nAverage ten scores");
            Grade10();

            Console.WriteLine("\nAverage a specific number of scores");
            Console.Write("Enter the number of scores: ");
            GradeSpec(int.Parse(Console.ReadLine()));

            Console.WriteLine("\nAverage a non-specific number of scores");
            GradeUnSpec();

            Console.Write("Enter the number of the Fibonacci series: ");
            int iterations = int.Parse(Console.ReadLine());
            FibPhi(iterations);

        }



        // Assign letter grades
        private static string LetterGrade(double score, int i = 0)
        {
            int[] Scores = { 60, 70, 80, 90, 100 };
            string[] Letters = { "F", "D", "C", "B", "A" };

            if (score >= Scores[i])
                return LetterGrade(score, i + 1);
            else
            {
                return Letters[i];
            }
        }



        // Average ten scores
        private static int Grade10(int count = 0, int sum = 0)
        {
            Console.Write("Please enter a score:  ");
            sum += int.Parse(Console.ReadLine());
            count += 1;

            if (count < 10)
                return Grade10(count, sum);
            else
            {
                int AvgScore = sum / 10;
                string AvgLetter = LetterGrade(AvgScore);
                Console.WriteLine($"The student's averge score is {AvgScore}.");
                Console.WriteLine($"The student's letter grade is {AvgLetter}.");
                return AvgScore;
            }
        }



        // Average a specific number of scores
        private static int GradeSpec(int Spec, int count = 0, int sum = 0)
        {
            Console.Write("Please enter a score:  ");
            sum += int.Parse(Console.ReadLine());
            count += 1;

            if (count < Spec)
                return GradeSpec(Spec, count, sum);
            else
            {
                int AvgScore = sum / Spec;
                string AvgLetter = LetterGrade(AvgScore);
                Console.WriteLine($"The student's averge score is {AvgScore}.");
                Console.WriteLine($"The student's letter grade is {AvgLetter}.");
                return AvgScore;
            }
        }



        // Average a non-specific number of scores
        private static int GradeUnSpec(int count = 0, int sum = 0)
        {
            Console.Write("Please enter a score:  ");
            var input = int.Parse(Console.ReadLine());
            

            if (input != -1)
            {
                sum += input;
                count += 1;
                return GradeUnSpec(count, sum);
            }

            else
            {
                var AvgScore = sum / count;
                string AvgLetter = LetterGrade(AvgScore);
                Console.WriteLine($"The student's averge score is {AvgScore}.");
                Console.WriteLine($"The student's letter grade is {AvgLetter}.");
                return AvgScore;
            }
                
        }



        // Calculate phi
        private static double FibPhi(int iterations, int count = 1, long first = 1, long second = 1)
        {
            Console.WriteLine($"{count}. {first} + {second} = {first + second} ");
            count += 1;
            long newfirst = second;
            long newsecond = first + second;           

            if (count < iterations)
                return (FibPhi(iterations, count, newfirst, newsecond));
            else
            {
                var phi = 1.0 * newsecond / newfirst;
                Console.WriteLine($"{count}. phi is {phi}");
                return phi;
            }
                
        }

    }
}
