using System;

public interface IOpenable
{
    string OpenSesame();
}

public class TreasureBox : IOpenable
{
    public string OpenSesame()
    {
        return "Congratulations , Here is your lucky win";
    }
}

public class Parachute : IOpenable
{
    public string OpenSesame()
    {
        return "Have a thrilling experience flying in air";
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        TreasureBox t = new TreasureBox();
        Parachute p = new Parachute();
        
        Console.WriteLine("Enter the letter found in the paper");
        char ch = Convert.ToChar(Console.ReadLine());
        
        if(ch=='T')
        {
            Console.WriteLine(t.OpenSesame());
        }
        else if(ch == 'p')
        {
            Console.WriteLine(p.OpenSesame());
        }
    }
}