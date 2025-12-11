using CsharpTraining.C__algorythms;

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
        
        /*
        Dog dog = new Dog();
        Bird bird = new Bird();
        Snake snake = new Snake();

        Console.WriteLine("I have " + dog.numberOfLegs  + " legs");
        dog.Move();
        Console.WriteLine("I have " + bird.numberOfLegs  + " legs");
        bird.Move();
        Console.WriteLine("I have " + snake.numberOfLegs  + " legs");
        snake.Move();
        */
        //============================================
        
        //array of objects

        /*
        Person[] classroom = new Person[5];

        Person person1 = new Person("Chris", 15);
        Person person2 = new Person("Annie", 19);
        Person person3 = new Person("Jane", 17);
        Person person4 = new Person("Nicole", 18);
        Person person5 = new Person("Brian", 18);

        classroom[0] = person1;
        classroom[1] = person2;
        classroom[2] = person3;
        classroom[3] = person4;
        classroom[4] = person5;

        foreach (Person person in classroom)
        {
            Console.WriteLine(person.personName);
        }
        
        person1.ChangeAge(20);
        
        Person person6 = Person.Clone(person5);

        Console.WriteLine(person6.personName +  " is a clone!");
        */
        //============================================
        
        //overriding methods
        /*
        Dog dog2 = new Dog();
        Bird bird2 = new Bird();
        Snake snake2 = new Snake();
        
        dog2.Move();
        bird2.Move();
        snake2.Move();
        */
        //============================================
        
        //ToString method override
        /*
        Person person7 = new Person("Adrian", 30);

        Console.WriteLine(person7.ToString());
        Console.WriteLine(person7); //this will automatically call ToString method without having to call it
        */
        //============================================
        
        //polymorphism
        /*
        Dog doggo = new Dog();
        Snake bigBoss = new Snake();
        Bird birb = new Bird();

        Animal[] animals = { doggo, bigBoss, birb };

        foreach (Animal animal in animals)
        {
            animal.Speak();
        }
        */
        //============================================
        
        //interface (a methods blueprint for inheriting classes)
        /*
        Worker worker = new Worker();
        worker.Work();
        Criminal criminal = new Criminal();
        criminal.Rob();
        RobinHood robinHood = new RobinHood();
        robinHood.Rob();
        robinHood.Work();
        */
        //============================================
        
        //lists!!!
        /*
        List<String> colours = new List<string>();
        
        colours.Add("red");
        colours.Add("yellow");
        colours.Add("green");
        colours.Add("blue");
        
        colours.Insert(0, "purple");
        colours.Remove("red");
        colours.RemoveAt(colours.Count - 1);
        
        String[] coloursArray = colours.ToArray(); //create an array of items from the list
        
        //colours.Sort();
        //colours.Reverse();
        //colours.Clear();
        foreach (String colour in colours)
        {
            Console.WriteLine(colour);
        }

        Console.WriteLine("I counted " + colours.Count +  " colours");
        Console.WriteLine("Yellow is on " +  colours.IndexOf("yellow") + " index");
        
        colours.Add("yellow");
        Console.WriteLine("Last index of yellow is index " + colours.LastIndexOf("yellow"));
        Console.WriteLine(colours.Contains("red")); //returns bool after searching for asked colour (true/false)
        */
        //============================================
        
        //list of objects
        /*
        Person human1 = new Person("Mario", 45);
        Person human2 = new Person("Luigi", 40);
        Person human3 = new Person("Peach", 22);
        
        List<Person> humans = new List<Person>();
        
        humans.Add(human1);
        humans.Add(human2);
        humans.Add(human3);
        humans.Add(new Person("Waluigi", 40));

        foreach (Person person in humans)
        {
            Console.WriteLine(person);
        }
        */
        //============================================
        
        //getters/setters
        /*
        Criminal criminal1 = new Criminal(500);
        Console.WriteLine(criminal1.Income);
        criminal1.Income = 99999;
        Console.WriteLine(criminal1.Income);
        */
        //============================================
        
        //enums
        /*
        Console.WriteLine(Profession.Archer + " is our backline");
        Console.WriteLine(Profession.Bard + " is our leader and he joined the team as " + (int)Profession.Bard);
        
        String charClass = ProfessionLevel.Berserker.ToString();
        int level = (int)ProfessionLevel.Berserker;
        Console.WriteLine("Character class: " + charClass + " Current level: " + level);
        */
        //============================================
        
        //dictionary ->     Dictionary<TKey, TValue> name = new();
        /*
        Dictionary<String, String> configuration = new();
        
        configuration.Add("Theme", "Dark");
        configuration.Add("Brightness", "80");
        configuration.Add("Version", "1.0.2");
        //configuration.Add("Driver", "1.42");
        
        Console.WriteLine(configuration["Theme"]);

        if (configuration.ContainsKey("Driver"))
        {
            Console.WriteLine(configuration["Driver"]);
        }

        Dictionary<String, List<String>> prezents = new();
        
        prezents.Add("Girlfriend", new List<string>{"Chocolates", "Flowers", "Perfumes"});
        prezents.Add("Mom", new List<string>{"Music album", "Spa voucher", "Pillow"});
        prezents.Add("Grandma", new List<string>{"Sweater", "Cookies", "Flowers"});

        foreach (var (key, value) in prezents)
        {
            Console.WriteLine(key + "'s prezents:");
            foreach (var prezent in value)
            {
                Console.WriteLine(prezent);
            }
        }
        */
        
        //Recursion!!!
        
        Console.WriteLine("Counting down from provided number");
        int countdownNumber = 6;
        Recursion.Countdown(countdownNumber);
        
        Console.WriteLine("\nDisplaying every element of an array");
        int[] arr = { 5, 12, 8, 1, 13, 22 };
        Recursion.ShowArrayVal(arr, 0);
        
        Console.WriteLine("\nDisplaying every element of a list");
        List<String> list = new List<String>()
        {
            "Harry", "Hermione", "Ron", "Hagrid"
        };
        Recursion.ShowListVal(list, 0);
        
        Console.WriteLine("\nShowing factorial of provided number");
        int factX = 9;
        Console.WriteLine($"The factorial number of {factX} is {Recursion.Factorial(factX)}");
        
    }
}