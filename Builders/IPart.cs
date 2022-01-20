using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal interface IPart
    {
        public int Percentage { get; set; }
        public string Material { get; set; }
        public bool IsFinished { get; set; }
        public void Construction (int AddedProgress);

        public void Print();
    }
}
