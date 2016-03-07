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

            foreach(ICritters c in AllCritters)
            {
                c.DisplayName();
                Console.Write($"{c.Name} says ");
                c.DisplayGreeting();
            }

            List<Organic> Organics = new List<Organic> {BlackAndWhite, Person};
            
            Console.ReadLine();
        }
    }
}
