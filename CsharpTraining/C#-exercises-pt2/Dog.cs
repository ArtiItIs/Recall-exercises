namespace CsharpTraining;

public class Dog : Animal
{
    public int numberOfLegs = 4;

    public override void Move()
    {
        Console.WriteLine("I'm a dog and I move fast");
    }
}