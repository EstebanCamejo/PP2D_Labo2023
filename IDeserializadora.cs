using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPLabo2_2D
{
    public interface IDeserializadora 
    {
        public string DeSerializarJson();

        public string DeSerializarXml();
    }
}
