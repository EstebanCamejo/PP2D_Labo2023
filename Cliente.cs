using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPLabo2_2D
{
    public class Cliente : Usuario
    {
        // nombre -> lo hereda
        private string apellido;
        private float billetera;
        private long cuit;        
        private static int idCliente;
        private static int ultimoIdCliente = 0;
        private ETipoDePago tipoDePago;
        private List<Factura> factura;


        // instanciar un cliente con ID y sin billetera
        public Cliente() : base("", "", "")
        {

        }

        public Cliente (string nombreUsuario, string contrasenia, string nombre) :
            base(nombreUsuario, contrasenia, nombre)
        {
            this.factura = new List<Factura> ();
            ultimoIdCliente++;
            CompletarDatosDelCliente();
        }
        public Cliente(string nombreUsuario, string contrasenia, string nombre,string apellido, float billetera,
            long cuit, ETipoDePago tipoDePago): base (nombreUsuario, contrasenia, nombre)
        {
            this.Apellido = apellido;
            this.Billetera = billetera;
            this.Cuit = cuit;
            this.tipoDePago = tipoDePago;
            ultimoIdCliente++;
            this.factura = new List<Factura>();
        }
        public string Apellido { get => apellido; set => apellido = value; }
        public float Billetera { get => billetera; set => billetera = value; }
        public long Cuit { get => cuit; set => cuit = value; }       

        public List<Factura> Factura { get => this.factura; }

        public int IdCliente
        {
            get => idCliente = ultimoIdCliente; 
        }
        public ETipoDePago TipoDePago { get => tipoDePago; set => tipoDePago = value; }       

        public void GuardarFactura (Factura factura)
        {
            this.Factura.Add(factura);
        }                
        

        /// <summary>
        /// 
        /// </summary>
        /// <param name="subtotalFactura"></param>
        /// Es el precio de la suma de todos los productos comprados
        /// <param name="pagarConTarjeta"></param>
        /// Es la variable que valida la forma de pago del cliente
        /// <param name="ivaDelProductoAgregado"></param>
        /// Es la variable que acumula el iva de todos los productos comprados
        /// <returns></returns>

        public bool ActualizarBilletera(float subtotalFactura, bool pagarConTarjeta, float ivaDelProductoAgregado)
        {
            bool retorno;

            try
            {
                if (pagarConTarjeta)
                {
                    subtotalFactura += ivaDelProductoAgregado;
                    subtotalFactura += (subtotalFactura * 1 / 20);
                    if (Billetera >= subtotalFactura)
                    {
                        Billetera -= subtotalFactura;
                        retorno = true;
                    }
                    else
                    {
                        retorno = false;                        
                    }
                }
                else
                {
                    subtotalFactura += ivaDelProductoAgregado;
                    if (Billetera >= subtotalFactura)
                    {
                        Billetera -= subtotalFactura;
                        retorno = true;
                    }
                    else
                    {
                        retorno = false;                                             
                    }
                }
            }            
            catch (Exception) 
            {                
                throw;
            }
            
            return retorno;                        
        }
        public bool ActualizarBilletera(float subtotalFactura, bool pagarConTarjeta, float ivaDelProductoAgregado, bool esDevolucion)
        {
            bool retorno = false;
            try
            {
                if (esDevolucion)
                {
                    if (pagarConTarjeta)
                    {
                        subtotalFactura += ivaDelProductoAgregado;
                        subtotalFactura += (subtotalFactura * 1 / 20);
                        Billetera += subtotalFactura;
                        retorno = true;
                    }
                    else
                    {
                        subtotalFactura += ivaDelProductoAgregado;
                        Billetera += subtotalFactura;
                        retorno = true;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return retorno;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="factura"></param>
        /// Es la factura emitida que el cliente debe pagar
        /// <returns></returns>
        public bool PagarFactura(Factura factura)
        {
            try
            {
                if (Billetera >= factura.TotalFactura)
                {
                    Billetera -= factura.TotalFactura;
                    return true;
                }
                return false;
            }
            catch { return false; }
           
        }


        /// <summary>
        /// El metodo Obtener factura busca la ultima factura en el indice del listado de facturas del cliente
        /// </summary>
        /// <returns></returns>
        public Factura ObtenerUltimaFactura()
        {
            try 
            {
                if (this.factura.Count == 0)
                {
                    return null; // Si la lista de facturas está vacía, devolver null.
                }
                else
                {
                    return this.factura[this.factura.Count - 1]; // Devuelve el último elemento de la lista de facturas.
                }
            }
            catch (Exception)
            {
                throw;
            }
            
        }
        public override string ToString()
        {
            return $"{Nombre} {Apellido}";
        }

        private void CompletarDatosDelCliente()
        {
            //this.Apellido = GenerarNombreAleatorio();
            this.Billetera = GenerarValorAleatorio(10000, 50000);
            this.Cuit = GenerarCuitAleatorio();
            this.tipoDePago = (ETipoDePago)GenerarValorAleatorio(0, 1);
        }


        //private string GenerarNombreAleatorio()
        //{
        //    Random random = new Random();
        //    const string letras = "abcdefghijklmnopqrstuvwxyz";
        //    int longitud = random.Next(5, 10);
        //    StringBuilder nombreAleatorio = new StringBuilder();

        //    for (int i = 0; i < longitud; i++)
        //    {
        //        nombreAleatorio.Append(letras[random.Next(letras.Length)]);
        //    }

        //    return nombreAleatorio.ToString();
        //}

        // Generar valor aleatorio dentro de un rango para la billetera
        private float GenerarValorAleatorio(float minValue, float maxValue)
        {
            try
            {
                Random random = new Random();
                double randomValue = random.NextDouble() * (maxValue - minValue) + minValue;
                float billeteraAleatoria = (float)Math.Round(randomValue, 2);
                return billeteraAleatoria;
            }
            catch (Exception)
            {
                throw;
            }
           
        }

        // Generar CUIT aleatorio de 11 dígitos
        private long GenerarCuitAleatorio()
        {
            try
            {
                Random random = new Random();
                const int longitudCuit = 11;
                StringBuilder cuitAleatorio = new StringBuilder();

                for (int i = 0; i < longitudCuit; i++)
                {
                    cuitAleatorio.Append(random.Next(10));
                }

                return long.Parse(cuitAleatorio.ToString());
            }
            catch (Exception)
            {
                throw;
            }           
        }

    }
}
