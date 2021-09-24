using System;
namespace DesignPatterns.Bridge
{
    public class Car : Vehicle
    {
        public Car(Workshop w1, Workshop w2) : base(w1, w2) { }

        public override void Infrastructure()
        {
            Console.WriteLine("Car");
            _w1.Work();
            _w2.Work();
        }
    }
}
