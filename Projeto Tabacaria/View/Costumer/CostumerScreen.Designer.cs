namespace Projeto_Tabacaria.View
{
    partial class CostumerScreen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CostumerScreen));
            this.btnDeleteClient = new Projeto_Tabacaria.Models.MNButton();
            this.btnEditClient = new Projeto_Tabacaria.Models.MNButton();
            this.btnCreateClient = new Projeto_Tabacaria.Models.MNButton();
            this.dgvCostumers = new System.Windows.Forms.DataGridView();
            this.pagamento = new System.Windows.Forms.DataGridViewImageColumn();
            this.RefreshDgvCostumer = new System.Windows.Forms.Timer(this.components);
            this.picCloseEditProduct = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCostumers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCloseEditProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteClient
            // 
            this.btnDeleteClient.BackColor = System.Drawing.Color.Teal;
            this.btnDeleteClient.BackgroundColor = System.Drawing.Color.Teal;
            this.btnDeleteClient.BorderColor = System.Drawing.Color.Black;
            this.btnDeleteClient.BorderRadius = 10;
            this.btnDeleteClient.BorderSize = 0;
            this.btnDeleteClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteClient.FlatAppearance.BorderSize = 0;
            this.btnDeleteClient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteClient.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteClient.ForeColor = System.Drawing.Color.White;
            this.btnDeleteClient.Image = global::Projeto_Tabacaria.Properties.Resources.lixeira_de_reciclagem;
            this.btnDeleteClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteClient.Location = new System.Drawing.Point(435, 28);
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.Size = new System.Drawing.Size(201, 51);
            this.btnDeleteClient.TabIndex = 19;
            this.btnDeleteClient.Text = "    Excluir";
            this.btnDeleteClient.TextColor = System.Drawing.Color.White;
            this.btnDeleteClient.UseVisualStyleBackColor = false;
            this.btnDeleteClient.Click += new System.EventHandler(this.btnDeleteClient_Click);
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
            this.btnEditClient.Location = new System.Drawing.Point(228, 28);
            this.btnEditClient.Name = "btnEditClient";
            this.btnEditClient.Size = new System.Drawing.Size(201, 51);
            this.btnEditClient.TabIndex = 18;
            this.btnEditClient.Text = "     Editar";
            this.btnEditClient.TextColor = System.Drawing.Color.White;
            this.btnEditClient.UseVisualStyleBackColor = false;
            this.btnEditClient.Click += new System.EventHandler(this.btnEditClient_Click);
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
            this.btnCreateClient.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCreateClient.ForeColor = System.Drawing.Color.White;
            this.btnCreateClient.Image = global::Projeto_Tabacaria.Properties.Resources.adicionar_usuario;
            this.btnCreateClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateClient.Location = new System.Drawing.Point(21, 28);
            this.btnCreateClient.Name = "btnCreateClient";
            this.btnCreateClient.Size = new System.Drawing.Size(201, 51);
            this.btnCreateClient.TabIndex = 17;
            this.btnCreateClient.Text = "    Cadastrar";
            this.btnCreateClient.TextColor = System.Drawing.Color.White;
            this.btnCreateClient.UseVisualStyleBackColor = false;
            this.btnCreateClient.Click += new System.EventHandler(this.btnCreateClient_Click);
            // 
            // dgvCostumers
            // 
            this.dgvCostumers.AllowUserToAddRows = false;
            this.dgvCostumers.AllowUserToDeleteRows = false;
            this.dgvCostumers.AllowUserToOrderColumns = true;
            this.dgvCostumers.AllowUserToResizeColumns = false;
            this.dgvCostumers.AllowUserToResizeRows = false;
            this.dgvCostumers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCostumers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.dgvCostumers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCostumers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCostumers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCostumers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCostumers.ColumnHeadersHeight = 30;
            this.dgvCostumers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCostumers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pagamento});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCostumers.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCostumers.EnableHeadersVisualStyles = false;
            this.dgvCostumers.GridColor = System.Drawing.Color.White;
            this.dgvCostumers.Location = new System.Drawing.Point(12, 120);
            this.dgvCostumers.Name = "dgvCostumers";
            this.dgvCostumers.ReadOnly = true;
            this.dgvCostumers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCostumers.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCostumers.RowHeadersVisible = false;
            this.dgvCostumers.RowHeadersWidth = 60;
            this.dgvCostumers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvCostumers.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCostumers.RowTemplate.Height = 25;
            this.dgvCostumers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCostumers.Size = new System.Drawing.Size(1070, 531);
            this.dgvCostumers.TabIndex = 20;
            this.dgvCostumers.TabStop = false;
            this.dgvCostumers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCostumers_CellContentClick);
            this.dgvCostumers.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvCostumers_CellFormatting);
            this.dgvCostumers.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCostumers_CellMouseEnter);
            // 
            // pagamento
            // 
            this.pagamento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.pagamento.HeaderText = "";
            this.pagamento.Image = global::Projeto_Tabacaria.Properties.Resources.bolsa_de_dinheiro__1_;
            this.pagamento.Name = "pagamento";
            this.pagamento.ReadOnly = true;
            this.pagamento.Width = 30;
            // 
            // RefreshDgvCostumer
            // 
            this.RefreshDgvCostumer.Tick += new System.EventHandler(this.RefreshDgvCostumer_Tick);
            // 
            // picCloseEditProduct
            // 
            this.picCloseEditProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCloseEditProduct.Image = global::Projeto_Tabacaria.Properties.Resources.refresh;
            this.picCloseEditProduct.Location = new System.Drawing.Point(648, 35);
            this.picCloseEditProduct.Name = "picCloseEditProduct";
            this.picCloseEditProduct.Size = new System.Drawing.Size(42, 38);
            this.picCloseEditProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCloseEditProduct.TabIndex = 51;
            this.picCloseEditProduct.TabStop = false;
            this.picCloseEditProduct.Click += new System.EventHandler(this.picCloseEditProduct_Click);
            // 
            // CostumerScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1094, 666);
            this.Controls.Add(this.picCloseEditProduct);
            this.Controls.Add(this.dgvCostumers);
            this.Controls.Add(this.btnDeleteClient);
            this.Controls.Add(this.btnEditClient);
            this.Controls.Add(this.btnCreateClient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CostumerScreen";
            this.Text = "Clients";
            this.Load += new System.EventHandler(this.Clients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCostumers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCloseEditProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Models.MNButton btnDeleteClient;
        private Models.MNButton btnEditClient;
        private Models.MNButton btnCreateClient;
        private DataGridView dgvCostumers;
        private DataGridViewImageColumn pagamento;
        private System.Windows.Forms.Timer RefreshDgvCostumer;
        private PictureBox picCloseEditProduct;
    }
}