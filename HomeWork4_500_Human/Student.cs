using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4_500_Human
{
    public class Student : Human
    {
        public decimal Mark { get; set; }

        public Student (string FirstName, string LastName, decimal Mark) : base(FirstName, FirstName)
        {
            this.Mark = Mark;   
        }
    }
}
