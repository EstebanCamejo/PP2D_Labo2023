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
            btn_SerializarJson = new Button();
            btn_SerializarXml = new Button();
            btn_DeserializarXml = new Button();
            btn_DeserializarJson = new Button();
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
            lbl_TitularListadoFacturas.Location = new Point(240, 18);
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
            dgv_ListadoDeFacturas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ListadoDeFacturas.Columns.AddRange(new DataGridViewColumn[] { numeroDeFactura, fechaActual, cliente, totalFactura });
            dgv_ListadoDeFacturas.Location = new Point(47, 62);
            dgv_ListadoDeFacturas.Name = "dgv_ListadoDeFacturas";
            dgv_ListadoDeFacturas.ReadOnly = true;
            dgv_ListadoDeFacturas.RowHeadersWidth = 62;
            dgv_ListadoDeFacturas.RowTemplate.Height = 33;
            dgv_ListadoDeFacturas.Size = new Size(761, 348);
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
            pictureBox1.Location = new Point(481, 516);
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
            label1.Location = new Point(657, 563);
            label1.Name = "label1";
            label1.Size = new Size(151, 21);
            label1.TabIndex = 6;
            label1.Text = "FM Carnes SRL";
            // 
            // btn_SerializarJson
            // 
            btn_SerializarJson.BackColor = Color.Red;
            btn_SerializarJson.Font = new Font("Lucida Sans", 8F, FontStyle.Italic, GraphicsUnit.Point);
            btn_SerializarJson.Location = new Point(466, 456);
            btn_SerializarJson.Name = "btn_SerializarJson";
            btn_SerializarJson.Size = new Size(141, 34);
            btn_SerializarJson.TabIndex = 7;
            btn_SerializarJson.Text = "Serializar Json";
            btn_SerializarJson.UseVisualStyleBackColor = false;
            btn_SerializarJson.Click += btn_SerializarJson_Click;
            // 
            // btn_SerializarXml
            // 
            btn_SerializarXml.BackColor = Color.Red;
            btn_SerializarXml.Font = new Font("Lucida Fax", 8F, FontStyle.Italic, GraphicsUnit.Point);
            btn_SerializarXml.Location = new Point(466, 416);
            btn_SerializarXml.Name = "btn_SerializarXml";
            btn_SerializarXml.Size = new Size(141, 34);
            btn_SerializarXml.TabIndex = 8;
            btn_SerializarXml.Text = "Serializar Xml";
            btn_SerializarXml.UseVisualStyleBackColor = false;
            btn_SerializarXml.Visible = false;
            btn_SerializarXml.Click += btn_SerializarXml_Click;
            // 
            // btn_DeserializarXml
            // 
            btn_DeserializarXml.BackColor = SystemColors.Highlight;
            btn_DeserializarXml.Font = new Font("Lucida Fax", 8F, FontStyle.Italic, GraphicsUnit.Point);
            btn_DeserializarXml.Location = new Point(650, 416);
            btn_DeserializarXml.Name = "btn_DeserializarXml";
            btn_DeserializarXml.Size = new Size(158, 34);
            btn_DeserializarXml.TabIndex = 9;
            btn_DeserializarXml.Text = "Deserializar Xml";
            btn_DeserializarXml.UseVisualStyleBackColor = false;
            btn_DeserializarXml.Visible = false;
            btn_DeserializarXml.Click += btn_DeserializarXml_Click;
            // 
            // btn_DeserializarJson
            // 
            btn_DeserializarJson.BackColor = SystemColors.Highlight;
            btn_DeserializarJson.Font = new Font("Lucida Sans", 8F, FontStyle.Italic, GraphicsUnit.Point);
            btn_DeserializarJson.Location = new Point(650, 456);
            btn_DeserializarJson.Name = "btn_DeserializarJson";
            btn_DeserializarJson.Size = new Size(158, 34);
            btn_DeserializarJson.TabIndex = 10;
            btn_DeserializarJson.Text = "Deserializar Json";
            btn_DeserializarJson.UseVisualStyleBackColor = false;
            btn_DeserializarJson.Click += btn_DeserializarJson_Click;
            // 
            // FrmListadoDeFacturacion
            // 
            AutoScaleDimensions = new SizeF(12F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlText;
            ClientSize = new Size(845, 635);
            Controls.Add(btn_DeserializarJson);
            Controls.Add(btn_DeserializarXml);
            Controls.Add(btn_SerializarXml);
            Controls.Add(btn_SerializarJson);
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
        private Button btn_SerializarJson;
        private Button btn_SerializarXml;
        private Button btn_DeserializarXml;
        private Button btn_DeserializarJson;
    }
}