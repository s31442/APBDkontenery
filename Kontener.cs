namespace Aplikacja1;

public abstract class Kontener
{
    abstract public double cargoWeight { set; get; } //kg
    abstract public double height{ set; get; }  //cm
    abstract public double contenerWeight{ set; get; }  //kg
    abstract public double depth{ set; get; }  //cm
    abstract public double maxCapacity{ set; get; }  //kg
    abstract public string type{ set; get; } 
    
    public Kontener(string type, double height, double contenerWeight, double depth, double maxCapacity)
    {
        switch(type) 
        {
            case "L" or "G" or "C":
                this.type = type;
                this.height = height;
                this.contenerWeight = contenerWeight;
                this.depth = depth;
                this.maxCapacity = maxCapacity;
                break;
            default:
                throw new Exception("Unknown type");
        }
        
    }

    public virtual void unload()
    {
        cargoWeight = 0;
    }

    public virtual void load(double masa, string cargoType)
    {
        if (masa>this.maxCapacity)
        {
            throw new OverfillException("Maximum capacity exceeded");
        }
        
    }
    
}