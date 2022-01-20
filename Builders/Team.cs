using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Team
    {
        public List<Worker> Workers = new List<Worker> { new Worker("Emil", "Moryakoff"), new Worker("Elvin", "fjfjf"), new Worker("ilkoinm", "  dd d"), new Worker("Ismafff", "fshufif") };
        public TeamLeader Leader = new TeamLeader("Deez", "JoJos Bizarre Adventure");   
    }
}
