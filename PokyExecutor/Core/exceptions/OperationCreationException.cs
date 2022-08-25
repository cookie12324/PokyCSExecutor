using System;
using System.Runtime.Serialization;

namespace PokyExecutorCore.Core.Exceptions
{
    class OperationCreationException : Exception
    {
        public OperationCreationException()
        {
        }

        public OperationCreationException(string message) : base(message)
        {
        }

        public OperationCreationException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected OperationCreationException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
