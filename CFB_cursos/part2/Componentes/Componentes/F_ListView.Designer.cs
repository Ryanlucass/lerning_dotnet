﻿
namespace Componentes
{
    partial class F_ListView
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "0",
            "Mouse",
            "45",
            "55,00"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "Teclado",
            "50",
            "200,00"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "2",
            "Monitor ",
            "100",
            "550,00"}, -1);
            this.lv_products = new System.Windows.Forms.ListView();
            this.col_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_produto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_qtde = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_preco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_produto = new System.Windows.Forms.TextBox();
            this.tb_quantidade = new System.Windows.Forms.TextBox();
            this.tb_preco = new System.Windows.Forms.TextBox();
            this.lb_id = new System.Windows.Forms.Label();
            this.lb_produto = new System.Windows.Forms.Label();
            this.lb_quantidade = new System.Windows.Forms.Label();
            this.lb_preco = new System.Windows.Forms.Label();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.btn_remover = new System.Windows.Forms.Button();
            this.btn_obter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lv_products
            // 
            this.lv_products.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_id,
            this.col_produto,
            this.col_qtde,
            this.col_preco});
            this.lv_products.FullRowSelect = true;
            this.lv_products.HideSelection = false;
            this.lv_products.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.lv_products.Location = new System.Drawing.Point(12, 12);
            this.lv_products.MultiSelect = false;
            this.lv_products.Name = "lv_products";
            this.lv_products.Size = new System.Drawing.Size(731, 122);
            this.lv_products.TabIndex = 0;
            this.lv_products.UseCompatibleStateImageBehavior = false;
            this.lv_products.View = System.Windows.Forms.View.Details;
            this.lv_products.SelectedIndexChanged += new System.EventHandler(this.lv_products_SelectedIndexChanged);
            // 
            // col_id
            // 
            this.col_id.Text = "ID";
            this.col_id.Width = 76;
            // 
            // col_produto
            // 
            this.col_produto.Text = "Produto";
            this.col_produto.Width = 317;
            // 
            // col_qtde
            // 
            this.col_qtde.Text = "Quantidade ";
            this.col_qtde.Width = 88;
            // 
            // col_preco
            // 
            this.col_preco.Text = "Preço";
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(12, 160);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(60, 22);
            this.tb_id.TabIndex = 1;
            // 
            // tb_produto
            // 
            this.tb_produto.Location = new System.Drawing.Point(92, 160);
            this.tb_produto.Name = "tb_produto";
            this.tb_produto.Size = new System.Drawing.Size(309, 22);
            this.tb_produto.TabIndex = 2;
            // 
            // tb_quantidade
            // 
            this.tb_quantidade.Location = new System.Drawing.Point(407, 160);
            this.tb_quantidade.Name = "tb_quantidade";
            this.tb_quantidade.Size = new System.Drawing.Size(89, 22);
            this.tb_quantidade.TabIndex = 3;
            // 
            // tb_preco
            // 
            this.tb_preco.Location = new System.Drawing.Point(503, 160);
            this.tb_preco.Name = "tb_preco";
            this.tb_preco.Size = new System.Drawing.Size(90, 22);
            this.tb_preco.TabIndex = 4;
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Location = new System.Drawing.Point(13, 137);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(25, 17);
            this.lb_id.TabIndex = 5;
            this.lb_id.Text = "ID ";
            // 
            // lb_produto
            // 
            this.lb_produto.AutoSize = true;
            this.lb_produto.Location = new System.Drawing.Point(103, 137);
            this.lb_produto.Name = "lb_produto";
            this.lb_produto.Size = new System.Drawing.Size(58, 17);
            this.lb_produto.TabIndex = 6;
            this.lb_produto.Text = "Produto";
            // 
            // lb_quantidade
            // 
            this.lb_quantidade.AutoSize = true;
            this.lb_quantidade.Location = new System.Drawing.Point(407, 136);
            this.lb_quantidade.Name = "lb_quantidade";
            this.lb_quantidade.Size = new System.Drawing.Size(86, 17);
            this.lb_quantidade.TabIndex = 7;
            this.lb_quantidade.Text = "Quantidade ";
            // 
            // lb_preco
            // 
            this.lb_preco.AutoSize = true;
            this.lb_preco.Location = new System.Drawing.Point(503, 136);
            this.lb_preco.Name = "lb_preco";
            this.lb_preco.Size = new System.Drawing.Size(45, 17);
            this.lb_preco.TabIndex = 8;
            this.lb_preco.Text = "Preço";
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Location = new System.Drawing.Point(12, 201);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(183, 23);
            this.btn_adicionar.TabIndex = 9;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // btn_remover
            // 
            this.btn_remover.Location = new System.Drawing.Point(201, 201);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(200, 23);
            this.btn_remover.TabIndex = 10;
            this.btn_remover.Text = "Remover";
            this.btn_remover.UseVisualStyleBackColor = true;
            this.btn_remover.Click += new System.EventHandler(this.btn_remover_Click);
            // 
            // btn_obter
            // 
            this.btn_obter.Location = new System.Drawing.Point(410, 201);
            this.btn_obter.Name = "btn_obter";
            this.btn_obter.Size = new System.Drawing.Size(183, 23);
            this.btn_obter.TabIndex = 11;
            this.btn_obter.Text = "Obter";
            this.btn_obter.UseVisualStyleBackColor = true;
            this.btn_obter.Click += new System.EventHandler(this.btn_obter_Click);
            // 
            // F_ListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 237);
            this.Controls.Add(this.btn_obter);
            this.Controls.Add(this.btn_remover);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.lb_preco);
            this.Controls.Add(this.lb_quantidade);
            this.Controls.Add(this.lb_produto);
            this.Controls.Add(this.lb_id);
            this.Controls.Add(this.tb_preco);
            this.Controls.Add(this.tb_quantidade);
            this.Controls.Add(this.tb_produto);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.lv_products);
            this.MaximizeBox = false;
            this.Name = "F_ListView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_ListView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_products;
        private System.Windows.Forms.ColumnHeader col_id;
        private System.Windows.Forms.ColumnHeader col_produto;
        private System.Windows.Forms.ColumnHeader col_qtde;
        private System.Windows.Forms.ColumnHeader col_preco;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_produto;
        private System.Windows.Forms.TextBox tb_quantidade;
        private System.Windows.Forms.TextBox tb_preco;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.Label lb_produto;
        private System.Windows.Forms.Label lb_quantidade;
        private System.Windows.Forms.Label lb_preco;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.Button btn_obter;
    }
}