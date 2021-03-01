using System;
using System.Collections;
namespace Banking_Management_02
{
    class Bank
    {
        private string bankName;
        ArrayList mybank;
        public Bank(string name)
        {
            bankName = name;
            mybank = new ArrayList();
        }
        public void AddAccount(Account account)
        {
            mybank.Add(account);
        }
        public void DeleteAccount(int id)
        {
            foreach (Account i in mybank)
            {
                if (i.GetId() == id)
                {
                    mybank.Remove(i);
                    break;
                }
            }
        }
        public void Transaction(int type, int ownId, double amount)
        {
            if (type == 1 || type == 2)
            {
                foreach (Account i in mybank)
                {
                    if (i.GetId() == ownId)
                    {
                        if (type == 1)
                        {
                            i.Withdraw(amount);
                        }
                        else
                        {
                            i.Deposit(amount);
                        }
                        return;
                    }
                }
                Console.WriteLine("\nID not found");
            }
            else
            {
                Console.WriteLine("\nWrong Function Called !");
            }
        }
        public void Transaction(int type, int ownId, int recieverId, double amount)
        {
            bool tmp = false;
            if (type == 3)
            {

                foreach (Account i in mybank)
                {
                    if (i.GetId() == ownId)
                    {

                        foreach (Account x in mybank)
                        {
                            if (x.GetId() == recieverId)
                            {
                                tmp = true;
                                i.Transfer(x, amount);
                            }
                        }

                    }
                }
                if (!tmp)
                {
                    Console.WriteLine("\nID not found");
                }
            }
            else
            {
                Console.WriteLine("\nWrong Function Called !");
            }
        }
        public void PrintAccountDetails()
        {
            Console.WriteLine("\n##########  All Accounts are");
            foreach (Account i in mybank)
            {
                Console.WriteLine();
                i.ShowAccountInformation();
                Console.WriteLine();
            }
            Console.WriteLine("##########");

        }
    }
}