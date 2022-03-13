using System;
using System.IO;
using System.Text;

public class Program  //DO NOT CHANGE the name of class 'Program'
{ 
   public static void Main(string[] args) //DO NOT CHANGE 'Main' Signature
   {
      //Fill the code here
        var csv = new StringBuilder();
        
        Console.WriteLine ("Enter your no:");
        String no = Console.ReadLine();
        
        Console.WriteLine ("Enter your name:");
        String name = Console.ReadLine();
        
        Console.WriteLine ("Enter Bank Name:");
        String type = Console.ReadLine();
        
        Console.WriteLine ("Enter Bank Balance:");
        String balance = Console.ReadLine();
        
    
        var newline = String.Format("{0},{1},{2},{3}",no,name,type,balance);
        csv.AppendLine(newline);
        File.WriteAllText("output.csv",csv.ToString());
        
   }
}



   