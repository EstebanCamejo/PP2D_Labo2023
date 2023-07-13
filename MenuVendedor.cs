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
            if (frmHeladera == null || frmHeladera.IsDisposed)
            {
                frmHeladera = new AbmHeladera(this);
                SonidoElegirOpcion();
            }
            frmHeladera.Show();
            this.Hide();
        }

        private void btn_Ventas_Click(object sender, EventArgs e)
        {
            if (frmCompraVenta == null || frmCompraVenta.IsDisposed)
            {
                frmCompraVenta = new FrmCompraVenta(this);
                SonidoElegirOpcion();
            }
            frmCompraVenta.Show();
            this.Hide();
        }

        private void btn_Facturacion_Click(object sender, EventArgs e)
        {
            if (frmFacturacion == null || frmFacturacion.IsDisposed)
            {
                frmFacturacion = new FrmListadoDeFacturacion(this);
                SonidoElegirOpcion();
            }
            frmFacturacion.Show();
            this.Hide();
        }


        private void SonidoElegirOpcion()
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = @"C:\Users\Usuario\source\repos\Camejo.Esteban\VisualParcial1\bin\SoundEffectMarioCoinOK.wav"; ; // Ruta del archivo de sonido
            player.Play();
        }
        private void SonidoVolverAtras()
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = @"C:\Users\Usuario\source\repos\Camejo.Esteban\VisualParcial1\bin\SoundEffectSuperMarioBrosDown.wav"; ; // Ruta del archivo de sonido
            player.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SonidoVolverAtras();
            Application.Exit();
        }

        private void btn_Inventario_MouseEnter(object sender, EventArgs e)
        {
            btn_Inventario.BackColor = Color.Red;
        }

        private void btn_Inventario_MouseLeave(object sender, EventArgs e)
        {
            btn_Inventario.BackColor = Color.White;
        }

        private void btn_Facturacion_MouseEnter(object sender, EventArgs e)
        {
            btn_Facturacion.BackColor = Color.Red;
        }

        private void btn_Facturacion_MouseLeave(object sender, EventArgs e)
        {
            btn_Facturacion.BackColor = Color.White;
        }

        private void btn_Ventas_MouseEnter(object sender, EventArgs e)
        {
            btn_Ventas.BackColor = Color.Red;
        }

        private void btn_Ventas_MouseLeave(object sender, EventArgs e)
        {
            btn_Ventas.BackColor = Color.White;
        }

        private void btn_Salir_MouseEnter(object sender, EventArgs e)
        {
            btn_Salir.BackColor = Color.Red;
        }

        private void btn_Salir_MouseLeave(object sender, EventArgs e)
        {
            btn_Salir.BackColor = Color.White;
        }
    }
}
