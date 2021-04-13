using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProjetoLogin
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void CriarConta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TelaCadastro exibeTelaCadastro = new TelaCadastro();
            TelaLogin exibeTelaLogin = new TelaLogin();
            exibeTelaCadastro.Show();
            this.Hide();
        }

        private void BotaoAutenticar_Click(object sender, EventArgs e)
        {
            int posicao;

            if (txtEmail.Text != "" && txtSenha.Text != "")
            {
                //Transforma os textos dos arquivos em arrays de strings
                var lerLinhasEmailADM = File.ReadAllLines("C:/WorkSpace/Projetos-pessoais/ProjetoLogin/BDtxt/ADM/EmailsADM.txt");
                var lerLinhasEmailComum = File.ReadAllLines("C:/WorkSpace/Projetos-pessoais/ProjetoLogin/BDtxt/Comum/EmailsComum.txt");
                var lerLinhasSenhaADM = File.ReadAllLines("C:/WorkSpace/Projetos-pessoais/ProjetoLogin/BDtxt/ADM/SenhasADM.txt");
                var lerLinhasSenhaComum = File.ReadAllLines("C:/WorkSpace/Projetos-pessoais/ProjetoLogin/BDtxt/Comum/SenhasComum.txt");
                var lerNomeUsuarioADM = File.ReadAllLines("C:/WorkSpace/Projetos-pessoais/ProjetoLogin/BDtxt/ADM/NomesADM.txt");
                var lerNomeUsuarioComum = File.ReadAllLines("C:/WorkSpace/Projetos-pessoais/ProjetoLogin/BDtxt/Comum/NomesComum.txt");

                txtSenha.PasswordChar = '\u0000';
                //linhaArrayEmailADM, linhaArraySenhaADM;


                if (lerLinhasEmailADM.Contains(txtEmail.Text) == true)
                {
                    if (lerLinhasSenhaADM.Contains(txtSenha.Text) == true)
                    {
                        for (posicao = 0; posicao < lerLinhasEmailADM.Count(); posicao++)
                        {
                            if (lerLinhasEmailADM[posicao] == txtEmail.Text)
                            {
                                if (lerLinhasSenhaADM[posicao] == txtSenha.Text)
                                {
                                    this.Hide();
                                    txtEmail = null;
                                    txtSenha = null;
                                    MessageBox.Show($"Olá {lerNomeUsuarioADM[posicao]}");
                                    InterfaceADM AbrirInterfaceADM = new InterfaceADM();
                                    AbrirInterfaceADM.Show();
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou senha incorreto(s)");
                    }
                }
                else if (lerLinhasEmailComum.Contains(txtEmail.Text) == true)
                {
                    if (lerLinhasSenhaComum.Contains(txtSenha.Text) == true)
                    {
                        for (posicao = 0; posicao < lerLinhasEmailComum.Count(); posicao++)
                        {
                            if (lerLinhasEmailComum[posicao] == txtEmail.Text)
                            {
                                if (lerLinhasSenhaComum[posicao] == txtSenha.Text)
                                {
                                    MessageBox.Show($"Olá {lerNomeUsuarioComum[posicao]}");
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou senha incorreto(s)");
                    }
                }
                else 
                {
                    MessageBox.Show("Usuário ou senha incorreto(s)");
                }
                
            }










        }
    }
}
