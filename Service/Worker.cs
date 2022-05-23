using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW_7.Accessories;
using HW_7.PC.HousingDerivative;
using HW_7.PC.MotherboardDerivative;
using HW_7.PC;
using HW_7.Interface;

namespace HW_7.Service
{
    public class Worker : IMake
    {
        private GPU _gpu;
        private CPU _cpu;
        private Motherboard _motherBoard;
        private RAM _ram;
        private Cooling _cooling;
        private DataStorage _dataStorage;
        private Fram _fram;
        private PowerUnit _powerUnit;
        public Worker()
        {
            ArrayAcces[0] = new CoolingSystemAccessories();
            ArrayAcces[1] = new CPUAccessories();
            ArrayAcces[2] = new DataStorageAccessories();
            ArrayAcces[3] = new FramAccessories();
            ArrayAcces[4] = new GPUAccessories();
            ArrayAcces[5] = new MotherboardAccessories();
            ArrayAcces[6] = new PowerUnitAccessories();
            ArrayAcces[7] = new RAMAccessories();
            ArrayPC[0] = _gpu = new GPU();
            ArrayPC[1] = _cpu = new CPU();
            ArrayPC[2] = _motherBoard = new Motherboard();
            ArrayPC[3] = _ram = new RAM();
            ArrayPC[4] = _cooling = new Cooling();
            ArrayPC[5] = _dataStorage = new DataStorage();
            ArrayPC[6] = _fram = new Fram();
            ArrayPC[7] = _powerUnit = new PowerUnit();
        }

        public IAccessorise[] ArrayAcces { get; } = new IAccessorise[8];
        public PC.PC[] ArrayPC { get; } = new PC.PC[8];

        public void Make(int userInfo)
        {
            foreach (var item in ArrayAcces)
            {
                if (item is GPUAccessories)
                {
                    GPUAccessories? gPUAccessories = item as GPUAccessories;
                    _gpu.Name = gPUAccessories?.GpuName[userInfo];
                    _gpu.Countru = gPUAccessories?.GpuCountry[userInfo];
                    _gpu.Prise = gPUAccessories?.GpuPrice[userInfo];
                }
                else if (item is CPUAccessories)
                {
                    CPUAccessories? cPUAccessories = item as CPUAccessories;
                    _cpu.Name = cPUAccessories?.CpuName[userInfo];
                    _cpu.Countru = cPUAccessories?.CpuCountry[userInfo];
                    _cpu.Prise = cPUAccessories?.CpuPrice[userInfo];
                }
                else if (item is MotherboardAccessories)
                {
                    MotherboardAccessories? motherboardAccessories = item as MotherboardAccessories;
                    _motherBoard.Name = motherboardAccessories?.MothBoaName[userInfo];
                    _motherBoard.Countru = motherboardAccessories?.MothBoaCountry[userInfo];
                    _motherBoard.Prise = motherboardAccessories?.MothBoaPrice[userInfo];
                }
                else if (item is RAMAccessories)
                {
                    RAMAccessories? ramAccessories = item as RAMAccessories;
                    _ram.Name = ramAccessories?.RamName[userInfo];
                    _ram.Countru = ramAccessories?.RamCountry[userInfo];
                    _ram.Prise = ramAccessories?.RamPrice[userInfo];
                }
                else if (item is CoolingSystemAccessories)
                {
                    CoolingSystemAccessories? coolingSystemAccessories = item as CoolingSystemAccessories;
                    _cooling.Name = coolingSystemAccessories?.CoolName[userInfo];
                    _cooling.Countru = coolingSystemAccessories?.CoolCountry[userInfo];
                    _cooling.Prise = coolingSystemAccessories?.CoolPrice[userInfo];
                }
                else if (item is DataStorageAccessories)
                {
                    DataStorageAccessories? dataStorageAccessories = item as DataStorageAccessories;
                    _dataStorage.Name = dataStorageAccessories?.DataStorageName[userInfo];
                    _dataStorage.Countru = dataStorageAccessories?.DataStorageCountry[userInfo];
                    _dataStorage.Prise = dataStorageAccessories?.DataStoragePrice[userInfo];
                }
                else if (item is FramAccessories)
                {
                    FramAccessories? framAccessories = item as FramAccessories;
                    _fram.Name = framAccessories?.FramName[userInfo];
                    _fram.Countru = framAccessories?.FramCountry[userInfo];
                    _fram.Prise = framAccessories?.FramPrice[userInfo];
                }
                else if (item is PowerUnitAccessories)
                {
                    PowerUnitAccessories? powerUnitAccessories = item as PowerUnitAccessories;
                    _powerUnit.Name = powerUnitAccessories?.PowerName[userInfo];
                    _powerUnit.Countru = powerUnitAccessories?.PowerCountry[userInfo];
                    _powerUnit.Prise = powerUnitAccessories?.PowerPrice[userInfo];
                }
            }

            foreach (var item in ArrayPC)
            {
                item.Get();
            }
        }
    }
}
