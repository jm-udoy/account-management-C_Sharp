using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppAccountManagementSystem
{
    class FinancialAccount
    {
        private static Account[] account = new Account[1000];
        private static int count = 0;

        internal static void AddAccount(Account a)
        {
            account[count] = a;
            count++;
        }

        internal static void ShowAll()
        {
            int index = 0;
            while (index < count)
            {
                account[index].ShowAccountInfo();
                index++;
            }
        }

        internal static bool SearchAccount(string key, out int i)
        {
            int index = 0;
            bool found = false;
            i = -1;
            while (index < count)
            {
                if (account[index].Id == key)
                {
                    Console.WriteLine("Person Found");
                    account[index].ShowAccountInfo();
                    found = true;
                    i = index;
                    return found; 
                }
                index++;
            }
            if (!found)
                Console.WriteLine("Person Not found");

            return found;
        }

        internal static void DeleteAccount(string key)
        {
            int index;
            bool decision = SearchAccount(key, out index);
            string name = account[index].Name;
            if (decision)
            {
                account[index] = null;
                Console.WriteLine(name + "ACCOUNT HAS BEEN DELETED");
            }
        }



        public static void Transfer(string sender, string receiver, double amount)
        {
            Console.WriteLine("TRANSACTION INFORMATION");
            Console.WriteLine("AMOUNT: {0}",amount +" TAKA");
            Console.WriteLine("SENDER...");
            int sindex = -1;
            SearchAccount(sender, out sindex);
            account[sindex].Balance = account[sindex].Balance - amount;

            Console.WriteLine("RECEIVER...");
            int rindex = -1;
            SearchAccount(receiver, out rindex);
            account[rindex].Balance = account[rindex].Balance + amount;
            Console.WriteLine("TRANSACTION DONE");
        }

        public static void StartSystem()
        {
            
            int mainCount = 1;
            do
            {
                Console.WriteLine("##### ACCOUNT MANAGEMENT SYSTEM MAIN MENU #####");
                Console.WriteLine("[1] Add new Account.");
                Console.WriteLine("[2] Search Account.");
                Console.WriteLine("[3] Show All Account Information.");
                Console.WriteLine("[4] Delete Account.");
                Console.WriteLine("[5] Deposit.");
                Console.WriteLine("[6] Withdraw.");
                Console.WriteLine("[7] Transfer.");
                Console.WriteLine("[8] Check Balance.");
                Console.WriteLine("[9] Exit System.");

                Console.WriteLine();
                Console.Write("ENTER YOUR CHOICE [BETWEEN 1 TO 9] FROM ABOVE LIST: ");
                int input = Convert.ToInt32(Console.ReadLine());

                int count = 1;
                do
                {
                    if (input > 0 && input < 10)
                    {
                        switch (input)
                        {
                            case 1:
                                Console.WriteLine("Select what type of account you want to create...");
                                Console.WriteLine("[1] Savings.");
                                Console.WriteLine("[2] Current.");
                                Console.WriteLine("[3] Loan.");
                                Console.WriteLine();
                                Console.Write("ENTER YOUR CHOICE [BETWEEN 1 TO 3] FROM ABOVE LIST: ");
                                int input1 = Convert.ToInt32(Console.ReadLine());
                                int count1 = 1;
                                //do
                                //{
                                    if (input1 > 0 && input1 < 4)
                                    {
                                        switch (input1)
                                        {
                                            case 1:
                                                Console.WriteLine("ENTER YOUR SAVINGS ACCOUNT INFO");
                                                Console.Write("Enter Name    :");
                                                string n1 = Console.ReadLine();

                                                Console.WriteLine("ENTER OPENING DATE");
                                                Console.Write("Day:");
                                                byte day = Convert.ToByte(Console.ReadLine());
                                                Console.Write("Month:");
                                                string month = Console.ReadLine();
                                                Console.Write("Year:");
                                                ushort year = Convert.ToUInt16(Console.ReadLine());

                                                Console.WriteLine("ENTER ADDRESS INFORMATION");
                                                Console.Write("Apartment Number :");
                                                byte apNo = Convert.ToByte(Console.ReadLine());
                                                Console.Write("Road Number      :");
                                                ushort roadNo = Convert.ToUInt16(Console.ReadLine());
                                                Console.Write("District         :");
                                                string dis = Console.ReadLine();
                                                Console.Write("Country          :");
                                                string coun = Console.ReadLine();
                                                Console.Write("Enter Balance :");
                                                double b1 = Convert.ToDouble(Console.ReadLine());
                                                AddAccount(new Savings(n1, new OpeningDate(day, month, year), new Address(apNo, roadNo, dis, coun), b1));
                                                Console.WriteLine("Account created successfully");
                                                count1 = 2;
                                                break;

                                            case 2:
                                                Console.WriteLine("ENTER YOUR SAVINGS ACCOUNT INFO");
                                                Console.Write("Enter Name    :");
                                                string n2 = Console.ReadLine();

                                                Console.WriteLine("ENTER OPENING DATE");
                                                Console.Write("Day:");
                                                byte day2 = Convert.ToByte(Console.ReadLine());
                                                Console.Write("Month:");
                                                string month2 = Console.ReadLine();
                                                Console.Write("Year:");
                                                ushort year2 = Convert.ToUInt16(Console.ReadLine());

                                                Console.WriteLine("ENTER ADDRESS INFORMATION");
                                                Console.Write("Apartment Number :");
                                                byte apNo2 = Convert.ToByte(Console.ReadLine());
                                                Console.Write("Road Number      :");
                                                ushort roadNo2 = Convert.ToUInt16(Console.ReadLine());
                                                Console.Write("District         :");
                                                string dis2 = Console.ReadLine();
                                                Console.Write("Country          :");
                                                string coun2 = Console.ReadLine();
                                                Console.Write("Enter Balance :");
                                                double b2 = Convert.ToDouble(Console.ReadLine());
                                                AddAccount(new Current(n2, new OpeningDate(day2, month2, year2), new Address(apNo2, roadNo2, dis2, coun2), b2));
                                                Console.WriteLine("Account created successfully");
                                                count1 = 2;
                                                break;

                                            case 3:
                                                Console.WriteLine("ENTER YOUR SAVINGS ACCOUNT INFO");
                                                Console.Write("Enter Name    :");
                                                string n3 = Console.ReadLine();

                                                Console.WriteLine("ENTER OPENING DATE");
                                                Console.Write("Day:");
                                                byte day3 = Convert.ToByte(Console.ReadLine());
                                                Console.Write("Month:");
                                                string month3 = Console.ReadLine();
                                                Console.Write("Year:");
                                                ushort year3 = Convert.ToUInt16(Console.ReadLine());

                                                Console.WriteLine("ENTER ADDRESS INFORMATION");
                                                Console.Write("Apartment Number :");
                                                byte apNo3 = Convert.ToByte(Console.ReadLine());
                                                Console.Write("Road Number      :");
                                                ushort roadNo3 = Convert.ToUInt16(Console.ReadLine());
                                                Console.Write("District         :");
                                                string dis3 = Console.ReadLine();
                                                Console.Write("Country          :");
                                                string coun3 = Console.ReadLine();
                                                Console.Write("Enter Balance :");
                                                double b3 = Convert.ToDouble(Console.ReadLine());
                                                AddAccount(new Savings(n3, new OpeningDate(day3, month3, year3), new Address(apNo3, roadNo3, dis3, coun3), b3));
                                                Console.WriteLine("Account created successfully");

                                                count1 = 2;
                                                break;
                                            default:
                                                Console.WriteLine("Please enter a valid integer number from the list! Try again...");
                                                count1 = 2;
                                                break;
                                        }
                                    }
                                    else { Console.WriteLine("Enter between 1 to 3! Try again..."); }
                                //} while (count1 == 2);
                                count = 2;
                                break;
                            case 2:
                                Console.Write("ENTER THE ACCOUNT ID YOU WANT TO SEARCH: ");
                                string searchId = Console.ReadLine();
                                int i;
                                SearchAccount(searchId, out i);
                                count = 2;
                                break;

                            case 3:
                                ShowAll();
                                count = 2;
                                break;

                            case 4:
                                Console.Write("ENTER THE ACCOUNT ID YOU WANT TO DELETE: ");
                                string deleteId = Console.ReadLine();
                                DeleteAccount(deleteId);
                                count = 2;
                                break;

                            case 5:
                                Console.Write("ENTER THE ACCOUNT ID WHERE YOU WANT TO DIPOSIT: ");
                                string dipId = Console.ReadLine();
                                int dipIndex;
                                SearchAccount(dipId, out dipIndex);
                                account[dipIndex].Diposit();
                                count = 2;
                                break;

                            case 6:
                                Console.Write("ENTER THE ACCOUNT ID WHERE YOU WANT TO WITHDRAW: ");
                                string withdrawId = Console.ReadLine();
                                int withdrawIndex;
                                SearchAccount(withdrawId, out withdrawIndex);
                                account[withdrawIndex].Withdraw();
                                count = 2;
                                break;

                            case 7:
                                Console.Write("ENTER SENDER ACCOUNT ID: ");
                                string sen = Console.ReadLine();
                                Console.Write("ENTER RECEIVER ACCOUNT ID: ");
                                string rec = Console.ReadLine();
                                Console.Write("ENTER THE AMOUNT YOU WANT TO TRANSFER: ");
                                double amou = Convert.ToDouble(Console.ReadLine());
                                Transfer(sen, rec, amou);
                                count = 2;
                                break;

                            case 8:
                                Console.Write("ENTER THE ACCOUNT ID WHICH BALANCE YOU WANT TO CHECK: ");
                                string balanceCheckId = Console.ReadLine();
                                int balanceCheckIndex;
                                SearchAccount(balanceCheckId, out balanceCheckIndex);
                                Console.WriteLine("Balance: {0}", account[balanceCheckIndex].Balance);
                                count = 2;
                                break;

                            case 9:
                                Console.WriteLine("SHUT DOWN");
                                count = 2;
                                mainCount = 2;
                                break;

                            default:
                                Console.WriteLine("Please enter a valid integer number from the list! Try again...");
                                count = 2;
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Enter between 1 to 9! Try again...");
                        count = 2;
                    }
                } while (count == 1);
            } while (mainCount==1);

        }


    }
}
