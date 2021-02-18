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

            System.Diagnostics.Process.Start("");
            //Dentro  da string passe o link da page 
        }
    }
}
