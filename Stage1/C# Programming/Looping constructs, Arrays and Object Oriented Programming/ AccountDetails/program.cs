using System;

public class Account
{
    private int id;
    private string accountType;
    private double balance;
    
    public int Id
    {
        get{return id;}
        set{id = value;}
    }
    public string AccountType{
        get{return accountType;}
        set{accountType = value;}
    }
    
    public double Balance{
        get{return balance;}
        set{balance=value;}
    }
    public Account(){}
    public Account (int myId, string myAccountType, double myBalance)
    {
        id = myId;
        accountType = myAccountType;
        balance = myBalance;
    }
    
    public bool WithDraw(double amount){
        if(balance>amount){
            balance = balance - amount;
            return true;
        }
        return false;
    }
    public string GetDetails()
    {
        return ("Account Id: "+id+"\nAccount Type:"+accountType+"\nBalance :"+balance);
    }
}

public class Program
{
    static void Main(string[] args)
    {
        int id;
        string accountType;
        double balance,Withdraw;
       
        Account ac = new Account();
        Console.WriteLine("Enter account id");
        id = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Enter account type");
        accountType = Console.ReadLine();
        
        Console.WriteLine("Enter account balance");
        balance = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Enter amount to Withdraw");
        Withdraw = Convert.ToDouble(Console.ReadLine());
        
        ac = new Account (id,accountType,balance);
        Console.WriteLine(ac.GetDetails());
        
        if(ac.WithDraw(Withdraw))
        {
            Console.WriteLine("New Balance: "+ac.Balance);
        }
    }
}
