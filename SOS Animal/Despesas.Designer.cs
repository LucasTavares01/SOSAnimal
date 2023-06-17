namespace SOS_Animal
{
    partial class Despesas
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
            this.labelDescricao = new System.Windows.Forms.Label();
            this.labelValor = new System.Windows.Forms.Label();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.botaoRemover = new System.Windows.Forms.Button();
            this.botaoEditar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDescricao
            // 
            this.labelDescricao.AutoSize = true;
            this.labelDescricao.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescricao.Location = new System.Drawing.Point(456, 14);
            this.labelDescricao.Name = "labelDescricao";
            this.labelDescricao.Size = new System.Drawing.Size(86, 23);
            this.labelDescricao.TabIndex = 7;
            this.labelDescricao.Text = "Descricao";
            this.labelDescricao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelValor
            // 
            this.labelValor.AutoSize = true;
            this.labelValor.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValor.Location = new System.Drawing.Point(332, 14);
            this.labelValor.Name = "labelValor";
            this.labelValor.Size = new System.Drawing.Size(49, 23);
            this.labelValor.TabIndex = 6;
            this.labelValor.Text = "Valor";
            this.labelValor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategoria.Location = new System.Drawing.Point(181, 14);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(83, 23);
            this.labelCategoria.TabIndex = 5;
            this.labelCategoria.Text = "Categoria";
            this.labelCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelData.Location = new System.Drawing.Point(48, 14);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(44, 23);
            this.labelData.TabIndex = 4;
            this.labelData.Text = "Data";
            this.labelData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // botaoRemover
            // 
            this.botaoRemover.Location = new System.Drawing.Point(752, 10);
            this.botaoRemover.Name = "botaoRemover";
            this.botaoRemover.Size = new System.Drawing.Size(55, 33);
            this.botaoRemover.TabIndex = 9;
            this.botaoRemover.Text = "button2";
            this.botaoRemover.UseVisualStyleBackColor = true;
            // 
            // botaoEditar
            // 
            this.botaoEditar.Location = new System.Drawing.Point(691, 10);
            this.botaoEditar.Name = "botaoEditar";
            this.botaoEditar.Size = new System.Drawing.Size(55, 33);
            this.botaoEditar.TabIndex = 8;
            this.botaoEditar.Text = "button1";
            this.botaoEditar.UseVisualStyleBackColor = true;
            // 
            // Despesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::SOS_Animal.Properties.Resources.listaDespesasReceitas;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.botaoRemover);
            this.Controls.Add(this.botaoEditar);
            this.Controls.Add(this.labelDescricao);
            this.Controls.Add(this.labelValor);
            this.Controls.Add(this.labelCategoria);
            this.Controls.Add(this.labelData);
            this.DoubleBuffered = true;
            this.Name = "Despesas";
            this.Size = new System.Drawing.Size(822, 64);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label labelDescricao;
        public System.Windows.Forms.Label labelValor;
        public System.Windows.Forms.Label labelCategoria;
        public System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Button botaoRemover;
        public System.Windows.Forms.Button botaoEditar;
    }
}
