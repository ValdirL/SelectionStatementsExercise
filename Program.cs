using System;

namespace SelectionStatementsExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1, 1000);

            Console.WriteLine("Try to guess my favorite number");

            var userInput = int.Parse(Console.ReadLine());

            if (userInput < favNumber)
            {
                Console.WriteLine("too low");

            }
            else if (userInput > favNumber)
            {
                Console.WriteLine("too high");
            }
            else
            {
                Console.WriteLine("nevermind");
            }

            Console.WriteLine("What is your favorite school subject?");

            var subject = Console.ReadLine();

            switch (subject)
            {
                case "math":
                    Console.WriteLine("You must be great with numbers!");
                    break;
                case "english":
                    Console.WriteLine("Maybe you'll be a writer some day!");
                    break;
                case "spanish":
                    Console.WriteLine("Always good to speak multiple langauges!");
                    break;
                case "history":
                    Console.WriteLine("Don't be afraid of critical race theory. Its only the truth.");
                    break;
                case "science":
                    Console.WriteLine("Our next great doctor!");
                    break;
                default:
                    break;



            }




        }
    }
}
