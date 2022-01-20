using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class House
    {
       public List<Wall> Walls = new() { new Wall { }, new Wall { }, new Wall { }, new Wall { } };
       public List<Window> Windows = new() { new Window { }, new Window { }, new Window { }, new Window { } };
       public Basement Foundation = new Basement();
       public Roof Roof = new();
       public Door Door = new Door();

    }
}
