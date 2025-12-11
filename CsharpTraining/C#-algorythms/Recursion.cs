namespace CsharpTraining.C__algorythms;

public class Recursion
{
    public static void Countdown(int number)
    {
        if (number > 0)
        {
            Console.Write(number + " ");
            Countdown(number - 1);
        }
    }

    public static void ShowArrayVal(int[] arr, int index)
    {
        if (index >= arr.Length)
        {
            return;
        }
        
        Console.Write(arr[index] + " ");
        
        ShowArrayVal(arr, index + 1);
    }

    public static void ShowListVal(List<String> arr, int index)
    {
        if (index >= arr.Count)
        {
            return;
        }

        Console.Write(arr[index] + " ");
        ShowListVal(arr, index + 1);
    }

    public static int Factorial(int n)
    {
        if (n == 1)
        {
            return 1;
        }
        else
        {
            return (n * Factorial(n - 1));
        }
    }
}