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
using System.Media;

namespace VisualParcial1
{
    public partial class AbmHeladera : Form
    {
        Heladera heladera;
        Producto auxProducto;
        bool primeraCarga;
        private MenuVendedor frmMenuVendedor;
        int indiceSeleccionado = -1;

        public AbmHeladera()
        {
            InitializeComponent();
        }
        public AbmHeladera(MenuVendedor frmMenuVendedor) : this()
        {

            heladera = new Heladera();
            auxProducto = new Producto();
            primeraCarga = true;
            this.frmMenuVendedor = frmMenuVendedor;

            dtgv_StockHeladera.CellClick += dtgv_StockHeladera_CellClick;
        }
        private void AbmHeladera_Load(object sender, EventArgs e)
        {
            heladera.ActualizarProductosDeLaHeladera(CoreDelSistema.Productos);

            ActualizarDataGrid(heladera);
        }

        // EDITAR

        /// <summary>
        /// El metodo obtiene el producto desde el listBox, verifica que no sea nulo
        /// instancia el siguiente formulario y envia el producto a editar
        /// si el siguiente formulario devuelve un OK indicando que puedo realizar los cambios
        /// se acutualiza la heladera con los cambios del producto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_editarProducto_Click(object sender, EventArgs e)
        {
            Producto? productoEditar = ObtenerProductoDelDataGrid();

            if (productoEditar != null)
            {
                Producto productoCopia = productoEditar;

                FrmAltaProducto frmEditarProducto = new FrmAltaProducto(productoCopia, this);

                DialogResult resltado = frmEditarProducto.ShowDialog();

                if (resltado == DialogResult.OK)
                {
                    int indice = heladera.ListaProducto.IndexOf(productoEditar);
                    heladera.ListaProducto[indice] = productoCopia;

                    ActualizarDataGrid(heladera);
                    MessageBox.Show($"El producto {productoCopia.Nombre}se ha actualizado correctamente.");
                    SonidoAbmOK();
                    ActualizarDataGrid(heladera);
                }
                else if (resltado == DialogResult.No)
                {
                    MessageBox.Show("El producto no ha sido actualizado");
                    SonidoError();
                }
            }
            else
            {
                MessageBox.Show("Para continuar con la edición \ndebe seleccionar un producto.");
            }
        }

        //ALTA
        /// <summary>
        /// Se instancia el siguiente formulario para realizar el alta del pruducto
        /// si este devuelve OK entonces agregamso el proiducto a la heladera y al core del sistema
        /// actualizamos los listbox de productos y mostramos el mensaje
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_nuevoProducto_Click(object sender, EventArgs e)
        {
            FrmAltaProducto frmAltaProducto = new FrmAltaProducto(this);

            DialogResult resltado = frmAltaProducto.ShowDialog();

            if (resltado == DialogResult.OK)
            {
                heladera.AgregarProductoALista(frmAltaProducto.ProductoAlta);
                CoreDelSistema.GuardarNuevoProducto(frmAltaProducto.ProductoAlta);
                ActualizarDataGrid(heladera);
                MessageBox.Show($"El producto {frmAltaProducto.ProductoAlta.Nombre} ha sido creado exitosamente");
                SonidoAbmOK();
            }
            else if (resltado == DialogResult.No)
            {
                MessageBox.Show("El producto no se ha creado");
                SonidoError();
            }

        }

        // BAJA

        /// <summary>
        /// Obtenemos el producto que queremos dar de baja de la lista
        /// comprobamos que no sea nulo y lo removemos de la heladera luego actualizamos el listbox de productos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_bajaProducto_Click(object sender, EventArgs e)
        {
            Producto? productoBaja = ObtenerProductoDelDataGrid();

            if (productoBaja != null)
            {
                MessageBox.Show("El siguiente producto se ha dado de baja: " + productoBaja.Nombre);

                heladera.ListaProducto.Remove(productoBaja);

                ActualizarDataGrid(heladera);

                SonidoAbmOK();
            }
            else
            {
                MessageBox.Show("Para continuar con la baja \ndebe seleccionar un producto.");
            }

        }

        /// <summary>
        /// Obtenemos el indice del producto seleccionado desde el listbox y retornamos el objeto producto desde la heladera
        /// </summary>
        /// <returns></returns>
        private Producto? ObtenerProductoDelDataGrid()
        {
            if (indiceSeleccionado >= 0 && indiceSeleccionado < heladera.ListaProducto.Count)
            {
                return auxProducto = heladera.ListaProducto[indiceSeleccionado];
            }
            return null;
        }

        private void btn_VolverAtras_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMenuVendedor.Show();
            SonidoVolverAtras();
        }

        private void ActualizarDataGrid(Heladera heladera)
        {
            dtgv_StockHeladera.Rows.Clear();

            foreach (Producto producto in heladera.ListaProducto)
            {
                int rowIndex = dtgv_StockHeladera.Rows.Add();

                dtgv_StockHeladera.Rows[rowIndex].Cells["tipoDeProducto"].Value = producto.TipoDeProducto;
                dtgv_StockHeladera.Rows[rowIndex].Cells["tipoDeProducto"].ReadOnly = true;

                dtgv_StockHeladera.Rows[rowIndex].Cells["precioPorKilo"].Value = producto.PrecioPorKilo.ToString();
                dtgv_StockHeladera.Rows[rowIndex].Cells["precioPorKilo"].ReadOnly = true;

                dtgv_StockHeladera.Rows[rowIndex].Cells["CantidadKilos"].Value = producto.CantidadDeKilos.ToString();
                dtgv_StockHeladera.Rows[rowIndex].Cells["CantidadKilos"].ReadOnly = true;

                dtgv_StockHeladera.Rows[rowIndex].Cells["nombre"].Value = producto.Nombre;
                dtgv_StockHeladera.Rows[rowIndex].Cells["nombre"].ReadOnly = true;
            }
            dtgv_StockHeladera.ClearSelection();
            dtgv_StockHeladera.CurrentCell = null;
        }

        private void dtgv_StockHeladera_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                indiceSeleccionado = e.RowIndex;
            }
        }
        private void SonidoVolverAtras()
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = @"C:\Users\Usuario\source\repos\Camejo.Esteban\VisualParcial1\bin\SoundEffectSuperMarioBrosDown.wav"; ; // Ruta del archivo de sonido
            player.Play();
        }
        private void SonidoAbmOK()
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = @"C:\Users\Usuario\source\repos\Camejo.Esteban\VisualParcial1\bin\SoundEffectMarioCoinOK.wav"; ; // Ruta del archivo de sonido
            player.Play();
        }

        private void SonidoError()
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = @"C:\Users\Usuario\source\repos\Camejo.Esteban\VisualParcial1\bin\SoundEffectERROR.wav"; ; // Ruta del archivo de sonido
            player.Play();
        }

        private void btn_nuevoProducto_MouseEnter(object sender, EventArgs e)
        {
            btn_nuevoProducto.BackColor = Color.Red;
        }

        private void btn_nuevoProducto_MouseLeave(object sender, EventArgs e)
        {
            btn_nuevoProducto.BackColor = Color.White;
        }

        private void btn_editarProducto_MouseEnter(object sender, EventArgs e)
        {
            btn_editarProducto.BackColor = Color.Red;
        }

        private void btn_editarProducto_MouseLeave(object sender, EventArgs e)
        {
            btn_editarProducto.BackColor = Color.White;
        }

        private void btn_bajaProducto_MouseEnter(object sender, EventArgs e)
        {
            btn_bajaProducto.BackColor = Color.Red;
        }

        private void btn_bajaProducto_MouseLeave(object sender, EventArgs e)
        {
            btn_bajaProducto.BackColor = Color.White;
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
