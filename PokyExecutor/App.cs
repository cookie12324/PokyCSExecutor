using PokyExecutorCore.Core;
using PokyExecutorCore.Core.Executors;
using PokyCSExecutor.Core.readers.job;

namespace PokyCSExecutor
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
