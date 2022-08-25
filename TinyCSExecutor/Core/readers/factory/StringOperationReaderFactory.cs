using CSJobExecutor.Core.Exceptions;
using CSJobExecutor.Core.Readers.Operations;
using CSJobExecutor.Core.Readers.Operations.Pool;
using System;

namespace CSJobExecutor.Core.Readers.Factory
{
    class StringOperationReaderFactory : IOperationReaderFactory
    {
        private static readonly string EXECUTE_STRING = "execute";
        private static readonly string DOWNLOAD_STRING = "download";

        private static readonly OperationsReadersObjectPool _pool = new OperationsReadersObjectPool();

        private string _textFileLine = null;

        public StringOperationReaderFactory(string textFileLine)
        {
            _textFileLine = textFileLine.Trim();
        }

        public Tuple<OperationType, IOperationReader> CreateOperationReader()
        {
            if (_textFileLine.StartsWith(EXECUTE_STRING))
            {
                if (_pool.ContainsKey(OperationType.EXECUTE))
                {
                    IOperationReader reader = _pool.GetObject(OperationType.EXECUTE);
                    return new Tuple<OperationType, IOperationReader>(
                        OperationType.EXECUTE,
                        reader);
                }

                return new Tuple<OperationType, IOperationReader>(
                    OperationType.EXECUTE,
                    new CmdOperationStringReader(_textFileLine));
            }
            else if (_textFileLine.StartsWith(DOWNLOAD_STRING))
            {
                if (_pool.ContainsKey(OperationType.DOWNLOAD))
                {
                    IOperationReader reader = _pool.GetObject(OperationType.EXECUTE);
                    return new Tuple<OperationType, IOperationReader>(
                        OperationType.DOWNLOAD,
                        reader);
                }

                return new Tuple<OperationType, IOperationReader>(
                    OperationType.DOWNLOAD,
                    new SyncDownloadOperationStringReader(_textFileLine)
                    );
            }
            else throw new OperationCreationException($"Unable to create operation from line \"{_textFileLine}\"");
        }
    }
}
