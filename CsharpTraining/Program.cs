namespace CsharpTraining;

class Program
{
    static void Main(string[] args)
    {

        //variable types, type conversion examples
        //BasicVariable.BasicVariables();
        //============================================
        
        //user input
        //WritingInput.WritingInputs();
        //============================================
        
        //operators, math methods and random numbers (+Exercise)
        //MathOperator.MathOperators();
        //============================================
        
        //String methods, string interpolation
        //StringModification.StringMethods();
        //============================================
        
        //basic statements (if, for, while, switch, AND/OR)
        //Statements.BasicStatements();
        //============================================
        
        //nested loops exercises!
        //NestedLoop.NestedLoops();
        //============================================
        
        //arrays
        //ArrayExercise.ArraysExc();
        //============================================
        
        //number guessing exercise game
        //NumberGuessing.NumbGuess();
        //============================================
        
        //methods (with calculator exercise)
        /*
        String methodName = "Adam";
        int methodAge = 24;
        BasicMethods.BasicMethod(methodName, methodAge);
        Console.WriteLine("Your number is: " + BasicMethods.Calculator());
        
        String animalType = "Dog";
        String animalName = "Lana";
        int animalAge = 4;
        double animalHeight = 45.5;

        //Console.WriteLine(BasicMethods.DescribeAnimal(animalType, animalName));
        Console.WriteLine(BasicMethods.DescribeAnimal(animalType, animalName, animalAge));
        Console.WriteLine(BasicMethods.DescribeAnimal(animalType, animalHeight));

        Console.WriteLine(BasicMethods.ShoppingCart(11.9, 15.2, 11.2, 0.99) + " eur");
        */
        //============================================
        
        //simple exercise with exceptions
        //Exceptions.ExceptionExercise();
        //============================================
        
        //class objects, constructors, static modifier
        
        //Person class
        /*
        Person person1 = new Person("Forest", 40);
        Person person2 = new Person("Barry", 28);
        */
        
        //if there was no constructor then program will use empty one
        //then we can assign values to the object
        /* 
        person1.personName = "Forest";
        person1.personAge = 40;
        person2.personName = "Barry";
        person2.personAge = 28;
        */
        
        //Person.Race();
        //person1.Run();
        //person1.StopRunning();
        
        
        //House class
        /*
        House house1 = new House(48, 3, "Somewhere 20/2, Warsaw", 1, "white");
        House mansion = new House(400, 40, "In the middle of nowhere, ???", 3, "wooden");

        house1.HouseEvaluation();
        mansion.HouseEvaluation();

        Console.WriteLine("There are " + House.numberOfHouses + " houses on the list");
        */
        
        //overloaded constructors
        //Computer computer = new Computer("RTX 3080", "i7-1500", 32, "Windows 11", "LG 4k");
        //Computer laptop = new Computer("RTX 3050ti", "i9-9000", 16, "Windows 11");
        
        //inheritance
        Dog dog = new Dog();
        Bird bird = new Bird();
        Snake snake = new Snake();

        Console.WriteLine("I have " + dog.numberOfLegs  + " legs");
        dog.Move();
        Console.WriteLine("I have " + bird.numberOfLegs  + " legs");
        bird.Move();
        Console.WriteLine("I have " + snake.numberOfLegs  + " legs");
        snake.Move();
    }
}