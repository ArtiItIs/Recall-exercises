namespace CsharpTraining;

public class Exceptions
{
    public static void ExceptionExercise()
    {
        String[] cars = {"Chevrolet", "Ford", "Toyota", "Mercedes"};
        try
        {
            for (int i = 0; i < cars.Length+1; i++)
            {
                Console.WriteLine(cars[i]);
            }
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }

        //============================================
        
        Console.WriteLine("What is your age?");
        int age = Convert.ToInt32(Console.ReadLine());

        if (age < 18)
        {
            throw new ArithmeticException("You need to be 18 years old");
        }
        else
        {
            Console.WriteLine("You're an adult");
        }
        
        //============================================

        double x;
        double y;
        double z;
        
        Console.WriteLine("Which number do you want to divide?");
        try
        {
            Console.WriteLine("Enter your first number: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter your second number: ");
            y = Convert.ToDouble(Console.ReadLine());

            if (y == 0 || x == 0)
            {
                throw new DivideByZeroException();
            }

            z = x / y;

            Console.WriteLine("Your result is: " + z);
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine("You can't divide by zero");
        }
        catch (FormatException e)
        {
            Console.WriteLine("You can only provide numbers");
        }
        finally
        {
            Console.WriteLine("Thanks for stopping by! Have a great day!");
        }
    }
}