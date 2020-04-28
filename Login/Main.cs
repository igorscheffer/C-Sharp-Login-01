using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Main : Form
    {
        private object ApplicationForms;

        public Main()
        {
            InitializeComponent();
        }

        private void OnClickSair(object sender, EventArgs e) {
            Application.Exit();
        }

        private void OnCloseForm(object sender, FormClosingEventArgs e) {
            DialogResult CloseDialog = MessageBox.Show("Deseja fechar este formulario?", "Fechar", MessageBoxButtons.YesNo);

            if (CloseDialog == DialogResult.No) {
                e.Cancel = true;
            }
        }

        private void OnClickCadastrarClientes(object sender, EventArgs e) {
            Form CadastroClientes = new ApplicationForm.CadastroUsuarios();
            CadastroClientes.Show();
        }
    }
}
