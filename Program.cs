using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer myMac = new Computer()
            {
                model = "IOS 10",
                price = 10000,
                numberOfProcessors = 16,
                screenSize = 28,
                isTurnOn = true,
            };
            Computer myHp = new Computer()
            {
                model = "HP 8000",
                price = 5000,
                numberOfProcessors = 8,
                screenSize = 24,
                isTurnOn = true,
            };
            Computer myLenovo = new Computer()
            {
                model = "v14",
                price = 4000,
                numberOfProcessors = 16,
                screenSize = 28,
                isTurnOn = true,
            };
            myHp.TellMeThePrice();
            myMac.TellMeTheScreenSize();
            myHp.TurnOn();
            myLenovo.TurnOof();
            Console.WriteLine(myLenovo);
            myLenovo.ToString();


        }
    }
}
