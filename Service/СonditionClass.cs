using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_7.Service
{
    public static class СonditionClass
    {
        public static void Сondition(this Worker worker)
        {
            Console.WriteLine("Hello, choose one of three configurations: budget, medium, top.");

            string? userChoice = Console.ReadLine();

            Console.WriteLine(new string('-', 70));

            if (userChoice == null)
            {
                userChoice = "Error";
            }

            int userInfo = 0;

            switch (userChoice.ToLower())
            {
                case "budget":
                    userInfo = 0;
                    break;
                case "medium":
                    userInfo = 1;
                    break;
                case "top":
                    userInfo = 2;
                    break;
                default:
                    Console.WriteLine("Тo such configuration");
                    break;
            }

            worker.Make(userInfo);
        }
    }
}
