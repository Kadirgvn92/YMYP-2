using static System.Net.Mime.MediaTypeNames;

namespace NumberGuessingGameConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, My name is Number Guessing Game");
        Console.WriteLine("I want to play a game");
        Console.WriteLine("I will keep a number in my mind. I will ask you to guess");
        Random random = new Random();
        int guessNumber = random.Next(1, 15);

        while (true)
        {
            Console.WriteLine("What is the number I keep in mind");
            string response = Console.ReadLine();
            int responseNumber = 0;
            bool isConvertSuccess = int.TryParse(response, out responseNumber);
            if (isConvertSuccess == false)
            {
                Console.WriteLine("Your answer is wrong");
            }
            else
            {
                if (responseNumber == guessNumber)
                {
                    Console.WriteLine("Congrats you win");
                    break;
                }
                else
                {
                    Console.WriteLine("your answer is wrong");
                }
            }
        }



    }
}
