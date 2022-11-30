namespace Projeto_Tabacaria.View.Inventory
{
    partial class DeleteBrand
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteBrand));
            this.cmbBrands = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblReturnDB = new System.Windows.Forms.Label();
            this.lblDeleteBrand = new System.Windows.Forms.Label();
            this.bntDeleteBrand = new Projeto_Tabacaria.Models.MNButton();
            this.refreshBrand = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbBrands
            // 
            this.cmbBrands.FormattingEnabled = true;
            this.cmbBrands.Location = new System.Drawing.Point(40, 62);
            this.cmbBrands.Name = "cmbBrands";
            this.cmbBrands.Size = new System.Drawing.Size(194, 23);
            this.cmbBrands.TabIndex = 37;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(250, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblReturnDB
            // 
            this.lblReturnDB.AutoSize = true;
            this.lblReturnDB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReturnDB.ForeColor = System.Drawing.SystemColors.Control;
            this.lblReturnDB.Location = new System.Drawing.Point(89, 109);
            this.lblReturnDB.Name = "lblReturnDB";
            this.lblReturnDB.Size = new System.Drawing.Size(93, 19);
            this.lblReturnDB.TabIndex = 35;
            this.lblReturnDB.Text = "Return DB";
            // 
            // lblDeleteBrand
            // 
            this.lblDeleteBrand.AutoSize = true;
            this.lblDeleteBrand.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDeleteBrand.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDeleteBrand.Location = new System.Drawing.Point(40, 9);
            this.lblDeleteBrand.Name = "lblDeleteBrand";
            this.lblDeleteBrand.Size = new System.Drawing.Size(185, 28);
            this.lblDeleteBrand.TabIndex = 34;
            this.lblDeleteBrand.Text = "DELETAR MARCA";
            // 
            // bntDeleteBrand
            // 
            this.bntDeleteBrand.BackColor = System.Drawing.Color.Teal;
            this.bntDeleteBrand.BackgroundColor = System.Drawing.Color.Teal;
            this.bntDeleteBrand.BorderColor = System.Drawing.Color.Teal;
            this.bntDeleteBrand.BorderRadius = 10;
            this.bntDeleteBrand.BorderSize = 0;
            this.bntDeleteBrand.FlatAppearance.BorderSize = 0;
            this.bntDeleteBrand.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bntDeleteBrand.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bntDeleteBrand.ForeColor = System.Drawing.Color.White;
            this.bntDeleteBrand.Image = global::Projeto_Tabacaria.Properties.Resources.lixeira_de_reciclagem;
            this.bntDeleteBrand.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntDeleteBrand.Location = new System.Drawing.Point(64, 131);
            this.bntDeleteBrand.Name = "bntDeleteBrand";
            this.bntDeleteBrand.Size = new System.Drawing.Size(150, 40);
            this.bntDeleteBrand.TabIndex = 38;
            this.bntDeleteBrand.Text = "Delete";
            this.bntDeleteBrand.TextColor = System.Drawing.Color.White;
            this.bntDeleteBrand.UseVisualStyleBackColor = false;
            this.bntDeleteBrand.Click += new System.EventHandler(this.bntDeleteBrand_Click);
            // 
            // refreshBrand
            // 
            this.refreshBrand.Tick += new System.EventHandler(this.refreshBrand_Tick);
            // 
            // DeleteBrand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(290, 194);
            this.Controls.Add(this.bntDeleteBrand);
            this.Controls.Add(this.cmbBrands);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblReturnDB);
            this.Controls.Add(this.lblDeleteBrand);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeleteBrand";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteBrand";
            this.Load += new System.EventHandler(this.DeleteBrand_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cmbBrands;
        private PictureBox pictureBox1;
        private Label lblReturnDB;
        private Label lblDeleteBrand;
        private Models.MNButton bntDeleteBrand;
        private System.Windows.Forms.Timer refreshBrand;
    }
}