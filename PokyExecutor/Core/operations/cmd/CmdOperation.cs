using PokyExecutorCore.Core.Executors.Internals;

namespace PokyExecutorCore.Core.Operations
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
