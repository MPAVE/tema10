using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_App
{
    class CompanyCustomer:Customer
    {
        public CompanyCustomer(string name)
        {
            Name = name;
            Type = CustomerType.Company;
        }
        public override void Print()
        {
            Console.WriteLine($"Name: {this.Name}");
        }
    }
}

