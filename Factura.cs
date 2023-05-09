using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PPLabo2_2D
{
    public class Factura
    {
        // metodo generar factura que tome como parametros - Cliente + List Productos 

        // Productos -> List de Productos 


        // Form ->
        // Instanciar el CLiente
        // Instanciar Cada Producto
        // guardar cantidades
        // llamar al metodo Heladera.ActualizarCantidad (Producto,cantidades) y si devuelve true 
        // guardarlo en un List Producto(Producto)
        // enviarlo al metodo Factura.GenerarFactura recibe (Cliente, Listado Producto <Producto>)
        // Retorna una factura
        // Boton Mostrar Factura -> debe mnostrar la factura generada en el Form y a su vez llamar
        //                          -> Guardar la Factura generada en un listado CORE
        // 

        private List<Producto>producto;
        private Cliente cliente;
        private float totalPorProducto;
        private float subtotalFactura;
        private float ivaFactura;
        private float totalFactura;
        private int numeroDeFactura;
        private static int ultimoNumeroFactura;
        private float recargo;
        private DateTime fechaActual;

        public Factura()
        {
            this.fechaActual = DateTime.Now;
        }

        public Factura(List<Producto> producto, Cliente cliente)
        {
            this.producto = producto;
            this.cliente = cliente;
            this.fechaActual = DateTime.Now;

        }
        public Factura(List<Producto> producto, Cliente cliente, float totalPorProducto, 
        float subtotalFactura, float ivaFactura, float totalFactura, float recargo) : this (producto,cliente)
        {
            this.producto = producto;
            this.cliente = cliente;
            this.totalPorProducto = totalPorProducto;
            this.subtotalFactura = subtotalFactura;
            this.ivaFactura = ivaFactura;
            this.totalFactura = totalFactura;
            this.recargo = recargo;
            ultimoNumeroFactura++;
            this.fechaActual = DateTime.Now;
        }
        public Factura (List<Producto> producto, Cliente cliente, float totalPorProducto,
        float subtotalFactura, float ivaFactura, float totalFactura, float recargo, int numeroDeFactura) :
            this(producto,cliente, totalPorProducto, subtotalFactura, ivaFactura, totalFactura, recargo)
        {
            this.producto = producto;
            this.cliente = cliente;
            this.totalPorProducto = totalPorProducto;
            this.subtotalFactura = subtotalFactura;
            this.ivaFactura = ivaFactura;
            this.totalFactura = totalFactura;
            this.recargo = recargo;
            this.numeroDeFactura = numeroDeFactura;
            this.fechaActual = DateTime.Now;
        }  



        public List<Producto> Producto { get => this.producto; }

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

        public DateTime FechaActual
        {
            get => this.fechaActual;
        }


        public static float CalcularIva(float SubtotalFactura)
        {
            float iva = 21f/100f;
            
            return  SubtotalFactura * iva ;
        }

        public static float RecargoTarjetaDeCredito(float TotalFactura)
        {
            float recargo = 1f/20f;

            return TotalFactura * recargo;
        }

        public Factura GenerarFactura(Cliente clienteFacturar, List<Producto> producto)
        {           
            this.producto = new List<Producto>();

            foreach (Producto p in producto)
            {                
                if (p.CantidadSolicitada > 0)
                {
                    this.Producto.Add(p);
                    this.SubtotalFactura += p.CantidadSolicitada * p.PrecioPorKilo;
                }
            }
            this.IvaFactura = CalcularIva(SubtotalFactura);
            this.TotalFactura = SubtotalFactura + IvaFactura;

            if (clienteFacturar.TipoDePago == ETipoDePago.tarjeta)
            {
                this.Recargo = RecargoTarjetaDeCredito(totalFactura);
                this.totalFactura += Recargo;
            }
            this.NumeroDeFactura = ultimoNumeroFactura;
            clienteFacturar.GuardarFactura(this);
            CoreDelSistema.GuardarNuevaFactura(this);
            return this;
        }

        public override string ToString()
        {                  
            return $"FC nº - {NumeroDeFactura} - Cliente: {Cliente.Nombre} {Cliente.Apellido} - Cuit: {Cliente.Cuit} - TOTAL ${TotalFactura}";
        }


    }

}
