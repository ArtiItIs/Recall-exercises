namespace CsharpTraining;

public class BasicVariable
{
    public static void BasicVariables()
    {
        int x = 1670;
        int y;
        y = x + 30;
        
        Console.WriteLine("X: "+ x + "\nY: " + y);

        int age = 24;
        double weight = 75.5;
        bool alive = false;
        
        Console.WriteLine("Your age is: " + age);
        Console.WriteLine("Your weight is: " + weight);

        if (alive)
            Console.WriteLine("Your alive");
        else
            Console.WriteLine("Your not alive :c");

        char exclamation = '!';
        Console.WriteLine("Are you alive? " + alive + exclamation);

        String someEmail = "randomEmail@gmail.com";

        //constant: immutable value that will not change for the life of program
        const double unchangeableNumber = 12.4123;
        Console.WriteLine("This number will not change: " +  unchangeableNumber);

        double a = 55.22;
        int b = Convert.ToInt32(a);
        
        Console.WriteLine("double a: " + a);
        Console.WriteLine("a type: " + a.GetType());

        Console.WriteLine("converted from double b: " + b);
        Console.WriteLine("b type: " + b.GetType());

        int c = 111;
        double d = Convert.ToDouble(c) + 0.1;
        
        Console.WriteLine("converted from int d: " + d);
        Console.WriteLine("d type: " + d.GetType());

        int e = 222;
        String f = Convert.ToString(e);
        
        Console.WriteLine("converted from int f: " + f);
        Console.WriteLine("f type: " + f.GetType());
    }
}