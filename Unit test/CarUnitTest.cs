

using System;

namespace CarAccountNS
{
   
    public class CarAccount
    {
        private readonly string m_customerName;
        private double m_balance;

        private CarAccount() { }

        public CarAccount(string customerName, double balance)
        {
            m_customerName = customerName;
            m_balance = balance;
        }

        public string CustomerName
        {
            get { return m_customerName; }
        }

        public double Balance
        {
            get { return m_balance; }
        }

        public void Debit(double amount)
        {
            if (amount > m_balance)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            m_balance += amount; // intentionally incorrect code
        }

        public void Credit(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            m_balance += amount;
        }

        public static void Main(CarAccount ba)
        {
            CarAccount ba = new CarAccount("Mr. Bryan Walton",
                                           11.99);
            NewMethod(ba);
            ba.Debit(11.22);
            Console.WriteLine("Current balance is ${0}", ba.Balance);
        }

        private static void NewMethod(CarAccount ba)
        {
            ba.Credit(5.77);
        }
    }
}