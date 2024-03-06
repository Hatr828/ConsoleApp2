using System;

class Vehicle
{
    public string Type { get; set; }

    public virtual string Description
    {
        get { return "This is a vehicle."; }
    }

    public virtual void Move()
    {
        Console.WriteLine("The vehicle is moving.");
    }

    public Vehicle(string type)
    {
        Type = type;
    }
}

class Truck : Vehicle
{
    public Truck(string type) : base(type) { }

    public override string Description
    {
        get { return "This is a truck."; }
    }

    public override void Move()
    {
        Console.WriteLine("The truck is transporting goods.");
    }
}

class Aircraft : Vehicle
{
    public Aircraft(string type) : base(type) { }

    public override string Description
    {
        get { return "This is an aircraft."; }
    }

    public override void Move()
    {
        Console.WriteLine("The aircraft is flying.");
    }
}

class FighterJet : Aircraft
{
    public FighterJet(string type) : base(type) { }

    public override void Move()
    {
        Console.WriteLine("The fighter jet is engaging in combat maneuvers.");
    }

    public void PerformAirStrike()
    {
        base.Move(); 
        Console.WriteLine("Launching air strike!");
    }
}

class Helicopter : Aircraft
{
    public Helicopter(string type) : base(type) { }
}

class Program
{
    static void Main(string[] args)
    {
        Aircraft aircraft = new Aircraft("rrrr");
        Console.WriteLine(aircraft.Description);
        aircraft.Move();
        Console.WriteLine();

        Helicopter helicopter = new Helicopter("hhh");
        Console.WriteLine(helicopter.Description);
        helicopter.Move();

        Console.ReadLine();
    }
}