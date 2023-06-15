using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOS_Animal
{
    public partial class ControleAnimal : UserControl
    {
        public ControleAnimal()
        {
            InitializeComponent();
        }

        public void PreencherLabels(string idAnimal, string nome, string idade, string raca, string porte)
        {
            labelID.Text = idAnimal;
            labelNome.Text = nome;
            labelIdade.Text = idade;
            labelRaca.Text = raca;
            labelPorte.Text = porte;
        }
    }
}
