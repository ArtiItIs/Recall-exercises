namespace CsharpTraining;

public class House
{
    private double size;
    private int numberOfRooms;
    private String adress;
    private int floors;
    private String colour;
    public static int numberOfHouses;
    
    public House(double size, int  numberOfRooms, String adress, int floors, String colour)
    {
        this.size = size;
        this.numberOfRooms = numberOfRooms;
        this.adress = adress;
        this.floors = floors;
        this.colour = colour;
        numberOfHouses++;
    }

    public void HouseEvaluation()
    {
        Console.WriteLine($"Your house is {size} size, with {numberOfRooms} rooms and  {floors} floors. The whole building is in {colour} colour.");
        switch (size)
        {
            case < 50:
                Console.WriteLine("That's a cute little house");
                break;
            case < 100:
                Console.WriteLine("That's a really nice house");
                break;
            case < 250:
                Console.WriteLine("Wow that is really big");
                break;
            default:
                Console.WriteLine("Are you living in a castle?!");
                break;
        }
    }
}