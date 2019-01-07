using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_App
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IBank> list = new List<IBank>();

          Customer individ1 = new IndividualCustomer("Alexandru Vlad");
            Customer individ2 = new IndividualCustomer("Popovici Ioana");
            Customer company1 = new CompanyCustomer("Popescu Dragos");
            Customer company2 = new CompanyCustomer("Anastasie Ioan");

            list.Add(new DepozitAccount(individ1, 100, 5));
            list.Add(new DepozitAccount(individ2, -2, 5));
            list.Add(new DepozitAccount(company1, 10, 5));
            list.Add(new DepozitAccount(company2, 2, 5));

            list.Add(new MortgageAccount(company1, 25, 100));
            list.Add(new MortgageAccount(company2, 45, 100));

            list.Add(new MortgageAccount(individ1, 30, 100));
            list.Add(new MortgageAccount(individ2, 1, 10));

            list.Add(new LoanAccount(company1, 32, 10));
            list.Add(new LoanAccount(individ1, 12, 1));

            foreach (var elem in list)
            {
                elem.Print();
            }


            Console.ReadKey();
        }
    }
    }

