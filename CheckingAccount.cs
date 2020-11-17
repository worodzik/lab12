using System;

class CheckingAccount : BankAccount
{
  override public void CalculateInterest(){
    double interest = Balance * 0.05;
    Balance = Balance + interest;
    Console.WriteLine("Balance with interest = " + Balance);

  }
  public override void Withdraw(double amount){
    if (Balance < 2000){
      Console.WriteLine ("Insufficient balance");
    }
    else {
      base.Withdraw(amount);
    }
  }
      
}