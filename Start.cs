using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW_7.Service;
using HW_7.Accessories;
using HW_7.Interface;

namespace HW_7
{
    public class Start : IStarter
    {
        private Worker _worker;

        public Start()
        {
            _worker = new Worker();
        }

        public void Run()
        {
            _worker.Сondition();
        }
    }
}
