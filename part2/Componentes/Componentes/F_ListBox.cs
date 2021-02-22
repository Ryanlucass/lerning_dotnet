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
    public partial class F_ListBox : Form
    {
        //Criando a lista
        List<string> carros = new List<string>();

        public F_ListBox()
        {
            InitializeComponent();

            carros.Add("Ford Fiesta");
            carros.Add("Chevrolet Celta");
            carros.Add("Fiat Strada");
            carros.Add("Ford Ka");
            carros.Add("Volkswagen Fox");


            //Falando que o lb_carros está recebendo uma conjunto de dados da minha lista
            //Poderia ser de um banco de dados 
            lb_carros.DataSource = carros;
        }
    }
}
