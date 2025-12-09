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
        //============================================
        
        //jagged array (array of arrays)
        String[][] menu = new String[3][]; //we cannot specify second index at the time of compilation

        //to specify size of the second index we have to specify another array inside the previous one
        menu[0] = new String[2];
        menu[1] = new String[3];
        menu[2] = new String[1];
        
        menu[0][0] = "Pancakes";
        menu[0][1] = "Ice cream";
        menu[1][0] = "Pizza";
        menu[1][1] = "Curry";
        menu[1][2] = "Sushi";
        menu[2][0] = "Tea";

        for (int i = 0; i < menu.Length; i++)
        {
            for (int j = 0; j < menu[i].Length; j++)
            {
                Console.Write(menu[i][j] + " ");
            }
            Console.WriteLine();
        }
        //============================================
        
        //multidimensional array
        //every {} must have the same ammount of values as other array
        String[,] menu2 =
        {
            { "Pancakes", "Ice cream", "Cheesecake"},
            { "Pizza", "Curry", "Sushi" },
            { "Tea", "Coffee", "Lemonade"}
        };

        foreach (String dish in menu2)
        {
            Console.WriteLine(dish);
        }

        Console.WriteLine();
        
        //updating the value
        menu2[1, 1] = "Burger";

        for (int i = 0; i < menu2.GetLength(0); i++)
        {
            for (int j = 0; j < menu2.GetLength(1); j++)
            {
                Console.Write(menu2[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}