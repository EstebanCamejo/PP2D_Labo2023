using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPLabo2_2D
{
    public class Vendedor : Usuario
    {
        
        private List<Cliente> listaCliente;
        private Heladera heladera;
     
        public Vendedor (string nombreUsuario, string contrasenia, string nombre) :
            base(nombreUsuario, contrasenia, nombre)
        {
            this.heladera = new Heladera(CoreDelSistema.Productos);           
        }

      /// <summary>
      /// El vendedor recibe un cliente y una lista de productos solicitada y realiza la transaccion venta
      /// comprueba la disponibilidad solicitada de cada producto en la heladera
      /// Genera una nueva factura y le cobra al cliente
      /// </summary>
      /// <param name="cliente"></param>
      /// <param name="productos"></param>
      /// <returns></returns>
        public bool VenderProductos(Cliente cliente, List<Producto> productos)
        {
            try
            {
                Factura factura = new Factura();
                factura.GenerarFactura(cliente, productos);
                cliente.PagarFactura(factura);

                return true;
            }
            catch (Exception)
            {
                return false;
            }           
        }
        /// <summary>
        /// Retorna el estado actual de la heladera
        /// </summary>
        public Heladera Heladera
        {
            get => this.heladera;          
        }

     

    }
}
