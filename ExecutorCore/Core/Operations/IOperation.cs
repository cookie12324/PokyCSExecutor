using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSJobExecutor.Core.Operations
{
    interface IOperation
    {
        IOperationExecutionResult Execute();
    }
}
