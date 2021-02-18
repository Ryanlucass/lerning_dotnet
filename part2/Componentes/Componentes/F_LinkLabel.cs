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
        public F_LinkLabel()
        {
            InitializeComponent();
            //tenho que colocar onde ele começa a posição[0] e o seu tamanho [6]
            ll_multipleLinks.Links.Add(0,6,"www.google.com.br");
            ll_multipleLinks.Links.Add(9,5,"www.gmail.com.br");
            ll_multipleLinks.Links.Add(17,7,"www.youtube.com.br");
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
    }
}
