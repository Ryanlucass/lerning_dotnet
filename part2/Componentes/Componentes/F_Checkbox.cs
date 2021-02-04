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
    public partial class F_Checkbox : Form
    {
        public F_Checkbox()
        {
            InitializeComponent();
        }
        
        //Botão Transportes Marcados 
        private void btn_transportes_marcados_Click(object sender, EventArgs e)
        {
            string txt = "";
            
            if(cb_carro.Checked)
            {
                txt += cb_carro.Text + System.Environment.NewLine.ToString();
            }
            if(cb_aviao.Checked)
            {
                txt += cb_aviao.Text + System.Environment.NewLine.ToString();
            }
            if (cb_navio.Checked)
            {
                txt += cb_navio.Text + System.Environment.NewLine.ToString();
            }
            if (cb_onibus.Checked)
            {
                txt += cb_onibus.Text + System.Environment.NewLine.ToString();
            }
            MessageBox.Show(txt);

        }
    }
}
