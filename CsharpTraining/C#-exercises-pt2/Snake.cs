namespace CsharpTraining;

public class Snake : Animal
{
    public int numberOfLegs = 0;
    
    public override void Move()
    {
        Console.WriteLine("I'm a snake and I'm not that fast");
    }
}