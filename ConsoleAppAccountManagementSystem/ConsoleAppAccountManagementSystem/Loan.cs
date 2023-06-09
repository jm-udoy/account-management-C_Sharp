using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppAccountManagementSystem
{
    class Loan : Account
    {
        internal override string Id
        {
            set
            {
                base.Id = "AL-" + value;
            }
        }

        internal Loan(string name, OpeningDate openingDate, Address address, double balance) : base(name, openingDate, address, balance)
        {

        }

        public override void Withdraw()
        {
            int count = 1;
            do
            {
                Console.WriteLine("[MAXIMUM WITHDRAWAL AMOUNT IS" +base.Balance+ " TAKA]");
                Console.Write("ENTER THE AMOUNT YOU WANT TO WITHDRAW: ");
                double wit = Convert.ToDouble(Console.ReadLine());
                if (wit > 0 && wit <= this.Balance - 50)
                {
                    this.Balance = this.Balance - wit - 50;
                    Console.WriteLine("TRANSACTION FEE 50 TAKA ALSO DEDUCTED");
                    count = 2;
                }
                else
                { Console.WriteLine("INAPPROPRIATE AMOUNT! Try Again..."); }
            } while (count == 1);

        }
    }
}
