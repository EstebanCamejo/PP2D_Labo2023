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
    public partial class MenuCliente : Form
    {
        Cliente clienteUsuario;
        string nombreCliente;
        string apellidoCliente;
        long cuitCliente;
        string direccionCliente;
        float montoAGastarCliente;
        ETipoDePago tipoPagoEnum;
        Login login;


        public MenuCliente(Login login)
        {
            InitializeComponent();
            this.login = login;
        }

        private void MenuCliente_Load(object sender, EventArgs e)
        {
            cbb_MedioDePago.Items.Add("efectivo");
            cbb_MedioDePago.Items.Add("tarjeta");
        }

        private void btn_GestionarPedido_Click(object sender, EventArgs e)
        {
            nombreCliente = txb_Nombre.Text;
            apellidoCliente = txb_Apellido.Text;
            if (!long.TryParse(txb_Cuit.Text, out cuitCliente))
            {
                MessageBox.Show("El numero de Cuit Ingresado es inválido");
            }

            direccionCliente = txb_Direccion.Text;

            if (!float.TryParse(txb_MontoAGastar.Text, out montoAGastarCliente))
            {
                MessageBox.Show("El monto a gastar ingresado es inválido");
            }

            if (string.IsNullOrWhiteSpace(cbb_MedioDePago.Text))
            {
                MessageBox.Show("El tipo de Producto Selecionado es Invalido");
            }
            else
            {
                tipoPagoEnum = (ETipoDePago)Enum.Parse(typeof(ETipoDePago), cbb_MedioDePago.Text);
            }
            string nombreUsuario = "usuarioHardcodeado";
            string passUsuario = "passHardcodeado";

            Cliente nuevoCliente = new Cliente(nombreUsuario, passUsuario, nombreCliente, apellidoCliente,
            montoAGastarCliente, cuitCliente, direccionCliente, tipoPagoEnum);

            if (CoreDelSistema.GuardarNuevoCliente(nuevoCliente))
            {
                bool esCliente = true;
                FrmCompraVenta compraVenta = new FrmCompraVenta(nuevoCliente, esCliente, this);
                compraVenta.Show();
                this.Hide();
            }
            //DialogResult resultado = FrmGeneradorDeFactura.ShowDialog();                       
        }

        private void btn_VolverAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            login.Show();
        }
    }
}
