using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW_7.Interface;

namespace HW_7.Accessories
{
    public class CPUAccessories : IAccessorise
    {
        public CPUAccessories()
        {
            CpuName[0] = "AMD x2";
            CpuName[1] = "AMD x4";
            CpuName[2] = "Intel x8";
            CpuCountry[0] = "Taiwan";
            CpuCountry[1] = "China";
            CpuCountry[2] = "Japan";
            CpuPrice[0] = "40";
            CpuPrice[1] = "100";
            CpuPrice[2] = "150";
        }

        public string[] CpuName { get; } = new string[3];

        public string[] CpuCountry { get; } = new string[3];

        public string[] CpuPrice { get; } = new string[3];
    }
}