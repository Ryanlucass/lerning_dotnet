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
    public partial class F_Principal : Form
    {
        public F_Principal()
        {
            InitializeComponent();

             
        }

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

        private void btn_clear_Click(object sender, EventArgs e)
        {
            tb_lista_veiculos.Clear();
            tb_veiculo.Clear();
            tb_veiculo.Focus();
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            F_veiculos f_veiculos = new F_veiculos(tb_lista_veiculos.Text);
            f_veiculos.ShowDialog();
        }
    }
}
