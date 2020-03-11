using LegoMinifigures.Composition.Heads;
using LegoMinifigures.Composition.Legs;
using LegoMinifigures.Composition.Torsos;
using System;

namespace LegoMinifigures
{
    class Program
    {
        static void Main(string[] args)
        {
            var head = new ZoeHead
            {
                FacialExpression = "Smiling",
                Color = LegoColor.Orange,
                EyeColor = LegoColor.Green,
                Helmeted = true
            };

            var legs = new AstronautLegs
            {
                HasPants = true,
                Shoes = ShoeType.FlipFlops
            };

            var atorso = new AstronautTorso
            {
                NumberOfArms = 2,
                ChiseledAbs = true,
                Shirted = true,
                HandType = HandType.Baby

            };
            var btorso = new AstronautTorso
            {
                NumberOfArms = 2,
                ChiseledAbs = true,
                Shirted = true,
                HandType = HandType.Baby

            };
            var astronaut = new Astronaut("Space Person", "Janitor", head, atorso, legs);
            var astronaut2 = new Astronaut("Space Lady", "Janitor", head, btorso, legs);
            
            astronaut.DoYourJob();
            var casper = new Ghost("Casper", DateTime.Today) { Friendly = true };

            casper.Spook();
            casper.Haunt("Whipstaff Manor");
            casper.Spook();

        }
    }
}
