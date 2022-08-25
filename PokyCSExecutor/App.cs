using CSJobExecutor.Core;
using CSJobExecutor.Core.Executors;
using TinyCSExecutor.Core.readers.job;

namespace TinyCSExecutor
{
    class App
    {
        static void Main(string[] args)
        {
            IJobReaderFactory factory = new TextFileJobReaderFactory("jobfile.txt");
            IJobReader reader = factory.CreateReader();
            Job targetJob = reader.Read();
            JobExecutor executor = new DefaultJobExecutor();
            executor.Execute(targetJob);
        }
    }
}
