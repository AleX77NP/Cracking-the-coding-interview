using System;
namespace DesignPatterns.Facade
{
    public class DbWriter : IWriter
    {
        public DbWriter() { }

        public void Write()
        {
            Console.WriteLine("Writing to the database...");
        }
    }
}
