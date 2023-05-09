namespace VisualParcial1
{
    partial class FrmCompraVenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCompraVenta));
            cbb_SleccionProducto = new ComboBox();
            dtgv_Productos = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            PrecioPorKg = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Importe = new DataGridViewTextBoxColumn();
            lbl_ProductoSeleccionado = new Label();
            lbl_Cantidad = new Label();
            txb_CantKg = new TextBox();
            lbl_TotalProducto = new Label();
            btn_Agregar = new Button();
            btn_Quitar = new Button();
            btn_Comprar = new Button();
            lbl_SaldoDisponible = new Label();
            lbl_TotalApagar = new Label();
            lbl_NombreCliente = new Label();
            lbl_Cuit = new Label();
            lbl_Leyenda = new Label();
            lbl_TipoDePago = new Label();
            lbl_IvaProductoAgregado = new Label();
            btn_VolverAtras = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgv_Productos).BeginInit();
            SuspendLayout();
            // 
            // cbb_SleccionProducto
            // 
            cbb_SleccionProducto.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbb_SleccionProducto.FormattingEnabled = true;
            cbb_SleccionProducto.Location = new Point(298, 31);
            cbb_SleccionProducto.Margin = new Padding(4, 3, 4, 3);
            cbb_SleccionProducto.Name = "cbb_SleccionProducto";
            cbb_SleccionProducto.Size = new Size(218, 29);
            cbb_SleccionProducto.TabIndex = 0;
            cbb_SleccionProducto.SelectedIndexChanged += cbb_SleccionProducto_SelectedIndexChanged;
            // 
            // dtgv_Productos
            // 
            dtgv_Productos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_Productos.Columns.AddRange(new DataGridViewColumn[] { Nombre, PrecioPorKg, Cantidad, Importe });
            dtgv_Productos.Location = new Point(95, 317);
            dtgv_Productos.Margin = new Padding(4, 3, 4, 3);
            dtgv_Productos.Name = "dtgv_Productos";
            dtgv_Productos.RowHeadersWidth = 62;
            dtgv_Productos.RowTemplate.Height = 33;
            dtgv_Productos.Size = new Size(666, 226);
            dtgv_Productos.TabIndex = 1;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre de Producto";
            Nombre.MinimumWidth = 8;
            Nombre.Name = "Nombre";
            Nombre.Width = 150;
            // 
            // PrecioPorKg
            // 
            PrecioPorKg.HeaderText = "Precio Kg.";
            PrecioPorKg.MinimumWidth = 8;
            PrecioPorKg.Name = "PrecioPorKg";
            PrecioPorKg.Width = 150;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 8;
            Cantidad.Name = "Cantidad";
            Cantidad.Width = 150;
            // 
            // Importe
            // 
            Importe.HeaderText = "Importe";
            Importe.MinimumWidth = 8;
            Importe.Name = "Importe";
            Importe.Width = 150;
            // 
            // lbl_ProductoSeleccionado
            // 
            lbl_ProductoSeleccionado.AutoSize = true;
            lbl_ProductoSeleccionado.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_ProductoSeleccionado.Location = new Point(109, 34);
            lbl_ProductoSeleccionado.Margin = new Padding(4, 0, 4, 0);
            lbl_ProductoSeleccionado.Name = "lbl_ProductoSeleccionado";
            lbl_ProductoSeleccionado.Size = new Size(152, 21);
            lbl_ProductoSeleccionado.TabIndex = 2;
            lbl_ProductoSeleccionado.Text = "Selec. Producto:";
            // 
            // lbl_Cantidad
            // 
            lbl_Cantidad.AutoSize = true;
            lbl_Cantidad.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Cantidad.Location = new Point(109, 81);
            lbl_Cantidad.Margin = new Padding(4, 0, 4, 0);
            lbl_Cantidad.Name = "lbl_Cantidad";
            lbl_Cantidad.Size = new Size(126, 21);
            lbl_Cantidad.TabIndex = 3;
            lbl_Cantidad.Text = "Cantidad Kg.";
            // 
            // txb_CantKg
            // 
            txb_CantKg.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txb_CantKg.Location = new Point(298, 78);
            txb_CantKg.Margin = new Padding(4, 3, 4, 3);
            txb_CantKg.Name = "txb_CantKg";
            txb_CantKg.Size = new Size(218, 29);
            txb_CantKg.TabIndex = 4;
            // 
            // lbl_TotalProducto
            // 
            lbl_TotalProducto.AutoSize = true;
            lbl_TotalProducto.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_TotalProducto.Location = new Point(109, 129);
            lbl_TotalProducto.Margin = new Padding(4, 0, 4, 0);
            lbl_TotalProducto.Name = "lbl_TotalProducto";
            lbl_TotalProducto.Size = new Size(169, 21);
            lbl_TotalProducto.TabIndex = 6;
            lbl_TotalProducto.Text = "Total Producto: $ ";
            // 
            // btn_Agregar
            // 
            btn_Agregar.Location = new Point(298, 205);
            btn_Agregar.Margin = new Padding(4, 3, 4, 3);
            btn_Agregar.Name = "btn_Agregar";
            btn_Agregar.Size = new Size(218, 48);
            btn_Agregar.TabIndex = 7;
            btn_Agregar.Text = "Agregar";
            btn_Agregar.UseVisualStyleBackColor = true;
            btn_Agregar.Click += btn_Agregar_Click;
            // 
            // btn_Quitar
            // 
            btn_Quitar.Location = new Point(0, 0);
            btn_Quitar.Margin = new Padding(4, 3, 4, 3);
            btn_Quitar.Name = "btn_Quitar";
            btn_Quitar.Size = new Size(90, 19);
            btn_Quitar.TabIndex = 15;
            // 
            // btn_Comprar
            // 
            btn_Comprar.Location = new Point(797, 488);
            btn_Comprar.Margin = new Padding(4, 3, 4, 3);
            btn_Comprar.Name = "btn_Comprar";
            btn_Comprar.Size = new Size(261, 55);
            btn_Comprar.TabIndex = 9;
            btn_Comprar.Text = "Confirmar Compra";
            btn_Comprar.UseVisualStyleBackColor = true;
            btn_Comprar.Click += btn_Comprar_Click;
            // 
            // lbl_SaldoDisponible
            // 
            lbl_SaldoDisponible.AutoSize = true;
            lbl_SaldoDisponible.Font = new Font("Lucida Sans", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_SaldoDisponible.ForeColor = Color.SpringGreen;
            lbl_SaldoDisponible.Location = new Point(663, 161);
            lbl_SaldoDisponible.Margin = new Padding(4, 0, 4, 0);
            lbl_SaldoDisponible.Name = "lbl_SaldoDisponible";
            lbl_SaldoDisponible.Size = new Size(200, 23);
            lbl_SaldoDisponible.TabIndex = 10;
            lbl_SaldoDisponible.Text = "Saldo Disponible: ";
            // 
            // lbl_TotalApagar
            // 
            lbl_TotalApagar.AutoSize = true;
            lbl_TotalApagar.Font = new Font("Lucida Sans", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_TotalApagar.ForeColor = Color.Red;
            lbl_TotalApagar.Location = new Point(663, 193);
            lbl_TotalApagar.Margin = new Padding(4, 0, 4, 0);
            lbl_TotalApagar.Name = "lbl_TotalApagar";
            lbl_TotalApagar.Size = new Size(159, 23);
            lbl_TotalApagar.TabIndex = 11;
            lbl_TotalApagar.Text = "Total a Pagar: ";
            // 
            // lbl_NombreCliente
            // 
            lbl_NombreCliente.AutoSize = true;
            lbl_NombreCliente.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_NombreCliente.Location = new Point(663, 36);
            lbl_NombreCliente.Margin = new Padding(4, 0, 4, 0);
            lbl_NombreCliente.Name = "lbl_NombreCliente";
            lbl_NombreCliente.Size = new Size(95, 21);
            lbl_NombreCliente.TabIndex = 12;
            lbl_NombreCliente.Text = "Nombre: ";
            // 
            // lbl_Cuit
            // 
            lbl_Cuit.AutoSize = true;
            lbl_Cuit.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Cuit.Location = new Point(663, 67);
            lbl_Cuit.Margin = new Padding(4, 0, 4, 0);
            lbl_Cuit.Name = "lbl_Cuit";
            lbl_Cuit.Size = new Size(87, 21);
            lbl_Cuit.TabIndex = 13;
            lbl_Cuit.Text = "Nº CUIT:";
            // 
            // lbl_Leyenda
            // 
            lbl_Leyenda.AutoSize = true;
            lbl_Leyenda.Font = new Font("Lucida Sans", 8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lbl_Leyenda.Location = new Point(95, 283);
            lbl_Leyenda.Margin = new Padding(4, 0, 4, 0);
            lbl_Leyenda.Name = "lbl_Leyenda";
            lbl_Leyenda.Size = new Size(963, 18);
            lbl_Leyenda.TabIndex = 14;
            lbl_Leyenda.Text = "Recuerde, si selecciono abonar con Tarjeta de Credito su compra tendra un recargo del 5% en el saldo final de su Fact";
            // 
            // lbl_TipoDePago
            // 
            lbl_TipoDePago.AutoSize = true;
            lbl_TipoDePago.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_TipoDePago.Location = new Point(663, 97);
            lbl_TipoDePago.Margin = new Padding(4, 0, 4, 0);
            lbl_TipoDePago.Name = "lbl_TipoDePago";
            lbl_TipoDePago.Size = new Size(156, 21);
            lbl_TipoDePago.TabIndex = 16;
            lbl_TipoDePago.Text = "Tipo de Pago =>";
            // 
            // lbl_IvaProductoAgregado
            // 
            lbl_IvaProductoAgregado.AutoSize = true;
            lbl_IvaProductoAgregado.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_IvaProductoAgregado.Location = new Point(109, 161);
            lbl_IvaProductoAgregado.Margin = new Padding(4, 0, 4, 0);
            lbl_IvaProductoAgregado.Name = "lbl_IvaProductoAgregado";
            lbl_IvaProductoAgregado.Size = new Size(163, 21);
            lbl_IvaProductoAgregado.TabIndex = 17;
            lbl_IvaProductoAgregado.Text = "IVA Prod Selec: $";
            // 
            // btn_VolverAtras
            // 
            btn_VolverAtras.Location = new Point(797, 408);
            btn_VolverAtras.Margin = new Padding(4, 3, 4, 3);
            btn_VolverAtras.Name = "btn_VolverAtras";
            btn_VolverAtras.Size = new Size(261, 55);
            btn_VolverAtras.TabIndex = 18;
            btn_VolverAtras.Text = "Atras";
            btn_VolverAtras.UseVisualStyleBackColor = true;
            btn_VolverAtras.Click += btn_VolverAtras_Click;
            // 
            // FrmCompraVenta
            // 
            AutoScaleDimensions = new SizeF(12F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1132, 578);
            Controls.Add(btn_VolverAtras);
            Controls.Add(lbl_IvaProductoAgregado);
            Controls.Add(lbl_TipoDePago);
            Controls.Add(lbl_Leyenda);
            Controls.Add(lbl_Cuit);
            Controls.Add(lbl_NombreCliente);
            Controls.Add(lbl_TotalApagar);
            Controls.Add(lbl_SaldoDisponible);
            Controls.Add(btn_Comprar);
            Controls.Add(btn_Quitar);
            Controls.Add(btn_Agregar);
            Controls.Add(lbl_TotalProducto);
            Controls.Add(txb_CantKg);
            Controls.Add(lbl_Cantidad);
            Controls.Add(lbl_ProductoSeleccionado);
            Controls.Add(dtgv_Productos);
            Controls.Add(cbb_SleccionProducto);
            Font = new Font("Lucida Fax", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmCompraVenta";
            Text = "Compra - Venta";
            Load += FrmCompraVenta_Load;
            ((System.ComponentModel.ISupportInitialize)dtgv_Productos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbb_SleccionProducto;
        private DataGridView dtgv_Productos;
        private Label lbl_ProductoSeleccionado;
        private Label lbl_Cantidad;
        private TextBox txb_CantKg;
        private Label lbl_TotalProducto;
        private Button btn_Agregar;
        private Button btn_Quitar;
        private Button btn_Comprar;
        private Label lbl_SaldoDisponible;
        private Label lbl_TotalApagar;
        private Label lbl_NombreCliente;
        private Label lbl_Cuit;
        private Label lbl_Leyenda;
        private Label lbl_TipoDePago;
        private Label lbl_IvaProductoAgregado;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn PrecioPorKg;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Importe;
        private Button btn_VolverAtras;
    }
}