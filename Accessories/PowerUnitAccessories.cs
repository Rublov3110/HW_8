using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW_7.Interface;

namespace HW_7.Accessories
{
    public class PowerUnitAccessories : IAccessorise
    {
        public PowerUnitAccessories()
        {
            PowerName[0] = "80 Plus 300W";
            PowerName[1] = "80 Plus Gold 450W";
            PowerName[2] = "80 Plus Platinum 650";
            PowerCountry[0] = "Taiwan";
            PowerCountry[1] = "China";
            PowerCountry[2] = "Japan";
            PowerPrice[0] = "30";
            PowerPrice[1] = "50";
            PowerPrice[2] = "80";
        }

        public string[] PowerName { get; } = new string[3];
        public string[] PowerCountry { get; } = new string[3];
        public string[] PowerPrice { get; } = new string[3];
    }
}
