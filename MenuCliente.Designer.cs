namespace VisualParcial1
{
    partial class MenuCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuCliente));
            lbl_LeyendaMCliente = new Label();
            lbl_NombreCliente = new Label();
            lbl_ApellidoCliente = new Label();
            lbl_CuitCliente = new Label();
            lbl_BilleteraCliente = new Label();
            lbl_MedioDePagoCliente = new Label();
            txb_Nombre = new TextBox();
            txb_Apellido = new TextBox();
            txb_Cuit = new TextBox();
            txb_MontoAGastar = new TextBox();
            btn_RegistroDeDatos = new Button();
            cbb_MedioDePago = new ComboBox();
            dgv_Heladera = new DataGridView();
            TipoProducto = new DataGridViewTextBoxColumn();
            NombreProducto = new DataGridViewTextBoxColumn();
            PrecioPorKg = new DataGridViewTextBoxColumn();
            CantidadKgDisponibles = new DataGridViewTextBoxColumn();
            CantidadSolicitada = new DataGridViewTextBoxColumn();
            lbl_SaldoDisponible = new Label();
            lbl_TotalApagar = new Label();
            btn_Comprar = new Button();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgv_Heladera).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lbl_LeyendaMCliente
            // 
            lbl_LeyendaMCliente.AutoSize = true;
            lbl_LeyendaMCliente.Font = new Font("Lucida Sans", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_LeyendaMCliente.ForeColor = SystemColors.MenuBar;
            lbl_LeyendaMCliente.Location = new Point(48, 164);
            lbl_LeyendaMCliente.Margin = new Padding(4, 0, 4, 0);
            lbl_LeyendaMCliente.Name = "lbl_LeyendaMCliente";
            lbl_LeyendaMCliente.Size = new Size(781, 23);
            lbl_LeyendaMCliente.TabIndex = 1;
            lbl_LeyendaMCliente.Text = "Antes de continuar con su pedido, por favor complete los datos de facturacion";
            // 
            // lbl_NombreCliente
            // 
            lbl_NombreCliente.AutoSize = true;
            lbl_NombreCliente.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_NombreCliente.ForeColor = SystemColors.MenuBar;
            lbl_NombreCliente.Location = new Point(48, 235);
            lbl_NombreCliente.Margin = new Padding(4, 0, 4, 0);
            lbl_NombreCliente.Name = "lbl_NombreCliente";
            lbl_NombreCliente.Size = new Size(89, 21);
            lbl_NombreCliente.TabIndex = 2;
            lbl_NombreCliente.Text = "Nombre:";
            // 
            // lbl_ApellidoCliente
            // 
            lbl_ApellidoCliente.AutoSize = true;
            lbl_ApellidoCliente.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_ApellidoCliente.ForeColor = SystemColors.MenuBar;
            lbl_ApellidoCliente.Location = new Point(50, 276);
            lbl_ApellidoCliente.Margin = new Padding(4, 0, 4, 0);
            lbl_ApellidoCliente.Name = "lbl_ApellidoCliente";
            lbl_ApellidoCliente.Size = new Size(92, 21);
            lbl_ApellidoCliente.TabIndex = 3;
            lbl_ApellidoCliente.Text = "Apellido:";
            // 
            // lbl_CuitCliente
            // 
            lbl_CuitCliente.AutoSize = true;
            lbl_CuitCliente.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_CuitCliente.ForeColor = SystemColors.MenuBar;
            lbl_CuitCliente.Location = new Point(50, 316);
            lbl_CuitCliente.Margin = new Padding(4, 0, 4, 0);
            lbl_CuitCliente.Name = "lbl_CuitCliente";
            lbl_CuitCliente.Size = new Size(87, 21);
            lbl_CuitCliente.TabIndex = 4;
            lbl_CuitCliente.Text = "Nº CUIT:";
            // 
            // lbl_BilleteraCliente
            // 
            lbl_BilleteraCliente.AutoSize = true;
            lbl_BilleteraCliente.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_BilleteraCliente.ForeColor = SystemColors.MenuBar;
            lbl_BilleteraCliente.Location = new Point(441, 230);
            lbl_BilleteraCliente.Margin = new Padding(4, 0, 4, 0);
            lbl_BilleteraCliente.Name = "lbl_BilleteraCliente";
            lbl_BilleteraCliente.Size = new Size(165, 21);
            lbl_BilleteraCliente.TabIndex = 6;
            lbl_BilleteraCliente.Text = "Maximo a Gastar:";
            // 
            // lbl_MedioDePagoCliente
            // 
            lbl_MedioDePagoCliente.AutoSize = true;
            lbl_MedioDePagoCliente.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_MedioDePagoCliente.ForeColor = SystemColors.MenuBar;
            lbl_MedioDePagoCliente.Location = new Point(441, 269);
            lbl_MedioDePagoCliente.Margin = new Padding(4, 0, 4, 0);
            lbl_MedioDePagoCliente.Name = "lbl_MedioDePagoCliente";
            lbl_MedioDePagoCliente.Size = new Size(149, 21);
            lbl_MedioDePagoCliente.TabIndex = 7;
            lbl_MedioDePagoCliente.Text = "Medio de Pago:";
            // 
            // txb_Nombre
            // 
            txb_Nombre.Location = new Point(158, 230);
            txb_Nombre.Margin = new Padding(4, 3, 4, 3);
            txb_Nombre.Name = "txb_Nombre";
            txb_Nombre.Size = new Size(181, 29);
            txb_Nombre.TabIndex = 8;
            // 
            // txb_Apellido
            // 
            txb_Apellido.Location = new Point(158, 271);
            txb_Apellido.Margin = new Padding(4, 3, 4, 3);
            txb_Apellido.Name = "txb_Apellido";
            txb_Apellido.Size = new Size(181, 29);
            txb_Apellido.TabIndex = 9;
            // 
            // txb_Cuit
            // 
            txb_Cuit.Location = new Point(158, 311);
            txb_Cuit.Margin = new Padding(4, 3, 4, 3);
            txb_Cuit.Name = "txb_Cuit";
            txb_Cuit.Size = new Size(181, 29);
            txb_Cuit.TabIndex = 10;
            // 
            // txb_MontoAGastar
            // 
            txb_MontoAGastar.Location = new Point(625, 225);
            txb_MontoAGastar.Margin = new Padding(4, 3, 4, 3);
            txb_MontoAGastar.Name = "txb_MontoAGastar";
            txb_MontoAGastar.Size = new Size(204, 29);
            txb_MontoAGastar.TabIndex = 12;
            // 
            // btn_RegistroDeDatos
            // 
            btn_RegistroDeDatos.Font = new Font("Lucida Sans", 8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_RegistroDeDatos.Location = new Point(625, 307);
            btn_RegistroDeDatos.Margin = new Padding(4, 3, 4, 3);
            btn_RegistroDeDatos.Name = "btn_RegistroDeDatos";
            btn_RegistroDeDatos.Size = new Size(204, 35);
            btn_RegistroDeDatos.TabIndex = 14;
            btn_RegistroDeDatos.Text = "Registro de Datos";
            btn_RegistroDeDatos.UseVisualStyleBackColor = true;
            btn_RegistroDeDatos.Click += btn_RegistroDeDatos_Click;
            // 
            // cbb_MedioDePago
            // 
            cbb_MedioDePago.FormattingEnabled = true;
            cbb_MedioDePago.Location = new Point(625, 266);
            cbb_MedioDePago.Margin = new Padding(4, 3, 4, 3);
            cbb_MedioDePago.Name = "cbb_MedioDePago";
            cbb_MedioDePago.Size = new Size(204, 29);
            cbb_MedioDePago.TabIndex = 15;
            // 
            // dgv_Heladera
            // 
            dgv_Heladera.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Heladera.Columns.AddRange(new DataGridViewColumn[] { TipoProducto, NombreProducto, PrecioPorKg, CantidadKgDisponibles, CantidadSolicitada });
            dgv_Heladera.Location = new Point(32, 413);
            dgv_Heladera.Name = "dgv_Heladera";
            dgv_Heladera.RowHeadersWidth = 62;
            dgv_Heladera.RowTemplate.Height = 33;
            dgv_Heladera.Size = new Size(809, 225);
            dgv_Heladera.TabIndex = 16;
            dgv_Heladera.CellEndEdit += dgv_Heladera_CellEndEdit;
            // 
            // TipoProducto
            // 
            TipoProducto.HeaderText = "Tipo";
            TipoProducto.MinimumWidth = 8;
            TipoProducto.Name = "TipoProducto";
            TipoProducto.Width = 150;
            // 
            // NombreProducto
            // 
            NombreProducto.HeaderText = "Nombre";
            NombreProducto.MinimumWidth = 8;
            NombreProducto.Name = "NombreProducto";
            NombreProducto.Width = 150;
            // 
            // PrecioPorKg
            // 
            PrecioPorKg.HeaderText = "Precio Kg";
            PrecioPorKg.MinimumWidth = 8;
            PrecioPorKg.Name = "PrecioPorKg";
            PrecioPorKg.Width = 150;
            // 
            // CantidadKgDisponibles
            // 
            CantidadKgDisponibles.HeaderText = "Stock Kg";
            CantidadKgDisponibles.MinimumWidth = 8;
            CantidadKgDisponibles.Name = "CantidadKgDisponibles";
            CantidadKgDisponibles.Width = 150;
            // 
            // CantidadSolicitada
            // 
            CantidadSolicitada.HeaderText = "Cantidad";
            CantidadSolicitada.MinimumWidth = 8;
            CantidadSolicitada.Name = "CantidadSolicitada";
            CantidadSolicitada.Width = 150;
            // 
            // lbl_SaldoDisponible
            // 
            lbl_SaldoDisponible.AutoSize = true;
            lbl_SaldoDisponible.Font = new Font("Lucida Sans", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_SaldoDisponible.ForeColor = Color.Red;
            lbl_SaldoDisponible.Location = new Point(693, 370);
            lbl_SaldoDisponible.Name = "lbl_SaldoDisponible";
            lbl_SaldoDisponible.Size = new Size(22, 21);
            lbl_SaldoDisponible.TabIndex = 17;
            lbl_SaldoDisponible.Text = "0";
            // 
            // lbl_TotalApagar
            // 
            lbl_TotalApagar.AutoSize = true;
            lbl_TotalApagar.Font = new Font("Lucida Sans", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_TotalApagar.ForeColor = Color.Blue;
            lbl_TotalApagar.Location = new Point(281, 370);
            lbl_TotalApagar.Name = "lbl_TotalApagar";
            lbl_TotalApagar.Size = new Size(22, 21);
            lbl_TotalApagar.TabIndex = 18;
            lbl_TotalApagar.Text = "0";
            // 
            // btn_Comprar
            // 
            btn_Comprar.Font = new Font("Lucida Sans", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Comprar.Location = new Point(348, 653);
            btn_Comprar.Name = "btn_Comprar";
            btn_Comprar.Size = new Size(191, 60);
            btn_Comprar.TabIndex = 19;
            btn_Comprar.Text = "      Comprar";
            btn_Comprar.UseVisualStyleBackColor = true;
            btn_Comprar.Click += btn_Comprar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(48, 370);
            label1.Name = "label1";
            label1.Size = new Size(182, 21);
            label1.TabIndex = 20;
            label1.Text = "Total a Pagar:     $";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Sans", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(442, 370);
            label2.Name = "label2";
            label2.Size = new Size(187, 21);
            label2.TabIndex = 21;
            label2.Text = "Saldo Disponible: $";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, -88);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(867, 235);
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.MenuBar;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(367, 663);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(49, 46);
            pictureBox2.TabIndex = 23;
            pictureBox2.TabStop = false;
            // 
            // MenuCliente
            // 
            AutoScaleDimensions = new SizeF(11F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlText;
            ClientSize = new Size(870, 732);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_Comprar);
            Controls.Add(lbl_TotalApagar);
            Controls.Add(lbl_SaldoDisponible);
            Controls.Add(dgv_Heladera);
            Controls.Add(cbb_MedioDePago);
            Controls.Add(btn_RegistroDeDatos);
            Controls.Add(txb_MontoAGastar);
            Controls.Add(txb_Cuit);
            Controls.Add(txb_Apellido);
            Controls.Add(txb_Nombre);
            Controls.Add(lbl_MedioDePagoCliente);
            Controls.Add(lbl_BilleteraCliente);
            Controls.Add(lbl_CuitCliente);
            Controls.Add(lbl_ApellidoCliente);
            Controls.Add(lbl_NombreCliente);
            Controls.Add(lbl_LeyendaMCliente);
            Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "MenuCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Cliente";
            Load += MenuCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Heladera).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbl_LeyendaMCliente;
        private Label lbl_NombreCliente;
        private Label lbl_ApellidoCliente;
        private Label lbl_CuitCliente;
        private Label lbl_BilleteraCliente;
        private Label lbl_MedioDePagoCliente;
        private TextBox txb_Nombre;
        private TextBox txb_Apellido;
        private TextBox txb_Cuit;
        private TextBox txb_MontoAGastar;
        private Button btn_RegistroDeDatos;
        private ComboBox cbb_MedioDePago;
        private DataGridView dgv_Heladera;
        private DataGridViewTextBoxColumn TipoProducto;
        private DataGridViewTextBoxColumn NombreProducto;
        private DataGridViewTextBoxColumn PrecioPorKg;
        private DataGridViewTextBoxColumn CantidadKgDisponibles;
        private DataGridViewTextBoxColumn CantidadSolicitada;
        private Label lbl_SaldoDisponible;
        private Label lbl_TotalApagar;
        private Button btn_Comprar;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}