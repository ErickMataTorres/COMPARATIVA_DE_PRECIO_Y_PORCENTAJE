namespace ModernGUI_V3.Ventanas
{
    partial class ComparacionGeneral
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComparacionGeneral));
            this.cbMedida = new System.Windows.Forms.ComboBox();
            this.lblDiferenciaPorcentaje = new System.Windows.Forms.Label();
            this.txtDiferenciaPorcentaje = new System.Windows.Forms.TextBox();
            this.lblDiferenciaPrecio = new System.Windows.Forms.Label();
            this.txtDiferenciaPrecio = new System.Windows.Forms.TextBox();
            this.lblDiferencia = new System.Windows.Forms.Label();
            this.dgvLlantasProveedor = new System.Windows.Forms.DataGridView();
            this.dgvLlantiRed = new System.Windows.Forms.DataGridView();
            this.cbProveedor = new System.Windows.Forms.ComboBox();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.lblMedida = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLlantasProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLlantiRed)).BeginInit();
            this.SuspendLayout();
            // 
            // cbMedida
            // 
            this.cbMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMedida.FormattingEnabled = true;
            this.cbMedida.Location = new System.Drawing.Point(82, 12);
            this.cbMedida.Name = "cbMedida";
            this.cbMedida.Size = new System.Drawing.Size(217, 25);
            this.cbMedida.TabIndex = 22;
            this.cbMedida.TextChanged += new System.EventHandler(this.cbMedida_TextChanged);
            // 
            // lblDiferenciaPorcentaje
            // 
            this.lblDiferenciaPorcentaje.AutoSize = true;
            this.lblDiferenciaPorcentaje.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiferenciaPorcentaje.Location = new System.Drawing.Point(256, 403);
            this.lblDiferenciaPorcentaje.Name = "lblDiferenciaPorcentaje";
            this.lblDiferenciaPorcentaje.Size = new System.Drawing.Size(112, 18);
            this.lblDiferenciaPorcentaje.TabIndex = 21;
            this.lblDiferenciaPorcentaje.Text = "De porcentaje:";
            // 
            // txtDiferenciaPorcentaje
            // 
            this.txtDiferenciaPorcentaje.Location = new System.Drawing.Point(374, 400);
            this.txtDiferenciaPorcentaje.Name = "txtDiferenciaPorcentaje";
            this.txtDiferenciaPorcentaje.Size = new System.Drawing.Size(225, 25);
            this.txtDiferenciaPorcentaje.TabIndex = 20;
            // 
            // lblDiferenciaPrecio
            // 
            this.lblDiferenciaPrecio.AutoSize = true;
            this.lblDiferenciaPrecio.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiferenciaPrecio.Location = new System.Drawing.Point(293, 369);
            this.lblDiferenciaPrecio.Name = "lblDiferenciaPrecio";
            this.lblDiferenciaPrecio.Size = new System.Drawing.Size(81, 18);
            this.lblDiferenciaPrecio.TabIndex = 19;
            this.lblDiferenciaPrecio.Text = "De precio:";
            // 
            // txtDiferenciaPrecio
            // 
            this.txtDiferenciaPrecio.Location = new System.Drawing.Point(374, 368);
            this.txtDiferenciaPrecio.Name = "txtDiferenciaPrecio";
            this.txtDiferenciaPrecio.Size = new System.Drawing.Size(225, 25);
            this.txtDiferenciaPrecio.TabIndex = 18;
            // 
            // lblDiferencia
            // 
            this.lblDiferencia.AutoSize = true;
            this.lblDiferencia.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiferencia.Location = new System.Drawing.Point(371, 348);
            this.lblDiferencia.Name = "lblDiferencia";
            this.lblDiferencia.Size = new System.Drawing.Size(85, 18);
            this.lblDiferencia.TabIndex = 17;
            this.lblDiferencia.Text = "Diferencia:";
            // 
            // dgvLlantasProveedor
            // 
            this.dgvLlantasProveedor.AllowUserToAddRows = false;
            this.dgvLlantasProveedor.AllowUserToDeleteRows = false;
            this.dgvLlantasProveedor.AllowUserToResizeRows = false;
            this.dgvLlantasProveedor.BackgroundColor = System.Drawing.Color.White;
            this.dgvLlantasProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLlantasProveedor.Location = new System.Drawing.Point(436, 40);
            this.dgvLlantasProveedor.MultiSelect = false;
            this.dgvLlantasProveedor.Name = "dgvLlantasProveedor";
            this.dgvLlantasProveedor.ReadOnly = true;
            this.dgvLlantasProveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLlantasProveedor.Size = new System.Drawing.Size(398, 305);
            this.dgvLlantasProveedor.TabIndex = 16;
            this.dgvLlantasProveedor.SelectionChanged += new System.EventHandler(this.dgvLlantasProveedor_SelectionChanged);
            // 
            // dgvLlantiRed
            // 
            this.dgvLlantiRed.AllowUserToAddRows = false;
            this.dgvLlantiRed.AllowUserToDeleteRows = false;
            this.dgvLlantiRed.AllowUserToResizeRows = false;
            this.dgvLlantiRed.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLlantiRed.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLlantiRed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLlantiRed.Location = new System.Drawing.Point(12, 40);
            this.dgvLlantiRed.MultiSelect = false;
            this.dgvLlantiRed.Name = "dgvLlantiRed";
            this.dgvLlantiRed.ReadOnly = true;
            this.dgvLlantiRed.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLlantiRed.Size = new System.Drawing.Size(418, 305);
            this.dgvLlantiRed.TabIndex = 15;
            this.dgvLlantiRed.SelectionChanged += new System.EventHandler(this.dgvLlantiRed_SelectionChanged);
            // 
            // cbProveedor
            // 
            this.cbProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProveedor.FormattingEnabled = true;
            this.cbProveedor.Location = new System.Drawing.Point(537, 12);
            this.cbProveedor.Name = "cbProveedor";
            this.cbProveedor.Size = new System.Drawing.Size(215, 25);
            this.cbProveedor.TabIndex = 14;
            this.cbProveedor.SelectedValueChanged += new System.EventHandler(this.cbProveedor_SelectedValueChanged);
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedor.Location = new System.Drawing.Point(436, 19);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(95, 18);
            this.lblProveedor.TabIndex = 13;
            this.lblProveedor.Text = "Ecommerce:";
            // 
            // lblMedida
            // 
            this.lblMedida.AutoSize = true;
            this.lblMedida.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedida.Location = new System.Drawing.Point(12, 19);
            this.lblMedida.Name = "lblMedida";
            this.lblMedida.Size = new System.Drawing.Size(64, 18);
            this.lblMedida.TabIndex = 12;
            this.lblMedida.Text = "Médida:";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "iconfinder_Delete_1493279.png");
            this.imageList1.Images.SetKeyName(1, "iconfinder_Tick_31225.png");
            // 
            // ComparacionGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 433);
            this.Controls.Add(this.cbMedida);
            this.Controls.Add(this.lblDiferenciaPorcentaje);
            this.Controls.Add(this.txtDiferenciaPorcentaje);
            this.Controls.Add(this.lblDiferenciaPrecio);
            this.Controls.Add(this.txtDiferenciaPrecio);
            this.Controls.Add(this.lblDiferencia);
            this.Controls.Add(this.dgvLlantasProveedor);
            this.Controls.Add(this.dgvLlantiRed);
            this.Controls.Add(this.cbProveedor);
            this.Controls.Add(this.lblProveedor);
            this.Controls.Add(this.lblMedida);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ComparacionGeneral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "COMPARATIVA GENERAL POR SELECIÓN";
            this.Load += new System.EventHandler(this.ComparacionGeneral_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLlantasProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLlantiRed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMedida;
        private System.Windows.Forms.Label lblDiferenciaPorcentaje;
        private System.Windows.Forms.TextBox txtDiferenciaPorcentaje;
        private System.Windows.Forms.Label lblDiferenciaPrecio;
        private System.Windows.Forms.TextBox txtDiferenciaPrecio;
        private System.Windows.Forms.Label lblDiferencia;
        private System.Windows.Forms.DataGridView dgvLlantasProveedor;
        private System.Windows.Forms.DataGridView dgvLlantiRed;
        private System.Windows.Forms.ComboBox cbProveedor;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.Label lblMedida;
        private System.Windows.Forms.ImageList imageList1;
    }
}