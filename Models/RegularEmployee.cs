using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLabExamOOP.Models
{
    public class RegularEmployee : Employee
    {
        public decimal MonthlySalary;

        public override decimal CalculateSalary()
        {
            return MonthlySalary;
        }
    }
}
