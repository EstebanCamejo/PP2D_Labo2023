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
    public partial class AbmHeladera : Form
    {
        Heladera heladera;
        Producto auxProducto;
        bool primeraCarga;
        private MenuVendedor frmMenuVendedor;

        public AbmHeladera(MenuVendedor frmMenuVendedor)
        {
            InitializeComponent();
            heladera = new Heladera();
            auxProducto = new Producto();
            primeraCarga = true;
            this.frmMenuVendedor = frmMenuVendedor;
        }
        private void AbmHeladera_Load(object sender, EventArgs e)
        {
            ActualizarListBoxDeProductos();

            heladera.ActualizarProductosDeLaHeladera(CoreDelSistema.Productos);
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
            Producto? productoEditar = ObtenerProductoDelListbox();

            if (productoEditar != null)
            {
                FrmAltaProducto frmEditarProducto = new FrmAltaProducto(productoEditar, this);

                DialogResult resltado = frmEditarProducto.ShowDialog();

                if (resltado == DialogResult.OK)
                {
                    heladera.ActualizarProductoEnLalista(frmEditarProducto.ProductoAlta);
                    //CoreDelSistema.ActualizarProducto(frmEditarProducto.ProductoAlta);                               
                    ActualizarListBoxDeProductos();
                }
                else
                {
                    MessageBox.Show("El producto no ha sido actualizado");
                }

                ActualizarListBoxDeProductos();
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
            FrmAltaProducto frmAltaProducto = new FrmAltaProducto();

            DialogResult resltado = frmAltaProducto.ShowDialog(this);

            if (resltado == DialogResult.OK)
            {
                heladera.AgregarProductoALista(frmAltaProducto.ProductoAlta);
                CoreDelSistema.GuardarNuevoProducto(frmAltaProducto.ProductoAlta);
                ActualizarListBoxDeProductos();
                MessageBox.Show($"El producto {frmAltaProducto.ProductoAlta.Nombre} ha sido creado exitosamente");
            }
            else
            {
                MessageBox.Show("El producto no se ha creado");
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
            Producto? productoBaja = ObtenerProductoDelListbox();

            if (productoBaja != null)
            {
                MessageBox.Show("El siguiente producto se ha dado de baja: " + productoBaja.Nombre);

                heladera.ListaProducto.Remove(productoBaja);

                // CoreDelSistema.ActualizarListaDeProductos(heladera.ListaProducto);

                ActualizarListBoxDeProductos();
            }

        }

        /// <summary>
        /// Obtenemos el indice del producto seleccionado desde el listbox y retornamos el objeto producto desde la heladera
        /// </summary>
        /// <returns></returns>
        private Producto? ObtenerProductoDelListbox()
        {
            int indiceSeleccionado = lbx_ListadoDeProductos.SelectedIndex;

            if (indiceSeleccionado >= 0 )
            {
                return auxProducto = heladera.ListaProducto[indiceSeleccionado];               
            }
            return null;
        }

        /// <summary>
        /// en primera instancia actualizamos la lista desde el core del sistema solo la primera vez y una vez 
        /// que se realizan modificaciones en ejecucion obtenemos el listado actualizado desde la heladera
        /// </summary>
        private void ActualizarListBoxDeProductos()
        {
            lbx_ListadoDeProductos.DataSource = null;
            if (primeraCarga)
            {
                lbx_ListadoDeProductos.DataSource = CoreDelSistema.Productos;
                primeraCarga = false;
            }
            else
            {
                lbx_ListadoDeProductos.DataSource = heladera.ListaProducto;
            }
        }

        private void btn_VolverAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenuVendedor.Show();
        }
    }
}
