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
        private string direccion;
        private static int idCliente;
        private static int ultimoIdCliente = 0;
        private ETipoDePago tipoDePago;
        private List<Factura> factura;
        

        // instanciar un cliente con ID y sin billetera
        public Cliente (string nombreUsuario, string contrasenia, string nombre) :
            base(nombreUsuario, contrasenia, nombre)
        {
            this.factura = new List<Factura> ();
        }
        public Cliente(string nombreUsuario, string contrasenia, string nombre,string apellido, float billetera,
            long cuit, string direccion, ETipoDePago tipoDePago): base (nombreUsuario, contrasenia, nombre)
        {
            this.Apellido = apellido;
            this.Billetera = billetera;
            this.Cuit = cuit;
            this.Direccion = direccion;
            this.tipoDePago = tipoDePago;
            ultimoIdCliente++;
            this.factura = new List<Factura>();

        }

        public string Apellido { get => apellido; set => apellido = value; }
        public float Billetera { get => billetera; set => billetera = value; }
        public long Cuit { get => cuit; set => cuit = value; }
        public string Direccion { get => direccion; set => direccion = value; }

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
        
        public bool ActualizarBilletera(float subtotalFactura, bool pagarConTarjeta, float ivaDelProductoAgregado)
        {
            bool retorno = false;

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

            return retorno;
            
            
        }
        public bool PagarFactura(Factura factura)
        {
            if (Billetera >= factura.TotalFactura)
            {
                Billetera -= factura.TotalFactura;
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return $" {Nombre} {Apellido} - Cuit: {Cuit}";
        }

        public Factura ObtenerUltimaFactura()
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
    }
}
