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
    }
}
