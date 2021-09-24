using System;
using System.Collections.Generic;

namespace DesignPatterns.Observer
{
    public class Subject // Observer pattern is used when there is one-to-many relationship between objects such as if one object is modified,
                         // its depenedent objects are to be notified automatically.
                         // Observer pattern falls under behavioral pattern category.
    {
        private int _state;
        private List<IObserver> _observers = new();

        public Subject() { }

        public int GetState()
        {
            return _state;
        }

        public void SetState(int state)
        {
            _state = state;
            NotifyAllObservers();
        }

        private void NotifyAllObservers()
        {
            foreach (var o in _observers)
            {
                o.Update();
            }
        }

        public void Attach(IObserver o)
        {
            _observers.Add(o);
        }
    }
}
