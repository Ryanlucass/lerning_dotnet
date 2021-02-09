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
    public partial class F_filhoCheckBox : Form
    {
        //variável global 
        public F_Checkbox fcb;
        
        public F_filhoCheckBox()
        {
            InitializeComponent();
            fcb = Application.OpenForms["F_Checkbox"] as F_Checkbox;
            cb_carro.Checked = fcb.cb_carro.Checked;
            cb_aviao.Checked = fcb.cb_aviao.Checked;
            cb_navio.Checked = fcb.cb_navio.Checked;
            cb_onibus.Checked = fcb.cb_onibus.Checked;

        }
    }
}
