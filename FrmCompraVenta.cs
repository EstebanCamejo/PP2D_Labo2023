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
using System.Media;


namespace VisualParcial1
{
    // Utilizo el delegado para representar mi evento
    public delegate void ReponerStockEventHandler();

    public partial class FrmCompraVenta : Form
    {
        List<Producto> listaProductosComprados;

        Heladera heladera;
        Producto auxProducto;
        int indiceProductoDgv = 0;
        float totalAPagar;
        Vendedor vendedor;
        List<Cliente> ClienteSeleccionado;
        bool puedePagar = false;
        Cliente cliente;
        MenuVendedor menuVendedor;


        //Creacion del Evento
        public event ReponerStockEventHandler ReponerStock;
        public FrmCompraVenta(MenuVendedor frmMenuVendedor)
        {
            InitializeComponent();
            // this.cliente = clienteAFacturar;
            this.heladera = new Heladera();
            this.listaProductosComprados = new List<Producto>();
            this.vendedor = new Vendedor("UsuarioHardcodeado", "ContraseniaHardcodeada", "Vendedor1");
            this.menuVendedor = frmMenuVendedor;
            this.cliente = null;

            //suscribir metodo al evento
            ReponerStock += MensajeDeAlertaReponerStock;
        }



        /// <summary>
        /// Cargo el formulario con los datos necesarios, actualizo la heladera para disponer de los productos
        /// y actualizo las etiquetas con los datos del cliente que me llega por instanciacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmCompraVenta_Load(object sender, EventArgs e)
        {
            ClienteSeleccionado = CoreDelSistema.Clientes;
            cbb_SeleccionarCliente.Items.AddRange(ClienteSeleccionado.ToArray());
            dtgv_Productos.ReadOnly = true;
            heladera = vendedor.Heladera;
            ActualizarListBoxDeProductos();

        }

        /// <summary>
        /// Actualizo los productos en el list box obteniendo el listado de productos desde la heladera
        /// </summary>
        private void ActualizarListBoxDeProductos()
        {
            cbb_SleccionProducto.DataSource = null;
            cbb_SleccionProducto.DisplayMember = nameof(Producto.Nombre);
            cbb_SleccionProducto.DataSource = heladera.ListaProducto;
        }



        /// <summary>
        /// Obtengo el indice del proiducto en la lista, con este obtengo el producto seleccionado por el cliente
        /// verifico si los campos ingresados son correctos los parseo a mi conveniencia y obtengo los detalles 
        /// del producto seleccionado para la compra, verifico la disponibilidad en la heladera, chequeo que metodo de pago 
        /// va a utilizar el cliente, compruebo que tenga saldo suficiente para agregar el producto a la lista, si es asi 
        /// actualizo la heladera, el monto disponieble a gastar para el cliente. Actualizo el formulario y los datagrid 
        /// con la informacion de la transaccion, actualizo la oinformacion para este producto en la compra y lo agrego a la lista.
        /// En caso que alguno de los pasos sea invalido el usuario es informado.
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


        private void btn_Agregar_Click(object sender, EventArgs e)
        {

            try
            {
                if (cliente == null)
                {
                    SonidoError();
                    MessageBox.Show("Antes de continuar es obligatorio \n seleccionar un cliente");
                    return;
                }


                int indiceProductoEnLaLista = ObtenerIndiceDelProductoEnHeladera();
                Producto productoAgregado = ObtenerProductoDelDgv(indiceProductoEnLaLista);
                float cantidadSolicitada;
                float precioPorCantidad;
                bool pagaConTarjeta = false;


                // si toco el boton atras y se arrepiente de comprar recargar la billetera

                if (float.TryParse(txb_CantKg.Text, out cantidadSolicitada) && cantidadSolicitada > 0)
                {
                    try
                    {
                        precioPorCantidad = ObtenerPrecioPorCantidad(cantidadSolicitada, productoAgregado.PrecioPorKilo);

                        if (cliente.Billetera >= (precioPorCantidad + DevolverIvaDelProducto(precioPorCantidad) + totalAPagar))
                        {
                            ActualizarTotalAPagarEnELForm(precioPorCantidad + DevolverIvaDelProducto(precioPorCantidad));
                            //Comprobamos disponibilidad sobre la cantidad del producto
                            productoAgregado.SetearCantidadSolicitada(cantidadSolicitada);

                            if (heladera.DisponibilidadProducto(productoAgregado))
                            {
                                //****CHEQUEAR SI ES CON TC o EFVO***

                                if (cliente.TipoDePago == ETipoDePago.tarjeta)
                                {
                                    pagaConTarjeta = true;
                                }

                                // Actualizar Heladera
                                heladera = heladera.ActualizarProductoEnLalista(productoAgregado, heladera.ListaProducto);

                                // Actualizamos el DataGrid
                                indiceProductoDgv = dtgv_Productos.Rows.Add();
                                dtgv_Productos.Rows[indiceProductoDgv].Cells[0].Value = productoAgregado.Nombre;
                                dtgv_Productos.Rows[indiceProductoDgv].Cells[1].Value = productoAgregado.CantidadDeKilos.ToString();
                                dtgv_Productos.Rows[indiceProductoDgv].Cells[2].Value = productoAgregado.PrecioPorKilo.ToString();
                                dtgv_Productos.Rows[indiceProductoDgv].Cells[3].Value = txb_CantKg.Text;
                                dtgv_Productos.Rows[indiceProductoDgv].Cells[4].Value = precioPorCantidad.ToString();

                                // Agregamos Producto a la lista de compras                        

                                productoAgregado.SetearPrecioPorCantidadSolicitada(precioPorCantidad);

                                AgregarProductosAlChanguito(productoAgregado);
                                puedePagar = true;
                                SonidoAgregarAlChangitoOK();
                            }
                            else
                            {
                                SonidoError();
                                MessageBox.Show("La demanda solicitada de este producto no esta disponible.");

                                //InvocarEvento Sin Stock
                                ReponerStock.Invoke();
                                ReponerStockEnHeladera(productoAgregado);
                            }
                            txb_CantKg.Text = "";
                        }
                        else
                        {
                            SonidoError();
                            MessageBox.Show("El saldo del cliente es insuficiente para realizar la venta");
                            txb_CantKg.Text = "";
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Se produjo un error al intentar agregar el producto. " + ex.Message);
                    }
                }
                else
                {
                    SonidoError();
                    MessageBox.Show("La Cantidad Ingresada es Invalida");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error al agregar el producto. " + ex.Message);
            }
        }




        private int ObtenerIndiceDelProductoEnHeladera()
        {
            try
            {
                int indice = heladera.ListaProducto.IndexOf(cbb_SleccionProducto.SelectedItem as Producto);
                return indice;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error al obtener el índice del producto en la heladera. " + ex.Message);
                return -1; // Valor de índice inválido para indicar un error
            }
        }

        private Producto ObtenerProductoDelDgv(int indiceProductoEnLaLista)
        {
            try
            {
                if (indiceProductoEnLaLista >= 0)
                {
                    return auxProducto = heladera.ListaProducto[indiceProductoEnLaLista];
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error al obtener el producto del DataGridView. " + ex.Message);
                return null;
            }
        }

        private float ObtenerPrecioPorCantidad(float cantidadSolicitada, float precioPorKg)
        {
            try
            {
                float precioPorCantidad = cantidadSolicitada * precioPorKg;
                return precioPorCantidad;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error al obtener el precio por cantidad. " + ex.Message);
                return 0; // Valor de precio invalido para indicar un error
            }
        }

        private void ActualizarTotalAPagarEnELForm(float precioPorCantidad)
        {
            try
            {
                if (cliente.Billetera >= totalAPagar)
                {
                    totalAPagar += precioPorCantidad;
                    lbl_TotalApagar.Text = "Total a Pagar:    $" + totalAPagar.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error al actualizar el total a pagar. " + ex.Message);
            }
        }

        private void AgregarProductosAlChanguito(Producto productoAgregado)
        {
            try
            {
                listaProductosComprados.Add(productoAgregado);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error al agregar el producto al changuito. " + ex.Message);
            }
        }

        private void btn_Comprar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente? clienteVenta = ObtenerClienteDelListbox();

                if (clienteVenta != null && puedePagar)
                {
                    vendedor.VenderProductos(clienteVenta, listaProductosComprados);
                    FrmGeneradorDeFactura generarFactura = new FrmGeneradorDeFactura(clienteVenta, listaProductosComprados, menuVendedor, this);


                    ProductoBD.Modificar(heladera.ListaProducto);

                    //Actualizar Heladera del Core del sistema
                    CoreDelSistema.ActualizarListaDeProductos(heladera.ListaProducto);

                    generarFactura.Show();
                    SonidoDatosYCompraOK();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Para realizar una compra es necesario: \n- Cargar los datos de facturacion.\n- Cargar productos al changuito.\n\n Muchas Gracias! ");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error al realizar la compra. " + ex.Message);
            }
        }
        private float DevolverIvaDelProducto(float precioPorCantidad)
        {
            try
            {
                float ivaDelProducto = precioPorCantidad * 21 / 100;
                return ivaDelProducto;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error al calcular el IVA del producto. " + ex.Message);
                return 0;
            }
        }
        private void cbb_SleccionProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Producto productoSeleccionado = (Producto)cbb_SleccionProducto.SelectedItem;
                lbl_TotalProducto.Text = "Precio Por Kg: $        " + productoSeleccionado.PrecioPorKilo.ToString();
                lbl_IvaProductoAgregado.Text = "IVA ProdSelec: $        " + (DevolverIvaDelProducto(productoSeleccionado.PrecioPorKilo)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error al seleccionar el producto. " + ex.Message);
            }
        }

        private void btn_VolverAtras_Click_1(object sender, EventArgs e)
        {
            try
            {
                menuVendedor.Show();
                this.Close();
                SonidoVolverAtras();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error al volver atras. " + ex.Message);
            }
        }

        private Cliente? ObtenerClienteDelListbox()
        {
            try
            {
                if (cbb_SeleccionarCliente.SelectedIndex == -1)
                {
                    SonidoError();
                    MessageBox.Show("Antes de continuar es obligatorio seleccionar un cliente");
                    return null;
                }

                int indiceCliente = cbb_SeleccionarCliente.SelectedIndex;
                if (indiceCliente >= 0)
                {
                    return cliente = ClienteSeleccionado[indiceCliente];
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error al obtener el cliente seleccionado. " + ex.Message);
                return null;
            }
        }

        private void cbb_SeleccionarCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ObtenerClienteDelListbox();
                lbl_NombreCliente.Text = "Nombre: " + cliente.Nombre + " " + cliente.Apellido;
                lbl_Cuit.Text = "CUIT: " + cliente.Cuit.ToString();
                lbl_TipoDePago.Text = "Tipo de Pago => " + cliente.TipoDePago.ToString();
                lbl_TopeMaximo.Text = "Tope Maximo: $" + cliente.Billetera.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error al seleccionar el cliente. " + ex.Message);
            }
        }

        private void SonidoError()
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = @"C:\Users\Usuario\source\repos\Camejo.Esteban\VisualParcial1\bin\SoundEffectERROR.wav"; ; // Ruta del archivo de sonido
            player.Play();
        }

        private void SonidoAgregarAlChangitoOK()
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = @"C:\Users\Usuario\source\repos\Camejo.Esteban\VisualParcial1\bin\SoundEffectMarioCoinOK.wav"; ; // Ruta del archivo de sonido
            player.Play();
        }

        private void SonidoDatosYCompraOK()
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = @"C:\Users\Usuario\source\repos\Camejo.Esteban\VisualParcial1\bin\SoundEffectSuperMarioBrosUP.wav"; ; // Ruta del archivo de sonido
            player.Play();
        }
        private void SonidoVolverAtras()
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = @"C:\Users\Usuario\source\repos\Camejo.Esteban\VisualParcial1\bin\SoundEffectSuperMarioBrosDown.wav"; ; // Ruta del archivo de sonido
            player.Play();
        }

        private void MensajeDeAlertaReponerStock()
        {
            MessageBox.Show("Hay faltante de productos en la heladera. \nPor favor, Reponer Stock.");
        }
        private void ReponerStockEnHeladera(Producto productoRecargarStock)
        {
            AbmHeladera abmHeladera = new AbmHeladera();
            abmHeladera.RecargarProductoEnFormularioVendedor(productoRecargarStock);
        }

        private void btn_Agregar_MouseEnter(object sender, EventArgs e)
        {
            btn_Agregar.BackColor = Color.Red;
        }

        private void btn_Agregar_MouseLeave(object sender, EventArgs e)
        {
            btn_Agregar.BackColor = Color.White;
        }

        private void btn_VolverAtras_MouseEnter(object sender, EventArgs e)
        {
            btn_VolverAtras.BackColor = Color.Red;
        }

        private void btn_VolverAtras_MouseLeave(object sender, EventArgs e)
        {
            btn_VolverAtras.BackColor = Color.White;
        }

        private void btn_Comprar_MouseEnter(object sender, EventArgs e)
        {
            btn_Comprar.BackColor = Color.Red;
        }

        private void btn_Comprar_MouseLeave(object sender, EventArgs e)
        {
            btn_Comprar.BackColor = Color.White;
        }
    }
}
