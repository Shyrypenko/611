using System;

public class Device
{
    public string Name { get; private set; }
    public string Characteristics { get; private set; }

    public Device(string name, string characteristics)
    {
        Name = name;
        Characteristics = characteristics;
    }

    public virtual void Sound() => Console.WriteLine("The device makes a sound.");
    public void Show() => Console.WriteLine($"Device name: {Name}");
    public void Desc() => Console.WriteLine($"Description: {Characteristics}");
}
public class Kettle : Device
{
    public Kettle(string name, string characteristics) : base(name, characteristics) { }
    public override void Sound() => Console.WriteLine("The kettle whistles.");
}

public class Microwave : Device
{
    public Microwave(string name, string characteristics) : base(name, characteristics) { }
    public override void Sound() => Console.WriteLine("The microwave beeps.");
}

public class Car : Device
{
    public Car(string name, string characteristics) : base(name, characteristics) { }
    public override void Sound() => Console.WriteLine("The car honks.");
}

public class Steamship : Device
{
    public Steamship(string name, string characteristics) : base(name, characteristics) { }
    public override void Sound() => Console.WriteLine("The steamship blows its horn.");
}