using System;

namespace ConsoleAppAccountManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            //Account a1 = new Account();
            //a1.ShowAccountInfo();

            //Account a2 = new Account("Abir",new OpeningDate(21, "JAN",2020),new Address(21,2,"DHAKA","Bangladesh"),2500);
            //a2.ShowAccountInfo();
            //a2.Diposit();
            //a2.ShowAccountInfo();

            //FinancialAccount.AddAccount(new Savings("Karim", new OpeningDate(25, "FEB", 2020), new Address(13, 12, "CUMILLA", "Bangladesh"), 5000));
            //FinancialAccount.AddAccount(new Current("Rarim", new OpeningDate(14, "JUNE", 2020), new Address(20, 5, "DHAKA", "Bangladesh"), 15000));
            //FinancialAccount.AddAccount(new Loan("Abdul", new OpeningDate(11, "NOV", 2020), new Address(32, 18, "DHAKA", "Bangladesh"), 250000));

            //FinancialAccount.ShowAll();
            //FinancialAccount.Transfer("AS-1112", "AC-1113", 500);
            //FinancialAccount.ShowAll();

            FinancialAccount.StartSystem();
            
        }
    }
}
