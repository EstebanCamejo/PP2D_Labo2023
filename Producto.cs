namespace PPLabo2_2D
{
    using System.IO;
    using System.Text;
    using System.Text.Json;
    using System.Text.Json.Serialization;
    using System.Xml.Serialization;

    public class Producto : ISerializadora <Producto>, IDeserializadora 
    {
        private EProdcuto tipoDeProducto;
        private float precioPorKilo; //heladera
        private float cantidadDeKilos; //heladera
        private string nombre;
        private int codigoDeProducto;
        private float cantidadSolicitada;
        private float precioPorCantidad;

        private static int ultimoCodigoManual;
        private static bool primeraVez = true;
        private static string archivoUltimoCodigo = "ultimoCodigo.txt";

        public Producto()
        {
           
        }
        public Producto(EProdcuto tipoDeProducto, float precioPorKilo, float cantidadDeKilos, string nombre) : this()
        {
            
            this.tipoDeProducto = tipoDeProducto;
            this.precioPorKilo = precioPorKilo;
            this.cantidadDeKilos = cantidadDeKilos;
            this.nombre = nombre;
            codigoDeProducto = UltimoCodigoManual(); 
          
        }
        


        public Producto(EProdcuto tipoDeProducto, float precioPorKilo, float cantidadDeKilos, string nombre, int codigoDeProducto)        
        {
            this.tipoDeProducto = tipoDeProducto;
            this.precioPorKilo = precioPorKilo;
            this.cantidadDeKilos = cantidadDeKilos;
            this.nombre = nombre;
            this.codigoDeProducto = codigoDeProducto;
           
        }
       
       


        public EProdcuto TipoDeProducto { get => tipoDeProducto; set => tipoDeProducto = value; }
        public float PrecioPorKilo { get => precioPorKilo; set => precioPorKilo = value; }
        public float CantidadDeKilos { get => cantidadDeKilos; set => cantidadDeKilos = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int CodigoDeProducto { get => codigoDeProducto; set => codigoDeProducto = value; }       
        
        public float CantidadSolicitada { get => cantidadSolicitada; }
        public float PrecioPorCantidad { get => precioPorCantidad; }

        ///// <summary>
        ///// El metodo retorna una cadena de string con los datos del producto para poder mostrarse en una lista
        ///// </summary>
        ///// <returns></returns>
        //public override string ToString()
        //{
        //    return $"{TipoDeProducto} - {Nombre} - ${PrecioPorKilo} - Stock: {CantidadDeKilos} Kg.";
        //}

        /// <summary>
        /// El metodo setea la cantidad solicitada del producto
        /// </summary>
        /// <param name="cantidadSolicitada"></param>
        /// <returns></returns>
        public bool SetearCantidadSolicitada(float cantidadSolicitada)
        {
            try 
            {
                this.cantidadSolicitada = cantidadSolicitada;
                return true;
            }
            catch (Exception)
            {
                throw;
            }           
        }

        /// <summary>
        /// El metodo setea el precio por la cantidad solicitada para este producto
        /// </summary>
        /// <param name="precioPorCantidad"></param>
        /// <returns></returns>
        public bool SetearPrecioPorCantidadSolicitada(float precioPorCantidad)
        {
            try
            {
                this.precioPorCantidad = precioPorCantidad;
                return true;
            }
            catch (Exception) 
            { 
                throw; 
            }               
        }

        private static int UltimoCodigoManual()
        {
            try
            {
                if (primeraVez)
                {
                    // Verificar si existe un archivo guardado con el ultimo codigo
                    if (File.Exists(archivoUltimoCodigo))
                    {
                        string contenido = File.ReadAllText(archivoUltimoCodigo);
                        if (int.TryParse(contenido, out int codigo))
                        {
                            ultimoCodigoManual = codigo;
                            primeraVez = false;
                        }
                        else
                        {
                            // El contenido del archivo no es un numero valido, se asigna el valor por defecto
                            ultimoCodigoManual = 100;
                        }
                    }
                    else
                    {
                        // No existe un archivo guardado, se asigna el valor por defecto
                        ultimoCodigoManual = 100;

                        // Crear el archivo y escribir el primer codigo manual
                        using (StreamWriter writer = File.CreateText(archivoUltimoCodigo))
                        {
                            writer.Write(ultimoCodigoManual.ToString());
                        }
                    }
                }
                ultimoCodigoManual++;
                // Guardar el ultimo código en el archivo
                File.WriteAllText(archivoUltimoCodigo, ultimoCodigoManual.ToString());

                return ultimoCodigoManual;
            }
            catch (Exception)
            {
                throw;
            }

        }

        public void SerializarJson(List<Producto> listaSerializar)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\productosJson.json"))
                {
                    string jsonString = JsonSerializer.Serialize(listaSerializar);
                    sw.WriteLine(jsonString);
                }
            }
            catch (IOException)
            { 
                throw; 
            }
            catch (Exception) 
            { 
                throw; 
            }
        }
        public string DeSerializarJson()
        {
            try
            {
                using (StreamReader streamReader = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\productosJson.json"))
                {
                    string jsonString = streamReader.ReadToEnd();

                    List<Producto> listaDeSerializar = JsonSerializer.Deserialize<List<Producto>>(jsonString) as List<Producto>;

                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine($"        ----------DESERIALIZAR_Json---------\n\n\n");

                    foreach (Producto item in listaDeSerializar)
                    {
                        sb.AppendLine($"        -----------------------------------");
                        sb.AppendLine($"        -----------{item.Nombre}-----------");
                        sb.AppendLine($"        TIPO: {item.TipoDeProducto.ToString()}");
                        sb.AppendLine($"        PRECIO x KG: $ {item.PrecioPorKilo}");
                        sb.AppendLine($"        STOCK: {item.CantidadDeKilos} Kg");
                        sb.AppendLine($"        CODIGO:---- {item.CodigoDeProducto}");
                        sb.AppendLine($"\n");
                    }

                    return sb.ToString();
                }
            }
            catch (Exception ex)
            {
                return $"Error al deserializar el JSON: {ex.Message}";
            }            
        }
        
       
        public void SerializarXml(List<Producto> listaSerializar)
        {
            try
            {
                string archivoXml = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "productos.xml");
                XmlSerializer serializer = new XmlSerializer(typeof(List<Producto>));

                using (StreamWriter sw = new StreamWriter(archivoXml))
                {
                    serializer.Serialize(sw, listaSerializar);
                }
            }
            catch (IOException) 
            { 
                throw; 
            }
            catch (Exception)
            { 
                throw; 
            }            
        }
        
        public string DeSerializarXml()
        {
            try
            {
                string archivoXml = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "productos.xml");

                XmlSerializer serializer = new XmlSerializer(typeof(List<Producto>));

                using (StreamReader sr = new StreamReader(archivoXml))
                {
                    List<Producto> listaDeserializar = serializer.Deserialize(sr) as List<Producto>;

                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine($"        ----------DESERIALIZAR_XML----------\n\n\n");

                    foreach (Producto item in listaDeserializar)
                    {
                        sb.AppendLine($"        -----------------------------------");
                        sb.AppendLine($"        -----------{item.Nombre}-----------");
                        sb.AppendLine($"        TIPO: {item.TipoDeProducto.ToString()}");
                        sb.AppendLine($"        PRECIO x KG: $ {item.PrecioPorKilo}");
                        sb.AppendLine($"        STOCK: {item.CantidadDeKilos} Kg");
                        sb.AppendLine($"        CODIGO:---- {item.CodigoDeProducto}");
                        sb.AppendLine($"\n");
                    }

                    return sb.ToString();
                }
            }
            catch (FileNotFoundException ex) 
            {             
                return $"Errorexcepciones de archivo no encontrado XML: {ex.Message}";
            }
            catch (Exception ex) 
            {
                return $"Error al deserializar el XML: {ex.Message}";                
            }           
        }
    }
}