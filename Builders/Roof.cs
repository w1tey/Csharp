using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Roof : IPart
    {
        public Roof()
        {
            Percentage = 0;
            Material = "Wood";
            IsFinished = false;
        }

        public int Percentage { get; set; }
        public string Material { get; set; }
        public bool IsFinished { get; set; }
        public void Construction(int AddedProgress)
        {
            Percentage += AddedProgress;

            if (Percentage > 100)
            {
                IsFinished = true;
            }
        }

        public void Print()
        {
            Console.WriteLine(
                $"Percentage: {Percentage}" +
                $"Material: {Material}" +
                $"Is it finished?: {IsFinished}" +
                $"\n");
        }
    }
}
