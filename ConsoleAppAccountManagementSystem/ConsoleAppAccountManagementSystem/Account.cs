using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppAccountManagementSystem
{
    internal struct OpeningDate
    {
        private byte day;
        private string month;
        private ushort year;

       
        internal OpeningDate(byte day, string month, ushort year)
        {
            if (day >= 1 && day <= 31)
            {
                this.day = day;
                this.month = month;
                this.year = year;
            }
            else
            {
                this.day = 1;
                this.month = "NOT VALID";
                this.year = 1010;
            }
        }

        internal void DateStore()
        {
            int count = 1;
            do
            {
                Console.WriteLine("ENTER OPENING DATE");
                Console.Write("Day:");
                this.day = Convert.ToByte(Console.ReadLine());
                if (this.day >= 1 && this.day <= 31)
                {
                    Console.Write("Month:");
                    this.month = Console.ReadLine();
                    Console.Write("Year:");
                    this.year = Convert.ToUInt16(Console.ReadLine());
                    
                    count = 2;
                }
                else
                {
                    Console.WriteLine("NOT VALID DATE! TRY AGAIN...");
                }
            } while (count == 1);
            
        }

        internal void ShowDate()
        {
            Console.WriteLine("Opening Date     : {0} - {1} - {2}", this.day, this.month, this.year);
        }
    }


    struct Address
    {
        private byte apartmentNumber;
        private ushort roadNumber;
        private string district;
        private string country;

        public Address(byte apartmentNumber, ushort roadNumber, string district, string country)
        {
            this.apartmentNumber = apartmentNumber;
            this.roadNumber = roadNumber;
            this.district = district;
            this.country = country;
        }

        public void AddressStore()
        {
            Console.WriteLine("ENTER ADDRESS INFORMATION");
            Console.Write("Apartment Number :");
            this.apartmentNumber = Convert.ToByte(Console.ReadLine());
            Console.Write("Road Number      :");
            this.roadNumber = Convert.ToUInt16(Console.ReadLine());
            Console.Write("District         :");
            this.district = Console.ReadLine();
            Console.Write("Country          :");
            this.country = Console.ReadLine();
        }

        public void ShowAddress()
        {
            Console.WriteLine("ADDRESS INFORMATION");
            Console.WriteLine("Apartment Number : {0}", this.apartmentNumber);
            Console.WriteLine("Road Number      : {0}", this.roadNumber);
            Console.WriteLine("District         : {0}", this.district);
            Console.WriteLine("Country          : {0}", this.country);

        }
    }
    class Account
    {
        private static int serialNo = 1111;
        private string id;
        private string name;
        private OpeningDate openingDate;
        private Address address;
        private double balance;

        internal virtual string Id
        {
            get { return this.id; }
            set
            {
                this.id = value;
            }
        }

        internal string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        internal OpeningDate OpeningDate
        {
            get { return this.openingDate; }
            set { this.openingDate = value; }
        }

        internal Address Address
        {
            get { return this.address; }
            set { this.address = value; }
        }

        internal double Balance
        {
            get { return this.balance; }
            set
            {
                if (value > 0)
                    this.balance = value;
                else
                    this.balance = -1;
            }
        }

        internal Account()
        {
            this.Id = (++serialNo).ToString();
            Console.Write("Enter Name    :");
            this.Name = Console.ReadLine();
            this.OpeningDate.DateStore();
            this.Address.AddressStore();
            //this.OpeningDate = openingDate;
            //this.Address = address;
            Console.Write("Enter Balance :");
            this.Balance = Convert.ToDouble(Console.ReadLine());
        }

        internal Account(string name, OpeningDate openingDate, Address address, double balance)
        {
            this.Id = (++serialNo).ToString();
            this.Name = name;
            this.OpeningDate = openingDate;
            this.Address = address;
            this.Balance = balance;
        }

        public void ShowAccountInfo()
        {
            Console.WriteLine();
            Console.WriteLine("ACCOUNT INFORMATION");
            Console.WriteLine("Account Number   : {0}", this.Id);
            Console.WriteLine("Name             : {0}", this.Name);
            this.OpeningDate.ShowDate();
            this.Address.ShowAddress();
            Console.WriteLine("Balance          : {0}", this.Balance);
            Console.WriteLine();
        }


        public virtual void Diposit()
        {
            int count = 1;
            do
            {
                Console.Write("ENTER DIPOSIT AMOUNT: ");
                double dip = Convert.ToDouble(Console.ReadLine());
                if (dip > 0)
                {
                    this.Balance = this.Balance + dip;
                    count = 2;
                    Console.WriteLine("DIPOSIT DONE");
                }
                else
                { Console.WriteLine("INAPPROPRIATE AMOUNT! Try Again..."); }
            } while (count == 1);
            
        }

        public virtual double Diposit(double d)
        {
            int count = 1;
            do
            {
                ;
                double dip = d;
                if (dip > 0)
                {
                    this.Balance = this.Balance + dip;
                    count = 2;
                    Console.WriteLine("DIPOSIT DONE");
                }
                else
                { Console.WriteLine("INAPPROPRIATE AMOUNT! Try Again..."); }
            } while (count == 1);

            return this.Balance;

        }

        public virtual void Withdraw()
        {
            int count = 1;
            do
            {
                Console.Write("ENTER THE AMOUNT YOU WANT TO WITHDRAW: ");
                double wit = Convert.ToDouble(Console.ReadLine());
                if (wit > 0 && wit <= this.Balance)
                {
                    this.Balance = this.Balance - wit;
                    count = 2;
                    Console.WriteLine("WITHDRAW DONE");
                }
                else
                { Console.WriteLine("INAPPROPRIATE AMOUNT! Try Again..."); }
            } while (count == 1);

        }





    }
}
