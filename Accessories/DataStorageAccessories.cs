using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW_7.Interface;

namespace HW_7.Accessories
{
    public class DataStorageAccessories : IAccessorise
    {
        public DataStorageAccessories()
        {
            DataStorageName[0] = "HDD 1T";
            DataStorageName[1] = "SSD 500Gb";
            DataStorageName[2] = "SSD M2 500Gb";
            DataStorageCountry[0] = "Taiwan";
            DataStorageCountry[1] = "China";
            DataStorageCountry[2] = "Japan";
            DataStoragePrice[0] = "20";
            DataStoragePrice[1] = "60";
            DataStoragePrice[2] = "150";
        }

        public string[] DataStorageName { get; } = new string[3];

        public string[] DataStorageCountry { get; } = new string[3];

        public string[] DataStoragePrice { get; } = new string[3];
    }
}
