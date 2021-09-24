using System;
namespace DesignPatterns.Observer
{
    public class BinaryObserver : IObserver
    {
        public BinaryObserver(Subject subject)
        {
            _subject = subject;
            _subject.Attach(this);
        }

        public override void Update()
        {
            Console.WriteLine("Value in binary is: " + Convert.ToString(_subject.GetState(),2));
        }
    }
}
