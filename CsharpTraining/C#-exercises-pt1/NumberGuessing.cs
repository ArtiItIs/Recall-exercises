namespace CsharpTraining;

public class NumberGuessing
{
    public static void NumbGuess()
    {
        Random rnd = new Random();
        
        Console.WriteLine("Welcome to number guessing game!");
        int min = 1;
        int max = 100;
        int number = rnd.Next(min, max + 1);
        int guessCounter = 0;
        bool correctGuess = false;
        int guessedNumber;
        
        while (correctGuess == false)
        {
            Console.WriteLine("Please enter a number between " + min + " and " + max + ":");
            guessedNumber = Convert.ToInt32(Console.ReadLine());
            guessCounter++;
            if (guessedNumber == number)
            {
                Console.WriteLine("You were right! Your number was: " + guessedNumber + "!");
                Console.WriteLine("You guessed in " + guessCounter + " tries!");
                correctGuess = true;
            }
            else if (guessedNumber > number)
            {
                max = guessedNumber;
                Console.WriteLine("Your number was too high! Current highest number is: " + max);
            }
            else
            {
                min = guessedNumber;
                Console.WriteLine("Your number was too low! Current lowest number is: " + min);
            }
        }
    }
}