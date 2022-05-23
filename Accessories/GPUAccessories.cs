using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW_7.Interface;

namespace HW_7.Accessories
{
    public class GPUAccessories : IAccessorise
    {
        public GPUAccessories()
        {
            GpuName[0] = "MSI 2GB";
            GpuName[1] = "Radiom 4GB";
            GpuName[2] = "NVideo 8GB";
            GpuCountry[0] = "Taiwan";
            GpuCountry[1] = "China";
            GpuCountry[2] = "Japan";
            GpuPrice[0] = "150";
            GpuPrice[1] = "300";
            GpuPrice[2] = "500";
        }

        public string[] GpuName { get; } = new string[3];
        public string[] GpuCountry { get; } = new string[3];
        public string[] GpuPrice { get; } = new string[3];
    }
}
