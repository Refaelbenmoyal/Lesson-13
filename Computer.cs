using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    [DebuggerDisplay("{price * 3.67f}")]
    class Computer
    {
        //Data
        public string model;
        public int price;
        public int numberOfProcessors;
        public float screenSize;
        public bool isTurnOn;

        //functionallity
         public void TellMeThePrice()
        {
            Console.WriteLine($"{ model} price is {price }");
        }
         public float TellMeTheScreenSize()
        {
            return screenSize;
        }
        public void TurnOn()
        {
            if (isTurnOn)
            {
                Console.WriteLine($"{model} is already on");
            }
            else
            {
                isTurnOn = false;
                Console.WriteLine($"turning on {model}...");
            }
        }
        public void TurnOof()
        {
            if (!isTurnOn)
            {
                Console.WriteLine($"{model} is already oof");
            }
            else
            {
                isTurnOn = true;
                Console.WriteLine($"turning oof {model}...");
            }
        }
        public void AddProcessor(int processor)
        {
            numberOfProcessors = numberOfProcessors + processor;
            Console.WriteLine($"{model} Has got {numberOfProcessors}");
        }
        public override string ToString()
        {
            return $"Computer [model]:{model} [price]:{price} [numberOfProcessors]:{numberOfProcessors} [screenSize]:{screenSize} [isTurnOn]:{isTurnOn}";
        }
    }
}
