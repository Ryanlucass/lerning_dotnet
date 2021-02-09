using System;
using System.Windows.Forms;

namespace Componentes
{
    public partial class F_filhoCheckBox : Form
    {
        //variável global 
        public F_Checkbox fcb;


        // Passando Dados de Um checbox para outro 
        public F_filhoCheckBox()
        {
            InitializeComponent();
            fcb = Application.OpenForms["F_Checkbox"] as F_Checkbox;
            cb_carro.Checked = fcb.cb_carro.Checked;
            cb_aviao.Checked = fcb.cb_aviao.Checked;
            cb_navio.Checked = fcb.cb_navio.Checked;
            cb_onibus.Checked = fcb.cb_onibus.Checked;

        }
        //O filho retornando para o pai o Valor dos ChecketBox
        private void cb_carro_CheckedChanged(object sender, EventArgs e)
        {
            fcb.cb_carro.Checked = cb_carro.Checked;
        }

        private void cb_aviao_CheckedChanged(object sender, EventArgs e)
        {
            fcb.cb_aviao.Checked = cb_aviao.Checked;
        }
        private void cb_navio_CheckedChanged(object sender, EventArgs e)
        {
            fcb.cb_navio.Checked = cb_navio.Checked;
        }

        private void cb_onibus_CheckedChanged(object sender, EventArgs e)
        {
            fcb.cb_onibus.Checked = cb_onibus.Checked;
        }

    }
}
