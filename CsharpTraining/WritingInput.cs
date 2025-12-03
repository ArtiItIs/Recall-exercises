namespace CsharpTraining;

public class WritingInput
{
    public static void WritingInputs()
    {
        Console.WriteLine("What is your name?:");
        String name = Console.ReadLine();
        Console.WriteLine("And what is your age?:");
        int age = Convert.ToInt32(Console.ReadLine());
        int birthYear = 2025 - age;
        
        Console.WriteLine("Nice to meet you " + name);
        Console.WriteLine("You were born in " + birthYear);
    }
}