using System;
namespace DesignPatterns.Adapter
{
    public class Target
    {
        public Target() { }

        public virtual void Request()
        {
            Console.Write("Target Request()...");
        }
    }
}
