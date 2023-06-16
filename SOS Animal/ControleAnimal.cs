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

        public void trocarImagem(string GC)
        {
            if (GC == "0")
            {
                avatarAnimal.Image = Properties.Resources.avatarGato;

                Image originalImage = Properties.Resources.avatarGato; // Substitua "nome_da_imagem" pelo nome do recurso de imagem

                int larguraDesejada = avatarAnimal.Width;
                int alturaDesejada = avatarAnimal.Height;

                Image imagemRedimensionada = new Bitmap(larguraDesejada, alturaDesejada);
                using (Graphics graphics = Graphics.FromImage(imagemRedimensionada))
                {
                    graphics.DrawImage(originalImage, 0, 0, larguraDesejada, alturaDesejada);
                }

                avatarAnimal.Image = imagemRedimensionada;

            }
            else if (GC == "1")
            {
                avatarAnimal.Image = Properties.Resources.avatarCachorro;

                Image originalImage = Properties.Resources.avatarCachorro; // Substitua "nome_da_imagem" pelo nome do recurso de imagem

                int larguraDesejada = avatarAnimal.Width;
                int alturaDesejada = avatarAnimal.Height;

                Image imagemRedimensionada = new Bitmap(larguraDesejada, alturaDesejada);
                using (Graphics graphics = Graphics.FromImage(imagemRedimensionada))
                {
                    graphics.DrawImage(originalImage, 0, 0, larguraDesejada, alturaDesejada);
                }

                avatarAnimal.Image = imagemRedimensionada;

            }
        }
    }
}
