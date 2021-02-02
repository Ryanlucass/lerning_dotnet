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
    public partial class F_veiculos : Form
    {
        F_Principal fp; //ele pode ser usado por toda classe, dentro do construtor ele muda o valor de f 
        public F_veiculos(String v,F_Principal f)
        {
            InitializeComponent();

            tb_listaveiculos.Text = v;
            fp = f;

        }

        private void F_veiculos_FormClosed(object sender, FormClosedEventArgs e)
        {
            fp.tb_lista_veiculos.Text = tb_listaveiculos.Text;
        }
    }
}
