using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PokyExecutorCore.Core.Exceptions
{
    class OperationExecutionException : Exception
    {
        public OperationExecutionException()
        {
        }

        public OperationExecutionException(string message) : base(message)
        {
        }

        public OperationExecutionException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected OperationExecutionException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
