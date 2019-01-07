using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_App
{
    class LoanAccount : Bank
    {
        public LoanAccount(Customer customer, int balance, int interestRate)
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
            if (CustomerType == CustomerType.Individual && NrOfMonths < 4)
            {
                return -1;
            }
            else if (CustomerType == CustomerType.Company && NrOfMonths < 3)
            {
                return -1;
            }
            else
                return InterestRate * NrOfMonths;
        }
    }
}
