using System;

public class Program      //DO NOT change the class name
{
    //implement code here
    static void Main(string[] args){
    int x,y;
    bool result;
    Console.WriteLine("Enter the value for x");
    x = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the value for y");
    y = Convert.ToInt32(Console.ReadLine());
    
    result = x<y;
    Console.WriteLine("x is less than y is {0}",result);
        
    }
}
