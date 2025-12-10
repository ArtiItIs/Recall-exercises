namespace CsharpTraining;

public class Criminal : IRobber
{
    public void Rob()
    {
        Console.WriteLine("This criminal just robbed somebody!");
    }
}