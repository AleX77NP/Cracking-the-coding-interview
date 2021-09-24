using System;
namespace DesignPatterns.Bridge
{
    public class Produce : Workshop
    {
        public Produce() { }

        public void Work()
        {
            Console.WriteLine("Producing....Poduced.");
        }
    }
}
