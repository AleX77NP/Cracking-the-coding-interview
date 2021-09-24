using System;
namespace DesignPatterns.Observer
{
    public abstract class IObserver
    {
        protected Subject _subject;

        public abstract void Update();
    }
}
