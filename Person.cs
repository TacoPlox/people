using System;

namespace Persons
{
    class Person {
        private string name;

        static public string bloodColor = "red";

        public Person (string name) {
            this.name = name;
        }

        public void SayHello () {
            Console.WriteLine("Hello, my name is " + this.name);
        }

        static public void PrintRace () {
            Console.WriteLine("Human");
        }
    }
}