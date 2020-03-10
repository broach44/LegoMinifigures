using LegoMinifigures.Composition.Heads;
using LegoMinifigures.Composition.Legs;
using LegoMinifigures.Composition.Torsos;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigures
{

    class Astronaut
    {
        // Public property
        public Location Location { get; set; }
        // Expression Bodied Property
        public bool SuitedUp => Name == "Space Person";
        // Read-Only Property
        public string Name { get; }
        // Public property with a private setter
        public string Job { get; private set; }
        public int OxygenLevel { private get; set; }

        public AstronautTorso Torso { get; set; }
        public AstronautLegs Legs { get; set; }
        public ZoeHead Head { get; set; }

        public Astronaut(string name, string job, 
                        ZoeHead head, AstronautTorso torso, 
                        AstronautLegs legs)
        {
            Name = name;
            Job = job;
            Head = head;
            Torso = torso;
            Legs = legs;
        }

        public void Promote()
        {
            Job = "Commander of Janitors";
        }

        public void DoYourJob()
        {
            Console.WriteLine($"Doing all my {Job} duties...");
            Legs.Walk(15);
            Head.EatPie("Cherry");
            Torso.Flex();
            Legs.Walk(10);
        }

    }
}
