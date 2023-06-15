namespace SOS_Animal
{
    partial class ControleAnimal
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelID = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelIdade = new System.Windows.Forms.Label();
            this.labelRaca = new System.Windows.Forms.Label();
            this.labelPorte = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(50, 21);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(18, 13);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "ID";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(119, 21);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(39, 13);
            this.labelNome.TabIndex = 1;
            this.labelNome.Text = "NOME";
            // 
            // labelIdade
            // 
            this.labelIdade.AutoSize = true;
            this.labelIdade.Location = new System.Drawing.Point(204, 21);
            this.labelIdade.Name = "labelIdade";
            this.labelIdade.Size = new System.Drawing.Size(40, 13);
            this.labelIdade.TabIndex = 2;
            this.labelIdade.Text = "IDADE";
            // 
            // labelRaca
            // 
            this.labelRaca.AutoSize = true;
            this.labelRaca.Location = new System.Drawing.Point(298, 21);
            this.labelRaca.Name = "labelRaca";
            this.labelRaca.Size = new System.Drawing.Size(36, 13);
            this.labelRaca.TabIndex = 3;
            this.labelRaca.Text = "RACA";
            // 
            // labelPorte
            // 
            this.labelPorte.AutoSize = true;
            this.labelPorte.Location = new System.Drawing.Point(391, 21);
            this.labelPorte.Name = "labelPorte";
            this.labelPorte.Size = new System.Drawing.Size(44, 13);
            this.labelPorte.TabIndex = 4;
            this.labelPorte.Text = "PORTE";
            // 
            // ControleAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::SOS_Animal.Properties.Resources.listaControleAnimal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.labelPorte);
            this.Controls.Add(this.labelRaca);
            this.Controls.Add(this.labelIdade);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.labelID);
            this.DoubleBuffered = true;
            this.Name = "ControleAnimal";
            this.Size = new System.Drawing.Size(822, 64);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelIdade;
        private System.Windows.Forms.Label labelRaca;
        private System.Windows.Forms.Label labelPorte;
    }
}
