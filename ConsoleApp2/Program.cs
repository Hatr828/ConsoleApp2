using System;
using System.Collections.Generic;
using System.Linq;

public enum Priority
{
    I = 1,
    II,
    III,
    IV,
    V,
    VI,
    VII,
    IIX,
    IX,
    X
}

public class Document
{
    public Priority priority;
    public string name;

    public Document(Priority priority, string name)
    {
        this.priority = priority; 
        this.name = name;
    }

    public override string ToString()
    {
       return (name + "   " + Convert.ToInt32(priority));
    }
}

public class DocumentQ
{
    private List<Document> queue;

    public DocumentQ()
    {
        queue = new List<Document>();
    }

    public void AddDocument(Document doc)
    {
        queue.Add(doc);
        queue = queue.OrderBy(x => x.priority).ToList();
    }

    public Document getDocument()
    {
        var rezult = queue.First();
        queue.Remove(rezult);
        return rezult;
    }

    public bool IsEmpty()
    {
        return queue.Count == 0;
    }
}

class Program
{
    static void Main(string[] args)
    {
        DocumentQ printer;

        printer = new DocumentQ();

        printer.AddDocument(new Document(Priority.X, "1 pdhh"));

        Console.WriteLine(printer.getDocument());


        Console.ReadLine();
    }
}