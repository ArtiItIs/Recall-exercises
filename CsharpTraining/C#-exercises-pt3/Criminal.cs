namespace CsharpTraining;

public class Criminal : IRobber
{
    private int income;

    public Criminal(int income)
    {
        this.income = income;
    }
    
    public int Income
    {
        get { return income; }
        set
        {
            if (value > 50000)
            {
                income = 50000;
            }
            else
            {
                income = value;
            }
        }
    }
    
    //if there is no logic required in creating get/set we can auto implement
    //public int Income { get; set; }
    
    public void Rob()
    {
        Console.WriteLine("This criminal just robbed somebody!");
    }
}