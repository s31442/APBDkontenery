namespace Aplikacja1;

public class L : Kontener , IHazardNotifier
{
    public override double cargoWeight { get; set; }
    public override double height { get; set; }
    public override double contenerWeight { get; set; }
    public override double depth { get; set; }
    public override double maxCapacity { get; set; }
    public override string type { get; set; }
    
    private static int counter = 0;  
    private string serialNum; 
    public int UniqueId { get; private set; }
    
    public L(string type, double height, double contenerWeight, double depth, double maxCapacity) : base(type, height, contenerWeight, depth, maxCapacity)
    {
        serialNum = $"KON-L-{UniqueId}";
        UniqueId = ++counter;
    }
    
    public void SendHazardMessage()
    {
        Console.WriteLine($"Niebezpieczna sytuacja - {serialNum}");
    }

    

    public override void load(double masa, string cargoType)
    {
        
        if (cargoType == "hazardous")
        {
            maxCapacity=0.5*maxCapacity;
        }
        else
        {
            maxCapacity = 0.9*maxCapacity;
        }

        if (masa > maxCapacity)
        {
            SendHazardMessage();
        }
        else
        {
            cargoWeight = masa;
        }
        
    }
}