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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // lbl_Mensaje
            // 
            lbl_Mensaje.AutoSize = true;
            lbl_Mensaje.BackColor = Color.Transparent;
            lbl_Mensaje.Font = new Font("Lucida Fax", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Mensaje.ForeColor = SystemColors.MenuBar;
            lbl_Mensaje.Location = new Point(99, 68);
            lbl_Mensaje.Margin = new Padding(4, 0, 4, 0);
            lbl_Mensaje.Name = "lbl_Mensaje";
            lbl_Mensaje.Size = new Size(568, 23);
            lbl_Mensaje.TabIndex = 0;
            lbl_Mensaje.Text = "Por favor, seleccione una de las siguientes opciones";
            // 
            // btn_Inventario
            // 
            btn_Inventario.BackColor = Color.Transparent;
            btn_Inventario.Font = new Font("Lucida Sans", 8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Inventario.Location = new Point(197, 140);
            btn_Inventario.Margin = new Padding(4, 3, 4, 3);
            btn_Inventario.Name = "btn_Inventario";
            btn_Inventario.Size = new Size(307, 52);
            btn_Inventario.TabIndex = 1;
            btn_Inventario.Text = "Inventario ";
            btn_Inventario.UseVisualStyleBackColor = false;
            btn_Inventario.Click += btn_Inventario_Click;
            // 
            // btn_Ventas
            // 
            btn_Ventas.BackColor = Color.Transparent;
            btn_Ventas.Font = new Font("Lucida Sans", 8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Ventas.Location = new Point(197, 340);
            btn_Ventas.Margin = new Padding(4, 3, 4, 3);
            btn_Ventas.Name = "btn_Ventas";
            btn_Ventas.Size = new Size(307, 52);
            btn_Ventas.TabIndex = 2;
            btn_Ventas.Text = "   Ventas y Pedidos";
            btn_Ventas.UseVisualStyleBackColor = false;
            btn_Ventas.Click += btn_Ventas_Click;
            // 
            // btn_Facturacion
            // 
            btn_Facturacion.BackColor = Color.Transparent;
            btn_Facturacion.Font = new Font("Lucida Sans", 8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Facturacion.Location = new Point(197, 240);
            btn_Facturacion.Margin = new Padding(4, 3, 4, 3);
            btn_Facturacion.Name = "btn_Facturacion";
            btn_Facturacion.Size = new Size(307, 52);
            btn_Facturacion.TabIndex = 3;
            btn_Facturacion.Text = "   Facturacion";
            btn_Facturacion.UseVisualStyleBackColor = false;
            btn_Facturacion.Click += btn_Facturacion_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, -11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(350, 535);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(571, 340);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(105, 106);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.MenuBar;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(261, 249);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(39, 39);
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = SystemColors.MenuBar;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(236, 348);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(44, 39);
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = SystemColors.MenuBar;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(254, 148);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(46, 39);
            pictureBox5.TabIndex = 9;
            pictureBox5.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.MenuBar;
            label1.Location = new Point(544, 464);
            label1.Name = "label1";
            label1.Size = new Size(151, 21);
            label1.TabIndex = 10;
            label1.Text = "FM Carnes SRL";
            // 
            // MenuVendedor
            // 
            AutoScaleDimensions = new SizeF(12F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlText;
            ClientSize = new Size(721, 524);
            Controls.Add(label1);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(btn_Facturacion);
            Controls.Add(btn_Ventas);
            Controls.Add(btn_Inventario);
            Controls.Add(lbl_Mensaje);
            Controls.Add(pictureBox1);
            Font = new Font("Lucida Fax", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "MenuVendedor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Vendedor";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Mensaje;
        private Button btn_Inventario;
        private Button btn_Ventas;
        private Button btn_Facturacion;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Label label1;
    }
}