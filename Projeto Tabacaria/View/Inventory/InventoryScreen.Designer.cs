namespace Projeto_Tabacaria.View
{
    partial class InventoryScreen
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
            this.txtSearchProduct = new CustomControls.RJControls.RJTextBox();
            this.picSearchIcon_Inventory = new System.Windows.Forms.PictureBox();
            this.btnCreateProduct = new Projeto_Tabacaria.Models.MNButton();
            this.btnEditProduct = new Projeto_Tabacaria.Models.MNButton();
            this.mnButton2 = new Projeto_Tabacaria.Models.MNButton();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picSearchIcon_Inventory)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearchProduct
            // 
            this.txtSearchProduct.BackColor = System.Drawing.SystemColors.Window;
            this.txtSearchProduct.BorderColor = System.Drawing.Color.White;
            this.txtSearchProduct.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(204)))), ((int)(((byte)(55)))));
            this.txtSearchProduct.BorderRadius = 10;
            this.txtSearchProduct.BorderSize = 2;
            this.txtSearchProduct.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearchProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearchProduct.Location = new System.Drawing.Point(89, 26);
            this.txtSearchProduct.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchProduct.Multiline = false;
            this.txtSearchProduct.Name = "txtSearchProduct";
            this.txtSearchProduct.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSearchProduct.PasswordChar = false;
            this.txtSearchProduct.PlaceholderColor = System.Drawing.SystemColors.ControlText;
            this.txtSearchProduct.PlaceholderText = "                       Pesquisar Produto";
            this.txtSearchProduct.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSearchProduct.Size = new System.Drawing.Size(268, 29);
            this.txtSearchProduct.TabIndex = 12;
            this.txtSearchProduct.TabStop = false;
            this.txtSearchProduct.Texts = "";
            this.txtSearchProduct.UnderlinedStyle = false;
            // 
            // picSearchIcon_Inventory
            // 
            this.picSearchIcon_Inventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.picSearchIcon_Inventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSearchIcon_Inventory.Image = global::Projeto_Tabacaria.Properties.Resources.SearchIcon;
            this.picSearchIcon_Inventory.Location = new System.Drawing.Point(364, 26);
            this.picSearchIcon_Inventory.Name = "picSearchIcon_Inventory";
            this.picSearchIcon_Inventory.Size = new System.Drawing.Size(32, 29);
            this.picSearchIcon_Inventory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSearchIcon_Inventory.TabIndex = 13;
            this.picSearchIcon_Inventory.TabStop = false;
            // 
            // btnCreateProduct
            // 
            this.btnCreateProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(113)))), ((int)(((byte)(49)))));
            this.btnCreateProduct.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(113)))), ((int)(((byte)(49)))));
            this.btnCreateProduct.BorderColor = System.Drawing.Color.Black;
            this.btnCreateProduct.BorderRadius = 10;
            this.btnCreateProduct.BorderSize = 0;
            this.btnCreateProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateProduct.FlatAppearance.BorderSize = 0;
            this.btnCreateProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreateProduct.Font = new System.Drawing.Font("Gadugi", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCreateProduct.ForeColor = System.Drawing.Color.Black;
            this.btnCreateProduct.Image = global::Projeto_Tabacaria.Properties.Resources.registro1;
            this.btnCreateProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateProduct.Location = new System.Drawing.Point(477, 16);
            this.btnCreateProduct.Name = "btnCreateProduct";
            this.btnCreateProduct.Size = new System.Drawing.Size(212, 51);
            this.btnCreateProduct.TabIndex = 14;
            this.btnCreateProduct.Text = "       Cadastrar Produto";
            this.btnCreateProduct.TextColor = System.Drawing.Color.Black;
            this.btnCreateProduct.UseVisualStyleBackColor = false;
            this.btnCreateProduct.Click += new System.EventHandler(this.btnCreateProduct_Click);
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(113)))), ((int)(((byte)(49)))));
            this.btnEditProduct.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(113)))), ((int)(((byte)(49)))));
            this.btnEditProduct.BorderColor = System.Drawing.Color.Black;
            this.btnEditProduct.BorderRadius = 10;
            this.btnEditProduct.BorderSize = 0;
            this.btnEditProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditProduct.FlatAppearance.BorderSize = 0;
            this.btnEditProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditProduct.Font = new System.Drawing.Font("Gadugi", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditProduct.ForeColor = System.Drawing.Color.Black;
            this.btnEditProduct.Image = global::Projeto_Tabacaria.Properties.Resources.editar_documento__1_;
            this.btnEditProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditProduct.Location = new System.Drawing.Point(695, 16);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(189, 51);
            this.btnEditProduct.TabIndex = 15;
            this.btnEditProduct.Text = "       Editar Produto";
            this.btnEditProduct.TextColor = System.Drawing.Color.Black;
            this.btnEditProduct.UseVisualStyleBackColor = false;
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // mnButton2
            // 
            this.mnButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(113)))), ((int)(((byte)(49)))));
            this.mnButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(113)))), ((int)(((byte)(49)))));
            this.mnButton2.BorderColor = System.Drawing.Color.Black;
            this.mnButton2.BorderRadius = 10;
            this.mnButton2.BorderSize = 0;
            this.mnButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mnButton2.FlatAppearance.BorderSize = 0;
            this.mnButton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mnButton2.Font = new System.Drawing.Font("Gadugi", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mnButton2.ForeColor = System.Drawing.Color.Black;
            this.mnButton2.Image = global::Projeto_Tabacaria.Properties.Resources.excluir__1_;
            this.mnButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnButton2.Location = new System.Drawing.Point(890, 16);
            this.mnButton2.Name = "mnButton2";
            this.mnButton2.Size = new System.Drawing.Size(192, 51);
            this.mnButton2.TabIndex = 16;
            this.mnButton2.Text = "       Excluir Produto";
            this.mnButton2.TextColor = System.Drawing.Color.Black;
            this.mnButton2.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(22)))), ((int)(((byte)(9)))));
            this.panel1.Location = new System.Drawing.Point(13, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1069, 587);
            this.panel1.TabIndex = 17;
            // 
            // InventoryScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1094, 690);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mnButton2);
            this.Controls.Add(this.btnEditProduct);
            this.Controls.Add(this.btnCreateProduct);
            this.Controls.Add(this.picSearchIcon_Inventory);
            this.Controls.Add(this.txtSearchProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InventoryScreen";
            this.Text = "InventoryScreen";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.picSearchIcon_Inventory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private CustomControls.RJControls.RJTextBox txtSearchProduct;
        private PictureBox picSearchIcon_Inventory;
        private Models.MNButton btnCreateProduct;
        private Models.MNButton btnEditProduct;
        private Models.MNButton mnButton2;
        private Panel panel1;
    }
}