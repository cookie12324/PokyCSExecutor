using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokyExecutorCore.Core.Operations.download
{
    class SyncDownloadOperationResult : IOperationExecutionResult
    {
        private bool _downloadSuccessful;

        public SyncDownloadOperationResult(bool downloadSuccessful)
        {
            _downloadSuccessful = downloadSuccessful;
        }

        public bool HasErrors()
        {
            return !_downloadSuccessful;
        }
    }
}
