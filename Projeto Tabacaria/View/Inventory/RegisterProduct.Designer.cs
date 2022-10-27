namespace Projeto_Tabacaria.View.Inventory
{
    partial class RegisterProduct
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
            this.lblReturnDB = new System.Windows.Forms.Label();
            this.txtInventoryMin = new System.Windows.Forms.TextBox();
            this.lblRegisterGroup = new System.Windows.Forms.Label();
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.txtBuyValue = new System.Windows.Forms.TextBox();
            this.txtSaleValue = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbUnidade_De_Medida = new System.Windows.Forms.ComboBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.lblGrupo = new System.Windows.Forms.Label();
            this.cmbGrupo = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.butRegisterProduct = new Projeto_Tabacaria.Models.MNButton();
            this.RefreshForm = new System.Windows.Forms.Timer(this.components);
            this.txtTotalSale = new System.Windows.Forms.TextBox();
            this.txtTotalProfit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblReturnDB
            // 
            this.lblReturnDB.AutoSize = true;
            this.lblReturnDB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReturnDB.ForeColor = System.Drawing.SystemColors.Control;
            this.lblReturnDB.Location = new System.Drawing.Point(123, 360);
            this.lblReturnDB.Name = "lblReturnDB";
            this.lblReturnDB.Size = new System.Drawing.Size(93, 19);
            this.lblReturnDB.TabIndex = 43;
            this.lblReturnDB.Text = "Return DB";
            // 
            // txtInventoryMin
            // 
            this.txtInventoryMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtInventoryMin.Location = new System.Drawing.Point(274, 196);
            this.txtInventoryMin.Name = "txtInventoryMin";
            this.txtInventoryMin.PlaceholderText = "Quantidade mínima de estoque";
            this.txtInventoryMin.Size = new System.Drawing.Size(83, 22);
            this.txtInventoryMin.TabIndex = 4;
            // 
            // lblRegisterGroup
            // 
            this.lblRegisterGroup.AutoSize = true;
            this.lblRegisterGroup.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRegisterGroup.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRegisterGroup.Location = new System.Drawing.Point(78, 9);
            this.lblRegisterGroup.Name = "lblRegisterGroup";
            this.lblRegisterGroup.Size = new System.Drawing.Size(232, 28);
            this.lblRegisterGroup.TabIndex = 42;
            this.lblRegisterGroup.Text = "REGISTRAR PRODUTO";
            // 
            // txtProdName
            // 
            this.txtProdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtProdName.Location = new System.Drawing.Point(17, 129);
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.PlaceholderText = "Nome do Produto";
            this.txtProdName.Size = new System.Drawing.Size(339, 22);
            this.txtProdName.TabIndex = 2;
            this.txtProdName.TabStop = false;
            // 
            // txtQtd
            // 
            this.txtQtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtQtd.Location = new System.Drawing.Point(274, 168);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.PlaceholderText = "Quantidade";
            this.txtQtd.Size = new System.Drawing.Size(83, 22);
            this.txtQtd.TabIndex = 3;
            this.txtQtd.Text = "0";
            this.txtQtd.TextChanged += new System.EventHandler(this.txtQtd__TextChanged);
            // 
            // txtBuyValue
            // 
            this.txtBuyValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBuyValue.Location = new System.Drawing.Point(274, 253);
            this.txtBuyValue.Name = "txtBuyValue";
            this.txtBuyValue.PlaceholderText = "Valor de compra";
            this.txtBuyValue.Size = new System.Drawing.Size(83, 22);
            this.txtBuyValue.TabIndex = 6;
            this.txtBuyValue.Text = "0";
            this.txtBuyValue.TextChanged += new System.EventHandler(this.txtBuyValue__TextChanged);
            // 
            // txtSaleValue
            // 
            this.txtSaleValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSaleValue.Location = new System.Drawing.Point(274, 281);
            this.txtSaleValue.Name = "txtSaleValue";
            this.txtSaleValue.PlaceholderText = "Valor de venda";
            this.txtSaleValue.Size = new System.Drawing.Size(83, 22);
            this.txtSaleValue.TabIndex = 7;
            this.txtSaleValue.Text = "0";
            this.txtSaleValue.TextChanged += new System.EventHandler(this.txtSaleValue__TextChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTotal.Location = new System.Drawing.Point(16, 309);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.PlaceholderText = "Total Compra";
            this.txtTotal.Size = new System.Drawing.Size(105, 22);
            this.txtTotal.TabIndex = 9;
            this.txtTotal.TabStop = false;
            this.txtTotal.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 19);
            this.label1.TabIndex = 40;
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
            this.cmbUnidade_De_Medida.Location = new System.Drawing.Point(274, 224);
            this.cmbUnidade_De_Medida.Name = "cmbUnidade_De_Medida";
            this.cmbUnidade_De_Medida.Size = new System.Drawing.Size(83, 23);
            this.cmbUnidade_De_Medida.TabIndex = 5;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMarca.ForeColor = System.Drawing.Color.White;
            this.lblMarca.Location = new System.Drawing.Point(205, 87);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(56, 19);
            this.lblMarca.TabIndex = 39;
            this.lblMarca.Text = "Marca";
            // 
            // cmbMarca
            // 
            this.cmbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(264, 86);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(93, 23);
            this.cmbMarca.TabIndex = 1;
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGrupo.ForeColor = System.Drawing.Color.White;
            this.lblGrupo.Location = new System.Drawing.Point(19, 87);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(56, 19);
            this.lblGrupo.TabIndex = 37;
            this.lblGrupo.Text = "Grupo";
            // 
            // cmbGrupo
            // 
            this.cmbGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrupo.FormattingEnabled = true;
            this.cmbGrupo.Location = new System.Drawing.Point(78, 86);
            this.cmbGrupo.Name = "cmbGrupo";
            this.cmbGrupo.Size = new System.Drawing.Size(93, 23);
            this.cmbGrupo.TabIndex = 0;
            this.cmbGrupo.SelectedIndexChanged += new System.EventHandler(this.cmbGrupo_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projeto_Tabacaria.Properties.Resources.close_correto;
            this.pictureBox1.Location = new System.Drawing.Point(353, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // butRegisterProduct
            // 
            this.butRegisterProduct.BackColor = System.Drawing.Color.Teal;
            this.butRegisterProduct.BackgroundColor = System.Drawing.Color.Teal;
            this.butRegisterProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butRegisterProduct.BorderColor = System.Drawing.Color.Teal;
            this.butRegisterProduct.BorderRadius = 10;
            this.butRegisterProduct.BorderSize = 0;
            this.butRegisterProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butRegisterProduct.FlatAppearance.BorderSize = 0;
            this.butRegisterProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butRegisterProduct.Font = new System.Drawing.Font("Gadugi", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.butRegisterProduct.ForeColor = System.Drawing.Color.White;
            this.butRegisterProduct.Image = global::Projeto_Tabacaria.Properties.Resources.registrar;
            this.butRegisterProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butRegisterProduct.Location = new System.Drawing.Point(107, 382);
            this.butRegisterProduct.Name = "butRegisterProduct";
            this.butRegisterProduct.Size = new System.Drawing.Size(168, 49);
            this.butRegisterProduct.TabIndex = 8;
            this.butRegisterProduct.Text = "Registrar";
            this.butRegisterProduct.TextColor = System.Drawing.Color.White;
            this.butRegisterProduct.UseVisualStyleBackColor = false;
            this.butRegisterProduct.Click += new System.EventHandler(this.butRegisterProduct_Click);
            // 
            // RefreshForm
            // 
            this.RefreshForm.Tick += new System.EventHandler(this.RefreshForm_Tick);
            // 
            // txtTotalSale
            // 
            this.txtTotalSale.Enabled = false;
            this.txtTotalSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTotalSale.Location = new System.Drawing.Point(136, 309);
            this.txtTotalSale.Name = "txtTotalSale";
            this.txtTotalSale.PlaceholderText = "Total Venda";
            this.txtTotalSale.Size = new System.Drawing.Size(105, 22);
            this.txtTotalSale.TabIndex = 10;
            this.txtTotalSale.TabStop = false;
            this.txtTotalSale.Text = "0";
            // 
            // txtTotalProfit
            // 
            this.txtTotalProfit.Enabled = false;
            this.txtTotalProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTotalProfit.Location = new System.Drawing.Point(251, 309);
            this.txtTotalProfit.Name = "txtTotalProfit";
            this.txtTotalProfit.PlaceholderText = "Lucro";
            this.txtTotalProfit.Size = new System.Drawing.Size(105, 22);
            this.txtTotalProfit.TabIndex = 45;
            this.txtTotalProfit.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 19);
            this.label2.TabIndex = 46;
            this.label2.Text = "Quantidade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(14, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 19);
            this.label3.TabIndex = 47;
            this.label3.Text = "Quantidade Mínima de Estoque";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(17, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 19);
            this.label4.TabIndex = 48;
            this.label4.Text = "Valor de Compra";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(17, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 19);
            this.label5.TabIndex = 49;
            this.label5.Text = "Valor de Venda";
            // 
            // RegisterProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(382, 464);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTotalProfit);
            this.Controls.Add(this.txtTotalSale);
            this.Controls.Add(this.lblReturnDB);
            this.Controls.Add(this.txtInventoryMin);
            this.Controls.Add(this.lblRegisterGroup);
            this.Controls.Add(this.txtProdName);
            this.Controls.Add(this.txtQtd);
            this.Controls.Add(this.txtBuyValue);
            this.Controls.Add(this.txtSaleValue);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbUnidade_De_Medida);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.cmbMarca);
            this.Controls.Add(this.lblGrupo);
            this.Controls.Add(this.cmbGrupo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.butRegisterProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Produto";
            this.Load += new System.EventHandler(this.RegisterProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblReturnDB;
        private TextBox txtInventoryMin;
        private Label lblRegisterGroup;
        private TextBox txtProdName;
        private TextBox txtQtd;
        private TextBox txtBuyValue;
        private TextBox txtSaleValue;
        private TextBox txtTotal;
        private Label label1;
        private ComboBox cmbUnidade_De_Medida;
        private Label lblMarca;
        private ComboBox cmbMarca;
        private Label lblGrupo;
        private ComboBox cmbGrupo;
        private PictureBox pictureBox1;
        private Models.MNButton butRegisterProduct;
        private System.Windows.Forms.Timer RefreshForm;
        private TextBox txtTotalSale;
        private TextBox txtTotalProfit;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}