namespace Projeto_Tabacaria.View.Costumer
{
    partial class DebitPaymentCostumer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DebitPaymentCostumer));
            this.txtNameCostumer = new System.Windows.Forms.TextBox();
            this.txtTotalPay = new System.Windows.Forms.TextBox();
            this.btnPayDebit = new Projeto_Tabacaria.Models.MNButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotalDebit = new System.Windows.Forms.TextBox();
            this.picCloseEditProduct = new System.Windows.Forms.PictureBox();
            this.lblReturnDB = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCloseEditProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNameCostumer
            // 
            this.txtNameCostumer.Location = new System.Drawing.Point(7, 48);
            this.txtNameCostumer.Name = "txtNameCostumer";
            this.txtNameCostumer.PlaceholderText = "Nome do cliente";
            this.txtNameCostumer.Size = new System.Drawing.Size(180, 23);
            this.txtNameCostumer.TabIndex = 0;
            // 
            // txtTotalPay
            // 
            this.txtTotalPay.Location = new System.Drawing.Point(87, 106);
            this.txtTotalPay.Name = "txtTotalPay";
            this.txtTotalPay.PlaceholderText = "Total Pago";
            this.txtTotalPay.Size = new System.Drawing.Size(100, 23);
            this.txtTotalPay.TabIndex = 1;
            this.txtTotalPay.Text = "0";
            this.txtTotalPay.TextChanged += new System.EventHandler(this.txtTotalPay_TextChanged);
            this.txtTotalPay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotalPay_KeyPress);
            // 
            // btnPayDebit
            // 
            this.btnPayDebit.BackColor = System.Drawing.Color.Teal;
            this.btnPayDebit.BackgroundColor = System.Drawing.Color.Teal;
            this.btnPayDebit.BorderColor = System.Drawing.Color.Teal;
            this.btnPayDebit.BorderRadius = 20;
            this.btnPayDebit.BorderSize = 0;
            this.btnPayDebit.FlatAppearance.BorderSize = 0;
            this.btnPayDebit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPayDebit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPayDebit.ForeColor = System.Drawing.Color.White;
            this.btnPayDebit.Location = new System.Drawing.Point(62, 179);
            this.btnPayDebit.Name = "btnPayDebit";
            this.btnPayDebit.Size = new System.Drawing.Size(150, 40);
            this.btnPayDebit.TabIndex = 2;
            this.btnPayDebit.Text = "DEBITAR";
            this.btnPayDebit.TextColor = System.Drawing.Color.White;
            this.btnPayDebit.UseVisualStyleBackColor = false;
            this.btnPayDebit.Click += new System.EventHandler(this.btnPayDebit_Click);
            this.btnPayDebit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnPayDebit_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "PAGAMENTO DE DÍVIDA";
            // 
            // txtTotalDebit
            // 
            this.txtTotalDebit.Location = new System.Drawing.Point(87, 77);
            this.txtTotalDebit.Name = "txtTotalDebit";
            this.txtTotalDebit.Size = new System.Drawing.Size(100, 23);
            this.txtTotalDebit.TabIndex = 4;
            this.txtTotalDebit.Text = "0";
            this.txtTotalDebit.TextChanged += new System.EventHandler(this.txtTotalDebit_TextChanged);
            this.txtTotalDebit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotalDebit_KeyPress);
            // 
            // picCloseEditProduct
            // 
            this.picCloseEditProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCloseEditProduct.Image = global::Projeto_Tabacaria.Properties.Resources.close_correto;
            this.picCloseEditProduct.Location = new System.Drawing.Point(247, 3);
            this.picCloseEditProduct.Name = "picCloseEditProduct";
            this.picCloseEditProduct.Size = new System.Drawing.Size(28, 24);
            this.picCloseEditProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCloseEditProduct.TabIndex = 11;
            this.picCloseEditProduct.TabStop = false;
            this.picCloseEditProduct.Click += new System.EventHandler(this.picCloseEditProduct_Click);
            // 
            // lblReturnDB
            // 
            this.lblReturnDB.AutoSize = true;
            this.lblReturnDB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReturnDB.ForeColor = System.Drawing.SystemColors.Control;
            this.lblReturnDB.Location = new System.Drawing.Point(85, 146);
            this.lblReturnDB.Name = "lblReturnDB";
            this.lblReturnDB.Size = new System.Drawing.Size(93, 19);
            this.lblReturnDB.TabIndex = 27;
            this.lblReturnDB.Text = "Return DB";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(3, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 14);
            this.label2.TabIndex = 28;
            this.label2.Text = "Total Dívida:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(3, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 14);
            this.label3.TabIndex = 29;
            this.label3.Text = "Total Pago:";
            // 
            // DebitPaymentCostumer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(277, 231);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblReturnDB);
            this.Controls.Add(this.picCloseEditProduct);
            this.Controls.Add(this.txtTotalDebit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPayDebit);
            this.Controls.Add(this.txtTotalPay);
            this.Controls.Add(this.txtNameCostumer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DebitPaymentCostumer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DebitPaymentCostumer";
            this.Load += new System.EventHandler(this.DebitPaymentCostumer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCloseEditProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtNameCostumer;
        private TextBox txtTotalPay;
        private Models.MNButton btnPayDebit;
        private Label label1;
        private TextBox txtTotalDebit;
        private PictureBox picCloseEditProduct;
        private Label lblReturnDB;
        private Label label2;
        private Label label3;
    }
}