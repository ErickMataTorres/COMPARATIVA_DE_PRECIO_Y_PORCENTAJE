namespace ModernGUI_V3.Ventanas
{
    partial class ComparativaCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComparativaCategoria));
            this.lblMedida = new System.Windows.Forms.Label();
            this.cbMedida = new System.Windows.Forms.ComboBox();
            this.dgvLlantiRed = new System.Windows.Forms.DataGridView();
            this.dgvEcommerce = new System.Windows.Forms.DataGridView();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.cbEcommerce = new System.Windows.Forms.ComboBox();
            this.lblEcommerce = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLlantiRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEcommerce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMedida
            // 
            this.lblMedida.AutoSize = true;
            this.lblMedida.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedida.Location = new System.Drawing.Point(9, 118);
            this.lblMedida.Name = "lblMedida";
            this.lblMedida.Size = new System.Drawing.Size(64, 18);
            this.lblMedida.TabIndex = 0;
            this.lblMedida.Text = "Médida:";
            // 
            // cbMedida
            // 
            this.cbMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMedida.FormattingEnabled = true;
            this.cbMedida.Location = new System.Drawing.Point(73, 112);
            this.cbMedida.Name = "cbMedida";
            this.cbMedida.Size = new System.Drawing.Size(281, 25);
            this.cbMedida.TabIndex = 1;
            this.cbMedida.SelectionChangeCommitted += new System.EventHandler(this.cbMedida_SelectionChangeCommitted);
            // 
            // dgvLlantiRed
            // 
            this.dgvLlantiRed.AllowUserToAddRows = false;
            this.dgvLlantiRed.AllowUserToDeleteRows = false;
            this.dgvLlantiRed.BackgroundColor = System.Drawing.Color.White;
            this.dgvLlantiRed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLlantiRed.Location = new System.Drawing.Point(12, 138);
            this.dgvLlantiRed.Name = "dgvLlantiRed";
            this.dgvLlantiRed.ReadOnly = true;
            this.dgvLlantiRed.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLlantiRed.Size = new System.Drawing.Size(457, 349);
            this.dgvLlantiRed.TabIndex = 4;
            // 
            // dgvEcommerce
            // 
            this.dgvEcommerce.AllowUserToAddRows = false;
            this.dgvEcommerce.AllowUserToDeleteRows = false;
            this.dgvEcommerce.BackgroundColor = System.Drawing.Color.White;
            this.dgvEcommerce.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEcommerce.Location = new System.Drawing.Point(475, 138);
            this.dgvEcommerce.Name = "dgvEcommerce";
            this.dgvEcommerce.ReadOnly = true;
            this.dgvEcommerce.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEcommerce.Size = new System.Drawing.Size(459, 349);
            this.dgvEcommerce.TabIndex = 5;
            // 
            // btnCalcular
            // 
            this.btnCalcular.FlatAppearance.BorderSize = 0;
            this.btnCalcular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.btnCalcular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Image = ((System.Drawing.Image)(resources.GetObject("btnCalcular.Image")));
            this.btnCalcular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalcular.Location = new System.Drawing.Point(415, 493);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(113, 50);
            this.btnCalcular.TabIndex = 10;
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
            // cbEcommerce
            // 
            this.cbEcommerce.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEcommerce.FormattingEnabled = true;
            this.cbEcommerce.Location = new System.Drawing.Point(571, 107);
            this.cbEcommerce.Name = "cbEcommerce";
            this.cbEcommerce.Size = new System.Drawing.Size(363, 25);
            this.cbEcommerce.TabIndex = 12;
            this.cbEcommerce.SelectionChangeCommitted += new System.EventHandler(this.cbEcommerce_SelectionChangeCommitted);
            // 
            // lblEcommerce
            // 
            this.lblEcommerce.AutoSize = true;
            this.lblEcommerce.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEcommerce.Location = new System.Drawing.Point(472, 115);
            this.lblEcommerce.Name = "lblEcommerce";
            this.lblEcommerce.Size = new System.Drawing.Size(95, 18);
            this.lblEcommerce.TabIndex = 11;
            this.lblEcommerce.Text = "Ecommerce:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(73, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(281, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(72, 108);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(611, 9);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(264, 92);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // ComparativaCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 555);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbEcommerce);
            this.Controls.Add(this.lblEcommerce);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.dgvEcommerce);
            this.Controls.Add(this.dgvLlantiRed);
            this.Controls.Add(this.cbMedida);
            this.Controls.Add(this.lblMedida);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ComparativaCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " COMPARACIÓN LLANTA TOLEDO CONTRA TODAS LAS LLANTAS";
            this.Load += new System.EventHandler(this.ComparativaCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLlantiRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEcommerce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMedida;
        private System.Windows.Forms.ComboBox cbMedida;
        private System.Windows.Forms.DataGridView dgvLlantiRed;
        private System.Windows.Forms.DataGridView dgvEcommerce;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ComboBox cbEcommerce;
        private System.Windows.Forms.Label lblEcommerce;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}