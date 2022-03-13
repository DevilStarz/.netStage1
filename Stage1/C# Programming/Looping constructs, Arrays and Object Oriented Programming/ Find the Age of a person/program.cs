using System;
using System.IO;

public class Person
{
    //Fill code here
    private String firstName;
    private String lastName;
    private DateTime dob;
    
    public String FirstName
    {
        get{return firstName;} 
        set{firstName=value;}
    }
    public String LastName
    {
        get{return lastName;}
        set{lastName = value;}
    }
    public DateTime Dob
    {
        get{return dob;}
        set{dob = value;}
    }
    
    public String Adult
    {
        get{
            if(GetAge(dob)<18)
                return "Child";
            else
                return "Adult";
        }
    }
    
    public void DisplayDetails()
    {
        Console.WriteLine("First Name:{0}",firstName);
        Console.WriteLine("Last Name:{0}",lastName);
        Console.WriteLine("Age:{0}",GetAge(dob));
        Console.WriteLine(Adult);
    }
    
    public int GetAge(DateTime dob)
    {
        DateTime now = DateTime.Now;
        int age = 0;
        age = DateTime.Now.Year - dob.Year;
        if(DateTime.Now.DayOfYear<dob.DayOfYear)
            age = age - 2;
        return age;
    }
}

public class Progarm
{
    public static void Main(String[] args)
    {
        //Fill code here  
        Person person = new Person();
        Console.WriteLine("Enter first name ");
        person.FirstName=Console.ReadLine();
        Console.WriteLine("Enter last name ");
        person.LastName=Console.ReadLine();
        Console.WriteLine("Enter date of birth in yyyy/mm/dd/ format ");
        person.Dob= Convert.ToDateTime(Console.ReadLine());
        
        person.DisplayDetails();
    }
}
