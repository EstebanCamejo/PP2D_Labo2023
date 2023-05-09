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
            lbx_ListadoDeProductos = new ListBox();
            btn_bajaProducto = new Button();
            btn_VolverAtras = new Button();
            SuspendLayout();
            // 
            // btn_editarProducto
            // 
            btn_editarProducto.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_editarProducto.Location = new Point(667, 129);
            btn_editarProducto.Margin = new Padding(4, 3, 4, 3);
            btn_editarProducto.Name = "btn_editarProducto";
            btn_editarProducto.Size = new Size(142, 29);
            btn_editarProducto.TabIndex = 0;
            btn_editarProducto.Text = "Editar";
            btn_editarProducto.UseVisualStyleBackColor = true;
            btn_editarProducto.Click += btn_editarProducto_Click;
            // 
            // btn_nuevoProducto
            // 
            btn_nuevoProducto.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_nuevoProducto.Location = new Point(667, 73);
            btn_nuevoProducto.Margin = new Padding(4, 3, 4, 3);
            btn_nuevoProducto.Name = "btn_nuevoProducto";
            btn_nuevoProducto.Size = new Size(142, 29);
            btn_nuevoProducto.TabIndex = 1;
            btn_nuevoProducto.Text = "Nuevo";
            btn_nuevoProducto.UseVisualStyleBackColor = true;
            btn_nuevoProducto.Click += btn_nuevoProducto_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(272, 23);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(195, 27);
            label1.TabIndex = 2;
            label1.Text = "Stock Heladera";
            // 
            // lbx_ListadoDeProductos
            // 
            lbx_ListadoDeProductos.FormattingEnabled = true;
            lbx_ListadoDeProductos.ItemHeight = 21;
            lbx_ListadoDeProductos.Location = new Point(30, 71);
            lbx_ListadoDeProductos.Margin = new Padding(4, 3, 4, 3);
            lbx_ListadoDeProductos.Name = "lbx_ListadoDeProductos";
            lbx_ListadoDeProductos.Size = new Size(605, 445);
            lbx_ListadoDeProductos.TabIndex = 3;
            // 
            // btn_bajaProducto
            // 
            btn_bajaProducto.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_bajaProducto.Location = new Point(667, 184);
            btn_bajaProducto.Margin = new Padding(4, 3, 4, 3);
            btn_bajaProducto.Name = "btn_bajaProducto";
            btn_bajaProducto.Size = new Size(142, 29);
            btn_bajaProducto.TabIndex = 4;
            btn_bajaProducto.Text = "Baja";
            btn_bajaProducto.UseVisualStyleBackColor = true;
            btn_bajaProducto.Click += btn_bajaProducto_Click;
            // 
            // btn_VolverAtras
            // 
            btn_VolverAtras.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_VolverAtras.Location = new Point(667, 487);
            btn_VolverAtras.Margin = new Padding(4, 3, 4, 3);
            btn_VolverAtras.Name = "btn_VolverAtras";
            btn_VolverAtras.Size = new Size(142, 29);
            btn_VolverAtras.TabIndex = 5;
            btn_VolverAtras.Text = "Atras";
            btn_VolverAtras.UseVisualStyleBackColor = true;
            btn_VolverAtras.Click += btn_VolverAtras_Click;
            // 
            // AbmHeladera
            // 
            AutoScaleDimensions = new SizeF(12F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCoral;
            ClientSize = new Size(840, 560);
            Controls.Add(btn_VolverAtras);
            Controls.Add(btn_bajaProducto);
            Controls.Add(lbx_ListadoDeProductos);
            Controls.Add(label1);
            Controls.Add(btn_nuevoProducto);
            Controls.Add(btn_editarProducto);
            Font = new Font("Lucida Fax", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "AbmHeladera";
            Text = "Heladera";
            Load += AbmHeladera_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_editarProducto;
        private Button btn_nuevoProducto;
        private Label label1;
        private ListBox lbx_ListadoDeProductos;
        private Button btn_bajaProducto;
        private Button btn_VolverAtras;
    }
}