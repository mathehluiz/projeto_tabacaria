namespace Projeto_Tabacaria.View.Barcode
{
    partial class BarcodeScreen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnRegBarcode = new Projeto_Tabacaria.Models.MNButton();
            this.btnRegBarcodeCup = new Projeto_Tabacaria.Models.MNButton();
            this.dgvBarCodeProducts = new System.Windows.Forms.DataGridView();
            this.editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.excluir = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvBarCodeCups = new System.Windows.Forms.DataGridView();
            this.picRefresh = new System.Windows.Forms.PictureBox();
            this.lblSendGroupName = new System.Windows.Forms.Label();
            this.lblSendBarcodeProduct = new System.Windows.Forms.Label();
            this.lblSendNameProduct = new System.Windows.Forms.Label();
            this.editar1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.excluir1 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarCodeProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarCodeCups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRefresh)).BeginInit();
            this.SuspendLayout();
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
            this.btnRegBarcode.Location = new System.Drawing.Point(155, 12);
            this.btnRegBarcode.Name = "btnRegBarcode";
            this.btnRegBarcode.Size = new System.Drawing.Size(212, 51);
            this.btnRegBarcode.TabIndex = 50;
            this.btnRegBarcode.Text = "       Cadastrar Código";
            this.btnRegBarcode.TextColor = System.Drawing.Color.White;
            this.btnRegBarcode.UseVisualStyleBackColor = false;
            this.btnRegBarcode.Click += new System.EventHandler(this.btnRegBarcode_Click);
            // 
            // btnRegBarcodeCup
            // 
            this.btnRegBarcodeCup.BackColor = System.Drawing.Color.Teal;
            this.btnRegBarcodeCup.BackgroundColor = System.Drawing.Color.Teal;
            this.btnRegBarcodeCup.BorderColor = System.Drawing.Color.Teal;
            this.btnRegBarcodeCup.BorderRadius = 10;
            this.btnRegBarcodeCup.BorderSize = 0;
            this.btnRegBarcodeCup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegBarcodeCup.FlatAppearance.BorderSize = 0;
            this.btnRegBarcodeCup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegBarcodeCup.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegBarcodeCup.ForeColor = System.Drawing.Color.White;
            this.btnRegBarcodeCup.Image = global::Projeto_Tabacaria.Properties.Resources.copo_de_medicao;
            this.btnRegBarcodeCup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegBarcodeCup.Location = new System.Drawing.Point(684, 12);
            this.btnRegBarcodeCup.Name = "btnRegBarcodeCup";
            this.btnRegBarcodeCup.Size = new System.Drawing.Size(208, 51);
            this.btnRegBarcodeCup.TabIndex = 57;
            this.btnRegBarcodeCup.Text = "      Cadastrar Código";
            this.btnRegBarcodeCup.TextColor = System.Drawing.Color.White;
            this.btnRegBarcodeCup.UseVisualStyleBackColor = false;
            this.btnRegBarcodeCup.Click += new System.EventHandler(this.btnRegBarcodeCup_Click);
            // 
            // dgvBarCodeProducts
            // 
            this.dgvBarCodeProducts.AllowUserToAddRows = false;
            this.dgvBarCodeProducts.AllowUserToDeleteRows = false;
            this.dgvBarCodeProducts.AllowUserToOrderColumns = true;
            this.dgvBarCodeProducts.AllowUserToResizeColumns = false;
            this.dgvBarCodeProducts.AllowUserToResizeRows = false;
            this.dgvBarCodeProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBarCodeProducts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.dgvBarCodeProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBarCodeProducts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBarCodeProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBarCodeProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBarCodeProducts.ColumnHeadersHeight = 30;
            this.dgvBarCodeProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBarCodeProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.editar,
            this.excluir});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBarCodeProducts.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBarCodeProducts.EnableHeadersVisualStyles = false;
            this.dgvBarCodeProducts.GridColor = System.Drawing.Color.White;
            this.dgvBarCodeProducts.Location = new System.Drawing.Point(11, 70);
            this.dgvBarCodeProducts.Name = "dgvBarCodeProducts";
            this.dgvBarCodeProducts.ReadOnly = true;
            this.dgvBarCodeProducts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBarCodeProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBarCodeProducts.RowHeadersVisible = false;
            this.dgvBarCodeProducts.RowHeadersWidth = 60;
            this.dgvBarCodeProducts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvBarCodeProducts.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBarCodeProducts.RowTemplate.Height = 25;
            this.dgvBarCodeProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBarCodeProducts.Size = new System.Drawing.Size(483, 569);
            this.dgvBarCodeProducts.TabIndex = 58;
            this.dgvBarCodeProducts.TabStop = false;
            this.dgvBarCodeProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBarCodeProducts_CellContentClick);
            this.dgvBarCodeProducts.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvBarCodeProducts_CellFormatting);
            // 
            // editar
            // 
            this.editar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.editar.HeaderText = "";
            this.editar.Image = global::Projeto_Tabacaria.Properties.Resources.caneta_esferografica;
            this.editar.Name = "editar";
            this.editar.ReadOnly = true;
            this.editar.Width = 30;
            // 
            // excluir
            // 
            this.excluir.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.excluir.HeaderText = "";
            this.excluir.Image = global::Projeto_Tabacaria.Properties.Resources.cross;
            this.excluir.Name = "excluir";
            this.excluir.ReadOnly = true;
            this.excluir.Width = 30;
            // 
            // dgvBarCodeCups
            // 
            this.dgvBarCodeCups.AllowUserToAddRows = false;
            this.dgvBarCodeCups.AllowUserToDeleteRows = false;
            this.dgvBarCodeCups.AllowUserToOrderColumns = true;
            this.dgvBarCodeCups.AllowUserToResizeColumns = false;
            this.dgvBarCodeCups.AllowUserToResizeRows = false;
            this.dgvBarCodeCups.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBarCodeCups.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.dgvBarCodeCups.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBarCodeCups.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBarCodeCups.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBarCodeCups.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvBarCodeCups.ColumnHeadersHeight = 30;
            this.dgvBarCodeCups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBarCodeCups.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.editar1,
            this.excluir1});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBarCodeCups.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvBarCodeCups.EnableHeadersVisualStyles = false;
            this.dgvBarCodeCups.GridColor = System.Drawing.Color.White;
            this.dgvBarCodeCups.Location = new System.Drawing.Point(545, 70);
            this.dgvBarCodeCups.Name = "dgvBarCodeCups";
            this.dgvBarCodeCups.ReadOnly = true;
            this.dgvBarCodeCups.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBarCodeCups.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvBarCodeCups.RowHeadersVisible = false;
            this.dgvBarCodeCups.RowHeadersWidth = 60;
            this.dgvBarCodeCups.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.dgvBarCodeCups.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvBarCodeCups.RowTemplate.Height = 25;
            this.dgvBarCodeCups.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBarCodeCups.Size = new System.Drawing.Size(483, 569);
            this.dgvBarCodeCups.TabIndex = 59;
            this.dgvBarCodeCups.TabStop = false;
            this.dgvBarCodeCups.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBarCodeCups_CellContentClick);
            this.dgvBarCodeCups.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvBarCodeCups_CellFormatting);
            // 
            // picRefresh
            // 
            this.picRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRefresh.Image = global::Projeto_Tabacaria.Properties.Resources.refresh;
            this.picRefresh.Location = new System.Drawing.Point(499, 12);
            this.picRefresh.Name = "picRefresh";
            this.picRefresh.Size = new System.Drawing.Size(42, 38);
            this.picRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRefresh.TabIndex = 60;
            this.picRefresh.TabStop = false;
            this.picRefresh.Click += new System.EventHandler(this.picRefresh_Click);
            // 
            // lblSendGroupName
            // 
            this.lblSendGroupName.AutoSize = true;
            this.lblSendGroupName.Location = new System.Drawing.Point(12, 9);
            this.lblSendGroupName.Name = "lblSendGroupName";
            this.lblSendGroupName.Size = new System.Drawing.Size(98, 15);
            this.lblSendGroupName.TabIndex = 63;
            this.lblSendGroupName.Text = "SendGroupName";
            // 
            // lblSendBarcodeProduct
            // 
            this.lblSendBarcodeProduct.AutoSize = true;
            this.lblSendBarcodeProduct.Location = new System.Drawing.Point(12, 24);
            this.lblSendBarcodeProduct.Name = "lblSendBarcodeProduct";
            this.lblSendBarcodeProduct.Size = new System.Drawing.Size(106, 15);
            this.lblSendBarcodeProduct.TabIndex = 62;
            this.lblSendBarcodeProduct.Text = "SendBrandProduct";
            // 
            // lblSendNameProduct
            // 
            this.lblSendNameProduct.AutoSize = true;
            this.lblSendNameProduct.Location = new System.Drawing.Point(12, 39);
            this.lblSendNameProduct.Name = "lblSendNameProduct";
            this.lblSendNameProduct.Size = new System.Drawing.Size(107, 15);
            this.lblSendNameProduct.TabIndex = 61;
            this.lblSendNameProduct.Text = "SendNameProduct";
            // 
            // editar1
            // 
            this.editar1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.editar1.HeaderText = "";
            this.editar1.Image = global::Projeto_Tabacaria.Properties.Resources.caneta_esferografica;
            this.editar1.Name = "editar1";
            this.editar1.ReadOnly = true;
            this.editar1.Width = 30;
            // 
            // excluir1
            // 
            this.excluir1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.excluir1.HeaderText = "";
            this.excluir1.Image = global::Projeto_Tabacaria.Properties.Resources.cross;
            this.excluir1.Name = "excluir1";
            this.excluir1.ReadOnly = true;
            this.excluir1.Width = 30;
            // 
            // BarcodeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1078, 651);
            this.Controls.Add(this.lblSendGroupName);
            this.Controls.Add(this.lblSendBarcodeProduct);
            this.Controls.Add(this.lblSendNameProduct);
            this.Controls.Add(this.picRefresh);
            this.Controls.Add(this.dgvBarCodeCups);
            this.Controls.Add(this.dgvBarCodeProducts);
            this.Controls.Add(this.btnRegBarcodeCup);
            this.Controls.Add(this.btnRegBarcode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BarcodeScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BarcodeScreen";
            this.Load += new System.EventHandler(this.BarcodeScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarCodeProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarCodeCups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRefresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Models.MNButton btnRegBarcode;
        private Models.MNButton btnRegBarcodeCup;
        private DataGridView dgvBarCodeProducts;
        private DataGridView dgvBarCodeCups;
        private PictureBox picRefresh;
        private Label lblSendGroupName;
        private Label lblSendBarcodeProduct;
        private Label lblSendNameProduct;
        private DataGridViewImageColumn editar;
        private DataGridViewImageColumn excluir;
        private DataGridViewImageColumn editar1;
        private DataGridViewImageColumn excluir1;
    }
}