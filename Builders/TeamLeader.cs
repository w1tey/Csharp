using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class TeamLeader : IWorker
    {
        public TeamLeader(string _Name, string _Surname)
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
            Console.WriteLine("Team Leader cannot build, only can check.");
        }


        public bool Check(House house)
        {
            if (
                house.Roof.IsFinished == true &&
                house.Door.IsFinished == true &&
                house.Windows[1].IsFinished == true &&
                house.Windows[2].IsFinished == true &&
                house.Windows[3].IsFinished == true &&
                house.Windows[4].IsFinished == true &&
                house.Foundation.IsFinished == true &&
                house.Walls[1].IsFinished == true &&
                house.Walls[2].IsFinished == true &&
                house.Walls[3].IsFinished == true &&
                house.Walls[4].IsFinished == true
            )
            {
                return true;
            }

            else return false;
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
