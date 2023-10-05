namespace ModernGUI_V3.Ventanas
{
    partial class ComparacionFiltro
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComparacionFiltro));
            this.btnExportar = new System.Windows.Forms.Button();
            this.cbModelo = new System.Windows.Forms.ComboBox();
            this.lblECommerce = new System.Windows.Forms.Label();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.cbEcommerce = new System.Windows.Forms.ComboBox();
            this.dgvComparacion = new System.Windows.Forms.DataGridView();
            this.lblModelo = new System.Windows.Forms.Label();
            this.cbMedida = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblMedida = new System.Windows.Forms.Label();
            this.gbFiltro = new System.Windows.Forms.GroupBox();
            this.cbModo = new System.Windows.Forms.ComboBox();
            this.lblComoBuscar = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComparacion)).BeginInit();
            this.gbFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExportar
            // 
            this.btnExportar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExportar.FlatAppearance.BorderSize = 0;
            this.btnExportar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnExportar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.Image = ((System.Drawing.Image)(resources.GetObject("btnExportar.Image")));
            this.btnExportar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnExportar.Location = new System.Drawing.Point(320, 429);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(193, 35);
            this.btnExportar.TabIndex = 38;
            this.btnExportar.Text = "EXPORTAR A EXCEL";
            this.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.BtnExportar_Click);
            // 
            // cbModelo
            // 
            this.cbModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModelo.FormattingEnabled = true;
            this.cbModelo.Location = new System.Drawing.Point(97, 97);
            this.cbModelo.Name = "cbModelo";
            this.cbModelo.Size = new System.Drawing.Size(121, 26);
            this.cbModelo.TabIndex = 12;
            this.cbModelo.TextChanged += new System.EventHandler(this.CbModelo_TextChanged);
            // 
            // lblECommerce
            // 
            this.lblECommerce.AutoSize = true;
            this.lblECommerce.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblECommerce.Location = new System.Drawing.Point(325, 15);
            this.lblECommerce.Name = "lblECommerce";
            this.lblECommerce.Size = new System.Drawing.Size(118, 18);
            this.lblECommerce.TabIndex = 17;
            this.lblECommerce.Text = "E-COMMERCE:\r\n";
            // 
            // cbMarca
            // 
            this.cbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(97, 65);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(121, 26);
            this.cbMarca.TabIndex = 16;
            this.cbMarca.TextChanged += new System.EventHandler(this.CbMarca_TextChanged);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(18, 72);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(65, 18);
            this.lblMarca.TabIndex = 15;
            this.lblMarca.Text = "MARCA:";
            // 
            // cbEcommerce
            // 
            this.cbEcommerce.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEcommerce.FormattingEnabled = true;
            this.cbEcommerce.Location = new System.Drawing.Point(445, 15);
            this.cbEcommerce.Name = "cbEcommerce";
            this.cbEcommerce.Size = new System.Drawing.Size(176, 26);
            this.cbEcommerce.TabIndex = 18;
            this.cbEcommerce.SelectionChangeCommitted += new System.EventHandler(this.cbECommerce_SelectionChangeCommitted);
            // 
            // dgvComparacion
            // 
            this.dgvComparacion.AllowUserToAddRows = false;
            this.dgvComparacion.AllowUserToDeleteRows = false;
            this.dgvComparacion.BackgroundColor = System.Drawing.Color.White;
            this.dgvComparacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComparacion.Location = new System.Drawing.Point(15, 193);
            this.dgvComparacion.Name = "dgvComparacion";
            this.dgvComparacion.ReadOnly = true;
            this.dgvComparacion.Size = new System.Drawing.Size(868, 216);
            this.dgvComparacion.TabIndex = 31;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.Location = new System.Drawing.Point(12, 105);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(79, 18);
            this.lblModelo.TabIndex = 11;
            this.lblModelo.Text = "MODELO:";
            // 
            // cbMedida
            // 
            this.cbMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMedida.FormattingEnabled = true;
            this.cbMedida.Location = new System.Drawing.Point(97, 129);
            this.cbMedida.Name = "cbMedida";
            this.cbMedida.Size = new System.Drawing.Size(121, 26);
            this.cbMedida.TabIndex = 10;
            this.cbMedida.TextChanged += new System.EventHandler(this.CbMedida_TextChanged);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(627, 15);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(288, 25);
            this.dtpFecha.TabIndex = 7;
            // 
            // lblMedida
            // 
            this.lblMedida.AutoSize = true;
            this.lblMedida.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedida.Location = new System.Drawing.Point(16, 137);
            this.lblMedida.Name = "lblMedida";
            this.lblMedida.Size = new System.Drawing.Size(70, 18);
            this.lblMedida.TabIndex = 4;
            this.lblMedida.Text = "MEDIDA:";
            // 
            // gbFiltro
            // 
            this.gbFiltro.Controls.Add(this.cbModo);
            this.gbFiltro.Controls.Add(this.lblComoBuscar);
            this.gbFiltro.Controls.Add(this.cbEcommerce);
            this.gbFiltro.Controls.Add(this.lblECommerce);
            this.gbFiltro.Controls.Add(this.cbMarca);
            this.gbFiltro.Controls.Add(this.lblMarca);
            this.gbFiltro.Controls.Add(this.cbModelo);
            this.gbFiltro.Controls.Add(this.lblModelo);
            this.gbFiltro.Controls.Add(this.cbMedida);
            this.gbFiltro.Controls.Add(this.dtpFecha);
            this.gbFiltro.Controls.Add(this.lblMedida);
            this.gbFiltro.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbFiltro.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFiltro.Location = new System.Drawing.Point(0, 0);
            this.gbFiltro.Name = "gbFiltro";
            this.gbFiltro.Size = new System.Drawing.Size(915, 170);
            this.gbFiltro.TabIndex = 30;
            this.gbFiltro.TabStop = false;
            this.gbFiltro.Text = "BUSCAR LLANTA POR MEDIDA:";
            this.gbFiltro.Enter += new System.EventHandler(this.GbFiltro_Enter);
            // 
            // cbModo
            // 
            this.cbModo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModo.FormattingEnabled = true;
            this.cbModo.Items.AddRange(new object[] {
            "Específica",
            "General"});
            this.cbModo.Location = new System.Drawing.Point(135, 18);
            this.cbModo.Name = "cbModo";
            this.cbModo.Size = new System.Drawing.Size(178, 26);
            this.cbModo.TabIndex = 20;
            this.cbModo.SelectionChangeCommitted += new System.EventHandler(this.CbModo_SelectionChangeCommitted);
            this.cbModo.TextChanged += new System.EventHandler(this.CbModo_TextChanged);
            // 
            // lblComoBuscar
            // 
            this.lblComoBuscar.AutoSize = true;
            this.lblComoBuscar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComoBuscar.Location = new System.Drawing.Point(6, 18);
            this.lblComoBuscar.Name = "lblComoBuscar";
            this.lblComoBuscar.Size = new System.Drawing.Size(127, 18);
            this.lblComoBuscar.TabIndex = 19;
            this.lblComoBuscar.Text = "COMO BUSCAR:";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "iconfinder_Delete_1493279.png");
            this.imageList1.Images.SetKeyName(1, "iconfinder_Tick_31225.png");
            // 
            // ComparacionFiltro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 485);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.dgvComparacion);
            this.Controls.Add(this.gbFiltro);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ComparacionFiltro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "COMPARACIÓN POR FILTRO";
            this.Load += new System.EventHandler(this.ComparacionFiltro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComparacion)).EndInit();
            this.gbFiltro.ResumeLayout(false);
            this.gbFiltro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.ComboBox cbModelo;
        private System.Windows.Forms.Label lblECommerce;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.ComboBox cbEcommerce;
        private System.Windows.Forms.DataGridView dgvComparacion;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.ComboBox cbMedida;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblMedida;
        private System.Windows.Forms.GroupBox gbFiltro;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ComboBox cbModo;
        private System.Windows.Forms.Label lblComoBuscar;
    }
}