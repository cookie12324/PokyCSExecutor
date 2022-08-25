using PokyExecutorCore.Core.Exceptions;
using PokyExecutorCore.Core.Operations;
using System;

namespace PokyExecutorCore.Core.Executors
{
    class DefaultJobExecutor : JobExecutor
    {
        public void Execute(Job job)
        {
            if (!job.HasCommands())
            {
                Console.WriteLine("Job has no commands, nothing to execute");
                return;
            }

            Console.WriteLine("Starting {0} job execution", job.Name);

            foreach (IOperation operation in job)
            {
                Console.Write($"Starting operation: {operation}: ");
                IOperationExecutionResult result = operation.Execute();

                if (result.HasErrors()) 
                {
                    throw new OperationExecutionException($"Failed to execute operation " +
                        $"technical information {result}");
                }

                Console.WriteLine("Done");
            }

        }
    }
}
