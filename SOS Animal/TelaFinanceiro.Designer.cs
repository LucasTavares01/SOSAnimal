namespace SOS_Animal
{
    partial class TelaFinanceiro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaFinanceiro));
            this.botaoVoltarFinanceiro = new System.Windows.Forms.Button();
            this.botaoFechar = new System.Windows.Forms.Button();
            this.panelLateralFinanceiro = new System.Windows.Forms.Panel();
            this.botaoCadastrarReceitas = new System.Windows.Forms.Button();
            this.botaoCadastrarDespesas = new System.Windows.Forms.Button();
            this.botaoReceitas = new System.Windows.Forms.Button();
            this.botaoDespesas = new System.Windows.Forms.Button();
            this.cadastrarDespesas = new System.Windows.Forms.Panel();
            this.textDescricaoDespesas = new System.Windows.Forms.TextBox();
            this.textValorDespesas = new System.Windows.Forms.TextBox();
            this.textCategoriaDespesas = new System.Windows.Forms.TextBox();
            this.textDataDespesas = new System.Windows.Forms.TextBox();
            this.botaoCadastrarDespesas2 = new System.Windows.Forms.Button();
            this.panelDespesas = new System.Windows.Forms.Panel();
            this.btnOrdenarPorData = new System.Windows.Forms.Button();
            this.btnOrdenarDescricao = new System.Windows.Forms.Button();
            this.btnOrdenarPorValor = new System.Windows.Forms.Button();
            this.btnOrdenarPorCategoria = new System.Windows.Forms.Button();
            this.flowDespesas = new System.Windows.Forms.FlowLayoutPanel();
            this.panelReceitas = new System.Windows.Forms.Panel();
            this.btnOrdenarPorDataReceitas = new System.Windows.Forms.Button();
            this.btnOrdenarPorDescricaoReceitas = new System.Windows.Forms.Button();
            this.btnOrdenarPorValorReceitas = new System.Windows.Forms.Button();
            this.btnOrdenarPorCategoriaReceitas = new System.Windows.Forms.Button();
            this.flowReceitas = new System.Windows.Forms.FlowLayoutPanel();
            this.cadastrarReceitas = new System.Windows.Forms.Panel();
            this.textDescricaoReceitas = new System.Windows.Forms.TextBox();
            this.textValorReceitas = new System.Windows.Forms.TextBox();
            this.textCategoriaReceitas = new System.Windows.Forms.TextBox();
            this.textDataReceitas = new System.Windows.Forms.TextBox();
            this.botaoCadastrarReceitas2 = new System.Windows.Forms.Button();
            this.panelLateralFinanceiro.SuspendLayout();
            this.cadastrarDespesas.SuspendLayout();
            this.panelDespesas.SuspendLayout();
            this.panelReceitas.SuspendLayout();
            this.cadastrarReceitas.SuspendLayout();
            this.SuspendLayout();
            // 
            // botaoVoltarFinanceiro
            // 
            this.botaoVoltarFinanceiro.BackColor = System.Drawing.Color.White;
            this.botaoVoltarFinanceiro.BackgroundImage = global::SOS_Animal.Properties.Resources.botaoVoltar;
            this.botaoVoltarFinanceiro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.botaoVoltarFinanceiro.FlatAppearance.BorderSize = 0;
            this.botaoVoltarFinanceiro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.botaoVoltarFinanceiro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.botaoVoltarFinanceiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoVoltarFinanceiro.Location = new System.Drawing.Point(260, 0);
            this.botaoVoltarFinanceiro.Name = "botaoVoltarFinanceiro";
            this.botaoVoltarFinanceiro.Size = new System.Drawing.Size(44, 44);
            this.botaoVoltarFinanceiro.TabIndex = 8;
            this.botaoVoltarFinanceiro.UseVisualStyleBackColor = false;
            this.botaoVoltarFinanceiro.Click += new System.EventHandler(this.botaoVoltarFinanceiro_Click);
            // 
            // botaoFechar
            // 
            this.botaoFechar.BackColor = System.Drawing.Color.White;
            this.botaoFechar.BackgroundImage = global::SOS_Animal.Properties.Resources.botaoFechar;
            this.botaoFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.botaoFechar.FlatAppearance.BorderSize = 0;
            this.botaoFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.botaoFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(219)))));
            this.botaoFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoFechar.Location = new System.Drawing.Point(1137, 0);
            this.botaoFechar.Name = "botaoFechar";
            this.botaoFechar.Size = new System.Drawing.Size(44, 44);
            this.botaoFechar.TabIndex = 7;
            this.botaoFechar.UseVisualStyleBackColor = false;
            this.botaoFechar.Click += new System.EventHandler(this.botaoFechar_Click);
            // 
            // panelLateralFinanceiro
            // 
            this.panelLateralFinanceiro.BackgroundImage = global::SOS_Animal.Properties.Resources.painelLateralFinanceiro;
            this.panelLateralFinanceiro.Controls.Add(this.botaoCadastrarReceitas);
            this.panelLateralFinanceiro.Controls.Add(this.botaoCadastrarDespesas);
            this.panelLateralFinanceiro.Controls.Add(this.botaoReceitas);
            this.panelLateralFinanceiro.Controls.Add(this.botaoDespesas);
            this.panelLateralFinanceiro.Location = new System.Drawing.Point(0, 0);
            this.panelLateralFinanceiro.Name = "panelLateralFinanceiro";
            this.panelLateralFinanceiro.Size = new System.Drawing.Size(260, 660);
            this.panelLateralFinanceiro.TabIndex = 1;
            // 
            // botaoCadastrarReceitas
            // 
            this.botaoCadastrarReceitas.BackColor = System.Drawing.Color.Transparent;
            this.botaoCadastrarReceitas.BackgroundImage = global::SOS_Animal.Properties.Resources.cadastrarReceitas1;
            this.botaoCadastrarReceitas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.botaoCadastrarReceitas.FlatAppearance.BorderSize = 0;
            this.botaoCadastrarReceitas.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.botaoCadastrarReceitas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.botaoCadastrarReceitas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.botaoCadastrarReceitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoCadastrarReceitas.Location = new System.Drawing.Point(62, 454);
            this.botaoCadastrarReceitas.Name = "botaoCadastrarReceitas";
            this.botaoCadastrarReceitas.Size = new System.Drawing.Size(170, 60);
            this.botaoCadastrarReceitas.TabIndex = 3;
            this.botaoCadastrarReceitas.UseVisualStyleBackColor = false;
            this.botaoCadastrarReceitas.Click += new System.EventHandler(this.botaoCadastrarReceitas_Click);
            this.botaoCadastrarReceitas.MouseEnter += new System.EventHandler(this.botaoCadastrarReceitas_MouseEnter);
            this.botaoCadastrarReceitas.MouseLeave += new System.EventHandler(this.botaoCadastrarReceitas_MouseLeave);
            // 
            // botaoCadastrarDespesas
            // 
            this.botaoCadastrarDespesas.BackColor = System.Drawing.Color.Transparent;
            this.botaoCadastrarDespesas.BackgroundImage = global::SOS_Animal.Properties.Resources.cadastrarDespesas1;
            this.botaoCadastrarDespesas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.botaoCadastrarDespesas.FlatAppearance.BorderSize = 0;
            this.botaoCadastrarDespesas.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.botaoCadastrarDespesas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.botaoCadastrarDespesas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.botaoCadastrarDespesas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoCadastrarDespesas.Location = new System.Drawing.Point(62, 381);
            this.botaoCadastrarDespesas.Name = "botaoCadastrarDespesas";
            this.botaoCadastrarDespesas.Size = new System.Drawing.Size(170, 60);
            this.botaoCadastrarDespesas.TabIndex = 2;
            this.botaoCadastrarDespesas.UseVisualStyleBackColor = false;
            this.botaoCadastrarDespesas.Click += new System.EventHandler(this.botaoCadastrarDespesas_Click);
            this.botaoCadastrarDespesas.MouseEnter += new System.EventHandler(this.botaoCadastrarDespesas_MouseEnter);
            this.botaoCadastrarDespesas.MouseLeave += new System.EventHandler(this.botaoCadastrarDespesas_MouseLeave);
            // 
            // botaoReceitas
            // 
            this.botaoReceitas.BackColor = System.Drawing.Color.Transparent;
            this.botaoReceitas.BackgroundImage = global::SOS_Animal.Properties.Resources.botaoReceitas1;
            this.botaoReceitas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.botaoReceitas.FlatAppearance.BorderSize = 0;
            this.botaoReceitas.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.botaoReceitas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.botaoReceitas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.botaoReceitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoReceitas.Location = new System.Drawing.Point(62, 311);
            this.botaoReceitas.Name = "botaoReceitas";
            this.botaoReceitas.Size = new System.Drawing.Size(170, 60);
            this.botaoReceitas.TabIndex = 1;
            this.botaoReceitas.UseVisualStyleBackColor = false;
            this.botaoReceitas.Click += new System.EventHandler(this.botaoReceitas_Click);
            this.botaoReceitas.MouseEnter += new System.EventHandler(this.botaoReceitas_MouseEnter);
            this.botaoReceitas.MouseLeave += new System.EventHandler(this.botaoReceitas_MouseLeave);
            // 
            // botaoDespesas
            // 
            this.botaoDespesas.BackColor = System.Drawing.Color.Transparent;
            this.botaoDespesas.BackgroundImage = global::SOS_Animal.Properties.Resources.botaoDespesas1;
            this.botaoDespesas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.botaoDespesas.FlatAppearance.BorderSize = 0;
            this.botaoDespesas.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.botaoDespesas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.botaoDespesas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.botaoDespesas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoDespesas.Location = new System.Drawing.Point(62, 242);
            this.botaoDespesas.Name = "botaoDespesas";
            this.botaoDespesas.Size = new System.Drawing.Size(170, 60);
            this.botaoDespesas.TabIndex = 0;
            this.botaoDespesas.UseVisualStyleBackColor = false;
            this.botaoDespesas.Click += new System.EventHandler(this.botaoDespesas_Click);
            this.botaoDespesas.MouseEnter += new System.EventHandler(this.botaoDespesas_MouseEnter);
            this.botaoDespesas.MouseLeave += new System.EventHandler(this.botaoDespesas_MouseLeave);
            // 
            // cadastrarDespesas
            // 
            this.cadastrarDespesas.BackgroundImage = global::SOS_Animal.Properties.Resources.fundoCadastrarDespesas;
            this.cadastrarDespesas.Controls.Add(this.textDescricaoDespesas);
            this.cadastrarDespesas.Controls.Add(this.textValorDespesas);
            this.cadastrarDespesas.Controls.Add(this.textCategoriaDespesas);
            this.cadastrarDespesas.Controls.Add(this.textDataDespesas);
            this.cadastrarDespesas.Controls.Add(this.botaoCadastrarDespesas2);
            this.cadastrarDespesas.Location = new System.Drawing.Point(260, 0);
            this.cadastrarDespesas.Name = "cadastrarDespesas";
            this.cadastrarDespesas.Size = new System.Drawing.Size(920, 660);
            this.cadastrarDespesas.TabIndex = 10;
            // 
            // textDescricaoDespesas
            // 
            this.textDescricaoDespesas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textDescricaoDespesas.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold);
            this.textDescricaoDespesas.Location = new System.Drawing.Point(278, 466);
            this.textDescricaoDespesas.Name = "textDescricaoDespesas";
            this.textDescricaoDespesas.Size = new System.Drawing.Size(350, 31);
            this.textDescricaoDespesas.TabIndex = 11;
            this.textDescricaoDespesas.Text = "DESCRIÇÃO";
            this.textDescricaoDespesas.Enter += new System.EventHandler(this.textDescricaoDespesas_Enter);
            this.textDescricaoDespesas.Leave += new System.EventHandler(this.textDescricaoDespesas_Leave);
            // 
            // textValorDespesas
            // 
            this.textValorDespesas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textValorDespesas.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold);
            this.textValorDespesas.Location = new System.Drawing.Point(278, 377);
            this.textValorDespesas.Name = "textValorDespesas";
            this.textValorDespesas.Size = new System.Drawing.Size(350, 31);
            this.textValorDespesas.TabIndex = 10;
            this.textValorDespesas.Text = "VALOR";
            this.textValorDespesas.Enter += new System.EventHandler(this.textValorDespesas_Enter);
            this.textValorDespesas.Leave += new System.EventHandler(this.textValorDespesas_Leave);
            // 
            // textCategoriaDespesas
            // 
            this.textCategoriaDespesas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textCategoriaDespesas.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold);
            this.textCategoriaDespesas.Location = new System.Drawing.Point(278, 287);
            this.textCategoriaDespesas.Name = "textCategoriaDespesas";
            this.textCategoriaDespesas.Size = new System.Drawing.Size(350, 31);
            this.textCategoriaDespesas.TabIndex = 9;
            this.textCategoriaDespesas.Text = "CATEGORIA";
            this.textCategoriaDespesas.Enter += new System.EventHandler(this.textCategoriaDespesas_Enter);
            this.textCategoriaDespesas.Leave += new System.EventHandler(this.textCategoriaDespesas_Leave);
            // 
            // textDataDespesas
            // 
            this.textDataDespesas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textDataDespesas.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold);
            this.textDataDespesas.Location = new System.Drawing.Point(278, 191);
            this.textDataDespesas.Name = "textDataDespesas";
            this.textDataDespesas.Size = new System.Drawing.Size(350, 31);
            this.textDataDespesas.TabIndex = 8;
            this.textDataDespesas.Text = "DATA";
            this.textDataDespesas.Enter += new System.EventHandler(this.textDataDespesas_Enter);
            this.textDataDespesas.Leave += new System.EventHandler(this.textDataDespesas_Leave);
            // 
            // botaoCadastrarDespesas2
            // 
            this.botaoCadastrarDespesas2.BackColor = System.Drawing.Color.Transparent;
            this.botaoCadastrarDespesas2.BackgroundImage = global::SOS_Animal.Properties.Resources.botaoCadastrarCachorro1;
            this.botaoCadastrarDespesas2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.botaoCadastrarDespesas2.FlatAppearance.BorderSize = 0;
            this.botaoCadastrarDespesas2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.botaoCadastrarDespesas2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.botaoCadastrarDespesas2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoCadastrarDespesas2.Location = new System.Drawing.Point(365, 548);
            this.botaoCadastrarDespesas2.Name = "botaoCadastrarDespesas2";
            this.botaoCadastrarDespesas2.Size = new System.Drawing.Size(213, 67);
            this.botaoCadastrarDespesas2.TabIndex = 7;
            this.botaoCadastrarDespesas2.UseVisualStyleBackColor = false;
            this.botaoCadastrarDespesas2.Click += new System.EventHandler(this.botaoCadastrarDespesas2_Click);
            this.botaoCadastrarDespesas2.MouseEnter += new System.EventHandler(this.botaoCadastrarDespesas2_MouseEnter);
            this.botaoCadastrarDespesas2.MouseLeave += new System.EventHandler(this.botaoCadastrarDespesas2_MouseLeave);
            // 
            // panelDespesas
            // 
            this.panelDespesas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelDespesas.BackgroundImage")));
            this.panelDespesas.Controls.Add(this.btnOrdenarPorData);
            this.panelDespesas.Controls.Add(this.btnOrdenarDescricao);
            this.panelDespesas.Controls.Add(this.btnOrdenarPorValor);
            this.panelDespesas.Controls.Add(this.btnOrdenarPorCategoria);
            this.panelDespesas.Controls.Add(this.flowDespesas);
            this.panelDespesas.Location = new System.Drawing.Point(260, 0);
            this.panelDespesas.Name = "panelDespesas";
            this.panelDespesas.Size = new System.Drawing.Size(920, 660);
            this.panelDespesas.TabIndex = 9;
            // 
            // btnOrdenarPorData
            // 
            this.btnOrdenarPorData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(66)))));
            this.btnOrdenarPorData.BackgroundImage = global::SOS_Animal.Properties.Resources.filtro1;
            this.btnOrdenarPorData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnOrdenarPorData.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(66)))));
            this.btnOrdenarPorData.FlatAppearance.BorderSize = 0;
            this.btnOrdenarPorData.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnOrdenarPorData.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(66)))));
            this.btnOrdenarPorData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(66)))));
            this.btnOrdenarPorData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdenarPorData.Location = new System.Drawing.Point(96, 181);
            this.btnOrdenarPorData.Name = "btnOrdenarPorData";
            this.btnOrdenarPorData.Size = new System.Drawing.Size(20, 20);
            this.btnOrdenarPorData.TabIndex = 13;
            this.btnOrdenarPorData.UseVisualStyleBackColor = false;
            this.btnOrdenarPorData.Click += new System.EventHandler(this.btnOrdenarPorData_Click);
            // 
            // btnOrdenarDescricao
            // 
            this.btnOrdenarDescricao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(66)))));
            this.btnOrdenarDescricao.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOrdenarDescricao.BackgroundImage")));
            this.btnOrdenarDescricao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnOrdenarDescricao.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(66)))));
            this.btnOrdenarDescricao.FlatAppearance.BorderSize = 0;
            this.btnOrdenarDescricao.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnOrdenarDescricao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(66)))));
            this.btnOrdenarDescricao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(66)))));
            this.btnOrdenarDescricao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdenarDescricao.Location = new System.Drawing.Point(558, 181);
            this.btnOrdenarDescricao.Name = "btnOrdenarDescricao";
            this.btnOrdenarDescricao.Size = new System.Drawing.Size(20, 20);
            this.btnOrdenarDescricao.TabIndex = 12;
            this.btnOrdenarDescricao.UseVisualStyleBackColor = false;
            this.btnOrdenarDescricao.Click += new System.EventHandler(this.btnOrdenarDescricao_Click);
            // 
            // btnOrdenarPorValor
            // 
            this.btnOrdenarPorValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(66)))));
            this.btnOrdenarPorValor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOrdenarPorValor.BackgroundImage")));
            this.btnOrdenarPorValor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnOrdenarPorValor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(66)))));
            this.btnOrdenarPorValor.FlatAppearance.BorderSize = 0;
            this.btnOrdenarPorValor.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnOrdenarPorValor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(66)))));
            this.btnOrdenarPorValor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(66)))));
            this.btnOrdenarPorValor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdenarPorValor.Location = new System.Drawing.Point(379, 181);
            this.btnOrdenarPorValor.Name = "btnOrdenarPorValor";
            this.btnOrdenarPorValor.Size = new System.Drawing.Size(20, 20);
            this.btnOrdenarPorValor.TabIndex = 11;
            this.btnOrdenarPorValor.UseVisualStyleBackColor = false;
            this.btnOrdenarPorValor.Click += new System.EventHandler(this.btnOrdenarPorValor_Click);
            // 
            // btnOrdenarPorCategoria
            // 
            this.btnOrdenarPorCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(66)))));
            this.btnOrdenarPorCategoria.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOrdenarPorCategoria.BackgroundImage")));
            this.btnOrdenarPorCategoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnOrdenarPorCategoria.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(66)))));
            this.btnOrdenarPorCategoria.FlatAppearance.BorderSize = 0;
            this.btnOrdenarPorCategoria.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnOrdenarPorCategoria.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(66)))));
            this.btnOrdenarPorCategoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(66)))));
            this.btnOrdenarPorCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdenarPorCategoria.Location = new System.Drawing.Point(210, 181);
            this.btnOrdenarPorCategoria.Name = "btnOrdenarPorCategoria";
            this.btnOrdenarPorCategoria.Size = new System.Drawing.Size(20, 20);
            this.btnOrdenarPorCategoria.TabIndex = 10;
            this.btnOrdenarPorCategoria.UseVisualStyleBackColor = false;
            this.btnOrdenarPorCategoria.Click += new System.EventHandler(this.btnOrdenarPorCategoria_Click);
            // 
            // flowDespesas
            // 
            this.flowDespesas.AutoScroll = true;
            this.flowDespesas.BackColor = System.Drawing.Color.Transparent;
            this.flowDespesas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.flowDespesas.Location = new System.Drawing.Point(55, 215);
            this.flowDespesas.Name = "flowDespesas";
            this.flowDespesas.Size = new System.Drawing.Size(822, 400);
            this.flowDespesas.TabIndex = 1;
            // 
            // panelReceitas
            // 
            this.panelReceitas.BackgroundImage = global::SOS_Animal.Properties.Resources.fundoReceitas;
            this.panelReceitas.Controls.Add(this.btnOrdenarPorDataReceitas);
            this.panelReceitas.Controls.Add(this.btnOrdenarPorDescricaoReceitas);
            this.panelReceitas.Controls.Add(this.btnOrdenarPorValorReceitas);
            this.panelReceitas.Controls.Add(this.btnOrdenarPorCategoriaReceitas);
            this.panelReceitas.Controls.Add(this.flowReceitas);
            this.panelReceitas.Location = new System.Drawing.Point(260, 0);
            this.panelReceitas.Name = "panelReceitas";
            this.panelReceitas.Size = new System.Drawing.Size(920, 660);
            this.panelReceitas.TabIndex = 11;
            // 
            // btnOrdenarPorDataReceitas
            // 
            this.btnOrdenarPorDataReceitas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(66)))));
            this.btnOrdenarPorDataReceitas.BackgroundImage = global::SOS_Animal.Properties.Resources.filtro1;
            this.btnOrdenarPorDataReceitas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnOrdenarPorDataReceitas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(66)))));
            this.btnOrdenarPorDataReceitas.FlatAppearance.BorderSize = 0;
            this.btnOrdenarPorDataReceitas.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnOrdenarPorDataReceitas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(66)))));
            this.btnOrdenarPorDataReceitas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(66)))));
            this.btnOrdenarPorDataReceitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdenarPorDataReceitas.Location = new System.Drawing.Point(96, 181);
            this.btnOrdenarPorDataReceitas.Name = "btnOrdenarPorDataReceitas";
            this.btnOrdenarPorDataReceitas.Size = new System.Drawing.Size(20, 20);
            this.btnOrdenarPorDataReceitas.TabIndex = 17;
            this.btnOrdenarPorDataReceitas.UseVisualStyleBackColor = false;
            // 
            // btnOrdenarPorDescricaoReceitas
            // 
            this.btnOrdenarPorDescricaoReceitas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(66)))));
            this.btnOrdenarPorDescricaoReceitas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOrdenarPorDescricaoReceitas.BackgroundImage")));
            this.btnOrdenarPorDescricaoReceitas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnOrdenarPorDescricaoReceitas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(66)))));
            this.btnOrdenarPorDescricaoReceitas.FlatAppearance.BorderSize = 0;
            this.btnOrdenarPorDescricaoReceitas.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnOrdenarPorDescricaoReceitas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(66)))));
            this.btnOrdenarPorDescricaoReceitas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(66)))));
            this.btnOrdenarPorDescricaoReceitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdenarPorDescricaoReceitas.Location = new System.Drawing.Point(558, 181);
            this.btnOrdenarPorDescricaoReceitas.Name = "btnOrdenarPorDescricaoReceitas";
            this.btnOrdenarPorDescricaoReceitas.Size = new System.Drawing.Size(20, 20);
            this.btnOrdenarPorDescricaoReceitas.TabIndex = 16;
            this.btnOrdenarPorDescricaoReceitas.UseVisualStyleBackColor = false;
            // 
            // btnOrdenarPorValorReceitas
            // 
            this.btnOrdenarPorValorReceitas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(66)))));
            this.btnOrdenarPorValorReceitas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOrdenarPorValorReceitas.BackgroundImage")));
            this.btnOrdenarPorValorReceitas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnOrdenarPorValorReceitas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(66)))));
            this.btnOrdenarPorValorReceitas.FlatAppearance.BorderSize = 0;
            this.btnOrdenarPorValorReceitas.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnOrdenarPorValorReceitas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(66)))));
            this.btnOrdenarPorValorReceitas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(66)))));
            this.btnOrdenarPorValorReceitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdenarPorValorReceitas.Location = new System.Drawing.Point(379, 181);
            this.btnOrdenarPorValorReceitas.Name = "btnOrdenarPorValorReceitas";
            this.btnOrdenarPorValorReceitas.Size = new System.Drawing.Size(20, 20);
            this.btnOrdenarPorValorReceitas.TabIndex = 15;
            this.btnOrdenarPorValorReceitas.UseVisualStyleBackColor = false;
            // 
            // btnOrdenarPorCategoriaReceitas
            // 
            this.btnOrdenarPorCategoriaReceitas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(66)))));
            this.btnOrdenarPorCategoriaReceitas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOrdenarPorCategoriaReceitas.BackgroundImage")));
            this.btnOrdenarPorCategoriaReceitas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnOrdenarPorCategoriaReceitas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(66)))));
            this.btnOrdenarPorCategoriaReceitas.FlatAppearance.BorderSize = 0;
            this.btnOrdenarPorCategoriaReceitas.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnOrdenarPorCategoriaReceitas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(66)))));
            this.btnOrdenarPorCategoriaReceitas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(66)))));
            this.btnOrdenarPorCategoriaReceitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdenarPorCategoriaReceitas.Location = new System.Drawing.Point(210, 181);
            this.btnOrdenarPorCategoriaReceitas.Name = "btnOrdenarPorCategoriaReceitas";
            this.btnOrdenarPorCategoriaReceitas.Size = new System.Drawing.Size(20, 20);
            this.btnOrdenarPorCategoriaReceitas.TabIndex = 14;
            this.btnOrdenarPorCategoriaReceitas.UseVisualStyleBackColor = false;
            // 
            // flowReceitas
            // 
            this.flowReceitas.AutoScroll = true;
            this.flowReceitas.BackColor = System.Drawing.Color.Transparent;
            this.flowReceitas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.flowReceitas.Location = new System.Drawing.Point(55, 215);
            this.flowReceitas.Name = "flowReceitas";
            this.flowReceitas.Size = new System.Drawing.Size(822, 400);
            this.flowReceitas.TabIndex = 2;
            // 
            // cadastrarReceitas
            // 
            this.cadastrarReceitas.BackgroundImage = global::SOS_Animal.Properties.Resources.fundoCadastrarReceitas;
            this.cadastrarReceitas.Controls.Add(this.textDescricaoReceitas);
            this.cadastrarReceitas.Controls.Add(this.textValorReceitas);
            this.cadastrarReceitas.Controls.Add(this.textCategoriaReceitas);
            this.cadastrarReceitas.Controls.Add(this.textDataReceitas);
            this.cadastrarReceitas.Controls.Add(this.botaoCadastrarReceitas2);
            this.cadastrarReceitas.Location = new System.Drawing.Point(260, 0);
            this.cadastrarReceitas.Name = "cadastrarReceitas";
            this.cadastrarReceitas.Size = new System.Drawing.Size(920, 660);
            this.cadastrarReceitas.TabIndex = 12;
            // 
            // textDescricaoReceitas
            // 
            this.textDescricaoReceitas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textDescricaoReceitas.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold);
            this.textDescricaoReceitas.Location = new System.Drawing.Point(278, 466);
            this.textDescricaoReceitas.Name = "textDescricaoReceitas";
            this.textDescricaoReceitas.Size = new System.Drawing.Size(350, 31);
            this.textDescricaoReceitas.TabIndex = 15;
            this.textDescricaoReceitas.Text = "DESCRIÇÃO";
            this.textDescricaoReceitas.Enter += new System.EventHandler(this.textDescricaoReceitas_Enter);
            this.textDescricaoReceitas.Leave += new System.EventHandler(this.textDescricaoReceitas_Leave);
            // 
            // textValorReceitas
            // 
            this.textValorReceitas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textValorReceitas.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold);
            this.textValorReceitas.Location = new System.Drawing.Point(278, 377);
            this.textValorReceitas.Name = "textValorReceitas";
            this.textValorReceitas.Size = new System.Drawing.Size(350, 31);
            this.textValorReceitas.TabIndex = 14;
            this.textValorReceitas.Text = "VALOR";
            this.textValorReceitas.Enter += new System.EventHandler(this.textValorReceitas_Enter);
            this.textValorReceitas.Leave += new System.EventHandler(this.textValorReceitas_Leave);
            // 
            // textCategoriaReceitas
            // 
            this.textCategoriaReceitas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textCategoriaReceitas.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold);
            this.textCategoriaReceitas.Location = new System.Drawing.Point(278, 287);
            this.textCategoriaReceitas.Name = "textCategoriaReceitas";
            this.textCategoriaReceitas.Size = new System.Drawing.Size(350, 31);
            this.textCategoriaReceitas.TabIndex = 13;
            this.textCategoriaReceitas.Text = "CATEGORIA";
            this.textCategoriaReceitas.Enter += new System.EventHandler(this.textCategoriaReceitas_Enter);
            this.textCategoriaReceitas.Leave += new System.EventHandler(this.textCategoriaReceitas_Leave);
            // 
            // textDataReceitas
            // 
            this.textDataReceitas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textDataReceitas.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold);
            this.textDataReceitas.Location = new System.Drawing.Point(278, 191);
            this.textDataReceitas.Name = "textDataReceitas";
            this.textDataReceitas.Size = new System.Drawing.Size(350, 31);
            this.textDataReceitas.TabIndex = 12;
            this.textDataReceitas.Text = "DATA";
            this.textDataReceitas.Enter += new System.EventHandler(this.textDataReceitas_Enter);
            this.textDataReceitas.Leave += new System.EventHandler(this.textDataReceitas_Leave);
            // 
            // botaoCadastrarReceitas2
            // 
            this.botaoCadastrarReceitas2.BackColor = System.Drawing.Color.Transparent;
            this.botaoCadastrarReceitas2.BackgroundImage = global::SOS_Animal.Properties.Resources.botaoCadastrarCachorro1;
            this.botaoCadastrarReceitas2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.botaoCadastrarReceitas2.FlatAppearance.BorderSize = 0;
            this.botaoCadastrarReceitas2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.botaoCadastrarReceitas2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.botaoCadastrarReceitas2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoCadastrarReceitas2.Location = new System.Drawing.Point(365, 548);
            this.botaoCadastrarReceitas2.Name = "botaoCadastrarReceitas2";
            this.botaoCadastrarReceitas2.Size = new System.Drawing.Size(213, 67);
            this.botaoCadastrarReceitas2.TabIndex = 6;
            this.botaoCadastrarReceitas2.UseVisualStyleBackColor = false;
            this.botaoCadastrarReceitas2.Click += new System.EventHandler(this.botaoCadastrarReceitas2_Click);
            this.botaoCadastrarReceitas2.MouseEnter += new System.EventHandler(this.botaoCadastrarReceitas2_MouseEnter);
            this.botaoCadastrarReceitas2.MouseLeave += new System.EventHandler(this.botaoCadastrarReceitas2_MouseLeave);
            // 
            // TelaFinanceiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 660);
            this.Controls.Add(this.botaoVoltarFinanceiro);
            this.Controls.Add(this.botaoFechar);
            this.Controls.Add(this.panelLateralFinanceiro);
            this.Controls.Add(this.cadastrarReceitas);
            this.Controls.Add(this.cadastrarDespesas);
            this.Controls.Add(this.panelDespesas);
            this.Controls.Add(this.panelReceitas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaFinanceiro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaFinanceiro";
            this.Load += new System.EventHandler(this.TelaFinanceiro_Load);
            this.panelLateralFinanceiro.ResumeLayout(false);
            this.cadastrarDespesas.ResumeLayout(false);
            this.cadastrarDespesas.PerformLayout();
            this.panelDespesas.ResumeLayout(false);
            this.panelReceitas.ResumeLayout(false);
            this.cadastrarReceitas.ResumeLayout(false);
            this.cadastrarReceitas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLateralFinanceiro;
        private System.Windows.Forms.Button botaoReceitas;
        private System.Windows.Forms.Button botaoDespesas;
        private System.Windows.Forms.Button botaoVoltarFinanceiro;
        private System.Windows.Forms.Button botaoFechar;
        private System.Windows.Forms.Panel panelDespesas;
        private System.Windows.Forms.Panel cadastrarDespesas;
        private System.Windows.Forms.Panel panelReceitas;
        private System.Windows.Forms.FlowLayoutPanel flowDespesas;
        private System.Windows.Forms.FlowLayoutPanel flowReceitas;
        private System.Windows.Forms.Button btnOrdenarPorData;
        private System.Windows.Forms.Button btnOrdenarDescricao;
        private System.Windows.Forms.Button btnOrdenarPorValor;
        private System.Windows.Forms.Button btnOrdenarPorCategoria;
        private System.Windows.Forms.Panel cadastrarReceitas;
        private System.Windows.Forms.Button botaoCadastrarReceitas;
        private System.Windows.Forms.Button botaoCadastrarDespesas;
        private System.Windows.Forms.Button botaoCadastrarReceitas2;
        private System.Windows.Forms.Button botaoCadastrarDespesas2;
        private System.Windows.Forms.TextBox textDescricaoDespesas;
        private System.Windows.Forms.TextBox textValorDespesas;
        private System.Windows.Forms.TextBox textCategoriaDespesas;
        private System.Windows.Forms.TextBox textDataDespesas;
        private System.Windows.Forms.TextBox textDescricaoReceitas;
        private System.Windows.Forms.TextBox textValorReceitas;
        private System.Windows.Forms.TextBox textCategoriaReceitas;
        private System.Windows.Forms.TextBox textDataReceitas;
        private System.Windows.Forms.Button btnOrdenarPorDataReceitas;
        private System.Windows.Forms.Button btnOrdenarPorDescricaoReceitas;
        private System.Windows.Forms.Button btnOrdenarPorValorReceitas;
        private System.Windows.Forms.Button btnOrdenarPorCategoriaReceitas;
    }
}