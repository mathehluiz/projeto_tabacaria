namespace Projeto_Tabacaria.View.Inventory
{
    partial class DeleteGroup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteGroup));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblReturnDB = new System.Windows.Forms.Label();
            this.lblDeleteGroup = new System.Windows.Forms.Label();
            this.bntDeleteGroup = new Projeto_Tabacaria.Models.MNButton();
            this.cmbGroups = new System.Windows.Forms.ComboBox();
            this.refreshDeleteGroup = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(250, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblReturnDB
            // 
            this.lblReturnDB.AutoSize = true;
            this.lblReturnDB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReturnDB.ForeColor = System.Drawing.SystemColors.Control;
            this.lblReturnDB.Location = new System.Drawing.Point(70, 94);
            this.lblReturnDB.Name = "lblReturnDB";
            this.lblReturnDB.Size = new System.Drawing.Size(93, 19);
            this.lblReturnDB.TabIndex = 30;
            this.lblReturnDB.Text = "Return DB";
            // 
            // lblDeleteGroup
            // 
            this.lblDeleteGroup.AutoSize = true;
            this.lblDeleteGroup.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDeleteGroup.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDeleteGroup.Location = new System.Drawing.Point(40, 9);
            this.lblDeleteGroup.Name = "lblDeleteGroup";
            this.lblDeleteGroup.Size = new System.Drawing.Size(180, 28);
            this.lblDeleteGroup.TabIndex = 29;
            this.lblDeleteGroup.Text = "DELETAR GRUPO";
            // 
            // bntDeleteGroup
            // 
            this.bntDeleteGroup.BackColor = System.Drawing.Color.Teal;
            this.bntDeleteGroup.BackgroundColor = System.Drawing.Color.Teal;
            this.bntDeleteGroup.BorderColor = System.Drawing.Color.Teal;
            this.bntDeleteGroup.BorderRadius = 10;
            this.bntDeleteGroup.BorderSize = 0;
            this.bntDeleteGroup.FlatAppearance.BorderSize = 0;
            this.bntDeleteGroup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bntDeleteGroup.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bntDeleteGroup.ForeColor = System.Drawing.Color.White;
            this.bntDeleteGroup.Image = global::Projeto_Tabacaria.Properties.Resources.lixeira_de_reciclagem;
            this.bntDeleteGroup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntDeleteGroup.Location = new System.Drawing.Point(59, 130);
            this.bntDeleteGroup.Name = "bntDeleteGroup";
            this.bntDeleteGroup.Size = new System.Drawing.Size(150, 40);
            this.bntDeleteGroup.TabIndex = 28;
            this.bntDeleteGroup.Text = "Delete";
            this.bntDeleteGroup.TextColor = System.Drawing.Color.White;
            this.bntDeleteGroup.UseVisualStyleBackColor = false;
            this.bntDeleteGroup.Click += new System.EventHandler(this.bntDeleteGroup_Click);
            // 
            // cmbGroups
            // 
            this.cmbGroups.FormattingEnabled = true;
            this.cmbGroups.Location = new System.Drawing.Point(40, 59);
            this.cmbGroups.Name = "cmbGroups";
            this.cmbGroups.Size = new System.Drawing.Size(194, 23);
            this.cmbGroups.TabIndex = 32;
            // 
            // refreshDeleteGroup
            // 
            this.refreshDeleteGroup.Tick += new System.EventHandler(this.refreshDeleteGroup_Tick);
            // 
            // DeleteGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(290, 194);
            this.Controls.Add(this.cmbGroups);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblReturnDB);
            this.Controls.Add(this.lblDeleteGroup);
            this.Controls.Add(this.bntDeleteGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeleteGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteGroup";
            this.Load += new System.EventHandler(this.DeleteGroup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblReturnDB;
        private Label lblDeleteGroup;
        private Models.MNButton bntDeleteGroup;
        private ComboBox cmbGroups;
        private System.Windows.Forms.Timer refreshDeleteGroup;
    }
}