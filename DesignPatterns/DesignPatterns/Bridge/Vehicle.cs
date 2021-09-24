using System;
namespace DesignPatterns.Bridge
{
    public abstract class Vehicle // The Bridge design pattern allows you to separate the abstraction from the implementation.It is a structural design pattern.
    {
        protected Workshop _w1;
        protected Workshop _w2;

        public Vehicle(Workshop w1, Workshop W2)
        {
            _w1 = w1;
            _w2 = W2;
        }

        abstract public void Infrastructure();
    }
}
