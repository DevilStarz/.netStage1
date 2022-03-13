using System;
using System.Collections.Generic;
using System.Text;

    public class Product
    {
        public string _productName;
        public string _serialNumber;
        public DateTime _purchaseDate;
        public double _cost;
        
        // Implement 4-Argument Constructor
        public Product(string _productName,string _serialNumber,DateTime _purchaseDate,double _cost)
        {
            this._productName = _productName;
            this._serialNumber = _serialNumber;
            this._purchaseDate = _purchaseDate;
            this._cost = _cost;
        }
           
        // Implement Properties
        public string ProductName
        {
            get{return this._productName;}
            set{this._productName = value;}
        }
        public string SerialNumber
        {
            get{return this._serialNumber;}
            set{this._serialNumber = value;}
        }
        public DateTime PurchaseDate
        {
            get{return this._purchaseDate;}
            set{this._purchaseDate = value;}
        }
       public double Cost
       {
           get{return this._cost;}
           set{this._cost = value;}
       }
       public Product(){}
        public override string ToString()
        {
            return String.Format("{0,-15}{1,-15}{2,-15}{3,-15}", ProductName, SerialNumber, String.Format("{0:d}", PurchaseDate), Cost);
        }
    }

