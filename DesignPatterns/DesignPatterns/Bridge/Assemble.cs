using System;
namespace DesignPatterns.Bridge
{
    public class Assemble : Workshop
    {
        public Assemble() { }

        public void Work()
        {
            Console.WriteLine("Assembling...Assembled.");
        }
    }
}
