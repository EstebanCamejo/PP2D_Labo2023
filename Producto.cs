namespace PPLabo2_2D
{
    using System.IO;
    using System.Text;
    using System.Text.Json;
    using System.Text.Json.Serialization;
    using System.Xml.Serialization;

    public class Producto 
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
        //public bool SetearCantidadSolicitada(float cantidadSolicitada)
        //{
        //    try 
        //    {
        //        this.cantidadSolicitada = cantidadSolicitada;
        //        return true;
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }           
        //}

        public void SetearCantidadSolicitada(float cantidadSolicitada)
        {
            try
            {
                this.cantidadSolicitada = cantidadSolicitada;
            }
            catch (Exception)
            {
                throw;
            }
        }




        ///// <summary>
        ///// El metodo setea el precio por la cantidad solicitada para este producto
        ///// </summary>
        ///// <param name="precioPorCantidad"></param>
        ///// <returns></returns>
        //public bool SetearPrecioPorCantidadSolicitada(float precioPorCantidad)
        //{
        //    try
        //    {
        //        this.precioPorCantidad = precioPorCantidad;
        //        return true;
        //    }
        //    catch (Exception) 
        //    { 
        //        throw; 
        //    }               
        //}

        public void SetearPrecioPorCantidadSolicitada(float precioPorCantidad)
        {
            try
            {
                this.precioPorCantidad = precioPorCantidad;
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

    }
}