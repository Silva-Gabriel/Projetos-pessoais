﻿
namespace ProjetoLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaLogin));
            this.panellogin = new System.Windows.Forms.Panel();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.BotaoAutenticar = new System.Windows.Forms.Button();
            this.panelCriarConta = new System.Windows.Forms.Panel();
            this.CriarConta = new System.Windows.Forms.LinkLabel();
            this.lblCadastro = new System.Windows.Forms.Label();
            this.lblBoasVindas = new System.Windows.Forms.Label();
            this.panelAutentica = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panellogin.SuspendLayout();
            this.panelCriarConta.SuspendLayout();
            this.panelAutentica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panellogin
            // 
            this.panellogin.BackColor = System.Drawing.Color.Transparent;
            this.panellogin.Controls.Add(this.lblSenha);
            this.panellogin.Controls.Add(this.lblEmail);
            this.panellogin.Controls.Add(this.txtSenha);
            this.panellogin.Controls.Add(this.txtEmail);
            this.panellogin.Location = new System.Drawing.Point(286, 133);
            this.panellogin.Name = "panellogin";
            this.panellogin.Size = new System.Drawing.Size(400, 148);
            this.panellogin.TabIndex = 6;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.Color.Yellow;
            this.lblSenha.Location = new System.Drawing.Point(3, 104);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(92, 28);
            this.lblSenha.TabIndex = 1;
            this.lblSenha.Text = "Senha:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.Yellow;
            this.lblEmail.Location = new System.Drawing.Point(11, 21);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(84, 28);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email:";
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.SystemColors.Info;
            this.txtSenha.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(101, 97);
            this.txtSenha.Multiline = true;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(278, 35);
            this.txtSenha.TabIndex = 1;
            this.txtSenha.Tag = "";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Info;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(101, 13);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(278, 36);
            this.txtEmail.TabIndex = 0;
            // 
            // BotaoAutenticar
            // 
            this.BotaoAutenticar.BackColor = System.Drawing.Color.Blue;
            this.BotaoAutenticar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BotaoAutenticar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotaoAutenticar.ForeColor = System.Drawing.Color.White;
            this.BotaoAutenticar.Location = new System.Drawing.Point(38, 13);
            this.BotaoAutenticar.Name = "BotaoAutenticar";
            this.BotaoAutenticar.Size = new System.Drawing.Size(110, 47);
            this.BotaoAutenticar.TabIndex = 2;
            this.BotaoAutenticar.Text = "Entrar";
            this.BotaoAutenticar.UseVisualStyleBackColor = false;
            this.BotaoAutenticar.Click += new System.EventHandler(this.BotaoAutenticar_Click);
            // 
            // panelCriarConta
            // 
            this.panelCriarConta.BackColor = System.Drawing.Color.Transparent;
            this.panelCriarConta.Controls.Add(this.CriarConta);
            this.panelCriarConta.Controls.Add(this.lblCadastro);
            this.panelCriarConta.Location = new System.Drawing.Point(344, 409);
            this.panelCriarConta.Name = "panelCriarConta";
            this.panelCriarConta.Size = new System.Drawing.Size(342, 46);
            this.panelCriarConta.TabIndex = 8;
            // 
            // CriarConta
            // 
            this.CriarConta.ActiveLinkColor = System.Drawing.Color.Gray;
            this.CriarConta.AutoSize = true;
            this.CriarConta.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CriarConta.LinkColor = System.Drawing.Color.Lime;
            this.CriarConta.Location = new System.Drawing.Point(188, 13);
            this.CriarConta.Name = "CriarConta";
            this.CriarConta.Size = new System.Drawing.Size(95, 23);
            this.CriarConta.TabIndex = 3;
            this.CriarConta.TabStop = true;
            this.CriarConta.Text = "Cadastre-se";
            this.CriarConta.VisitedLinkColor = System.Drawing.Color.Red;
            this.CriarConta.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CriarConta_LinkClicked);
            // 
            // lblCadastro
            // 
            this.lblCadastro.AutoSize = true;
            this.lblCadastro.BackColor = System.Drawing.Color.Transparent;
            this.lblCadastro.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastro.ForeColor = System.Drawing.Color.White;
            this.lblCadastro.Location = new System.Drawing.Point(28, 13);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(154, 23);
            this.lblCadastro.TabIndex = 5;
            this.lblCadastro.Text = "Não tem uma conta?";
            // 
            // lblBoasVindas
            // 
            this.lblBoasVindas.AutoSize = true;
            this.lblBoasVindas.BackColor = System.Drawing.Color.Transparent;
            this.lblBoasVindas.Font = new System.Drawing.Font("Algerian", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoasVindas.ForeColor = System.Drawing.Color.White;
            this.lblBoasVindas.Location = new System.Drawing.Point(161, 35);
            this.lblBoasVindas.Name = "lblBoasVindas";
            this.lblBoasVindas.Size = new System.Drawing.Size(365, 41);
            this.lblBoasVindas.TabIndex = 4;
            this.lblBoasVindas.Text = "BEM-VINDO AO GBX";
            // 
            // panelAutentica
            // 
            this.panelAutentica.BackColor = System.Drawing.Color.Transparent;
            this.panelAutentica.Controls.Add(this.BotaoAutenticar);
            this.panelAutentica.Location = new System.Drawing.Point(425, 304);
            this.panelAutentica.Name = "panelAutentica";
            this.panelAutentica.Size = new System.Drawing.Size(179, 73);
            this.panelAutentica.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::ProjetoLogin.Properties.Resources.unnamed;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 260);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 215);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // TelaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoLogin.Properties.Resources.gamer;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(740, 478);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelAutentica);
            this.Controls.Add(this.lblBoasVindas);
            this.Controls.Add(this.panelCriarConta);
            this.Controls.Add(this.panellogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaLogin";
            this.Text = "Login screen";
            this.panellogin.ResumeLayout(false);
            this.panellogin.PerformLayout();
            this.panelCriarConta.ResumeLayout(false);
            this.panelCriarConta.PerformLayout();
            this.panelAutentica.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panellogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button BotaoAutenticar;
        private System.Windows.Forms.Panel panelCriarConta;
        private System.Windows.Forms.LinkLabel CriarConta;
        private System.Windows.Forms.Label lblCadastro;
        private System.Windows.Forms.Label lblBoasVindas;
        private System.Windows.Forms.Panel panelAutentica;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

