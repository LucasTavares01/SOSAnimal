namespace SOS_Animal
{
    partial class TelaEscolhaCadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.botaoEscolhaEstoque = new System.Windows.Forms.Button();
            this.botaoEscolhaFinanceiro = new System.Windows.Forms.Button();
            this.botaoEscolhaControleAnimal = new System.Windows.Forms.Button();
            this.botaoFecharEscolha = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botaoEscolhaEstoque
            // 
            this.botaoEscolhaEstoque.BackColor = System.Drawing.Color.Transparent;
            this.botaoEscolhaEstoque.BackgroundImage = global::SOS_Animal.Properties.Resources.estoque_1;
            this.botaoEscolhaEstoque.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botaoEscolhaEstoque.FlatAppearance.BorderSize = 0;
            this.botaoEscolhaEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoEscolhaEstoque.Location = new System.Drawing.Point(130, 249);
            this.botaoEscolhaEstoque.Name = "botaoEscolhaEstoque";
            this.botaoEscolhaEstoque.Size = new System.Drawing.Size(200, 200);
            this.botaoEscolhaEstoque.TabIndex = 0;
            this.botaoEscolhaEstoque.UseVisualStyleBackColor = false;
            this.botaoEscolhaEstoque.Click += new System.EventHandler(this.botaoEscolhaEstoque_Click);
            // 
            // botaoEscolhaFinanceiro
            // 
            this.botaoEscolhaFinanceiro.BackColor = System.Drawing.Color.Transparent;
            this.botaoEscolhaFinanceiro.BackgroundImage = global::SOS_Animal.Properties.Resources.bolsa_de_dinheiro__1__1;
            this.botaoEscolhaFinanceiro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botaoEscolhaFinanceiro.FlatAppearance.BorderSize = 0;
            this.botaoEscolhaFinanceiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoEscolhaFinanceiro.Location = new System.Drawing.Point(473, 249);
            this.botaoEscolhaFinanceiro.Name = "botaoEscolhaFinanceiro";
            this.botaoEscolhaFinanceiro.Size = new System.Drawing.Size(200, 200);
            this.botaoEscolhaFinanceiro.TabIndex = 1;
            this.botaoEscolhaFinanceiro.UseVisualStyleBackColor = false;
            this.botaoEscolhaFinanceiro.Click += new System.EventHandler(this.botaoEscolhaFinanceiro_Click);
            // 
            // botaoEscolhaControleAnimal
            // 
            this.botaoEscolhaControleAnimal.BackColor = System.Drawing.Color.Transparent;
            this.botaoEscolhaControleAnimal.BackgroundImage = global::SOS_Animal.Properties.Resources.animal_care_1;
            this.botaoEscolhaControleAnimal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botaoEscolhaControleAnimal.FlatAppearance.BorderSize = 0;
            this.botaoEscolhaControleAnimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoEscolhaControleAnimal.Location = new System.Drawing.Point(844, 249);
            this.botaoEscolhaControleAnimal.Name = "botaoEscolhaControleAnimal";
            this.botaoEscolhaControleAnimal.Size = new System.Drawing.Size(200, 200);
            this.botaoEscolhaControleAnimal.TabIndex = 2;
            this.botaoEscolhaControleAnimal.UseVisualStyleBackColor = false;
            this.botaoEscolhaControleAnimal.Click += new System.EventHandler(this.botaoEscolhaControleAnimal_Click);
            // 
            // botaoFecharEscolha
            // 
            this.botaoFecharEscolha.BackColor = System.Drawing.Color.Transparent;
            this.botaoFecharEscolha.BackgroundImage = global::SOS_Animal.Properties.Resources.Vector;
            this.botaoFecharEscolha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.botaoFecharEscolha.FlatAppearance.BorderSize = 0;
            this.botaoFecharEscolha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoFecharEscolha.Location = new System.Drawing.Point(1107, 12);
            this.botaoFecharEscolha.Name = "botaoFecharEscolha";
            this.botaoFecharEscolha.Size = new System.Drawing.Size(61, 44);
            this.botaoFecharEscolha.TabIndex = 3;
            this.botaoFecharEscolha.UseVisualStyleBackColor = false;
            this.botaoFecharEscolha.Click += new System.EventHandler(this.botaoFecharEscolha_Click);
            // 
            // TelaEscolhaCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SOS_Animal.Properties.Resources.TelaEscolhaCadastro;
            this.ClientSize = new System.Drawing.Size(1180, 660);
            this.Controls.Add(this.botaoFecharEscolha);
            this.Controls.Add(this.botaoEscolhaControleAnimal);
            this.Controls.Add(this.botaoEscolhaFinanceiro);
            this.Controls.Add(this.botaoEscolhaEstoque);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaEscolhaCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaEscolhaCadastro";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botaoEscolhaEstoque;
        private System.Windows.Forms.Button botaoEscolhaFinanceiro;
        private System.Windows.Forms.Button botaoEscolhaControleAnimal;
        private System.Windows.Forms.Button botaoFecharEscolha;
    }
}