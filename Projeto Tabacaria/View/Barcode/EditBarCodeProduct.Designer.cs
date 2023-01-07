namespace Projeto_Tabacaria.View.Barcode
{
    partial class EditBarCodeProduct
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
            this.txtNameProduct = new System.Windows.Forms.TextBox();
            this.txtCodeBarProduct = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblSendNameProduct = new System.Windows.Forms.Label();
            this.lblSendBarCodeProduct = new System.Windows.Forms.Label();
            this.txtNewBarcode = new System.Windows.Forms.TextBox();
            this.btnEditProduct = new Projeto_Tabacaria.Models.MNButton();
            this.lblReturnDB = new System.Windows.Forms.Label();
            this.picCloseEditProduct = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCloseEditProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNameProduct
            // 
            this.txtNameProduct.Location = new System.Drawing.Point(90, 51);
            this.txtNameProduct.Name = "txtNameProduct";
            this.txtNameProduct.ReadOnly = true;
            this.txtNameProduct.Size = new System.Drawing.Size(221, 23);
            this.txtNameProduct.TabIndex = 47;
            // 
            // txtCodeBarProduct
            // 
            this.txtCodeBarProduct.Location = new System.Drawing.Point(90, 80);
            this.txtCodeBarProduct.Name = "txtCodeBarProduct";
            this.txtCodeBarProduct.ReadOnly = true;
            this.txtCodeBarProduct.Size = new System.Drawing.Size(221, 23);
            this.txtCodeBarProduct.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 21);
            this.label1.TabIndex = 50;
            this.label1.Text = "Código";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProduct.ForeColor = System.Drawing.Color.White;
            this.lblProduct.Location = new System.Drawing.Point(12, 51);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(72, 21);
            this.lblProduct.TabIndex = 49;
            this.lblProduct.Text = "Produto";
            // 
            // lblSendNameProduct
            // 
            this.lblSendNameProduct.AutoSize = true;
            this.lblSendNameProduct.Location = new System.Drawing.Point(12, 9);
            this.lblSendNameProduct.Name = "lblSendNameProduct";
            this.lblSendNameProduct.Size = new System.Drawing.Size(113, 15);
            this.lblSendNameProduct.TabIndex = 51;
            this.lblSendNameProduct.Text = "Send Name Product";
            // 
            // lblSendBarCodeProduct
            // 
            this.lblSendBarCodeProduct.AutoSize = true;
            this.lblSendBarCodeProduct.Location = new System.Drawing.Point(12, 24);
            this.lblSendBarCodeProduct.Name = "lblSendBarCodeProduct";
            this.lblSendBarCodeProduct.Size = new System.Drawing.Size(124, 15);
            this.lblSendBarCodeProduct.TabIndex = 52;
            this.lblSendBarCodeProduct.Text = "Send Barcode Product";
            // 
            // txtNewBarcode
            // 
            this.txtNewBarcode.Location = new System.Drawing.Point(90, 141);
            this.txtNewBarcode.Name = "txtNewBarcode";
            this.txtNewBarcode.Size = new System.Drawing.Size(221, 23);
            this.txtNewBarcode.TabIndex = 53;
            this.txtNewBarcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.BackColor = System.Drawing.Color.Teal;
            this.btnEditProduct.BackgroundColor = System.Drawing.Color.Teal;
            this.btnEditProduct.BorderColor = System.Drawing.Color.Black;
            this.btnEditProduct.BorderRadius = 10;
            this.btnEditProduct.BorderSize = 0;
            this.btnEditProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditProduct.FlatAppearance.BorderSize = 0;
            this.btnEditProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditProduct.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditProduct.ForeColor = System.Drawing.Color.White;
            this.btnEditProduct.Image = global::Projeto_Tabacaria.Properties.Resources.editar1;
            this.btnEditProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditProduct.Location = new System.Drawing.Point(81, 217);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(193, 58);
            this.btnEditProduct.TabIndex = 54;
            this.btnEditProduct.Text = "       Salvar Alterações";
            this.btnEditProduct.TextColor = System.Drawing.Color.White;
            this.btnEditProduct.UseVisualStyleBackColor = false;
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // lblReturnDB
            // 
            this.lblReturnDB.AutoSize = true;
            this.lblReturnDB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReturnDB.ForeColor = System.Drawing.SystemColors.Control;
            this.lblReturnDB.Location = new System.Drawing.Point(101, 181);
            this.lblReturnDB.Name = "lblReturnDB";
            this.lblReturnDB.Size = new System.Drawing.Size(93, 19);
            this.lblReturnDB.TabIndex = 55;
            this.lblReturnDB.Text = "Return DB";
            // 
            // picCloseEditProduct
            // 
            this.picCloseEditProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCloseEditProduct.Image = global::Projeto_Tabacaria.Properties.Resources.close_correto;
            this.picCloseEditProduct.Location = new System.Drawing.Point(315, 0);
            this.picCloseEditProduct.Name = "picCloseEditProduct";
            this.picCloseEditProduct.Size = new System.Drawing.Size(28, 24);
            this.picCloseEditProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCloseEditProduct.TabIndex = 56;
            this.picCloseEditProduct.TabStop = false;
            this.picCloseEditProduct.Click += new System.EventHandler(this.picCloseEditProduct_Click);
            // 
            // EditBarCodeProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(343, 305);
            this.Controls.Add(this.picCloseEditProduct);
            this.Controls.Add(this.lblReturnDB);
            this.Controls.Add(this.btnEditProduct);
            this.Controls.Add(this.txtNewBarcode);
            this.Controls.Add(this.lblSendBarCodeProduct);
            this.Controls.Add(this.lblSendNameProduct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.txtCodeBarProduct);
            this.Controls.Add(this.txtNameProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditBarCodeProduct";
            this.Text = "EditBarCodeProduct";
            this.Load += new System.EventHandler(this.EditBarCodeProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCloseEditProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtNameProduct;
        private TextBox txtCodeBarProduct;
        private Label label1;
        private Label lblProduct;
        private Label lblSendNameProduct;
        private Label lblSendBarCodeProduct;
        private TextBox txtNewBarcode;
        private Models.MNButton btnEditProduct;
        private Label lblReturnDB;
        private PictureBox picCloseEditProduct;
    }
}