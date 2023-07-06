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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VisualParcial1
{
    public partial class AbmHeladera : Form
    {
        Heladera heladera;
        Producto auxProducto;
        bool primeraCarga;
        private MenuVendedor frmMenuVendedor;
        int indiceSeleccionado = -1;
        private ISerializadora<Producto> serializadora;
        private bool productosSerializadosJson;
        private bool productosSerializadosXml;
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

            productosSerializadosJson = false;
            productosSerializadosXml = false;
           
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
            try
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

                        ProductoBD.Modificar(productoCopia);
                        heladera.ListaProducto = ProductoBD.Leer();// ir a buscar el core
                        CoreDelSistema.ActualizarListaDeProductos(heladera.ListaProducto);

                        ActualizarDataGrid(heladera);
                        MessageBox.Show($"El producto {productoCopia.Nombre} se ha actualizado correctamente.");
                        SonidoAbmOK();
                        ActualizarDataGrid(heladera);

                        productosSerializadosJson = false;
                        productosSerializadosXml = false;
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
            catch (Exception ex) 
            {
                MessageBox.Show("Se produjo un error durante la edición del producto. " + ex.Message);
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
            try
            {
                FrmAltaProducto frmAltaProducto = new FrmAltaProducto(this);

                DialogResult resltado = frmAltaProducto.ShowDialog();

                if (resltado == DialogResult.OK)
                {

                    heladera.AgregarProductoALista(frmAltaProducto.ProductoAlta);

                    try
                    {
                        if (!ProductoBD.GuardarProducto(heladera.ListaProducto))
                        {
                            throw new falloGuardarProductoException("Error al guardar el producto en la base de datos.");
                        }
                        //CoreDelSistema.GuardarNuevoProducto(frmAltaProducto.ProductoAlta);
                        MessageBox.Show($"El producto {frmAltaProducto.ProductoAlta.Nombre} ha sido creado exitosamente");
                        SonidoAbmOK();

                        heladera.ListaProducto = ProductoBD.Leer();
                        ActualizarDataGrid(heladera);


                        productosSerializadosJson = false;
                        productosSerializadosXml = false;
                    }
                    catch (falloGuardarProductoException ex)
                    {
                        MessageBox.Show("EL producto no se guardo en la base de datos." + ex.Message);                        
                    }
                }
                else if (resltado == DialogResult.No)
                {
                    MessageBox.Show("El producto no se ha creado.");
                    SonidoError();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error al crear el producto. " + ex.Message);
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
            try
            {
                Producto? productoBaja = ObtenerProductoDelDataGrid();

                if (productoBaja != null)
                {
                    ProductoBD.Eliminar(productoBaja);
                    heladera.ListaProducto.Remove(productoBaja);

                    heladera.ListaProducto = ProductoBD.Leer();// ir a buscar el core
                    CoreDelSistema.ActualizarListaDeProductos(heladera.ListaProducto);

                    ActualizarDataGrid(heladera);
                    MessageBox.Show("El siguiente producto se ha dado de baja: " + productoBaja.Nombre);
                    SonidoAbmOK();

                    productosSerializadosJson = false;
                    productosSerializadosXml = false;
                }
                else
                {
                    MessageBox.Show("Para continuar con la baja \ndebe seleccionar un producto.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error al dar de baja el producto. " + ex.Message);
            }
        }

        /// <summary>
        /// Obtenemos el indice del producto seleccionado desde el listbox y retornamos el objeto producto desde la heladera
        /// </summary>
        /// <returns></returns>
        private Producto? ObtenerProductoDelDataGrid()
        {            
            try
            {
                if (indiceSeleccionado >= 0 && indiceSeleccionado < heladera.ListaProducto.Count)
                {
                    return auxProducto = heladera.ListaProducto[indiceSeleccionado];
                }
                else
                {
                    MessageBox.Show("No se ha seleccionado un producto valido.");
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error al obtener el producto del DataGrid. " + ex.Message);
                return null;
            }
        }

        private void btn_VolverAtras_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMenuVendedor.Show();
            SonidoVolverAtras();
        }

        private void ActualizarDataGrid(Heladera heladera)
        {
            try
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
            catch (Exception ex) 
            {
                MessageBox.Show("Se produjo un error al actualizar el DataGrid. " + ex.Message);
            }
        }

        private void dtgv_StockHeladera_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    indiceSeleccionado = e.RowIndex;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error al procesar el evento CellClick. " + ex.Message);
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

        private void btn_SerializarJson_Click(object sender, EventArgs e)
        {
            try
            {
                Producto productoSeralizarJson = new Producto();
                List<Producto> listaProductos = heladera.ListaProducto = ProductoBD.Leer();
                productoSeralizarJson.SerializarJson(listaProductos);
                MessageBox.Show("La serialización en formato JSON se ha completado.");

                // Habilitar los botones de deserializacion
                productosSerializadosJson = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error durante la serialización en formato JSON. " + ex.Message);
            }
        }

        private void btn_DeSerializarJson_Click(object sender, EventArgs e)
        {
            try
            {
                if (productosSerializadosJson)
                {
                    Producto producto = new Producto();
                    string productoDeserializar = producto.DeSerializarJson();
                    listaProductosForm listaProductosForm = new listaProductosForm();
                    listaProductosForm.MostrarProductosSerializados(productoDeserializar);
                    listaProductosForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Antes de deserializar los productos en JSON, \ndebes presionar el boton 'Serializar Json' \nya que pudo haber actualizaciones en la base de datos.");
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Se produjo un error durante la deserializacion en formato JSON. " + ex.Message);
            }
        }


        private void btn_SerializarXml_Click(object sender, EventArgs e)
        {
            try
            {
                Producto productoSeralizarXml = new Producto();
                List<Producto> listaProductos = heladera.ListaProducto = ProductoBD.Leer();
                productoSeralizarXml.SerializarXml(listaProductos);
                MessageBox.Show("La serialización en formato XML se ha completado.");

                // Habilitar los botones de deserializacion
                productosSerializadosXml = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error durante la serializacion en formato XML. " + ex.Message);
            }
        }


        private void btn_DeSerializarXml_Click(object sender, EventArgs e)
        {
            try
            {
                if (productosSerializadosXml)
                {
                    Producto producto = new Producto();
                    string productoDeserializar = producto.DeSerializarXml();

                    listaProductosForm listaProductosForm = new listaProductosForm();
                    listaProductosForm.MostrarProductosSerializados(productoDeserializar);
                    listaProductosForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Antes de deserializar los productos en XML, \ndebes presionar el boton 'Serializar XML'\nya que pudo haber actualizaciones en la base de datos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error durante la deserializacion en formato XML. " + ex.Message);
            }
        }

        public bool RecargarProductoEnFormularioVendedor(Producto productoRecargarStock)
        {
            bool retorno = false;
            try
            {
                if (productoRecargarStock != null)
                {
                    Producto productoCopia = productoRecargarStock;

                    FrmAltaProducto frmEditarProducto = new FrmAltaProducto(productoCopia, this);

                    DialogResult resltado = frmEditarProducto.ShowDialog();

                    if (resltado == DialogResult.OK)
                    {
                        ProductoBD.Modificar(productoCopia);
                        MessageBox.Show($"El producto {productoCopia.Nombre} se ha actualizado correctamente.");
                        SonidoAbmOK();

                        retorno = true;
                    }
                    else if (resltado == DialogResult.No)
                    {
                        MessageBox.Show("El producto no ha sido actualizado.");
                        SonidoError();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error durante la recarga del producto. " + ex.Message);
            }
            return retorno;
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
