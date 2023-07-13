using PPLabo2_2D;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


namespace VisualParcial1
{
    public partial class FrmAltaProducto : Form
    {
        Producto productoAlta;
        EProdcuto tipoProductoEnum;
        string precioPorKilo;
        string cantidadDeKilos;
        string nombre;
        bool esModificar;
        public float valorPrecioPorKg;
        public float valorCantidadKg;
        private AbmHeladera frmAbmHladera;
        private bool cerrarFormulario;
        public FrmAltaProducto()
        {
            InitializeComponent();
            this.esModificar = false;
            this.cerrarFormulario = false;
        }
        public FrmAltaProducto(AbmHeladera frmAbmHladera) : this()
        {
            this.frmAbmHladera = frmAbmHladera;
        }
        public FrmAltaProducto(Producto productoEditar, AbmHeladera frmAbmHladera) : this()
        {
            this.productoAlta = productoEditar;
            this.esModificar = true;
            this.frmAbmHladera = frmAbmHladera;
        }

        public Producto ProductoAlta
        {
            get { return productoAlta; }
        }

        /// <summary>
        /// Cargo el combobox con la informacion que contiene mi enumerado productos
        /// Actualizo mis etiquetas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAltaProducto_Load(object sender, EventArgs e)
        {
            try
            {
                cbb_TipoDeProducto.Items.Add("vacuno");
                cbb_TipoDeProducto.Items.Add("aves");
                cbb_TipoDeProducto.Items.Add("cerdo");
                cbb_TipoDeProducto.Items.Add("preparados");
                cbb_TipoDeProducto.Items.Add("embutidos");

                if (this.productoAlta != null)
                {
                    cbb_TipoDeProducto.Text = productoAlta.TipoDeProducto.ToString();
                    txb_Nombre.Text = productoAlta.Nombre;
                    txb_Precio.Text = productoAlta.PrecioPorKilo.ToString();
                    txb_Cantidad.Text = productoAlta.CantidadDeKilos.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error durante la carga del formulario. " + ex.Message);
            }
        }


        /// <summary>
        /// Valido cada campo porviniente de los text box y combo box hago el parse en cada uno que lo necesite
        /// En el caso que sea una modificacion rescato esa informacion para no duplicar prductos
        /// Luego instancio el nuevo producto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_CrearProducto_Click(object sender, EventArgs e)
        {
            try
            {
                nombre = txb_Nombre.Text;
                precioPorKilo = txb_Precio.Text;
                cantidadDeKilos = txb_Cantidad.Text;
                bool datosOK = true;

                if (string.IsNullOrWhiteSpace(cbb_TipoDeProducto.Text))
                {
                    MessageBox.Show("El tipo de Producto Selecionado es Invalido.");
                    SonidoError();
                    datosOK = false;
                }
                else
                {
                    tipoProductoEnum = (EProdcuto)Enum.Parse(typeof(EProdcuto), cbb_TipoDeProducto.Text);
                }

                if (string.IsNullOrEmpty(nombre))
                {
                    MessageBox.Show("El nombre Ingresado es Invalido.");
                    SonidoError();
                    datosOK = false;
                }

                if ((!float.TryParse(precioPorKilo, out valorPrecioPorKg)) || valorPrecioPorKg <= 0)
                {
                    MessageBox.Show("El precio ingresado es invalido.");
                    SonidoError();
                    datosOK = false;
                }
                if ((!float.TryParse(cantidadDeKilos, out valorCantidadKg)) || valorCantidadKg < 0)
                {
                    MessageBox.Show("El precio ingresado es invalido.");
                    SonidoError();
                    datosOK = false;
                }

                if (datosOK == false)
                {
                    this.DialogResult = DialogResult.No;
                }
                else
                {
                    if (esModificar == true)
                    {
                        this.productoAlta.TipoDeProducto = tipoProductoEnum;
                        this.productoAlta.Nombre = nombre;
                        this.productoAlta.PrecioPorKilo = valorPrecioPorKg;
                        this.productoAlta.CantidadDeKilos = valorCantidadKg;
                    }
                    else
                    {
                        Producto nuevoProducto = new Producto(tipoProductoEnum, valorPrecioPorKg, valorCantidadKg, nombre);

                        this.productoAlta = nuevoProducto;
                    }

                    this.DialogResult = DialogResult.OK;
                    cerrarFormulario = true; // El formulario puede cerrarse
                    this.Close(); // Cerrar el formulario
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error durante la creacion del producto. " + ex.Message);
            }
        }

        private void btn_VolverAtras_Click(object sender, EventArgs e)
        {
            cerrarFormulario = true;
            this.Close();
            frmAbmHladera.Show();
            SonidoVolverAtras();
        }

        private void SonidoError()
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = @"C:\Users\Usuario\source\repos\Camejo.Esteban\VisualParcial1\bin\SoundEffectERROR.wav"; ; // Ruta del archivo de sonido
            player.Play();
        }

        private void SonidoVolverAtras()
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = @"C:\Users\Usuario\source\repos\Camejo.Esteban\VisualParcial1\bin\SoundEffectSuperMarioBrosDown.wav"; ; // Ruta del archivo de sonido
            player.Play();
        }

        private void FrmAltaProducto_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (!cerrarFormulario)
                {
                    e.Cancel = true; // Cancelar el cierre del formulario
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error durante el cierre del formulario. " + ex.Message);
            }
        }

        private void btn_VolverAtras_MouseEnter(object sender, EventArgs e)
        {
            btn_VolverAtras.BackColor = Color.Red;
        }

        private void btn_VolverAtras_MouseLeave(object sender, EventArgs e)
        {
            btn_VolverAtras.BackColor = Color.White;
        }

        private void btn_CrearProducto_MouseEnter(object sender, EventArgs e)
        {
            btn_CrearProducto.BackColor = Color.Red;
        }

        private void btn_CrearProducto_MouseLeave(object sender, EventArgs e)
        {
            btn_CrearProducto.BackColor = Color.White;
        }
    }
}
