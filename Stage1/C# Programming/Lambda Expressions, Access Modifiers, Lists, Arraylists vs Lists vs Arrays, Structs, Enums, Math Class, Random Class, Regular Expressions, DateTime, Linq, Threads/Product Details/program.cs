using System;
using System.Collections;
using System.Globalization;
using System.IO;


    public class Program  //DO NOT CHANGE the name of class 'Program'
    {
       public static void Main(string[] args) //DO NOT CHANGE 'Main' Signature
        {
            
            //Fill the code here
            StreamReader readData = new StreamReader("input.csv");
            string data = "";
            Product p = new Product();
            ArrayList fileData = new ArrayList();
            while((data = readData.ReadLine())!=null)
            {
                string[] i = data.Split(',');
                string  productName = i[0].Trim();
                string serialNumber = i[1].Trim();
                DateTime purchaseDate = DateTime.ParseExact(i[2].Trim(),"dd-mm-yyyy",null);
                double purchaseCost =double.Parse(i[3].Trim());
                p = new Product(productName,serialNumber,purchaseDate,purchaseCost);
                fileData.Add(p);
            }
            Console.WriteLine("{0}",String.Format("{0,-15}{1,-15}{2,-15}{3,-15}", "ProductName", "SerialNumber", "PurchaseDate", "Cost"));
            foreach (var obj in fileData)
            {
                Product prd = (Product)obj;
                Console.WriteLine("{0}",prd.ToString());
            }
            
        }


    }

   

