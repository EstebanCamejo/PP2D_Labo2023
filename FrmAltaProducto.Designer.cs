namespace VisualParcial1
{
    partial class FrmAltaProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAltaProducto));
            btn_CrearProducto = new Button();
            lbl_TipoDeProducto = new Label();
            lbl_NombreDeProducto = new Label();
            lbl_PrecioPorKg = new Label();
            lbl_CantidadDeKg = new Label();
            txb_Nombre = new TextBox();
            txb_Precio = new TextBox();
            txb_Cantidad = new TextBox();
            cbb_TipoDeProducto = new ComboBox();
            btn_VolverAtras = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btn_CrearProducto
            // 
            btn_CrearProducto.Font = new Font("Lucida Sans", 8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_CrearProducto.Location = new Point(410, 333);
            btn_CrearProducto.Margin = new Padding(4, 3, 4, 3);
            btn_CrearProducto.Name = "btn_CrearProducto";
            btn_CrearProducto.Size = new Size(164, 43);
            btn_CrearProducto.TabIndex = 0;
            btn_CrearProducto.Text = "Guardar";
            btn_CrearProducto.UseVisualStyleBackColor = true;
            btn_CrearProducto.Click += btn_CrearProducto_Click;
            btn_CrearProducto.MouseEnter += btn_CrearProducto_MouseEnter;
            btn_CrearProducto.MouseLeave += btn_CrearProducto_MouseLeave;
            // 
            // lbl_TipoDeProducto
            // 
            lbl_TipoDeProducto.AutoSize = true;
            lbl_TipoDeProducto.Font = new Font("Lucida Sans", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_TipoDeProducto.ForeColor = SystemColors.MenuBar;
            lbl_TipoDeProducto.Location = new Point(64, 20);
            lbl_TipoDeProducto.Margin = new Padding(4, 0, 4, 0);
            lbl_TipoDeProducto.Name = "lbl_TipoDeProducto";
            lbl_TipoDeProducto.Size = new Size(171, 21);
            lbl_TipoDeProducto.TabIndex = 1;
            lbl_TipoDeProducto.Text = "Tipo de Producto";
            // 
            // lbl_NombreDeProducto
            // 
            lbl_NombreDeProducto.AutoSize = true;
            lbl_NombreDeProducto.Font = new Font("Lucida Sans", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_NombreDeProducto.ForeColor = SystemColors.MenuBar;
            lbl_NombreDeProducto.Location = new Point(64, 65);
            lbl_NombreDeProducto.Margin = new Padding(4, 0, 4, 0);
            lbl_NombreDeProducto.Name = "lbl_NombreDeProducto";
            lbl_NombreDeProducto.Size = new Size(204, 21);
            lbl_NombreDeProducto.TabIndex = 2;
            lbl_NombreDeProducto.Text = "Nombre de Producto";
            // 
            // lbl_PrecioPorKg
            // 
            lbl_PrecioPorKg.AutoSize = true;
            lbl_PrecioPorKg.Font = new Font("Lucida Sans", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_PrecioPorKg.ForeColor = SystemColors.MenuBar;
            lbl_PrecioPorKg.Location = new Point(64, 106);
            lbl_PrecioPorKg.Margin = new Padding(4, 0, 4, 0);
            lbl_PrecioPorKg.Name = "lbl_PrecioPorKg";
            lbl_PrecioPorKg.Size = new Size(136, 21);
            lbl_PrecioPorKg.TabIndex = 3;
            lbl_PrecioPorKg.Text = "Precio por Kg";
            // 
            // lbl_CantidadDeKg
            // 
            lbl_CantidadDeKg.AutoSize = true;
            lbl_CantidadDeKg.Font = new Font("Lucida Sans", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_CantidadDeKg.ForeColor = SystemColors.MenuBar;
            lbl_CantidadDeKg.Location = new Point(64, 148);
            lbl_CantidadDeKg.Margin = new Padding(4, 0, 4, 0);
            lbl_CantidadDeKg.Name = "lbl_CantidadDeKg";
            lbl_CantidadDeKg.Size = new Size(153, 21);
            lbl_CantidadDeKg.TabIndex = 4;
            lbl_CantidadDeKg.Text = "Cantidad de Kg";
            // 
            // txb_Nombre
            // 
            txb_Nombre.Location = new Point(297, 62);
            txb_Nombre.Margin = new Padding(4, 3, 4, 3);
            txb_Nombre.Name = "txb_Nombre";
            txb_Nombre.Size = new Size(277, 29);
            txb_Nombre.TabIndex = 5;
            // 
            // txb_Precio
            // 
            txb_Precio.Location = new Point(297, 103);
            txb_Precio.Margin = new Padding(4, 3, 4, 3);
            txb_Precio.Name = "txb_Precio";
            txb_Precio.Size = new Size(277, 29);
            txb_Precio.TabIndex = 6;
            // 
            // txb_Cantidad
            // 
            txb_Cantidad.Location = new Point(297, 145);
            txb_Cantidad.Margin = new Padding(4, 3, 4, 3);
            txb_Cantidad.Name = "txb_Cantidad";
            txb_Cantidad.Size = new Size(277, 29);
            txb_Cantidad.TabIndex = 7;
            // 
            // cbb_TipoDeProducto
            // 
            cbb_TipoDeProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cbb_TipoDeProducto.FormattingEnabled = true;
            cbb_TipoDeProducto.Location = new Point(297, 20);
            cbb_TipoDeProducto.Margin = new Padding(4, 3, 4, 3);
            cbb_TipoDeProducto.Name = "cbb_TipoDeProducto";
            cbb_TipoDeProducto.Size = new Size(277, 29);
            cbb_TipoDeProducto.TabIndex = 8;
            // 
            // btn_VolverAtras
            // 
            btn_VolverAtras.Font = new Font("Lucida Sans", 8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_VolverAtras.Location = new Point(64, 333);
            btn_VolverAtras.Margin = new Padding(4, 3, 4, 3);
            btn_VolverAtras.Name = "btn_VolverAtras";
            btn_VolverAtras.Size = new Size(164, 43);
            btn_VolverAtras.TabIndex = 9;
            btn_VolverAtras.Text = "Atras";
            btn_VolverAtras.UseVisualStyleBackColor = true;
            btn_VolverAtras.Click += btn_VolverAtras_Click;
            btn_VolverAtras.MouseEnter += btn_VolverAtras_MouseEnter;
            btn_VolverAtras.MouseLeave += btn_VolverAtras_MouseLeave;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(287, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(372, 397);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(93, 189);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(107, 106);
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.MenuBar;
            label1.Location = new Point(74, 298);
            label1.Name = "label1";
            label1.Size = new Size(142, 21);
            label1.TabIndex = 12;
            label1.Text = "FM Carnes Srl";
            // 
            // FrmAltaProducto
            // 
            AutoScaleDimensions = new SizeF(12F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlText;
            ClientSize = new Size(656, 398);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(btn_VolverAtras);
            Controls.Add(cbb_TipoDeProducto);
            Controls.Add(txb_Cantidad);
            Controls.Add(txb_Precio);
            Controls.Add(txb_Nombre);
            Controls.Add(lbl_CantidadDeKg);
            Controls.Add(lbl_PrecioPorKg);
            Controls.Add(lbl_NombreDeProducto);
            Controls.Add(lbl_TipoDeProducto);
            Controls.Add(btn_CrearProducto);
            Controls.Add(pictureBox1);
            Font = new Font("Lucida Fax", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmAltaProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Producto Alta/Modificar";
            FormClosing += FrmAltaProducto_FormClosing;
            Load += FrmAltaProducto_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_CrearProducto;
        private Label lbl_TipoDeProducto;
        private Label lbl_NombreDeProducto;
        private Label lbl_PrecioPorKg;
        private Label lbl_CantidadDeKg;
        private TextBox txb_Nombre;
        private TextBox txb_Precio;
        private TextBox txb_Cantidad;
        private ComboBox cbb_TipoDeProducto;
        private Button btn_VolverAtras;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
    }
}