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
            btn_Ingresar = new Button();
            btn_VolverAtras = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txb_nombreUsuario
            // 
            txb_nombreUsuario.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txb_nombreUsuario.Location = new Point(352, 116);
            txb_nombreUsuario.Margin = new Padding(4, 3, 4, 3);
            txb_nombreUsuario.Name = "txb_nombreUsuario";
            txb_nombreUsuario.PlaceholderText = "Usuario";
            txb_nombreUsuario.Size = new Size(269, 29);
            txb_nombreUsuario.TabIndex = 0;
            txb_nombreUsuario.TextChanged += txb_nombreUsuario_TextChanged;
            // 
            // txb_contrasenia
            // 
            txb_contrasenia.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txb_contrasenia.Location = new Point(352, 181);
            txb_contrasenia.Margin = new Padding(4, 3, 4, 3);
            txb_contrasenia.Name = "txb_contrasenia";
            txb_contrasenia.PasswordChar = '*';
            txb_contrasenia.PlaceholderText = "Contrasenia";
            txb_contrasenia.Size = new Size(269, 29);
            txb_contrasenia.TabIndex = 1;
            txb_contrasenia.TextChanged += txb_contrasenia_TextChanged;
            // 
            // btn_Ingresar
            // 
            btn_Ingresar.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Ingresar.Location = new Point(408, 237);
            btn_Ingresar.Margin = new Padding(4, 3, 4, 3);
            btn_Ingresar.Name = "btn_Ingresar";
            btn_Ingresar.Size = new Size(134, 29);
            btn_Ingresar.TabIndex = 2;
            btn_Ingresar.Text = "Ingresar";
            btn_Ingresar.UseVisualStyleBackColor = true;
            btn_Ingresar.Click += btn_Ingresar_Click;
            // 
            // btn_VolverAtras
            // 
            btn_VolverAtras.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_VolverAtras.Location = new Point(408, 295);
            btn_VolverAtras.Margin = new Padding(4, 3, 4, 3);
            btn_VolverAtras.Name = "btn_VolverAtras";
            btn_VolverAtras.Size = new Size(134, 29);
            btn_VolverAtras.TabIndex = 3;
            btn_VolverAtras.Text = "Atras";
            btn_VolverAtras.UseVisualStyleBackColor = true;
            btn_VolverAtras.Click += btn_VolverAtras_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Fax", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(371, 44);
            label1.Name = "label1";
            label1.Size = new Size(218, 27);
            label1.TabIndex = 4;
            label1.Text = "Carnes Res S.R.L";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(12F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(960, 378);
            Controls.Add(label1);
            Controls.Add(btn_VolverAtras);
            Controls.Add(btn_Ingresar);
            Controls.Add(txb_contrasenia);
            Controls.Add(txb_nombreUsuario);
            Font = new Font("Lucida Fax", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "Login";
            Text = "Login Usuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txb_nombreUsuario;
        private TextBox txb_contrasenia;
        private Button btn_Ingresar;
        private Button btn_VolverAtras;
        private Label label1;
    }
}