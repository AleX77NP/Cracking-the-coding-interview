using System;
namespace DesignPatterns.Strategy
{
    public class OperationSubstract : IOperation
    {

        public void DoOperation(int n, int m)
        {
            Console.WriteLine("Result of: " + n + " - " + m + " is: " + (n - m));
        }
    }
}
