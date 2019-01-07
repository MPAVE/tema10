using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_App
{
    class DepozitAccount:Bank
    {
        public DepozitAccount(Customer customer, int balance, int interestRate )
        {
            Customer = customer;
            Balance = balance;
            InterestRate = interestRate;
           
        }

        public override int Deposit(int money)
        {
            Balance = Balance + money;
            return Balance;
        }

        public int WithDraw(int money)
        {
            if (Balance < money)
            {

                Console.WriteLine("not enought founds");
            }
            else
            {
                Balance = Balance - money;
            }
            return Balance;
        }

        public override int CalculateInterestAmount(int NrOfMonths)
        {
            if (Balance > 0 && Balance < 1000)

                return -1;
            else
                return InterestRate * NrOfMonths;
        }

    }
}

