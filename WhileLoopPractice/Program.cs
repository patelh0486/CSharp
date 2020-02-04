/*use of sentinel control loop, create a console app that allows the user to enter a list of valid grades until
 an invalid grade is entere. Determined the following:-
 1. the class average(ensure the count is positive)
 2. number of students who has earned A, B, C
 3. Draw stars according to the count*/


using System;
using static System.Console;
namespace WhileLoopPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int total = 0;
            int countA = 0;
            int countB = 0;
            int countC = 0;
            int countF = 0;

            WriteLine($"Enter student's grade: ");
            int grade = Convert.ToInt32(ReadLine());
            while (grade >= 0)
            {
                count++;
                total = total + grade;

                if (grade >= 90 && grade <= 100)
                {
                    countA++;
                }

                if (grade >= 80 && grade <= 89)
                {
                    countB++;
                }

                if (grade >= 60 && grade <= 79)
                {
                    countC++;
                }
                if (grade < 60 )
                {
                    countF++;
                }

                WriteLine($"Enter student's grade: ");
                 grade = Convert.ToInt32(ReadLine());

            }

            WriteLine($" C# Students' total : " + total);

            if (count >= 0)
            {
                double average = (double)total / count;
                WriteLine($" C# Students' Average : " + average);
            }

            Write($"Number of A grade: ");
            int starA = 0;
            while(starA < countA)
            {
                Write(" * " );
                starA++;
            }
            WriteLine("( " + countA + ")");

            Write($"Number of B grade: ");
            int starB = 0;
            while (starB < countB)
            {
                Write(" * ");
                starB++;
            }
            WriteLine("( " + countB + ")");

            Write($"Number of C grade: ");
            int starC = 0;
            while (starC < countC)
            {
                Write(" * ");
                starC++;
            }
            WriteLine("( " + countC + ")");

            Write($"Number of F grade: ");
            int starF = 0;
            while (starF < countF)
            {
                Write(" * ");
                starF++;
            }
            WriteLine("( " + countF + ")");

        }
    }
}
