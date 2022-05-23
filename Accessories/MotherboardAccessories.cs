using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW_7.Interface;

namespace HW_7.Accessories
{
    public class MotherboardAccessories : IAccessorise
    {
        public MotherboardAccessories()
        {
            MothBoaName[0] = "Asus";
            MothBoaName[1] = "MSI";
            MothBoaName[2] = "GIGABYET";
            MothBoaCountry[0] = "Taiwan";
            MothBoaCountry[1] = "China";
            MothBoaCountry[2] = "Japan";
            MothBoaPrice[0] = "50";
            MothBoaPrice[1] = "100";
            MothBoaPrice[2] = "200";
        }

        public string[] MothBoaName { get; } = new string[3];
        public string[] MothBoaCountry { get; } = new string[3];
        public string[] MothBoaPrice { get; } = new string[3];
    }
}
