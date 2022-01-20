using System;

namespace ConsoleApp1 
{ 
    public  class Program {
        public static void Main(string[] args)
        {
            House house = new House();
            Team team = new Team();
            team.Workers[1].Build(house.Walls[1]);
        }
    }
}

