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
using System.Threading;
using Timer = System.Threading.Timer;

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
        bool datosCargados = false;
        private Cliente clienteLogueado;
        private bool showImagen1;
        private bool showImagen2;
        private bool showImagen3;
        public MenuCliente()
        {
            InitializeComponent();
            this.heladera = new Heladera();
            this.listaProductosComprados = new List<Producto>();
            this.vendedor = new Vendedor("UsuarioHardcodeado", "ContraseniaHardcodeada", "Vendedor1");
            UpdateUI();

            showImagen1 = false;
            showImagen2 = false;
            showImagen3 = false;
        }

        public MenuCliente(Cliente clienteLogueado) : this()
        {
            this.clienteLogueado = clienteLogueado;
        }

        private void MenuCliente_Load(object sender, EventArgs e)
        {           
            heladera.HeladeraCargada();
            CargarHeladeraAlDataGrid(heladera);
            CargarClienteAlDataGrid();
            BloquearTextBoxes();

            IniciarCambioPublicidad();
        }

        // Permitir ejeciucion asincronica en un hilo secundario
        private async void IniciarCambioPublicidad()
        {
            // Ejecutamos el metodo CambarPublicidad en un nuevo hilo
            await Task.Run(() => CambiarPublicidadPeriodicamente());
        }
        private void CambiarPublicidadPeriodicamente()
        {
            while (true)
            {
                // Cambiar la visibilidad de las imagenes en el hilo secundario
                if (showImagen3)
                {
                    SetearPictureBoxImagen(pictureBox_Publicidad1, Properties.Resources.A_1_1);
                    SetearPictureBoxImagen(pictureBox_Publicidad2, Properties.Resources.AA_2);
                }
                else if (showImagen1)
                {
                    if (showImagen2)
                    {
                        SetearPictureBoxImagen(pictureBox_Publicidad1, Properties.Resources.A_1_1);
                        SetearPictureBoxImagen(pictureBox_Publicidad2, null);
                    }
                    else
                    {
                        SetearPictureBoxImagen(pictureBox_Publicidad1, null);
                        SetearPictureBoxImagen(pictureBox_Publicidad2, Properties.Resources.AA_2);
                    }
                }
                else
                {
                    SetearPictureBoxImagen(pictureBox_Publicidad1, null);
                    SetearPictureBoxImagen(pictureBox_Publicidad2, null);
                }

                //Actualizar estado de las variables
                showImagen1 = !showImagen1;
                showImagen2 = !showImagen2;
                showImagen3 = !showImagen3;

                // Esperar el tiempo deseado antes de cambiar la publicidad nuevamente
                Thread.Sleep(TimeSpan.FromSeconds(1));
            }
        }

        // Establecer imagenes en los pictureBox
        private void SetearPictureBoxImagen(PictureBox pictureBox, Image image)
        {
            //Si la llamada se realiza desde un hilo que no es el hilo principal se invoca una accion en el hilo principa
            if (pictureBox.InvokeRequired)
            {
                pictureBox.Invoke(new Action(() => pictureBox.Image = image));
            }
            else
            {
                //si la llamada se realiza desde el hilo principal, la imagen se establece en el PictureBox.
                pictureBox.Image = image;
            }
        }

        private void BloquearTextBoxes()
        {
            txb_Nombre.ReadOnly = true;
            txb_Cuit.ReadOnly = true;
            txb_MontoAGastar.ReadOnly = true;
        }

        private void CargarClienteAlDataGrid()
        {
            nuevoCliente = clienteLogueado;

            saldoInicialCliente = nuevoCliente.Billetera;
            // UpdateUI();
        }

        private void btn_RegistroDeDatos_Click(object sender, EventArgs e)
        {

            txb_Nombre.Text = nuevoCliente.Nombre.ToString();
            //txb_Apellido.Text = " ";
            txb_Cuit.Text = nuevoCliente.Cuit.ToString();
            txb_MontoAGastar.Text = nuevoCliente.Billetera.ToString();
            cbb_MedioDePago.Text = nuevoCliente.TipoDePago.ToString();
            lbl_SaldoDisponible.Text = nuevoCliente.Billetera.ToString();

            nuevoCliente = clienteLogueado;

            saldoInicialCliente = nuevoCliente.Billetera;

            txb_Nombre.ReadOnly = true;
            txb_Cuit.ReadOnly = true;
            txb_MontoAGastar.ReadOnly = true;
            cbb_MedioDePago.Enabled = false;

            btn_RegistroDeDatos.Enabled = false;

            datosCargados = true;

            UpdateUI();
        }

        public bool ObtenerDatosDelCliente(out string nombreCliente, out string apellidoCliente,
            out long cuitCliente, out float montoAGastarCliente, out ETipoDePago tipoPagoEnum)
        {
            // Llamar a los metodos para obtener los datos del cliente
            bool nombreValido = ObtenerNombreDelCliente(out nombreCliente, out apellidoCliente);
            bool cuitValido = ObtenerCuitDelCliente(out cuitCliente);
            bool montoAGastarValido = ObtenerMaximoAGastar(out montoAGastarCliente);
            bool modoDePagoValido = ObtenerModoDePago(out tipoPagoEnum);
            // Verificar si todos los metodos devuelven true
            if (nombreValido && cuitValido && montoAGastarValido && modoDePagoValido)
            {
                // Todos los datos son validos
                SonidoDatosOk();
                return true;
            }
            // Al menos uno de los metodos devolvio false
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
                retorno = false;
            }

            if (!Regex.IsMatch(apellidoCliente, @"^[a-zA-Z]+$") || apellidoCliente == null)
            {
                SonidoError();
                MessageBox.Show("El apellido ingresado es inválido. Debe contener solo letras.");
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
                MessageBox.Show("El número de CUIT ingresado es inválido. Debe contener solo números.");
                SonidoError();
                esValido = false;
            }

            long.TryParse(cuitTexto, out cuitCliente);

            return esValido;
        }
        public bool ObtenerMaximoAGastar(out float montoAGastarCliente)
        {
            bool retorno = true;
            if (!float.TryParse(txb_MontoAGastar.Text, out montoAGastarCliente) || montoAGastarCliente <= 0)
            {
                MessageBox.Show("El monto a gastar ingresado es inválido. Debe contener solo números.");
                SonidoError();
                retorno = false;
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

            try
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

                            try
                            {
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
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error al comprobar la disponibilidad del producto. " + ex.Message);
                            }

                        }
                    }
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Se produjo una excepción al editar la celda del DataGridView. " + ex.Message);
            }
        }

        private int ObtenerIdProducto(string? tipoProducto)
        {
            throw new NotImplementedException();
        }

        private Producto ObtenerProductoDelDgv(int indiceProductoEnLaLista)
        {
            try
            {
                if (indiceProductoEnLaLista >= 0 && indiceProductoEnLaLista <= heladera.ListaProducto.Count)
                {
                    return auxProducto = heladera.ListaProducto[indiceProductoEnLaLista];
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                // Manejo de la excepcion de indice fuera de los limites
                SonidoError();
                MessageBox.Show("Error al obtener el producto del DataGridView. " + ex.Message);
            }
            catch (Exception ex)
            {
                // Manejo de otras excepciones inesperadas
                SonidoError();
                MessageBox.Show("Se produjo una excepcion al obtener el producto del DataGridView. " + ex.Message);
            }
            // Retornar un valor predeterminado o nulo en caso de excepción
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
            try
            {
                if (datosCargados == false)
                {
                    SonidoError();
                    MessageBox.Show("Por favor, presione el boton REGISTRO DE DATOS.");
                    return;
                }
                if(!puedePagar || !datosCargados)
                {
                    MessageBox.Show("Para continuar con su compra \npor favor seleccione algun producto.");
                    return;
                }
                if (puedePagar && datosCargados)
                {
                    SonidoDatosYCompraOK();
                    nuevoCliente.Billetera = saldoInicialCliente;

                    ComprobarSiAlgunProductoSeRetiroDeLaLista(listaProductosComprados);

                    // Vender Producto
                    vendedor.VenderProductos(nuevoCliente, listaProductosComprados);
                    FrmGeneradorDeFactura generarFactura = new FrmGeneradorDeFactura(nuevoCliente, listaProductosComprados, this);
                    ProductoBD.Modificar(listaProductosComprados);
                    generarFactura.Show();
                    this.Hide();
                }
            }
            catch (Exception ex) 
            {
                // Manejo de excepciones inesperadas
                SonidoError();
                MessageBox.Show("Se produjo una excepcion al realizar la compra: " + ex.Message);
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

                // dgv_Heladera.Columns["CantidadSolicitada"].ReadOnly = false;
                dgv_Heladera.ReadOnly = false;
            }
            else
            {
                dgv_Heladera.DefaultCellStyle.BackColor = SystemColors.Window;
                dgv_Heladera.DefaultCellStyle.ForeColor = SystemColors.ControlText;

                dgv_Heladera.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.Window;
                dgv_Heladera.ColumnHeadersDefaultCellStyle.ForeColor = SystemColors.ControlText;

                dgv_Heladera.EnableHeadersVisualStyles = true;

                //DataGridView1.CurrentCell = null;
                //dgv_Heladera.Columns["CantidadSolicitada"].ReadOnly = true;
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

                float cantidadSolicitada;
                if (!float.TryParse(e.FormattedValue.ToString(), out cantidadSolicitada))
                {
                    e.Cancel = true;
                    MessageBox.Show("Ingrese un valor numerico valido para la cantidad solicitada.");
                }
                else
                {
                    dgv_Heladera.Rows[e.RowIndex].ErrorText = string.Empty;
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
            if (listaProductosComprados != null && productoAgregado != null)
            {
                bool pagaConTarjeta = nuevoCliente.TipoDePago == ETipoDePago.tarjeta;

                foreach (Producto p in listaProductosComprados)
                {
                    if (p.Nombre == productoAgregado.Nombre)
                    {                       
                        float precioPorCantidad = ObtenerPrecioPorCantidad(p.CantidadSolicitada, productoAgregado.PrecioPorKilo);
                        float ivaDelProductoAgregado = DevolverIvaDelProducto(precioPorCantidad);
                        bool esDevolucion = true;

                        if (nuevoCliente != null && nuevoCliente.ActualizarBilletera(precioPorCantidad, pagaConTarjeta, ivaDelProductoAgregado, esDevolucion))
                        {
                            ActualizarSaldoDisponibleEnELFrm(nuevoCliente.Billetera);
                            ActualizarTotalAPagarEnELForm(saldoInicialCliente - nuevoCliente.Billetera);
                        }
                    }
                }
            }
        }

        private void btn_Comprar_MouseEnter(object sender, EventArgs e)
        {
            btn_Comprar.BackColor = Color.Red;
        }

        private void btn_Comprar_MouseLeave(object sender, EventArgs e)
        {
            btn_Comprar.BackColor = Color.White;
        }

        private void btn_RegistroDeDatos_MouseEnter(object sender, EventArgs e)
        {
            btn_RegistroDeDatos.BackColor = Color.Red;
        }

        private void btn_RegistroDeDatos_MouseLeave(object sender, EventArgs e)
        {
            btn_RegistroDeDatos.BackColor = Color.White;
        }

        //private void pictureBox_Publicidad2_Click(object sender, EventArgs e)
        //{

        //}

        //private void pictureBox_Publicidad1_Click(object sender, EventArgs e)
        //{
        //}
    }
}
