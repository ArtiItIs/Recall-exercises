namespace CsharpTraining;

public abstract class Animal
{
    //public int numberOfLegs;

    public abstract void Move();

    /*
    //if class is not abstract we can use 'virtual' with body:
    public virtual void Move()
    {
        Console.WriteLine("Catch me!");
    }
    */

    public virtual void Speak()
    {
        Console.WriteLine("Animal speaking");
    }
}