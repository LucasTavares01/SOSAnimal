namespace SOS_Animal
{
    partial class TelaLogin
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.campoEmailLogin = new System.Windows.Forms.TextBox();
            this.campoSenhaLogin = new System.Windows.Forms.TextBox();
            this.avisoErroLogin = new System.Windows.Forms.Label();
            this.botaoCadastrarLogin = new System.Windows.Forms.Button();
            this.botaoFechar = new System.Windows.Forms.Button();
            this.botaoEntrarLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // campoEmailLogin
            // 
            this.campoEmailLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(218)))), ((int)(((byte)(194)))));
            this.campoEmailLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.campoEmailLogin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoEmailLogin.ForeColor = System.Drawing.Color.Black;
            this.campoEmailLogin.Location = new System.Drawing.Point(564, 260);
            this.campoEmailLogin.Name = "campoEmailLogin";
            this.campoEmailLogin.Size = new System.Drawing.Size(500, 25);
            this.campoEmailLogin.TabIndex = 2;
            this.campoEmailLogin.Text = "E-MAIL";
            this.campoEmailLogin.TextChanged += new System.EventHandler(this.campoEmailLogin_TextChanged);
            this.campoEmailLogin.Enter += new System.EventHandler(this.campoEmailLogin_Enter);
            this.campoEmailLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.campoEmailLogin_KeyDown);
            this.campoEmailLogin.Leave += new System.EventHandler(this.campoEmailLogin_Leave);
            // 
            // campoSenhaLogin
            // 
            this.campoSenhaLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(218)))), ((int)(((byte)(194)))));
            this.campoSenhaLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.campoSenhaLogin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.campoSenhaLogin.Location = new System.Drawing.Point(564, 363);
            this.campoSenhaLogin.Name = "campoSenhaLogin";
            this.campoSenhaLogin.Size = new System.Drawing.Size(500, 25);
            this.campoSenhaLogin.TabIndex = 3;
            this.campoSenhaLogin.Text = "SENHA";
            this.campoSenhaLogin.Enter += new System.EventHandler(this.campoSenhaLogin_Enter);
            this.campoSenhaLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.campoSenhaLogin_KeyDown);
            this.campoSenhaLogin.Leave += new System.EventHandler(this.campoSenhaLogin_Leave);
            // 
            // avisoErroLogin
            // 
            this.avisoErroLogin.AutoSize = true;
            this.avisoErroLogin.BackColor = System.Drawing.Color.IndianRed;
            this.avisoErroLogin.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold);
            this.avisoErroLogin.ForeColor = System.Drawing.Color.White;
            this.avisoErroLogin.Location = new System.Drawing.Point(708, 425);
            this.avisoErroLogin.Name = "avisoErroLogin";
            this.avisoErroLogin.Size = new System.Drawing.Size(152, 15);
            this.avisoErroLogin.TabIndex = 0;
            this.avisoErroLogin.Text = "E-MAIL OU SENHA INCORRETO";
            this.avisoErroLogin.Visible = false;
            // 
            // botaoCadastrarLogin
            // 
            this.botaoCadastrarLogin.BackColor = System.Drawing.Color.Transparent;
            this.botaoCadastrarLogin.BackgroundImage = global::SOS_Animal.Properties.Resources.botaoCadastrar1;
            this.botaoCadastrarLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.botaoCadastrarLogin.FlatAppearance.BorderSize = 0;
            this.botaoCadastrarLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.botaoCadastrarLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.botaoCadastrarLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoCadastrarLogin.Location = new System.Drawing.Point(36, 481);
            this.botaoCadastrarLogin.Name = "botaoCadastrarLogin";
            this.botaoCadastrarLogin.Size = new System.Drawing.Size(314, 103);
            this.botaoCadastrarLogin.TabIndex = 5;
            this.botaoCadastrarLogin.UseVisualStyleBackColor = false;
            this.botaoCadastrarLogin.Click += new System.EventHandler(this.BotaoCadastrarLogin_Click);
            this.botaoCadastrarLogin.MouseEnter += new System.EventHandler(this.botaoCadastrarLogin_MouseEnter);
            this.botaoCadastrarLogin.MouseLeave += new System.EventHandler(this.botaoCadastrarLogin_MouseLeave);
            // 
            // botaoFechar
            // 
            this.botaoFechar.BackColor = System.Drawing.Color.Transparent;
            this.botaoFechar.BackgroundImage = global::SOS_Animal.Properties.Resources.botaoFechar;
            this.botaoFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.botaoFechar.FlatAppearance.BorderSize = 0;
            this.botaoFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.botaoFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(219)))));
            this.botaoFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoFechar.Location = new System.Drawing.Point(1134, 0);
            this.botaoFechar.Name = "botaoFechar";
            this.botaoFechar.Size = new System.Drawing.Size(44, 44);
            this.botaoFechar.TabIndex = 1;
            this.botaoFechar.UseVisualStyleBackColor = false;
            this.botaoFechar.Click += new System.EventHandler(this.botaoFechar_Click);
            // 
            // botaoEntrarLogin
            // 
            this.botaoEntrarLogin.BackColor = System.Drawing.Color.Transparent;
            this.botaoEntrarLogin.BackgroundImage = global::SOS_Animal.Properties.Resources.botaoEntrar1;
            this.botaoEntrarLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.botaoEntrarLogin.FlatAppearance.BorderSize = 0;
            this.botaoEntrarLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.botaoEntrarLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.botaoEntrarLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoEntrarLogin.Location = new System.Drawing.Point(632, 479);
            this.botaoEntrarLogin.Name = "botaoEntrarLogin";
            this.botaoEntrarLogin.Size = new System.Drawing.Size(319, 107);
            this.botaoEntrarLogin.TabIndex = 6;
            this.botaoEntrarLogin.UseVisualStyleBackColor = false;
            this.botaoEntrarLogin.Click += new System.EventHandler(this.botaoEntrarLogin_Click);
            this.botaoEntrarLogin.MouseEnter += new System.EventHandler(this.botaoEntrarLogin_MouseEnter);
            this.botaoEntrarLogin.MouseLeave += new System.EventHandler(this.botaoEntrarLogin_MouseLeave);
            // 
            // TelaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SOS_Animal.Properties.Resources.TelaLogin;
            this.ClientSize = new System.Drawing.Size(1180, 660);
            this.Controls.Add(this.botaoEntrarLogin);
            this.Controls.Add(this.botaoFechar);
            this.Controls.Add(this.botaoCadastrarLogin);
            this.Controls.Add(this.avisoErroLogin);
            this.Controls.Add(this.campoSenhaLogin);
            this.Controls.Add(this.campoEmailLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FECHAR";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TelaLogin_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TelaLogin_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox campoEmailLogin;
        private System.Windows.Forms.TextBox campoSenhaLogin;
        private System.Windows.Forms.Label avisoErroLogin;
        private System.Windows.Forms.Button botaoCadastrarLogin;
        private System.Windows.Forms.Button botaoFechar;
        private System.Windows.Forms.Button botaoEntrarLogin;
    }
}

