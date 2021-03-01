using System;
using System.Collections;

namespace Banking_Management_02
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList X = new ArrayList();
            Account a = new Account("Musa", "12", "4A", "Natore", "Bangladesh");
            Account b = new Account("Mim", "13", "8B", "Natore", "Bangladesh");
            Account c = new Account("Piash", "10", "XB", "Rajshahi", "Bangladesh");

            Bank Demo = new Bank("MyBank");
            Demo.AddAccount(a);
            Demo.AddAccount(b);
            Demo.AddAccount(c);
            Demo.PrintAccountDetails();
            int n = 0;
            while (true)
            {

                Console.WriteLine("\nEnter 1 to Add Accocunt ");
                Console.WriteLine("Enter 2 to Remove Accocunt ");
                Console.WriteLine("Enter 3 to Transaction ");
                Console.WriteLine("Enter 4 to View All Accounts ");
                n = Int32.Parse(Console.ReadLine());
                if (n == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Enter Name :");
                    String name = Console.ReadLine();
                    Console.WriteLine("Enter Road No :");
                    String road = Console.ReadLine();
                    Console.WriteLine("Enter House No :");
                    String house = Console.ReadLine();
                    Console.WriteLine("Enter City :");
                    String city = Console.ReadLine();
                    Console.WriteLine("Enter Country :");
                    String country = Console.ReadLine();

                    Demo.AddAccount(new Account(name, road, house, city, country));
                    Console.WriteLine("Account created successfully");

                }
                else if (n == 4)
                {
                    Console.Clear();
                    Demo.PrintAccountDetails();
                }
                else if (n == 2)
                {
                    Console.WriteLine("Enter ID of the account to be removed !");
                    Demo.DeleteAccount(Int32.Parse(Console.ReadLine()));

                }
                else if (n == 3)
                {
                start:
                    Console.WriteLine("\nEnter Transaction Type :");
                    Console.WriteLine("Enter 1 for Transfer ");
                    Console.WriteLine("Enter 2 for Withdraw ");
                    Console.WriteLine("Enter 3 for Deposit ");
                    int tmp = Int32.Parse(Console.ReadLine());
                    if (tmp == 1)
                    {
                        Console.WriteLine("Enter Sender ID ");
                        int sid = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Receiver ID ");
                        int rid = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Amount ");
                        int amnt = Int32.Parse(Console.ReadLine());
                        Demo.Transaction(3, sid, rid, amnt);

                    }
                    else if (tmp == 2)
                    {
                        Console.WriteLine("Enter Owner Id to Withdraw ");
                        int oid = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Amount ");
                        int amnt2 = Int32.Parse(Console.ReadLine());
                        Demo.Transaction(1, oid, amnt2);

                    }
                    else if (tmp == 3)
                    {
                        Console.WriteLine("Enter Owner Id to Deposit ");
                        int oid = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Amount ");
                        int amnt2 = Int32.Parse(Console.ReadLine());
                        Demo.Transaction(2, oid, amnt2);

                    }
                    else
                    {
                        Console.WriteLine("\nWrong Command ! ");
                        goto start;
                    }


                }


            }


        }
    }
}