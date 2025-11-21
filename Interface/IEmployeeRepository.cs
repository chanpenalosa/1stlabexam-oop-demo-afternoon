using FirstLabExamOOP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLabExamOOP.Interface
{
    public interface IEmployeeRepository
    {
        void Save(Employee e);
    }
}
