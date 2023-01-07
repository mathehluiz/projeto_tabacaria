namespace Projeto_Tabacaria.View.Barcode
{
    partial class DeleteBarcodeProduct
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
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.lblProduct = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRegisterGroup = new System.Windows.Forms.Label();
            this.picCloseEditProduct = new System.Windows.Forms.PictureBox();
            this.btnDeleteBarCodeProduct = new Projeto_Tabacaria.Models.MNButton();
            this.lblSendBarcode = new System.Windows.Forms.Label();
            this.lblSendNameProduct = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCloseEditProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNameProduct
            // 
            this.txtNameProduct.Location = new System.Drawing.Point(89, 61);
            this.txtNameProduct.Name = "txtNameProduct";
            this.txtNameProduct.ReadOnly = true;
            this.txtNameProduct.Size = new System.Drawing.Size(180, 23);
            this.txtNameProduct.TabIndex = 0;
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(89, 90);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.ReadOnly = true;
            this.txtBarcode.Size = new System.Drawing.Size(180, 23);
            this.txtBarcode.TabIndex = 1;
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProduct.ForeColor = System.Drawing.Color.White;
            this.lblProduct.Location = new System.Drawing.Point(11, 59);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(72, 21);
            this.lblProduct.TabIndex = 47;
            this.lblProduct.Text = "Produto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 21);
            this.label1.TabIndex = 48;
            this.label1.Text = "Código";
            // 
            // lblRegisterGroup
            // 
            this.lblRegisterGroup.AutoSize = true;
            this.lblRegisterGroup.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRegisterGroup.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRegisterGroup.Location = new System.Drawing.Point(50, 9);
            this.lblRegisterGroup.Name = "lblRegisterGroup";
            this.lblRegisterGroup.Size = new System.Drawing.Size(208, 28);
            this.lblRegisterGroup.TabIndex = 49;
            this.lblRegisterGroup.Text = "DELETAR PRODUTO";
            // 
            // picCloseEditProduct
            // 
            this.picCloseEditProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCloseEditProduct.Image = global::Projeto_Tabacaria.Properties.Resources.close_correto;
            this.picCloseEditProduct.Location = new System.Drawing.Point(288, 0);
            this.picCloseEditProduct.Name = "picCloseEditProduct";
            this.picCloseEditProduct.Size = new System.Drawing.Size(28, 24);
            this.picCloseEditProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCloseEditProduct.TabIndex = 50;
            this.picCloseEditProduct.TabStop = false;
            this.picCloseEditProduct.Click += new System.EventHandler(this.picCloseEditProduct_Click);
            // 
            // btnDeleteBarCodeProduct
            // 
            this.btnDeleteBarCodeProduct.BackColor = System.Drawing.Color.Teal;
            this.btnDeleteBarCodeProduct.BackgroundColor = System.Drawing.Color.Teal;
            this.btnDeleteBarCodeProduct.BorderColor = System.Drawing.Color.Black;
            this.btnDeleteBarCodeProduct.BorderRadius = 10;
            this.btnDeleteBarCodeProduct.BorderSize = 0;
            this.btnDeleteBarCodeProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteBarCodeProduct.FlatAppearance.BorderSize = 0;
            this.btnDeleteBarCodeProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteBarCodeProduct.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteBarCodeProduct.ForeColor = System.Drawing.Color.White;
            this.btnDeleteBarCodeProduct.Image = global::Projeto_Tabacaria.Properties.Resources.lixeira_de_reciclagem;
            this.btnDeleteBarCodeProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteBarCodeProduct.Location = new System.Drawing.Point(69, 155);
            this.btnDeleteBarCodeProduct.Name = "btnDeleteBarCodeProduct";
            this.btnDeleteBarCodeProduct.Size = new System.Drawing.Size(189, 58);
            this.btnDeleteBarCodeProduct.TabIndex = 51;
            this.btnDeleteBarCodeProduct.Text = "       Deletar Código";
            this.btnDeleteBarCodeProduct.TextColor = System.Drawing.Color.White;
            this.btnDeleteBarCodeProduct.UseVisualStyleBackColor = false;
            // 
            // lblSendBarcode
            // 
            this.lblSendBarcode.AutoSize = true;
            this.lblSendBarcode.Location = new System.Drawing.Point(12, 135);
            this.lblSendBarcode.Name = "lblSendBarcode";
            this.lblSendBarcode.Size = new System.Drawing.Size(118, 15);
            this.lblSendBarcode.TabIndex = 53;
            this.lblSendBarcode.Text = "SendBarcodeProduct";
            // 
            // lblSendNameProduct
            // 
            this.lblSendNameProduct.AutoSize = true;
            this.lblSendNameProduct.Location = new System.Drawing.Point(12, 116);
            this.lblSendNameProduct.Name = "lblSendNameProduct";
            this.lblSendNameProduct.Size = new System.Drawing.Size(107, 15);
            this.lblSendNameProduct.TabIndex = 52;
            this.lblSendNameProduct.Text = "SendNameProduct";
            // 
            // DeleteBarcodeProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(318, 234);
            this.Controls.Add(this.lblSendBarcode);
            this.Controls.Add(this.lblSendNameProduct);
            this.Controls.Add(this.btnDeleteBarCodeProduct);
            this.Controls.Add(this.picCloseEditProduct);
            this.Controls.Add(this.lblRegisterGroup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.txtNameProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeleteBarcodeProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteBarcodeProduct";
            ((System.ComponentModel.ISupportInitialize)(this.picCloseEditProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtNameProduct;
        private TextBox txtBarcode;
        private Label lblProduct;
        private Label label1;
        private Label lblRegisterGroup;
        private PictureBox picCloseEditProduct;
        private Models.MNButton btnDeleteBarCodeProduct;
        private Label lblSendBarcode;
        private Label lblSendNameProduct;
    }
}