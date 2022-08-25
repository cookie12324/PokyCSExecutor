using PokyExecutorCore.Core.Executors.Internals;
using PokyExecutorCore.Core.Operations.download;

namespace PokyExecutorCore.Core.Operations
{
    class SyncDownloadOperation : IOperation
    {
        private readonly string _downloadUrl;
        private readonly string _fileName;

        public SyncDownloadOperation(string downloadUrl, string fileName)
        {
            _downloadUrl = downloadUrl;
            _fileName = fileName;
        }

        public IOperationExecutionResult Execute()
        {
            IOperationExecutor<bool> executor = new SyncDownloadOperationExecutor(_downloadUrl, _fileName);
            bool downloadSuccsessful = executor.Run();
            return new SyncDownloadOperationResult(downloadSuccsessful);
        }

        public override string ToString()
        {
            return $"DOWNLOAD {_downloadUrl} {_fileName}";
        }
    }
}
