namespace Aplikacja1;

public class Kontener
{
    private double cargoWeight; //kg
    private double height; //cm
    private double contenerWeight; //kg
    private double depth; //cm
    private double maxCapacity; //kg
    private string type;
    
    public Kontener(string type)
    {
        this.type = type;
    }

    public void unload()
    {
        
    }

    public void load(double masa)
    {
        if (masa>this.maxCapacity)
        {
            throw OverfillException("Masa przekracza pojemnosc kontenera");
        }
        else
        {
            
        }
        
        
        
    }

    private Exception OverfillException(string message)
    {
        throw new NotImplementedException();
    }
}