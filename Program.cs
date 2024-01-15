using System.Collections.Concurrent;

namespace GuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            int min = 1;
            int max = 100;
            int guess;
            int number;
            int guesses;
            string response;

            while (playAgain)
            {
                guess = 0;
                guesses = 0;
                //response = string.Empty;
                response = "" ;
                number = random.Next(min, max+1);
            


                while (guess != number)
                {
                    Console.WriteLine("Guess a number between {0} and {1}", min, max);
                    //Console.WriteLine($"Guess a number between {min} and {max} : ");
                    //guess = int.Parse(Console.ReadLine());
                   
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Guess" + guess);
                    Console.WriteLine();
                    if (guess < number)
                    {
                        Console.WriteLine(guess + " is too low!");
                    }
                    else if (guess > number)
                    {
                        Console.WriteLine(guess + " is too high!");
                    }
                    guesses++;
                }
                Console.WriteLine($"Number {number}");
                Console.WriteLine("YOU WIN!");
                Console.WriteLine($" It took you {guesses} Gusses");

                Console.WriteLine("Would you like to play again? (Y/N): ");
                
                response = Console.ReadLine() ;
                response = response.ToUpper();

                if (response == "Y")
                { playAgain = true; }
                else
                {
                    playAgain = false;
                }
            }
           
            Console.WriteLine();
            Console.WriteLine("Thanks for playing! ... I guess");
            Console.Beep();
            Console.ReadKey();
        }
    }
}