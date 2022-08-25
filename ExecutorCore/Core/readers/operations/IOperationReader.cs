using PokyExecutorCore.Core.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokyExecutorCore.Core.Readers.Operations
{
    interface IOperationReader
    {
        IOperation read();
    }
}
