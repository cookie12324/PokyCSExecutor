﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokyExecutorCore.Core.Executors.Internals
{
    interface IOperationExecutor<T>
    {
        T Run();
    }
}
