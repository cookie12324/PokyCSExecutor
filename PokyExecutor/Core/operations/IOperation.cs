using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokyExecutorCore.Core.Operations
{
    interface IOperation
    {
        IOperationExecutionResult Execute();
    }
}
