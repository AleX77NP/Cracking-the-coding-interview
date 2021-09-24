using System;
namespace DesignPatterns.FactoryPattern
{
    public class Circle : IShape
    {
        private int _r;

        public Circle(int r = 1)
        {
            _r = r;
        }

        public void Draw()
        {
            Console.WriteLine("Drawing square with with radisu: " + _r);
        }
    }
}
