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
        //Mostrando os ítens selecionados do ChecketBox 
        private void btn_mostrar_selecionados_Click(object sender, EventArgs e)
        {
            string txt = "";    //iniciando uma variável com nada para relacionar esse valor futuramente 


            //ciclo para percorrer a coleção "CheckedItems"
            foreach (string t in clb_transportes.CheckedItems)
            {
                txt += t + ", ";
            }


            MessageBox.Show(txt);

        }


        //Limpando o Checketbox 
        private void btn_limpar_Click(object sender, EventArgs e)
        {
            clb_transportes.Items.Clear();
        }

        private void btn_resetar_lista_Click(object sender, EventArgs e)
        {
            clb_transportes.Items.Clear();
            clb_transportes.Items.Add("Carro",false);
            clb_transportes.Items.Add("Navio", false);
            clb_transportes.Items.Add("Ônibus", false);
            clb_transportes.Items.Add("Trem", false);

        }
    }
}
