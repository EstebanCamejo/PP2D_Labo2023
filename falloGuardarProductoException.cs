using System.Runtime.Serialization;

namespace VisualParcial1
{
    [Serializable]
    internal class falloGuardarProductoException : Exception
    {
        public falloGuardarProductoException()
        {
        }

        public falloGuardarProductoException(string? message) : base(message)
        {
        }

        public falloGuardarProductoException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected falloGuardarProductoException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}