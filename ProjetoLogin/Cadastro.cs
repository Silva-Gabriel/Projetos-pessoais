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
    public partial class TelaCadastro : Form
    {
        public TelaCadastro()
        {
            InitializeComponent();
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        string Usuario = "";
        private void BotaoCadastrar_Click(object sender, EventArgs e)
        {
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
                MessageBox.Show("O código de administrador deve ser preenchido,se você não for um insira 0 como valor padrão","Aviso!",MessageBoxButtons.OK,MessageBoxIcon.Information);
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
                }
                else
                {
                    Usuario = "Comum";
                }

                //Instanciando as classes StreamWrite para a escrita em txt e StreamReader para a leitura dos arquivos >> Início do armazenamento usuário administrador
                if (Usuario == "ADM")
                {
                    StreamWriter escreveEmails = new StreamWriter(@"C:/WorkSpace/Projetos-pessoais/ProjetoLogin/BDtxt/ADM/EmailsADM.txt", true);
                    try
                    {
                        escreveEmails.WriteLine($"{txtEmail.Text}");
                    }
                    catch
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    escreveEmails.Close();

                    StreamWriter escreveSenhas = new StreamWriter(@"C:/WorkSpace/Projetos-pessoais/ProjetoLogin/BDtxt/ADM/SenhasADM.txt", true);
                    try
                    {
                        txtSenha.PasswordChar = '\u0000';
                        escreveSenhas.WriteLine($"{txtSenha.Text}");
                        escreveSenhas.Close();
                    }
                    catch
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    escreveSenhas.Close();

                    StreamWriter escreveNomeCompleto = new StreamWriter(@"C:\WorkSpace\Projetos-pessoais\ProjetoLogin\BDtxt\ADM\NomesADM.txt", true);
                    try
                    {
                        escreveNomeCompleto.WriteLine($"{txtNome.Text} {txtSobrenome.Text}");
                    }
                    catch
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    escreveNomeCompleto.Close();

                    //Termina o cadastro e volta para a tela inicial
                    MessageBox.Show("Cadastro efetuado com Sucesso");
                    this.Close();
                    TelaLogin AbreTelaLogin = new TelaLogin();
                    AbreTelaLogin.Show();

                }
                //Instanciando as classes StreamWrite para a escrita em txt e StreamReader para a leitura dos arquivos >> Início do armazenamento usuário comum
                else if (Usuario == "Comum")
                {
                    StreamWriter escreveEmails = new StreamWriter(@"C:/WorkSpace/Projetos-pessoais/ProjetoLogin/BDtxt/Comum/EmailsComum.txt", true);
                    try
                    {
                        escreveEmails.WriteLine($"{txtEmail.Text}");
                    }
                    catch
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    escreveEmails.Close();

                    StreamWriter escreveSenhas = new StreamWriter(@"C:/WorkSpace/Projetos-pessoais/ProjetoLogin/BDtxt/ComumSenhasComum.txt", true);
                    try
                    {
                        txtSenha.PasswordChar = '\u0000'; //Retira o passwordChar '*' para mostrar a senha no banco de dados txt
                        escreveSenhas.WriteLine($"{txtSenha.Text}");
                        escreveSenhas.Close();
                    }
                    catch
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    escreveSenhas.Close();

                    StreamWriter escreveNomeCompleto = new StreamWriter(@"C:/WorkSpace/Projetos-pessoais/ProjetoLogin/BDtxt/Comum/NomesComum.txt", true);
                    try
                    {
                        escreveNomeCompleto.WriteLine($"{txtNome.Text} {txtSobrenome.Text}");
                    }
                    catch
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    escreveNomeCompleto.Close();
                    MessageBox.Show("Cadastro efetuado com Sucesso");
                    this.Close();
                    TelaLogin AbreTelaLogin = new TelaLogin();
                    AbreTelaLogin.Show();
                }
            }
       

        }

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
