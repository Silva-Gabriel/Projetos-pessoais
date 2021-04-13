using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoLogin
{
    public partial class InterfaceADM : Form
    {
        public InterfaceADM()
        {
            InitializeComponent();
        }

        private void InterfaceADM_Load(object sender, EventArgs e)
        {
           
        }

        private void InterfaceADM_FormClosed(object sender, FormClosedEventArgs e)
        {
            TelaLogin abrirTelaLogin = new TelaLogin();
            abrirTelaLogin.Show();
        }
    }
}
