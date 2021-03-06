﻿using System;
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

        //Função para atualizar o conjunto de dados 
        private void atualizaLB(ListBox lb, List<string>l)
        {
            lb.DataSource = null;
            lb.DataSource = l;
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
                //Atulizando o data sirce 
                atualizaLB(lb_carros, carros);

                tb_carro.Clear();
                tb_carro.Focus();
            }
        }

        //Botão de Remover 

 
        private void btn_remover_Click(object sender, EventArgs e)
        {
            carros.RemoveAt(lb_carros.SelectedIndex);
            atualizaLB(lb_carros, carros);
        }

        //Botão para Obter 
        private void btn_obter_Click(object sender, EventArgs e)
        {

            //Obter para o carro label aquilo que está selecionado 
            tb_carro.Text = carros[lb_carros.SelectedIndex];
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            tb_carro.Clear();

            atualizaLB(lb_carros, carros);
        }
    }
}
