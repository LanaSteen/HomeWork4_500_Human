using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4_500_Human
{
    public class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Human(string FirstName, string LastName)
        {
            this.FirstName = FirstName;  
            this.LastName = LastName;    
        }
    }
}
