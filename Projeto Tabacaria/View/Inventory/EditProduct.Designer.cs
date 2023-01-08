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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditProduct));
            this.picCloseEditProduct = new System.Windows.Forms.PictureBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.searchButton = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbUnidade_De_Medida = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbActiveProd = new System.Windows.Forms.ComboBox();
            this.btnEditProduct = new Projeto_Tabacaria.Models.MNButton();
            this.cmbSearchProduct = new System.Windows.Forms.ComboBox();
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.txtBuyValue = new System.Windows.Forms.TextBox();
            this.txtSaleValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRegisterGroup = new System.Windows.Forms.Label();
            this.lblReturnDB = new System.Windows.Forms.Label();
            this.lblSendBrandProduct = new System.Windows.Forms.Label();
            this.lblSendNameProduct = new System.Windows.Forms.Label();
            this.lblSendGroupName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtInventoryMin = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCloseEditProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchButton)).BeginInit();
            this.SuspendLayout();
            // 
            // picCloseEditProduct
            // 
            this.picCloseEditProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCloseEditProduct.Image = global::Projeto_Tabacaria.Properties.Resources.close_correto;
            this.picCloseEditProduct.Location = new System.Drawing.Point(436, 1);
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
            this.lblMarca.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMarca.ForeColor = System.Drawing.Color.White;
            this.lblMarca.Location = new System.Drawing.Point(23, 66);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(57, 21);
            this.lblMarca.TabIndex = 19;
            this.lblMarca.Text = "Marca";
            // 
            // cmbMarca
            // 
            this.cmbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(81, 66);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(93, 23);
            this.cmbMarca.TabIndex = 1;
            this.cmbMarca.TabStop = false;
            this.cmbMarca.SelectedIndexChanged += new System.EventHandler(this.cmbMarca_SelectedIndexChanged);
            // 
            // searchButton
            // 
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.Image = global::Projeto_Tabacaria.Properties.Resources.lupa;
            this.searchButton.Location = new System.Drawing.Point(424, 65);
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
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 21);
            this.label1.TabIndex = 28;
            this.label1.Text = "Unidade de Medida";
            // 
            // cmbUnidade_De_Medida
            // 
            this.cmbUnidade_De_Medida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnidade_De_Medida.FormattingEnabled = true;
            this.cmbUnidade_De_Medida.Items.AddRange(new object[] {
            "ML",
            "LT",
            "UN"});
            this.cmbUnidade_De_Medida.Location = new System.Drawing.Point(326, 205);
            this.cmbUnidade_De_Medida.Name = "cmbUnidade_De_Medida";
            this.cmbUnidade_De_Medida.Size = new System.Drawing.Size(92, 23);
            this.cmbUnidade_De_Medida.TabIndex = 4;
            this.cmbUnidade_De_Medida.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(25, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 21);
            this.label2.TabIndex = 31;
            this.label2.Text = "Ativo";
            // 
            // cmbActiveProd
            // 
            this.cmbActiveProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbActiveProd.FormattingEnabled = true;
            this.cmbActiveProd.Items.AddRange(new object[] {
            "S",
            "N"});
            this.cmbActiveProd.Location = new System.Drawing.Point(326, 234);
            this.cmbActiveProd.Name = "cmbActiveProd";
            this.cmbActiveProd.Size = new System.Drawing.Size(92, 23);
            this.cmbActiveProd.TabIndex = 5;
            this.cmbActiveProd.TabStop = false;
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
            this.btnEditProduct.Location = new System.Drawing.Point(129, 384);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(193, 58);
            this.btnEditProduct.TabIndex = 8;
            this.btnEditProduct.Text = "       Salvar Alterações";
            this.btnEditProduct.TextColor = System.Drawing.Color.White;
            this.btnEditProduct.UseVisualStyleBackColor = false;
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // cmbSearchProduct
            // 
            this.cmbSearchProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchProduct.FormattingEnabled = true;
            this.cmbSearchProduct.Location = new System.Drawing.Point(268, 66);
            this.cmbSearchProduct.Name = "cmbSearchProduct";
            this.cmbSearchProduct.Size = new System.Drawing.Size(150, 23);
            this.cmbSearchProduct.TabIndex = 2;
            this.cmbSearchProduct.TabStop = false;
            // 
            // txtProdName
            // 
            this.txtProdName.Location = new System.Drawing.Point(25, 109);
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.PlaceholderText = "Nome do Produto";
            this.txtProdName.Size = new System.Drawing.Size(393, 23);
            this.txtProdName.TabIndex = 3;
            this.txtProdName.TabStop = false;
            // 
            // txtQtd
            // 
            this.txtQtd.Location = new System.Drawing.Point(326, 145);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.PlaceholderText = "Quantidade";
            this.txtQtd.Size = new System.Drawing.Size(92, 23);
            this.txtQtd.TabIndex = 4;
            this.txtQtd.TabStop = false;
            this.txtQtd.Text = "0";
            this.txtQtd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtd_KeyPress);
            // 
            // txtBuyValue
            // 
            this.txtBuyValue.Location = new System.Drawing.Point(326, 263);
            this.txtBuyValue.Name = "txtBuyValue";
            this.txtBuyValue.PlaceholderText = "Valor de Compra";
            this.txtBuyValue.Size = new System.Drawing.Size(92, 23);
            this.txtBuyValue.TabIndex = 6;
            this.txtBuyValue.TabStop = false;
            this.txtBuyValue.Text = "0";
            this.txtBuyValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuyValue_KeyPress);
            // 
            // txtSaleValue
            // 
            this.txtSaleValue.Location = new System.Drawing.Point(326, 292);
            this.txtSaleValue.Name = "txtSaleValue";
            this.txtSaleValue.PlaceholderText = "Valor de Venda";
            this.txtSaleValue.Size = new System.Drawing.Size(92, 23);
            this.txtSaleValue.TabIndex = 7;
            this.txtSaleValue.TabStop = false;
            this.txtSaleValue.Text = "0";
            this.txtSaleValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSaleValue_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(192, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 21);
            this.label3.TabIndex = 40;
            this.label3.Text = "Produto";
            // 
            // lblRegisterGroup
            // 
            this.lblRegisterGroup.AutoSize = true;
            this.lblRegisterGroup.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRegisterGroup.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRegisterGroup.Location = new System.Drawing.Point(129, 8);
            this.lblRegisterGroup.Name = "lblRegisterGroup";
            this.lblRegisterGroup.Size = new System.Drawing.Size(193, 28);
            this.lblRegisterGroup.TabIndex = 41;
            this.lblRegisterGroup.Text = "EDITAR PRODUTO";
            // 
            // lblReturnDB
            // 
            this.lblReturnDB.AutoSize = true;
            this.lblReturnDB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReturnDB.ForeColor = System.Drawing.SystemColors.Control;
            this.lblReturnDB.Location = new System.Drawing.Point(152, 329);
            this.lblReturnDB.Name = "lblReturnDB";
            this.lblReturnDB.Size = new System.Drawing.Size(93, 19);
            this.lblReturnDB.TabIndex = 42;
            this.lblReturnDB.Text = "Return DB";
            // 
            // lblSendBrandProduct
            // 
            this.lblSendBrandProduct.AutoSize = true;
            this.lblSendBrandProduct.Location = new System.Drawing.Point(170, 350);
            this.lblSendBrandProduct.Name = "lblSendBrandProduct";
            this.lblSendBrandProduct.Size = new System.Drawing.Size(106, 15);
            this.lblSendBrandProduct.TabIndex = 44;
            this.lblSendBrandProduct.Text = "SendBrandProduct";
            // 
            // lblSendNameProduct
            // 
            this.lblSendNameProduct.AutoSize = true;
            this.lblSendNameProduct.Location = new System.Drawing.Point(36, 350);
            this.lblSendNameProduct.Name = "lblSendNameProduct";
            this.lblSendNameProduct.Size = new System.Drawing.Size(107, 15);
            this.lblSendNameProduct.TabIndex = 43;
            this.lblSendNameProduct.Text = "SendNameProduct";
            // 
            // lblSendGroupName
            // 
            this.lblSendGroupName.AutoSize = true;
            this.lblSendGroupName.Location = new System.Drawing.Point(310, 350);
            this.lblSendGroupName.Name = "lblSendGroupName";
            this.lblSendGroupName.Size = new System.Drawing.Size(98, 15);
            this.lblSendGroupName.TabIndex = 48;
            this.lblSendGroupName.Text = "SendGroupName";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(23, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 19);
            this.label7.TabIndex = 52;
            this.label7.Text = "Quantidade";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(25, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 19);
            this.label8.TabIndex = 53;
            this.label8.Text = "Valor de Compra";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(25, 296);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 19);
            this.label9.TabIndex = 54;
            this.label9.Text = "Valor de Venda";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(23, 179);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(250, 19);
            this.label10.TabIndex = 56;
            this.label10.Text = "Quantidade Mínima de Estoque";
            // 
            // txtInventoryMin
            // 
            this.txtInventoryMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtInventoryMin.Location = new System.Drawing.Point(326, 174);
            this.txtInventoryMin.Name = "txtInventoryMin";
            this.txtInventoryMin.PlaceholderText = "Quantidade mínima de estoque";
            this.txtInventoryMin.Size = new System.Drawing.Size(92, 22);
            this.txtInventoryMin.TabIndex = 55;
            // 
            // EditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(464, 461);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtInventoryMin);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblSendGroupName);
            this.Controls.Add(this.lblSendBrandProduct);
            this.Controls.Add(this.lblSendNameProduct);
            this.Controls.Add(this.lblReturnDB);
            this.Controls.Add(this.lblRegisterGroup);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSaleValue);
            this.Controls.Add(this.txtBuyValue);
            this.Controls.Add(this.txtQtd);
            this.Controls.Add(this.txtProdName);
            this.Controls.Add(this.cmbSearchProduct);
            this.Controls.Add(this.btnEditProduct);
            this.Controls.Add(this.cmbActiveProd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbUnidade_De_Medida);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.cmbMarca);
            this.Controls.Add(this.picCloseEditProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private Label label2;
        private ComboBox cmbActiveProd;
        private Models.MNButton btnEditProduct;
        private ComboBox cmbSearchProduct;
        private TextBox txtProdName;
        private TextBox txtQtd;
        private TextBox txtBuyValue;
        private TextBox txtSaleValue;
        private Label label3;
        private Label lblRegisterGroup;
        private Label lblReturnDB;
        private Label lblSendBrandProduct;
        private Label lblSendNameProduct;
        private Label lblSendGroupName;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtInventoryMin;
    }
}