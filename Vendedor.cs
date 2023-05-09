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

        //Puede vender productos seleccionando a un cliente de la lista de clientes.
        //Forms tiene que tener un listado Cientes  al que poder acceder instanciar una nueva lista de productos
        // y llamar al metodo "Vender Productos"
        public bool VenderProductos(Cliente cliente, List<Producto> productos)
        {                                  
            foreach(Producto p in productos)
            {
                if (!this.heladera.DisponibilidadProducto(p))
                {                   
                    return false;
                }

            }
            Factura factura = new Factura();

            factura.GenerarFactura(cliente, productos);
            cliente.PagarFactura(factura);

            return true;   
        }

        public Heladera Heladera
        {
            get => this.heladera;          
        }

     

    }
}
