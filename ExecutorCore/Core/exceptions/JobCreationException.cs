using System;
using System.Runtime.Serialization;

namespace PokyExecutorCore.Core.Exceptions
{
    class JobCreationException : Exception
    {
        public JobCreationException()
        {
        }

        public JobCreationException(string message) : base(message)
        {
        }

        public JobCreationException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected JobCreationException(SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}
