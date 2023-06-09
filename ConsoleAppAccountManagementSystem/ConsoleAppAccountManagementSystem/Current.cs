using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppAccountManagementSystem
{
    class Current : Account
    {
        internal override string Id
        {
            set
            {
                base.Id = "AC-" + value;
            }
        }

        internal Current(string name, OpeningDate openingDate, Address address, double balance) : base(name, openingDate, address, balance)
        {

        }

        public override void Diposit()
        {
            int count = 1;
            do
            {
                Console.WriteLine("[MINIMUM 500 TAKA NEEDS TO DEPOSIT]");
                Console.Write("ENTER DIPOSIT AMOUNT: ");
                double dip = Convert.ToDouble(Console.ReadLine());
                if (dip >= 500)
                {
                    this.Balance = this.Balance + dip;
                    count = 2;
                }
                else
                { Console.WriteLine("INAPPROPRIATE AMOUNT! Try Again..."); }
            } while (count == 1);

        }

        public override void Withdraw()
        {
            int count = 1;
            do
            {
                Console.WriteLine("[MAXIMUM WITHDRAWAL AMOUNT IS 5000 TAKA]");
                Console.Write("ENTER THE AMOUNT YOU WANT TO WITHDRAW: ");
                double wit = Convert.ToDouble(Console.ReadLine());
                if (wit > 0 && wit <= this.Balance && wit <= 5000)
                {
                    this.Balance = this.Balance - wit;
                    count = 2;
                }
                else
                { Console.WriteLine("INAPPROPRIATE AMOUNT! Try Again..."); }
            } while (count == 1);

        }


    }
}
