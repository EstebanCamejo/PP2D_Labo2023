using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PPLabo2_2D
{
    public class SerializadorJson<T> : ISerializadora<T> where T : class, new()
    {
        public StreamWriter escribirArchivo;
        public StreamReader leerArchivo;

        public string path;

        /// <summary>
        /// indica la ruta donde guarda el archivo
        /// </summary>
        /// <param name="archivo"></param>
        public SerializadorJson(string archivo)
        {
            path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            path += "\\" + archivo;
        }

        /// <summary>
        /// deserializa el objeto
        /// </summary>
        /// <returns></returns>
        public T Deserializar()
        {
            T aux = new T();
            try
            {
                using (leerArchivo = new StreamReader(path))
                {
                    string json = leerArchivo.ReadToEnd();

                    aux = JsonSerializer.Deserialize<T>(json);
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
        public bool Serializar(T objeto)
        {
            bool retorno = false;
            try
            {
                using (escribirArchivo = new StreamWriter(path))
                {
                    string json = JsonSerializer.Serialize(objeto);
                    escribirArchivo.Write(json);
                    retorno = true;
                }
            }
            catch (Exception)
            {
                retorno = false;
            }
            return retorno;
        }
    }
}
