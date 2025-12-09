namespace CsharpTraining;

public class BasicMethods
{
    public static void BasicMethod(String wantedName, int wantedAge)
    {
        Console.WriteLine(wantedName + " is " + wantedAge +  " years old.");
    }

    public static double Calculator()
    {
        double result = 0;
        
        Console.WriteLine("Please enter first number:");
        double firstNumber = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Please enter the second number:");
        double secondNumber = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Please enter one the symbols (+, -, *, /):");
        switch (Console.ReadLine())
        {
            case "+":
                result = firstNumber + secondNumber;
                Console.WriteLine($"$The result of: {firstNumber} + {secondNumber} = " + result);
                break;
            case "-":
                result = firstNumber - secondNumber;
                Console.WriteLine($"$The result of: {firstNumber} - {secondNumber} = " + result);
                break;
            case "*":
                result = firstNumber * secondNumber;
                Console.WriteLine($"$The result of: {firstNumber} * {secondNumber} = " + result);
                break;
            case "/":
                result = firstNumber / secondNumber;
                Console.WriteLine($"$The result of: {firstNumber} / {secondNumber} = " + result);
                break;
        }
        return result;
    }
    
    //method overloading
    public static String DescribeAnimal(String animalType, String animalName)
    {
        return "That's a " + animalType + ", it's name is " + animalName;
    }
    
    public static String DescribeAnimal(String animalType, String animalName, int  animalAge)
    {
        return "That's a " + animalType + ", it's name is " + animalName + " and it's " + animalAge + " years old.";
    }
    
    public static String DescribeAnimal(String animalType, double height)
    {
        return "That's a " + animalType + ", it's " + height + " centimeters tall.";
    }
    
    //params method
    public static double ShoppingCart(params double[] value)
    {
        double fullPrice = 0;

        foreach (double price in value)
        {
            fullPrice += price;
        }
        
        return fullPrice;
    }
}