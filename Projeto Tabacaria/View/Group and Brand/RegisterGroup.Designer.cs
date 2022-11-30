namespace Projeto_Tabacaria.View.Inventory
{
    partial class RegisterGroup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterGroup));
            this.txtGroupName = new System.Windows.Forms.TextBox();
            this.bntRegGroup = new Projeto_Tabacaria.Models.MNButton();
            this.lblRegisterGroup = new System.Windows.Forms.Label();
            this.lblReturnDB = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtGroupName
            // 
            this.txtGroupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtGroupName.Location = new System.Drawing.Point(12, 62);
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.PlaceholderText = "Nome do Grupo";
            this.txtGroupName.Size = new System.Drawing.Size(287, 22);
            this.txtGroupName.TabIndex = 1;
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
            this.bntRegGroup.Location = new System.Drawing.Point(76, 147);
            this.bntRegGroup.Name = "bntRegGroup";
            this.bntRegGroup.Size = new System.Drawing.Size(150, 40);
            this.bntRegGroup.TabIndex = 2;
            this.bntRegGroup.Text = "Registrar";
            this.bntRegGroup.TextColor = System.Drawing.Color.White;
            this.bntRegGroup.UseVisualStyleBackColor = false;
            this.bntRegGroup.Click += new System.EventHandler(this.bntRegGroup_Click);
            // 
            // lblRegisterGroup
            // 
            this.lblRegisterGroup.AutoSize = true;
            this.lblRegisterGroup.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRegisterGroup.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRegisterGroup.Location = new System.Drawing.Point(45, 0);
            this.lblRegisterGroup.Name = "lblRegisterGroup";
            this.lblRegisterGroup.Size = new System.Drawing.Size(204, 28);
            this.lblRegisterGroup.TabIndex = 25;
            this.lblRegisterGroup.Text = "REGISTRAR GRUPO";
            // 
            // lblReturnDB
            // 
            this.lblReturnDB.AutoSize = true;
            this.lblReturnDB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReturnDB.ForeColor = System.Drawing.SystemColors.Control;
            this.lblReturnDB.Location = new System.Drawing.Point(76, 110);
            this.lblReturnDB.Name = "lblReturnDB";
            this.lblReturnDB.Size = new System.Drawing.Size(93, 19);
            this.lblReturnDB.TabIndex = 26;
            this.lblReturnDB.Text = "Return DB";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(275, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // RegisterGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(311, 208);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblReturnDB);
            this.Controls.Add(this.lblRegisterGroup);
            this.Controls.Add(this.bntRegGroup);
            this.Controls.Add(this.txtGroupName);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegisterGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterGroup";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtGroupName;
        private Models.MNButton bntRegGroup;
        private Label lblRegisterGroup;
        private Label lblReturnDB;
        private PictureBox pictureBox1;
    }
}