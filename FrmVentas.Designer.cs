namespace VisualParcial1
{
    partial class FrmVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVentas));
            cbb_SeleccionarCliente = new ComboBox();
            lbl_TitularVentas = new Label();
            lbl_SeleccionarCliente = new Label();
            lbl_TopeDeConcesion = new Label();
            txb_TopeDeConcesion = new TextBox();
            button1 = new Button();
            btn_VolverAtras = new Button();
            SuspendLayout();
            // 
            // cbb_SeleccionarCliente
            // 
            cbb_SeleccionarCliente.FormattingEnabled = true;
            cbb_SeleccionarCliente.Location = new Point(334, 177);
            cbb_SeleccionarCliente.Margin = new Padding(4, 3, 4, 3);
            cbb_SeleccionarCliente.Name = "cbb_SeleccionarCliente";
            cbb_SeleccionarCliente.Size = new Size(562, 29);
            cbb_SeleccionarCliente.TabIndex = 0;
            cbb_SeleccionarCliente.SelectedIndexChanged += cbb_SeleccionarCliente_SelectedIndexChanged;
            // 
            // lbl_TitularVentas
            // 
            lbl_TitularVentas.AutoSize = true;
            lbl_TitularVentas.Font = new Font("Lucida Fax", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_TitularVentas.Location = new Point(545, 58);
            lbl_TitularVentas.Margin = new Padding(4, 0, 4, 0);
            lbl_TitularVentas.Name = "lbl_TitularVentas";
            lbl_TitularVentas.Size = new Size(227, 27);
            lbl_TitularVentas.TabIndex = 1;
            lbl_TitularVentas.Text = "Ventas y Pedidos";
            // 
            // lbl_SeleccionarCliente
            // 
            lbl_SeleccionarCliente.AutoSize = true;
            lbl_SeleccionarCliente.Font = new Font("Lucida Fax", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_SeleccionarCliente.Location = new Point(68, 180);
            lbl_SeleccionarCliente.Margin = new Padding(4, 0, 4, 0);
            lbl_SeleccionarCliente.Name = "lbl_SeleccionarCliente";
            lbl_SeleccionarCliente.Size = new Size(183, 21);
            lbl_SeleccionarCliente.TabIndex = 2;
            lbl_SeleccionarCliente.Text = "Seleccionar Cliente";
            // 
            // lbl_TopeDeConcesion
            // 
            lbl_TopeDeConcesion.AutoSize = true;
            lbl_TopeDeConcesion.Font = new Font("Lucida Fax", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_TopeDeConcesion.Location = new Point(68, 229);
            lbl_TopeDeConcesion.Margin = new Padding(4, 0, 4, 0);
            lbl_TopeDeConcesion.Name = "lbl_TopeDeConcesion";
            lbl_TopeDeConcesion.Size = new Size(255, 21);
            lbl_TopeDeConcesion.TabIndex = 3;
            lbl_TopeDeConcesion.Text = "Tope de Concesion          $";
            // 
            // txb_TopeDeConcesion
            // 
            txb_TopeDeConcesion.Location = new Point(334, 226);
            txb_TopeDeConcesion.Margin = new Padding(4, 3, 4, 3);
            txb_TopeDeConcesion.Name = "txb_TopeDeConcesion";
            txb_TopeDeConcesion.Size = new Size(200, 29);
            txb_TopeDeConcesion.TabIndex = 4;
            // 
            // button1
            // 
            button1.Font = new Font("Lucida Fax", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(619, 328);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(280, 29);
            button1.TabIndex = 5;
            button1.Text = "Gestionar Pedido";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btn_VolverAtras
            // 
            btn_VolverAtras.Font = new Font("Lucida Fax", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_VolverAtras.Location = new Point(619, 280);
            btn_VolverAtras.Margin = new Padding(4, 3, 4, 3);
            btn_VolverAtras.Name = "btn_VolverAtras";
            btn_VolverAtras.Size = new Size(280, 29);
            btn_VolverAtras.TabIndex = 6;
            btn_VolverAtras.Text = "Atras";
            btn_VolverAtras.UseVisualStyleBackColor = true;
            btn_VolverAtras.Click += btn_VolverAtras_Click;
            // 
            // FrmVentas
            // 
            AutoScaleDimensions = new SizeF(12F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCoral;
            ClientSize = new Size(960, 378);
            Controls.Add(btn_VolverAtras);
            Controls.Add(button1);
            Controls.Add(txb_TopeDeConcesion);
            Controls.Add(lbl_TopeDeConcesion);
            Controls.Add(lbl_SeleccionarCliente);
            Controls.Add(lbl_TitularVentas);
            Controls.Add(cbb_SeleccionarCliente);
            Font = new Font("Lucida Fax", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmVentas";
            Text = "Ventas y Pedidos";
            Load += FrmVentas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbb_SeleccionarCliente;
        private Label lbl_TitularVentas;
        private Label lbl_SeleccionarCliente;
        private Label lbl_TopeDeConcesion;
        private TextBox txb_TopeDeConcesion;
        private Button button1;
        private Button btn_VolverAtras;
    }
}