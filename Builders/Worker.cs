using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Worker : IWorker
    {
        public Worker(string _Name, string _Surname)
        {
            Random rnd = new Random();
            int num = rnd.Next(1, 100);

            Name = _Name;
            Surname = _Surname;
            Strength = num;
        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Strength { get; set; }
        public void Build(IPart part)
        {
            if (part.Percentage < 100)
            {
                part.Construction(Strength);
            }
        }

        public void Print()
        {
            Console.WriteLine(
                $"Name: {Name}" +
                $"Surname: {Surname}" +
                $"Strength: {Strength}");
        }
    }
}
