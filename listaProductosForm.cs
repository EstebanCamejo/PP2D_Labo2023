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
    public partial class listaProductosForm : Form
    {
        public listaProductosForm()
        {
            InitializeComponent();
        }
        public void MostrarProductosSerializados(string listaDeProductos)
        {
            textBox1.Text = listaDeProductos;
        }
    }
}
