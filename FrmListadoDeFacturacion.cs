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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Media;

namespace VisualParcial1
{

    public partial class FrmListadoDeFacturacion : Form
    {
        List<Factura> listadoFacturas;

        private MenuVendedor frmMenuVendedor;

        private bool facturasSerializadasXml = false;
        private bool facturasSerializadasJson = false;
        public FrmListadoDeFacturacion(MenuVendedor frmMenuVendedor)
        {
            InitializeComponent();
            this.frmMenuVendedor = frmMenuVendedor;
            this.listadoFacturas = CoreDelSistema.Facturas;
        }


        private void FrmListadoDeFacturacion_Load(object sender, EventArgs e)
        {
            ActualizarFacturasDelDatagrid(listadoFacturas);
        }


        private void ActualizarFacturasDelDatagrid(List<Factura> facturas)
        {
            if (facturas == null || facturas.Count == 0)
            {
                // La lista de facturas es nula o está vacía, limpiar el DataGridView y salir
                dgv_ListadoDeFacturas.Rows.Clear();
                return;
            }

            dgv_ListadoDeFacturas.Rows.Clear();

            foreach (Factura factura in facturas)
            {
                int rowIndex = dgv_ListadoDeFacturas.Rows.Add();

                // Verificar si las columnas existen antes de asignar valores
                if (dgv_ListadoDeFacturas.Columns.Contains("numeroDeFactura"))
                {
                    dgv_ListadoDeFacturas.Rows[rowIndex].Cells["numeroDeFactura"].Value = factura.NumeroDeFactura.ToString();
                    dgv_ListadoDeFacturas.Rows[rowIndex].Cells["numeroDeFactura"].ReadOnly = true;
                }
                if (dgv_ListadoDeFacturas.Columns.Contains("fechaActual"))
                {
                    dgv_ListadoDeFacturas.Rows[rowIndex].Cells["fechaActual"].Value = factura.FechaActual.ToShortDateString();
                    dgv_ListadoDeFacturas.Rows[rowIndex].Cells["fechaActual"].ReadOnly = true;
                }
                if (dgv_ListadoDeFacturas.Columns.Contains("cliente"))
                {
                    dgv_ListadoDeFacturas.Rows[rowIndex].Cells["cliente"].Value = factura.Nombre;
                    dgv_ListadoDeFacturas.Rows[rowIndex].Cells["cliente"].ReadOnly = true;
                }
                if (dgv_ListadoDeFacturas.Columns.Contains("totalFactura"))
                {
                    // Verificar si el valor es numerico antes de formatearlo
                    if (float.TryParse(factura.TotalFactura.ToString(), out float totalFactura))
                    {
                        dgv_ListadoDeFacturas.Rows[rowIndex].Cells["totalFactura"].Value = totalFactura.ToString("N2");
                        dgv_ListadoDeFacturas.Rows[rowIndex].Cells["totalFactura"].ReadOnly = true;
                    }
                }
            }
            dgv_ListadoDeFacturas.ClearSelection();
            dgv_ListadoDeFacturas.CurrentCell = null;
        }

        private void btn_VolverAtras_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMenuVendedor.Show();
            SonidoVolverAtras();
        }
        private void SonidoVolverAtras()
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = @"C:\Users\Usuario\source\repos\Camejo.Esteban\VisualParcial1\bin\SoundEffectSuperMarioBrosDown.wav"; ; // Ruta del archivo de sonido
            player.Play();
        }

        private void btn_SerializarJson_Click(object sender, EventArgs e)
        {
            if (listadoFacturas != null)
            {
                try
                {
                    // Factura facturaSeralizarJson = new Factura();
                    //facturaSeralizarJson.SerializarJson(listadoFacturas);
                    CoreDelSistema.SerializarFacturasJson(listadoFacturas);
                    MessageBox.Show("La serialización en formato JSON se ha completado.");
                    facturasSerializadasJson = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al serializar en formato JSON. " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("La lista de facturas esta vacia. No se puede realizar la serializacion en formato JSON.");
            }
        }

        private void btn_DeserializarJson_Click(object sender, EventArgs e)
        {
            if (facturasSerializadasJson)
            {
                try
                {
                    listaProductosForm listaProductosForm = new listaProductosForm();
                    listaProductosForm.MostrarFacturasSerializados();
                    listaProductosForm.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al deserializar el JSON. " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Antes de deserializar Facturas en JSON, \ndebes presionar el boton 'Serializar XML'\nya que pudo haber actualizaciones en la base de datos.");
            }
        }

        private void btn_SerializarXml_Click(object sender, EventArgs e)
        {
            //if (listadoFacturas != null)
            //{
            //    try
            //    {
            //        Factura facturaSeralizarXml = new Factura();
            //        facturaSeralizarXml.SerializarXml(listadoFacturas);
            //        MessageBox.Show("La serialización en formato XML se ha completado.");
            //        facturasSerializadasXml = true;
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Error al serializar en formato XML. " + ex.Message);
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("La lista de facturas esta vacia. No se puede realizar la serializacion en formato XML.");
            //}
        }

        private void btn_DeserializarXml_Click(object sender, EventArgs e)
        {
            //if (facturasSerializadasXml)
            //{
            //    try
            //    {
            //        //Factura factura = new Factura();
            //        // string facturaDeserializar = factura.DeSerializarXml();

            //        listaProductosForm listaProductosForm = new listaProductosForm();
            //        //listaProductosForm.MostrarProductosSerializados(facturaDeserializar);
            //        listaProductosForm.ShowDialog();
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Error al deserializar el XML. " + ex.Message);
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Antes de deserializar Facturas en XML, \ndebes presionar el boton 'Serializar XML'\nya que pudo haber actualizaciones en la base de datos.");
            //}
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
