namespace Projeto_Tabacaria.View.Client
{
    partial class EditCostumer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCostumer));
            this.cmbSelectClient = new System.Windows.Forms.ComboBox();
            this.txtNameClient = new System.Windows.Forms.TextBox();
            this.txtPhoneClient = new System.Windows.Forms.TextBox();
            this.picCloseEditProduct = new System.Windows.Forms.PictureBox();
            this.btnEditClient = new Projeto_Tabacaria.Models.MNButton();
            this.searchButton = new System.Windows.Forms.PictureBox();
            this.RefreshCmbClient = new System.Windows.Forms.Timer(this.components);
            this.lblRegisterGroup = new System.Windows.Forms.Label();
            this.lblReturnDB = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCloseEditProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchButton)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbSelectClient
            // 
            this.cmbSelectClient.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbSelectClient.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSelectClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelectClient.FormattingEnabled = true;
            this.cmbSelectClient.Location = new System.Drawing.Point(24, 53);
            this.cmbSelectClient.Name = "cmbSelectClient";
            this.cmbSelectClient.Size = new System.Drawing.Size(241, 23);
            this.cmbSelectClient.TabIndex = 0;
            // 
            // txtNameClient
            // 
            this.txtNameClient.Location = new System.Drawing.Point(24, 105);
            this.txtNameClient.Name = "txtNameClient";
            this.txtNameClient.PlaceholderText = "Nome do cliente";
            this.txtNameClient.Size = new System.Drawing.Size(241, 23);
            this.txtNameClient.TabIndex = 1;
            // 
            // txtPhoneClient
            // 
            this.txtPhoneClient.Location = new System.Drawing.Point(24, 144);
            this.txtPhoneClient.Name = "txtPhoneClient";
            this.txtPhoneClient.PlaceholderText = "Celular do cliente";
            this.txtPhoneClient.Size = new System.Drawing.Size(241, 23);
            this.txtPhoneClient.TabIndex = 2;
            // 
            // picCloseEditProduct
            // 
            this.picCloseEditProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCloseEditProduct.Image = global::Projeto_Tabacaria.Properties.Resources.close_correto;
            this.picCloseEditProduct.Location = new System.Drawing.Point(284, 0);
            this.picCloseEditProduct.Name = "picCloseEditProduct";
            this.picCloseEditProduct.Size = new System.Drawing.Size(28, 24);
            this.picCloseEditProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCloseEditProduct.TabIndex = 11;
            this.picCloseEditProduct.TabStop = false;
            this.picCloseEditProduct.Click += new System.EventHandler(this.picCloseEditProduct_Click);
            // 
            // btnEditClient
            // 
            this.btnEditClient.BackColor = System.Drawing.Color.Teal;
            this.btnEditClient.BackgroundColor = System.Drawing.Color.Teal;
            this.btnEditClient.BorderColor = System.Drawing.Color.Black;
            this.btnEditClient.BorderRadius = 10;
            this.btnEditClient.BorderSize = 0;
            this.btnEditClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditClient.FlatAppearance.BorderSize = 0;
            this.btnEditClient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditClient.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditClient.ForeColor = System.Drawing.Color.White;
            this.btnEditClient.Image = global::Projeto_Tabacaria.Properties.Resources.editar1;
            this.btnEditClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditClient.Location = new System.Drawing.Point(61, 215);
            this.btnEditClient.Name = "btnEditClient";
            this.btnEditClient.Size = new System.Drawing.Size(195, 58);
            this.btnEditClient.TabIndex = 34;
            this.btnEditClient.Text = "       Salvar Alterações";
            this.btnEditClient.TextColor = System.Drawing.Color.White;
            this.btnEditClient.UseVisualStyleBackColor = false;
            this.btnEditClient.Click += new System.EventHandler(this.btnEditClient_Click);
            // 
            // searchButton
            // 
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.Image = global::Projeto_Tabacaria.Properties.Resources.lupa1;
            this.searchButton.Location = new System.Drawing.Point(271, 49);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(30, 27);
            this.searchButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.searchButton.TabIndex = 35;
            this.searchButton.TabStop = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // RefreshCmbClient
            // 
            this.RefreshCmbClient.Tick += new System.EventHandler(this.RefreshCmbClient_Tick);
            // 
            // lblRegisterGroup
            // 
            this.lblRegisterGroup.AutoSize = true;
            this.lblRegisterGroup.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRegisterGroup.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRegisterGroup.Location = new System.Drawing.Point(61, 2);
            this.lblRegisterGroup.Name = "lblRegisterGroup";
            this.lblRegisterGroup.Size = new System.Drawing.Size(175, 28);
            this.lblRegisterGroup.TabIndex = 44;
            this.lblRegisterGroup.Text = "EDITAR CLIENTE";
            // 
            // lblReturnDB
            // 
            this.lblReturnDB.AutoSize = true;
            this.lblReturnDB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReturnDB.ForeColor = System.Drawing.SystemColors.Control;
            this.lblReturnDB.Location = new System.Drawing.Point(82, 193);
            this.lblReturnDB.Name = "lblReturnDB";
            this.lblReturnDB.Size = new System.Drawing.Size(93, 19);
            this.lblReturnDB.TabIndex = 45;
            this.lblReturnDB.Text = "Return DB";
            // 
            // EditCostumer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(312, 299);
            this.Controls.Add(this.lblReturnDB);
            this.Controls.Add(this.lblRegisterGroup);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.btnEditClient);
            this.Controls.Add(this.picCloseEditProduct);
            this.Controls.Add(this.txtPhoneClient);
            this.Controls.Add(this.txtNameClient);
            this.Controls.Add(this.cmbSelectClient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditCostumer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditClient";
            this.Load += new System.EventHandler(this.EditClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCloseEditProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cmbSelectClient;
        private TextBox txtNameClient;
        private TextBox txtPhoneClient;
        private PictureBox picCloseEditProduct;
        private Models.MNButton btnEditClient;
        private PictureBox searchButton;
        private System.Windows.Forms.Timer RefreshCmbClient;
        private Label lblRegisterGroup;
        private Label lblReturnDB;
    }
}