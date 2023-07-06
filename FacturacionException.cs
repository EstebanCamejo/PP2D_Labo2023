using System.Runtime.Serialization;

namespace VisualParcial1
{
    [Serializable]
    internal class FacturacionException : Exception
    {
        public FacturacionException() : base ("Error al obtener la ultima factura.")
        {
        }

        public FacturacionException(string? message) : base(message)
        {
        }

        public FacturacionException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected FacturacionException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}