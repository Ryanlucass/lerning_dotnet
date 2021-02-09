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
        //Criando a minha lista do tipo Checkbox 

        List<CheckBox> veiculos=new List <CheckBox>();
        public F_Checkbox()
        {
            InitializeComponent();
            veiculos.Add(cb_carro);
            veiculos.Add(cb_aviao);
            veiculos.Add(cb_navio);
            veiculos.Add(cb_onibus);

        }
        
        //Botão Transportes Marcados 
        private void btn_transportes_marcados_Click(object sender, EventArgs e)
        {
            string txt = "";
            
            foreach (CheckBox t in veiculos)
            {
                if(t.Checked)
                {
                    txt += t.Text + System.Environment.NewLine.ToString();
                }
            }

            MessageBox.Show(txt);
        }

        //Chacked do Patinete 
        private void cb_patinete_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_patinete.Checked)
            {
                MessageBox.Show("Patinete Marcado");
            }
        }
    }
}
