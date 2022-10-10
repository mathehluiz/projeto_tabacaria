namespace Projeto_Tabacaria.View
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
            this.txtProdCod = new CustomControls.RJControls.RJTextBox();
            this.txtProdName = new CustomControls.RJControls.RJTextBox();
            this.txtBuyValue = new CustomControls.RJControls.RJTextBox();
            this.txtSaleValue = new CustomControls.RJControls.RJTextBox();
            this.lblCod = new System.Windows.Forms.Label();
            this.txtTotal = new CustomControls.RJControls.RJTextBox();
            this.butRegisterProduct = new Projeto_Tabacaria.Models.MNButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtQtd = new CustomControls.RJControls.RJTextBox();
            this.cmbGrupo = new System.Windows.Forms.ComboBox();
            this.lblGrupo = new System.Windows.Forms.Label();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.cmbUnidade_De_Medida = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtProdCod
            // 
            this.txtProdCod.BackColor = System.Drawing.SystemColors.Window;
            this.txtProdCod.BorderColor = System.Drawing.Color.White;
            this.txtProdCod.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(204)))), ((int)(((byte)(55)))));
            this.txtProdCod.BorderRadius = 6;
            this.txtProdCod.BorderSize = 2;
            this.txtProdCod.Enabled = false;
            this.txtProdCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtProdCod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtProdCod.Location = new System.Drawing.Point(80, 27);
            this.txtProdCod.Margin = new System.Windows.Forms.Padding(4);
            this.txtProdCod.Multiline = false;
            this.txtProdCod.Name = "txtProdCod";
            this.txtProdCod.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtProdCod.PasswordChar = false;
            this.txtProdCod.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtProdCod.PlaceholderText = "";
            this.txtProdCod.Size = new System.Drawing.Size(40, 31);
            this.txtProdCod.TabIndex = 0;
            this.txtProdCod.Texts = "";
            this.txtProdCod.UnderlinedStyle = false;
            // 
            // txtProdName
            // 
            this.txtProdName.BackColor = System.Drawing.SystemColors.Window;
            this.txtProdName.BorderColor = System.Drawing.Color.White;
            this.txtProdName.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(204)))), ((int)(((byte)(55)))));
            this.txtProdName.BorderRadius = 6;
            this.txtProdName.BorderSize = 2;
            this.txtProdName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtProdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtProdName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtProdName.Location = new System.Drawing.Point(14, 111);
            this.txtProdName.Margin = new System.Windows.Forms.Padding(4);
            this.txtProdName.Multiline = false;
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtProdName.PasswordChar = false;
            this.txtProdName.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtProdName.PlaceholderText = "Nome do produto";
            this.txtProdName.Size = new System.Drawing.Size(341, 31);
            this.txtProdName.TabIndex = 1;
            this.txtProdName.TabStop = false;
            this.txtProdName.Texts = "";
            this.txtProdName.UnderlinedStyle = false;
            // 
            // txtBuyValue
            // 
            this.txtBuyValue.BackColor = System.Drawing.SystemColors.Window;
            this.txtBuyValue.BorderColor = System.Drawing.Color.White;
            this.txtBuyValue.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(204)))), ((int)(((byte)(55)))));
            this.txtBuyValue.BorderRadius = 6;
            this.txtBuyValue.BorderSize = 2;
            this.txtBuyValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBuyValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBuyValue.Location = new System.Drawing.Point(14, 228);
            this.txtBuyValue.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuyValue.Multiline = false;
            this.txtBuyValue.Name = "txtBuyValue";
            this.txtBuyValue.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtBuyValue.PasswordChar = false;
            this.txtBuyValue.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtBuyValue.PlaceholderText = "Valor unitário de compra";
            this.txtBuyValue.Size = new System.Drawing.Size(341, 31);
            this.txtBuyValue.TabIndex = 4;
            this.txtBuyValue.TabStop = false;
            this.txtBuyValue.Texts = "";
            this.txtBuyValue.UnderlinedStyle = false;
            this.txtBuyValue._TextChanged += new System.EventHandler(this.txtBuyValue__TextChanged);
            // 
            // txtSaleValue
            // 
            this.txtSaleValue.BackColor = System.Drawing.SystemColors.Window;
            this.txtSaleValue.BorderColor = System.Drawing.Color.White;
            this.txtSaleValue.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(204)))), ((int)(((byte)(55)))));
            this.txtSaleValue.BorderRadius = 6;
            this.txtSaleValue.BorderSize = 2;
            this.txtSaleValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSaleValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSaleValue.Location = new System.Drawing.Point(14, 267);
            this.txtSaleValue.Margin = new System.Windows.Forms.Padding(4);
            this.txtSaleValue.Multiline = false;
            this.txtSaleValue.Name = "txtSaleValue";
            this.txtSaleValue.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSaleValue.PasswordChar = false;
            this.txtSaleValue.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtSaleValue.PlaceholderText = "Valor unitário de venda";
            this.txtSaleValue.Size = new System.Drawing.Size(341, 31);
            this.txtSaleValue.TabIndex = 5;
            this.txtSaleValue.TabStop = false;
            this.txtSaleValue.Texts = "";
            this.txtSaleValue.UnderlinedStyle = false;
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(204)))), ((int)(((byte)(55)))));
            this.lblCod.Location = new System.Drawing.Point(14, 32);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(59, 19);
            this.lblCod.TabIndex = 6;
            this.lblCod.Text = "Código";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.Window;
            this.txtTotal.BorderColor = System.Drawing.Color.White;
            this.txtTotal.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(204)))), ((int)(((byte)(55)))));
            this.txtTotal.BorderRadius = 6;
            this.txtTotal.BorderSize = 2;
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTotal.Location = new System.Drawing.Point(15, 306);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Multiline = false;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTotal.PasswordChar = false;
            this.txtTotal.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtTotal.PlaceholderText = "Total Gasto";
            this.txtTotal.Size = new System.Drawing.Size(94, 31);
            this.txtTotal.TabIndex = 6;
            this.txtTotal.TabStop = false;
            this.txtTotal.Texts = "";
            this.txtTotal.UnderlinedStyle = false;
            // 
            // butRegisterProduct
            // 
            this.butRegisterProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(113)))), ((int)(((byte)(49)))));
            this.butRegisterProduct.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(113)))), ((int)(((byte)(49)))));
            this.butRegisterProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butRegisterProduct.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(204)))), ((int)(((byte)(55)))));
            this.butRegisterProduct.BorderRadius = 20;
            this.butRegisterProduct.BorderSize = 0;
            this.butRegisterProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butRegisterProduct.FlatAppearance.BorderSize = 0;
            this.butRegisterProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butRegisterProduct.Font = new System.Drawing.Font("Gadugi", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.butRegisterProduct.ForeColor = System.Drawing.Color.Black;
            this.butRegisterProduct.Image = global::Projeto_Tabacaria.Properties.Resources.registro1;
            this.butRegisterProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butRegisterProduct.Location = new System.Drawing.Point(106, 359);
            this.butRegisterProduct.Name = "butRegisterProduct";
            this.butRegisterProduct.Size = new System.Drawing.Size(168, 49);
            this.butRegisterProduct.TabIndex = 7;
            this.butRegisterProduct.Text = "Registrar";
            this.butRegisterProduct.TextColor = System.Drawing.Color.Black;
            this.butRegisterProduct.UseVisualStyleBackColor = false;
            this.butRegisterProduct.Click += new System.EventHandler(this.butRegisterProduct_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projeto_Tabacaria.Properties.Resources.Close;
            this.pictureBox1.Location = new System.Drawing.Point(339, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtQtd
            // 
            this.txtQtd.BackColor = System.Drawing.SystemColors.Window;
            this.txtQtd.BorderColor = System.Drawing.Color.White;
            this.txtQtd.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(204)))), ((int)(((byte)(55)))));
            this.txtQtd.BorderRadius = 6;
            this.txtQtd.BorderSize = 2;
            this.txtQtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtQtd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtQtd.Location = new System.Drawing.Point(15, 150);
            this.txtQtd.Margin = new System.Windows.Forms.Padding(4);
            this.txtQtd.Multiline = false;
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtQtd.PasswordChar = false;
            this.txtQtd.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtQtd.PlaceholderText = "Quantidade";
            this.txtQtd.Size = new System.Drawing.Size(341, 31);
            this.txtQtd.TabIndex = 10;
            this.txtQtd.TabStop = false;
            this.txtQtd.Texts = "";
            this.txtQtd.UnderlinedStyle = false;
            this.txtQtd._TextChanged += new System.EventHandler(this.txtQtd__TextChanged);
            // 
            // cmbGrupo
            // 
            this.cmbGrupo.FormattingEnabled = true;
            this.cmbGrupo.Location = new System.Drawing.Point(80, 81);
            this.cmbGrupo.Name = "cmbGrupo";
            this.cmbGrupo.Size = new System.Drawing.Size(93, 23);
            this.cmbGrupo.TabIndex = 11;
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGrupo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(204)))), ((int)(((byte)(55)))));
            this.lblGrupo.Location = new System.Drawing.Point(12, 81);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(53, 19);
            this.lblGrupo.TabIndex = 12;
            this.lblGrupo.Text = "Grupo";
            // 
            // cmbMarca
            // 
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(261, 81);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(93, 23);
            this.cmbMarca.TabIndex = 13;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(204)))), ((int)(((byte)(55)))));
            this.lblMarca.Location = new System.Drawing.Point(203, 81);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(52, 19);
            this.lblMarca.TabIndex = 14;
            this.lblMarca.Text = "Marca";
            // 
            // cmbUnidade_De_Medida
            // 
            this.cmbUnidade_De_Medida.FormattingEnabled = true;
            this.cmbUnidade_De_Medida.Items.AddRange(new object[] {
            "ML",
            "LT",
            "UN"});
            this.cmbUnidade_De_Medida.Location = new System.Drawing.Point(165, 188);
            this.cmbUnidade_De_Medida.Name = "cmbUnidade_De_Medida";
            this.cmbUnidade_De_Medida.Size = new System.Drawing.Size(64, 23);
            this.cmbUnidade_De_Medida.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(204)))), ((int)(((byte)(55)))));
            this.label1.Location = new System.Drawing.Point(15, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 19);
            this.label1.TabIndex = 17;
            this.label1.Text = "Unidade de Medida";
            // 
            // RegisterProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(379, 420);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbUnidade_De_Medida);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.cmbMarca);
            this.Controls.Add(this.lblGrupo);
            this.Controls.Add(this.cmbGrupo);
            this.Controls.Add(this.txtQtd);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.butRegisterProduct);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblCod);
            this.Controls.Add(this.txtSaleValue);
            this.Controls.Add(this.txtBuyValue);
            this.Controls.Add(this.txtProdName);
            this.Controls.Add(this.txtProdCod);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterProduct";
            this.Load += new System.EventHandler(this.RegisterProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.RJControls.RJTextBox txtProdCod;
        private CustomControls.RJControls.RJTextBox txtProdName;
        private CustomControls.RJControls.RJTextBox txtBuyValue;
        private CustomControls.RJControls.RJTextBox txtSaleValue;
        private Label lblCod;
        private CustomControls.RJControls.RJTextBox txtTotal;
        private Models.MNButton butRegisterProduct;
        private PictureBox pictureBox1;
        private CustomControls.RJControls.RJTextBox txtQtd;
        private ComboBox cmbGrupo;
        private Label lblGrupo;
        private ComboBox cmbMarca;
        private Label lblMarca;
        private ComboBox cmbUnidade_De_Medida;
        private Label label1;
    }
}