namespace CsharpTraining;

public class RobinHood : ICitizen, IRobber
{
    public void Work()
    {
        Console.WriteLine("Robin hood just gave something to the poor!");
    }

    public void Rob()
    {
        Console.WriteLine("Robin hood have stolen something from the rich!");
    }
}