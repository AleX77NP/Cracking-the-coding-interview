using System;
using DesignPatterns.FactoryPattern;
using DesignPatterns.Singleton;
using DesignPatterns.Strategy;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            // Singleton demo
            SimpleObject s = SimpleObject.getInstance();
            s.Greeting();

            // Factory demo
            ShapeFactory sf = null;
            var shapeInput = Console.ReadLine();

            switch(shapeInput.ToUpper())
            {
                case "SQUARE":
                    sf = new SquareFactory();
                    break;
                case "CIRCLE":
                    sf = new CircleFactory();
                    break;
                default:
                    break;
            }

            var myShape = sf.GetShape();
            myShape.Draw();

            // Strategy demo
            int m = 10, n = 5;

            Context ctx = new Context(new OperationAdd());
            ctx.Execute(m, n);
            ctx = new Context(new OperationSubstract());
            ctx.Execute(m, n);
        }
    }
}
