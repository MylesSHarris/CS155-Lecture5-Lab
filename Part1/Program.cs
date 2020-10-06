using System;

namespace Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numberGenerator = new Random();

            int number = numberGenerator.Next(100);
            int guesses = 0;

            while (true)
            {
                Console.Write("Guess a number between 0 and 100: ");

                int guess = Int32.Parse(Console.ReadLine());
                guesses++;

                if (guess < number)
                {
                    Console.WriteLine("Try a higher number.");
                }
                else if (guess > number)
                {
                    Console.WriteLine("Try a lower number.");
                }
                else
                {
                    Console.WriteLine($"You got thhe number in {guesses} guesses.");
                    break;
                }
            }
        }
    }
}
