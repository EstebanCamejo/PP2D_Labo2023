using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace VisualParcial1
{
    public partial class MenuVendedor : Form
    {
        AbmHeladera frmHeladera;
        FrmListadoDeFacturacion frmFacturacion;
        FrmCompraVenta frmCompraVenta;


        public MenuVendedor()
        {
            InitializeComponent();
        }

        private void btn_Inventario_Click(object sender, EventArgs e)
        {
            if (frmHeladera == null)
            {
                frmHeladera = new AbmHeladera(this);
                SonidoElegirOpcion();
                frmHeladera.Show();
                this.Hide();
            }
        }

        private void btn_Ventas_Click(object sender, EventArgs e)
        {
            if (frmCompraVenta == null)
            {
                frmCompraVenta = new FrmCompraVenta(this);
                SonidoElegirOpcion();
                frmCompraVenta.Show();
                this.Hide();
            }
        }

        private void btn_Facturacion_Click(object sender, EventArgs e)
        {
            if (frmFacturacion == null)
            {
                frmFacturacion = new FrmListadoDeFacturacion(this);
                SonidoElegirOpcion();
                frmFacturacion.Show();
                this.Hide();
            }
        }
       

        private void SonidoElegirOpcion()
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = @"C:\Users\Usuario\source\repos\Camejo.Esteban\VisualParcial1\bin\SoundEffectMarioCoinOK.wav"; ; // Ruta del archivo de sonido
            player.Play();
        }

        
    }
}
