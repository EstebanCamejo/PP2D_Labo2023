using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;



namespace PPLabo2_2D
{
    public class Factura : ISerializadora<Factura>, IDeserializadora
    {
        private List<Producto> listaDeProductosEnFactura;
        private Cliente cliente;
        private float totalPorProducto;
        private float subtotalFactura;
        private float ivaFactura;
        private float totalFactura;
        private int numeroDeFactura;
        private static int ultimoNumeroFactura;
        private float recargo;
        private DateTime fechaActual;
        private string nombre;


        public Factura()
        {
            this.fechaActual = DateTime.Now;
            ultimoNumeroFactura++;
        }

        public Factura(List<Producto> listaDeProductosEnFactura, Cliente cliente)
        {
            this.listaDeProductosEnFactura = listaDeProductosEnFactura;
            this.cliente = cliente;
            this.fechaActual = DateTime.Now;

        }
        public Factura(List<Producto> listaDeProductosEnFactura, Cliente cliente, float totalPorProducto, 
        float subtotalFactura, float ivaFactura, float totalFactura, float recargo) : this (listaDeProductosEnFactura, cliente)
        {
            this.listaDeProductosEnFactura = listaDeProductosEnFactura;
            this.cliente = cliente;
            this.totalPorProducto = totalPorProducto;
            this.subtotalFactura = subtotalFactura;
            this.ivaFactura = ivaFactura;
            this.totalFactura = totalFactura;
            this.recargo = recargo;
            ultimoNumeroFactura++;
            this.fechaActual = DateTime.Now;
            this.nombre = cliente.Nombre;
        }      

        public Factura(int numeroFactura, DateTime fecha, string? nombre, double total)
        {
            this.numeroDeFactura = numeroFactura;
            this.fechaActual = fecha;
            this.nombre = nombre;           
            this.totalFactura = (float)total;
        }

        public List<Producto> ListaDeProductosEnFactura { get => this.listaDeProductosEnFactura; }

        public Cliente Cliente 
        { 
            get => this.cliente; 
            set =>this.cliente = value;
        }
       
        public float TotalPorProducto 
        { 
            get => this.totalPorProducto;
            set => this.totalPorProducto = value;   
        }

        public float SubtotalFactura 
        { 
            get => this.subtotalFactura;
            set => this.subtotalFactura = value;
        }

        public float IvaFactura 
        {
            get => this.ivaFactura;
            set { this.ivaFactura = value; }
        }
        
        public float TotalFactura 
        { 
            get => this.totalFactura;
            set { this.totalFactura = value; }
        }

        public int NumeroDeFactura
        {
            get => this.numeroDeFactura;           
            set { this.numeroDeFactura = value; }
        }

        public float Recargo
        {
            get => this.recargo;
            set { this.recargo = value; }           
        }
        //public string Apellido
        //{
        //    get => this.Cliente.Apellido;
        //}
        public string Nombre
        {           
            get => this.nombre;
            set { this.nombre = value; }    
        }
        

        public DateTime FechaActual
        {
            get => this.fechaActual;
        }


        /// <summary>
        /// Recibe el atributo del subtotal de la compra y calcula el iva sobre este monto
        /// </summary>
        /// <param name="SubtotalFactura"></param>
        /// <returns></returns>
        public float CalcularIva(float SubtotalFactura)
        {
            try
            {
                float iva = 21f / 100f;
                return SubtotalFactura * iva;
            }
            catch (Exception) 
            {
                throw;
            }                      
        }

        /// <summary>
        /// Recibe el total de la factura con el iva sumado y suma la recarga por poago con tarjeta
        /// </summary>
        /// <param name="TotalFactura"></param>
        /// <returns></returns>
        public static float RecargoTarjetaDeCredito(float TotalFactura)
        {
            try
            {
                float recargo = 1f / 20f;
                return TotalFactura * recargo;
            }
            catch (Exception) 
            {
                throw;
            }            
        }

        /// <summary>
        /// Recibe el cliente que realizo la compra y el listado de productos y genera la factura de la compra
        /// </summary>
        /// <param name="clienteFacturar"></param>
        /// <param name="producto"></param>
        /// <returns></returns>
        public Factura GenerarFactura(Cliente clienteFacturar, List<Producto> producto)
        {
            try
            {
                listaDeProductosEnFactura = new List<Producto>();
                cliente = clienteFacturar;
                foreach (Producto p in producto)
                {                
                    if (p.CantidadSolicitada > 0)
                    {
                        this.ListaDeProductosEnFactura.Add(p);
                        this.SubtotalFactura += p.CantidadSolicitada * p.PrecioPorKilo;
                    }
                }
                this.IvaFactura = CalcularIva(SubtotalFactura);
                this.TotalFactura = SubtotalFactura + IvaFactura;

                if (cliente.TipoDePago == ETipoDePago.tarjeta)
                {
                    this.Recargo = RecargoTarjetaDeCredito(totalFactura);
                    this.totalFactura += Recargo;
                }
            
                this.Nombre = cliente.Nombre;
                cliente.GuardarFactura(this);
                //CoreDelSistema.GuardarNuevaFactura(this);
                return this;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Devuelve una cadena de strings con los datos necesarios para imprimar la factura en un listado
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {                  
            return $"{Cliente.Nombre} {Cliente.Apellido}";
        }

        public void SerializarJson(List<Factura> listaSerializar)
        {
            try
            {
                JsonSerializerOptions options = new JsonSerializerOptions
                {
                    ReferenceHandler = ReferenceHandler.IgnoreCycles,
                    WriteIndented = true // Opcional: Para que el JSON sea mas legible
                };

                using (StreamWriter sw = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\facturasJson.json"))
                {
                    string jsonString = JsonSerializer.Serialize(listaSerializar, options);
                    sw.WriteLine(jsonString);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Se produjo una excepcion al serializar el JSON: ");
                throw;                
            }          
        }
        public string DeSerializarJson()
        {            
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\facturasJson.json";

            try
            {
                using (StreamReader streamReader = new StreamReader(filePath))
                {
                    string jsonString = streamReader.ReadToEnd();

                    if (!string.IsNullOrEmpty(jsonString))
                    {
                        List<Factura> listaDeSerializar = JsonSerializer.Deserialize<List<Factura>>(jsonString);

                        if (listaDeSerializar != null)
                        {
                            StringBuilder sb = new StringBuilder();
                            sb.AppendLine("----------DESERIALIZAR_Json---------\n\n\n");

                            foreach (Factura item in listaDeSerializar)
                            {
                                sb.AppendLine("-----------------------------------");
                                sb.AppendLine($"NUMERO: {item.NumeroDeFactura}");
                                sb.AppendLine($"CLIENTE: {item.Nombre}");
                                sb.AppendLine($"TOTAL: $ {item.TotalFactura}");
                                sb.AppendLine("\n");
                            }

                            return sb.ToString();
                        }
                        else
                        {
                            return "La deserialización del JSON no pudo convertirse en una lista válida de facturas.";
                        }
                    }
                    else
                    {
                        return "El archivo JSON está vacío.";
                    }
                }
            }
            catch (Exception ex)
            {
                return $"Error al deserializar el JSON: {ex.Message}";
            }
        }


        public void SerializarXml(List<Factura> listaSerializar)
        {
            try
            {
                string archivoXml = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "facturas.xml");

                XmlSerializer serializer = new XmlSerializer(typeof(List<Factura>));

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
                string archivoXml = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "facturas.xml");
                XmlSerializer serializer = new XmlSerializer(typeof(List<Factura>));

                using (StreamReader sr = new StreamReader(archivoXml))
                {
                    List<Factura> listaDeserializar = serializer.Deserialize(sr) as List<Factura>;

                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine($"        ----------DESERIALIZAR_XML----------\n\n\n");

                    foreach (Factura item in listaDeserializar)
                    {
                        sb.AppendLine($"        -----------------------------------");
                        sb.AppendLine($"        NUMERO: {item.NumeroDeFactura}");
                        sb.AppendLine($"        CLIENTE: {item.Nombre}");
                        sb.AppendLine($"        TOTAL: $ {item.TotalFactura}");

                        sb.AppendLine($"\n");
                    }

                    return sb.ToString();
                }
            }
            catch (Exception ex)             
            {
                return $"Error al deserializar el XML: {ex.Message}"; 
            }           
        }
    }

}
