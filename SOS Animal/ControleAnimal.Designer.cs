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
            this.avatarAnimal = new System.Windows.Forms.PictureBox();
            this.botaoEditar = new System.Windows.Forms.Button();
            this.botaoRemover = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.avatarAnimal)).BeginInit();
            this.SuspendLayout();
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(59, 17);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(25, 23);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "ID";
            this.labelID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(193, 16);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(56, 23);
            this.labelNome.TabIndex = 1;
            this.labelNome.Text = "NOME";
            this.labelNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelIdade
            // 
            this.labelIdade.AutoSize = true;
            this.labelIdade.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdade.Location = new System.Drawing.Point(345, 16);
            this.labelIdade.Name = "labelIdade";
            this.labelIdade.Size = new System.Drawing.Size(57, 23);
            this.labelIdade.TabIndex = 2;
            this.labelIdade.Text = "IDADE";
            this.labelIdade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRaca
            // 
            this.labelRaca.AutoSize = true;
            this.labelRaca.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRaca.Location = new System.Drawing.Point(475, 17);
            this.labelRaca.Name = "labelRaca";
            this.labelRaca.Size = new System.Drawing.Size(54, 23);
            this.labelRaca.TabIndex = 3;
            this.labelRaca.Text = "RACA";
            this.labelRaca.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPorte
            // 
            this.labelPorte.AutoSize = true;
            this.labelPorte.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPorte.Location = new System.Drawing.Point(598, 17);
            this.labelPorte.Name = "labelPorte";
            this.labelPorte.Size = new System.Drawing.Size(63, 23);
            this.labelPorte.TabIndex = 4;
            this.labelPorte.Text = "PORTE";
            this.labelPorte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // avatarAnimal
            // 
            this.avatarAnimal.Location = new System.Drawing.Point(14, 11);
            this.avatarAnimal.Name = "avatarAnimal";
            this.avatarAnimal.Size = new System.Drawing.Size(36, 36);
            this.avatarAnimal.TabIndex = 5;
            this.avatarAnimal.TabStop = false;
            // 
            // botaoEditar
            // 
            this.botaoEditar.BackgroundImage = global::SOS_Animal.Properties.Resources.botaoEditar1;
            this.botaoEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.botaoEditar.FlatAppearance.BorderSize = 0;
            this.botaoEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.botaoEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.botaoEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoEditar.Location = new System.Drawing.Point(721, 14);
            this.botaoEditar.Name = "botaoEditar";
            this.botaoEditar.Size = new System.Drawing.Size(30, 30);
            this.botaoEditar.TabIndex = 6;
            this.botaoEditar.UseVisualStyleBackColor = true;
            this.botaoEditar.MouseEnter += new System.EventHandler(this.botaoEditar_MouseEnter);
            this.botaoEditar.MouseLeave += new System.EventHandler(this.botaoEditar_MouseLeave);
            // 
            // botaoRemover
            // 
            this.botaoRemover.BackgroundImage = global::SOS_Animal.Properties.Resources.botaoDeletar1;
            this.botaoRemover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.botaoRemover.FlatAppearance.BorderSize = 0;
            this.botaoRemover.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.botaoRemover.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.botaoRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoRemover.Location = new System.Drawing.Point(751, 14);
            this.botaoRemover.Name = "botaoRemover";
            this.botaoRemover.Size = new System.Drawing.Size(30, 30);
            this.botaoRemover.TabIndex = 7;
            this.botaoRemover.UseVisualStyleBackColor = true;
            this.botaoRemover.Click += new System.EventHandler(this.botaoRemover_Click);
            this.botaoRemover.MouseEnter += new System.EventHandler(this.botaoRemover_MouseEnter);
            this.botaoRemover.MouseLeave += new System.EventHandler(this.botaoRemover_MouseLeave);
            // 
            // ControleAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::SOS_Animal.Properties.Resources.listaControleAnimal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.botaoRemover);
            this.Controls.Add(this.botaoEditar);
            this.Controls.Add(this.avatarAnimal);
            this.Controls.Add(this.labelPorte);
            this.Controls.Add(this.labelRaca);
            this.Controls.Add(this.labelIdade);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.labelID);
            this.DoubleBuffered = true;
            this.Name = "ControleAnimal";
            this.Size = new System.Drawing.Size(822, 64);
            ((System.ComponentModel.ISupportInitialize)(this.avatarAnimal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label labelID;
        public System.Windows.Forms.Label labelNome;
        public System.Windows.Forms.Label labelIdade;
        public System.Windows.Forms.Label labelRaca;
        public System.Windows.Forms.Label labelPorte;
        private System.Windows.Forms.PictureBox avatarAnimal;
        private System.Windows.Forms.Button botaoRemover;
        public System.Windows.Forms.Button botaoEditar;
    }
}
