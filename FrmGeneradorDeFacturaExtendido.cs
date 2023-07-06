using PPLabo2_2D;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualParcial1
{
    public class FrmGeneradorDeFacturaExtendido : FrmGeneradorDeFactura
    {
        public void GenerarYGuardarArchivoFactura(string carpetaDestino, Cliente cliente, Factura factura)
        {
            try
            {
                Factura facturaGenerada = factura;
                Cliente clienteAFacturar = cliente;

                string nombreArchivo = facturaGenerada.NumeroDeFactura.ToString() + "_" + clienteAFacturar.Nombre + ".txt";
                string rutaCarpeta = Path.Combine(carpetaDestino, "FacturasHistorial");

                // Comprobar si la carpeta "FacturasHistorial" existe, o crearla si no existe
                if (!Directory.Exists(rutaCarpeta))
                {
                    Directory.CreateDirectory(rutaCarpeta);
                }

                string rutaArchivo = Path.Combine(rutaCarpeta, nombreArchivo);
                if (rutaArchivo == null)
                {
                    throw new MisExcepciones("La ruta del archivo string es Null.");
                }

                string contenidoArchivo = $"Fecha: {facturaGenerada.FechaActual}\n" +
                                            $"Número de Factura: {facturaGenerada.NumeroDeFactura}\n" +
                                            $"Nombre de la Factura: {clienteAFacturar.Nombre}\n" +
                                            $"Total de la Factura: {facturaGenerada.TotalFactura}";

                File.WriteAllText(rutaArchivo, contenidoArchivo);
            }
            catch (MisExcepciones ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

    }
}
