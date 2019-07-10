using System;

class Program
{
    static void Main(string[] args)
    {
        Printer dev = new Canon("Canon");
        Document house2 = dev.Print();

        dev = new HP("HP");
        Document house = dev.Print();

        Console.ReadLine();
    }
}
// абстрактный класс строительной компании
abstract class Printer
{
    public string Name { get; set; }

    public Printer(string n)
    {
        Name = n;
    }

    abstract public Document Print();
}
// строит панельные дома
class Canon : Printer
{
    public Canon(string n) : base(n)
    { }

    public override Document Print()
    {
        return new Perl();
    }
}
// строит деревянные дома
class HP : Printer
{
    public HP(string n) : base(n)
    { }

    public override Document Print()
    {
        return new Offset();
    }
}

abstract class Document
{ }

class Perl : Document
{
    public Perl()
    {
        Console.WriteLine("Документ распечатан на бумаге Perl, Принтером Canon");
    }
}
class Offset : Document
{
    public Offset()
    {
        Console.WriteLine("Документ распечатан на бумаге Offset, Принтером HP");
    }
}