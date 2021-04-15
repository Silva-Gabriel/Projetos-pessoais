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
                                    NomeUserADM = lerNomeUsuarioADM[posicao];
                                    this.Hide();
                                    MessageBox.Show($"Olá {lerNomeUsuarioADM[posicao]}");
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
                    if (lerLinhasSenhaComum.Contains(txtSenha.Text) == true)
                    {
                        for (posicao = 0; posicao < lerLinhasEmailComum.Count(); posicao++)
                        {
                            if (lerLinhasEmailComum[posicao] == txtEmail.Text)
                            {
                                if (lerLinhasSenhaComum[posicao] == txtSenha.Text)
                                {
                                    NomeUserADM = lerNomeUsuarioComum[posicao];
                                    this.Hide();
                                    MessageBox.Show($"Olá usuário comum {lerNomeUsuarioComum[posicao]}");
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
    }
}
