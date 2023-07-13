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
using System.Media;

namespace VisualParcial1
{
    public partial class FrmGeneradorDeFactura : Form
    {
        Cliente clienteAFacturar;
        List<Producto> productosAFacturar;
        Factura facturaGenerada;
        MenuCliente menuCliente;
        MenuVendedor frmMenuVendedor;
        FrmCompraVenta frmCompraVenta;
        public FrmGeneradorDeFactura()
        {
            InitializeComponent();
        }
        public FrmGeneradorDeFactura(Cliente cliente, List<Producto> productos, MenuCliente menuCliente) : this()
        {
            this.clienteAFacturar = cliente;
            this.productosAFacturar = productos;
            this.menuCliente = menuCliente;
            btn_Atras.Text = "Salir";
        }
        public FrmGeneradorDeFactura(Cliente cliente, List<Producto> productos, MenuVendedor frmMenuVendedor, FrmCompraVenta frmCompraVenta) : this()
        {
            this.clienteAFacturar = cliente;
            this.productosAFacturar = productos;
            this.frmMenuVendedor = frmMenuVendedor;
            btn_Atras.Text = "Atras";
            this.frmCompraVenta = frmCompraVenta;
        }



        private void FrmGeneradorDeFactura_Load(object sender, EventArgs e)
        {
            facturaGenerada = clienteAFacturar.ObtenerUltimaFactura();

            lbl_NumeroFactura.Text = "Nº00000-00 " + facturaGenerada.NumeroDeFactura.ToString();
            lbl_Fecha.Text = "FECHA: " + facturaGenerada.FechaActual.ToShortDateString();
            lbl_NombreFc.Text = "Señor/es: " + clienteAFacturar.Nombre + " " + clienteAFacturar.Apellido;
            lbl_Cuit.Text = "CUIT: " + clienteAFacturar.Cuit.ToString();
            lbl_Subtotal.Text = "" + facturaGenerada.SubtotalFactura.ToString("N2");
            lbl_IvaTotal.Text = "" + facturaGenerada.IvaFactura.ToString("N2");
            lbl_RecargoTc.Text = "" + facturaGenerada.Recargo.ToString("N2");
            lbl_TotalFactura.Text = "" + facturaGenerada.TotalFactura.ToString("N2");

            dgv_ListaDeProductos.Columns.Add("ColumnaCantidades", "Cantidad");
            dgv_ListaDeProductos.Columns.Add("ColumnaNombre", "Nombre del Producto");
            dgv_ListaDeProductos.Columns.Add("ColumnaPrecioPorKg", "Precio por Kg.");
            dgv_ListaDeProductos.Columns.Add("ColumnaPrecioUnitario", "Importe");

            dgv_ListaDeProductos.Columns["ColumnaCantidades"].DataPropertyName = "CantidadSolicitada";
            dgv_ListaDeProductos.Columns["ColumnaNombre"].DataPropertyName = "Nombre";
            dgv_ListaDeProductos.Columns["ColumnaPrecioPorKg"].DataPropertyName = "PrecioPorKilo";
            dgv_ListaDeProductos.Columns["ColumnaPrecioUnitario"].DataPropertyName = "PrecioPorCantidad";


            foreach (Producto producto in productosAFacturar)
            {

                DataGridViewRow filas = new DataGridViewRow();

                // Agrego La Cantidad
                DataGridViewCell cantidadCell = new DataGridViewTextBoxCell();
                cantidadCell.Value = producto.CantidadSolicitada;
                filas.Cells.Add(cantidadCell);

                // Agrego El nombre
                DataGridViewCell nombreCell = new DataGridViewTextBoxCell();
                nombreCell.Value = producto.Nombre;
                filas.Cells.Add(nombreCell);

                // Agrego El Precio Unitario
                DataGridViewCell precioUnitarioCell = new DataGridViewTextBoxCell();
                precioUnitarioCell.Value = producto.PrecioPorKilo;
                filas.Cells.Add(precioUnitarioCell);

                // Agrego El importe Precio x PrecioUnitario
                DataGridViewCell importeparcialCell = new DataGridViewTextBoxCell();
                importeparcialCell.Value = producto.PrecioPorCantidad;
                filas.Cells.Add(importeparcialCell);

                dgv_ListaDeProductos.Rows.Add(filas);

            }


        }
        private void btn_Atras_Click(object sender, EventArgs e)
        {
            if (menuCliente != null)
            {
                SonidoVolverAtras();
                Application.Exit();
            }
            else if (frmMenuVendedor != null)
            {
                this.Close();
                frmCompraVenta.Close();
                frmMenuVendedor.Show();
                SonidoVolverAtras();
            }
            return;

        }
        private void SonidoVolverAtras()
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = @"C:\Users\Usuario\source\repos\Camejo.Esteban\VisualParcial1\bin\SoundEffectSuperMarioBrosDown.wav"; ; // Ruta del archivo de sonido
            player.Play();
        }

        private void btn_Atras_MouseEnter(object sender, EventArgs e)
        {
            btn_Atras.BackColor = Color.Red;
        }

        private void btn_Atras_MouseLeave(object sender, EventArgs e)
        {
            btn_Atras.BackColor = Color.White;
        }
    }
}
