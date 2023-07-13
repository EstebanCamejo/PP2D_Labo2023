using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPLabo2_2D
{
    public static class FacturaExtendida
    {
        /// <summary>
        /// Recibe el atributo del subtotal de la compra y calcula el iva sobre este monto
        /// </summary>
        /// <param name="SubtotalFactura"></param>
        /// <returns></returns>
        public static float CalcularIva(this Factura factura)
        {
            try
            {
                float iva = 21f / 100f;
                return factura.SubtotalFactura * iva;
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
        public static float RecargoTarjetaDeCredito(this Factura factura)
        {
            try
            {
                float recargo = 1f / 20f;
                return factura.TotalFactura * recargo;
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
