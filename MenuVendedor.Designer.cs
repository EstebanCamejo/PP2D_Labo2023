namespace VisualParcial1
{
    partial class MenuVendedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuVendedor));
            lbl_Mensaje = new Label();
            btn_Inventario = new Button();
            btn_Ventas = new Button();
            btn_Facturacion = new Button();
            btn_VolverAtras = new Button();
            SuspendLayout();
            // 
            // lbl_Mensaje
            // 
            lbl_Mensaje.AutoSize = true;
            lbl_Mensaje.Font = new Font("Lucida Fax", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Mensaje.Location = new Point(151, 65);
            lbl_Mensaje.Margin = new Padding(4, 0, 4, 0);
            lbl_Mensaje.Name = "lbl_Mensaje";
            lbl_Mensaje.Size = new Size(675, 27);
            lbl_Mensaje.TabIndex = 0;
            lbl_Mensaje.Text = "Por favor, seleccione una de las siguientes opciones";
            // 
            // btn_Inventario
            // 
            btn_Inventario.BackColor = Color.Transparent;
            btn_Inventario.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Inventario.Location = new Point(229, 146);
            btn_Inventario.Margin = new Padding(4, 3, 4, 3);
            btn_Inventario.Name = "btn_Inventario";
            btn_Inventario.Size = new Size(503, 29);
            btn_Inventario.TabIndex = 1;
            btn_Inventario.Text = "Inventario de Productos";
            btn_Inventario.UseVisualStyleBackColor = false;
            btn_Inventario.Click += btn_Inventario_Click;
            // 
            // btn_Ventas
            // 
            btn_Ventas.BackColor = Color.Transparent;
            btn_Ventas.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Ventas.Location = new Point(229, 208);
            btn_Ventas.Margin = new Padding(4, 3, 4, 3);
            btn_Ventas.Name = "btn_Ventas";
            btn_Ventas.Size = new Size(503, 29);
            btn_Ventas.TabIndex = 2;
            btn_Ventas.Text = "Realizar Ventas y Pedidos";
            btn_Ventas.UseVisualStyleBackColor = false;
            btn_Ventas.Click += btn_Ventas_Click;
            // 
            // btn_Facturacion
            // 
            btn_Facturacion.BackColor = Color.Transparent;
            btn_Facturacion.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Facturacion.Location = new Point(229, 270);
            btn_Facturacion.Margin = new Padding(4, 3, 4, 3);
            btn_Facturacion.Name = "btn_Facturacion";
            btn_Facturacion.Size = new Size(503, 29);
            btn_Facturacion.TabIndex = 3;
            btn_Facturacion.Text = "Facturacion";
            btn_Facturacion.UseVisualStyleBackColor = false;
            btn_Facturacion.Click += btn_Facturacion_Click;
            // 
            // btn_VolverAtras
            // 
            btn_VolverAtras.BackColor = Color.Transparent;
            btn_VolverAtras.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_VolverAtras.Location = new Point(414, 322);
            btn_VolverAtras.Margin = new Padding(4, 3, 4, 3);
            btn_VolverAtras.Name = "btn_VolverAtras";
            btn_VolverAtras.Size = new Size(134, 29);
            btn_VolverAtras.TabIndex = 4;
            btn_VolverAtras.Text = "Atras";
            btn_VolverAtras.UseVisualStyleBackColor = false;
            btn_VolverAtras.Click += btn_VolverAtras_Click;
            // 
            // MenuVendedor
            // 
            AutoScaleDimensions = new SizeF(12F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCoral;
            ClientSize = new Size(960, 378);
            Controls.Add(btn_VolverAtras);
            Controls.Add(btn_Facturacion);
            Controls.Add(btn_Ventas);
            Controls.Add(btn_Inventario);
            Controls.Add(lbl_Mensaje);
            Font = new Font("Lucida Fax", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "MenuVendedor";
            Text = "Menu Vendedor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Mensaje;
        private Button btn_Inventario;
        private Button btn_Ventas;
        private Button btn_Facturacion;
        private Button btn_VolverAtras;
    }
}