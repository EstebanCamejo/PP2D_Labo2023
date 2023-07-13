using PPLabo2_2D;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualParcial1
{
    public partial class listaProductosForm : Form
    {
        public listaProductosForm()
        {
            InitializeComponent();
        }
        public void MostrarFacturasSerializados()
        {
            List<Factura> listaDeFacturas = CoreDelSistema.DeserializarFacturasJson();

            StringBuilder sb = ConvertirListadeFacturaEnString(listaDeFacturas);

            string listaDeFacturasString = sb.ToString();
            textBox1.Text = listaDeFacturasString;
        }

        private static StringBuilder ConvertirListadeFacturaEnString(List<Factura> listaDeFacturas)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("----------DESERIALIZAR_Json---------\n\n\n");

            foreach (Factura item in listaDeFacturas)
            {
                sb.AppendLine("-----------------------------------");
                sb.AppendLine($"NUMERO: {item.NumeroDeFactura}");
                sb.AppendLine($"CLIENTE: {item.Nombre}");
                sb.AppendLine($"TOTAL: $ {item.TotalFactura}");
                sb.AppendLine("\n");
            }

            sb.ToString();
            return sb;
        }


        public void MostrarProductosSerializadosJson()
        {
            List<Producto> listaDeProductos = CoreDelSistema.DeserializarProductosJson();

            StringBuilder sb = ConvertirListadeProductosJsonEnString(listaDeProductos);

            string listaDeFacturasString = sb.ToString();
            textBox1.Text = listaDeFacturasString;
        }
        private static StringBuilder ConvertirListadeProductosJsonEnString(List<Producto> listaDeSerializar)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"        ----------DESERIALIZAR_JSON---------\n\n\n");

            foreach (Producto item in listaDeSerializar)
            {
                sb.AppendLine($"        -----------------------------------");
                sb.AppendLine($"        -----------{item.Nombre}-----------");
                sb.AppendLine($"        TIPO: {item.TipoDeProducto.ToString()}");
                sb.AppendLine($"        PRECIO x KG: $ {item.PrecioPorKilo}");
                sb.AppendLine($"        STOCK: {item.CantidadDeKilos} Kg");
                sb.AppendLine($"        CODIGO:---- {item.CodigoDeProducto}");
                sb.AppendLine($"\n");
            }
            sb.ToString();
            return sb;
        }

        public void MostrarProductosSerializadosXml()
        {
            List<Producto> listaDeProductos = CoreDelSistema.DeserializarProductosXml();

            StringBuilder sb = ConvertirListadeProductosXmlEnString(listaDeProductos);

            string listaDeFacturasString = sb.ToString();
            textBox1.Text = listaDeFacturasString;
        }
        private static StringBuilder ConvertirListadeProductosXmlEnString(List<Producto> listaDeSerializar)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"        ----------DESERIALIZAR_XML---------\n\n\n");

            foreach (Producto item in listaDeSerializar)
            {
                sb.AppendLine($"        -----------------------------------");
                sb.AppendLine($"        -----------{item.Nombre}-----------");
                sb.AppendLine($"        TIPO: {item.TipoDeProducto.ToString()}");
                sb.AppendLine($"        PRECIO x KG: $ {item.PrecioPorKilo}");
                sb.AppendLine($"        STOCK: {item.CantidadDeKilos} Kg");
                sb.AppendLine($"        CODIGO:---- {item.CodigoDeProducto}");
                sb.AppendLine($"\n");
            }
            sb.ToString();
            return sb;
        }
    }
}
