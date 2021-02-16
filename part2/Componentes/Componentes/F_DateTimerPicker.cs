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
    public partial class F_DateTimerPicker : Form
    {
        public F_DateTimerPicker()
        {
            InitializeComponent();
        }
        //botão obter data
        private void btn_obter_data_Click(object sender, EventArgs e)
        {
            //Recebendo a data completa 
            //tb_data.Text = dtp_data.Text;
            tb_data.Text += "A data de hoje é: " + dtp_data.Text;
          
            //Recebendo o dia 
            tb_dia.Text = dtp_data.Value.Day.ToString();
            //Recebendo o Mês
            tb_mes.Text = dtp_data.Value.Month.ToString();
            //Recebendo o Ano
            tb_ano.Text = dtp_data.Value.Year.ToString();

            //obs: É preciso convertar "ToString()" pois os valores adquiridos no Value são Int
        }
    }
}
