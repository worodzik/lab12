using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");

    //Write code to implement the test cases below

            /*Test case 1
             * Create a savingsaccount object
             * Deposit $2000
             * Withdraw $5000
             * Calculate interest
             * Withdraw $500
            */
    Console.WriteLine("Test Case 1");
    SavingsAccount s1 = new SavingsAccount();
    s1.Deposit(2000);
    s1.Withdraw(5000);
    s1.CalculateInterest();
    s1.Withdraw(500);
    Console.WriteLine();


            /*Test case 2
            * Create a checkingaccount object
            * Deposit $2000
            * Withdraw $5000
            * Calculate interest
            * Withdraw $500
           */
    Console.WriteLine("Test Case 2");
    CheckingAccount c1 = new CheckingAccount();
    c1.Deposit(2000);
    c1.Withdraw(5000);
    c1.CalculateInterest();
    c1.Withdraw(500);
  }
}