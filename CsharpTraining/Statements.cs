namespace CsharpTraining;

public class Statements
{
    public static void BasicStatements()
    {
        //if statements
        Console.WriteLine("Please enter your age: ");
        int age =  Convert.ToInt32(Console.ReadLine());

        if (age >= 18)
        {
            Console.WriteLine("You can learn to drive a car!");
        }
        else if (age == 17)
        {
            Console.WriteLine("You can only take the driving theory test.");
        }
        else
        {
            Console.WriteLine("Aren't you too young to drive a car?");
        }
        
        Console.WriteLine("Please enter your nick name: ");
        String nickName = Console.ReadLine();

        if (nickName != "")
        {
            Console.WriteLine("Welcome " + nickName);
        }
        else
        {
            Console.WriteLine("You forgot to enter your nick name!");
        }
        
        Console.WriteLine("Please enter your login: ");
        String login = Console.ReadLine();

        if (login.Length > 5)
        {
            Console.WriteLine("Your login is valid");
        }
        else
        {
            Console.WriteLine("Your login should be at least 6 characters long!");
        }
        
        //switch case
        Console.WriteLine("Please enter your new password: ");
        String password = Console.ReadLine();
        
        switch (password.Length)
        {
            case < 6:
                Console.WriteLine("Very weak password!");
                break;
            case < 8:
                Console.WriteLine("Weak password!");
                break;
            case < 15:
                Console.WriteLine("Strong password!");
                break;
            default:
                Console.WriteLine("Is that even possible to remember?");
                break;
        }
        
        //AND / OR
        if (password.Length >= 8 && password.Length <= 15)
        {
            Console.WriteLine("Your password is valid");
        }
        else if (password.Length < 6 || password.Length > 15)
        {
            Console.WriteLine("Why don't you try again?");
        }
        else
        {
            Console.WriteLine("Your password's strength is medium");
        }
        
        //while loop
        Console.WriteLine("Please enter your security number: ");
        String secNumber = Console.ReadLine();

        while (secNumber.Length < 5 || secNumber.Length > 15)
        {
            Console.WriteLine("Your security number should have between 5 to 15 characters!");
            Console.WriteLine("Please enter your security number again: ");
            secNumber = Console.ReadLine();
        }
        
        Console.WriteLine("Your security number is: " + secNumber);
        
        //do while loop
        String secNumber2;
        do
        {
            Console.WriteLine("Please enter your second security number (It should be 5 to 15 characters long): ");
            secNumber2 = Console.ReadLine();
            Console.WriteLine("You've entered" + secNumber2);
        } while (secNumber2.Length < 5 || secNumber2.Length > 15);

        //for loop
        int countToFive = 0;
        for (int i = 0; i < 5; i++)
        {
            countToFive++;
            Console.WriteLine(countToFive);
        }
        
        Random rnd = new Random();
        int randomNumber;
        for (int i = 0; i < 25; i++)
        {
            randomNumber = rnd.Next(1, 10);
            Console.Write(randomNumber);
        }
    }
}