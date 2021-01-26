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
            if (tb_veiculo.Text=="")
            {
                MessageBox.Show("Digite um Veículo");
                tb_veiculo.Focus();
                return; //para a execução do evento
            }
            if (tb_lista_veiculos.Text==tb_veiculo.Text)
            {
                MessageBox.Show("Você já adicionou este veículo");
                tb_veiculo.Focus();
                return;
            }
            tb_lista_veiculos.Text += tb_veiculo.Text + ", ";
            //desse modo ele vai concatenar o texto e não substituílo
            tb_veiculo.Clear();
            tb_veiculo.Focus(); //onde o posicionandor de digitação irá ficar 
        }
    }
}
