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
    public partial class Inicio : Form
    {
        string tipoUsuario;
        Login login;
        public Inicio()
        {
            InitializeComponent();
            this.tipoUsuario = string.Empty;
        }

        private void btnVendedor_MouseHover(object sender, EventArgs e)
        {
            btnVendedor.BackColor = Color.LightBlue;
        }

        private void btnVendedor_MouseLeave(object sender, EventArgs e)
        {
            btnVendedor.BackColor = Color.Blue;
        }

        private void btnCliente_MouseHover(object sender, EventArgs e)
        {
            btnCliente.BackColor = Color.LightBlue;
        }

        private void btnCliente_MouseLeave(object sender, EventArgs e)
        {
            btnCliente.BackColor = Color.Blue;
        }

        private void btnVendedor_Click(object sender, EventArgs e)
        {
            tipoUsuario = "vendedor";

            if (login == null && tipoUsuario == "vendedor")
            {
                login = new Login(tipoUsuario, this);
                login.Show();
                this.Hide();
            }

        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            tipoUsuario = "cliente";

            if (login == null && tipoUsuario == "cliente")
            {
                login = new Login(tipoUsuario, this);
                login.Show();
                this.Hide();
            }
        }
    }
}
