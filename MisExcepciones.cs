using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PPLabo2_2D
{
    public class MisExcepciones : Exception
    {
        public MisExcepciones()
        {
        }

        public MisExcepciones(string? message) : base(message)
        {
        }

        public MisExcepciones(string? message, Exception? innerException) : base(message, innerException)
        {
        }

    }
}
