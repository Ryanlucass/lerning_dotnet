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
    public partial class F_CheckedListBox : Form
    {
        public F_CheckedListBox()
        {
            InitializeComponent();
        }

        private void btn_mostrar_selecionados_Click(object sender, EventArgs e)
        {
            string txt = "";    //iniciando uma variável com nada para relacionar esse valor futuramente 
            
            foreach(string t in clb_transportes.CheckedItems)
            {
                txt += t + ", ";
            }


            MessageBox.Show(txt);

        }
    }
}
