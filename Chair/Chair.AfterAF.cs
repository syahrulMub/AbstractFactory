namespace chairAbstractFactory;

interface IChair
{
    void Sit();
}

interface ISofa
{
    void Relax();
}

public class VictorianChair : IChair
{
    public void Sit()
    {
        Console.WriteLine("Sitting on victorian chair ");
    }
}
public class ModernChair : IChair
{
    public void Sit()
    {
        Console.WriteLine("Sitting on modern chair ");
    }
}

public class ModernSofa : ISofa
{
    public void Relax()
    {
        Console.WriteLine("relaxing on modern sofa");
    }
}

public class VictorianSofa : ISofa
{
    public void Relax()
    {
        Console.WriteLine("relaxing on victorian sofa");
    }
}

public class FutureChair : IChair, ISofa
{
    public void Relax()
    {
        Console.WriteLine("relaxing on future chair");
    }

    public void Sit()
    {
        Console.WriteLine("sitting on future chair");
    }
}
