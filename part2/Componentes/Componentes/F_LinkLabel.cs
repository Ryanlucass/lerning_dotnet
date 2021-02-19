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
    public partial class F_LinkLabel : Form
    {
        string namelink;

        public F_LinkLabel()
        {
            InitializeComponent();
            ll_multipleLinks.Links.Add(0,6,"www.google.com.br");
            ll_multipleLinks.Links.Add(9,5,"www.gmail.com.br");
            ll_multipleLinks.Links.Add(17,7,"www.youtube.com.br");

    

            //desativando um link que está na posição [2]
            ll_multipleLinks.Links[2].Enabled = false;
            
            //tenho que colocar onde ele começa a posição[0] e o seu tamanho [6]
        }

        // Github Link 
        private void ll_github_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Como chamar o Link

            System.Diagnostics.Process.Start("https://github.com/Ryanlucass?tab=overview&from=2021-02-01&to=2021-02-18");
            //Dentro  da string passe o link da page 
        }

        //Abrir Calculadora 
        private void ll_Calc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Pode colocar o nome do programa ou o caminho para o arquivo 

            System.Diagnostics.Process.Start("calc.exe");
        }
        //Chamando o multiple links 
        private void ll_multipleLinks_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());

            //(e) pois é o que a função me retorna
            //LinkData é o que eu quero, quero que eleme retorno o link do (e)
            //LinkData o espaço que ele retorna, o espaço de cada strin, se fosse somente  um link não precisaria colocar
            //Estou convertendo para string, já que ele é outro tipo
        }

        //Botão Gerar Link
        public void btn_GetLink_Click(object sender, EventArgs e)
        {
            namelink = tb_Link.Text;
        }

        //Passando o Link para o label
        public void ll_atual_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(namelink);
        }

        //Definindo o nome do Link
        private void btn_NameLink_Click(object sender, EventArgs e)
        {
            ll_atual.Text = tb_NameLink.Text;
        }
    }
}
