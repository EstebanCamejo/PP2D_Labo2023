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
            cantidadDeKilos = new DataGridViewTextBoxColumn();
            PrecioPorKg = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Importe = new DataGridViewTextBoxColumn();
            lbl_ProductoSeleccionado = new Label();
            lbl_Cantidad = new Label();
            txb_CantKg = new TextBox();
            lbl_TotalProducto = new Label();
            btn_Agregar = new Button();
            btn_Comprar = new Button();
            lbl_TotalApagar = new Label();
            lbl_NombreCliente = new Label();
            lbl_Cuit = new Label();
            lbl_TipoDePago = new Label();
            lbl_IvaProductoAgregado = new Label();
            btn_VolverAtras = new Button();
            lbl_SeleccionarCliente = new Label();
            cbb_SeleccionarCliente = new ComboBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            label1 = new Label();
            lbl_TopeMaximo = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgv_Productos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // cbb_SleccionProducto
            // 
            cbb_SleccionProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cbb_SleccionProducto.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbb_SleccionProducto.FormattingEnabled = true;
            cbb_SleccionProducto.Location = new Point(295, 206);
            cbb_SleccionProducto.Margin = new Padding(4, 3, 4, 3);
            cbb_SleccionProducto.Name = "cbb_SleccionProducto";
            cbb_SleccionProducto.Size = new Size(218, 29);
            cbb_SleccionProducto.TabIndex = 0;
            cbb_SleccionProducto.SelectedIndexChanged += cbb_SleccionProducto_SelectedIndexChanged;
            // 
            // dtgv_Productos
            // 
            dtgv_Productos.AllowDrop = true;
            dtgv_Productos.AllowUserToAddRows = false;
            dtgv_Productos.AllowUserToDeleteRows = false;
            dtgv_Productos.AllowUserToOrderColumns = true;
            dtgv_Productos.AllowUserToResizeColumns = false;
            dtgv_Productos.AllowUserToResizeRows = false;
            dtgv_Productos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_Productos.Columns.AddRange(new DataGridViewColumn[] { Nombre, cantidadDeKilos, PrecioPorKg, Cantidad, Importe });
            dtgv_Productos.Location = new Point(72, 366);
            dtgv_Productos.Margin = new Padding(4, 3, 4, 3);
            dtgv_Productos.Name = "dtgv_Productos";
            dtgv_Productos.ReadOnly = true;
            dtgv_Productos.RowHeadersWidth = 5;
            dtgv_Productos.RowTemplate.Height = 33;
            dtgv_Productos.Size = new Size(908, 280);
            dtgv_Productos.TabIndex = 1;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre de Producto";
            Nombre.MinimumWidth = 8;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 300;
            // 
            // cantidadDeKilos
            // 
            cantidadDeKilos.HeaderText = "Stock";
            cantidadDeKilos.MinimumWidth = 8;
            cantidadDeKilos.Name = "cantidadDeKilos";
            cantidadDeKilos.ReadOnly = true;
            cantidadDeKilos.Width = 150;
            // 
            // PrecioPorKg
            // 
            PrecioPorKg.HeaderText = "P. Kg.";
            PrecioPorKg.MinimumWidth = 8;
            PrecioPorKg.Name = "PrecioPorKg";
            PrecioPorKg.ReadOnly = true;
            PrecioPorKg.Width = 150;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 8;
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            Cantidad.Width = 150;
            // 
            // Importe
            // 
            Importe.HeaderText = "Importe";
            Importe.MinimumWidth = 8;
            Importe.Name = "Importe";
            Importe.ReadOnly = true;
            Importe.Width = 150;
            // 
            // lbl_ProductoSeleccionado
            // 
            lbl_ProductoSeleccionado.AutoSize = true;
            lbl_ProductoSeleccionado.Font = new Font("Lucida Sans", 8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_ProductoSeleccionado.ForeColor = SystemColors.MenuBar;
            lbl_ProductoSeleccionado.Location = new Point(106, 209);
            lbl_ProductoSeleccionado.Margin = new Padding(4, 0, 4, 0);
            lbl_ProductoSeleccionado.Name = "lbl_ProductoSeleccionado";
            lbl_ProductoSeleccionado.Size = new Size(138, 18);
            lbl_ProductoSeleccionado.TabIndex = 2;
            lbl_ProductoSeleccionado.Text = "Selec. Producto:";
            // 
            // lbl_Cantidad
            // 
            lbl_Cantidad.AutoSize = true;
            lbl_Cantidad.Font = new Font("Lucida Sans", 8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Cantidad.ForeColor = SystemColors.MenuBar;
            lbl_Cantidad.Location = new Point(106, 256);
            lbl_Cantidad.Margin = new Padding(4, 0, 4, 0);
            lbl_Cantidad.Name = "lbl_Cantidad";
            lbl_Cantidad.Size = new Size(111, 18);
            lbl_Cantidad.TabIndex = 3;
            lbl_Cantidad.Text = "Cantidad Kg.";
            // 
            // txb_CantKg
            // 
            txb_CantKg.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txb_CantKg.Location = new Point(295, 253);
            txb_CantKg.Margin = new Padding(4, 3, 4, 3);
            txb_CantKg.Name = "txb_CantKg";
            txb_CantKg.Size = new Size(218, 29);
            txb_CantKg.TabIndex = 4;
            // 
            // lbl_TotalProducto
            // 
            lbl_TotalProducto.AutoSize = true;
            lbl_TotalProducto.Font = new Font("Lucida Sans", 8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_TotalProducto.ForeColor = SystemColors.MenuBar;
            lbl_TotalProducto.Location = new Point(595, 206);
            lbl_TotalProducto.Margin = new Padding(4, 0, 4, 0);
            lbl_TotalProducto.Name = "lbl_TotalProducto";
            lbl_TotalProducto.Size = new Size(153, 18);
            lbl_TotalProducto.TabIndex = 6;
            lbl_TotalProducto.Text = "Total Producto: $ ";
            // 
            // btn_Agregar
            // 
            btn_Agregar.BackColor = SystemColors.MenuBar;
            btn_Agregar.Font = new Font("Lucida Fax", 8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Agregar.Location = new Point(295, 300);
            btn_Agregar.Margin = new Padding(4, 3, 4, 3);
            btn_Agregar.Name = "btn_Agregar";
            btn_Agregar.Size = new Size(218, 48);
            btn_Agregar.TabIndex = 7;
            btn_Agregar.Text = "       Agregar";
            btn_Agregar.UseVisualStyleBackColor = false;
            btn_Agregar.Click += btn_Agregar_Click;
            btn_Agregar.MouseEnter += btn_Agregar_MouseEnter;
            btn_Agregar.MouseLeave += btn_Agregar_MouseLeave;
            // 
            // btn_Comprar
            // 
            btn_Comprar.BackColor = SystemColors.MenuBar;
            btn_Comprar.Font = new Font("Lucida Fax", 8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Comprar.Location = new Point(731, 668);
            btn_Comprar.Margin = new Padding(4, 3, 4, 3);
            btn_Comprar.Name = "btn_Comprar";
            btn_Comprar.Size = new Size(261, 55);
            btn_Comprar.TabIndex = 9;
            btn_Comprar.Text = "     Facturar";
            btn_Comprar.UseVisualStyleBackColor = false;
            btn_Comprar.Click += btn_Comprar_Click;
            btn_Comprar.MouseEnter += btn_Comprar_MouseEnter;
            btn_Comprar.MouseLeave += btn_Comprar_MouseLeave;
            // 
            // lbl_TotalApagar
            // 
            lbl_TotalApagar.AutoSize = true;
            lbl_TotalApagar.Font = new Font("Lucida Sans", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_TotalApagar.ForeColor = Color.Red;
            lbl_TotalApagar.Location = new Point(595, 311);
            lbl_TotalApagar.Margin = new Padding(4, 0, 4, 0);
            lbl_TotalApagar.Name = "lbl_TotalApagar";
            lbl_TotalApagar.Size = new Size(159, 23);
            lbl_TotalApagar.TabIndex = 11;
            lbl_TotalApagar.Text = "Total a Pagar: ";
            // 
            // lbl_NombreCliente
            // 
            lbl_NombreCliente.AutoSize = true;
            lbl_NombreCliente.Font = new Font("Lucida Sans", 8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_NombreCliente.ForeColor = SystemColors.MenuBar;
            lbl_NombreCliente.Location = new Point(595, 44);
            lbl_NombreCliente.Margin = new Padding(4, 0, 4, 0);
            lbl_NombreCliente.Name = "lbl_NombreCliente";
            lbl_NombreCliente.Size = new Size(81, 18);
            lbl_NombreCliente.TabIndex = 12;
            lbl_NombreCliente.Text = "Nombre: ";
            // 
            // lbl_Cuit
            // 
            lbl_Cuit.AutoSize = true;
            lbl_Cuit.Font = new Font("Lucida Sans", 8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Cuit.ForeColor = SystemColors.MenuBar;
            lbl_Cuit.Location = new Point(595, 77);
            lbl_Cuit.Margin = new Padding(4, 0, 4, 0);
            lbl_Cuit.Name = "lbl_Cuit";
            lbl_Cuit.Size = new Size(78, 18);
            lbl_Cuit.TabIndex = 13;
            lbl_Cuit.Text = "Nº CUIT:";
            // 
            // lbl_TipoDePago
            // 
            lbl_TipoDePago.AutoSize = true;
            lbl_TipoDePago.Font = new Font("Lucida Sans", 8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_TipoDePago.ForeColor = SystemColors.MenuBar;
            lbl_TipoDePago.Location = new Point(595, 111);
            lbl_TipoDePago.Margin = new Padding(4, 0, 4, 0);
            lbl_TipoDePago.Name = "lbl_TipoDePago";
            lbl_TipoDePago.Size = new Size(139, 18);
            lbl_TipoDePago.TabIndex = 16;
            lbl_TipoDePago.Text = "Tipo de Pago =>";
            // 
            // lbl_IvaProductoAgregado
            // 
            lbl_IvaProductoAgregado.AutoSize = true;
            lbl_IvaProductoAgregado.Font = new Font("Lucida Sans", 8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_IvaProductoAgregado.ForeColor = SystemColors.MenuBar;
            lbl_IvaProductoAgregado.Location = new Point(595, 256);
            lbl_IvaProductoAgregado.Margin = new Padding(4, 0, 4, 0);
            lbl_IvaProductoAgregado.Name = "lbl_IvaProductoAgregado";
            lbl_IvaProductoAgregado.Size = new Size(145, 18);
            lbl_IvaProductoAgregado.TabIndex = 17;
            lbl_IvaProductoAgregado.Text = "IVA Prod Selec: $";
            // 
            // btn_VolverAtras
            // 
            btn_VolverAtras.BackColor = SystemColors.MenuBar;
            btn_VolverAtras.Font = new Font("Lucida Fax", 8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_VolverAtras.Location = new Point(59, 668);
            btn_VolverAtras.Margin = new Padding(4, 3, 4, 3);
            btn_VolverAtras.Name = "btn_VolverAtras";
            btn_VolverAtras.Size = new Size(261, 55);
            btn_VolverAtras.TabIndex = 18;
            btn_VolverAtras.Text = "Atras";
            btn_VolverAtras.UseVisualStyleBackColor = false;
            btn_VolverAtras.Click += btn_VolverAtras_Click_1;
            btn_VolverAtras.MouseEnter += btn_VolverAtras_MouseEnter;
            btn_VolverAtras.MouseLeave += btn_VolverAtras_MouseLeave;
            // 
            // lbl_SeleccionarCliente
            // 
            lbl_SeleccionarCliente.AutoSize = true;
            lbl_SeleccionarCliente.Font = new Font("Lucida Fax", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_SeleccionarCliente.ForeColor = SystemColors.MenuBar;
            lbl_SeleccionarCliente.Location = new Point(95, 36);
            lbl_SeleccionarCliente.Name = "lbl_SeleccionarCliente";
            lbl_SeleccionarCliente.Size = new Size(200, 21);
            lbl_SeleccionarCliente.TabIndex = 19;
            lbl_SeleccionarCliente.Text = "Selecionar Cliente : ";
            // 
            // cbb_SeleccionarCliente
            // 
            cbb_SeleccionarCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cbb_SeleccionarCliente.FormattingEnabled = true;
            cbb_SeleccionarCliente.Location = new Point(295, 33);
            cbb_SeleccionarCliente.Name = "cbb_SeleccionarCliente";
            cbb_SeleccionarCliente.Size = new Size(218, 29);
            cbb_SeleccionarCliente.TabIndex = 20;
            cbb_SeleccionarCliente.SelectedIndexChanged += cbb_SeleccionarCliente_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.MenuBar;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(330, 305);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(47, 37);
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.MenuBar;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(780, 680);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(41, 35);
            pictureBox2.TabIndex = 22;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.ControlText;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(360, 68);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(121, 106);
            pictureBox3.TabIndex = 23;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(519, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(528, 762);
            pictureBox4.TabIndex = 24;
            pictureBox4.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.MenuBar;
            label1.Location = new Point(330, 168);
            label1.Name = "label1";
            label1.Size = new Size(151, 21);
            label1.TabIndex = 25;
            label1.Text = "FM Carnes SRL";
            // 
            // lbl_TopeMaximo
            // 
            lbl_TopeMaximo.AutoSize = true;
            lbl_TopeMaximo.Font = new Font("Lucida Sans", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_TopeMaximo.ForeColor = Color.Lime;
            lbl_TopeMaximo.Location = new Point(595, 146);
            lbl_TopeMaximo.Name = "lbl_TopeMaximo";
            lbl_TopeMaximo.Size = new Size(168, 23);
            lbl_TopeMaximo.TabIndex = 26;
            lbl_TopeMaximo.Text = "Tope Maximo:  ";
            // 
            // FrmCompraVenta
            // 
            AutoScaleDimensions = new SizeF(12F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlText;
            ClientSize = new Size(1041, 747);
            Controls.Add(lbl_TopeMaximo);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(cbb_SeleccionarCliente);
            Controls.Add(lbl_SeleccionarCliente);
            Controls.Add(btn_VolverAtras);
            Controls.Add(lbl_IvaProductoAgregado);
            Controls.Add(lbl_TipoDePago);
            Controls.Add(lbl_Cuit);
            Controls.Add(lbl_NombreCliente);
            Controls.Add(lbl_TotalApagar);
            Controls.Add(btn_Comprar);
            Controls.Add(btn_Agregar);
            Controls.Add(lbl_TotalProducto);
            Controls.Add(txb_CantKg);
            Controls.Add(lbl_Cantidad);
            Controls.Add(lbl_ProductoSeleccionado);
            Controls.Add(dtgv_Productos);
            Controls.Add(cbb_SleccionProducto);
            Controls.Add(pictureBox4);
            Font = new Font("Lucida Fax", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmCompraVenta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Compra - Venta";
            Load += FrmCompraVenta_Load;
            ((System.ComponentModel.ISupportInitialize)dtgv_Productos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
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
        private Button btn_Comprar;
        private Label lbl_TotalApagar;
        private Label lbl_NombreCliente;
        private Label lbl_Cuit;
        private Label lbl_TipoDePago;
        private Label lbl_IvaProductoAgregado;
        private Button btn_VolverAtras;
        private Label lbl_SeleccionarCliente;
        private ComboBox cbb_SeleccionarCliente;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn cantidadDeKilos;
        private DataGridViewTextBoxColumn PrecioPorKg;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Importe;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label label1;
        private Label lbl_TopeMaximo;
    }
}