using FirstLabExamOOP.Interface;
using FirstLabExamOOP.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstLabExamOOP
{
    public partial class Form1 : Form
    {
        RegularEmployee regEmp = new RegularEmployee() { 
            Lastname ="Dela Cruz",
            Firstname = "Juan"
            
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetFullName_Click(object sender, EventArgs e)
        {
            MessageBox.Show(regEmp.GetFullName());
        }

        private void btnShowRegularSalary_Click(object sender, EventArgs e)
        {
            regEmp.MonthlySalary = 50000;
            MessageBox.Show($"Monthly Salary is { regEmp.CalculateSalary() }");
        }

        private void btnShowJOSalary_Click(object sender, EventArgs e)
        {
            ContractEmployee JOEmp = new ContractEmployee()
            {
                Lastname = "Rizal",
                Firstname = "Jose",
                HourlyRate = 500M,
                HoursWorked = 8,
            };

            MessageBox.Show($"Total Salary is {JOEmp.CalculateSalary()}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IEmployeeRepository MySqlCtx = new MySqlDBContext();
            EmployeeManager empMgr = new EmployeeManager(MySqlCtx);

            empMgr.AddEmployee(regEmp);

        }
    }
}
