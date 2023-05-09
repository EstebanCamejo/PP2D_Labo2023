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
            lbx_ListadoDeFactuaras = new ListBox();
            btn_VolverAtras = new Button();
            SuspendLayout();
            // 
            // lbl_TitularListadoFacturas
            // 
            lbl_TitularListadoFacturas.AutoSize = true;
            lbl_TitularListadoFacturas.Font = new Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_TitularListadoFacturas.Location = new Point(183, 29);
            lbl_TitularListadoFacturas.Margin = new Padding(4, 0, 4, 0);
            lbl_TitularListadoFacturas.Name = "lbl_TitularListadoFacturas";
            lbl_TitularListadoFacturas.Size = new Size(575, 27);
            lbl_TitularListadoFacturas.TabIndex = 0;
            lbl_TitularListadoFacturas.Text = "Las facturas efectuadas al dia de la fecha son:";
            // 
            // lbx_ListadoDeFactuaras
            // 
            lbx_ListadoDeFactuaras.FormattingEnabled = true;
            lbx_ListadoDeFactuaras.ItemHeight = 21;
            lbx_ListadoDeFactuaras.Location = new Point(36, 72);
            lbx_ListadoDeFactuaras.Margin = new Padding(4, 3, 4, 3);
            lbx_ListadoDeFactuaras.Name = "lbx_ListadoDeFactuaras";
            lbx_ListadoDeFactuaras.Size = new Size(919, 403);
            lbx_ListadoDeFactuaras.TabIndex = 1;
            // 
            // btn_VolverAtras
            // 
            btn_VolverAtras.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_VolverAtras.Location = new Point(751, 489);
            btn_VolverAtras.Margin = new Padding(4, 3, 4, 3);
            btn_VolverAtras.Name = "btn_VolverAtras";
            btn_VolverAtras.Size = new Size(204, 46);
            btn_VolverAtras.TabIndex = 2;
            btn_VolverAtras.Text = "Atras";
            btn_VolverAtras.UseVisualStyleBackColor = true;
            btn_VolverAtras.Click += btn_VolverAtras_Click;
            // 
            // FrmListadoDeFacturacion
            // 
            AutoScaleDimensions = new SizeF(12F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCoral;
            ClientSize = new Size(994, 557);
            Controls.Add(btn_VolverAtras);
            Controls.Add(lbx_ListadoDeFactuaras);
            Controls.Add(lbl_TitularListadoFacturas);
            Font = new Font("Lucida Fax", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmListadoDeFacturacion";
            Text = "Listado de Facturas";
            Load += FrmListadoDeFacturacion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_TitularListadoFacturas;
        private ListBox lbx_ListadoDeFactuaras;
        private Button btn_VolverAtras;
    }
}