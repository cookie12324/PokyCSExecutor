using CSJobExecutor.Core;

namespace TinyCSExecutor.Core.readers.job
{
    internal class TextFileJobReaderFactory : IJobReaderFactory
    {
        private string _fileName;

        public TextFileJobReaderFactory(string fileName)
        {
            _fileName = fileName;
        }

        public IJobReader CreateReader()
        {
            return new TextFileJobReader(_fileName);
        }
    }
}
