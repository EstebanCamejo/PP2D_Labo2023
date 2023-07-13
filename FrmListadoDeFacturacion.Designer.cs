namespace VisualParcial1
{
    partial class FrmListadoDeFacturacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListadoDeFacturacion));
            lbl_TitularListadoFacturas = new Label();
            btn_VolverAtras = new Button();
            dgv_ListadoDeFacturas = new DataGridView();
            numeroDeFactura = new DataGridViewTextBoxColumn();
            fechaActual = new DataGridViewTextBoxColumn();
            cliente = new DataGridViewTextBoxColumn();
            totalFactura = new DataGridViewTextBoxColumn();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_ListadoDeFacturas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lbl_TitularListadoFacturas
            // 
            lbl_TitularListadoFacturas.AutoSize = true;
            lbl_TitularListadoFacturas.Font = new Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_TitularListadoFacturas.ForeColor = SystemColors.MenuBar;
            lbl_TitularListadoFacturas.Location = new Point(242, 51);
            lbl_TitularListadoFacturas.Margin = new Padding(4, 0, 4, 0);
            lbl_TitularListadoFacturas.Name = "lbl_TitularListadoFacturas";
            lbl_TitularListadoFacturas.Size = new Size(367, 27);
            lbl_TitularListadoFacturas.TabIndex = 0;
            lbl_TitularListadoFacturas.Text = "Estado de Facturacion Actual";
            // 
            // btn_VolverAtras
            // 
            btn_VolverAtras.Font = new Font("Lucida Sans", 8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_VolverAtras.Location = new Point(47, 563);
            btn_VolverAtras.Margin = new Padding(4, 3, 4, 3);
            btn_VolverAtras.Name = "btn_VolverAtras";
            btn_VolverAtras.Size = new Size(204, 46);
            btn_VolverAtras.TabIndex = 2;
            btn_VolverAtras.Text = "Atras";
            btn_VolverAtras.UseVisualStyleBackColor = true;
            btn_VolverAtras.Click += btn_VolverAtras_Click;
            btn_VolverAtras.MouseEnter += btn_VolverAtras_MouseEnter;
            btn_VolverAtras.MouseLeave += btn_VolverAtras_MouseLeave;
            // 
            // dgv_ListadoDeFacturas
            // 
            dgv_ListadoDeFacturas.AllowDrop = true;
            dgv_ListadoDeFacturas.AllowUserToAddRows = false;
            dgv_ListadoDeFacturas.AllowUserToDeleteRows = false;
            dgv_ListadoDeFacturas.AllowUserToOrderColumns = true;
            dgv_ListadoDeFacturas.AllowUserToResizeColumns = false;
            dgv_ListadoDeFacturas.AllowUserToResizeRows = false;
            dgv_ListadoDeFacturas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ListadoDeFacturas.Columns.AddRange(new DataGridViewColumn[] { numeroDeFactura, fechaActual, cliente, totalFactura });
            dgv_ListadoDeFacturas.Location = new Point(47, 128);
            dgv_ListadoDeFacturas.Name = "dgv_ListadoDeFacturas";
            dgv_ListadoDeFacturas.ReadOnly = true;
            dgv_ListadoDeFacturas.RowHeadersWidth = 4;
            dgv_ListadoDeFacturas.RowTemplate.Height = 33;
            dgv_ListadoDeFacturas.Size = new Size(761, 332);
            dgv_ListadoDeFacturas.TabIndex = 3;
            // 
            // numeroDeFactura
            // 
            numeroDeFactura.HeaderText = "Nº";
            numeroDeFactura.MinimumWidth = 8;
            numeroDeFactura.Name = "numeroDeFactura";
            numeroDeFactura.ReadOnly = true;
            numeroDeFactura.Width = 150;
            // 
            // fechaActual
            // 
            fechaActual.HeaderText = "Fecha";
            fechaActual.MinimumWidth = 8;
            fechaActual.Name = "fechaActual";
            fechaActual.ReadOnly = true;
            fechaActual.Width = 150;
            // 
            // cliente
            // 
            cliente.HeaderText = "Nombre";
            cliente.MinimumWidth = 8;
            cliente.Name = "cliente";
            cliente.ReadOnly = true;
            cliente.Width = 300;
            // 
            // totalFactura
            // 
            totalFactura.HeaderText = "Total";
            totalFactura.MinimumWidth = 8;
            totalFactura.Name = "totalFactura";
            totalFactura.ReadOnly = true;
            totalFactura.Width = 150;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(612, 478);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(110, 107);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-7, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(450, 646);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.MenuBar;
            label1.Location = new Point(582, 588);
            label1.Name = "label1";
            label1.Size = new Size(151, 21);
            label1.TabIndex = 6;
            label1.Text = "FM Carnes SRL";
            // 
            // FrmListadoDeFacturacion
            // 
            AutoScaleDimensions = new SizeF(12F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlText;
            ClientSize = new Size(845, 635);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(dgv_ListadoDeFacturas);
            Controls.Add(btn_VolverAtras);
            Controls.Add(lbl_TitularListadoFacturas);
            Controls.Add(pictureBox2);
            Font = new Font("Lucida Fax", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmListadoDeFacturacion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Listado de Facturas";
            Load += FrmListadoDeFacturacion_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_ListadoDeFacturas).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_TitularListadoFacturas;
        private Button btn_VolverAtras;
        private DataGridView dgv_ListadoDeFacturas;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private DataGridViewTextBoxColumn numeroDeFactura;
        private DataGridViewTextBoxColumn fechaActual;
        private DataGridViewTextBoxColumn cliente;
        private DataGridViewTextBoxColumn totalFactura;
    }
}