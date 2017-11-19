using System;
using System.Runtime.Serialization;

namespace Discounts.Exceptions
{
    [Serializable]
    internal class DuplicateObjectexception : Exception
    {
        public DuplicateObjectexception()
        {
        }

        public DuplicateObjectexception(string message) : base(message)
        {
        }

        public DuplicateObjectexception(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DuplicateObjectexception(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}