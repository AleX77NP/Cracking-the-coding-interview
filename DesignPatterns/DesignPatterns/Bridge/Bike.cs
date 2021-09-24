using System;
namespace DesignPatterns.Bridge
{
    public class Bike : Vehicle
    {
        public Bike(Workshop w1, Workshop w2) : base(w1, w2) { }

        public override void Infrastructure()
        {
            Console.WriteLine("Bike");
            _w1.Work();
            _w2.Work();
        }
    }
}
