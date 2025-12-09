namespace CsharpTraining;

public class WritingInput
{
    public static void WritingInputs()
    {
        String name = "";
        int age = 0;
        int birthYear = 0;
        
        try
        {
            Console.WriteLine("What is your name?:");
            name = Console.ReadLine();
        }
        catch (Exception e)
        {
            Console.WriteLine("You have to provide a name");
        }
        finally
        {
            Console.WriteLine("Nice to meet you " + name);
        }

        try
        {
            Console.WriteLine("And what is your age?:");
            age = Convert.ToInt32(Console.ReadLine());
            birthYear = 2025 - age;
        }
        catch (Exception e)
        {
            Console.WriteLine("You have to provide a year");
        }
        finally
        {
            Console.WriteLine("You were born in " + birthYear);
        }
        
        
        
        
    }
}