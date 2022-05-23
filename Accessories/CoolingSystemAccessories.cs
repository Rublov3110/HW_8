using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW_7.Interface;

namespace HW_7.Accessories
{
    public class CoolingSystemAccessories : IAccessorise
    {
        public CoolingSystemAccessories()
        {
            CoolName[0] = "Standard cooling";
            CoolName[1] = "Quiet cooling";
            CoolName[2] = "Water cooling";
            CoolCountry[0] = "Taiwan";
            CoolCountry[1] = "China";
            CoolCountry[2] = "Japan";
            CoolPrice[0] = "20";
            CoolPrice[1] = "50";
            CoolPrice[2] = "100";
        }

        public string[] CoolName { get; } = new string[3];

        public string[] CoolCountry { get; } = new string[3];

        public string[] CoolPrice { get; } = new string[3];
    }
}
