using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW_7.Accessories;

namespace HW_7.PC.HousingDerivative
{
    public class DataStorage : HousingElements
    {
        public string? Name { get; set; }
        public string? Countru { get; set; }
        public string? Prise { get; set; }

        public override void Get()
        {
            Console.WriteLine("Data storage:");
            Console.WriteLine($"Name:{Name}");
            Console.WriteLine($"Countrry:{Countru}");
            Console.WriteLine($"Prise:{Prise}");
            Console.WriteLine(new string('-', 70));
        }
    }
}
