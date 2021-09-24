using System;
namespace DesignPatterns.FactoryPattern
{
    public class SquareFactory : ShapeFactory
    {
        public SquareFactory() { }

        public override IShape GetShape()
        {
            return new Square();
        }
    }
}
