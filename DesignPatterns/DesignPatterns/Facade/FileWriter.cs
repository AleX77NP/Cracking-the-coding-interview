using System;
namespace DesignPatterns.Facade
{
    public class FileWriter : IWriter
    {
        public FileWriter() { }

        public void Write()
        {
            Console.WriteLine("Writing to a file...");
        }
    }
}
