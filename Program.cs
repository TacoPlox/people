using System;

namespace Persons
{
    class Program
    {
        static void Main(string[] args)
        {
            Person jackSparrow = new Person("Jack Sparrow");
            jackSparrow.SayHello();

            Person davyJones = new Person("Davy Jones");
            davyJones.SayHello();

            //Console.WriteLine(jackSparrow.bloodColor);
            Console.WriteLine(Person.bloodColor);

            Person.PrintRace();
        }
    }
}
