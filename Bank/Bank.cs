using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_App
{
   abstract class Bank:IBank
    {
        public Customer Customer { get; set; }

        public int Balance { get; set; }


        public int InterestRate { get; set; }
        

        public abstract int Deposit(int money);

        public virtual int CalculateInterestAmount(int NrOfMonths)
        {
            return InterestRate * NrOfMonths;
        }
        public virtual void Print()
        {
            Customer.Print();
            Console.WriteLine($"\t Balance: {this.Balance}, Monthly InterestRate: {this.InterestRate}");
           
        }
    }
}
