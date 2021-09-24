using System;
namespace DesignPatterns.FactoryPattern
{
    public class CircleFactory : ShapeFactory
    {
        public CircleFactory() { }

        public override IShape GetShape()
        {
            return new Circle();
        }
    }
}
