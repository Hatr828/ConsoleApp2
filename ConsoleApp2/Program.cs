using System;
using System.Linq;

public class Item
{
    public string Name { get; set; }
    public int Level { get; set; }
    public int Value { get; set; }
    public int Weight { get; set; }

    public Item(string name, int level, int value, int weight)
    {
        Name = name;
        Level = level;
        Value = value;
        Weight = weight;
    }
}

public class Player
{
    public string Name { get; set; }
    private Item[] inventory;
    private int count;

    public Player(string name, int capacity)
    {
        Name = name;
        inventory = new Item[capacity];
        count = 0;
    }

    public void AddItem(Item item)
    {
        if (count < inventory.Length)
        {
            inventory[count++] = item;
        }
        else
        {
            Console.WriteLine("Inventory is full. Cannot add more items.");
        }
    }

    public void RemoveItem(Item item)
    {
        int index = Array.IndexOf(inventory, item);
        if (index != -1)
        {
            for (int i = index; i < count - 1; i++)
            {
                inventory[i] = inventory[i + 1];
            }
            inventory[count - 1] = null;
            count--;
        }
        else
        {
            Console.WriteLine("Item not found in the inventory.");
        }
    }

    public int TotalWeight()
    {
        int totalWeight = 0;
        foreach (var item in inventory)
        {
            if (item != null)
            {
                totalWeight += item.Weight;
            }
        }
        return totalWeight;
    }

    public int TotalValue()
    {
        int totalValue = 0;
        foreach (var item in inventory)
        {
            if (item != null)
            {
                totalValue += item.Value;
            }
        }
        return totalValue;
    }

    public Item[] FindItemsByLevel(int level)
    {
        return inventory.Where(item => (item != null && item.Level == level)).ToArray();       // скопировал с интарнета
    }

    public Item[] FindItemsByValue(int value)
    {
        return inventory.Where(item => item != null && item.Value == value).ToArray(); // скопировал с интарнета
    }
}

class Program
{
    static void Main(string[] args)
    {
        Player player = new Player("Player1", 10);

        Item sword = new Item("Sword", 10, 100, 5);
        Item armor = new Item("Armar", 15, 200, 10);
        Item potion = new Item("Potion", 5, 50, 1);

        player.AddItem(sword);
        player.AddItem(armor);
        player.AddItem(potion);

        Console.WriteLine($"Total weight of player inventary: {player.TotalWeight()}");
        Console.WriteLine($"Total value of player inventary: {player.TotalValue()}");

        Console.WriteLine("Items with level 10: ");
        Item[] level10Items = player.FindItemsByLevel(10);
        foreach (var item in level10Items)
        {
            Console.WriteLine($"{item.Name} - Level: {item.Level}, Value: {item.Value}, Weight: {item.Weight}");
        }

        Console.ReadLine();
    }
}