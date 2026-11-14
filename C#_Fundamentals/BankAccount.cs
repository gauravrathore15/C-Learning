using System;
using System.Collections.Generic;
using System.Text;

namespace C__Fundamentals
{
    internal class BankAccount
    {
        private int accountNumber { get; set; }
        private String holderName { get; set; }
        private int balance { get; set; }
        private static String bankName { get; } = "Central Bank Of India";
        private static int totalAccotuns { get; set; }

        public BankAccount(int acccountNumber, String holderName, int deposit) { 
            this.accountNumber = acccountNumber;   
            this.holderName = holderName;
            this.balance = deposit;
            totalAccotuns++;
        }

        public void showDetails()
        {
            Console.WriteLine("Account Number = "+this.accountNumber);
            Console.WriteLine("Account Holder Name = "+ this.holderName);
            Console.WriteLine("Account Balance = "+ this.balance);

        }

        public static void BankDetail() {
            Console.WriteLine("Bank Name " + bankName);
            Console.WriteLine("Total Accounts " + totalAccotuns);
        }
    }
}
