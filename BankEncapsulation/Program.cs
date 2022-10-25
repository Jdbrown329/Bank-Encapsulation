using System;
using BankEncapsulation;
class program 
{
    static void Main(string[] args)
    {
        var b1 = new BankAccount();
        b1.Deposit(500);

        var bal = b1.GetBalance();
        
        Console.WriteLine($"{bal}");

        b1.Withdraw(220);
      
     }
}



