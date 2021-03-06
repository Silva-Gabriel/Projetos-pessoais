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
            this.cBoxMostrarSenha = new System.Windows.Forms.CheckBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.BotaoAutenticar = new System.Windows.Forms.Button();
            this.panelCriarConta = new System.Windows.Forms.Panel();
            this.CriarConta = new System.Windows.Forms.LinkLabel();
            this.lblCadastro = new System.Windows.Forms.Label();
            this.lblBoasVindas = new System.Windows.Forms.Label();
            this.panelAutentica = new System.Windows.Forms.Panel();
            this.panellogin.SuspendLayout();
            this.panelCriarConta.SuspendLayout();
            this.panelAutentica.SuspendLayout();
            this.SuspendLayout();
            // 
            // panellogin
            // 
            this.panellogin.BackColor = System.Drawing.Color.Transparent;
            this.panellogin.Controls.Add(this.cBoxMostrarSenha);
            this.panellogin.Controls.Add(this.txtSenha);
            this.panellogin.Controls.Add(this.txtEmail);
            this.panellogin.Location = new System.Drawing.Point(155, 126);
            this.panellogin.Name = "panellogin";
            this.panellogin.Size = new System.Drawing.Size(299, 161);
            this.panellogin.TabIndex = 6;
            // 
            // cBoxMostrarSenha
            // 
            this.cBoxMostrarSenha.AutoSize = true;
            this.cBoxMostrarSenha.BackColor = System.Drawing.Color.Transparent;
            this.cBoxMostrarSenha.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxMostrarSenha.ForeColor = System.Drawing.Color.White;
            this.cBoxMostrarSenha.Location = new System.Drawing.Point(159, 126);
            this.cBoxMostrarSenha.Name = "cBoxMostrarSenha";
            this.cBoxMostrarSenha.Size = new System.Drawing.Size(112, 24);
            this.cBoxMostrarSenha.TabIndex = 10;
            this.cBoxMostrarSenha.Text = "Mostrar senha";
            this.cBoxMostrarSenha.UseVisualStyleBackColor = false;
            this.cBoxMostrarSenha.CheckedChanged += new System.EventHandler(this.cBoxMostrarSenha_CheckedChanged);
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.White;
            this.txtSenha.Font = new System.Drawing.Font("Snap ITC", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(6, 86);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(265, 34);
            this.txtSenha.TabIndex = 2;
            this.txtSenha.Tag = "";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.Font = new System.Drawing.Font("Snap ITC", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(6, 18);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(265, 34);
            this.txtEmail.TabIndex = 1;
            // 
            // BotaoAutenticar
            // 
            this.BotaoAutenticar.BackColor = System.Drawing.Color.Blue;
            this.BotaoAutenticar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BotaoAutenticar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotaoAutenticar.ForeColor = System.Drawing.Color.White;
            this.BotaoAutenticar.Location = new System.Drawing.Point(6, 3);
            this.BotaoAutenticar.Name = "BotaoAutenticar";
            this.BotaoAutenticar.Size = new System.Drawing.Size(265, 47);
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
            this.panelCriarConta.Location = new System.Drawing.Point(107, 383);
            this.panelCriarConta.Name = "panelCriarConta";
            this.panelCriarConta.Size = new System.Drawing.Size(380, 46);
            this.panelCriarConta.TabIndex = 8;
            // 
            // CriarConta
            // 
            this.CriarConta.ActiveLinkColor = System.Drawing.Color.Gray;
            this.CriarConta.AutoSize = true;
            this.CriarConta.Font = new System.Drawing.Font("Arial Black", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CriarConta.LinkColor = System.Drawing.Color.Lime;
            this.CriarConta.Location = new System.Drawing.Point(230, 9);
            this.CriarConta.Name = "CriarConta";
            this.CriarConta.Size = new System.Drawing.Size(138, 27);
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
            this.lblCadastro.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastro.ForeColor = System.Drawing.Color.White;
            this.lblCadastro.Location = new System.Drawing.Point(3, 9);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(229, 27);
            this.lblCadastro.TabIndex = 5;
            this.lblCadastro.Text = "Não tem uma conta?";
            // 
            // lblBoasVindas
            // 
            this.lblBoasVindas.AutoSize = true;
            this.lblBoasVindas.BackColor = System.Drawing.Color.Transparent;
            this.lblBoasVindas.Font = new System.Drawing.Font("Algerian", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoasVindas.ForeColor = System.Drawing.Color.Black;
            this.lblBoasVindas.Location = new System.Drawing.Point(100, 40);
            this.lblBoasVindas.Name = "lblBoasVindas";
            this.lblBoasVindas.Size = new System.Drawing.Size(365, 41);
            this.lblBoasVindas.TabIndex = 4;
            this.lblBoasVindas.Text = "BEM-VINDO AO GBX";
            // 
            // panelAutentica
            // 
            this.panelAutentica.BackColor = System.Drawing.Color.Transparent;
            this.panelAutentica.Controls.Add(this.BotaoAutenticar);
            this.panelAutentica.Location = new System.Drawing.Point(155, 293);
            this.panelAutentica.Name = "panelAutentica";
            this.panelAutentica.Size = new System.Drawing.Size(299, 57);
            this.panelAutentica.TabIndex = 7;
            // 
            // TelaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::ProjetoLogin.Properties.Resources.login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(559, 429);
            this.Controls.Add(this.panelAutentica);
            this.Controls.Add(this.lblBoasVindas);
            this.Controls.Add(this.panelCriarConta);
            this.Controls.Add(this.panellogin);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login screen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TelaLogin_FormClosing);
            this.panellogin.ResumeLayout(false);
            this.panellogin.PerformLayout();
            this.panelCriarConta.ResumeLayout(false);
            this.panelCriarConta.PerformLayout();
            this.panelAutentica.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panellogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button BotaoAutenticar;
        private System.Windows.Forms.Panel panelCriarConta;
        private System.Windows.Forms.LinkLabel CriarConta;
        private System.Windows.Forms.Label lblCadastro;
        private System.Windows.Forms.Label lblBoasVindas;
        private System.Windows.Forms.Panel panelAutentica;
        private System.Windows.Forms.CheckBox cBoxMostrarSenha;
    }
}

