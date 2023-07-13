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

        static SerializadorJson<List<Factura>> SerializadorJsonFactura = new SerializadorJson <List<Factura>> ("facturas.json");
        static SerializadorJson<List<Producto>> SerializadorJsonProducto = new SerializadorJson <List<Producto>> ("productos.json");

        static SerializadorXml<List<Factura>> SerializadorXmlFactura = new SerializadorXml<List<Factura>>("facturas.xml");
        static SerializadorXml<List<Producto>> SerializadorXmlProducto = new SerializadorXml<List<Producto>>("productos.xml");

        static CoreDelSistema()
        {
            CoreDelSistema.clientes = new List<Cliente>();
            CoreDelSistema.usuarios = new List<Usuario> ();
            CoreDelSistema.productos = new List<Producto>();
            CoreDelSistema.facturas = new List<Factura>();

            CoreDelSistema.CargarUsuarios();
            CoreDelSistema.CargarClaseProductos();
            CoreDelSistema.CargarClaseFacturas();           
        }

    

        /// <summary>
        /// Harcodeo de los clientes al sistema
        /// </summary>
        private static void CargarClaseClientes()
        {                        
            foreach (Usuario usuario in CoreDelSistema.usuarios)
            {
                if (usuario.TipoDeUsuario == 1)
                {
                    Cliente cliente = new Cliente(usuario.NombreUsuario, usuario.Contrasenia, usuario.Nombre);
                    clientes.Add(cliente);
                }                
            }
        }
        private static void CargarUsuarios()
        {            
            CoreDelSistema.usuarios = UsuariosDB.Leer();
            CargarClaseClientes();
        }

        /// <summary>
        /// Harcodeo de los productos al sistema
        /// </summary>

        private static void CargarClaseProductos() 
        {            
            productos = ProductoBD.Leer();
        }


        /// <summary>
        /// Harcodeo de las facturas al sistema
        /// </summary>

        private static void CargarClaseFacturas()
        {                        
            CoreDelSistema.facturas = FacturasBD.Leer();
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
            try
            {
                if (cliente is not null)
                {
                    CoreDelSistema.clientes.Add(cliente);
                    return true;
                }
                return false;
            }           
            catch (Exception) 
            {
                return false;
            }                       
        }

        /// <summary>
        /// Recibe el objeto factura y lo guarda en la lista del sistema
        /// </summary>
        /// <param name="factura"></param>
        /// <returns></returns>
        public static bool GuardarNuevaFactura (Factura factura)
        {
            try
            {
                if (factura is not null)
                {
                    CoreDelSistema.facturas.Add(factura);
                    FacturasBD.GuardarFacturas(factura);
                    //Serializar facturas todo el CORE e implementar extension del metodo
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }                      
        }

        /// <summary>
        /// Recibe el objeto producto y lo guarda en la lista del sistema
        /// </summary>
        /// <param name="producto"></param>
        /// <returns></returns>
        public static bool GuardarNuevoProducto(Producto producto)
        {
            try
            {
                if (producto is not null)
                {
                    CoreDelSistema.productos.Add(producto);
                    return true;
                }
                return false;
            }
            catch (Exception) 
            { 
                return false; 
            }          
        }


        public static bool ActualizarProducto(Producto producto)
        {
            try
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
            catch (Exception) 
            { 
                return false; 
            }                       
        }

        public static bool ActualizarListaDeProductos(List<Producto> listaActualizadaDeProductos)
        {
            try
            {
                if (listaActualizadaDeProductos is not null)
                {
                    CoreDelSistema.productos = listaActualizadaDeProductos;
                    return true;
                }
                return false;
            }
            catch (Exception) 
            {
                return false;
            }
        }

        public static bool SerializarFacturasJson (List<Factura> listaFacturas)
        {
            try
            {
                if (!SerializadorJsonFactura.Serializar(listaFacturas))
                {                    
                    throw new SerializarException();                    
                }                 
            }
            catch (SerializarException)
            {
                return false; 
            }
            return true;                
        }
        public static List<Factura> DeserializarFacturasJson()
        {
            List<Factura> listFacturas = new List<Factura>();
            try
            {
                return listFacturas = SerializadorJsonFactura.Deserializar();
            }
            catch (Exception)
            {
                return null;
            }
        }


        public static bool SerializarFacturasXml(List<Factura> listaFacturas)
        {
            try
            {
                if (!SerializadorXmlFactura.Serializar(listaFacturas))
                {
                    throw new SerializarException();
                }
            }
            catch (SerializarException)
            {
                return false;
            }
            return true;
        }

        public static List<Factura> DeserializarFacturasXml()
        {
            List<Factura> listFacturas = new List<Factura>();
            try
            {
                return listFacturas = SerializadorXmlFactura.Deserializar();
            }
            catch (Exception)
            {
                return null;
            }
        }
        
        
        
        public static bool SerializarProductosJson (List<Producto> listaProductos)
        {
            bool retorno = true;
            try
            {
                if (!SerializadorJsonProducto.Serializar(listaProductos))
                {
                    retorno = false;
                    throw new SerializarException();
                }
            }
            catch (SerializarException ex)
            {               
                throw ex;
            }
            return retorno;
        }

        public static List<Producto> DeserializarProductosJson()
        {
            List<Producto> listProductos = new List<Producto>();
            try
            {
                return listProductos = SerializadorJsonProducto.Deserializar();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static bool SerializarProductosXml(List<Producto> listaProductos)
        {
            bool retorno = true;
            try
            {
                if (!SerializadorXmlProducto.Serializar(listaProductos))
                {
                    retorno = false;
                    throw new SerializarException();
                }
            }
            catch (SerializarException ex)
            {
                throw ex;
            }
            return retorno;
        }

        public static List<Producto> DeserializarProductosXml()
        {
            List<Producto> listProductos = new List<Producto>();
            try
            {
                return listProductos = SerializadorXmlProducto.Deserializar();
            }
            catch (Exception)
            {
                return null;
            }
        }

    }

}
