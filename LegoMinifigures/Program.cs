using System;

namespace LegoMinifigures
{
    class Program
    {
        static void Main(string[] args)
        {
            var astronaut = new Astronaut("Space Person", "Janitor");

            astronaut.DoYourJob();
        }
    }
}
