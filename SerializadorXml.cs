using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PPLabo2_2D
{
    public class SerializadorXml<T> : ISerializadora<T> where T : class, new()
    {
        private StreamWriter escribirArchivo;
        private StreamReader leerArchivo;
        public XmlSerializer serializador;

        private string path;

        /// <summary>
        ///  indica la ruta donde guarda el archivo
        /// </summary>
        /// <param name="archivo"></param>
        public SerializadorXml(string archivo)
        {
            path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            path += "\\" + archivo;
        }

        /// <summary>
        ///  deserializa el objeto  
        /// </summary>
        /// <returns></returns>
        public T Deserializar()
        {
            T aux = new T();
            try
            {
                using (leerArchivo = new StreamReader(path))
                {
                    serializador = new XmlSerializer(typeof(T));
                    aux = (T)serializador.Deserialize(leerArchivo);
                }
            }
            catch (Exception)
            {
                return null;
            }
            return aux;
        }
        /// <summary>
        ///  serializa cualquier el objeto recibido
        /// </summary> 
        /// <returns></returns>
        public bool Serializar(T item)
        {
            bool retorno = false;
            try
            {
                using (escribirArchivo = new StreamWriter(path))
                {
                    serializador = new XmlSerializer(typeof(T));

                    serializador.Serialize(escribirArchivo, item);
                }
                retorno = true;
            }
            catch (Exception)
            {
                retorno = false;
            }
            return retorno;
        }
    }
}
