﻿using System;
using System.Windows.Forms;

namespace Componentes
{
    public partial class F_Principal : Form
    {
        //Construtor Principal
        public F_Principal()
        {
            InitializeComponent();


        }

        //Botão para adicionar 
        private void btn_adicionar_Click(object sender, EventArgs e)
        {

            if (tb_veiculo.Text == string.Empty)
            {
                MessageBox.Show("Digite um Veículo");
                tb_veiculo.Focus();
                return;
            }

            tb_lista_veiculos.Text += tb_veiculo.Text + System.Environment.NewLine.ToString(); //pular a linha inteira                                                                                                  
            tb_veiculo.Clear();
            tb_veiculo.Focus(); //onde o posicionandor de digitação irá ficar 



        }
        //Botão Limpar
        private void btn_clear_Click(object sender, EventArgs e)
        {
            tb_lista_veiculos.Clear();
            tb_veiculo.Clear();
            tb_veiculo.Focus();
        }

        //Botão mostrar 
        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            F_veiculos f_veiculos = new F_veiculos(tb_lista_veiculos.Text, this);
            f_veiculos.ShowDialog();
        }

        //Botões de atalho do teclado 
        public void F_Principal_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    btn_adicionar_Click(sender, e);
                    break;
            }
        }
        //CheckBox Menu 
        private void checkboxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Checkbox f_Checkbox = new F_Checkbox();
            f_Checkbox.ShowDialog();
        }
        //CheckBoxList Menu
        private void checkedListBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_CheckedListBox f_CheckedListBox = new F_CheckedListBox();
            f_CheckedListBox.ShowDialog();
        }
        //Combo Box Menu
        private void comboBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_ComboBox f_ComboBox = new F_ComboBox();
            f_ComboBox.ShowDialog();
        }

        //Date Time Menu
        private void dateTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_DateTimerPicker f_DateTimerPicker = new F_DateTimerPicker();
            f_DateTimerPicker.ShowDialog();
        }

        //LabelLink Menu
        private void labelLinkLabelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_LinkLabel f_LinkLabel = new F_LinkLabel();
            f_LinkLabel.ShowDialog();
        }

        //ListBox Menu

        private void listBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_ListBox f_ListBox = new F_ListBox();
            f_ListBox.ShowDialog();
        }

        private void listViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_ListView f_ListView = new F_ListView();
            f_ListView.ShowDialog();
        }

        private void sQLiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_sqlite f_Sqlite = new F_sqlite();
            f_Sqlite.ShowDialog();
        }
    }
}
