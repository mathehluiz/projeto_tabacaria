namespace Projeto_Tabacaria.View.Client
{
    partial class DeleteCostumer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteCostumer));
            this.cmbSearchClient = new System.Windows.Forms.ComboBox();
            this.btnDeleteClient = new Projeto_Tabacaria.Models.MNButton();
            this.picCloseEditProduct = new System.Windows.Forms.PictureBox();
            this.refreshDeleteClient = new System.Windows.Forms.Timer(this.components);
            this.lblRegisterGroup = new System.Windows.Forms.Label();
            this.lblReturnDB = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCloseEditProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbSearchClient
            // 
            this.cmbSearchClient.FormattingEnabled = true;
            this.cmbSearchClient.Location = new System.Drawing.Point(23, 43);
            this.cmbSearchClient.Name = "cmbSearchClient";
            this.cmbSearchClient.Size = new System.Drawing.Size(193, 23);
            this.cmbSearchClient.TabIndex = 0;
            this.cmbSearchClient.TabStop = false;
            // 
            // btnDeleteClient
            // 
            this.btnDeleteClient.BackColor = System.Drawing.Color.Teal;
            this.btnDeleteClient.BackgroundColor = System.Drawing.Color.Teal;
            this.btnDeleteClient.BorderColor = System.Drawing.Color.Teal;
            this.btnDeleteClient.BorderRadius = 10;
            this.btnDeleteClient.BorderSize = 0;
            this.btnDeleteClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteClient.FlatAppearance.BorderSize = 0;
            this.btnDeleteClient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteClient.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteClient.ForeColor = System.Drawing.Color.White;
            this.btnDeleteClient.Image = global::Projeto_Tabacaria.Properties.Resources.lixeira_de_reciclagem;
            this.btnDeleteClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteClient.Location = new System.Drawing.Point(56, 101);
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.Size = new System.Drawing.Size(147, 48);
            this.btnDeleteClient.TabIndex = 1;
            this.btnDeleteClient.Text = "  Deletar";
            this.btnDeleteClient.TextColor = System.Drawing.Color.White;
            this.btnDeleteClient.UseVisualStyleBackColor = false;
            this.btnDeleteClient.Click += new System.EventHandler(this.btnDeleteClient_Click);
            // 
            // picCloseEditProduct
            // 
            this.picCloseEditProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCloseEditProduct.Image = global::Projeto_Tabacaria.Properties.Resources.close_correto;
            this.picCloseEditProduct.Location = new System.Drawing.Point(222, 2);
            this.picCloseEditProduct.Name = "picCloseEditProduct";
            this.picCloseEditProduct.Size = new System.Drawing.Size(28, 24);
            this.picCloseEditProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCloseEditProduct.TabIndex = 36;
            this.picCloseEditProduct.TabStop = false;
            this.picCloseEditProduct.Click += new System.EventHandler(this.picCloseEditProduct_Click);
            // 
            // refreshDeleteClient
            // 
            this.refreshDeleteClient.Tick += new System.EventHandler(this.refreshDeleteClient_Tick);
            // 
            // lblRegisterGroup
            // 
            this.lblRegisterGroup.AutoSize = true;
            this.lblRegisterGroup.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRegisterGroup.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRegisterGroup.Location = new System.Drawing.Point(23, 2);
            this.lblRegisterGroup.Name = "lblRegisterGroup";
            this.lblRegisterGroup.Size = new System.Drawing.Size(190, 28);
            this.lblRegisterGroup.TabIndex = 42;
            this.lblRegisterGroup.Text = "DELETAR CLIENTE";
            // 
            // lblReturnDB
            // 
            this.lblReturnDB.AutoSize = true;
            this.lblReturnDB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReturnDB.ForeColor = System.Drawing.SystemColors.Control;
            this.lblReturnDB.Location = new System.Drawing.Point(67, 79);
            this.lblReturnDB.Name = "lblReturnDB";
            this.lblReturnDB.Size = new System.Drawing.Size(93, 19);
            this.lblReturnDB.TabIndex = 43;
            this.lblReturnDB.Text = "Return DB";
            this.lblReturnDB.Click += new System.EventHandler(this.lblReturnDB_Click);
            // 
            // DeleteCostumer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(256, 161);
            this.Controls.Add(this.lblReturnDB);
            this.Controls.Add(this.lblRegisterGroup);
            this.Controls.Add(this.picCloseEditProduct);
            this.Controls.Add(this.btnDeleteClient);
            this.Controls.Add(this.cmbSearchClient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeleteCostumer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteClient";
            this.Load += new System.EventHandler(this.DeleteClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCloseEditProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cmbSearchClient;
        private Models.MNButton btnDeleteClient;
        private PictureBox picCloseEditProduct;
        private System.Windows.Forms.Timer refreshDeleteClient;
        private Label lblRegisterGroup;
        private Label lblReturnDB;
    }
}