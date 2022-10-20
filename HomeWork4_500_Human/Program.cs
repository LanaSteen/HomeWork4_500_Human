using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4_500_Human
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Worker worker = new Worker("Lana", "Steen", 3400, 160);
            Console.WriteLine($"Your hourly wedge is: {worker.GetHourlyWedge()} $");
        }
    }
}
