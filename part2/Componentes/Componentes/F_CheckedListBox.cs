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
    public partial class F_CheckedListBox : Form
    {
        public F_CheckedListBox()
        {
            InitializeComponent();
        }
        //Mostrando os ítens selecionados do ChecketBox 
        private void btn_mostrar_selecionados_Click(object sender, EventArgs e)
        {
            string txt = "";    //iniciando uma variável com nada para relacionar esse valor futuramente 


            //ciclo para percorrer a coleção "CheckedItems"
            foreach (string t in clb_transportes.CheckedItems)
            {
                txt += t + ", ";
            }


            MessageBox.Show(txt);

        }


        //Limpando o Checketbox 
        private void btn_limpar_Click(object sender, EventArgs e)
        {
            clb_transportes.Items.Clear();
        }

        //Resetando a lista e adicionando novamente as memsmas caixas 
        private void btn_resetar_lista_Click(object sender, EventArgs e)
        {
            clb_transportes.Items.Clear();
            
            //Criando uma lista
            List<String> tr = new List<String>();
            //Adicionando itens na lista
            tr.Add("Carro");
            tr.Add("Navio");
            tr.Add("Ônibus");
            tr.Add("Trem");

            clb_transportes.Items.AddRange(tr.ToArray());


        }
        //Adicionando conteúdo as novas listas 
        private void btn_addNovoTransporte_Click(object sender, EventArgs e)
        {
            if (tb_NovoTransporte.Text == string.Empty) //vazio
            {
                MessageBox.Show("Digite algo no campo");
                tb_NovoTransporte.Focus();
                return;
            }
                clb_transportes.Items.Add(tb_NovoTransporte.Text);
                tb_NovoTransporte.Clear();
                tb_NovoTransporte.Focus();
            
        }

        //Adicionando atalhos 
        private void F_CheckedListBox_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode) 
            {
                case Keys.Enter:
                    btn_addNovoTransporte_Click(sender, e);
                    break;
            }
        }
    }
}
