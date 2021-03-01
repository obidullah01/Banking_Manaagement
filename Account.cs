using System;
namespace Banking_Management_02
{
    class Account
    {
        private Random r = new Random();
        private int accountNumber;
        private String accountName;
        private double balance;
        private Address address;
        public Account(String name, String road, String house, String city, String country)
        {
            this.balance = 0;
            address = new Address(road, house, city, country);
            this.accountName = name;
            this.accountNumber = r.Next(2000);
        }
        public void Withdraw(double amount)
        {
            if (balance >= amount)
            {
                this.balance -= amount;
            }
            else
            {
                Console.WriteLine("\nBalance is low !");
            }
        }
        public void Deposit(double amount)
        {
            balance += amount;
        }
        public void Transfer(Account receiver, double amount)
        {
            if (receiver == null)
            {
                Console.WriteLine("\nInvalid acoount !");
            }
            else
            {
                if (balance >= amount)
                {
                    receiver.Deposit(amount);
                    balance -= amount;
                }
                else
                {
                    Console.WriteLine("\nBalance is low, Can not transfar !");
                }
            }
        }
        public void ShowAccountInformation()
        {
            Console.WriteLine(String.Format("ID : {0}, Name : {1}, Balance : {2}", accountNumber, accountName, balance));
            Console.WriteLine(address.GetAddress());
        }
        public int GetId()
        {
            return this.accountNumber;
        }
    }
}