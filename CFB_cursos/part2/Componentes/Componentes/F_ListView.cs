using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componentes
{
    public partial class F_ListView : Form
    {
        public F_ListView()
        {
            InitializeComponent();
        }

        //Função para limpar os TextBox
        private void limpar()
        {
            tb_id.Clear();
            tb_produto.Clear();
            tb_quantidade.Clear();
            tb_preco.Clear();
            tb_id.Focus();
        }

        private void Obter()
        {
            tb_id.Text = lv_products.SelectedItems[0].SubItems[0].Text;
            tb_produto.Text = lv_products.SelectedItems[0].SubItems[1].Text;
            tb_quantidade.Text = lv_products.SelectedItems[0].SubItems[2].Text;
            tb_preco.Text = lv_products.SelectedItems[0].SubItems[3].Text;
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            //criando um array de string 
            string[] pr = new string[4];

            //Verificando se o valor passado é vazio 
            
            if(tb_id.Text == "")
            {
                MessageBox.Show("ID não posso ser vazio ");
                tb_id.Focus();
                return;
            } 

            pr[0] = tb_id.Text;
            pr[1] = tb_produto.Text;
            pr[2] = tb_quantidade.Text;
            pr[3] = tb_preco.Text;


            //criando ListViewItem

            ListViewItem l = new ListViewItem(pr);
            lv_products.Items.Add(l);
            limpar();
        }

       //Remover Componentes 
       private void btn_remover_Click(object sender, EventArgs e)
        {
            lv_products.Items.RemoveAt(lv_products.SelectedIndices[0]);
            //RemoveAt irá me pedir a posição, como não é multi select, só vai haver um
        }

        // Obter componentes 
        private void btn_obter_Click(object sender, EventArgs e)
        {
            //TextBox está recebendo os itens selecionados, definidos por posições 

            Obter();
        }

        private void lv_products_SelectedIndexChanged(object sender, EventArgs e)
        {
            // se for maior que zero, então siginifica que tem item selecionado
            if(lv_products.SelectedItems.Count > 0)
            {
                Obter();
            }
        }
    }
}
