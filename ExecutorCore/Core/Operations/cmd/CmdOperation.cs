using CSJobExecutor.Core.Executors.Internals;

namespace CSJobExecutor.Core.Operations
{
    class CmdOperation : IOperation
    {
        private readonly string command;

        public CmdOperation(string command)
        {
            this.command = command;
        }

        public IOperationExecutionResult Execute()
        {
            IOperationExecutor<int> runner = new CmdOperationExecutor(command);
            return new CmdOperationResult(runner.Run());
        }

        public override string ToString()
        {
            return $"EXECUTE ${command}";
        }
    }
}
