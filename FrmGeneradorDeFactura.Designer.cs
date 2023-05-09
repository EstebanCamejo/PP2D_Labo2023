namespace VisualParcial1
{
    partial class FrmGeneradorDeFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGeneradorDeFactura));
            lbl_CarniceriaRes = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            lbl_Fecha = new Label();
            label7 = new Label();
            lbl_NumeroFactura = new Label();
            lbl_NombreFc = new Label();
            lbl_Cuit = new Label();
            lbl_Subtotal = new Label();
            lbl_IvaTotal = new Label();
            lbl_RecargoTc = new Label();
            lbl_TotalFactura = new Label();
            dgv_ListaDeProductos = new DataGridView();
            btn_VolverAtras = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_ListaDeProductos).BeginInit();
            SuspendLayout();
            // 
            // lbl_CarniceriaRes
            // 
            lbl_CarniceriaRes.AutoSize = true;
            lbl_CarniceriaRes.Font = new Font("Lucida Sans", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_CarniceriaRes.Location = new Point(199, 28);
            lbl_CarniceriaRes.Margin = new Padding(4, 0, 4, 0);
            lbl_CarniceriaRes.Name = "lbl_CarniceriaRes";
            lbl_CarniceriaRes.Size = new Size(182, 23);
            lbl_CarniceriaRes.TabIndex = 0;
            lbl_CarniceriaRes.Text = "CARNICERIA RES";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(223, 59);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(103, 23);
            label1.TabIndex = 1;
            label1.Text = "RES S.R.L";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Sans", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(76, 116);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(212, 23);
            label2.TabIndex = 2;
            label2.Text = "CUIT: 30-1111111-2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Sans", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(76, 95);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(477, 23);
            label3.TabIndex = 3;
            label3.Text = "Donovan y Camino Gral. Chamizo 820, GERLI";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Sans", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(162, 137);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(225, 23);
            label4.TabIndex = 4;
            label4.Text = "IVA RESP. INSCRIPTO";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Lucida Sans", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(321, 116);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(169, 23);
            label6.TabIndex = 6;
            label6.Text = "TEL. 4574 6521";
            // 
            // lbl_Fecha
            // 
            lbl_Fecha.AutoSize = true;
            lbl_Fecha.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Fecha.Location = new Point(574, 118);
            lbl_Fecha.Margin = new Padding(4, 0, 4, 0);
            lbl_Fecha.Name = "lbl_Fecha";
            lbl_Fecha.Size = new Size(73, 21);
            lbl_Fecha.TabIndex = 7;
            lbl_Fecha.Text = "Fecha: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Lucida Sans", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(572, 39);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(106, 23);
            label7.TabIndex = 8;
            label7.Text = "FACTURA";
            // 
            // lbl_NumeroFactura
            // 
            lbl_NumeroFactura.AutoSize = true;
            lbl_NumeroFactura.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_NumeroFactura.Location = new Point(574, 97);
            lbl_NumeroFactura.Margin = new Padding(4, 0, 4, 0);
            lbl_NumeroFactura.Name = "lbl_NumeroFactura";
            lbl_NumeroFactura.Size = new Size(115, 21);
            lbl_NumeroFactura.TabIndex = 9;
            lbl_NumeroFactura.Text = "Nº00000-00";
            // 
            // lbl_NombreFc
            // 
            lbl_NombreFc.AutoSize = true;
            lbl_NombreFc.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_NombreFc.Location = new Point(574, 139);
            lbl_NombreFc.Margin = new Padding(4, 0, 4, 0);
            lbl_NombreFc.Name = "lbl_NombreFc";
            lbl_NombreFc.Size = new Size(100, 21);
            lbl_NombreFc.TabIndex = 10;
            lbl_NombreFc.Text = "Señor/es: ";
            // 
            // lbl_Cuit
            // 
            lbl_Cuit.AutoSize = true;
            lbl_Cuit.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Cuit.Location = new Point(574, 160);
            lbl_Cuit.Margin = new Padding(4, 0, 4, 0);
            lbl_Cuit.Name = "lbl_Cuit";
            lbl_Cuit.Size = new Size(65, 21);
            lbl_Cuit.TabIndex = 11;
            lbl_Cuit.Text = "CUIT: ";
            // 
            // lbl_Subtotal
            // 
            lbl_Subtotal.AutoSize = true;
            lbl_Subtotal.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Subtotal.Location = new Point(502, 458);
            lbl_Subtotal.Margin = new Padding(4, 0, 4, 0);
            lbl_Subtotal.Name = "lbl_Subtotal";
            lbl_Subtotal.Size = new Size(101, 21);
            lbl_Subtotal.TabIndex = 12;
            lbl_Subtotal.Text = "Sub. Total";
            // 
            // lbl_IvaTotal
            // 
            lbl_IvaTotal.AutoSize = true;
            lbl_IvaTotal.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_IvaTotal.Location = new Point(483, 488);
            lbl_IvaTotal.Margin = new Padding(4, 0, 4, 0);
            lbl_IvaTotal.Name = "lbl_IvaTotal";
            lbl_IvaTotal.Size = new Size(120, 21);
            lbl_IvaTotal.TabIndex = 13;
            lbl_IvaTotal.Text = "IVA INSC...%";
            // 
            // lbl_RecargoTc
            // 
            lbl_RecargoTc.AutoSize = true;
            lbl_RecargoTc.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_RecargoTc.Location = new Point(462, 519);
            lbl_RecargoTc.Margin = new Padding(4, 0, 4, 0);
            lbl_RecargoTc.Name = "lbl_RecargoTc";
            lbl_RecargoTc.Size = new Size(141, 21);
            lbl_RecargoTc.TabIndex = 14;
            lbl_RecargoTc.Text = "Recargo TC %5";
            // 
            // lbl_TotalFactura
            // 
            lbl_TotalFactura.AutoSize = true;
            lbl_TotalFactura.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_TotalFactura.Location = new Point(520, 549);
            lbl_TotalFactura.Margin = new Padding(4, 0, 4, 0);
            lbl_TotalFactura.Name = "lbl_TotalFactura";
            lbl_TotalFactura.Size = new Size(83, 21);
            lbl_TotalFactura.TabIndex = 15;
            lbl_TotalFactura.Text = "TOTAL :";
            // 
            // dgv_ListaDeProductos
            // 
            dgv_ListaDeProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ListaDeProductos.Location = new Point(76, 203);
            dgv_ListaDeProductos.Margin = new Padding(4, 3, 4, 3);
            dgv_ListaDeProductos.Name = "dgv_ListaDeProductos";
            dgv_ListaDeProductos.RowHeadersWidth = 62;
            dgv_ListaDeProductos.RowTemplate.Height = 33;
            dgv_ListaDeProductos.Size = new Size(728, 232);
            dgv_ListaDeProductos.TabIndex = 16;
            // 
            // btn_VolverAtras
            // 
            btn_VolverAtras.Location = new Point(152, 541);
            btn_VolverAtras.Margin = new Padding(4, 3, 4, 3);
            btn_VolverAtras.Name = "btn_VolverAtras";
            btn_VolverAtras.Size = new Size(123, 29);
            btn_VolverAtras.TabIndex = 17;
            btn_VolverAtras.Text = "Atras";
            btn_VolverAtras.UseVisualStyleBackColor = true;
            btn_VolverAtras.Click += btn_VolverAtras_Click;
            // 
            // FrmGeneradorDeFactura
            // 
            AutoScaleDimensions = new SizeF(11F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(890, 603);
            Controls.Add(btn_VolverAtras);
            Controls.Add(dgv_ListaDeProductos);
            Controls.Add(lbl_TotalFactura);
            Controls.Add(lbl_RecargoTc);
            Controls.Add(lbl_IvaTotal);
            Controls.Add(lbl_Subtotal);
            Controls.Add(lbl_Cuit);
            Controls.Add(lbl_NombreFc);
            Controls.Add(lbl_NumeroFactura);
            Controls.Add(label7);
            Controls.Add(lbl_Fecha);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbl_CarniceriaRes);
            Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmGeneradorDeFactura";
            Text = "Factura";
            Load += FrmGeneradorDeFactura_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_ListaDeProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_CarniceriaRes;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label lbl_Fecha;
        private Label label7;
        private Label lbl_NumeroFactura;
        private Label lbl_NombreFc;
        private Label lbl_Cuit;
        private Label lbl_Subtotal;
        private Label lbl_IvaTotal;
        private Label lbl_RecargoTc;
        private Label lbl_TotalFactura;
        private DataGridView dgv_ListaDeProductos;
        private Button btn_VolverAtras;
    }
}