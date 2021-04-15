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
    public partial class InterfaceADM : Form
    {
        public string Usuario { get; set; }
        public string NivelAcesso { get; set; }
        public InterfaceADM(string Usuario,string NivelAcesso)
        {
            InitializeComponent();
            lblADM.Text = $"Olá {Usuario} \nNível de acesso: {NivelAcesso}";
        }

        TelaLogin abrirTelaLogin = new TelaLogin();
        

        private void InterfaceADM_Load(object sender, EventArgs e)
        {
        }

        private void InterfaceADM_FormClosed(object sender, FormClosedEventArgs e)
        {
            abrirTelaLogin.Show();
        }

        private void VoltarTelaLogin_Click(object sender, EventArgs e)
        {
            this.Close();
            abrirTelaLogin.Show();            
        }
    }
}
