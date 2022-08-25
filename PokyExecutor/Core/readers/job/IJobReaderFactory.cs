using PokyExecutorCore.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokyExecutor.Core.readers.job
{
    internal interface IJobReaderFactory
    {
        IJobReader CreateReader();
    }
}
