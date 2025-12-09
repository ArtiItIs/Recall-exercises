using System.IO.Pipes;

namespace CsharpTraining;

public class Person
{
    public String personName;
    public int personAge;
    
    //constructor
    public Person(String personName, int personAge)
    {
        this.personName = personName;
        this.personAge = personAge;
    }

    public void Run()
    {
        Console.WriteLine($"Run {personName} run!");
    }

    public static void Race()
    {
        Console.WriteLine("Everyone start running!");
    }

    public void StopRunning()
    {
        Console.WriteLine(personName + " will never stop!");
    }
}