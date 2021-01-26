using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula60
{
    public partial class F_Principal : Form
    {
        public F_Principal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

         }

        //Apertando no botão  "OK"
        //ele vai trocar o nome que está lá em cima e anexar em baixo
        private void btn_ok_Click(object sender, EventArgs e)
        {
            lb_link.Text = tb_text.Text;
        }
    }
}
