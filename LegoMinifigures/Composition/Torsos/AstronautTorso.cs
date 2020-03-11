using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigures.Composition.Torsos
{
    class AstronautTorso : TorsoBase  // Creates "is a" relationship, similar to React "extends"
    {
        public int NumberOfArms { get; set; }
        public override bool ChiseledAbs { get; set; }

        public override void Flex() // override says this is related to what the torso base said it should do
        {
            if (ChiseledAbs && !Shirted)
            {
                Console.WriteLine("Check out my sick abs!");
            }
            else if (HandType == HandType.XBuster)
            {
                Console.WriteLine("Welcome to the gun show.");
            }
            else
            {
                Console.WriteLine("Weird flex, but ok.");
            }

        }

        public override void Breathe()
        {
            Console.WriteLine("Some other pattern of breathing....");
        }

    }


}
