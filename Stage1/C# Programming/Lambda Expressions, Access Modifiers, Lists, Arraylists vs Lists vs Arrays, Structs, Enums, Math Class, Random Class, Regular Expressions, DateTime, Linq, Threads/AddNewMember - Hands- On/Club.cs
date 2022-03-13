using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddNewMember              //Do not change the namespace name
{
    public class Club          //Do not change the class name
    {
        
        static Dictionary<int, string> groupInfo = new Dictionary<int, string>() { { 1, "Gold" }, { 2, "Silver" }, { 3, "Platinum" } };
        static Dictionary<int, List<String>> memberInfo = new Dictionary<int, List<String>>() {
                                    { 1, new List<string>(){ "Tom","Harry"} },
                                    { 2,new List<string>(){ "Sam","Peter"} },
                                    { 3,new List<string>(){ "Kim","Robert"} } };

        public static void Main(string[] args)        //Do not change the method signature
        {
            List<string> gold = memberInfo[1];
            List<string> silver = memberInfo[2];
            List<string> platinum = memberInfo[3];
            
            Console.WriteLine("Group Name :");
            string group = Console.ReadLine();
            
            Console.WriteLine("Member Name:");
            string memberName = Console.ReadLine();
            
            if(group =="Gold")
            {
                gold.Add(memberName);
                foreach(string i in gold)
                Console.WriteLine(i);
            }
            
            if(group=="Silver")
            {
                silver.Add(memberName);
                foreach(string i in silver)
                Console.WriteLine(i);
            }
            
            if(group=="Platinum")
            {
                platinum.Add(memberName);
                foreach(string i in platinum)
                Console.WriteLine(i);
            }
            
        }
    }
}