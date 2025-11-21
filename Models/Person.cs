using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLabExamOOP.Models
{
    public abstract class Person
    {
        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public string GetFullName() {
            return $"{Lastname}, {Firstname}";
        }
    }
}
