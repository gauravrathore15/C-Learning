using System;
using System.Collections.Generic;
using System.Text;

namespace C__Fundamentals
{
    public class Program{
        public static void Main(String[] args) { 
        
        BankAccount account1 = new BankAccount(101,"Gaurav Rathore",4000);
        account1.showDetails();

         BankAccount account2 = new BankAccount(102, "Mohan Rathore", 400000);
         account2.showDetails();

         BankAccount.BankDetail();
        }
    }
}