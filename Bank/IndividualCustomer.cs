using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_App
{
    class IndividualCustomer:Customer
    {
        public IndividualCustomer(string name)
        {
            Name = name;
            Type = CustomerType.Individual;
        }
        public override void Print()
        {
            Console.WriteLine($"Name: {this.Name}");
        }
    }
}

