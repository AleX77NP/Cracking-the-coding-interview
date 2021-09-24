using System;
namespace DesignPatterns.Singleton
{
    public class SimpleObject
    {
        private static SimpleObject _instance = new(); // single instance

        private SimpleObject() { }

        public static SimpleObject getInstance()
        {
            return _instance;
        }

        public void Greeting()
        {
            Console.WriteLine("Single simple object says hi!");
        }
    }
}
