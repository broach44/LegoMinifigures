using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigures.Composition.Torsos
{
    abstract class TorsoBase // the abstract does not allow users to create a new thing of this class.  You can create other things that use this class.
    {
        public abstract bool ChiseledAbs { get; set; }
        public bool Shirted { get; set; }
        public HandType HandType { get; set; }

        public abstract void Flex(); // anything that is this base needs to implement a method that looks like this.


        public virtual void Breathe() //by default this is how breathing is done...but if we something that wants to change the method 
        {
            Console.WriteLine("Exhale...Inhale...to eternity...");
        }
    }

}

// abstract you have to override
// virtual have some behavior but you can change if you want.
