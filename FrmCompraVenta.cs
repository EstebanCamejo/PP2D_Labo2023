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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VisualParcial1
{
    public partial class FrmCompraVenta : Form
    {
        List<Producto> listaProductosComprados;
        Cliente cliente;
        Heladera heladera;
        Producto auxProducto;
        int indiceProductoDgv = 0;
        float saldoInicialCliente;
        float totalAPagar = 0;
        Vendedor vendedor;
        bool esCLienteOVendedor;
        MenuCliente frmMenuCliente;
        FrmVentas frmVentas;
        public FrmCompraVenta(Cliente clienteAFacturar, bool esVendedor, FrmVentas frmVentas)
        {
            InitializeComponent();
            this.cliente = clienteAFacturar;
            this.heladera = new Heladera();
            this.saldoInicialCliente = cliente.Billetera;
            this.listaProductosComprados = new List<Producto>();
            this.vendedor = new Vendedor("UsuarioHardcodeado", "ContraseniaHardcodeada", "Vendedor1");
            this.esCLienteOVendedor = esVendedor;

            this.frmVentas = frmVentas;
        }
        public FrmCompraVenta(Cliente clienteAFacturar, bool esCliente, MenuCliente frmMenuCliente)
        {
            InitializeComponent();
            this.cliente = clienteAFacturar;
            this.heladera = new Heladera();
            this.saldoInicialCliente = cliente.Billetera;
            this.listaProductosComprados = new List<Producto>();
            this.vendedor = new Vendedor("UsuarioHardcodeado", "ContraseniaHardcodeada", "Vendedor1");
            this.esCLienteOVendedor = esCliente;
            this.frmMenuCliente = frmMenuCliente;

        }

        private void FrmCompraVenta_Load(object sender, EventArgs e)
        {
            dtgv_Productos.ReadOnly = true;
            //  heladera.ActualizarProductosDeLaHeladera(CoreDelSistema.Productos);
            heladera = vendedor.Heladera;
            ActualizarListBoxDeProductos();
            lbl_NombreCliente.Text = "Nombre: " + cliente.Nombre + cliente.Apellido;
            lbl_Cuit.Text = "CUIT: " + cliente.Cuit.ToString();
            lbl_SaldoDisponible.Text = "Saldo Disponible: " + cliente.Billetera.ToString();
            lbl_TipoDePago.Text = "Tipo de Pago => " + cliente.TipoDePago.ToString();

        }

        private void ActualizarListBoxDeProductos()
        {
            cbb_SleccionProducto.DataSource = null;
            cbb_SleccionProducto.DisplayMember = nameof(Producto.Nombre);
            cbb_SleccionProducto.DataSource = heladera.ListaProducto;
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            int indiceProductoEnLaLista = ObtenerIndiceDelProductoEnHeladera();
            Producto productoAgregado = ObtenerProductoDelDgv(indiceProductoEnLaLista);
            float cantidadSolicitada;
            float precioPorCantidad;
            bool pagaConTarjeta = false;
            // si toco el boton atras y se arrepiente de comprar recargar la billetera



            if (float.TryParse(txb_CantKg.Text, out cantidadSolicitada) && cantidadSolicitada > 0)
            {
                precioPorCantidad = ObtenerPrecioPorCantidad(cantidadSolicitada, productoAgregado.PrecioPorKilo);

                indiceProductoDgv = dtgv_Productos.Rows.Add();

                float ivaDelProductoAgregado = DevolverIvaDelProducto(precioPorCantidad);


                //Comprobamos disponibilidad sobre la cantidad del producto

                if (heladera.DisponibilidadProducto(productoAgregado))
                {
                    //****CHEQUEAR SI ES CON TC o EFVO***


                    if (cliente.TipoDePago == ETipoDePago.tarjeta)
                    {
                        pagaConTarjeta = true;
                    }



                    // Actualizar billetera
                    if (cliente.ActualizarBilletera(precioPorCantidad, pagaConTarjeta, ivaDelProductoAgregado))
                    {
                        // Actualizar Heladera
                        heladera.ActualizarCantidad(productoAgregado);

                        // Actualizamos el FRM
                        ActualizarSaldoDisponibleEnELFrm(cliente.Billetera);
                        ActualizarTotalAPagarEnELForm(saldoInicialCliente - cliente.Billetera);

                        // Actualizamos el DataGrid
                        dtgv_Productos.Rows[indiceProductoDgv].Cells[0].Value = productoAgregado.Nombre;
                        dtgv_Productos.Rows[indiceProductoDgv].Cells[1].Value = productoAgregado.PrecioPorKilo.ToString();
                        dtgv_Productos.Rows[indiceProductoDgv].Cells[2].Value = txb_CantKg.Text;
                        dtgv_Productos.Rows[indiceProductoDgv].Cells[3].Value = precioPorCantidad.ToString();

                        // Agregamos Producto a la lista de compras                        
                        productoAgregado.SetearCantidadSolicitada(cantidadSolicitada);
                        productoAgregado.SetearPrecioPorCantidadSolicitada(precioPorCantidad);

                        AgregarProductosAlChanguito(productoAgregado);

                    }
                    else
                    {
                        MessageBox.Show("Su saldo disponible no es suficiente para efectuar la compra.");
                    }

                }
                else
                {
                    MessageBox.Show("La demanda solicitada de este producto no esta disponible.");
                }
                txb_CantKg.Text = "";
            }
            else
            {
                MessageBox.Show("La Cantidad Ingresada es Invalida");
            }



        }
        private int ObtenerIndiceDelProductoEnHeladera()
        {
            int indice = heladera.ListaProducto.IndexOf(cbb_SleccionProducto.SelectedItem as Producto);
            return indice;
        }

        private Producto ObtenerProductoDelDgv(int indiceProductoEnLaLista)
        {
            if (indiceProductoEnLaLista >= 0)
            {
                return auxProducto = heladera.ListaProducto[indiceProductoEnLaLista];
            }
            return null;
        }

        private float ObtenerPrecioPorCantidad(float cantidadSolicitada, float precioPorKg)
        {
            float precioPorCantidad = cantidadSolicitada * precioPorKg;

            return precioPorCantidad;
        }

        private void ActualizarSaldoDisponibleEnELFrm(float billetera)
        {
            lbl_SaldoDisponible.Text = "Saldo Disponible: $" + (billetera).ToString();
                                       
        }

        private void ActualizarTotalAPagarEnELForm(float precioPorCantidad)
        {
            totalAPagar = precioPorCantidad;

            lbl_TotalApagar.Text = "Total a Pagar:    $" + totalAPagar.ToString();
        }

        private void AgregarProductosAlChanguito(Producto productoAgregado)
        {
            listaProductosComprados.Add(productoAgregado);
        }

        private void btn_Comprar_Click(object sender, EventArgs e)
        {
            this.cliente.Billetera = saldoInicialCliente;

            vendedor.VenderProductos(cliente, listaProductosComprados);
            FrmGeneradorDeFactura generarFactura = new FrmGeneradorDeFactura(cliente, listaProductosComprados, this);
            generarFactura.Show();
            this.Hide();

            //Hardcodeo un vendedor y llamo al metodo VenderProductos
            //este llamara al metodo que instaciara la fc en el sistema y se guarda tanto para
            //el cliente como para el sistema
            // luego instancio el form facturas llamo a la factura generada e imprimo sus datos

        }
        private float DevolverIvaDelProducto(float precioPorCantidad)
        {
            float ivaDelProducto = precioPorCantidad * 21 / 100;

            return ivaDelProducto;
        }
        private void cbb_SleccionProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            Producto productoSeleccionado = (Producto)cbb_SleccionProducto.SelectedItem;
            lbl_TotalProducto.Text = "Precio Por Kg: $        " + productoSeleccionado.PrecioPorKilo.ToString();
            lbl_IvaProductoAgregado.Text = "IVA ProdSelec: $        " + (DevolverIvaDelProducto(productoSeleccionado.PrecioPorKilo)).ToString();

        }

        private void btn_VolverAtras_Click(object sender, EventArgs e)
        {
            if (esCLienteOVendedor == true)
            {
                frmMenuCliente.Show();
                this.Hide();
            }
            else if (esCLienteOVendedor == false)
            {
                frmVentas.Show();
                this.Hide();

            }
        }
    }
}
