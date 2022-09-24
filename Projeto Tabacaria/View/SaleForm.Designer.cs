namespace Projeto_Tabacaria.View
{
    partial class SaleForm
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
            this.txtSaleSearch = new CustomControls.RJControls.RJTextBox();
            this.picSearchIcon_Sale = new System.Windows.Forms.PictureBox();
            this.rjTextBox1 = new CustomControls.RJControls.RJTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDeleteItem = new Projeto_Tabacaria.Models.MNButton();
            this.btnEndSale = new Projeto_Tabacaria.Models.MNButton();
            ((System.ComponentModel.ISupportInitialize)(this.picSearchIcon_Sale)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSaleSearch
            // 
            this.txtSaleSearch.BackColor = System.Drawing.SystemColors.Window;
            this.txtSaleSearch.BorderColor = System.Drawing.Color.White;
            this.txtSaleSearch.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(204)))), ((int)(((byte)(55)))));
            this.txtSaleSearch.BorderRadius = 10;
            this.txtSaleSearch.BorderSize = 2;
            this.txtSaleSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSaleSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSaleSearch.Location = new System.Drawing.Point(13, 13);
            this.txtSaleSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSaleSearch.Multiline = false;
            this.txtSaleSearch.Name = "txtSaleSearch";
            this.txtSaleSearch.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSaleSearch.PasswordChar = false;
            this.txtSaleSearch.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtSaleSearch.PlaceholderText = "              Digite um item para incluir";
            this.txtSaleSearch.Size = new System.Drawing.Size(250, 31);
            this.txtSaleSearch.TabIndex = 0;
            this.txtSaleSearch.TabStop = false;
            this.txtSaleSearch.Texts = "";
            this.txtSaleSearch.UnderlinedStyle = false;
            // 
            // picSearchIcon_Sale
            // 
            this.picSearchIcon_Sale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.picSearchIcon_Sale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSearchIcon_Sale.Image = global::Projeto_Tabacaria.Properties.Resources.SearchIcon;
            this.picSearchIcon_Sale.Location = new System.Drawing.Point(270, 15);
            this.picSearchIcon_Sale.Name = "picSearchIcon_Sale";
            this.picSearchIcon_Sale.Size = new System.Drawing.Size(32, 29);
            this.picSearchIcon_Sale.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSearchIcon_Sale.TabIndex = 14;
            this.picSearchIcon_Sale.TabStop = false;
            // 
            // rjTextBox1
            // 
            this.rjTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox1.BorderColor = System.Drawing.Color.White;
            this.rjTextBox1.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(204)))), ((int)(((byte)(55)))));
            this.rjTextBox1.BorderRadius = 10;
            this.rjTextBox1.BorderSize = 2;
            this.rjTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rjTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox1.Location = new System.Drawing.Point(377, 13);
            this.rjTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox1.Multiline = false;
            this.rjTextBox1.Name = "rjTextBox1";
            this.rjTextBox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox1.PasswordChar = false;
            this.rjTextBox1.PlaceholderColor = System.Drawing.Color.Gray;
            this.rjTextBox1.PlaceholderText = "                                              CÓDIGO DE BARRAS";
            this.rjTextBox1.Size = new System.Drawing.Size(406, 31);
            this.rjTextBox1.TabIndex = 15;
            this.rjTextBox1.TabStop = false;
            this.rjTextBox1.Texts = "";
            this.rjTextBox1.UnderlinedStyle = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(22)))), ((int)(((byte)(9)))));
            this.panel1.Location = new System.Drawing.Point(25, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1041, 546);
            this.panel1.TabIndex = 16;
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.BackColor = System.Drawing.Color.Red;
            this.btnDeleteItem.BackgroundColor = System.Drawing.Color.Red;
            this.btnDeleteItem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(204)))), ((int)(((byte)(55)))));
            this.btnDeleteItem.BorderRadius = 20;
            this.btnDeleteItem.BorderSize = 0;
            this.btnDeleteItem.FlatAppearance.BorderSize = 0;
            this.btnDeleteItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteItem.Font = new System.Drawing.Font("Ink Free", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteItem.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteItem.Location = new System.Drawing.Point(720, 629);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(170, 49);
            this.btnDeleteItem.TabIndex = 17;
            this.btnDeleteItem.Text = "Excluir Item";
            this.btnDeleteItem.TextColor = System.Drawing.Color.Black;
            this.btnDeleteItem.UseVisualStyleBackColor = false;
            // 
            // btnEndSale
            // 
            this.btnEndSale.BackColor = System.Drawing.Color.Green;
            this.btnEndSale.BackgroundColor = System.Drawing.Color.Green;
            this.btnEndSale.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(204)))), ((int)(((byte)(55)))));
            this.btnEndSale.BorderRadius = 20;
            this.btnEndSale.BorderSize = 0;
            this.btnEndSale.FlatAppearance.BorderSize = 0;
            this.btnEndSale.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEndSale.Font = new System.Drawing.Font("Ink Free", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEndSale.ForeColor = System.Drawing.Color.Black;
            this.btnEndSale.Location = new System.Drawing.Point(896, 629);
            this.btnEndSale.Name = "btnEndSale";
            this.btnEndSale.Size = new System.Drawing.Size(170, 49);
            this.btnEndSale.TabIndex = 18;
            this.btnEndSale.Text = "Finalizar Venda";
            this.btnEndSale.TextColor = System.Drawing.Color.Black;
            this.btnEndSale.UseVisualStyleBackColor = false;
            // 
            // SaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1094, 690);
            this.Controls.Add(this.btnDeleteItem);
            this.Controls.Add(this.btnEndSale);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rjTextBox1);
            this.Controls.Add(this.picSearchIcon_Sale);
            this.Controls.Add(this.txtSaleSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SaleForm";
            this.Text = "SaleForm";
            ((System.ComponentModel.ISupportInitialize)(this.picSearchIcon_Sale)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.RJControls.RJTextBox txtSaleSearch;
        private PictureBox picSearchIcon_Sale;
        private CustomControls.RJControls.RJTextBox rjTextBox1;
        private Panel panel1;
        private Models.MNButton btnDeleteItem;
        private Models.MNButton btnEndSale;
    }
}