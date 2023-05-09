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


namespace VisualParcial1
{
    public partial class FrmAltaProducto : Form
    {
        Producto productoAlta;
        EProdcuto tipoProductoEnum;
        // string tipoDeProducto;
        string precioPorKilo;
        string cantidadDeKilos;
        string nombre;
        bool esModificar;
        public float valorPrecioPorKg;
        public float valorCantidadKg;
        private AbmHeladera frmAbmHladera;
        public FrmAltaProducto()
        {
            InitializeComponent();
            this.esModificar = false;
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


        private void FrmAltaProducto_Load(object sender, EventArgs e)
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

        private void btn_CrearProducto_Click(object sender, EventArgs e)
        {
           
            nombre = txb_Nombre.Text;
            precioPorKilo = txb_Precio.Text;
            cantidadDeKilos = txb_Cantidad.Text;

            if (string.IsNullOrWhiteSpace(cbb_TipoDeProducto.Text))
            {
                MessageBox.Show("El tipo de Producto Selecionado es Invalido");
            }
            else
            {
                tipoProductoEnum = (EProdcuto)Enum.Parse(typeof(EProdcuto), cbb_TipoDeProducto.Text);
            }

            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("El nombre Ingresado es Invalido");
            }

            if (!float.TryParse(precioPorKilo, out valorPrecioPorKg) && valorPrecioPorKg <= 0)
            {
                MessageBox.Show("El precio ingresado es invalido");
            }
            if (!float.TryParse(cantidadDeKilos, out valorCantidadKg) && valorCantidadKg < 0)
            {
                MessageBox.Show("El precio ingresado es invalido");
            }


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

        }

        private void btn_VolverAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAbmHladera.Show();
        }



        // solicito todos los datos del producto nuevo desde el form


        // guardo los datos en el Producto
        // Dentro del scoppe del metodo para guardar el producto o
        // Cuando se presiona el boton guardar le cambio el estado a mi variable DialogResult
        // this.DialogResult = DialogResult.OK; el this hace referenica a este estado

    }
}
