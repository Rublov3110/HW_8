using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW_7.Interface;

namespace HW_7.Accessories
{
    public class RAMAccessories : IAccessorise
    {
        public RAMAccessories()
        {
            RamName[0] = "NouName 4GB";
            RamName[1] = "Samsung 8GB";
            RamName[2] = "Kingston 16GB";
            RamCountry[0] = "Taiwan";
            RamCountry[1] = "China";
            RamCountry[2] = "Japan";
            RamPrice[0] = "20";
            RamPrice[1] = "50";
            RamPrice[2] = "100";
        }

        public string[] RamName { get; } = new string[3];

        public string[] RamCountry { get; } = new string[3];

        public string[] RamPrice { get; } = new string[3];
    }
}
