namespace CsharpTraining;

public class NestedLoop
{
    public static void NestedLoops()
    {
        int max = 15;
        
        for (int i = 0; i < max; i++)
        {
            for (int j = 0; j < max; j++)
            {
                if (max - j - 1 == i || j == i)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
        
        for (int i = 0; i < max; i++)
        {
            for (int j = 0; j < max; j++)
            {
                if ((max - j - 1 >= i && j >= i) || (max - j - 1 <= i && j <= i))
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
        
        int chessBoardSize = 8;

        for (int i = 0; i < chessBoardSize; i++)
        {
            for (int j = 0; j < chessBoardSize; j++)
            {
                if (i % 2 == 0)
                {
                    if (j % 2 == 0)
                    {
                        Console.Write("X");
                    }
                    else
                    {
                        Console.Write("O");
                    }
                }
                else
                {
                    if (j % 2 == 1)
                    {
                        Console.Write("X");
                    }
                    else
                    {
                        Console.Write("O");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}