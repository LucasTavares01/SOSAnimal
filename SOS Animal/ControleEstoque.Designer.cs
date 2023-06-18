namespace SOS_Animal
{
    partial class ControleEstoque
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
            this.picboxItem2 = new System.Windows.Forms.PictureBox();
            this.labelDoadoPorEstoque = new System.Windows.Forms.Label();
            this.labelDescricaoEstoque = new System.Windows.Forms.Label();
            this.labelNomeEstoque = new System.Windows.Forms.Label();
            this.labelDataEstoque = new System.Windows.Forms.Label();
            this.botaoRemover = new System.Windows.Forms.Button();
            this.botaoEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picboxItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // picboxItem2
            // 
            this.picboxItem2.Location = new System.Drawing.Point(20, 28);
            this.picboxItem2.Name = "picboxItem2";
            this.picboxItem2.Size = new System.Drawing.Size(100, 100);
            this.picboxItem2.TabIndex = 0;
            this.picboxItem2.TabStop = false;
            // 
            // labelDoadoPorEstoque
            // 
            this.labelDoadoPorEstoque.AutoSize = true;
            this.labelDoadoPorEstoque.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDoadoPorEstoque.Location = new System.Drawing.Point(561, 69);
            this.labelDoadoPorEstoque.Name = "labelDoadoPorEstoque";
            this.labelDoadoPorEstoque.Size = new System.Drawing.Size(104, 23);
            this.labelDoadoPorEstoque.TabIndex = 7;
            this.labelDoadoPorEstoque.Text = "DOADO POR";
            this.labelDoadoPorEstoque.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDescricaoEstoque
            // 
            this.labelDescricaoEstoque.AutoSize = true;
            this.labelDescricaoEstoque.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescricaoEstoque.Location = new System.Drawing.Point(415, 69);
            this.labelDescricaoEstoque.Name = "labelDescricaoEstoque";
            this.labelDescricaoEstoque.Size = new System.Drawing.Size(101, 23);
            this.labelDescricaoEstoque.TabIndex = 6;
            this.labelDescricaoEstoque.Text = "DESCRICAO";
            this.labelDescricaoEstoque.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNomeEstoque
            // 
            this.labelNomeEstoque.AutoSize = true;
            this.labelNomeEstoque.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeEstoque.Location = new System.Drawing.Point(293, 69);
            this.labelNomeEstoque.Name = "labelNomeEstoque";
            this.labelNomeEstoque.Size = new System.Drawing.Size(56, 23);
            this.labelNomeEstoque.TabIndex = 5;
            this.labelNomeEstoque.Text = "NOME";
            this.labelNomeEstoque.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDataEstoque
            // 
            this.labelDataEstoque.AutoSize = true;
            this.labelDataEstoque.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataEstoque.Location = new System.Drawing.Point(176, 69);
            this.labelDataEstoque.Name = "labelDataEstoque";
            this.labelDataEstoque.Size = new System.Drawing.Size(53, 23);
            this.labelDataEstoque.TabIndex = 4;
            this.labelDataEstoque.Text = "DATA";
            this.labelDataEstoque.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // botaoRemover
            // 
            this.botaoRemover.Location = new System.Drawing.Point(746, 64);
            this.botaoRemover.Name = "botaoRemover";
            this.botaoRemover.Size = new System.Drawing.Size(55, 33);
            this.botaoRemover.TabIndex = 9;
            this.botaoRemover.Text = "button2";
            this.botaoRemover.UseVisualStyleBackColor = true;
            this.botaoRemover.Click += new System.EventHandler(this.botaoRemover_Click);
            this.botaoRemover.MouseEnter += new System.EventHandler(this.botaoRemover_MouseEnter);
            this.botaoRemover.MouseLeave += new System.EventHandler(this.botaoRemover_MouseLeave);
            // 
            // botaoEditar
            // 
            this.botaoEditar.Location = new System.Drawing.Point(685, 64);
            this.botaoEditar.Name = "botaoEditar";
            this.botaoEditar.Size = new System.Drawing.Size(55, 33);
            this.botaoEditar.TabIndex = 8;
            this.botaoEditar.Text = "button1";
            this.botaoEditar.UseVisualStyleBackColor = true;
            this.botaoEditar.Click += new System.EventHandler(this.botaoEditar_Click);
            this.botaoEditar.MouseEnter += new System.EventHandler(this.botaoEditar_MouseEnter);
            this.botaoEditar.MouseLeave += new System.EventHandler(this.botaoEditar_MouseLeave);
            // 
            // ControleEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::SOS_Animal.Properties.Resources.listaControleEstoque;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.picboxItem2);
            this.Controls.Add(this.botaoRemover);
            this.Controls.Add(this.botaoEditar);
            this.Controls.Add(this.labelDoadoPorEstoque);
            this.Controls.Add(this.labelDescricaoEstoque);
            this.Controls.Add(this.labelNomeEstoque);
            this.Controls.Add(this.labelDataEstoque);
            this.DoubleBuffered = true;
            this.Name = "ControleEstoque";
            this.Size = new System.Drawing.Size(830, 163);
            ((System.ComponentModel.ISupportInitialize)(this.picboxItem2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label labelDoadoPorEstoque;
        public System.Windows.Forms.Label labelDescricaoEstoque;
        public System.Windows.Forms.Label labelNomeEstoque;
        public System.Windows.Forms.Label labelDataEstoque;
        private System.Windows.Forms.Button botaoRemover;
        public System.Windows.Forms.Button botaoEditar;
        public System.Windows.Forms.PictureBox picboxItem2;
    }
}
