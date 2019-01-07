using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_App
{
    class MortgageAccount : Bank
    {
        public MortgageAccount(Customer customer, int balance, int interestRate)
        {
            Customer = customer;
            Balance = balance;
            InterestRate = interestRate;

        }
        public CustomerType CustomerType { get; set; }
        public override int Deposit(int money)
        {
            Balance = Balance + money;
            return Balance;
        }

        public override int CalculateInterestAmount(int NrOfMonths)
        {
            if (CustomerType == CustomerType.Company && NrOfMonths <= 12)
            {
                return (InterestRate * NrOfMonths) / 2;
            }
            else if (CustomerType == CustomerType.Individual && NrOfMonths < 7)
            {
                return 0;
            }
            else
                return InterestRate * NrOfMonths;
        }


    }

       
}

