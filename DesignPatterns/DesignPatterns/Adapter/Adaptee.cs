using System;
namespace DesignPatterns.Adapter
{
    public class Adaptee
    {
        public Adaptee() { }

        public void SpecialRequest()
        {
            Console.WriteLine("Special Request()...");
        }
    }
}
