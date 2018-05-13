using System;
using System.Runtime.Serialization;

namespace SelfCSharp.Chap09
{
    class MyAppException : Exception
    {
        public MyAppException()
        {
        }

        public MyAppException(string message) : base(message)
        {
        }

        public MyAppException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        public MyAppException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
