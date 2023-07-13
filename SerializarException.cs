using System.Runtime.Serialization;

namespace PPLabo2_2D
{
    [Serializable]
    internal class SerializarException : Exception
    {
        public SerializarException()
        {
        }

        public SerializarException(string? message) : base(message)
        {
        }

        public SerializarException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected SerializarException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}