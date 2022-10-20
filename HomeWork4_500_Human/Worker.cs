using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4_500_Human
{
    public class Worker : Human
    {
        public decimal Wedge { get; set; }
        public decimal WorkedHours { get; set; }
       
        public Worker (string FirstName, string LastName, decimal Wedge, decimal WrokedHour) : base(FirstName, LastName)
        {
            this.Wedge = Wedge;
            this.WorkedHours = WrokedHour;
        }

        public decimal GetHourlyWedge ()
        {
           return this.Wedge / this.WorkedHours;
        }
    }
}
