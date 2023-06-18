namespace SOS_Animal
{
    partial class TelaCadastro
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
            this.campoEmailCadastro = new System.Windows.Forms.TextBox();
            this.campoNomeCadastro = new System.Windows.Forms.TextBox();
            this.campoSenhaCadastro = new System.Windows.Forms.TextBox();
            this.botaoCadastrar = new System.Windows.Forms.Button();
            this.botaoFecharCadastro = new System.Windows.Forms.Button();
            this.botaoVoltarCadastro = new System.Windows.Forms.Button();
            this.avisoNomeInvalido = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // campoEmailCadastro
            // 
            this.campoEmailCadastro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.campoEmailCadastro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.campoEmailCadastro.Location = new System.Drawing.Point(554, 303);
            this.campoEmailCadastro.Name = "campoEmailCadastro";
            this.campoEmailCadastro.Size = new System.Drawing.Size(450, 25);
            this.campoEmailCadastro.TabIndex = 2;
            this.campoEmailCadastro.Text = "E-MAIL";
            this.campoEmailCadastro.TextChanged += new System.EventHandler(this.campoEmailCadastro_TextChanged);
            this.campoEmailCadastro.Enter += new System.EventHandler(this.campoEmailCadastro_Enter);
            this.campoEmailCadastro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.campoEmailCadastro_KeyDown);
            this.campoEmailCadastro.Leave += new System.EventHandler(this.campoEmailCadastro_Leave);
            // 
            // campoNomeCadastro
            // 
            this.campoNomeCadastro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.campoNomeCadastro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.campoNomeCadastro.Location = new System.Drawing.Point(554, 191);
            this.campoNomeCadastro.Name = "campoNomeCadastro";
            this.campoNomeCadastro.Size = new System.Drawing.Size(460, 25);
            this.campoNomeCadastro.TabIndex = 1;
            this.campoNomeCadastro.Text = "NOME COMPLETO";
            this.campoNomeCadastro.TextChanged += new System.EventHandler(this.campoNomeCadastro_TextChanged);
            this.campoNomeCadastro.Enter += new System.EventHandler(this.campoNomeCadastro_Enter);
            this.campoNomeCadastro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.campoNomeCadastro_KeyDown);
            this.campoNomeCadastro.Leave += new System.EventHandler(this.campoNomeCadastro_Leave);
            // 
            // campoSenhaCadastro
            // 
            this.campoSenhaCadastro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.campoSenhaCadastro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.campoSenhaCadastro.Location = new System.Drawing.Point(554, 417);
            this.campoSenhaCadastro.Name = "campoSenhaCadastro";
            this.campoSenhaCadastro.Size = new System.Drawing.Size(450, 25);
            this.campoSenhaCadastro.TabIndex = 3;
            this.campoSenhaCadastro.Text = "SENHA";
            this.campoSenhaCadastro.Enter += new System.EventHandler(this.campoSenhaCadastro_Enter);
            this.campoSenhaCadastro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.campoSenhaCadastro_KeyDown);
            this.campoSenhaCadastro.Leave += new System.EventHandler(this.campoSenhaCadastro_Leave);
            // 
            // botaoCadastrar
            // 
            this.botaoCadastrar.BackColor = System.Drawing.Color.Transparent;
            this.botaoCadastrar.BackgroundImage = global::SOS_Animal.Properties.Resources.botaoCadastrarDados1;
            this.botaoCadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.botaoCadastrar.FlatAppearance.BorderSize = 0;
            this.botaoCadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.botaoCadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.botaoCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoCadastrar.Location = new System.Drawing.Point(614, 490);
            this.botaoCadastrar.Name = "botaoCadastrar";
            this.botaoCadastrar.Size = new System.Drawing.Size(278, 116);
            this.botaoCadastrar.TabIndex = 4;
            this.botaoCadastrar.UseVisualStyleBackColor = false;
            this.botaoCadastrar.Click += new System.EventHandler(this.botaoCadastrar_Click);
            this.botaoCadastrar.MouseEnter += new System.EventHandler(this.botaoCadastrar_MouseEnter);
            this.botaoCadastrar.MouseLeave += new System.EventHandler(this.botaoCadastrar_MouseLeave);
            // 
            // botaoFecharCadastro
            // 
            this.botaoFecharCadastro.BackColor = System.Drawing.Color.Transparent;
            this.botaoFecharCadastro.BackgroundImage = global::SOS_Animal.Properties.Resources.botaoFechar;
            this.botaoFecharCadastro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.botaoFecharCadastro.FlatAppearance.BorderSize = 0;
            this.botaoFecharCadastro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.botaoFecharCadastro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(219)))));
            this.botaoFecharCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoFecharCadastro.Location = new System.Drawing.Point(1134, 0);
            this.botaoFecharCadastro.Name = "botaoFecharCadastro";
            this.botaoFecharCadastro.Size = new System.Drawing.Size(44, 44);
            this.botaoFecharCadastro.TabIndex = 0;
            this.botaoFecharCadastro.UseVisualStyleBackColor = false;
            this.botaoFecharCadastro.Click += new System.EventHandler(this.botaoFecharCadastro_Click);
            // 
            // botaoVoltarCadastro
            // 
            this.botaoVoltarCadastro.BackColor = System.Drawing.Color.Transparent;
            this.botaoVoltarCadastro.BackgroundImage = global::SOS_Animal.Properties.Resources.botaoVoltar;
            this.botaoVoltarCadastro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.botaoVoltarCadastro.FlatAppearance.BorderSize = 0;
            this.botaoVoltarCadastro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.botaoVoltarCadastro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.botaoVoltarCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoVoltarCadastro.Location = new System.Drawing.Point(326, 0);
            this.botaoVoltarCadastro.Name = "botaoVoltarCadastro";
            this.botaoVoltarCadastro.Size = new System.Drawing.Size(44, 44);
            this.botaoVoltarCadastro.TabIndex = 5;
            this.botaoVoltarCadastro.UseVisualStyleBackColor = false;
            this.botaoVoltarCadastro.Click += new System.EventHandler(this.botaoVoltarCadastro_Click);
            // 
            // avisoNomeInvalido
            // 
            this.avisoNomeInvalido.AutoSize = true;
            this.avisoNomeInvalido.BackColor = System.Drawing.Color.IndianRed;
            this.avisoNomeInvalido.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold);
            this.avisoNomeInvalido.ForeColor = System.Drawing.Color.White;
            this.avisoNomeInvalido.Location = new System.Drawing.Point(681, 476);
            this.avisoNomeInvalido.Name = "avisoNomeInvalido";
            this.avisoNomeInvalido.Size = new System.Drawing.Size(143, 15);
            this.avisoNomeInvalido.TabIndex = 6;
            this.avisoNomeInvalido.Text = "NOME OU E-MAIL INVÁLIDOS";
            this.avisoNomeInvalido.Visible = false;
            // 
            // TelaCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::SOS_Animal.Properties.Resources.TelaCadastro;
            this.ClientSize = new System.Drawing.Size(1180, 660);
            this.Controls.Add(this.avisoNomeInvalido);
            this.Controls.Add(this.botaoVoltarCadastro);
            this.Controls.Add(this.botaoFecharCadastro);
            this.Controls.Add(this.botaoCadastrar);
            this.Controls.Add(this.campoSenhaCadastro);
            this.Controls.Add(this.campoNomeCadastro);
            this.Controls.Add(this.campoEmailCadastro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaCadastro";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TelaCadastro_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox campoEmailCadastro;
        private System.Windows.Forms.TextBox campoNomeCadastro;
        private System.Windows.Forms.TextBox campoSenhaCadastro;
        private System.Windows.Forms.Button botaoCadastrar;
        private System.Windows.Forms.Button botaoFecharCadastro;
        private System.Windows.Forms.Button botaoVoltarCadastro;
        private System.Windows.Forms.Label avisoNomeInvalido;
    }
}