using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculator
{
    class Employee : Person
    {
        string company;
        int years;
        double salary;
        public Employee(string c, int y, double s) 
        {
            company = c;
            years = y;
            salary = s;
        }

        public string calculateSalary() 
        {
            double calculatedsalary = years * salary;
            string cs = string.Format("{0:c}",calculatedsalary);
            return cs;
        }
    }
}
