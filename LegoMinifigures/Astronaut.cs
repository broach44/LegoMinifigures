using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigures
{
    class Astronaut
    {
        public string Location { get; set; } 
        public bool SuitedUp { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }
        public int OxygenLevel { get; set; }

        public Astronaut(string name, string job)
        {
            Name = name;
            Job = job;
        }

        public void DoYourJob()
        {
            Console.WriteLine($"Doing all my {Job} duties...");
        }

    }
}
