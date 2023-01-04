namespace Projeto_Tabacaria.View.Inventory
{
    partial class RegisterBarcodeCup
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
            this.lblQuantityBarcode = new System.Windows.Forms.Label();
            this.lblReturnDB = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRegisterGroup = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.cmbCopo = new System.Windows.Forms.ComboBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.cmbGarrafa = new System.Windows.Forms.ComboBox();
            this.btnRegBarcode = new Projeto_Tabacaria.Models.MNButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQuantityBarcode
            // 
            this.lblQuantityBarcode.AutoSize = true;
            this.lblQuantityBarcode.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblQuantityBarcode.ForeColor = System.Drawing.SystemColors.Control;
            this.lblQuantityBarcode.Location = new System.Drawing.Point(43, 153);
            this.lblQuantityBarcode.Name = "lblQuantityBarcode";
            this.lblQuantityBarcode.Size = new System.Drawing.Size(103, 19);
            this.lblQuantityBarcode.TabIndex = 64;
            this.lblQuantityBarcode.Text = "Return DB1";
            // 
            // lblReturnDB
            // 
            this.lblReturnDB.AutoSize = true;
            this.lblReturnDB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReturnDB.ForeColor = System.Drawing.SystemColors.Control;
            this.lblReturnDB.Location = new System.Drawing.Point(157, 174);
            this.lblReturnDB.Name = "lblReturnDB";
            this.lblReturnDB.Size = new System.Drawing.Size(93, 19);
            this.lblReturnDB.TabIndex = 63;
            this.lblReturnDB.Text = "Return DB";
            // 
            // txtBarcode
            // 
            this.txtBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBarcode.Location = new System.Drawing.Point(165, 99);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.PlaceholderText = "CÓDIGO DE BARRA";
            this.txtBarcode.Size = new System.Drawing.Size(239, 22);
            this.txtBarcode.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 21);
            this.label1.TabIndex = 62;
            this.label1.Text = "Código de barra";
            // 
            // lblRegisterGroup
            // 
            this.lblRegisterGroup.AutoSize = true;
            this.lblRegisterGroup.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRegisterGroup.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRegisterGroup.Location = new System.Drawing.Point(67, 9);
            this.lblRegisterGroup.Name = "lblRegisterGroup";
            this.lblRegisterGroup.Size = new System.Drawing.Size(322, 28);
            this.lblRegisterGroup.TabIndex = 61;
            this.lblRegisterGroup.Text = "REGISTRAR CÓDIGO DE BARRA";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProduct.ForeColor = System.Drawing.Color.White;
            this.lblProduct.Location = new System.Drawing.Point(177, 67);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(50, 21);
            this.lblProduct.TabIndex = 60;
            this.lblProduct.Text = "Copo";
            // 
            // cmbCopo
            // 
            this.cmbCopo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCopo.FormattingEnabled = true;
            this.cmbCopo.Location = new System.Drawing.Point(233, 67);
            this.cmbCopo.Name = "cmbCopo";
            this.cmbCopo.Size = new System.Drawing.Size(150, 23);
            this.cmbCopo.TabIndex = 58;
            this.cmbCopo.TabStop = false;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMarca.ForeColor = System.Drawing.Color.White;
            this.lblMarca.Location = new System.Drawing.Point(6, 66);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(66, 21);
            this.lblMarca.TabIndex = 59;
            this.lblMarca.Text = "Garrafa";
            // 
            // cmbGarrafa
            // 
            this.cmbGarrafa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGarrafa.FormattingEnabled = true;
            this.cmbGarrafa.Location = new System.Drawing.Point(74, 66);
            this.cmbGarrafa.Name = "cmbGarrafa";
            this.cmbGarrafa.Size = new System.Drawing.Size(93, 23);
            this.cmbGarrafa.TabIndex = 57;
            this.cmbGarrafa.TabStop = false;
            this.cmbGarrafa.SelectedIndexChanged += new System.EventHandler(this.cmbGarrafa_SelectedIndexChanged);
            // 
            // btnRegBarcode
            // 
            this.btnRegBarcode.BackColor = System.Drawing.Color.Teal;
            this.btnRegBarcode.BackgroundColor = System.Drawing.Color.Teal;
            this.btnRegBarcode.BorderColor = System.Drawing.Color.Teal;
            this.btnRegBarcode.BorderRadius = 10;
            this.btnRegBarcode.BorderSize = 0;
            this.btnRegBarcode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegBarcode.FlatAppearance.BorderSize = 0;
            this.btnRegBarcode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegBarcode.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegBarcode.ForeColor = System.Drawing.Color.White;
            this.btnRegBarcode.Image = global::Projeto_Tabacaria.Properties.Resources.barcode;
            this.btnRegBarcode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegBarcode.Location = new System.Drawing.Point(122, 196);
            this.btnRegBarcode.Name = "btnRegBarcode";
            this.btnRegBarcode.Size = new System.Drawing.Size(212, 51);
            this.btnRegBarcode.TabIndex = 65;
            this.btnRegBarcode.Text = "       Cadastrar Código";
            this.btnRegBarcode.TextColor = System.Drawing.Color.White;
            this.btnRegBarcode.UseVisualStyleBackColor = false;
            this.btnRegBarcode.Click += new System.EventHandler(this.btnRegBarcode_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projeto_Tabacaria.Properties.Resources.close_correto;
            this.pictureBox1.Location = new System.Drawing.Point(416, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 66;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // RegisterBarcodeCup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(452, 265);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRegBarcode);
            this.Controls.Add(this.lblQuantityBarcode);
            this.Controls.Add(this.lblReturnDB);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRegisterGroup);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.cmbCopo);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.cmbGarrafa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterBarcodeCup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterBarcodeCup";
            this.Load += new System.EventHandler(this.RegisterBarcodeCup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblQuantityBarcode;
        private Label lblReturnDB;
        private TextBox txtBarcode;
        private Label label1;
        private Label lblRegisterGroup;
        private Label lblProduct;
        private ComboBox cmbCopo;
        private Label lblMarca;
        private ComboBox cmbGarrafa;
        private Models.MNButton btnRegBarcode;
        private PictureBox pictureBox1;
    }
}