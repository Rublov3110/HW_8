using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW_7.Interface;

namespace HW_7.Accessories
{
    public class FramAccessories : IAccessorise
    {
        public FramAccessories()
        {
            FramName[0] = "Fram Blak";
            FramName[1] = "Fram glass lid";
            FramName[2] = "Fram RGB";
            FramCountry[0] = "Taiwan";
            FramCountry[1] = "China";
            FramCountry[2] = "Japan";
            FramPrice[0] = "10";
            FramPrice[1] = "50";
            FramPrice[2] = "100";
        }

        public string[] FramName { get; } = new string[3];
        public string[] FramCountry { get; } = new string[3];
        public string[] FramPrice { get; } = new string[3];
    }
}
