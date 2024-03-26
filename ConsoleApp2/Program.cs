using System;

public class Game : ICloneable
{
    public string Name { get; set; }
    public decimal Price { get; set; }

    public Game(string name, decimal price)
    {
        Name = name;
        Price = price;
    }

    public object Clone()
    {
        return new Game(Name, Price); 
    }
}

public class GameStop
{
    public string Name { get; set; }
    public int GamesCount { get; set; }
    public Game Game { get; set; }

    public GameStop(string name, int gamesCount, Game game)
    {
        Name = name;
        GamesCount = gamesCount;
        Game = game;
    }

    public GameStop Clone()
    {
        return new GameStop(Name, GamesCount, (Game)Game.Clone());
    }
}

class Program
{
    static void Main(string[] args)
    {
        Game game1 = new Game("GTA V", 50.0m);
        GameStop store1 = new GameStop("Store 1", 100, game1);

        GameStop store2 = store1.Clone();

        store2.Game.Name = "The Witcher 3";

        Console.WriteLine("Store 1:");
        Console.WriteLine($"{store1.Name}, {store1.GamesCount}, {store1.Game.Name}, {store1.Game.Price}");

        Console.WriteLine("\nStore 2:");
        Console.WriteLine($"{store2.Name},{store2.GamesCount},{store2.Game.Name}, {store2.Game.Price}");

        Console.ReadLine();
    }
}