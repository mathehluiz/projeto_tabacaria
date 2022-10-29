namespace Projeto_Tabacaria.View.Inventory
{
    partial class RegisterCup
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblProduct = new System.Windows.Forms.Label();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.txtCupName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.butRegisterProduct = new Projeto_Tabacaria.Models.MNButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValueCup = new System.Windows.Forms.TextBox();
            this.lblReturnDB = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRegisterGroup
            // 
            this.lblRegisterGroup.AutoSize = true;
            this.lblRegisterGroup.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRegisterGroup.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRegisterGroup.Location = new System.Drawing.Point(75, 9);
            this.lblRegisterGroup.Name = "lblRegisterGroup";
            this.lblRegisterGroup.Size = new System.Drawing.Size(188, 28);
            this.lblRegisterGroup.TabIndex = 43;
            this.lblRegisterGroup.Text = "REGISTRAR COPO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projeto_Tabacaria.Properties.Resources.close_correto;
            this.pictureBox1.Location = new System.Drawing.Point(304, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProduct.ForeColor = System.Drawing.Color.White;
            this.lblProduct.Location = new System.Drawing.Point(11, 57);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(72, 21);
            this.lblProduct.TabIndex = 46;
            this.lblProduct.Text = "Produto";
            // 
            // cmbProduct
            // 
            this.cmbProduct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbProduct.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbProduct.BackColor = System.Drawing.Color.White;
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(84, 56);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(221, 23);
            this.cmbProduct.TabIndex = 45;
            this.cmbProduct.TabStop = false;
            // 
            // txtCupName
            // 
            this.txtCupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCupName.Location = new System.Drawing.Point(98, 107);
            this.txtCupName.Name = "txtCupName";
            this.txtCupName.PlaceholderText = "Nome do Copo";
            this.txtCupName.Size = new System.Drawing.Size(207, 22);
            this.txtCupName.TabIndex = 47;
            this.txtCupName.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 21);
            this.label1.TabIndex = 48;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 50;
            this.label2.Text = "Tamanho";
            // 
            // txtQtd
            // 
            this.txtQtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtQtd.Location = new System.Drawing.Point(99, 138);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.PlaceholderText = "Quantidade";
            this.txtQtd.Size = new System.Drawing.Size(207, 22);
            this.txtQtd.TabIndex = 49;
            this.txtQtd.Text = "0";
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
            this.butRegisterProduct.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.butRegisterProduct.ForeColor = System.Drawing.Color.White;
            this.butRegisterProduct.Image = global::Projeto_Tabacaria.Properties.Resources.registrar;
            this.butRegisterProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butRegisterProduct.Location = new System.Drawing.Point(84, 244);
            this.butRegisterProduct.Name = "butRegisterProduct";
            this.butRegisterProduct.Size = new System.Drawing.Size(168, 49);
            this.butRegisterProduct.TabIndex = 51;
            this.butRegisterProduct.Text = "        Registrar Copo";
            this.butRegisterProduct.TextColor = System.Drawing.Color.White;
            this.butRegisterProduct.UseVisualStyleBackColor = false;
            this.butRegisterProduct.Click += new System.EventHandler(this.butRegisterProduct_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(11, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 19);
            this.label3.TabIndex = 52;
            this.label3.Text = "Valor";
            // 
            // txtValueCup
            // 
            this.txtValueCup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtValueCup.Location = new System.Drawing.Point(98, 169);
            this.txtValueCup.Name = "txtValueCup";
            this.txtValueCup.PlaceholderText = "Quantidade";
            this.txtValueCup.Size = new System.Drawing.Size(207, 22);
            this.txtValueCup.TabIndex = 53;
            this.txtValueCup.Text = "0";
            // 
            // lblReturnDB
            // 
            this.lblReturnDB.AutoSize = true;
            this.lblReturnDB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReturnDB.ForeColor = System.Drawing.SystemColors.Control;
            this.lblReturnDB.Location = new System.Drawing.Point(84, 211);
            this.lblReturnDB.Name = "lblReturnDB";
            this.lblReturnDB.Size = new System.Drawing.Size(93, 19);
            this.lblReturnDB.TabIndex = 54;
            this.lblReturnDB.Text = "Return DB";
            // 
            // RegisterCup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(333, 311);
            this.Controls.Add(this.lblReturnDB);
            this.Controls.Add(this.txtValueCup);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.butRegisterProduct);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtQtd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCupName);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.cmbProduct);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblRegisterGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterCup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterCup";
            this.Load += new System.EventHandler(this.RegisterCup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblRegisterGroup;
        private PictureBox pictureBox1;
        private Label lblProduct;
        private ComboBox cmbProduct;
        private TextBox txtCupName;
        private Label label1;
        private Label label2;
        private TextBox txtQtd;
        private Models.MNButton butRegisterProduct;
        private Label label3;
        private TextBox txtValueCup;
        private Label lblReturnDB;
    }
}