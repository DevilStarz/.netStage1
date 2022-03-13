using System;

public class Program      //DO NOT change the class name
{
    //implement code here
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number");
        int num = int.Parse(Console.ReadLine());
        
        for(int i=1; i<=num; i++)
        {
            for(int j=1; j<=num; j++)
            {
                Console.Write(i*j+" ");
            }
            Console.WriteLine();
        }
    }
}
