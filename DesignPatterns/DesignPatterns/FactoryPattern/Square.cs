using System;
namespace DesignPatterns.FactoryPattern
{
    public class Square : IShape
    {
        private int _a;

        public Square(int a = 1)
        {
            _a = a;
        }

        public void Draw()
        {
            Console.WriteLine("Drawing square with with side size: " + _a);
        }
    }
}
