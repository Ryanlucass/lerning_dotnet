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
