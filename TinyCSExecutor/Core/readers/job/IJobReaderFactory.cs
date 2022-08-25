using CSJobExecutor.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyCSExecutor.Core.readers.job
{
    internal interface IJobReaderFactory
    {
        IJobReader CreateReader();
    }
}
