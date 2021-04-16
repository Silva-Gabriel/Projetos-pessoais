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
    public partial class TelaCadastro : Form
    {
        public TelaCadastro()
        {
            InitializeComponent();
            List<TextBox> tList = new List<TextBox>();
            List<string> sList = new List<string>();
            tList.Add(txtNome);
            tList.Add(txtSobrenome);
            tList.Add(txtEmail);
            tList.Add(txtSenha);
            tList.Add(txtGeneroPerso);
            sList.Add("Seu nome");
            sList.Add("Sobrenome");
            sList.Add("Email");
            sList.Add("Senha");
            sList.Add("Genero personalizado");
            SetCueBanner(ref tList, sList);
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        private static extern IntPtr SendMessage(IntPtr hWnd, uint msg, IntPtr i, string str);

        void SetCueBanner(ref List<TextBox> textBox, List<string> CueText)
        {
            for (int i = 0; i < textBox.Count; i++)
            {
                SendMessage(textBox[i].Handle, 0x1501, (IntPtr)1, CueText[i]);
            }
        }


        TelaLogin AbreTelaLogin = new TelaLogin();
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        string Usuario = "";
        private void BotaoCadastrar_Click(object sender, EventArgs e)
        {
            //Lê o arquivo .txt e retorna uma lista que pode ser acessada por index
            //Emails
            var lerLinhasEmailComum = File.ReadAllLines("BD/EmailsComum.txt");
            var lerLinhasEmailADM = File.ReadAllLines("BD/EmailsADM.txt");
            //Senhas
            var lerSenhasComum = File.ReadAllLines("BD/SenhasComum.txt");
            var lerSenhasADM = File.ReadAllLines("BD/SenhasADM.txt");
            //Nomes
            var lerNomesComum = File.ReadAllLines("BD/NomesComum.txt");
            var lerNomesADM = File.ReadAllLines("BD/NomesADM.txt");

            //Avisos de campos não preenchidos
            if (txtNome.Text == "")
            {
                MessageBox.Show("O campo 'Nome' precisa ser preenchido!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (txtSobrenome.Text == "")
            {
                MessageBox.Show("O campo 'Sobrenome' precisa ser preenchido!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (txtEmail.Text == "")
            {
                MessageBox.Show("O campo 'Email' precisa ser preenchido!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (txtSenha.Text == "")
            {
                MessageBox.Show("O campo 'Senha' precisa ser preenchido!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if (txtCodigoADM.Text == "")
            {
                MessageBox.Show("O código de administrador deve ser preenchido,se você não for um insira 0 como valor padrão", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (txtCodigoADM.Text != "" && txtEmail.Text != "" && txtNome.Text != "" && txtSenha.Text != "" && txtSobrenome.Text != "")
            {
                //Declarando variáveis
                string Genero = "";
                string Nome = txtNome.Text;
                string Sobrenome = txtSobrenome.Text;
                string Email = txtEmail.Text;
                string Senha = txtSenha.Text;
                int CodigoADM = Convert.ToInt32(txtCodigoADM.Text);
                var DataNasc = DataNascimento.Value;

                //Verificando Gênero
                if (radMasculino.Checked == true)
                    Genero = "Masculino";
                else if (radFeminino.Checked == true)
                    Genero = "Feminino";
                else
                {
                    Genero = txtGeneroPerso.Text;
                }
            }

            //Definindo acessos e armazenando dados dos usuários
            if (txtEmail.Text != "" && txtNome.Text != "" && txtSenha.Text != "" && txtSobrenome.Text != "")
            {
                //Retorna nível de acesso do usuário
                if (txtCodigoADM.Text == "1135813")
                {
                    Usuario = "ADM";
                    this.NivelAcesso = Usuario;
                }
                else
                {
                    Usuario = "Comum";
                    this.NivelAcesso = Usuario;
                }

                //Instanciando as classes StreamWrite para a escrita em txt e StreamReader para a leitura dos arquivos >> Início do armazenamento usuário administrador

                if (Usuario == "ADM")
                {
                    if (!(lerLinhasEmailADM.Contains(txtEmail.Text)) && !(lerLinhasEmailADM.Contains(txtEmail.Text)))
                    {
                        StreamWriter escreveEmailsADM = new StreamWriter(@"BD/EmailsADM.txt", true);
                        try
                        {
                          escreveEmailsADM.WriteLine($"{txtEmail.Text}");
                        }
                        catch
                        {
                            throw new ArgumentOutOfRangeException();
                        }
                        escreveEmailsADM.Close();

                        StreamWriter escreveSenhasADM = new StreamWriter(@"BD/SenhasADM.txt", true);
                        try
                        {
                            escreveSenhasADM.WriteLine($"{txtSenha.Text}");
                        }

                        catch
                        {
                            throw new ArgumentOutOfRangeException();
                        }
                        escreveSenhasADM.Close();

                        StreamWriter escreveNomeCompletoADM = new StreamWriter(@"BD/NomesADM.txt", true);
                        try
                        {
                            escreveNomeCompletoADM.WriteLine($"{txtNome.Text} {txtSobrenome.Text}");
                        }
                        catch
                        {
                            throw new ArgumentOutOfRangeException();
                        }
                        escreveNomeCompletoADM.Close();

                        MessageBox.Show("Cadastro efetuado com Sucesso", "Muito bem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        AbreTelaLogin.Show();
                    }
                    else
                    {
                        MessageBox.Show("Email já cadastrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                //Instanciando as classes StreamWrite para a escrita em txt e StreamReader para a leitura dos arquivos >> Início do armazenamento usuário comum
                else if (Usuario == "Comum")
                {
                    if (!(lerLinhasEmailComum.Contains(txtEmail.Text)) && !(lerLinhasEmailADM.Contains(txtEmail.Text)))
                    {
                        StreamWriter escreveEmailsComum = new StreamWriter(@"BD/EmailsComum.txt", true);
                        try
                        {
                            escreveEmailsComum.WriteLine($"{txtEmail.Text}");
                        }
                        catch
                        {
                            throw new ArgumentOutOfRangeException();
                        }
                        escreveEmailsComum.Close();

                        StreamWriter escreveSenhasComum = new StreamWriter(@"BD/SenhasComum.txt", true);
                        try
                        {
                            escreveSenhasComum.WriteLine($"{txtSenha.Text}");
                        }
                        catch
                        {
                            throw new ArgumentOutOfRangeException();
                        }
                        escreveSenhasComum.Close();

                        StreamWriter escreveNomeCompletoComum = new StreamWriter(@"BD/NomesComum.txt", true);
                        try
                        {
                            escreveNomeCompletoComum.WriteLine($"{txtNome.Text} {txtSobrenome.Text}");
                        }
                        catch
                        {
                            throw new ArgumentOutOfRangeException();
                        }
                        escreveNomeCompletoComum.Close();
                        MessageBox.Show("Cadastro efetuado com Sucesso", "Muito bem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        TelaLogin AbreTelaLogin = new TelaLogin();
                        AbreTelaLogin.Show();
                    }
                    else
                    {
                        MessageBox.Show("Email já cadastrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        public void RetornaAcesso()
        {
            var lerLinhasEmailADM = File.ReadAllLines("../EmailsADM.txt");
            var lerLinhasEmailComum = File.ReadAllLines("../EmailsComum.txt");
            if (lerLinhasEmailADM.Contains(txtEmail.Text))
            {
                this.NivelAcesso = "ADM";
            }
            else if (lerLinhasEmailComum.Contains(txtEmail.Text))
            {
                this.NivelAcesso = "Comum";
            }
        }
        public string NivelAcesso { get; set; }

        private void radPersonalizado_CheckedChanged(object sender, EventArgs e)
        {
            txtGeneroPerso.Visible = true;
        }

        private void radMasculino_CheckedChanged(object sender, EventArgs e)
        {
            txtGeneroPerso.Visible = false;
        }

        private void radFeminino_CheckedChanged(object sender, EventArgs e)
        {
            txtGeneroPerso.Visible = false;
        }

        private void txtCodigoADM_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }
    }
}