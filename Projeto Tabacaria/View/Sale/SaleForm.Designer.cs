﻿namespace Projeto_Tabacaria.View
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.picSearchIcon_Sale = new System.Windows.Forms.PictureBox();
            this.btnDeleteItem = new Projeto_Tabacaria.Models.MNButton();
            this.btnEndSale = new Projeto_Tabacaria.Models.MNButton();
            this.cmbSaleProduct = new System.Windows.Forms.ComboBox();
            this.PRODUTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUANTIDADE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tamanho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor_unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.txtTotalValue = new CustomControls.RJControls.RJTextBox();
            this.txtDiscount = new CustomControls.RJControls.RJTextBox();
            this.txtSubtotal = new CustomControls.RJControls.RJTextBox();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbCostumer = new System.Windows.Forms.ComboBox();
            this.lblCostumer = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.btnNewSale = new Projeto_Tabacaria.Models.MNButton();
            this.btnCancelSale = new Projeto_Tabacaria.Models.MNButton();
            this.lblReturnDB = new System.Windows.Forms.Label();
            this.lblReturnQuantity = new System.Windows.Forms.Label();
            this.cmbCups = new System.Windows.Forms.ComboBox();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.txtBarCode = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picSearchIcon_Sale)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // picSearchIcon_Sale
            // 
            this.picSearchIcon_Sale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.picSearchIcon_Sale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSearchIcon_Sale.Image = global::Projeto_Tabacaria.Properties.Resources.adicionar_a_cesta;
            this.picSearchIcon_Sale.Location = new System.Drawing.Point(796, 61);
            this.picSearchIcon_Sale.Name = "picSearchIcon_Sale";
            this.picSearchIcon_Sale.Size = new System.Drawing.Size(32, 29);
            this.picSearchIcon_Sale.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSearchIcon_Sale.TabIndex = 14;
            this.picSearchIcon_Sale.TabStop = false;
            this.picSearchIcon_Sale.Click += new System.EventHandler(this.picSearchIcon_Sale_Click);
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.BackColor = System.Drawing.Color.Red;
            this.btnDeleteItem.BackgroundColor = System.Drawing.Color.Red;
            this.btnDeleteItem.BorderColor = System.Drawing.Color.White;
            this.btnDeleteItem.BorderRadius = 20;
            this.btnDeleteItem.BorderSize = 0;
            this.btnDeleteItem.FlatAppearance.BorderSize = 0;
            this.btnDeleteItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteItem.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteItem.ForeColor = System.Drawing.Color.White;
            this.btnDeleteItem.Location = new System.Drawing.Point(720, 629);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(170, 49);
            this.btnDeleteItem.TabIndex = 17;
            this.btnDeleteItem.Text = "Excluir Item";
            this.btnDeleteItem.TextColor = System.Drawing.Color.White;
            this.btnDeleteItem.UseVisualStyleBackColor = false;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // btnEndSale
            // 
            this.btnEndSale.BackColor = System.Drawing.Color.Teal;
            this.btnEndSale.BackgroundColor = System.Drawing.Color.Teal;
            this.btnEndSale.BorderColor = System.Drawing.Color.Teal;
            this.btnEndSale.BorderRadius = 20;
            this.btnEndSale.BorderSize = 0;
            this.btnEndSale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEndSale.FlatAppearance.BorderSize = 0;
            this.btnEndSale.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEndSale.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEndSale.ForeColor = System.Drawing.Color.White;
            this.btnEndSale.Location = new System.Drawing.Point(896, 629);
            this.btnEndSale.Name = "btnEndSale";
            this.btnEndSale.Size = new System.Drawing.Size(170, 49);
            this.btnEndSale.TabIndex = 18;
            this.btnEndSale.Text = "Finalizar Venda";
            this.btnEndSale.TextColor = System.Drawing.Color.White;
            this.btnEndSale.UseVisualStyleBackColor = false;
            this.btnEndSale.Click += new System.EventHandler(this.btnEndSale_Click);
            // 
            // cmbSaleProduct
            // 
            this.cmbSaleProduct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbSaleProduct.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSaleProduct.BackColor = System.Drawing.Color.White;
            this.cmbSaleProduct.FormattingEnabled = true;
            this.cmbSaleProduct.Location = new System.Drawing.Point(97, 63);
            this.cmbSaleProduct.Name = "cmbSaleProduct";
            this.cmbSaleProduct.Size = new System.Drawing.Size(136, 23);
            this.cmbSaleProduct.TabIndex = 19;
            this.cmbSaleProduct.TabStop = false;
            this.cmbSaleProduct.Text = "Selecione um Produto";
            this.cmbSaleProduct.SelectedIndexChanged += new System.EventHandler(this.cmbSaleProduct_SelectedIndexChanged);
            // 
            // PRODUTO
            // 
            this.PRODUTO.HeaderText = "PRODUTO";
            this.PRODUTO.Name = "PRODUTO";
            this.PRODUTO.ReadOnly = true;
            // 
            // QUANTIDADE
            // 
            this.QUANTIDADE.HeaderText = "QUANTIDADE";
            this.QUANTIDADE.Name = "QUANTIDADE";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "PRODUTO";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "QUANTIDADE";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvProducts);
            this.panel1.Location = new System.Drawing.Point(25, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1057, 470);
            this.panel1.TabIndex = 20;
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AllowUserToOrderColumns = true;
            this.dgvProducts.AllowUserToResizeColumns = false;
            this.dgvProducts.AllowUserToResizeRows = false;
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.dgvProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProducts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProducts.ColumnHeadersHeight = 30;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.Tamanho,
            this.Valor_unitario,
            this.Subtotal});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProducts.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProducts.EnableHeadersVisualStyles = false;
            this.dgvProducts.GridColor = System.Drawing.Color.White;
            this.dgvProducts.Location = new System.Drawing.Point(0, 3);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.RowHeadersWidth = 60;
            this.dgvProducts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvProducts.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProducts.RowTemplate.Height = 25;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(1057, 510);
            this.dgvProducts.TabIndex = 1;
            this.dgvProducts.TabStop = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Produto";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Quantidade";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // Tamanho
            // 
            this.Tamanho.HeaderText = "Tamanho";
            this.Tamanho.Name = "Tamanho";
            this.Tamanho.ReadOnly = true;
            // 
            // Valor_unitario
            // 
            this.Valor_unitario.HeaderText = "Valor_unitario";
            this.Valor_unitario.Name = "Valor_unitario";
            this.Valor_unitario.ReadOnly = true;
            // 
            // Subtotal
            // 
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.AutoSize = true;
            this.lblTotalValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalValue.ForeColor = System.Drawing.Color.White;
            this.lblTotalValue.Location = new System.Drawing.Point(399, 636);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(95, 21);
            this.lblTotalValue.TabIndex = 27;
            this.lblTotalValue.Text = "Valor Final:";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDiscount.ForeColor = System.Drawing.Color.White;
            this.lblDiscount.Location = new System.Drawing.Point(215, 634);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(86, 21);
            this.lblDiscount.TabIndex = 26;
            this.lblDiscount.Text = "Desconto:";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSubtotal.ForeColor = System.Drawing.Color.White;
            this.lblSubtotal.Location = new System.Drawing.Point(18, 634);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(79, 21);
            this.lblSubtotal.TabIndex = 25;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // txtTotalValue
            // 
            this.txtTotalValue.BackColor = System.Drawing.Color.White;
            this.txtTotalValue.BorderColor = System.Drawing.Color.White;
            this.txtTotalValue.BorderFocusColor = System.Drawing.Color.White;
            this.txtTotalValue.BorderRadius = 10;
            this.txtTotalValue.BorderSize = 2;
            this.txtTotalValue.Enabled = false;
            this.txtTotalValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTotalValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTotalValue.Location = new System.Drawing.Point(492, 629);
            this.txtTotalValue.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalValue.Multiline = false;
            this.txtTotalValue.Name = "txtTotalValue";
            this.txtTotalValue.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTotalValue.PasswordChar = false;
            this.txtTotalValue.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTotalValue.PlaceholderText = "";
            this.txtTotalValue.Size = new System.Drawing.Size(170, 31);
            this.txtTotalValue.TabIndex = 24;
            this.txtTotalValue.TabStop = false;
            this.txtTotalValue.Texts = "";
            this.txtTotalValue.UnderlinedStyle = false;
            // 
            // txtDiscount
            // 
            this.txtDiscount.BackColor = System.Drawing.Color.White;
            this.txtDiscount.BorderColor = System.Drawing.Color.White;
            this.txtDiscount.BorderFocusColor = System.Drawing.Color.White;
            this.txtDiscount.BorderRadius = 10;
            this.txtDiscount.BorderSize = 2;
            this.txtDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDiscount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDiscount.Location = new System.Drawing.Point(300, 629);
            this.txtDiscount.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiscount.Multiline = false;
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDiscount.PasswordChar = false;
            this.txtDiscount.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDiscount.PlaceholderText = "";
            this.txtDiscount.Size = new System.Drawing.Size(92, 31);
            this.txtDiscount.TabIndex = 23;
            this.txtDiscount.TabStop = false;
            this.txtDiscount.Texts = "";
            this.txtDiscount.UnderlinedStyle = false;
            this.txtDiscount._TextChanged += new System.EventHandler(this.txtDiscount__TextChanged);
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.BackColor = System.Drawing.Color.White;
            this.txtSubtotal.BorderColor = System.Drawing.Color.White;
            this.txtSubtotal.BorderFocusColor = System.Drawing.Color.White;
            this.txtSubtotal.BorderRadius = 10;
            this.txtSubtotal.BorderSize = 2;
            this.txtSubtotal.Enabled = false;
            this.txtSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSubtotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSubtotal.Location = new System.Drawing.Point(97, 629);
            this.txtSubtotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubtotal.Multiline = false;
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSubtotal.PasswordChar = false;
            this.txtSubtotal.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSubtotal.PlaceholderText = "";
            this.txtSubtotal.Size = new System.Drawing.Size(97, 31);
            this.txtSubtotal.TabIndex = 22;
            this.txtSubtotal.TabStop = false;
            this.txtSubtotal.Texts = "";
            this.txtSubtotal.UnderlinedStyle = false;
            this.txtSubtotal._TextChanged += new System.EventHandler(this.txtSubtotal__TextChanged);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Produtos";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 529;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Produto";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 1057;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Quantidade";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // cmbCostumer
            // 
            this.cmbCostumer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCostumer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCostumer.BackColor = System.Drawing.Color.White;
            this.cmbCostumer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCostumer.FormattingEnabled = true;
            this.cmbCostumer.Location = new System.Drawing.Point(663, 64);
            this.cmbCostumer.Name = "cmbCostumer";
            this.cmbCostumer.Size = new System.Drawing.Size(124, 23);
            this.cmbCostumer.TabIndex = 23;
            this.cmbCostumer.TabStop = false;
            // 
            // lblCostumer
            // 
            this.lblCostumer.AutoSize = true;
            this.lblCostumer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCostumer.ForeColor = System.Drawing.Color.White;
            this.lblCostumer.Location = new System.Drawing.Point(598, 65);
            this.lblCostumer.Name = "lblCostumer";
            this.lblCostumer.Size = new System.Drawing.Size(64, 21);
            this.lblCostumer.TabIndex = 24;
            this.lblCostumer.Text = "Cliente";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProduct.ForeColor = System.Drawing.Color.White;
            this.lblProduct.Location = new System.Drawing.Point(25, 63);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(72, 21);
            this.lblProduct.TabIndex = 25;
            this.lblProduct.Text = "Produto";
            // 
            // btnNewSale
            // 
            this.btnNewSale.BackColor = System.Drawing.Color.Teal;
            this.btnNewSale.BackgroundColor = System.Drawing.Color.Teal;
            this.btnNewSale.BorderColor = System.Drawing.Color.Teal;
            this.btnNewSale.BorderRadius = 10;
            this.btnNewSale.BorderSize = 0;
            this.btnNewSale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewSale.FlatAppearance.BorderSize = 0;
            this.btnNewSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewSale.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNewSale.ForeColor = System.Drawing.Color.White;
            this.btnNewSale.Location = new System.Drawing.Point(850, 57);
            this.btnNewSale.Name = "btnNewSale";
            this.btnNewSale.Size = new System.Drawing.Size(113, 40);
            this.btnNewSale.TabIndex = 26;
            this.btnNewSale.Text = "Nova Venda";
            this.btnNewSale.TextColor = System.Drawing.Color.White;
            this.btnNewSale.UseVisualStyleBackColor = false;
            this.btnNewSale.Click += new System.EventHandler(this.btnNewSale_Click);
            // 
            // btnCancelSale
            // 
            this.btnCancelSale.BackColor = System.Drawing.Color.Teal;
            this.btnCancelSale.BackgroundColor = System.Drawing.Color.Teal;
            this.btnCancelSale.BorderColor = System.Drawing.Color.Teal;
            this.btnCancelSale.BorderRadius = 10;
            this.btnCancelSale.BorderSize = 0;
            this.btnCancelSale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelSale.FlatAppearance.BorderSize = 0;
            this.btnCancelSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelSale.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelSale.ForeColor = System.Drawing.Color.White;
            this.btnCancelSale.Location = new System.Drawing.Point(969, 57);
            this.btnCancelSale.Name = "btnCancelSale";
            this.btnCancelSale.Size = new System.Drawing.Size(113, 40);
            this.btnCancelSale.TabIndex = 27;
            this.btnCancelSale.Text = "Cancelar Venda";
            this.btnCancelSale.TextColor = System.Drawing.Color.White;
            this.btnCancelSale.UseVisualStyleBackColor = false;
            this.btnCancelSale.Click += new System.EventHandler(this.btnCancelSale_Click);
            // 
            // lblReturnDB
            // 
            this.lblReturnDB.AutoSize = true;
            this.lblReturnDB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReturnDB.ForeColor = System.Drawing.SystemColors.Control;
            this.lblReturnDB.Location = new System.Drawing.Point(383, 9);
            this.lblReturnDB.Name = "lblReturnDB";
            this.lblReturnDB.Size = new System.Drawing.Size(93, 19);
            this.lblReturnDB.TabIndex = 29;
            this.lblReturnDB.Text = "Return DB";
            // 
            // lblReturnQuantity
            // 
            this.lblReturnQuantity.AutoSize = true;
            this.lblReturnQuantity.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReturnQuantity.ForeColor = System.Drawing.SystemColors.Control;
            this.lblReturnQuantity.Location = new System.Drawing.Point(383, 38);
            this.lblReturnQuantity.Name = "lblReturnQuantity";
            this.lblReturnQuantity.Size = new System.Drawing.Size(99, 19);
            this.lblReturnQuantity.TabIndex = 30;
            this.lblReturnQuantity.Text = "Return Qtd";
            // 
            // cmbCups
            // 
            this.cmbCups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCups.Enabled = false;
            this.cmbCups.FormattingEnabled = true;
            this.cmbCups.Location = new System.Drawing.Point(330, 63);
            this.cmbCups.Name = "cmbCups";
            this.cmbCups.Size = new System.Drawing.Size(90, 23);
            this.cmbCups.TabIndex = 31;
            // 
            // txtQtd
            // 
            this.txtQtd.Location = new System.Drawing.Point(239, 63);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.PlaceholderText = "Quantidade";
            this.txtQtd.Size = new System.Drawing.Size(85, 23);
            this.txtQtd.TabIndex = 32;
            this.txtQtd.TabStop = false;
            // 
            // txtBarCode
            // 
            this.txtBarCode.Location = new System.Drawing.Point(426, 63);
            this.txtBarCode.Name = "txtBarCode";
            this.txtBarCode.PlaceholderText = "Codigo de Barras";
            this.txtBarCode.Size = new System.Drawing.Size(146, 23);
            this.txtBarCode.TabIndex = 33;
            this.txtBarCode.TabStop = false;
            this.txtBarCode.Visible = false;
            this.txtBarCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarCode_KeyPress);
            // 
            // SaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1094, 690);
            this.Controls.Add(this.txtBarCode);
            this.Controls.Add(this.txtQtd);
            this.Controls.Add(this.cmbCups);
            this.Controls.Add(this.lblReturnQuantity);
            this.Controls.Add(this.lblReturnDB);
            this.Controls.Add(this.lblTotalValue);
            this.Controls.Add(this.txtTotalValue);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.btnCancelSale);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.btnNewSale);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.lblCostumer);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.cmbCostumer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmbSaleProduct);
            this.Controls.Add(this.btnDeleteItem);
            this.Controls.Add(this.btnEndSale);
            this.Controls.Add(this.picSearchIcon_Sale);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SaleForm";
            this.Text = "SaleForm";
            this.Load += new System.EventHandler(this.SaleForm_Load);
            this.Leave += new System.EventHandler(this.SaleForm_Leave_1);
            ((System.ComponentModel.ISupportInitialize)(this.picSearchIcon_Sale)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox picSearchIcon_Sale;
        private Models.MNButton btnDeleteItem;
        private Models.MNButton btnEndSale;
        private ComboBox cmbSaleProduct;
        private DataGridViewTextBoxColumn PRODUTO;
        private DataGridViewTextBoxColumn QUANTIDADE;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private Panel panel1;
        private DataGridView dgvProducts;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private CustomControls.RJControls.RJTextBox txtTotalValue;
        private CustomControls.RJControls.RJTextBox txtDiscount;
        private CustomControls.RJControls.RJTextBox txtSubtotal;
        private Label lblTotalValue;
        private Label lblDiscount;
        private Label lblSubtotal;
        private ComboBox cmbCostumer;
        private Label lblCostumer;
        private Label lblProduct;
        private Models.MNButton btnNewSale;
        private Models.MNButton btnCancelSale;
        private Label lblReturnDB;
        private Label lblReturnQuantity;
        private ComboBox cmbCups;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn Tamanho;
        private DataGridViewTextBoxColumn Valor_unitario;
        private DataGridViewTextBoxColumn Subtotal;
        private TextBox txtQtd;
        private TextBox txtBarCode;
    }
}