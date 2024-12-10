using System;

public abstract class Worker
{
    public string Name { get; private set; }

    protected Worker(string name)
    {
        Name = name;
    }

    public abstract void Print();
}

public class President : Worker
{
    public President(string name) : base(name) { }

    public override void Print() =>
        Console.WriteLine($"President: {Name} - Oversees the company and makes executive decisions.");
}

public class Security : Worker
{
    public Security(string name) : base(name) { }

    public override void Print() =>
        Console.WriteLine($"Security: {Name} - Ensures safety and enforces security measures.");
}

public class Manager : Worker
{
    public Manager(string name) : base(name) { }

    public override void Print() =>
        Console.WriteLine($"Manager: {Name} - Manages teams and oversees daily operations.");
}

public class Engineer : Worker
{
    public Engineer(string name) : base(name) { }

    public override void Print() =>
        Console.WriteLine($"Engineer: {Name} - Develops and maintains technical solutions.");
}