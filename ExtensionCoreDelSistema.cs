using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPLabo2_2D
{
    public class ExtensionCoreDelSistema
    {
        public void ValidarListas(List<Usuario> usuarios, List<Producto> productos, List<Factura> facturas)
        {
            if (usuarios == null || usuarios.Count == 0)
            {
                Console.WriteLine("La lista de usuarios esta vacia o es nula.");
            }
            if (productos == null || productos.Count == 0)
            {
                Console.WriteLine("La lista de productos esta vacia o es nula.");
            }
            if (facturas == null || facturas.Count == 0)
            {
                Console.WriteLine("La lista de facturas esta vacia o es nula..");
            }
        }
    }
}
