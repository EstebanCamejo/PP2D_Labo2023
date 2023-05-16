namespace VisualParcial1
{
    partial class AbmHeladera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AbmHeladera));
            btn_editarProducto = new Button();
            btn_nuevoProducto = new Button();
            label1 = new Label();
            btn_bajaProducto = new Button();
            btn_VolverAtras = new Button();
            dtgv_StockHeladera = new DataGridView();
            tipoDeProducto = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            precioPorKilo = new DataGridViewTextBoxColumn();
            CantidadKilos = new DataGridViewTextBoxColumn();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgv_StockHeladera).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btn_editarProducto
            // 
            btn_editarProducto.Font = new Font("Lucida Sans", 8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_editarProducto.Location = new Point(811, 156);
            btn_editarProducto.Margin = new Padding(4, 3, 4, 3);
            btn_editarProducto.Name = "btn_editarProducto";
            btn_editarProducto.Size = new Size(156, 47);
            btn_editarProducto.TabIndex = 0;
            btn_editarProducto.Text = "Editar";
            btn_editarProducto.UseVisualStyleBackColor = true;
            btn_editarProducto.Click += btn_editarProducto_Click;
            // 
            // btn_nuevoProducto
            // 
            btn_nuevoProducto.Font = new Font("Lucida Sans", 8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_nuevoProducto.Location = new Point(811, 100);
            btn_nuevoProducto.Margin = new Padding(4, 3, 4, 3);
            btn_nuevoProducto.Name = "btn_nuevoProducto";
            btn_nuevoProducto.Size = new Size(156, 47);
            btn_nuevoProducto.TabIndex = 1;
            btn_nuevoProducto.Text = "Nuevo";
            btn_nuevoProducto.UseVisualStyleBackColor = true;
            btn_nuevoProducto.Click += btn_nuevoProducto_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.MenuBar;
            label1.Location = new Point(339, 29);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(233, 32);
            label1.TabIndex = 2;
            label1.Text = "Stock Heladera";
            // 
            // btn_bajaProducto
            // 
            btn_bajaProducto.Font = new Font("Lucida Sans", 8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_bajaProducto.Location = new Point(811, 211);
            btn_bajaProducto.Margin = new Padding(4, 3, 4, 3);
            btn_bajaProducto.Name = "btn_bajaProducto";
            btn_bajaProducto.Size = new Size(156, 47);
            btn_bajaProducto.TabIndex = 4;
            btn_bajaProducto.Text = "Baja";
            btn_bajaProducto.UseVisualStyleBackColor = true;
            btn_bajaProducto.Click += btn_bajaProducto_Click;
            // 
            // btn_VolverAtras
            // 
            btn_VolverAtras.Font = new Font("Lucida Sans", 8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_VolverAtras.Location = new Point(811, 525);
            btn_VolverAtras.Margin = new Padding(4, 3, 4, 3);
            btn_VolverAtras.Name = "btn_VolverAtras";
            btn_VolverAtras.Size = new Size(156, 47);
            btn_VolverAtras.TabIndex = 5;
            btn_VolverAtras.Text = "Atras";
            btn_VolverAtras.UseVisualStyleBackColor = true;
            btn_VolverAtras.Click += btn_VolverAtras_Click;
            // 
            // dtgv_StockHeladera
            // 
            dtgv_StockHeladera.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_StockHeladera.Columns.AddRange(new DataGridViewColumn[] { tipoDeProducto, nombre, precioPorKilo, CantidadKilos });
            dtgv_StockHeladera.Location = new Point(30, 91);
            dtgv_StockHeladera.Name = "dtgv_StockHeladera";
            dtgv_StockHeladera.RowHeadersWidth = 62;
            dtgv_StockHeladera.RowTemplate.Height = 33;
            dtgv_StockHeladera.Size = new Size(763, 481);
            dtgv_StockHeladera.TabIndex = 6;
            dtgv_StockHeladera.CellClick += dtgv_StockHeladera_CellClick;
            // 
            // tipoDeProducto
            // 
            tipoDeProducto.HeaderText = "Tipo Prod";
            tipoDeProducto.MinimumWidth = 8;
            tipoDeProducto.Name = "tipoDeProducto";
            tipoDeProducto.Width = 150;
            // 
            // nombre
            // 
            nombre.HeaderText = "Nombre";
            nombre.MinimumWidth = 8;
            nombre.Name = "nombre";
            nombre.Width = 300;
            // 
            // precioPorKilo
            // 
            precioPorKilo.HeaderText = "Precio Kg";
            precioPorKilo.MinimumWidth = 8;
            precioPorKilo.Name = "precioPorKilo";
            precioPorKilo.Width = 150;
            // 
            // CantidadKilos
            // 
            CantidadKilos.HeaderText = "Stock";
            CantidadKilos.MinimumWidth = 8;
            CantidadKilos.Name = "CantidadKilos";
            CantidadKilos.Width = 150;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-178, -4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(971, 614);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(812, 313);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(156, 160);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.MenuBar;
            label2.Location = new Point(812, 476);
            label2.Name = "label2";
            label2.Size = new Size(151, 21);
            label2.TabIndex = 9;
            label2.Text = "FM Carnes SRL";
            // 
            // AbmHeladera
            // 
            AutoScaleDimensions = new SizeF(12F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlText;
            ClientSize = new Size(980, 610);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(dtgv_StockHeladera);
            Controls.Add(btn_VolverAtras);
            Controls.Add(btn_bajaProducto);
            Controls.Add(label1);
            Controls.Add(btn_nuevoProducto);
            Controls.Add(btn_editarProducto);
            Controls.Add(pictureBox1);
            Font = new Font("Lucida Fax", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "AbmHeladera";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Heladera";
            Load += AbmHeladera_Load;
            ((System.ComponentModel.ISupportInitialize)dtgv_StockHeladera).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_editarProducto;
        private Button btn_nuevoProducto;
        private Label label1;
        private Button btn_bajaProducto;
        private Button btn_VolverAtras;
        private DataGridView dtgv_StockHeladera;
        private DataGridViewTextBoxColumn tipoDeProducto;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn precioPorKilo;
        private DataGridViewTextBoxColumn CantidadKilos;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label2;
    }
}