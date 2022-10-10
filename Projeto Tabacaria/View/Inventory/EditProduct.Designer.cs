namespace Projeto_Tabacaria.View.Inventory
{
    partial class EditProduct
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
            this.picCloseEditProduct = new System.Windows.Forms.PictureBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.searchButton = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbUnidade_De_Medida = new System.Windows.Forms.ComboBox();
            this.txtQtd = new CustomControls.RJControls.RJTextBox();
            this.txtTotalSpent = new CustomControls.RJControls.RJTextBox();
            this.txtSaleValue = new CustomControls.RJControls.RJTextBox();
            this.txtBuyValue = new CustomControls.RJControls.RJTextBox();
            this.txtProdName = new CustomControls.RJControls.RJTextBox();
            this.totalProfitPresumed = new CustomControls.RJControls.RJTextBox();
            this.txtTotalSale = new CustomControls.RJControls.RJTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbActiveProd = new System.Windows.Forms.ComboBox();
            this.btnEditProduct = new Projeto_Tabacaria.Models.MNButton();
            this.cmbSearchProduct = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCloseEditProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchButton)).BeginInit();
            this.SuspendLayout();
            // 
            // picCloseEditProduct
            // 
            this.picCloseEditProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCloseEditProduct.Image = global::Projeto_Tabacaria.Properties.Resources.Close;
            this.picCloseEditProduct.Location = new System.Drawing.Point(475, 12);
            this.picCloseEditProduct.Name = "picCloseEditProduct";
            this.picCloseEditProduct.Size = new System.Drawing.Size(28, 24);
            this.picCloseEditProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCloseEditProduct.TabIndex = 10;
            this.picCloseEditProduct.TabStop = false;
            this.picCloseEditProduct.Click += new System.EventHandler(this.picCloseEditProduct_Click);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(204)))), ((int)(((byte)(55)))));
            this.lblMarca.Location = new System.Drawing.Point(24, 31);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(52, 19);
            this.lblMarca.TabIndex = 19;
            this.lblMarca.Text = "Marca";
            // 
            // cmbMarca
            // 
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(82, 31);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(93, 23);
            this.cmbMarca.TabIndex = 18;
            this.cmbMarca.TabStop = false;
            this.cmbMarca.SelectedIndexChanged += new System.EventHandler(this.cmbMarca_SelectedIndexChanged);
            // 
            // searchButton
            // 
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.Image = global::Projeto_Tabacaria.Properties.Resources.SearchIcon;
            this.searchButton.Location = new System.Drawing.Point(425, 28);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(30, 27);
            this.searchButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.searchButton.TabIndex = 21;
            this.searchButton.TabStop = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(204)))), ((int)(((byte)(55)))));
            this.label1.Location = new System.Drawing.Point(42, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 19);
            this.label1.TabIndex = 28;
            this.label1.Text = "Unidade de Medida";
            // 
            // cmbUnidade_De_Medida
            // 
            this.cmbUnidade_De_Medida.Enabled = false;
            this.cmbUnidade_De_Medida.FormattingEnabled = true;
            this.cmbUnidade_De_Medida.Items.AddRange(new object[] {
            "ML",
            "LT",
            "UN"});
            this.cmbUnidade_De_Medida.Location = new System.Drawing.Point(192, 174);
            this.cmbUnidade_De_Medida.Name = "cmbUnidade_De_Medida";
            this.cmbUnidade_De_Medida.Size = new System.Drawing.Size(64, 23);
            this.cmbUnidade_De_Medida.TabIndex = 27;
            // 
            // txtQtd
            // 
            this.txtQtd.BackColor = System.Drawing.SystemColors.Window;
            this.txtQtd.BorderColor = System.Drawing.Color.White;
            this.txtQtd.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(204)))), ((int)(((byte)(55)))));
            this.txtQtd.BorderRadius = 6;
            this.txtQtd.BorderSize = 2;
            this.txtQtd.Enabled = false;
            this.txtQtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtQtd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtQtd.Location = new System.Drawing.Point(42, 136);
            this.txtQtd.Margin = new System.Windows.Forms.Padding(4);
            this.txtQtd.Multiline = false;
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtQtd.PasswordChar = false;
            this.txtQtd.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtQtd.PlaceholderText = "Quantidade";
            this.txtQtd.Size = new System.Drawing.Size(393, 31);
            this.txtQtd.TabIndex = 26;
            this.txtQtd.TabStop = false;
            this.txtQtd.Texts = "";
            this.txtQtd.UnderlinedStyle = false;
            // 
            // txtTotalSpent
            // 
            this.txtTotalSpent.BackColor = System.Drawing.SystemColors.Window;
            this.txtTotalSpent.BorderColor = System.Drawing.Color.White;
            this.txtTotalSpent.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(204)))), ((int)(((byte)(55)))));
            this.txtTotalSpent.BorderRadius = 6;
            this.txtTotalSpent.BorderSize = 2;
            this.txtTotalSpent.Enabled = false;
            this.txtTotalSpent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTotalSpent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTotalSpent.Location = new System.Drawing.Point(42, 292);
            this.txtTotalSpent.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalSpent.Multiline = false;
            this.txtTotalSpent.Name = "txtTotalSpent";
            this.txtTotalSpent.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTotalSpent.PasswordChar = false;
            this.txtTotalSpent.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtTotalSpent.PlaceholderText = "Total Gasto";
            this.txtTotalSpent.Size = new System.Drawing.Size(103, 31);
            this.txtTotalSpent.TabIndex = 25;
            this.txtTotalSpent.TabStop = false;
            this.txtTotalSpent.Texts = "";
            this.txtTotalSpent.UnderlinedStyle = false;
            // 
            // txtSaleValue
            // 
            this.txtSaleValue.BackColor = System.Drawing.SystemColors.Window;
            this.txtSaleValue.BorderColor = System.Drawing.Color.White;
            this.txtSaleValue.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(204)))), ((int)(((byte)(55)))));
            this.txtSaleValue.BorderRadius = 6;
            this.txtSaleValue.BorderSize = 2;
            this.txtSaleValue.Enabled = false;
            this.txtSaleValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSaleValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSaleValue.Location = new System.Drawing.Point(41, 253);
            this.txtSaleValue.Margin = new System.Windows.Forms.Padding(4);
            this.txtSaleValue.Multiline = false;
            this.txtSaleValue.Name = "txtSaleValue";
            this.txtSaleValue.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSaleValue.PasswordChar = false;
            this.txtSaleValue.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtSaleValue.PlaceholderText = "Valor unitário de venda";
            this.txtSaleValue.Size = new System.Drawing.Size(394, 31);
            this.txtSaleValue.TabIndex = 24;
            this.txtSaleValue.TabStop = false;
            this.txtSaleValue.Texts = "";
            this.txtSaleValue.UnderlinedStyle = false;
            // 
            // txtBuyValue
            // 
            this.txtBuyValue.BackColor = System.Drawing.SystemColors.Window;
            this.txtBuyValue.BorderColor = System.Drawing.Color.White;
            this.txtBuyValue.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(204)))), ((int)(((byte)(55)))));
            this.txtBuyValue.BorderRadius = 6;
            this.txtBuyValue.BorderSize = 2;
            this.txtBuyValue.Enabled = false;
            this.txtBuyValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBuyValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBuyValue.Location = new System.Drawing.Point(41, 214);
            this.txtBuyValue.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuyValue.Multiline = false;
            this.txtBuyValue.Name = "txtBuyValue";
            this.txtBuyValue.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtBuyValue.PasswordChar = false;
            this.txtBuyValue.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtBuyValue.PlaceholderText = "Valor unitário de compra";
            this.txtBuyValue.Size = new System.Drawing.Size(394, 31);
            this.txtBuyValue.TabIndex = 23;
            this.txtBuyValue.TabStop = false;
            this.txtBuyValue.Texts = "";
            this.txtBuyValue.UnderlinedStyle = false;
            // 
            // txtProdName
            // 
            this.txtProdName.BackColor = System.Drawing.SystemColors.Window;
            this.txtProdName.BorderColor = System.Drawing.Color.White;
            this.txtProdName.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(204)))), ((int)(((byte)(55)))));
            this.txtProdName.BorderRadius = 6;
            this.txtProdName.BorderSize = 2;
            this.txtProdName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtProdName.Enabled = false;
            this.txtProdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtProdName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtProdName.Location = new System.Drawing.Point(41, 97);
            this.txtProdName.Margin = new System.Windows.Forms.Padding(4);
            this.txtProdName.Multiline = false;
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtProdName.PasswordChar = false;
            this.txtProdName.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtProdName.PlaceholderText = "Nome do produto";
            this.txtProdName.Size = new System.Drawing.Size(394, 31);
            this.txtProdName.TabIndex = 22;
            this.txtProdName.TabStop = false;
            this.txtProdName.Texts = "";
            this.txtProdName.UnderlinedStyle = false;
            // 
            // totalProfitPresumed
            // 
            this.totalProfitPresumed.BackColor = System.Drawing.SystemColors.Window;
            this.totalProfitPresumed.BorderColor = System.Drawing.Color.White;
            this.totalProfitPresumed.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(204)))), ((int)(((byte)(55)))));
            this.totalProfitPresumed.BorderRadius = 6;
            this.totalProfitPresumed.BorderSize = 2;
            this.totalProfitPresumed.Enabled = false;
            this.totalProfitPresumed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalProfitPresumed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.totalProfitPresumed.Location = new System.Drawing.Point(315, 292);
            this.totalProfitPresumed.Margin = new System.Windows.Forms.Padding(4);
            this.totalProfitPresumed.Multiline = false;
            this.totalProfitPresumed.Name = "totalProfitPresumed";
            this.totalProfitPresumed.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.totalProfitPresumed.PasswordChar = false;
            this.totalProfitPresumed.PlaceholderColor = System.Drawing.Color.Gray;
            this.totalProfitPresumed.PlaceholderText = "Lucro Presumido";
            this.totalProfitPresumed.Size = new System.Drawing.Size(120, 31);
            this.totalProfitPresumed.TabIndex = 29;
            this.totalProfitPresumed.TabStop = false;
            this.totalProfitPresumed.Texts = "";
            this.totalProfitPresumed.UnderlinedStyle = false;
            // 
            // txtTotalSale
            // 
            this.txtTotalSale.BackColor = System.Drawing.SystemColors.Window;
            this.txtTotalSale.BorderColor = System.Drawing.Color.White;
            this.txtTotalSale.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(204)))), ((int)(((byte)(55)))));
            this.txtTotalSale.BorderRadius = 6;
            this.txtTotalSale.BorderSize = 2;
            this.txtTotalSale.Enabled = false;
            this.txtTotalSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTotalSale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTotalSale.Location = new System.Drawing.Point(182, 292);
            this.txtTotalSale.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalSale.Multiline = false;
            this.txtTotalSale.Name = "txtTotalSale";
            this.txtTotalSale.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTotalSale.PasswordChar = false;
            this.txtTotalSale.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtTotalSale.PlaceholderText = "Total Venda";
            this.txtTotalSale.Size = new System.Drawing.Size(103, 31);
            this.txtTotalSale.TabIndex = 30;
            this.txtTotalSale.TabStop = false;
            this.txtTotalSale.Texts = "";
            this.txtTotalSale.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(204)))), ((int)(((byte)(55)))));
            this.label2.Location = new System.Drawing.Point(315, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 19);
            this.label2.TabIndex = 31;
            this.label2.Text = "Ativo:";
            // 
            // cmbActiveProd
            // 
            this.cmbActiveProd.Enabled = false;
            this.cmbActiveProd.FormattingEnabled = true;
            this.cmbActiveProd.Items.AddRange(new object[] {
            "ML",
            "LT",
            "UN"});
            this.cmbActiveProd.Location = new System.Drawing.Point(371, 174);
            this.cmbActiveProd.Name = "cmbActiveProd";
            this.cmbActiveProd.Size = new System.Drawing.Size(64, 23);
            this.cmbActiveProd.TabIndex = 32;
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
            this.btnEditProduct.ForeColor = System.Drawing.Color.Orange;
            this.btnEditProduct.Image = global::Projeto_Tabacaria.Properties.Resources.editar_documento__1_;
            this.btnEditProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditProduct.Location = new System.Drawing.Point(141, 371);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(189, 51);
            this.btnEditProduct.TabIndex = 33;
            this.btnEditProduct.Text = "       Editar Produto";
            this.btnEditProduct.TextColor = System.Drawing.Color.Orange;
            this.btnEditProduct.UseVisualStyleBackColor = false;
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // cmbSearchProduct
            // 
            this.cmbSearchProduct.FormattingEnabled = true;
            this.cmbSearchProduct.Location = new System.Drawing.Point(273, 31);
            this.cmbSearchProduct.Name = "cmbSearchProduct";
            this.cmbSearchProduct.Size = new System.Drawing.Size(146, 23);
            this.cmbSearchProduct.TabIndex = 34;
            this.cmbSearchProduct.TabStop = false;
            // 
            // EditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(515, 452);
            this.Controls.Add(this.cmbSearchProduct);
            this.Controls.Add(this.btnEditProduct);
            this.Controls.Add(this.cmbActiveProd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTotalSale);
            this.Controls.Add(this.totalProfitPresumed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbUnidade_De_Medida);
            this.Controls.Add(this.txtQtd);
            this.Controls.Add(this.txtTotalSpent);
            this.Controls.Add(this.txtSaleValue);
            this.Controls.Add(this.txtBuyValue);
            this.Controls.Add(this.txtProdName);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.cmbMarca);
            this.Controls.Add(this.picCloseEditProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditProduct";
            this.Load += new System.EventHandler(this.EditProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCloseEditProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox picCloseEditProduct;
        private Label lblMarca;
        private ComboBox cmbMarca;
        private PictureBox searchButton;
        private Label label1;
        private ComboBox cmbUnidade_De_Medida;
        private CustomControls.RJControls.RJTextBox txtQtd;
        private CustomControls.RJControls.RJTextBox txtTotalSpent;
        private CustomControls.RJControls.RJTextBox txtSaleValue;
        private CustomControls.RJControls.RJTextBox txtBuyValue;
        private CustomControls.RJControls.RJTextBox txtProdName;
        private CustomControls.RJControls.RJTextBox totalProfitPresumed;
        private CustomControls.RJControls.RJTextBox txtTotalSale;
        private Label label2;
        private ComboBox cmbActiveProd;
        private Models.MNButton btnEditProduct;
        private ComboBox cmbSearchProduct;
    }
}