using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateEx2         //DO NOT CHANGE the namespace name
{
    public class Program   //DO NOT CHANGE the class name
    {
        /*** Dictionary values are hard-coded. Do NOT change ****/
        static Dictionary<string, DateTime> flightSchedule = new Dictionary<string, DateTime>(){
                                                        {"ZW346", Convert.ToDateTime("13:54:10")},
                                                        {"AT489", Convert.ToDateTime("16:30:00")},
                                                         {"BR267", Convert.ToDateTime("21:15:30")}};
                                       
        
        public static void Main(string[] args)   //DO NOT CHANGE the 'Main' method signature
        {
            //Implement your code here
            string flightNumber;
            string time;
            
            Console.WriteLine("Enter the Flight Number :");
            flightNumber= Console.ReadLine();
            
            time = flightStatus(flightNumber);
            Console.WriteLine(time);
            
            
        }  

        public static string flightStatus(string flightNo) //DO NOT CHANGE the 'flightStatus' method signature
        {
            
            //Implement your code here
            if(flightSchedule.ContainsKey(flightNo))
            {
                DateTime dTime = flightSchedule[flightNo];
                if(DateTime.UtcNow < dTime){
                    TimeSpan t = dTime.Subtract(DateTime.UtcNow);
                    return "Time To Flight "+t.ToString();
                }
                else
                {
                    return "Flight Already Left";
                }
                
            }
            else
                    return "Flight Number is wrong";
        }


    }
}
