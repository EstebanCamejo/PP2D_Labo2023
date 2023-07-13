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
using PPLabo2_2D;

namespace VisualParcial1
{
    public partial class Login : Form
    {

        MenuCliente menuCliente;
        MenuVendedor menuVendedor;
        string tipoDeUsuario;

        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            txb_nombreUsuario.Text = "Usuario";
            txb_contrasenia.Text = "Contrasenia";
        }

        private void btn_Cliente_Click(object sender, EventArgs e)
        {
            tipoDeUsuario = "cliente";
            string usuarioDatoIngresado = txb_nombreUsuario.Text;
            string contraseniaDatoIngresado = txb_contrasenia.Text;

            try
            {
                if (usuarioDatoIngresado != "Usuario" || contraseniaDatoIngresado != "Contrasenia")
                {
                    MessageBox.Show("ERROR al ingresar los datos.");
                    txb_nombreUsuario.Text = "Usuario";
                    txb_contrasenia.Text = "Contrasenia";

                    return;
                }

                //ObtenerUsuarioYContraseniaDelegate obtenerUsuarioYContrasenia = ObtenerUsuarioYContraseniaAleatorio;
                //(string usuario, string contrasenia) = obtenerUsuarioYContrasenia();
                (string usuario, string contrasenia) = ObtenerUsuarioYContraseniaAleatorio();

                Cliente clienteLogueado = (Cliente)UsuariosDB.LoginTipoDeUsuario(usuario, contrasenia);

                if (menuCliente == null && tipoDeUsuario == "cliente" && clienteLogueado != null)
                {
                    menuCliente = new MenuCliente(clienteLogueado);
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
            catch (Exception ex) 
            {
                MessageBox.Show("Error al iniciar sesión LALALA. " + ex.Message); 
            }
        }

       // public delegate (string, string) ObtenerUsuarioYContraseniaDelegate();

        public static (string, string) ObtenerUsuarioYContraseniaAleatorio()
        {
            string[] usuarios = { "Usuario1", "Usuario2", "Usuario3", "Usuario4", "Usuario5" };
            string[] contrasenias = { "Contrasenia1", "Contrasenia2", "Contrasenia3", "Contrasenia4", "Contrasenia5" };

            try
            {
                Random random = new Random();
                int indice = random.Next(usuarios.Length);

                return (usuarios[indice], contrasenias[indice]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el usuario y la contraseña. " + ex.Message);
                return (string.Empty, string.Empty);
            }
        }


        private void btn_Vendedor_Click(object sender, EventArgs e)
        {
            tipoDeUsuario = "vendedor";
            string usuarioDatoIngresado = txb_nombreUsuario.Text;
            string contraseniaDatoIngresado = txb_contrasenia.Text;
            try
            {
                if (usuarioDatoIngresado != "Usuario" || contraseniaDatoIngresado != "Contrasenia")
                {
                    MessageBox.Show("ERROR al ingresar los datos.");
                    txb_nombreUsuario.Text = "Usuario";
                    txb_contrasenia.Text = "Contrasenia";

                    return;
                }
                else if (usuarioDatoIngresado == "Usuario" && contraseniaDatoIngresado == "Contrasenia")
                {
                    Usuario vendedorLogeado = UsuariosDB.LoginTipoDeUsuario("Usuario6", "Contrasenia6");

                    if (menuVendedor == null && vendedorLogeado != null)
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

            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error al iniciar sesión. " + ex.Message);
            }
        }

        private void txb_nombreUsuario_TextChanged(object sender, EventArgs e)
        {
            //txb_contrasenia.Text = "Usuario";
        }

        private void txb_contrasenia_TextChanged(object sender, EventArgs e)
        {
            // txb_contrasenia.Text = "Contrasenia";
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
