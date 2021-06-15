using System;
using System.Linq;
class MainClass {
   public class OzCalc
    {
        public static string[] answers = { "sure", "yes", "y", "why not?", "why not", "definitely", "for sure", "absolutely", "i guess", "okay","ok","k", "yeah" };
        public int Add(int firstnumber, int secondNumber)
        {
            return firstnumber + secondNumber;
        }

        protected int Substract(int firstNumber, int secondNumber)
        {
            return firstNumber - secondNumber;
        }
        protected bool AskToPlay(string game)
        {
            Console.WriteLine($"Ready to play {game}?");
            var userAnswer = Console.ReadLine();
            if (answers.Contains(userAnswer.ToLower()))
            {
                Console.WriteLine("Let's Play");
                return true;
            }
            else
            {
                System.Console.WriteLine("Maybe next time");
                return false;
            }

        }

        public static void RandomGuess()
        {
            var calc = new OzCalc();
            var askUser = calc.AskToPlay("Random Guess");
            if (!askUser)
                return;
   
            Console.WriteLine("Select mode:");
            Console.WriteLine("1) Quick");
            Console.WriteLine("2) Play to win");
            var mode = Convert.ToInt32(Console.ReadLine());
  var random = new Random();
            int randomNumber = random.Next(1, 10);
            Console.WriteLine("Please enter a number between 1 and 10...");
            if (mode == 1)
            {
                
                var userGuess = Convert.ToInt32(Console.ReadLine());
                if (userGuess == randomNumber)
                {
                    Console.WriteLine("Correct!");
                }
                else
                {
                    Console.WriteLine("Nope!");
                    Console.WriteLine($"The number was {randomNumber}");
                }
            }
            else
            {
                var userCorrect = false;
                while(!userCorrect)
                {
                    var userGuess = Convert.ToInt32(Console.ReadLine());
                    if (userGuess == randomNumber)
                    {
                        Console.WriteLine("Correct!");
                        userCorrect = true;
                    }
                    else
                    {
                        Console.WriteLine("Nope...");
                        Console.WriteLine("Guess again.");
                    }

                }

            }
        }
    }
  public static void Main (string[] args) {
   OzCalc.RandomGuess();
  }
}