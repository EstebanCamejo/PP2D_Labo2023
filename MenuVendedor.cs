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
    public partial class MenuVendedor : Form
    {
        AbmHeladera frmHeladera;
        FrmListadoDeFacturacion frmFacturacion;
        FrmVentas frmVentas;
        Login login;

        public MenuVendedor(Login login)
        {
            InitializeComponent();
            this.login = login;
        }

        private void btn_Inventario_Click(object sender, EventArgs e)
        {
            if (frmHeladera == null)
            {
                frmHeladera = new AbmHeladera(this);
                frmHeladera.Show();
                this.Hide();
            }
        }

        private void btn_Ventas_Click(object sender, EventArgs e)
        {
            if (frmVentas == null)
            {
                frmVentas = new FrmVentas(this);
                frmVentas.Show();
                this.Hide();
            }
        }

        private void btn_Facturacion_Click(object sender, EventArgs e)
        {
            if (frmFacturacion == null)
            {
                frmFacturacion = new FrmListadoDeFacturacion(this);
                frmFacturacion.Show();
                this.Hide();
            }
        }

        private void btn_VolverAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            login.Show();
        }
    }
}
