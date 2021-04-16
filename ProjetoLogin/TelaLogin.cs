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
using System.Runtime.InteropServices;

namespace ProjetoLogin
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
            List<TextBox> txtList = new List<TextBox>() { txtEmail,txtSenha };
            List<string> descList = new List<string>() { "Email", "Senha" };
            SetCueBanner(ref txtList, descList);
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr i, string str);

        void SetCueBanner(ref List<TextBox> txts, List<string> description)
        {
            for (int i = 0; i < txts.Count; i++)
            {
                SendMessage(txts[i].Handle, 0x1501, (IntPtr)1, description[i]);
            }
        }
        private void CriarConta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TelaCadastro exibeTelaCadastro = new TelaCadastro();
            TelaLogin exibeTelaLogin = new TelaLogin();
            exibeTelaCadastro.Show();
            this.Hide();
        }
        string NomeUserADM = "";
        string nivel = "";
        string user = "";
        private void BotaoAutenticar_Click(object sender, EventArgs e)
        {
            int posicao;

            if (txtEmail.Text != "" && txtSenha.Text != "")
            {
                //Transforma os textos dos arquivos em arrays de strings
                //Lê o arquivo .txt e retorna uma lista que pode ser acessada por index
                //Emails
                var lerLinhasEmailComum = File.ReadAllLines("BD/EmailsComum.txt");
                var lerLinhasEmailADM = File.ReadAllLines("BD/EmailsADM.txt");
                //Senhas
                var lerLinhasSenhasComum = File.ReadAllLines("BD/SenhasComum.txt");
                var lerLinhasSenhasADM = File.ReadAllLines("BD/SenhasADM.txt");
                //Nomes
                var lerLinhasNomesComum = File.ReadAllLines("BD/NomesComum.txt");
                var lerLinhasNomesADM = File.ReadAllLines("BD/NomesADM.txt");

                if (lerLinhasEmailADM.Contains(txtEmail.Text) == true)
                {
                    if (lerLinhasSenhasADM.Contains(txtSenha.Text) == true)
                    {
                        for (posicao = 0; posicao < lerLinhasEmailADM.Count(); posicao++)
                        {
                            if (lerLinhasEmailADM[posicao] == txtEmail.Text)
                            {
                                if (lerLinhasSenhasADM[posicao] == txtSenha.Text)
                                {
                                    NomeUserADM = lerLinhasNomesADM[posicao];
                                    this.Hide();
                                    MessageBox.Show($"Olá mestre {lerLinhasNomesADM[posicao]}","Boas-vindas");
                                    user = NomeUserADM;
                                    nivel = "Administrador";
                                    InterfaceADM AbrirInterfaceADM = new InterfaceADM(user,nivel);
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
                    if (lerLinhasSenhasComum.Contains(txtSenha.Text) == true)
                    {
                        for (posicao = 0; posicao < lerLinhasEmailComum.Count(); posicao++)
                        {
                            if (lerLinhasEmailComum[posicao] == txtEmail.Text)
                            {
                                if (lerLinhasSenhasComum[posicao] == txtSenha.Text)
                                {
                                    NomeUserADM = lerLinhasNomesComum[posicao];
                                    this.Hide();
                                    MessageBox.Show($"Olá usuário {lerLinhasNomesComum[posicao]},seja bem-vindo ao GBX","Boas-vindas");
                                    user = NomeUserADM;
                                    nivel = "Usuário Comum";
                                    InterfaceADM AbrirInterfaceADM = new InterfaceADM(user, nivel);
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
                else 
                {
                    MessageBox.Show("Usuário ou senha incorreto(s)");
                } 
            }
        }
        public void RetornaUsuario()
        {
            InterfaceADM retornandoUsuario = new InterfaceADM(user, nivel);
            retornandoUsuario.Usuario = user;
            retornandoUsuario.NivelAcesso = nivel;
        }

        private void TelaLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void cBoxMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxMostrarSenha.Checked)
            {
                txtSenha.PasswordChar = '\u0000';
            }
            else 
            {
                txtSenha.PasswordChar = Convert.ToChar("*");
            }
        }
    }
}
