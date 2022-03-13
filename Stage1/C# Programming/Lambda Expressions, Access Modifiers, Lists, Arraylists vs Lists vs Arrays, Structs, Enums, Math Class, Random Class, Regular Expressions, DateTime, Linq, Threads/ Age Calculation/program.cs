using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateEx1              //DO NOT CHANGE the namespace name
{
    public class Program       //DO NOT CHANGE the class name
    {
        public static void Main(string[] args)    //DO NOT CHANGE the 'Main' method signature
        {
            Console.WriteLine("Enter the date of birth (dd-mm-yyyy): ");
            //Implement code here
            DateTime dob = DateTime.ParseExact(Console.ReadLine(),"dd-mm-yyyy",null);
            string date = dob.ToString("dd-mm-yyyy");
            Console.WriteLine(calculateAge(date));
            
        }

        public static int calculateAge(string dateOfBirth)
        {
            //Implement code here
            int bYear  = Int32.Parse(dateOfBirth.Substring(6,4));
            
            var today = DateTime.Today;
            var cYear = today.Year;
            var birthYear = bYear;
            
            return(cYear-birthYear-1);
            
        }


    }
}
