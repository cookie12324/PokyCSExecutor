using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSJobExecutor.Core.Operations
{
    class CmdOperationResult : IOperationExecutionResult
    {
        private readonly int _exitCode;

        public CmdOperationResult(int exitCode)
        {
            _exitCode = exitCode;
        }

        public bool HasErrors()
        {
            return _exitCode != 0;
        }

        public override string ToString()
        {
            return $"Type = [ ${this.GetType()} ],[ EXIT CODE = {_exitCode} ]";
        }
    }
}
