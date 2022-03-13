using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgFundamentals2  //DO NOT change the namespace name
{
    public class Program      //DO NOT change the class name
    {
        public static void Main(string[] args)     //DO NOT change the 'Main' method signature
        {
            //Implement the code here
            int pizza,puffs,pepsi;
            int costofPizza,costofPuffs,costofPepsi;
            int totalPrice;
            double gst,cess;
            
            int perPizza = 200,perPuffs = 40,perPepsi = 120;
            Console.WriteLine("Enter the number of pizzas bought :");
            pizza = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter the number of puffs bought :");
            puffs = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter the number of pepsi bought :");
            pepsi = Convert.ToInt32(Console.ReadLine());
            
            costofPizza = perPizza * pizza;
            costofPuffs = perPuffs * puffs;
            costofPepsi = perPepsi * pepsi;
            
            totalPrice = costofPepsi + costofPizza + costofPuffs;
            
            gst = totalPrice * 0.12;
            cess = totalPrice * 0.05;
            
            Console.WriteLine("Bill Details\n");
            Console.WriteLine("Cost of Pizzas :"+costofPizza);
            Console.WriteLine("Cost of Puffs :"+costofPuffs);
            Console.WriteLine("Cost of Pepsis :"+costofPepsi);
            Console.WriteLine("GST 12% :"+gst);
            Console.WriteLine("CESS 5% :"+cess);
            Console.WriteLine("Total Price :"+totalPrice);
        }
    }
}
