namespace CsharpTraining;

public class MathOperator
{
    public static void MathOperators()
    {
        int donuts = 3;
        
        //add 1:
        donuts++;
        //donuts = donuts + 1;
        //donuts += 1;
        
        Console.WriteLine("Donut counter: " + donuts);
        
        //decrement 1
        donuts--;
        //donuts = donuts - 1;
        //donuts -= 1;
        
        Console.WriteLine("Donut counter: " + donuts);
        
        //multiply 2
        //donuts = donuts * 2;
        donuts *= 2;
        
        Console.WriteLine("Donut counter: " + donuts);
        
        //divide 2
        //donuts = donuts / 2;
        donuts /= 2;

        double chocolate = 5;
        chocolate /= 2;
        
        Console.WriteLine("Donut counter: " + donuts);
        Console.WriteLine("Chocolate counter: " + chocolate);
        
        //modulo reminder
        donuts = 31;
        //donuts = donuts % 3;
        donuts %= 3;
        
        Console.WriteLine("Donut counter: " + donuts);
        
        //============================================
        //MATH METHODS

        double x = 5;

        //power of ...
        double y = Math.Pow(x, 3);
        Console.WriteLine("X to the power of 3: " + y);
        
        //square root of...
        double z = Math.Sqrt(x);
        Console.WriteLine("X's square root is: " + z);
        
        //rounding
        double a = 3.421;
        double b = Math.Round(a);
        double c = Math.Ceiling(a);
        double d = Math.Floor(a);
        
        Console.WriteLine("'a' rounded is: " + b + ", rounded up is: " + c + ", rounded down is: " + d);
        
        //max and min value
        double e = Math.Max(a, x);
        double f = Math.Min(a, x);
        Console.WriteLine("Max from 'a' and 'x' is: " + e);
        Console.WriteLine("Min from 'a' and 'x' is: " + f);
        
        //random numbers
        Random random = new Random();
        int rngNumber = random.Next(1, 21);

        Console.WriteLine("Your random number between 1 and 20: " + rngNumber);

        //random double between 0 and 1
        for (int i = 0; i < 3; i++)
        {
            double rngDouble = random.NextDouble();
            Console.WriteLine("Your random double number between 0 and 1: " + rngDouble);
        }
        
        //random double between min and max value
        for (int i = 0; i < 3; i++)
        {
            double rngDouble = random.NextDouble() * (20 - 1) + 1;
            Console.WriteLine("Your random double number between 0 and 1: " + rngDouble);
        }
        
        //EXERCISE: Program to find the hypotenuse of a triangle
        Console.WriteLine("Enter the length of A side: ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the length of B side: ");
        b = Convert.ToDouble(Console.ReadLine());
        
        c = Math.Sqrt((a * a) + (b * b));
        //c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
        
        Console.WriteLine("The triangle's hypotenuse is: " + c);
    }
}