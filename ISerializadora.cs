using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPLabo2_2D
{

    //La interfaz se utiliza con un parámetro generico T que debe ser una clase con un constructor sin parametros.
    //Las clases que implementen esta interfaz deberan proporcionar una implementacion de los metodos
    //Serializar y Deserializar para adaptarse a sus necesidades especificas de serializacion y deserializacion.
    public interface ISerializadora <T> where T : class, new()
    {
        public bool Serializar(T obj);
        public T Deserializar();
    }
}
