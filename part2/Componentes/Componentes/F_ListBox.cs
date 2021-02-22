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
    public partial class F_ListBox : Form
    {
        //Criando a lista
        List<string> carros = new List<string>();

        public F_ListBox()
        {
            InitializeComponent();

            carros.Add("Ford Fiesta");
            carros.Add("Chevrolet Celta");
            carros.Add("Fiat Strada");
            carros.Add("Ford Ka");
            carros.Add("Volkswagen Fox");


            //Falando que o lb_carros está recebendo uma conjunto de dados da minha lista
            //Poderia ser de um banco de dados 
            lb_carros.DataSource = carros;
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            if(tb_carro.Text == "")
            {
                MessageBox.Show("Digite um carro !");
                
                lb_carros.Focus();
            }
            else 
            {
                carros.Add(tb_carro.Text);
                lb_carros.DataSource = null;
                lb_carros.DataSource = carros;

                tb_carro.Clear();
                tb_carro.Focus();
            }
        }
    }
}
