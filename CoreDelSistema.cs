using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PPLabo2_2D
{
    public static class CoreDelSistema
    {

        static List<Cliente> clientes;
        public static List<Usuario> usuarios;
        static List<Producto> productos;
        static List <Factura> facturas;
       
        
        static CoreDelSistema()
        {
            CoreDelSistema.clientes = new List<Cliente>();
            CoreDelSistema.usuarios = new List<Usuario> ();
            CoreDelSistema.productos = new List<Producto>();
            CoreDelSistema.facturas = new List<Factura>();
            

            CoreDelSistema.CargarClaseClientes();                       
            CoreDelSistema.CargarClaseProductos();
            CoreDelSistema.CargarClaseFacturas();
        }

        /// <summary>
        /// Harcodeo de los clientes al sistema
        /// </summary>
        private static void CargarClaseClientes()
        {
            CoreDelSistema.clientes.Add(new("Usuario1","Contrasenia1","Diego","Hem",10000,301111111, ETipoDePago.efectivo));
            CoreDelSistema.clientes.Add(new("Usuario2","Contrasenia2","Pablo","Mastracci",10000, 301111112,ETipoDePago.efectivo));
            CoreDelSistema.clientes.Add(new("Usuario3","Contrasenia3","Brais","Fernandez",10000, 301111113,ETipoDePago.efectivo));
            CoreDelSistema.clientes.Add(new("Usuario4","Contrasenia4","Lucas","Romero",10000,301111114,ETipoDePago.efectivo));
            CoreDelSistema.clientes.Add(new("Usuario5","Contrasenia5","Rafaela","Sanchez",10000, 301111115,ETipoDePago.efectivo));
            CoreDelSistema.clientes.Add(new("Usuario6","Contrasenia6","Samanta","Bianucci",10000, 301111116,ETipoDePago.efectivo));
            CoreDelSistema.clientes.Add(new("Usuario7","Contrasenia7","Angeles","Antelo",10000, 301111117,ETipoDePago.efectivo));
            CoreDelSistema.clientes.Add(new("Usuario8","Contrasenia8","Javier","Iriarte",10000, 301111118,ETipoDePago.efectivo));
            CoreDelSistema.clientes.Add(new("Usuario9","Contrasenia9","Martin","Losasso",10000, 301111119,ETipoDePago.efectivo));                        
        }

        /// <summary>
        /// Harcodeo de los productos al sistema
        /// </summary>

        private static void CargarClaseProductos() 
        {
            CoreDelSistema.productos.Add(new(EProdcuto.vacuno,2100,50, "Asado"));
            CoreDelSistema.productos.Add(new(EProdcuto.vacuno, 2400,50, "Bola de Lomo"));
            CoreDelSistema.productos.Add(new(EProdcuto.vacuno,1690,50, "Picada Premium"));
            CoreDelSistema.productos.Add(new(EProdcuto.vacuno,2300,50, "Bife Ancho"));

            CoreDelSistema.productos.Add(new(EProdcuto.aves, 790,50, "Pollo de Granja"));
            CoreDelSistema.productos.Add(new(EProdcuto.aves, 2800,50, "Suprema"));
            CoreDelSistema.productos.Add(new(EProdcuto.aves, 750,50, "Pata y Muslo"));
            CoreDelSistema.productos.Add(new(EProdcuto.aves, 2315,50, "Patitas de Pollo"));

            CoreDelSistema.productos.Add(new(EProdcuto.cerdo, 1700,50, "Costilla de Cerdo"));
            CoreDelSistema.productos.Add(new(EProdcuto.cerdo, 2500,50, "Solomillo de Cerdo"));
            CoreDelSistema.productos.Add(new(EProdcuto.cerdo,1350,50, "Pechito de Cerdo"));
            CoreDelSistema.productos.Add(new(EProdcuto.cerdo,2500,50, "Bondiola de Cerdo"));
            
            CoreDelSistema.productos.Add(new(EProdcuto.preparados, 2200,50, "Milanesas de Carne"));
            CoreDelSistema.productos.Add(new(EProdcuto.preparados, 1990,50, "Milanesas de Pechuga"));
            CoreDelSistema.productos.Add(new(EProdcuto.preparados, 1990,50, "Milanesas de Cerdo"));
            CoreDelSistema.productos.Add(new(EProdcuto.preparados, 1990,50, "Hamburguesas de Carne"));

            CoreDelSistema.productos.Add(new(EProdcuto.embutidos, 1975,50, "Chorizo"));
            CoreDelSistema.productos.Add(new(EProdcuto.embutidos, 1295,50, "Morcilla"));
            CoreDelSistema.productos.Add(new(EProdcuto.embutidos, 2675,50, "Salchicha Parrillera"));
            CoreDelSistema.productos.Add(new(EProdcuto.embutidos, 1075,50, "Chinchulin"));
        }


        /// <summary>
        /// Harcodeo de las facturas al sistema
        /// </summary>

        private static void CargarClaseFacturas()
        {
            CoreDelSistema.facturas.Add(new(CoreDelSistema.productos, clientes[1],1000,1000,210,1210,0,1));
            CoreDelSistema.facturas.Add(new(CoreDelSistema.productos, clientes[2],2000,2000,420,2420,0,2));
            CoreDelSistema.facturas.Add(new(CoreDelSistema.productos, clientes[3],3000,3000,630,3630,0,3));
            CoreDelSistema.facturas.Add(new(CoreDelSistema.productos, clientes[4],4000,4000,840,4840,0,4));
            CoreDelSistema.facturas.Add(new(CoreDelSistema.productos, clientes[5],5000,5000,1050,6050,0,5));          
        }


        public static List<Cliente> Clientes
        {
            get { return CoreDelSistema.clientes; }
            set { CoreDelSistema.clientes = value; }
        }
        public static List<Factura> Facturas
        {
            get { return CoreDelSistema.facturas; }
        }
        public static List<Producto> Productos
        {
            get { return CoreDelSistema.productos; }
            set { CoreDelSistema.productos = value; }
        }

        /// <summary>
        /// Recibe el objeto cliente y lo guarda en la lista del sistema
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns></returns>
        public static bool GuardarNuevoCliente(Cliente cliente)
        {
            if (cliente is not null)
            {
                CoreDelSistema.clientes.Add(cliente);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Recibe el objeto factura y lo guarda en la lista del sistema
        /// </summary>
        /// <param name="factura"></param>
        /// <returns></returns>
        public static bool GuardarNuevaFactura (Factura factura)
        {
            if (factura is not null)
            {
                CoreDelSistema.facturas.Add(factura);
                return true;
            }
            return false;
            
        }

        /// <summary>
        /// Recibe el objeto producto y lo guarda en la lista del sistema
        /// </summary>
        /// <param name="producto"></param>
        /// <returns></returns>
        public static bool GuardarNuevoProducto(Producto producto)
        {
            if (producto is not null)
            {
                CoreDelSistema.productos.Add(producto);
                return true;
            }
            return false;
        }


        public static bool ActualizarProducto(Producto producto)
        {
            if (producto is not null)
            {
                foreach (Producto p in Productos)
                {
                    if (p.CodigoDeProducto == producto.CodigoDeProducto)
                    {
                        p.TipoDeProducto = producto.TipoDeProducto;
                        p.Nombre = producto.Nombre;
                        p.PrecioPorKilo = producto.PrecioPorKilo;
                        p.CantidadDeKilos = producto.CantidadDeKilos;
                    }
                }              
                return true;
            }
            return false;
        }

        public static bool ActualizarListaDeProductos(List<Producto> listaActualizadaDeProductos)
        {            
            if (listaActualizadaDeProductos is not null)
            {
                CoreDelSistema.productos = listaActualizadaDeProductos;
                return true;
            }
            return false;
        }
    }

    
}
