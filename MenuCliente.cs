using PPLabo2_2D;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Media;

namespace VisualParcial1
{
    public partial class MenuCliente : Form
    {
        List<Producto> listaProductosComprados;
        Heladera heladera;
        Producto auxProducto;
        Cliente nuevoCliente;
        Vendedor vendedor;
        float saldoInicialCliente;
        float totalAPagar = 0;
        bool puedePagar = false;
        private bool montoIngresado = false;

        public MenuCliente()
        {
            InitializeComponent();
            this.heladera = new Heladera();
            this.listaProductosComprados = new List<Producto>();
            this.vendedor = new Vendedor("UsuarioHardcodeado", "ContraseniaHardcodeada", "Vendedor1");
            UpdateUI();
        }

        private void MenuCliente_Load(object sender, EventArgs e)
        {
            cbb_MedioDePago.Items.Add("efectivo");
            cbb_MedioDePago.Items.Add("tarjeta");
            heladera.HeladeraCargada();
            CargarHeladeraAlDataGrid(heladera);
        }

        private void btn_RegistroDeDatos_Click(object sender, EventArgs e)
        {
            // obtener datos del cliente
            bool datosCompletos = ObtenerDatosDelCliente(out string nombreCliente, out string apellidoCliente,
            out long cuitCliente, out float montoAGastarCliente, out ETipoDePago tipoPagoEnum);

            if (!datosCompletos)
            {
                SonidoError();
                MessageBox.Show("Por favor, ingresar correctamente los datos del cliente.");
                return;
            }else if(montoIngresado)
            {
                txb_MontoAGastar.Enabled = false; // Bloquear la edición del TextBox
            }

            // instanciar un nuevo cliente para la compra
            string nombreUsuario = "usuarioHardcodeado";
            string passUsuario = "passHardcodeado";

            nuevoCliente = new Cliente(nombreUsuario, passUsuario, nombreCliente, apellidoCliente,
            montoAGastarCliente, cuitCliente, tipoPagoEnum);

            saldoInicialCliente = nuevoCliente.Billetera;
            CoreDelSistema.GuardarNuevoCliente(nuevoCliente);

            UpdateUI();
        }

        public bool ObtenerDatosDelCliente(out string nombreCliente, out string apellidoCliente,
            out long cuitCliente, out float montoAGastarCliente, out ETipoDePago tipoPagoEnum)
        {

            // Llamar a los métodos para obtener los datos del cliente
            bool nombreValido = ObtenerNombreDelCliente(out nombreCliente, out apellidoCliente);
            bool cuitValido = ObtenerCuitDelCliente(out cuitCliente);
            bool montoAGastarValido = ObtenerMaximoAGastar(out montoAGastarCliente);
            bool modoDePagoValido = ObtenerModoDePago(out tipoPagoEnum);
            // Verificar si todos los métodos devuelven true
            if (nombreValido && cuitValido && montoAGastarValido && modoDePagoValido)
            {
                // Todos los datos son válidos
                SonidoDatosOk();
                return true;
            }

            // Al menos uno de los métodos devolvió false
            return false;
        }

        public bool ObtenerNombreDelCliente(out string nombreCliente, out string apellidoCliente)
        {
            nombreCliente = txb_Nombre.Text;
            apellidoCliente = txb_Apellido.Text;

            bool retorno = true;

            if (!Regex.IsMatch(nombreCliente, @"^[a-zA-Z]+$") || nombreCliente == null)
            {
                SonidoError();
                MessageBox.Show("El nombre ingresado es inválido. Debe contener solo letras.");
                txb_Nombre.Text = "";
                retorno = false;
            }

            if (!Regex.IsMatch(apellidoCliente, @"^[a-zA-Z]+$") || apellidoCliente == null)
            {
                SonidoError();
                MessageBox.Show("El apellido ingresado es inválido. Debe contener solo letras.");
                txb_Apellido.Text = "";
                retorno = false;
            }
            return retorno;
        }
        public bool ObtenerCuitDelCliente(out long cuitCliente)
        {
            string cuitTexto = txb_Cuit.Text;
            bool esValido = true;

            foreach (char c in cuitTexto)
            {
                if (!char.IsDigit(c))
                {
                    esValido = false;
                    break;
                }
            }

            if (!esValido || cuitTexto == null)
            {
                SonidoError();
                MessageBox.Show("El número de CUIT ingresado es inválido. Debe contener solo números.");
                esValido = false;
                txb_Cuit.Text = "";
            }

            long.TryParse(cuitTexto, out cuitCliente);

            return esValido;
        }
        public bool ObtenerMaximoAGastar(out float montoAGastarCliente)
        {
            bool retorno = true;
            if (!float.TryParse(txb_MontoAGastar.Text, out montoAGastarCliente) || montoAGastarCliente <= 0)
            {
                SonidoError();
                MessageBox.Show("El monto a gastar ingresado es inválido. Debe contener solo números.");
                retorno = false;
                txb_MontoAGastar.Text = "";
            }
            else
            {
                montoIngresado = true; // Se ingresó correctamente el monto
            }
            return retorno;
        }
        public bool ObtenerModoDePago(out ETipoDePago tipoPagoEnum)
        {

            if (Enum.TryParse(cbb_MedioDePago.Text, out tipoPagoEnum))
            {
                if (Enum.IsDefined(typeof(ETipoDePago), tipoPagoEnum))
                {
                    return true;
                }
            }

            MessageBox.Show("El método de pago seleccionado es inválido.");
            SonidoError();
            tipoPagoEnum = default(ETipoDePago);
            return false;
        }
        public void CargarHeladeraAlDataGrid(Heladera heladera)
        {
            dgv_Heladera.Rows.Clear();
            dgv_Heladera.AllowUserToAddRows = false;

            foreach (Producto producto in heladera.ListaProducto)
            {
                int rowIndex = dgv_Heladera.Rows.Add();

                dgv_Heladera.Rows[rowIndex].Cells["TipoProducto"].Value = producto.TipoDeProducto;
                dgv_Heladera.Rows[rowIndex].Cells["TipoProducto"].ReadOnly = true;

                dgv_Heladera.Rows[rowIndex].Cells["NombreProducto"].Value = producto.Nombre;
                dgv_Heladera.Rows[rowIndex].Cells["NombreProducto"].ReadOnly = true;

                dgv_Heladera.Rows[rowIndex].Cells["PrecioPorKg"].Value = producto.PrecioPorKilo;
                dgv_Heladera.Rows[rowIndex].Cells["PrecioPorKg"].ReadOnly = true;

                dgv_Heladera.Rows[rowIndex].Cells["CantidadSolicitada"].ReadOnly = true;
            }
            dgv_Heladera.ClearSelection();
            dgv_Heladera.CurrentCell = null;
        }

        private void dgv_Heladera_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (nuevoCliente == null)
            {
                return;
            }

            // Obtener el índice de la columna de la cantidad solicitada y el nombre del producto
            int columnIndexCantidadSolicitada = dgv_Heladera.Columns["CantidadSolicitada"].Index;

            int columnIndexNombreProducto = dgv_Heladera.Columns["NombreProducto"].Index;

            int idProducto = dgv_Heladera.Rows[e.RowIndex].Index;

            Producto productoAgregado = ObtenerProductoDelDgv(idProducto);

            // Verificar si se editó la columna de la cantidad solicitada
            if (e.ColumnIndex == columnIndexCantidadSolicitada)
            {
                // Obtener la cantidad solicitada ingresada por el usuario
                //string cantidadSolicitadaString = dgv_Heladera.Rows[e.RowIndex].Cells[columnIndexCantidadSolicitada].Value.ToString();

                object cantidadSolicitadaValue = dgv_Heladera.Rows[e.RowIndex].Cells[columnIndexCantidadSolicitada].Value;
                string cantidadSolicitadaString = cantidadSolicitadaValue != null ? cantidadSolicitadaValue.ToString() : string.Empty;

                if (string.IsNullOrEmpty(cantidadSolicitadaString))
                {
                    // El valor ingresado es nulo o vacío
                    SonidoError();
                    MessageBox.Show("Ingrese un valor numerico valido para la cantidad solicitada.");
                    dgv_Heladera.Rows[e.RowIndex].Cells[columnIndexCantidadSolicitada].Value = ""; // Valor vacío
                    return;
                }
                else if (!float.TryParse(cantidadSolicitadaString, out float cantidadSolicitada))
                {
                    // El valor ingresado no es un número válido
                    SonidoError();
                    MessageBox.Show("Ingrese un valor numérico válido para la cantidad solicitada.");
                    dgv_Heladera.Rows[e.RowIndex].Cells[columnIndexCantidadSolicitada].Value = ""; // Valor vacío

                    return;
                }
                else if (cantidadSolicitada <= 0)
                {
                    // La cantidad solicitada ingresada no es un número válido
                    SonidoError();
                    dgv_Heladera.Rows[e.RowIndex].Cells[columnIndexCantidadSolicitada].Value = ""; // Valor vacío                  
                    if (cantidadSolicitada == 0)
                    {
                        if (VerificarProductoEnLista(productoAgregado))
                        {
                            ReintegrarBilletera(productoAgregado);
                            QuitarProductoDeLaLista(productoAgregado);
                            MessageBox.Show("El producto ha sido retirado del changuito.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("La cantidad solicitada debe ser mayor a 0.");
                    }

                }
                else
                {
                    // La conversión a float se realizó correctamente
                    if (cantidadSolicitada >= 1)
                    {
                        productoAgregado.SetearCantidadSolicitada(cantidadSolicitada);
                        //Comprobamos disponibilidad sobre la cantidad del producto

                        if (heladera.DisponibilidadProducto(productoAgregado))
                        {
                            //****CHEQUEAR SI ES CON TC o EFVO***
                            bool pagaConTarjeta = false;

                            if (nuevoCliente.TipoDePago == ETipoDePago.tarjeta)
                            {
                                pagaConTarjeta = true;
                            }
                            float precioPorCantidad = ObtenerPrecioPorCantidad(cantidadSolicitada, productoAgregado.PrecioPorKilo);
                            float ivaDelProductoAgregado = DevolverIvaDelProducto(precioPorCantidad);
                            // Actualizar billetera
                            if (nuevoCliente.ActualizarBilletera(precioPorCantidad, pagaConTarjeta, ivaDelProductoAgregado))
                            {
                                // Actualizar Heladera
                                heladera.ActualizarCantidad(productoAgregado);

                                //dgv_Heladera.Rows[e.RowIndex].Cells["CantidadKgDisponibles"].Value = heladera.DevolverProducto(productoAgregado).CantidadDeKilos;
                                // Actualizamos el FRM
                                ActualizarSaldoDisponibleEnELFrm(nuevoCliente.Billetera);
                                ActualizarTotalAPagarEnELForm(saldoInicialCliente - nuevoCliente.Billetera);

                                productoAgregado.SetearPrecioPorCantidadSolicitada(precioPorCantidad);

                                // Agregar el nuevo producto a una lista junto con su cantidad.
                                // ...
                                AgregarProductosAlChanguito(productoAgregado);

                                SonidoAgregarAlChangitoOK();

                                // Obtener el nombre del producto asociado a la fila
                                string nombreProducto = dgv_Heladera.Rows[e.RowIndex].Cells[columnIndexNombreProducto].Value.ToString();

                                // mostrar un mensaje con la cantidad solicitada y el nombre del producto
                                MessageBox.Show($"Cantidad solicitada: {cantidadSolicitada} Kg. \nNombre del producto: {nombreProducto}");

                                puedePagar = true;
                            }
                            else
                            {
                                SonidoError();
                                MessageBox.Show("Su saldo disponible no es suficiente para efectuar la compra.");
                                dgv_Heladera.Rows[e.RowIndex].Cells[columnIndexCantidadSolicitada].Value = ""; // Valor vacío                                
                            }
                        }
                        else
                        {
                            SonidoError();
                            MessageBox.Show("La demanda solicitada de este producto no esta disponible.");
                            dgv_Heladera.Rows[e.RowIndex].Cells[columnIndexCantidadSolicitada].Value = ""; // Valor vacío                            
                        }
                    }
                }
            }
        }

        private int ObtenerIdProducto(string? tipoProducto)
        {
            throw new NotImplementedException();
        }

        private Producto ObtenerProductoDelDgv(int indiceProductoEnLaLista)
        {
            if (indiceProductoEnLaLista >= 0 && indiceProductoEnLaLista <= 19)
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
        private float DevolverIvaDelProducto(float precioPorCantidad)
        {
            float ivaDelProducto = precioPorCantidad * 21 / 100;

            return ivaDelProducto;
        }
        private void ActualizarSaldoDisponibleEnELFrm(float billetera)
        {
            lbl_SaldoDisponible.Text = "" + (billetera).ToString("N2");
        }
        private void ActualizarTotalAPagarEnELForm(float precioPorCantidad)
        {
            totalAPagar = precioPorCantidad;

            lbl_TotalApagar.Text = "" + totalAPagar.ToString("N2");
        }
        private void AgregarProductosAlChanguito(Producto productoAgregado)
        {
            listaProductosComprados.Add(productoAgregado);
        }
        private void QuitarProductoDeLaLista(Producto productoAgregado)
        {
            listaProductosComprados.Remove(productoAgregado);
        }

        private void ComprobarSiAlgunProductoSeRetiroDeLaLista(List<Producto> ListaAFacturar)
        {
            foreach (Producto p in ListaAFacturar)
            {
                if (p.CantidadSolicitada == 0)
                {
                    listaProductosComprados.Remove(p);
                }
            }
        }

        private void btn_Comprar_Click(object sender, EventArgs e)
        {
            if (nuevoCliente == null)
            {
                SonidoError();
                MessageBox.Show("Por favor, ingrese los datos solicitados");
                return;
            }
            if (puedePagar)
            {
                SonidoDatosYCompraOK();
                nuevoCliente.Billetera = saldoInicialCliente;

                ComprobarSiAlgunProductoSeRetiroDeLaLista(listaProductosComprados);

                // Vender Producto
                vendedor.VenderProductos(nuevoCliente, listaProductosComprados);
                FrmGeneradorDeFactura generarFactura = new FrmGeneradorDeFactura(nuevoCliente, listaProductosComprados, this);
                generarFactura.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Para continuar con su compra \npor favor seleccione algun producto.");
            }

        }

        private void UpdateUI()
        {
            bool bIsReadyForEdition = nuevoCliente != null;

            if (!bIsReadyForEdition)
            {
                dgv_Heladera.DefaultCellStyle.BackColor = SystemColors.Control;
                dgv_Heladera.DefaultCellStyle.ForeColor = SystemColors.GrayText;

                dgv_Heladera.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.Control;
                dgv_Heladera.ColumnHeadersDefaultCellStyle.ForeColor = SystemColors.GrayText;

                dgv_Heladera.EnableHeadersVisualStyles = false;

                dgv_Heladera.CurrentCell = null;

                dgv_Heladera.ReadOnly = false;
            }
            else
            {
                dgv_Heladera.DefaultCellStyle.BackColor = SystemColors.Window;
                dgv_Heladera.DefaultCellStyle.ForeColor = SystemColors.ControlText;

                dgv_Heladera.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.Window;
                dgv_Heladera.ColumnHeadersDefaultCellStyle.ForeColor = SystemColors.ControlText;

                dgv_Heladera.EnableHeadersVisualStyles = true;

                dgv_Heladera.ReadOnly = false;
            }

            for (int i = 0; i < dgv_Heladera.Rows.Count; i++)
            {
                dgv_Heladera.Rows[i].Cells["CantidadSolicitada"].ReadOnly = !bIsReadyForEdition;
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
        private void SonidoDatosOk()
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = @"C:\Users\Usuario\source\repos\Camejo.Esteban\VisualParcial1\bin\SoundEffectSuperMarioBrosDown.wav"; ; // Ruta del archivo de sonido
            player.Play();
        }

        private void dgv_Heladera_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            int columnIndexCantidadSolicitada = dgv_Heladera.Columns["CantidadSolicitada"].Index;

            if (e.ColumnIndex == columnIndexCantidadSolicitada) // Reemplaza columnIndexCantidadSolicitada con el índice de la columna "CantidadSolicitada" en tu DataGridView
            {
                if (e.FormattedValue.ToString() == string.Empty) // Validar si el valor ingresado está vacío
                {
                    dgv_Heladera.Rows[e.RowIndex].ErrorText = string.Empty;
                    return;
                }
            }
        }

        private bool VerificarProductoEnLista(Producto productoAgregado)
        {
            foreach (Producto p in listaProductosComprados)
            {
                if (p.Nombre == productoAgregado.Nombre)
                {
                    return true;
                }
            }
            return false;
        }

        private void ReintegrarBilletera(Producto productoAgregado)
        {
            foreach (Producto p in listaProductosComprados)
            {
                if (p.Nombre == productoAgregado.Nombre)
                {
                    bool pagaConTarjeta = false;

                    if (nuevoCliente.TipoDePago == ETipoDePago.tarjeta)
                    {
                        pagaConTarjeta = true;
                    }
                    float precioPorCantidad = ObtenerPrecioPorCantidad(p.CantidadSolicitada, productoAgregado.PrecioPorKilo);
                    float ivaDelProductoAgregado = DevolverIvaDelProducto(precioPorCantidad);
                    bool esDevolucion = true;

                    if (nuevoCliente.ActualizarBilletera(precioPorCantidad, pagaConTarjeta, ivaDelProductoAgregado, esDevolucion))
                    {
                        ActualizarSaldoDisponibleEnELFrm(nuevoCliente.Billetera);
                        ActualizarTotalAPagarEnELForm(saldoInicialCliente - nuevoCliente.Billetera);
                    }
                }
            }
        }

        private void btn_RegistroDeDatos_MouseEnter(object sender, EventArgs e)
        {
            btn_RegistroDeDatos.BackColor = Color.Red;
        }

        private void btn_RegistroDeDatos_MouseLeave(object sender, EventArgs e)
        {
            btn_RegistroDeDatos.BackColor = Color.White;
        }

        private void btn_Comprar_MouseEnter(object sender, EventArgs e)
        {
            btn_Comprar.BackColor = Color.Red;
        }

        private void btn_Comprar_MouseLeave(object sender, EventArgs e)
        {
            btn_Comprar.BackColor = Color.White;
        }

        private void dgv_Heladera_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            if (e.Column.Index == 0)
            {
                e.Column.Resizable = DataGridViewTriState.False;
            }
        }
    }
}
