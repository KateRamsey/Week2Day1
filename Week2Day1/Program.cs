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
                Console.WriteLine($"{c.Name} is Asleep? {c.IsASleep()}");
                Console.WriteLine();
            }

            List<Organic> Organics = new List<Organic> {BlackAndWhite, Person};

            foreach(Organic o in Organics)
            {
                o.Eat("Tacos");
            }

            Console.WriteLine();
            if (Bot.IsTerminator)
            {
                Console.WriteLine($"{Bot.Name} is a terminator");
            }

            Bot.ShutDown();
            Person.GoToSleep();
            BlackAndWhite.GoToSleep();

            foreach (ICritters c in AllCritters)
            {
                Console.WriteLine($"{c.Name} is Asleep? {c.IsASleep()}");
                Console.WriteLine();
            }

            Console.WriteLine();

            Bot.StartUp();
            Person.WakeUp();
            BlackAndWhite.WakeUp();

            foreach (ICritters c in AllCritters)
            {
                Console.WriteLine($"{c.Name} is Asleep? {c.IsASleep()}");
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
