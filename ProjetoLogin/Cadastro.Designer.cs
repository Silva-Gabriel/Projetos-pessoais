
namespace ProjetoLogin
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
            this.lblCadastro = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSobrenome = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCriarSenha = new System.Windows.Forms.Label();
            this.DataNascimento = new System.Windows.Forms.DateTimePicker();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.radMasculino = new System.Windows.Forms.RadioButton();
            this.radFeminino = new System.Windows.Forms.RadioButton();
            this.radPersonalizado = new System.Windows.Forms.RadioButton();
            this.txtGeneroPerso = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblCodigoADM = new System.Windows.Forms.Label();
            this.txtCodigoADM = new System.Windows.Forms.TextBox();
            this.BotaoCadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCadastro
            // 
            this.lblCadastro.AutoSize = true;
            this.lblCadastro.BackColor = System.Drawing.Color.Transparent;
            this.lblCadastro.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastro.ForeColor = System.Drawing.Color.Lime;
            this.lblCadastro.Location = new System.Drawing.Point(138, 31);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(237, 40);
            this.lblCadastro.TabIndex = 0;
            this.lblCadastro.Text = "Crie sua conta";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(12, 116);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(66, 25);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            // 
            // lblSobrenome
            // 
            this.lblSobrenome.AutoSize = true;
            this.lblSobrenome.BackColor = System.Drawing.Color.Transparent;
            this.lblSobrenome.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSobrenome.ForeColor = System.Drawing.Color.White;
            this.lblSobrenome.Location = new System.Drawing.Point(216, 117);
            this.lblSobrenome.Name = "lblSobrenome";
            this.lblSobrenome.Size = new System.Drawing.Size(115, 25);
            this.lblSobrenome.TabIndex = 2;
            this.lblSobrenome.Text = "Sobrenome:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(12, 173);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(64, 25);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email:";
            // 
            // lblCriarSenha
            // 
            this.lblCriarSenha.AutoSize = true;
            this.lblCriarSenha.BackColor = System.Drawing.Color.Transparent;
            this.lblCriarSenha.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriarSenha.ForeColor = System.Drawing.Color.White;
            this.lblCriarSenha.Location = new System.Drawing.Point(7, 237);
            this.lblCriarSenha.Name = "lblCriarSenha";
            this.lblCriarSenha.Size = new System.Drawing.Size(71, 25);
            this.lblCriarSenha.TabIndex = 2;
            this.lblCriarSenha.Text = "Senha:";
            // 
            // DataNascimento
            // 
            this.DataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DataNascimento.Location = new System.Drawing.Point(206, 334);
            this.DataNascimento.Name = "DataNascimento";
            this.DataNascimento.Size = new System.Drawing.Size(103, 20);
            this.DataNascimento.TabIndex = 3;
            this.DataNascimento.Value = new System.DateTime(2021, 4, 11, 0, 0, 0, 0);
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.BackColor = System.Drawing.Color.Transparent;
            this.lblDataNascimento.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataNascimento.ForeColor = System.Drawing.Color.White;
            this.lblDataNascimento.Location = new System.Drawing.Point(5, 329);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(186, 25);
            this.lblDataNascimento.TabIndex = 4;
            this.lblDataNascimento.Text = "Data de nascimento:";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.BackColor = System.Drawing.Color.Transparent;
            this.lblGenero.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.ForeColor = System.Drawing.Color.White;
            this.lblGenero.Location = new System.Drawing.Point(5, 370);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(80, 25);
            this.lblGenero.TabIndex = 5;
            this.lblGenero.Text = "Gênero:";
            // 
            // radMasculino
            // 
            this.radMasculino.AutoSize = true;
            this.radMasculino.BackColor = System.Drawing.Color.Transparent;
            this.radMasculino.Location = new System.Drawing.Point(91, 378);
            this.radMasculino.Name = "radMasculino";
            this.radMasculino.Size = new System.Drawing.Size(73, 17);
            this.radMasculino.TabIndex = 6;
            this.radMasculino.TabStop = true;
            this.radMasculino.Text = "Masculino";
            this.radMasculino.UseVisualStyleBackColor = false;
            this.radMasculino.CheckedChanged += new System.EventHandler(this.radMasculino_CheckedChanged);
            // 
            // radFeminino
            // 
            this.radFeminino.AutoSize = true;
            this.radFeminino.BackColor = System.Drawing.Color.Transparent;
            this.radFeminino.Location = new System.Drawing.Point(182, 378);
            this.radFeminino.Name = "radFeminino";
            this.radFeminino.Size = new System.Drawing.Size(67, 17);
            this.radFeminino.TabIndex = 7;
            this.radFeminino.TabStop = true;
            this.radFeminino.Text = "Feminino";
            this.radFeminino.UseVisualStyleBackColor = false;
            this.radFeminino.CheckedChanged += new System.EventHandler(this.radFeminino_CheckedChanged);
            // 
            // radPersonalizado
            // 
            this.radPersonalizado.AutoSize = true;
            this.radPersonalizado.BackColor = System.Drawing.Color.Transparent;
            this.radPersonalizado.Location = new System.Drawing.Point(267, 378);
            this.radPersonalizado.Name = "radPersonalizado";
            this.radPersonalizado.Size = new System.Drawing.Size(91, 17);
            this.radPersonalizado.TabIndex = 8;
            this.radPersonalizado.TabStop = true;
            this.radPersonalizado.Text = "Personalizado";
            this.radPersonalizado.UseVisualStyleBackColor = false;
            this.radPersonalizado.CheckedChanged += new System.EventHandler(this.radPersonalizado_CheckedChanged);
            // 
            // txtGeneroPerso
            // 
            this.txtGeneroPerso.Location = new System.Drawing.Point(161, 412);
            this.txtGeneroPerso.Name = "txtGeneroPerso";
            this.txtGeneroPerso.Size = new System.Drawing.Size(148, 20);
            this.txtGeneroPerso.TabIndex = 9;
            this.txtGeneroPerso.Visible = false;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(75, 122);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(135, 20);
            this.txtNome.TabIndex = 10;
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Location = new System.Drawing.Point(327, 121);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(165, 20);
            this.txtSobrenome.TabIndex = 11;
            this.txtSobrenome.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(75, 179);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(256, 20);
            this.txtEmail.TabIndex = 12;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(75, 242);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(254, 20);
            this.txtSenha.TabIndex = 13;
            // 
            // lblCodigoADM
            // 
            this.lblCodigoADM.AutoSize = true;
            this.lblCodigoADM.BackColor = System.Drawing.Color.Transparent;
            this.lblCodigoADM.Font = new System.Drawing.Font("Arial Narrow", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoADM.ForeColor = System.Drawing.Color.White;
            this.lblCodigoADM.Location = new System.Drawing.Point(7, 291);
            this.lblCodigoADM.Name = "lblCodigoADM";
            this.lblCodigoADM.Size = new System.Drawing.Size(122, 25);
            this.lblCodigoADM.TabIndex = 14;
            this.lblCodigoADM.Text = "Código ADM:";
            // 
            // txtCodigoADM
            // 
            this.txtCodigoADM.Location = new System.Drawing.Point(133, 291);
            this.txtCodigoADM.Name = "txtCodigoADM";
            this.txtCodigoADM.Size = new System.Drawing.Size(176, 20);
            this.txtCodigoADM.TabIndex = 15;
            this.txtCodigoADM.Text = "0";
            this.txtCodigoADM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoADM_KeyPress);
            // 
            // BotaoCadastrar
            // 
            this.BotaoCadastrar.BackColor = System.Drawing.Color.Yellow;
            this.BotaoCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BotaoCadastrar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotaoCadastrar.Location = new System.Drawing.Point(381, 378);
            this.BotaoCadastrar.Name = "BotaoCadastrar";
            this.BotaoCadastrar.Size = new System.Drawing.Size(97, 54);
            this.BotaoCadastrar.TabIndex = 16;
            this.BotaoCadastrar.Text = "Cadastrar";
            this.BotaoCadastrar.UseVisualStyleBackColor = false;
            this.BotaoCadastrar.Click += new System.EventHandler(this.BotaoCadastrar_Click);
            // 
            // TelaCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoLogin.Properties.Resources.TI;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(502, 462);
            this.Controls.Add(this.BotaoCadastrar);
            this.Controls.Add(this.txtCodigoADM);
            this.Controls.Add(this.lblCodigoADM);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSobrenome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtGeneroPerso);
            this.Controls.Add(this.radPersonalizado);
            this.Controls.Add(this.radFeminino);
            this.Controls.Add(this.radMasculino);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblDataNascimento);
            this.Controls.Add(this.DataNascimento);
            this.Controls.Add(this.lblCriarSenha);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblSobrenome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblCadastro);
            this.DoubleBuffered = true;
            this.Name = "TelaCadastro";
            this.Text = "Tela de Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCadastro;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSobrenome;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCriarSenha;
        private System.Windows.Forms.DateTimePicker DataNascimento;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.RadioButton radMasculino;
        private System.Windows.Forms.RadioButton radFeminino;
        private System.Windows.Forms.RadioButton radPersonalizado;
        private System.Windows.Forms.TextBox txtGeneroPerso;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblCodigoADM;
        private System.Windows.Forms.TextBox txtCodigoADM;
        private System.Windows.Forms.Button BotaoCadastrar;
    }
}