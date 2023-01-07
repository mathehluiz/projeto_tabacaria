namespace Projeto_Tabacaria.View.Inventory
{
    partial class RegisterBrand
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterBrand));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblReturnDB = new System.Windows.Forms.Label();
            this.lblRegisterGroup = new System.Windows.Forms.Label();
            this.bntRegGroup = new Projeto_Tabacaria.Models.MNButton();
            this.txtBrandName = new System.Windows.Forms.TextBox();
            this.cmbGroup = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(263, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblReturnDB
            // 
            this.lblReturnDB.AutoSize = true;
            this.lblReturnDB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReturnDB.ForeColor = System.Drawing.SystemColors.Control;
            this.lblReturnDB.Location = new System.Drawing.Point(80, 168);
            this.lblReturnDB.Name = "lblReturnDB";
            this.lblReturnDB.Size = new System.Drawing.Size(93, 19);
            this.lblReturnDB.TabIndex = 31;
            this.lblReturnDB.Text = "Return DB";
            // 
            // lblRegisterGroup
            // 
            this.lblRegisterGroup.AutoSize = true;
            this.lblRegisterGroup.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRegisterGroup.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRegisterGroup.Location = new System.Drawing.Point(35, 9);
            this.lblRegisterGroup.Name = "lblRegisterGroup";
            this.lblRegisterGroup.Size = new System.Drawing.Size(209, 28);
            this.lblRegisterGroup.TabIndex = 30;
            this.lblRegisterGroup.Text = "REGISTRAR MARCA";
            // 
            // bntRegGroup
            // 
            this.bntRegGroup.BackColor = System.Drawing.Color.Teal;
            this.bntRegGroup.BackgroundColor = System.Drawing.Color.Teal;
            this.bntRegGroup.BorderColor = System.Drawing.Color.Teal;
            this.bntRegGroup.BorderRadius = 10;
            this.bntRegGroup.BorderSize = 0;
            this.bntRegGroup.FlatAppearance.BorderSize = 0;
            this.bntRegGroup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bntRegGroup.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bntRegGroup.ForeColor = System.Drawing.Color.White;
            this.bntRegGroup.Location = new System.Drawing.Point(80, 211);
            this.bntRegGroup.Name = "bntRegGroup";
            this.bntRegGroup.Size = new System.Drawing.Size(150, 40);
            this.bntRegGroup.TabIndex = 3;
            this.bntRegGroup.Text = "Registrar";
            this.bntRegGroup.TextColor = System.Drawing.Color.White;
            this.bntRegGroup.UseVisualStyleBackColor = false;
            this.bntRegGroup.Click += new System.EventHandler(this.bntRegGroup_Click);
            // 
            // txtBrandName
            // 
            this.txtBrandName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBrandName.Location = new System.Drawing.Point(12, 111);
            this.txtBrandName.Name = "txtBrandName";
            this.txtBrandName.PlaceholderText = "Nome da Marca";
            this.txtBrandName.Size = new System.Drawing.Size(286, 22);
            this.txtBrandName.TabIndex = 2;
            this.txtBrandName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBrandName_KeyPress);
            // 
            // cmbGroup
            // 
            this.cmbGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGroup.FormattingEnabled = true;
            this.cmbGroup.Location = new System.Drawing.Point(12, 66);
            this.cmbGroup.Name = "cmbGroup";
            this.cmbGroup.Size = new System.Drawing.Size(286, 23);
            this.cmbGroup.TabIndex = 1;
            // 
            // RegisterBrand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(310, 282);
            this.Controls.Add(this.cmbGroup);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblReturnDB);
            this.Controls.Add(this.lblRegisterGroup);
            this.Controls.Add(this.bntRegGroup);
            this.Controls.Add(this.txtBrandName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegisterBrand";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterBrand";
            this.Load += new System.EventHandler(this.RegisterBrand_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblReturnDB;
        private Label lblRegisterGroup;
        private Models.MNButton bntRegGroup;
        private TextBox txtBrandName;
        private ComboBox cmbGroup;
    }
}