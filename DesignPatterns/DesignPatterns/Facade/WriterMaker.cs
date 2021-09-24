using System;
namespace DesignPatterns.Facade
{
    public class WriterMaker
    {
        private IWriter _fileWriter;
        private IWriter _dbWriter;

        public WriterMaker()
        {
            _fileWriter = new FileWriter();
            _dbWriter = new DbWriter();
        }

        public void WriteToFile()
        {
            _fileWriter.Write();
        }

        public void WriteToDb()
        {
            _dbWriter.Write();
        }
    }
}
