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
    public class Factura 
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

                this.IvaFactura = this.CalcularIva();
                this.TotalFactura = SubtotalFactura + IvaFactura;

                if (cliente.TipoDePago == ETipoDePago.tarjeta)
                {
                    this.Recargo = this.RecargoTarjetaDeCredito();                    
                    this.totalFactura += Recargo;
                }
            
                this.Nombre = cliente.Nombre;
                cliente.GuardarFactura(this);               
                return this;
            }
            catch (Exception)
            {
                throw;
            }
        }

      
    }

}
