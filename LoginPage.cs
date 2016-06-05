using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PreProjetoLP2
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void cbTipoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
           /* cbTipoUsuario.ValueMember = "Funcionário";
            cbTipoUsuario.ValueMember = "Professor";
            cbTipoUsuario.ValueMember = "Aluno";*/
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
