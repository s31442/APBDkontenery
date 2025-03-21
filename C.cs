namespace Aplikacja1;

public class C : Kontener
{
    public override double cargoWeight { get; set; }
    public override double height { get; set; }
    public override double contenerWeight { get; set; }
    public override double depth { get; set; }
    public override double maxCapacity { get; set; }
    public override string type { get; set; }
    private static int counter = 0;  
    private string serialNum; 
    
    private string rodzaj { get; set; }
    private double kontenerTemp { get; set; }
    public int UniqueId { get; private set; }
    
    public C(string type, double height, double contenerWeight, double depth, double maxCapacity) : base(type, height, contenerWeight, depth, maxCapacity)
    {
        serialNum = $"KON-C-{UniqueId}";
        UniqueId = ++counter;
    }
    
    public override void load(double masa, string cargoType)
    {
        if (masa > maxCapacity)
        {
            throw new OverfillException("Przekroczono ładownosc kontenera");
        }
        

    }
}