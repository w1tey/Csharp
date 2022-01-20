using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal interface IWorker
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Strength { get; set; }
        public void Build(IPart part);
        public void Print();
    }
}
