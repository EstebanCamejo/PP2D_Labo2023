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
    public partial class FrmVentas : Form
    {
        List<Cliente> ClienteSeleccionado;
        Cliente auxClienteVenta;
        float topeDeConcesion;
        bool soyVendedor;
        MenuVendedor frmMenuVendedor;

        public FrmVentas(MenuVendedor frmMenuVendedor)
        {
            InitializeComponent();
            this.soyVendedor = true;
            this.frmMenuVendedor = frmMenuVendedor;
        }

        private void FrmVentas_Load(object sender, EventArgs e)
        {
            ClienteSeleccionado = CoreDelSistema.Clientes;

            cbb_SeleccionarCliente.Items.AddRange(ClienteSeleccionado.ToArray());
        }
        private void cbb_SeleccionarCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Cliente? clienteVenta = ObtenerClienteDelListbox();

            if (!float.TryParse(txb_TopeDeConcesion.Text, out topeDeConcesion) && topeDeConcesion > 0)
            {
                MessageBox.Show("El monto ingresado es invalido");
            }
            else
            {
                clienteVenta.Billetera = topeDeConcesion;
            }

            bool esVendedor = false;

            FrmCompraVenta compraVenta = new FrmCompraVenta(clienteVenta, esVendedor, this);

            compraVenta.Show();
            this.Hide();


        }

        private Cliente? ObtenerClienteDelListbox()
        {
            int indiceCliente = cbb_SeleccionarCliente.SelectedIndex;

            if (indiceCliente >= 0)
            {
                return auxClienteVenta = ClienteSeleccionado[indiceCliente];
            }
            return null;
        }

        private void btn_VolverAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenuVendedor.Show();
        }
    }
}
