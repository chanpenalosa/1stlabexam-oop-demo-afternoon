using FirstLabExamOOP.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstLabExamOOP.Models
{
    public class MySqlDBContext : IEmployeeRepository
    {
        //Logic for database queries
        public void Save(Employee e)
        {
            MessageBox.Show($"Saing {e.GetFullName()} to MySQL Database....");
        }
    }
}
