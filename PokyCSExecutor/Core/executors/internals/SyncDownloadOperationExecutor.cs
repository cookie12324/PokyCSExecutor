using System;
using System.ComponentModel;
using System.Net;
using System.Threading;

namespace CSJobExecutor.Core.Executors.Internals
{
    class SyncDownloadOperationExecutor : IOperationExecutor<bool>
    {
        private readonly string _link;
        private readonly string _filename;
        private readonly WebClient _client;
        private volatile bool _downloadCompleted;

        public SyncDownloadOperationExecutor(string link, string filename)
        {
            _link = link;
            _filename = filename;
            _client = createWebClient();
            _client.DownloadFileCompleted += new AsyncCompletedEventHandler(_client_DownloadFileCompleted);
        }

        private void _client_DownloadFileCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            _downloadCompleted = !e.Cancelled && e.Error == null;
        }

        public bool Run()
        {
            StartDownload(_link, _filename);

            while (_client.IsBusy)
            {
                Thread.Sleep(1000);
            }

            return _downloadCompleted;
        }

        private void StartDownload(string link, string filename)
        {
            Console.WriteLine(link);
            _client.DownloadFileAsync(new Uri(link), filename);
        }

        private WebClient createWebClient()
        {
            WebClient client = new WebClient();
            return client;
        }
    }
}
