namespace Aplikacja1;

public class G : Kontener, IHazardNotifier
{
    public override double cargoWeight { get; set; }
    public override double height { get; set; }
    public override double contenerWeight { get; set; }
    public override double depth { get; set; }
    public override double maxCapacity { get; set; }
    public override string type { get; set; }
    private static int counter = 0;  
    private string serialNum; 
    
    private double cisnienie { get; set; }
    public int UniqueId { get; private set; }
    
    public G(string type, double height, double contenerWeight, double depth, double maxCapacity, double cisnienie) : base(type, height, contenerWeight, depth, maxCapacity)
    {
        serialNum = $"KON-G-{UniqueId}";
        UniqueId = ++counter;
        this.cisnienie = cisnienie;
    }
    
    public void SendHazardMessage()
    {
        Console.WriteLine($"Niebezpieczna sytuacja - {serialNum}");
    }
    
    public override void load(double masa, string cargoType)
    {
        if (masa > maxCapacity)
        {
            throw new OverfillException("Przekroczono ładownosc kontenera");
        }
        cargoWeight = masa;

    }
}