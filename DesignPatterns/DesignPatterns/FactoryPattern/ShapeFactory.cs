using System;
namespace DesignPatterns.FactoryPattern
{
    public abstract class ShapeFactory
    {

        // In Factory pattern, we create object without exposing the creation logic to the client
        // and refer to newly created object using a common interface.

        public abstract IShape GetShape();
    }
}
