using System;

public class MusicalInstrument
{
    public string Name { get; private set; }
    public string Characteristics { get; private set; }

    public MusicalInstrument(string name, string characteristics)
    {
        Name = name;
        Characteristics = characteristics;
    }

    public virtual void Sound() => Console.WriteLine("The instrument produces a sound.");
    public void Show() => Console.WriteLine($"Instrument name: {Name}");
    public void Desc() => Console.WriteLine($"Description: {Characteristics}");
    public virtual void History() => Console.WriteLine("This instrument has a rich history.");
}

public class Violin : MusicalInstrument
{
    public Violin(string name, string characteristics) : base(name, characteristics) { }
    public override void Sound() => Console.WriteLine("The violin produces a soothing melody.");
    public override void History() => Console.WriteLine("The violin originated in the 16th century in Italy.");
}

public class Trombone : MusicalInstrument
{
    public Trombone(string name, string characteristics) : base(name, characteristics) { }
    public override void Sound() => Console.WriteLine("The trombone produces a bold, brassy sound.");
    public override void History() => Console.WriteLine("The trombone has roots in the 15th century in Europe.");
}

public class Ukulele : MusicalInstrument
{
    public Ukulele(string name, string characteristics) : base(name, characteristics) { }
    public override void Sound() => Console.WriteLine("The ukulele produces a cheerful and light tone.");
    public override void History() => Console.WriteLine("The ukulele was developed in Hawaii in the 19th century.");
}

public class Cello : MusicalInstrument
{
    public Cello(string name, string characteristics) : base(name, characteristics) { }
    public override void Sound() => Console.WriteLine("The cello produces a deep and rich sound.");
    public override void History() => Console.WriteLine("The cello was developed in the 16th century in Italy.");
}