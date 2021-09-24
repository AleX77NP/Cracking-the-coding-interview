using System;
namespace DesignPatterns.Observer
{
    public class DecimalObserver : IObserver
    {
        public DecimalObserver(Subject subject)
        {
            _subject = subject;
            _subject.Attach(this);
        }

        public override void Update()
        {
            Console.WriteLine("Value is: " + _subject.GetState());
        }
    }
}
