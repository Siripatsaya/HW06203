using System;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            int score;
            score = int.Parse(Console.ReadLine());

            if ( score >= 80 && score <= 100)
            {
                Console.WriteLine("Your grade is A.");
            }
            else if (score >= 70 && score < 80 )
            {
                Console.WriteLine("Your grade is B.");
            }
            else if(score >= 60 && score < 70)
            {
                Console.WriteLine("Your grade is C.");
            }
            else if (score >= 50 && score < 60)
            {
                Console.WriteLine("Your grade is D.");
            }
            else if (score <= 49 && score >= 0)
            {
                Console.WriteLine("Your grade is F.");
            }
            else
            {
                Console.WriteLine("Please input your score again.");
                Console.WriteLine("The score between 0 to 100.");
            }       
            Console.ReadLine();
        }
    }
}
