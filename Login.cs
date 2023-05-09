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
    public partial class Login : Form
    {
        private string usuarioValido;
        private string passwordValido;
        MenuCliente menuCliente;
        MenuVendedor menuVendedor;
        string tipoDeUsuario;
        private Inicio FrmInicio;

        public Login(string tipoDeUsuario, Inicio frmInicio)
        {
            InitializeComponent();
            usuarioValido = "Usuario";
            passwordValido = "Contrasenia";
            this.tipoDeUsuario = tipoDeUsuario;
            FrmInicio = frmInicio;
        }

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            txb_nombreUsuario.Text = "Usuario";
            txb_contrasenia.Text = "Contrasenia";

            string usuarioIngresado = txb_nombreUsuario.Text;
            string passwordIngresado = txb_contrasenia.Text;

            if (usuarioIngresado == usuarioValido && passwordIngresado == passwordValido)
            {
                if (menuCliente == null && tipoDeUsuario == "cliente")
                {
                    menuCliente = new MenuCliente(this);
                    menuCliente.Show();
                    this.Hide();
                }
                else if (menuVendedor == null && tipoDeUsuario == "vendedor")
                {
                    menuVendedor = new MenuVendedor(this);
                    menuVendedor.Show();
                    this.Hide();
                }

            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrecta");
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

        public void MostrarLogin()
        {
            this.Show();
        }

        private void btn_VolverAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmInicio.Show();

        }
    }
}
