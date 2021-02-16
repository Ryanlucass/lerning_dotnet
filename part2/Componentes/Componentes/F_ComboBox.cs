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
    public partial class F_ComboBox : Form
    {
        public F_ComboBox()
        {
            InitializeComponent();
        }

        //Botão dos Itens Selecionados 
        private void btn_MostrarSelecionados_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cb_transportes.Text);
        }

        //Botão de limpar 
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            cb_transportes.Items.Clear();
        }

        //Botão de Resetar os Itens 
        private void btn_reset_Click(object sender, EventArgs e)
        {
            cb_transportes.Items.Clear();

            //criando a lista
            List<string> Vr = new List<string>();
            Vr.Add("Carro");
            Vr.Add("Navio");
            Vr.Add("Ônibus");
            Vr.Add("Trem");

            cb_transportes.Items.AddRange(Vr.ToArray());

        }

        private void cb_transportes_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_Transporte.Text = cb_transportes.Text;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (tb_Transporte.Text != "")
            {
                if (cb_transportes.FindString(tb_Transporte.Text) < 0)
                {
                    cb_transportes.Items.Add(tb_Transporte.Text);
                    tb_Transporte.Clear();
                    tb_Transporte.Focus();
                }
                else
                {
                    MessageBox.Show("O veículo já existe");
                }
                
            }
            else
            {
                MessageBox.Show("Digite um veículo");
            }
        }

        //Botões de Atalho 
        private void F_ComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Enter:
                btn_add_Click(sender, e);
                break;
            }
        }






    }
}
