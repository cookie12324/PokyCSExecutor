using CSJobExecutor.Core.Exceptions;
using CSJobExecutor.Core.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSJobExecutor.Core.Readers.Operations
{
    class SyncDownloadOperationStringReader : IOperationReader
    {
        private readonly string _downloadFileLine;

        public SyncDownloadOperationStringReader(string downloadFileLine)
        {
            _downloadFileLine = downloadFileLine;
        }

        public IOperation read()
        {
            string downloadKeyword = "download";
            int index = downloadKeyword.Length + 1;
            string targetString = _downloadFileLine
                .Substring(index);

            string [] split = targetString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (split.Length != 2)
            {
                throw new OperationCreationException($"Unable to construct download operation from line {_downloadFileLine}, invalid tokens count = {split.Length}");
            }

            string fileName = split[1];
            string downloadUrl = split[0];

            return new SyncDownloadOperation(downloadUrl, fileName);
        }
    }
}
