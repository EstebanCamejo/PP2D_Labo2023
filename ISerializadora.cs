using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPLabo2_2D
{
    public interface ISerializadora <T>
    {
        public void SerializarJson (List<T> listaSerializar);

        public void SerializarXml(List<T> listaSerializar);
    }
}
