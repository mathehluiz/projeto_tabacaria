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
            this.btnRegBarcode = new Projeto_Tabacaria.Models.MNButton();
            this.btnRegBarcodeCup = new Projeto_Tabacaria.Models.MNButton();
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
            this.btnRegBarcode.Location = new System.Drawing.Point(12, 12);
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
            this.btnRegBarcodeCup.Location = new System.Drawing.Point(244, 12);
            this.btnRegBarcodeCup.Name = "btnRegBarcodeCup";
            this.btnRegBarcodeCup.Size = new System.Drawing.Size(208, 51);
            this.btnRegBarcodeCup.TabIndex = 57;
            this.btnRegBarcodeCup.Text = "      Cadastrar Código";
            this.btnRegBarcodeCup.TextColor = System.Drawing.Color.White;
            this.btnRegBarcodeCup.UseVisualStyleBackColor = false;
            this.btnRegBarcodeCup.Click += new System.EventHandler(this.btnRegBarcodeCup_Click);
            // 
            // BarcodeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1078, 651);
            this.Controls.Add(this.btnRegBarcodeCup);
            this.Controls.Add(this.btnRegBarcode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BarcodeScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BarcodeScreen";
            this.ResumeLayout(false);

        }

        #endregion

        private Models.MNButton btnRegBarcode;
        private Models.MNButton btnRegBarcodeCup;
    }
}