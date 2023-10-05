namespace ModernGUI_V3.Ventanas
{
    partial class ExportarExcelCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExportarExcelCategoria));
            this.lblResultadoComparacion = new System.Windows.Forms.Label();
            this.dgvResultadoComparacion = new System.Windows.Forms.DataGridView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnExportar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadoComparacion)).BeginInit();
            this.SuspendLayout();
            // 
            // lblResultadoComparacion
            // 
            this.lblResultadoComparacion.AutoSize = true;
            this.lblResultadoComparacion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoComparacion.Location = new System.Drawing.Point(564, 9);
            this.lblResultadoComparacion.Name = "lblResultadoComparacion";
            this.lblResultadoComparacion.Size = new System.Drawing.Size(277, 19);
            this.lblResultadoComparacion.TabIndex = 10;
            this.lblResultadoComparacion.Text = "Resultado de Comparación Contra ";
            // 
            // dgvResultadoComparacion
            // 
            this.dgvResultadoComparacion.AllowUserToAddRows = false;
            this.dgvResultadoComparacion.AllowUserToDeleteRows = false;
            this.dgvResultadoComparacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultadoComparacion.Location = new System.Drawing.Point(12, 38);
            this.dgvResultadoComparacion.Name = "dgvResultadoComparacion";
            this.dgvResultadoComparacion.ReadOnly = true;
            this.dgvResultadoComparacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultadoComparacion.Size = new System.Drawing.Size(1278, 388);
            this.dgvResultadoComparacion.TabIndex = 9;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "iconfinder_logo_brand_brands_logos_excel_2993694.png");
            this.imageList1.Images.SetKeyName(1, "iconfinder_Delete_1493279.png");
            // 
            // btnExportar
            // 
            this.btnExportar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnExportar.FlatAppearance.BorderSize = 0;
            this.btnExportar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnExportar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportar.ImageIndex = 0;
            this.btnExportar.ImageList = this.imageList1;
            this.btnExportar.Location = new System.Drawing.Point(595, 433);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(113, 50);
            this.btnExportar.TabIndex = 11;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // ExportarExcelCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 487);
            this.Controls.Add(this.lblResultadoComparacion);
            this.Controls.Add(this.dgvResultadoComparacion);
            this.Controls.Add(this.btnExportar);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ExportarExcelCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EXPORTAR A EXCEL";
            this.Load += new System.EventHandler(this.ExportarExcelCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadoComparacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResultadoComparacion;
        private System.Windows.Forms.DataGridView dgvResultadoComparacion;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnExportar;
    }
}