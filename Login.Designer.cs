namespace VisualParcial1
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            txb_nombreUsuario = new TextBox();
            txb_contrasenia = new TextBox();
            label1 = new Label();
            btn_Cliente = new Button();
            btn_Vendedor = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // txb_nombreUsuario
            // 
            txb_nombreUsuario.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txb_nombreUsuario.Location = new Point(145, 272);
            txb_nombreUsuario.Margin = new Padding(4, 3, 4, 3);
            txb_nombreUsuario.Name = "txb_nombreUsuario";
            txb_nombreUsuario.PlaceholderText = "usuario@FmCarnes.com";
            txb_nombreUsuario.Size = new Size(269, 29);
            txb_nombreUsuario.TabIndex = 0;
            txb_nombreUsuario.TextChanged += txb_nombreUsuario_TextChanged;
            // 
            // txb_contrasenia
            // 
            txb_contrasenia.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txb_contrasenia.Location = new Point(145, 321);
            txb_contrasenia.Margin = new Padding(4, 3, 4, 3);
            txb_contrasenia.Name = "txb_contrasenia";
            txb_contrasenia.PasswordChar = '*';
            txb_contrasenia.PlaceholderText = "Contrasenia";
            txb_contrasenia.Size = new Size(269, 29);
            txb_contrasenia.TabIndex = 1;
            txb_contrasenia.TextChanged += txb_contrasenia_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Fax", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.MenuBar;
            label1.Location = new Point(145, 36);
            label1.Name = "label1";
            label1.Size = new Size(210, 27);
            label1.TabIndex = 4;
            label1.Text = "FM Carnes S.R.L";
            // 
            // btn_Cliente
            // 
            btn_Cliente.ForeColor = Color.Black;
            btn_Cliente.Location = new Point(71, 384);
            btn_Cliente.Name = "btn_Cliente";
            btn_Cliente.Size = new Size(158, 32);
            btn_Cliente.TabIndex = 5;
            btn_Cliente.Text = "Cliente";
            btn_Cliente.UseVisualStyleBackColor = true;
            btn_Cliente.Click += btn_Cliente_Click;
            // 
            // btn_Vendedor
            // 
            btn_Vendedor.ForeColor = Color.Black;
            btn_Vendedor.Location = new Point(301, 384);
            btn_Vendedor.Name = "btn_Vendedor";
            btn_Vendedor.Size = new Size(158, 32);
            btn_Vendedor.TabIndex = 6;
            btn_Vendedor.Text = "Vendedor";
            btn_Vendedor.UseVisualStyleBackColor = true;
            btn_Vendedor.Click += btn_Vendedor_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(181, 77);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 152);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(106, 272);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 29);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(104, 321);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(37, 35);
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(12F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlText;
            ClientSize = new Size(508, 456);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btn_Vendedor);
            Controls.Add(btn_Cliente);
            Controls.Add(label1);
            Controls.Add(txb_contrasenia);
            Controls.Add(txb_nombreUsuario);
            Font = new Font("Lucida Fax", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Usuario";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txb_nombreUsuario;
        private TextBox txb_contrasenia;
        private Label label1;
        private Button btn_Cliente;
        private Button btn_Vendedor;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}