using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_App
{
   abstract class Customer
    {
        public string Name { get; set; }

        public CustomerType Type { get; set; }
        public abstract void Print();
    }
}
