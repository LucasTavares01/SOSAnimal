namespace SOS_Animal
{
    partial class TelaEscolhaFinanceiro
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
            this.botaoReceitas = new System.Windows.Forms.Button();
            this.botaoDespesas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botaoReceitas
            // 
            this.botaoReceitas.BackColor = System.Drawing.Color.Transparent;
            this.botaoReceitas.BackgroundImage = global::SOS_Animal.Properties.Resources.botaoReceitas1;
            this.botaoReceitas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.botaoReceitas.FlatAppearance.BorderSize = 0;
            this.botaoReceitas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.botaoReceitas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.botaoReceitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoReceitas.Location = new System.Drawing.Point(235, 207);
            this.botaoReceitas.Name = "botaoReceitas";
            this.botaoReceitas.Size = new System.Drawing.Size(280, 280);
            this.botaoReceitas.TabIndex = 0;
            this.botaoReceitas.UseVisualStyleBackColor = false;
            this.botaoReceitas.MouseEnter += new System.EventHandler(this.botaoReceitas_MouseEnter);
            this.botaoReceitas.MouseLeave += new System.EventHandler(this.botaoReceitas_MouseLeave);
            // 
            // botaoDespesas
            // 
            this.botaoDespesas.BackColor = System.Drawing.Color.Transparent;
            this.botaoDespesas.BackgroundImage = global::SOS_Animal.Properties.Resources.botaoDespesas1;
            this.botaoDespesas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.botaoDespesas.FlatAppearance.BorderSize = 0;
            this.botaoDespesas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.botaoDespesas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.botaoDespesas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoDespesas.Location = new System.Drawing.Point(670, 207);
            this.botaoDespesas.Name = "botaoDespesas";
            this.botaoDespesas.Size = new System.Drawing.Size(280, 280);
            this.botaoDespesas.TabIndex = 1;
            this.botaoDespesas.UseVisualStyleBackColor = false;
            this.botaoDespesas.MouseEnter += new System.EventHandler(this.botaoDespesas_MouseEnter);
            this.botaoDespesas.MouseLeave += new System.EventHandler(this.botaoDespesas_MouseLeave);
            // 
            // TelaEscolhaFinanceiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SOS_Animal.Properties.Resources.TelaEscolhaFinanceiro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1180, 660);
            this.Controls.Add(this.botaoDespesas);
            this.Controls.Add(this.botaoReceitas);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaEscolhaFinanceiro";
            this.Text = "TelaEscolhaFinanceiro";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botaoReceitas;
        private System.Windows.Forms.Button botaoDespesas;
    }
}