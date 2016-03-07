using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            Robot Bot = new Robot("Bender");
            Human Person = new Human("Kate");
            Panda BlackAndWhite = new Panda("Joe Bear");

            List<ICritters> AllCritters = new List<ICritters> {Bot, Person, BlackAndWhite};

            List<Organic> Organics = new List<Organic> {BlackAndWhite, Person};
            
            Console.ReadLine();
        }
    }
}
