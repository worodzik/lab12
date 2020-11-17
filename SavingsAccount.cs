using System;

class SavingsAccount : BankAccount
  {
    override public void CalculateInterest(){
      double interest = Balance * 0.005;
      Balance = Balance + interest;
      Console.WriteLine("Balance with interest = " + Balance);
    }
    
    public override void Withdraw(double amount){
      base.Withdraw(amount);
    }
      
  }