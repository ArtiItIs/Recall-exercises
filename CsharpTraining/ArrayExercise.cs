namespace CsharpTraining;

public class ArrayExercise
{
    public static void ArraysExc()
    {
        String[] dishes = { "Pancakes", "Pizza", "Curry", "Sushi", "Dumplings" };

        Console.WriteLine("for");
        for (int i = 0; i < dishes.Length; i++)
        {
            Console.WriteLine(dishes[i]);
        }

        Console.WriteLine("\nfor each");
        foreach (String dish in dishes)
        {
            Console.WriteLine(dish);
        }

        Console.WriteLine("First position before: " + dishes[0]);
        dishes[0] = "Tofu";
        Console.WriteLine("First position after: " + dishes[0]);
        
        //it would be the same as:
        String[] dishes2 = new string[5];
        
        dishes2[0] = "Pancakes";
        dishes2[1] = "Pizza";
        dishes2[2] = "Curry";
        dishes2[3] = "Sushi";
        dishes2[4] = "Dumplings";
    }
}