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
            label5 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            btn_Atras = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgv_ListaDeProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbl_CarniceriaRes
            // 
            lbl_CarniceriaRes.AutoSize = true;
            lbl_CarniceriaRes.Font = new Font("Lucida Sans", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_CarniceriaRes.ForeColor = SystemColors.MenuBar;
            lbl_CarniceriaRes.Location = new Point(54, 73);
            lbl_CarniceriaRes.Margin = new Padding(4, 0, 4, 0);
            lbl_CarniceriaRes.Name = "lbl_CarniceriaRes";
            lbl_CarniceriaRes.Size = new Size(131, 23);
            lbl_CarniceriaRes.TabIndex = 0;
            lbl_CarniceriaRes.Text = "FM CARNES";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.MenuBar;
            label1.Location = new Point(88, 96);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(58, 23);
            label1.TabIndex = 1;
            label1.Text = "S.R.L";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Sans", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.MenuBar;
            label2.Location = new Point(70, 185);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(165, 18);
            label2.TabIndex = 2;
            label2.Text = "CUIT: 30-1111111-2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Sans", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.MenuBar;
            label3.Location = new Point(39, 158);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(373, 18);
            label3.TabIndex = 3;
            label3.Text = "Donovan y Camino Gral. Chamizo 820, GERLI";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Sans", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.MenuBar;
            label4.Location = new Point(129, 212);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(184, 18);
            label4.TabIndex = 4;
            label4.Text = "IVA RESP. INSCRIPTO";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Lucida Sans", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.MenuBar;
            label6.Location = new Point(243, 185);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(133, 18);
            label6.TabIndex = 6;
            label6.Text = "TEL. 4574 6521";
            // 
            // lbl_Fecha
            // 
            lbl_Fecha.AutoSize = true;
            lbl_Fecha.Font = new Font("Lucida Sans", 8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Fecha.ForeColor = SystemColors.MenuBar;
            lbl_Fecha.Location = new Point(448, 96);
            lbl_Fecha.Margin = new Padding(4, 0, 4, 0);
            lbl_Fecha.Name = "lbl_Fecha";
            lbl_Fecha.Size = new Size(65, 18);
            lbl_Fecha.TabIndex = 7;
            lbl_Fecha.Text = "Fecha: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Lucida Sans", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.MenuBar;
            label7.Location = new Point(446, 28);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(144, 23);
            label7.TabIndex = 8;
            label7.Text = "FACTURA \"A\"";
            // 
            // lbl_NumeroFactura
            // 
            lbl_NumeroFactura.AutoSize = true;
            lbl_NumeroFactura.Font = new Font("Lucida Sans", 8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_NumeroFactura.ForeColor = SystemColors.MenuBar;
            lbl_NumeroFactura.Location = new Point(448, 78);
            lbl_NumeroFactura.Margin = new Padding(4, 0, 4, 0);
            lbl_NumeroFactura.Name = "lbl_NumeroFactura";
            lbl_NumeroFactura.Size = new Size(103, 18);
            lbl_NumeroFactura.TabIndex = 9;
            lbl_NumeroFactura.Text = "Nº00000-00";
            // 
            // lbl_NombreFc
            // 
            lbl_NombreFc.AutoSize = true;
            lbl_NombreFc.Font = new Font("Lucida Sans", 8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_NombreFc.ForeColor = SystemColors.MenuBar;
            lbl_NombreFc.Location = new Point(448, 114);
            lbl_NombreFc.Margin = new Padding(4, 0, 4, 0);
            lbl_NombreFc.Name = "lbl_NombreFc";
            lbl_NombreFc.Size = new Size(91, 18);
            lbl_NombreFc.TabIndex = 10;
            lbl_NombreFc.Text = "Señor/es: ";
            // 
            // lbl_Cuit
            // 
            lbl_Cuit.AutoSize = true;
            lbl_Cuit.Font = new Font("Lucida Sans", 8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Cuit.ForeColor = SystemColors.MenuBar;
            lbl_Cuit.Location = new Point(448, 132);
            lbl_Cuit.Margin = new Padding(4, 0, 4, 0);
            lbl_Cuit.Name = "lbl_Cuit";
            lbl_Cuit.Size = new Size(57, 18);
            lbl_Cuit.TabIndex = 11;
            lbl_Cuit.Text = "CUIT: ";
            // 
            // lbl_Subtotal
            // 
            lbl_Subtotal.AutoSize = true;
            lbl_Subtotal.Font = new Font("Lucida Sans", 8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Subtotal.ForeColor = SystemColors.MenuBar;
            lbl_Subtotal.Location = new Point(572, 532);
            lbl_Subtotal.Margin = new Padding(4, 0, 4, 0);
            lbl_Subtotal.Name = "lbl_Subtotal";
            lbl_Subtotal.Size = new Size(18, 18);
            lbl_Subtotal.TabIndex = 12;
            lbl_Subtotal.Text = "0";
            // 
            // lbl_IvaTotal
            // 
            lbl_IvaTotal.AutoSize = true;
            lbl_IvaTotal.Font = new Font("Lucida Sans", 8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_IvaTotal.ForeColor = SystemColors.MenuBar;
            lbl_IvaTotal.Location = new Point(572, 557);
            lbl_IvaTotal.Margin = new Padding(4, 0, 4, 0);
            lbl_IvaTotal.Name = "lbl_IvaTotal";
            lbl_IvaTotal.Size = new Size(18, 18);
            lbl_IvaTotal.TabIndex = 13;
            lbl_IvaTotal.Text = "0";
            // 
            // lbl_RecargoTc
            // 
            lbl_RecargoTc.AutoSize = true;
            lbl_RecargoTc.Font = new Font("Lucida Sans", 8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_RecargoTc.ForeColor = SystemColors.MenuBar;
            lbl_RecargoTc.Location = new Point(572, 584);
            lbl_RecargoTc.Margin = new Padding(4, 0, 4, 0);
            lbl_RecargoTc.Name = "lbl_RecargoTc";
            lbl_RecargoTc.Size = new Size(18, 18);
            lbl_RecargoTc.TabIndex = 14;
            lbl_RecargoTc.Text = "0";
            // 
            // lbl_TotalFactura
            // 
            lbl_TotalFactura.AutoSize = true;
            lbl_TotalFactura.Font = new Font("Lucida Sans", 8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_TotalFactura.ForeColor = SystemColors.MenuBar;
            lbl_TotalFactura.Location = new Point(572, 610);
            lbl_TotalFactura.Margin = new Padding(4, 0, 4, 0);
            lbl_TotalFactura.Name = "lbl_TotalFactura";
            lbl_TotalFactura.Size = new Size(18, 18);
            lbl_TotalFactura.TabIndex = 15;
            lbl_TotalFactura.Text = "0";
            // 
            // dgv_ListaDeProductos
            // 
            dgv_ListaDeProductos.AllowDrop = true;
            dgv_ListaDeProductos.AllowUserToAddRows = false;
            dgv_ListaDeProductos.AllowUserToDeleteRows = false;
            dgv_ListaDeProductos.AllowUserToResizeColumns = false;
            dgv_ListaDeProductos.AllowUserToResizeRows = false;
            dgv_ListaDeProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ListaDeProductos.Location = new Point(39, 265);
            dgv_ListaDeProductos.Margin = new Padding(4, 3, 4, 3);
            dgv_ListaDeProductos.Name = "dgv_ListaDeProductos";
            dgv_ListaDeProductos.ReadOnly = true;
            dgv_ListaDeProductos.RowHeadersWidth = 4;
            dgv_ListaDeProductos.RowTemplate.Height = 33;
            dgv_ListaDeProductos.Size = new Size(642, 245);
            dgv_ListaDeProductos.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lucida Sans", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.MenuBar;
            label5.Location = new Point(417, 584);
            label5.Name = "label5";
            label5.Size = new Size(129, 18);
            label5.TabIndex = 17;
            label5.Text = "Recargo TC %5";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Lucida Sans", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.MenuBar;
            label8.Location = new Point(417, 610);
            label8.Name = "label8";
            label8.Size = new Size(71, 18);
            label8.TabIndex = 18;
            label8.Text = "TOTAL :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Lucida Sans", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.MenuBar;
            label9.Location = new Point(417, 557);
            label9.Name = "label9";
            label9.Size = new Size(105, 18);
            label9.TabIndex = 19;
            label9.Text = "IVA INSC...%";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Lucida Sans", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.MenuBar;
            label10.Location = new Point(417, 532);
            label10.Name = "label10";
            label10.Size = new Size(98, 18);
            label10.TabIndex = 20;
            label10.Text = "Sub. Total: ";
            // 
            // btn_Atras
            // 
            btn_Atras.Location = new Point(117, 580);
            btn_Atras.Name = "btn_Atras";
            btn_Atras.Size = new Size(146, 48);
            btn_Atras.TabIndex = 21;
            btn_Atras.Text = "Atras";
            btn_Atras.UseVisualStyleBackColor = true;
            btn_Atras.Click += btn_Atras_Click;
            btn_Atras.MouseEnter += btn_Atras_MouseEnter;
            btn_Atras.MouseLeave += btn_Atras_MouseLeave;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(212, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(101, 104);
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // FrmGeneradorDeFactura
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuText;
            ClientSize = new Size(737, 670);
            Controls.Add(pictureBox1);
            Controls.Add(btn_Atras);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label5);
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
            Font = new Font("Lucida Sans", 8F, FontStyle.Bold, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmGeneradorDeFactura";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Factura";
            Load += FrmGeneradorDeFactura_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_ListaDeProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Label label5;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button btn_Atras;
        private PictureBox pictureBox1;
    }
}