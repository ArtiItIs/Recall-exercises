namespace CsharpTraining;

public class Bird : Animal
{
    public int numberOfLegs = 2;
    
    public override void Move()
    {
        Console.WriteLine("I'm a bird and I can fly");
    }

    public override void Speak()
    {
        Console.WriteLine("Bird is chirping");
    }
}