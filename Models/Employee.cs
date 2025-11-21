using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace FirstLabExamOOP.Models
{
    public abstract class Employee : Person
    {

        public abstract decimal CalculateSalary();
    }
}
