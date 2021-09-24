using System;
namespace DesignPatterns.Strategy
{
    public class Context
    {
        private IOperation _operation;

        public Context(IOperation operation)
        {
            _operation = operation;
        }

        public void Execute(int m, int n)
        {
            _operation.DoOperation(n, m);
        }
    }
}
