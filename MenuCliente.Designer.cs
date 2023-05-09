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
            lbl_BienvenidaMenuCliente = new Label();
            lbl_LeyendaMCliente = new Label();
            lbl_NombreCliente = new Label();
            lbl_ApellidoCliente = new Label();
            lbl_CuitCliente = new Label();
            lbl_DireccionCliente = new Label();
            lbl_BilleteraCliente = new Label();
            lbl_MedioDePagoCliente = new Label();
            txb_Nombre = new TextBox();
            txb_Apellido = new TextBox();
            txb_Cuit = new TextBox();
            txb_Direccion = new TextBox();
            txb_MontoAGastar = new TextBox();
            btn_GestionarPedido = new Button();
            cbb_MedioDePago = new ComboBox();
            btn_VolverAtras = new Button();
            SuspendLayout();
            // 
            // lbl_BienvenidaMenuCliente
            // 
            lbl_BienvenidaMenuCliente.AutoSize = true;
            lbl_BienvenidaMenuCliente.Font = new Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_BienvenidaMenuCliente.Location = new Point(334, 32);
            lbl_BienvenidaMenuCliente.Margin = new Padding(4, 0, 4, 0);
            lbl_BienvenidaMenuCliente.Name = "lbl_BienvenidaMenuCliente";
            lbl_BienvenidaMenuCliente.Size = new Size(225, 27);
            lbl_BienvenidaMenuCliente.TabIndex = 0;
            lbl_BienvenidaMenuCliente.Text = "Bienvenido a RES";
            // 
            // lbl_LeyendaMCliente
            // 
            lbl_LeyendaMCliente.AutoSize = true;
            lbl_LeyendaMCliente.Font = new Font("Lucida Sans", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_LeyendaMCliente.Location = new Point(75, 108);
            lbl_LeyendaMCliente.Margin = new Padding(4, 0, 4, 0);
            lbl_LeyendaMCliente.Name = "lbl_LeyendaMCliente";
            lbl_LeyendaMCliente.Size = new Size(750, 23);
            lbl_LeyendaMCliente.TabIndex = 1;
            lbl_LeyendaMCliente.Text = "Por favor, completar el siguiente formulario para continuar con su pedido...";
            // 
            // lbl_NombreCliente
            // 
            lbl_NombreCliente.AutoSize = true;
            lbl_NombreCliente.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_NombreCliente.Location = new Point(209, 179);
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
            lbl_ApellidoCliente.Location = new Point(211, 220);
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
            lbl_CuitCliente.Location = new Point(211, 260);
            lbl_CuitCliente.Margin = new Padding(4, 0, 4, 0);
            lbl_CuitCliente.Name = "lbl_CuitCliente";
            lbl_CuitCliente.Size = new Size(87, 21);
            lbl_CuitCliente.TabIndex = 4;
            lbl_CuitCliente.Text = "Nº CUIT:";
            // 
            // lbl_DireccionCliente
            // 
            lbl_DireccionCliente.AutoSize = true;
            lbl_DireccionCliente.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_DireccionCliente.Location = new Point(206, 305);
            lbl_DireccionCliente.Margin = new Padding(4, 0, 4, 0);
            lbl_DireccionCliente.Name = "lbl_DireccionCliente";
            lbl_DireccionCliente.Size = new Size(100, 21);
            lbl_DireccionCliente.TabIndex = 5;
            lbl_DireccionCliente.Text = "Direccion:";
            // 
            // lbl_BilleteraCliente
            // 
            lbl_BilleteraCliente.AutoSize = true;
            lbl_BilleteraCliente.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_BilleteraCliente.Location = new Point(75, 345);
            lbl_BilleteraCliente.Margin = new Padding(4, 0, 4, 0);
            lbl_BilleteraCliente.Name = "lbl_BilleteraCliente";
            lbl_BilleteraCliente.Size = new Size(228, 21);
            lbl_BilleteraCliente.TabIndex = 6;
            lbl_BilleteraCliente.Text = "Monto Maximo a Gastar:";
            // 
            // lbl_MedioDePagoCliente
            // 
            lbl_MedioDePagoCliente.AutoSize = true;
            lbl_MedioDePagoCliente.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_MedioDePagoCliente.Location = new Point(50, 389);
            lbl_MedioDePagoCliente.Margin = new Padding(4, 0, 4, 0);
            lbl_MedioDePagoCliente.Name = "lbl_MedioDePagoCliente";
            lbl_MedioDePagoCliente.Size = new Size(256, 21);
            lbl_MedioDePagoCliente.TabIndex = 7;
            lbl_MedioDePagoCliente.Text = "Seleccionar Medio de Pago:";
            // 
            // txb_Nombre
            // 
            txb_Nombre.Location = new Point(319, 174);
            txb_Nombre.Margin = new Padding(4, 3, 4, 3);
            txb_Nombre.Name = "txb_Nombre";
            txb_Nombre.Size = new Size(516, 29);
            txb_Nombre.TabIndex = 8;
            // 
            // txb_Apellido
            // 
            txb_Apellido.Location = new Point(319, 215);
            txb_Apellido.Margin = new Padding(4, 3, 4, 3);
            txb_Apellido.Name = "txb_Apellido";
            txb_Apellido.Size = new Size(516, 29);
            txb_Apellido.TabIndex = 9;
            // 
            // txb_Cuit
            // 
            txb_Cuit.Location = new Point(319, 255);
            txb_Cuit.Margin = new Padding(4, 3, 4, 3);
            txb_Cuit.Name = "txb_Cuit";
            txb_Cuit.Size = new Size(516, 29);
            txb_Cuit.TabIndex = 10;
            // 
            // txb_Direccion
            // 
            txb_Direccion.Location = new Point(319, 300);
            txb_Direccion.Margin = new Padding(4, 3, 4, 3);
            txb_Direccion.Name = "txb_Direccion";
            txb_Direccion.Size = new Size(516, 29);
            txb_Direccion.TabIndex = 11;
            // 
            // txb_MontoAGastar
            // 
            txb_MontoAGastar.Location = new Point(319, 340);
            txb_MontoAGastar.Margin = new Padding(4, 3, 4, 3);
            txb_MontoAGastar.Name = "txb_MontoAGastar";
            txb_MontoAGastar.Size = new Size(228, 29);
            txb_MontoAGastar.TabIndex = 12;
            // 
            // btn_GestionarPedido
            // 
            btn_GestionarPedido.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_GestionarPedido.Location = new Point(565, 475);
            btn_GestionarPedido.Margin = new Padding(4, 3, 4, 3);
            btn_GestionarPedido.Name = "btn_GestionarPedido";
            btn_GestionarPedido.Size = new Size(270, 32);
            btn_GestionarPedido.TabIndex = 14;
            btn_GestionarPedido.Text = "Gestionar Pedido";
            btn_GestionarPedido.UseVisualStyleBackColor = true;
            btn_GestionarPedido.Click += btn_GestionarPedido_Click;
            // 
            // cbb_MedioDePago
            // 
            cbb_MedioDePago.FormattingEnabled = true;
            cbb_MedioDePago.Location = new Point(319, 381);
            cbb_MedioDePago.Margin = new Padding(4, 3, 4, 3);
            cbb_MedioDePago.Name = "cbb_MedioDePago";
            cbb_MedioDePago.Size = new Size(228, 29);
            cbb_MedioDePago.TabIndex = 15;
            // 
            // btn_VolverAtras
            // 
            btn_VolverAtras.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_VolverAtras.Location = new Point(565, 434);
            btn_VolverAtras.Margin = new Padding(4, 3, 4, 3);
            btn_VolverAtras.Name = "btn_VolverAtras";
            btn_VolverAtras.Size = new Size(270, 29);
            btn_VolverAtras.TabIndex = 16;
            btn_VolverAtras.Text = "Atras";
            btn_VolverAtras.UseVisualStyleBackColor = true;
            btn_VolverAtras.Click += btn_VolverAtras_Click;
            // 
            // MenuCliente
            // 
            AutoScaleDimensions = new SizeF(11F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Aquamarine;
            ClientSize = new Size(940, 541);
            Controls.Add(btn_VolverAtras);
            Controls.Add(cbb_MedioDePago);
            Controls.Add(btn_GestionarPedido);
            Controls.Add(txb_MontoAGastar);
            Controls.Add(txb_Direccion);
            Controls.Add(txb_Cuit);
            Controls.Add(txb_Apellido);
            Controls.Add(txb_Nombre);
            Controls.Add(lbl_MedioDePagoCliente);
            Controls.Add(lbl_BilleteraCliente);
            Controls.Add(lbl_DireccionCliente);
            Controls.Add(lbl_CuitCliente);
            Controls.Add(lbl_ApellidoCliente);
            Controls.Add(lbl_NombreCliente);
            Controls.Add(lbl_LeyendaMCliente);
            Controls.Add(lbl_BienvenidaMenuCliente);
            Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "MenuCliente";
            Text = "Menu Cliente";
            Load += MenuCliente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_BienvenidaMenuCliente;
        private Label lbl_LeyendaMCliente;
        private Label lbl_NombreCliente;
        private Label lbl_ApellidoCliente;
        private Label lbl_CuitCliente;
        private Label lbl_DireccionCliente;
        private Label lbl_BilleteraCliente;
        private Label lbl_MedioDePagoCliente;
        private TextBox txb_Nombre;
        private TextBox txb_Apellido;
        private TextBox txb_Cuit;
        private TextBox txb_Direccion;
        private TextBox txb_MontoAGastar;
        private Button btn_GestionarPedido;
        private ComboBox cbb_MedioDePago;
        private Button btn_VolverAtras;
    }
}