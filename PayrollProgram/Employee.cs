using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollProgram
{
    class Employee
    {
        public double hrPay = 12;
        public double[] Employees = new double[6];

        public void EmployeePay()
        {
            double grandTotal = 0;
            double totalHrsWorked = 0;
            for (int i = 0; i < Employees.Length; i++)
            {
                Console.WriteLine("How many hours did you work?");
                double hrsWorked = Convert.ToDouble(Console.ReadLine());
                totalHrsWorked += hrsWorked;
                double totalPay = hrPay * hrsWorked;
                Console.WriteLine($"Total pay: {totalPay:c}");
                grandTotal += totalPay;

                if (i == Employees.Length - 1)
                {
                    Console.WriteLine($"The grand total is {grandTotal:c}, and total hours worked is {totalHrsWorked}.");
                }
            }

        }
    }
}
