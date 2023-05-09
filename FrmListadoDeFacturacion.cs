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

    public partial class FrmListadoDeFacturacion : Form
    {
        private MenuVendedor frmMenuVendedor;
        public FrmListadoDeFacturacion(MenuVendedor frmMenuVendedor)
        {
            InitializeComponent();
            this.frmMenuVendedor = frmMenuVendedor;
        }


        private void FrmListadoDeFacturacion_Load(object sender, EventArgs e)
        {
            ActualizarListBoxDeProductos();
        }

        private void ActualizarListBoxDeProductos()
        {
            lbx_ListadoDeFactuaras.DataSource = null;
            lbx_ListadoDeFactuaras.DataSource = CoreDelSistema.Facturas;
        }

        private void btn_VolverAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenuVendedor.Show();
        }
    }
}
