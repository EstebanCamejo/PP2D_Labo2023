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

    public partial class FrmListadoDeFacturacion : Form
    {
        List<Factura> listadoFacturas;

        private MenuVendedor frmMenuVendedor;
        public FrmListadoDeFacturacion(MenuVendedor frmMenuVendedor)
        {
            InitializeComponent();
            this.frmMenuVendedor = frmMenuVendedor;
            this.listadoFacturas = CoreDelSistema.Facturas;
        }


        private void FrmListadoDeFacturacion_Load(object sender, EventArgs e)
        {
            ActualizarFacturasDelDatagrid(listadoFacturas);
        }


        private void ActualizarFacturasDelDatagrid(List<Factura> facturas)
        {
            dgv_ListadoDeFacturas.Rows.Clear();

            foreach (Factura factura in facturas)
            {
                int rowIndex = dgv_ListadoDeFacturas.Rows.Add();

                dgv_ListadoDeFacturas.Rows[rowIndex].Cells["numeroDeFactura"].Value = factura.NumeroDeFactura.ToString();
                dgv_ListadoDeFacturas.Rows[rowIndex].Cells["numeroDeFactura"].ReadOnly = true;

                dgv_ListadoDeFacturas.Rows[rowIndex].Cells["fechaActual"].Value = factura.FechaActual.ToShortDateString();
                dgv_ListadoDeFacturas.Rows[rowIndex].Cells["fechaActual"].ReadOnly = true;

                dgv_ListadoDeFacturas.Rows[rowIndex].Cells["cliente"].Value = factura.Apellido;
                dgv_ListadoDeFacturas.Rows[rowIndex].Cells["cliente"].ReadOnly = true;

                dgv_ListadoDeFacturas.Rows[rowIndex].Cells["totalFactura"].Value = factura.TotalFactura.ToString("N2");
                dgv_ListadoDeFacturas.Rows[rowIndex].Cells["totalFactura"].ReadOnly = true;
            }
            dgv_ListadoDeFacturas.ClearSelection();
            dgv_ListadoDeFacturas.CurrentCell = null;
        }

        private void btn_VolverAtras_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMenuVendedor.Show();
            SonidoVolverAtras();
        }
        private void SonidoVolverAtras()
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = @"C:\Users\Usuario\source\repos\Camejo.Esteban\VisualParcial1\bin\SoundEffectSuperMarioBrosDown.wav"; ; // Ruta del archivo de sonido
            player.Play();
        }

        private void btn_VolverAtras_MouseEnter(object sender, EventArgs e)
        {
            btn_VolverAtras.BackColor = Color.Red;
        }

        private void btn_VolverAtras_MouseLeave(object sender, EventArgs e)
        {
            btn_VolverAtras.BackColor = Color.White;
        }
    }
}
