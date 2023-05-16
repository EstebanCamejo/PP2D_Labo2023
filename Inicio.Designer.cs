namespace VisualParcial1
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            label1 = new Label();
            btnVendedor = new Button();
            btnCliente = new Button();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(419, 153);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(111, 21);
            label1.TabIndex = 0;
            label1.Text = "Bienvenido";
            // 
            // btnVendedor
            // 
            btnVendedor.Font = new Font("Lucida Sans", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnVendedor.Location = new Point(618, 279);
            btnVendedor.Margin = new Padding(4, 3, 4, 3);
            btnVendedor.Name = "btnVendedor";
            btnVendedor.Size = new Size(173, 60);
            btnVendedor.TabIndex = 1;
            btnVendedor.Text = "Vendedor";
            btnVendedor.UseVisualStyleBackColor = true;
            //btnVendedor.Click += btnVendedor_Click;
            //btnVendedor.MouseLeave += btnVendedor_MouseLeave;
            //btnVendedor.MouseHover += btnVendedor_MouseHover;
            // 
            // btnCliente
            // 
            btnCliente.Font = new Font("Lucida Sans", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCliente.Location = new Point(187, 279);
            btnCliente.Margin = new Padding(4, 3, 4, 3);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(173, 60);
            btnCliente.TabIndex = 2;
            btnCliente.Text = "Cliente";
            btnCliente.UseVisualStyleBackColor = true;
            //btnCliente.Click += btnCliente_Click;
            //btnCliente.MouseLeave += btnCliente_MouseLeave;
            //btnCliente.MouseHover += btnCliente_MouseHover;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(290, 207);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(352, 21);
            label2.TabIndex = 3;
            label2.Text = "Por favor seleccione el tipo de usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(377, 81);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(226, 27);
            label3.TabIndex = 4;
            label3.Text = "CARNICERIA RES";
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(12F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(960, 378);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnCliente);
            Controls.Add(btnVendedor);
            Controls.Add(label1);
            Font = new Font("Lucida Fax", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = SystemColors.ActiveCaptionText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "Inicio";
            Text = "Carniceria RES";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnVendedor;
        private Button btnCliente;
        private Label label2;
        private Label label3;
    }
}