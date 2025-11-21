using FirstLabExamOOP.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace FirstLabExamOOP.Models
{
    public class EmployeeManager
    {
        private IEmployeeRepository _repo;

        public EmployeeManager(IEmployeeRepository repo) { 
            _repo = repo;
        }

        public void AddEmployee(Employee e) { 
           
            _repo.Save(e);
        }
    }
}
