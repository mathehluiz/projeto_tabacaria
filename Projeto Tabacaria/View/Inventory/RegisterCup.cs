﻿using MySql.Data.MySqlClient;
using Projeto_Tabacaria.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Tabacaria.View.Inventory
{
    public partial class RegisterCup : Form
    {
        DBConnections dbConnections = new();
        public RegisterCup()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void RegisterCup_Load(object sender, EventArgs e)
        {
            lblReturnDB.Visible = false;
            dbConnections.OpenConnection();
            string cmd_sale_products = "select prod_nome from tb_produtos";
            MySqlDataAdapter da_products = new MySqlDataAdapter(cmd_sale_products, dbConnections.connection);
            DataSet ds_products = new DataSet();
            da_products.Fill(ds_products, "tb_produtos");
            this.cmbProduct.DisplayMember = "prod_nome";
            this.cmbProduct.ValueMember = "prod_cod";
            this.cmbProduct.DataSource = ds_products.Tables["tb_produtos"];
            dbConnections.CloseConnection();
        }

        private void butRegisterProduct_Click(object sender, EventArgs e)
        {
            decimal valueCup = Convert.ToDecimal(txtValueCup.Text.Replace(",", "."));

            dbConnections.OpenConnection();
            string strCup = "INSERT into tb_unidade(unidade_nome, unidade_quantidade,unidade_valor, prod_nome) values('" + txtCupName.Text + "', '" + txtQtd.Text + "', '"+ valueCup+"','" + cmbProduct.Text + "')";
            MySqlCommand cmd = new MySqlCommand(strCup, dbConnections.connection);
            cmd.ExecuteNonQuery();
            dbConnections.CloseConnection();
            lblReturnDB.Visible = true;
            lblReturnDB.Text = "Copo adicionado";

            txtCupName.Text = "";
            txtQtd.Text = "0";
            txtValueCup.Text = "0";
            cmbProduct.Text = "Selecione o Produto";
        }
    }
}
