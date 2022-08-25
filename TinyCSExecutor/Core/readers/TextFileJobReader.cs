using CSJobExecutor.Core.Operations;
using CSJobExecutor.Core.Readers.Factory;
using CSJobExecutor.Core.Readers.Operations;
using CSJobExecutor.Core.Readers.Operations.Pool;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CSJobExecutor.Core
{
    class TextFileJobReader : IJobReader
    {
        private readonly string _fileName;
        private readonly OperationsReadersObjectPool _readers;
        public TextFileJobReader(string fileName)
        {
            _readers = new OperationsReadersObjectPool();
            _fileName = fileName;
        }

        public Job Read()
        {
            Job targetJob = new Job("default");

            if (File.Exists(_fileName))
            {
                using (StreamReader reader = new StreamReader(_fileName))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (!(line.Trim() == string.Empty))
                        {
                            IOperationReaderFactory factory = new StringOperationReaderFactory(line);
                            Tuple<OperationType, IOperationReader> tuple = factory.CreateOperationReader();

                            IOperationReader operationReader = tuple.Item2;

                            IOperation operation = operationReader.read();
                            targetJob.AddOperation(operation);
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Unable to open {0}, jobfile does not exist", _fileName);
            }

            return targetJob;
        }
    }
}
