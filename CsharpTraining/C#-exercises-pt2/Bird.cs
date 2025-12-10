namespace CsharpTraining;

public class Bird : Animal
{
    public int numberOfLegs = 2;
    
    public override void Move()
    {
        Console.WriteLine("I'm a bird and I can fly");
    }
}