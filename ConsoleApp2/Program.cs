using System;

public class Processor
{
    public string Model { get; }

    public Processor(string model)
    {
        Model = model;
    }
}

public class Motherboard
{
    private Processor _processor;
    private int _ramSizeGB;

    public Processor Processor
    {
        get { return _processor; }
        set { _processor = value; }
    }

    public int RamSizeGB
    {
        get { return _ramSizeGB; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("argument < 0");
            }
            _ramSizeGB = value;
        }
    }

    public Motherboard(Processor processor, int ramSizeGB)
    {
        Processor = processor;
        RamSizeGB = ramSizeGB;
    }

    public string GetName()
    {
        return $"{Processor.Model},{RamSizeGB}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Processor processor = new Processor("Procea");
        try
        {
            Motherboard motherboard = new Motherboard(processor, 16);
            Console.WriteLine(motherboard.GetName());
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

}