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
    public partial class Login : Form
    {
        private string usuarioValido;
        private string passwordValido;
        MenuCliente menuCliente;
        MenuVendedor menuVendedor;
        string tipoDeUsuario;


        public Login()
        {
            InitializeComponent();
            usuarioValido = "Usuario";
            passwordValido = "Contrasenia";
        }
        private void Login_Load(object sender, EventArgs e)
        {
            txb_nombreUsuario.Text = "Usuario";
            txb_contrasenia.Text = "Contrasenia";
        }

        private void btn_Cliente_Click(object sender, EventArgs e)
        {
            tipoDeUsuario = "cliente";

            if (menuCliente == null && tipoDeUsuario == "cliente")
            {
                menuCliente = new MenuCliente();
                menuCliente.Show();
                this.Hide();

                SoundPlayer player = new SoundPlayer();
                player.SoundLocation = @"C:\Users\Usuario\source\repos\Camejo.Esteban\VisualParcial1\bin\SoundEffectSuperMarioBrosUP.wav"; ; // Ruta del archivo de sonido
                player.Play();
            }
            else
            {
                MessageBox.Show("Error. Seleccione una opcion valida");

                SoundPlayer player = new SoundPlayer();
                player.SoundLocation = @"C:\Users\Usuario\source\repos\Camejo.Esteban\VisualParcial1\bin\SoundEffectERROR.wav"; ; // Ruta del archivo de sonido
                player.Play();
            }
        }

        private void btn_Vendedor_Click(object sender, EventArgs e)
        {
            tipoDeUsuario = "vendedor";

            if (menuVendedor == null && tipoDeUsuario == "vendedor")
            {
                menuVendedor = new MenuVendedor();
                menuVendedor.Show();
                this.Hide();

                SoundPlayer player = new SoundPlayer();
                player.SoundLocation = @"C:\Users\Usuario\source\repos\Camejo.Esteban\VisualParcial1\bin\SoundEffectSuperMarioBrosUP.wav"; ; // Ruta del archivo de sonido
                player.Play();
            }
            else
            {
                MessageBox.Show("Error. Seleccione una opcion valida");

                SoundPlayer player = new SoundPlayer();
                player.SoundLocation = @"C:\Users\Usuario\source\repos\Camejo.Esteban\VisualParcial1\bin\SoundEffectERROR.wav"; ; // Ruta del archivo de sonido
                player.Play();
            }
        }

        private void txb_nombreUsuario_TextChanged(object sender, EventArgs e)
        {
            txb_contrasenia.Text = "Usuario";
        }

        private void txb_contrasenia_TextChanged(object sender, EventArgs e)
        {
            txb_contrasenia.Text = "Contrasenia";
        }

        private void btn_Cliente_MouseEnter(object sender, EventArgs e)
        {
            btn_Cliente.BackColor = Color.Red;
        }

        private void btn_Cliente_MouseLeave(object sender, EventArgs e)
        {
            btn_Cliente.BackColor = Color.White;
        }

        private void btn_Vendedor_MouseEnter(object sender, EventArgs e)
        {
            btn_Vendedor.BackColor = Color.Red;
        }

        private void btn_Vendedor_MouseLeave(object sender, EventArgs e)
        {
            btn_Vendedor.BackColor = Color.White;
        }
    }
}
