using System;
using DesignPatterns.Adapter;
using DesignPatterns.Bridge;
using DesignPatterns.Facade;
using DesignPatterns.FactoryPattern;
using DesignPatterns.Observer;
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

            // Facade demo
            WriterMaker wm = new WriterMaker();
            wm.WriteToFile();
            wm.WriteToDb();

            // Bridge demo
            Vehicle v1 = new Car(new Assemble(), new Produce());
            Vehicle v2 = new Bike(new Assemble(), new Produce());

            v1.Infrastructure();
            v2.Infrastructure();

            // Adapter demo
            Target t = new MyAdapter();
            t.Request();

            // Observer demo
            Subject sb = new Subject();

            new DecimalObserver(sb);
            new BinaryObserver(sb);

            Console.WriteLine("First value is 10");
            sb.SetState(10);
            Console.WriteLine("Second value is 100");
            sb.SetState(100);
        }
    }
}
