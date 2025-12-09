namespace CsharpTraining;

public class StringModification
{
    public static void StringMethods()
    {
        String location = "Polish Mountain";

        location = location.ToUpper();
        Console.WriteLine(location);
        
        location = location.ToLower();
        Console.WriteLine(location);

        String nameSpelling = "D a n n y D e V i t o";
        nameSpelling = nameSpelling.Replace(" ", "-");
        Console.WriteLine(nameSpelling);

        String fullName = nameSpelling.Replace("-", "").Insert(0, "Mr. ");
        Console.WriteLine(fullName); 
        
        Console.WriteLine("Enter your full name: ");
        fullName = Console.ReadLine();
        Console.WriteLine("Your full name has " + fullName.Length + " characters.");

        fullName = "Jack Black";
        String firstName = fullName.Substring(0, 4);
        String lastName = fullName.Substring(5, 5);
        Console.WriteLine(firstName + " " + lastName);
        
        
        //String interpolation
        String carBrand = "Chevrolet";
        String carModel = "Corvette";
        double horsePower = 495.0;

        Console.WriteLine($"This {carBrand} {carModel} is offering {horsePower} horse power!");
    }
}