using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW_7.Accessories;

namespace HW_7.PC.MotherboardDerivative
{
    public class GPU : MotherboardElements
    {
        public string? Name { get; set; }
        public string? Countru { get; set; }

        public string? Prise { get; set; }

        public override void Get()
        {
            Console.WriteLine("GPU:");
            Console.WriteLine($"Name:{Name}");
            Console.WriteLine($"Country:{Countru}");
            Console.WriteLine($"Prise:{Prise}");
            Console.WriteLine(new string('-', 70));
        }
    }
}
