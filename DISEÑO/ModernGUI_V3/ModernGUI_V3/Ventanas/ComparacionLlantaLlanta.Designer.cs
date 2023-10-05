namespace ModernGUI_V3.Ventanas
{
    partial class ComparacionLlantaLlanta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComparacionLlantaLlanta));
            this.btnCalcular = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dgvProveedores = new System.Windows.Forms.DataGridView();
            this.dgvLlantiRed = new System.Windows.Forms.DataGridView();
            this.cbEcommerce = new System.Windows.Forms.ComboBox();
            this.lblEcommerce = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLlantiRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.FlatAppearance.BorderSize = 0;
            this.btnCalcular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCalcular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Image = ((System.Drawing.Image)(resources.GetObject("btnCalcular.Image")));
            this.btnCalcular.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCalcular.Location = new System.Drawing.Point(449, 431);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(139, 71);
            this.btnCalcular.TabIndex = 9;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "iconfinder_swf_3776.png");
            this.imageList1.Images.SetKeyName(1, "iconfinder_Streamline-29_185049.png");
            this.imageList1.Images.SetKeyName(2, "iconfinder_Delete_1493279.png");
            // 
            // dgvProveedores
            // 
            this.dgvProveedores.AllowUserToAddRows = false;
            this.dgvProveedores.AllowUserToDeleteRows = false;
            this.dgvProveedores.AllowUserToOrderColumns = true;
            this.dgvProveedores.BackgroundColor = System.Drawing.Color.White;
            this.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedores.Location = new System.Drawing.Point(519, 95);
            this.dgvProveedores.Name = "dgvProveedores";
            this.dgvProveedores.ReadOnly = true;
            this.dgvProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProveedores.Size = new System.Drawing.Size(500, 330);
            this.dgvProveedores.TabIndex = 8;
            // 
            // dgvLlantiRed
            // 
            this.dgvLlantiRed.AllowUserToAddRows = false;
            this.dgvLlantiRed.AllowUserToDeleteRows = false;
            this.dgvLlantiRed.AllowUserToOrderColumns = true;
            this.dgvLlantiRed.AllowUserToResizeRows = false;
            this.dgvLlantiRed.BackgroundColor = System.Drawing.Color.White;
            this.dgvLlantiRed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLlantiRed.Location = new System.Drawing.Point(12, 95);
            this.dgvLlantiRed.Name = "dgvLlantiRed";
            this.dgvLlantiRed.ReadOnly = true;
            this.dgvLlantiRed.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLlantiRed.Size = new System.Drawing.Size(500, 330);
            this.dgvLlantiRed.TabIndex = 7;
            // 
            // cbEcommerce
            // 
            this.cbEcommerce.FormattingEnabled = true;
            this.cbEcommerce.Location = new System.Drawing.Point(617, 64);
            this.cbEcommerce.Name = "cbEcommerce";
            this.cbEcommerce.Size = new System.Drawing.Size(380, 25);
            this.cbEcommerce.TabIndex = 10;
            this.cbEcommerce.SelectionChangeCommitted += new System.EventHandler(this.cbEcommerce_SelectionChangeCommitted);
            // 
            // lblEcommerce
            // 
            this.lblEcommerce.AutoSize = true;
            this.lblEcommerce.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEcommerce.Location = new System.Drawing.Point(516, 70);
            this.lblEcommerce.Name = "lblEcommerce";
            this.lblEcommerce.Size = new System.Drawing.Size(95, 18);
            this.lblEcommerce.TabIndex = 11;
            this.lblEcommerce.Text = "Ecommerce:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(155, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(320, 79);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // ComparacionLlantaLlanta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 525);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblEcommerce);
            this.Controls.Add(this.cbEcommerce);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.dgvProveedores);
            this.Controls.Add(this.dgvLlantiRed);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ComparacionLlantaLlanta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "COMPARACIÓN CONTRA TODAS LAS LLANTAS";
            this.Load += new System.EventHandler(this.ComparacionLlantaLlanta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLlantiRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.DataGridView dgvProveedores;
        private System.Windows.Forms.DataGridView dgvLlantiRed;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ComboBox cbEcommerce;
        private System.Windows.Forms.Label lblEcommerce;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}