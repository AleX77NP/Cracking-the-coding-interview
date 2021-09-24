using System;
namespace DesignPatterns.Adapter
{
    public class MyAdapter : Target // The adapter pattern convert the interface of a class into another interface clients expect.
                                  // Adapter lets classes work together that couldn’t otherwise because of incompatible interfaces.
    {
        private Adaptee _adaptee = new Adaptee();

        public MyAdapter() { }

        public override void Request()
        {
            _adaptee.SpecialRequest();
        }
    }
}
