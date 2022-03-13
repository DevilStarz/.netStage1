using System;

public class Program      //DO NOT change the class name
{
    //implement code here
    static void Main(string[] args){
        string reverse = " ";
        Console.WriteLine("Enter a string");
        string str = Console.ReadLine();
        string[] newLine = str.Split(' ');
        for(int x = newLine.Length-1;x>=0;x--){
            reverse +=" "+ newLine[x];
        }
        Console.WriteLine(reverse);
    }
}
