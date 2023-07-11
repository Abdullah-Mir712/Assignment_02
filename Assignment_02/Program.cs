using System;

namespace Assignment_02
{
    public class BankAccount
    {
        int AccountNumber;
        string AccountHolderName;
        int Balance;

        public BankAccount(int accountnumber, string accountholdername, int balance)
        {

            AccountNumber = accountnumber;
            AccountHolderName = accountholdername;
            Balance = balance;

        }
         public virtual void Deposit(int amount)
        {
            Balance = Balance + amount;
            Console.WriteLine($"{amount } is deposited to account number {AccountNumber} under name {AccountHolderName}. Your total Balance is {Balance}");
        }
        public virtual void Withdraw(int amount)
        {
            Balance = Balance - amount;
            Console.WriteLine($"{amount} has been withdrawn from account number {AccountNumber} under name {AccountHolderName}. Your remaining balance is {Balance}");
        }
        public virtual void DisplayAccountInfo()
        {
            Console.WriteLine($" Customer {AccountHolderName} with account number {AccountNumber} has balance {Balance}");
        }

        

    }

    public class SavingAccount : BankAccount
    {
        int Interest;
        public SavingAccount(int accountnumber, string accountholdername, int balance, int interestrate) : base (accountnumber,accountholdername, balance )
        {
            Interest = interestrate;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BankAccount bank = new BankAccount(56362, "Abdullah", 2563);
            bank.Deposit(22);
        }
    }


}
