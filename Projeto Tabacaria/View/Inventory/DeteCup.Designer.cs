namespace Projeto_Tabacaria.View.Inventory
{
    partial class DeteCup
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
            this.lblRegisterGroup = new System.Windows.Forms.Label();
            this.cmbCupName = new System.Windows.Forms.ComboBox();
            this.lblReturnDB = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mnButton1 = new Projeto_Tabacaria.Models.MNButton();
            this.picCloseEditProduct = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCloseEditProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRegisterGroup
            // 
            this.lblRegisterGroup.AutoSize = true;
            this.lblRegisterGroup.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRegisterGroup.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRegisterGroup.Location = new System.Drawing.Point(36, 9);
            this.lblRegisterGroup.Name = "lblRegisterGroup";
            this.lblRegisterGroup.Size = new System.Drawing.Size(164, 28);
            this.lblRegisterGroup.TabIndex = 42;
            this.lblRegisterGroup.Text = "DELETAR COPO";
            // 
            // cmbCupName
            // 
            this.cmbCupName.FormattingEnabled = true;
            this.cmbCupName.Location = new System.Drawing.Point(72, 68);
            this.cmbCupName.Name = "cmbCupName";
            this.cmbCupName.Size = new System.Drawing.Size(132, 23);
            this.cmbCupName.TabIndex = 43;
            // 
            // lblReturnDB
            // 
            this.lblReturnDB.AutoSize = true;
            this.lblReturnDB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReturnDB.ForeColor = System.Drawing.SystemColors.Control;
            this.lblReturnDB.Location = new System.Drawing.Point(63, 125);
            this.lblReturnDB.Name = "lblReturnDB";
            this.lblReturnDB.Size = new System.Drawing.Size(93, 19);
            this.lblReturnDB.TabIndex = 44;
            this.lblReturnDB.Text = "Return DB";
            this.lblReturnDB.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(5, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 19);
            this.label1.TabIndex = 45;
            this.label1.Text = "Nome ";
            // 
            // mnButton1
            // 
            this.mnButton1.BackColor = System.Drawing.Color.Teal;
            this.mnButton1.BackgroundColor = System.Drawing.Color.Teal;
            this.mnButton1.BorderColor = System.Drawing.Color.Black;
            this.mnButton1.BorderRadius = 10;
            this.mnButton1.BorderSize = 0;
            this.mnButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mnButton1.FlatAppearance.BorderSize = 0;
            this.mnButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mnButton1.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mnButton1.ForeColor = System.Drawing.Color.White;
            this.mnButton1.Image = global::Projeto_Tabacaria.Properties.Resources.lixeira_de_reciclagem;
            this.mnButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnButton1.Location = new System.Drawing.Point(42, 156);
            this.mnButton1.Name = "mnButton1";
            this.mnButton1.Size = new System.Drawing.Size(134, 52);
            this.mnButton1.TabIndex = 49;
            this.mnButton1.Text = "  Deletar";
            this.mnButton1.TextColor = System.Drawing.Color.White;
            this.mnButton1.UseVisualStyleBackColor = false;
            this.mnButton1.Click += new System.EventHandler(this.mnButton1_Click);
            // 
            // picCloseEditProduct
            // 
            this.picCloseEditProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCloseEditProduct.Image = global::Projeto_Tabacaria.Properties.Resources.close_correto;
            this.picCloseEditProduct.Location = new System.Drawing.Point(201, 0);
            this.picCloseEditProduct.Name = "picCloseEditProduct";
            this.picCloseEditProduct.Size = new System.Drawing.Size(28, 24);
            this.picCloseEditProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCloseEditProduct.TabIndex = 50;
            this.picCloseEditProduct.TabStop = false;
            this.picCloseEditProduct.Click += new System.EventHandler(this.picCloseEditProduct_Click);
            // 
            // DeteCup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(229, 218);
            this.Controls.Add(this.picCloseEditProduct);
            this.Controls.Add(this.mnButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblReturnDB);
            this.Controls.Add(this.cmbCupName);
            this.Controls.Add(this.lblRegisterGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeteCup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deletar Copo";
            this.Load += new System.EventHandler(this.DeteCup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCloseEditProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblRegisterGroup;
        private ComboBox cmbCupName;
        private Label lblReturnDB;
        private Label label1;
        private Models.MNButton mnButton1;
        private PictureBox picCloseEditProduct;
    }
}