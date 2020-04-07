using FontAwesome.Sharp;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            textLogin.Text = "digite seu usuario";
            textSenha.Text = "digite sua senha";
            textSenha.PasswordChar = '\0';

            textLogin.ForeColor = System.Drawing.Color.FromArgb(122, 122, 163);
            textSenha.ForeColor = System.Drawing.Color.FromArgb(122, 122, 163);
        }

        private void CloseOnClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CloseOnHover(object sender, EventArgs e)
        {
            buttonClose.IconColor = System.Drawing.Color.FromArgb(35, 30, 78);
        }

        private void CloseOnLeave(object sender, EventArgs e)
        {
            buttonClose.IconColor = System.Drawing.Color.FromArgb(35, 35, 90);
        }

        private void TextFocusEnter(object sender, EventArgs e)
        {
            TextBox focus = sender as TextBox;
            if ((string)focus.Tag == "login"){
                panelLogin.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
                iconLogin.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);

                if (textLogin.Text == "digite seu usuario") {
                    textLogin.Text = "";
                    textLogin.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
                }
            }
            else {
                panelSenha.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
                iconSenha.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);

                if (textSenha.Text == "digite sua senha") {
                    textSenha.Text = "";
                    textSenha.PasswordChar = '*';
                    textSenha.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
                }
            }
        }

        private void TextFocusLeave(object sender, EventArgs e)
        {
            TextBox focus = sender as TextBox;
            if ((string)focus.Tag == "login")
            {
                panelLogin.BackColor = System.Drawing.Color.FromArgb(122, 122, 163);
                iconLogin.ForeColor = System.Drawing.Color.FromArgb(122, 122, 163);

                if (textLogin.Text == "") {
                    textLogin.Text = "digite seu usuario";
                    textLogin.ForeColor = System.Drawing.Color.FromArgb(122, 122, 163);
                }
                else {
                    textLogin.ForeColor = System.Drawing.Color.FromArgb(255,255,255);
                }
            }
            else
            {
                panelSenha.BackColor = System.Drawing.Color.FromArgb(122, 122, 163);
                iconSenha.ForeColor = System.Drawing.Color.FromArgb(122, 122, 163);

                if (textSenha.Text == "") {
                    textSenha.Text = "digite sua senha";
                    textSenha.ForeColor = System.Drawing.Color.FromArgb(122, 122, 163);
                    textSenha.PasswordChar = '\0';
                    MostrarSenhaEdit(false);
                }
                else {
                    textSenha.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
                }
            }
        }

        private void MostrarSenhaOnClick(object sender, EventArgs e)
        {
            MostrarSenhaEdit(true);
        }

        private void MostrarSenhaEdit(bool edit) {
            if (textSenha.PasswordChar != '*') {
                if (edit) { textSenha.PasswordChar = '*'; }
                iconMostrarSenha.IconChar = FontAwesome.Sharp.IconChar.Eye;
            }
            else {
                if (edit) { textSenha.PasswordChar = '\0'; }
                iconMostrarSenha.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            }
        }

        private void LogInValidation(object sender, EventArgs e)
        {
            if (textLogin.Text == "" || textSenha.Text == "" || textLogin.Text == "digite seu usuario" || textSenha.Text == "digite sua senha")
            {
                MessageBox.Show("Usuario e Senha devem ser preenchidos.");
            }
            else {
                if (textLogin.Text == "igorferreira" && textSenha.Text == "unifeb") {
                    this.Hide();
                    Form logado = new Logado();
                    logado.Closed += (s, a) => this.Close();
                    logado.Show();
                }
                else {
                    MessageBox.Show("Usuario ou Senha Incorretos.");
                }
            }
        }
    }
}
