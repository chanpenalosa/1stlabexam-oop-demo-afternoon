using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLabExamOOP.Models
{
    public class ContractEmployee : Employee
    {
        public decimal HourlyRate;
        public decimal HoursWorked;

        public override decimal CalculateSalary()
        {
            return HoursWorked * HourlyRate;
        }
    }
}
