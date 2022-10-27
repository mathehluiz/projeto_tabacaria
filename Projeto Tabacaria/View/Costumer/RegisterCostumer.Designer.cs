namespace Projeto_Tabacaria.View.Client
{
    partial class RegisterCostumer
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCreateClient = new Projeto_Tabacaria.Models.MNButton();
            this.txtNameClient = new CustomControls.RJControls.RJTextBox();
            this.txtPhoneClient = new CustomControls.RJControls.RJTextBox();
            this.lblRegisterGroup = new System.Windows.Forms.Label();
            this.lblReturnDB = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projeto_Tabacaria.Properties.Resources.close_correto;
            this.pictureBox1.Location = new System.Drawing.Point(335, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnCreateClient
            // 
            this.btnCreateClient.BackColor = System.Drawing.Color.Teal;
            this.btnCreateClient.BackgroundColor = System.Drawing.Color.Teal;
            this.btnCreateClient.BorderColor = System.Drawing.Color.Black;
            this.btnCreateClient.BorderRadius = 10;
            this.btnCreateClient.BorderSize = 0;
            this.btnCreateClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateClient.FlatAppearance.BorderSize = 0;
            this.btnCreateClient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreateClient.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCreateClient.ForeColor = System.Drawing.Color.White;
            this.btnCreateClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateClient.Location = new System.Drawing.Point(63, 176);
            this.btnCreateClient.Name = "btnCreateClient";
            this.btnCreateClient.Size = new System.Drawing.Size(201, 51);
            this.btnCreateClient.TabIndex = 18;
            this.btnCreateClient.Text = "    Cadastrar";
            this.btnCreateClient.TextColor = System.Drawing.Color.White;
            this.btnCreateClient.UseVisualStyleBackColor = false;
            this.btnCreateClient.Click += new System.EventHandler(this.btnCreateClient_Click);
            // 
            // txtNameClient
            // 
            this.txtNameClient.BackColor = System.Drawing.SystemColors.Window;
            this.txtNameClient.BorderColor = System.Drawing.Color.White;
            this.txtNameClient.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(204)))), ((int)(((byte)(55)))));
            this.txtNameClient.BorderRadius = 6;
            this.txtNameClient.BorderSize = 2;
            this.txtNameClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNameClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNameClient.Location = new System.Drawing.Point(30, 59);
            this.txtNameClient.Margin = new System.Windows.Forms.Padding(4);
            this.txtNameClient.Multiline = false;
            this.txtNameClient.Name = "txtNameClient";
            this.txtNameClient.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNameClient.PasswordChar = false;
            this.txtNameClient.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNameClient.PlaceholderText = "Nome do cliente";
            this.txtNameClient.Size = new System.Drawing.Size(302, 31);
            this.txtNameClient.TabIndex = 19;
            this.txtNameClient.Texts = "";
            this.txtNameClient.UnderlinedStyle = false;
            // 
            // txtPhoneClient
            // 
            this.txtPhoneClient.BackColor = System.Drawing.SystemColors.Window;
            this.txtPhoneClient.BorderColor = System.Drawing.Color.White;
            this.txtPhoneClient.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(204)))), ((int)(((byte)(55)))));
            this.txtPhoneClient.BorderRadius = 6;
            this.txtPhoneClient.BorderSize = 2;
            this.txtPhoneClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPhoneClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPhoneClient.Location = new System.Drawing.Point(30, 98);
            this.txtPhoneClient.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhoneClient.Multiline = false;
            this.txtPhoneClient.Name = "txtPhoneClient";
            this.txtPhoneClient.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPhoneClient.PasswordChar = false;
            this.txtPhoneClient.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPhoneClient.PlaceholderText = "Número celular";
            this.txtPhoneClient.Size = new System.Drawing.Size(302, 31);
            this.txtPhoneClient.TabIndex = 20;
            this.txtPhoneClient.Texts = "";
            this.txtPhoneClient.UnderlinedStyle = false;
            // 
            // lblRegisterGroup
            // 
            this.lblRegisterGroup.AutoSize = true;
            this.lblRegisterGroup.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRegisterGroup.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRegisterGroup.Location = new System.Drawing.Point(63, 9);
            this.lblRegisterGroup.Name = "lblRegisterGroup";
            this.lblRegisterGroup.Size = new System.Drawing.Size(225, 28);
            this.lblRegisterGroup.TabIndex = 43;
            this.lblRegisterGroup.Text = "CADASTRAR CLIENTE";
            // 
            // lblReturnDB
            // 
            this.lblReturnDB.AutoSize = true;
            this.lblReturnDB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReturnDB.ForeColor = System.Drawing.SystemColors.Control;
            this.lblReturnDB.Location = new System.Drawing.Point(81, 145);
            this.lblReturnDB.Name = "lblReturnDB";
            this.lblReturnDB.Size = new System.Drawing.Size(93, 19);
            this.lblReturnDB.TabIndex = 44;
            this.lblReturnDB.Text = "Return DB";
            // 
            // RegisterCostumer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(363, 243);
            this.Controls.Add(this.lblReturnDB);
            this.Controls.Add(this.lblRegisterGroup);
            this.Controls.Add(this.txtPhoneClient);
            this.Controls.Add(this.txtNameClient);
            this.Controls.Add(this.btnCreateClient);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterCostumer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterClient";
            this.Load += new System.EventHandler(this.RegisterCostumer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Models.MNButton btnCreateClient;
        private CustomControls.RJControls.RJTextBox txtNameClient;
        private CustomControls.RJControls.RJTextBox txtPhoneClient;
        private Label lblRegisterGroup;
        private Label lblReturnDB;
    }
}