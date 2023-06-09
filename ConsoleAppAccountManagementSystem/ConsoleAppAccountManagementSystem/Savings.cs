using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppAccountManagementSystem
{
    class Savings : Account
    {

        internal override string Id
        {
            set
            {
                base.Id = "AS-" + value;
            }
        }

        internal Savings(string name, OpeningDate openingDate, Address address, double balance) : base(name, openingDate, address, balance)
        {

        }

        public override void Withdraw()
        {
            int count = 1;
            do
            {
                Console.WriteLine("[MAXIMUM WITHDRAWAL AMOUNT IS 2000 TAKA]");
                Console.Write("ENTER THE AMOUNT YOU WANT TO WITHDRAW: ");
                double wit = Convert.ToDouble(Console.ReadLine());
                if (wit > 0 && wit <= this.Balance && wit <=2000 )
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
