using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login.Util;
using Login.Util.Validate;

namespace Login.ApplicationForm {
    public partial class CadastroUsuarios : Form {
        ErrorProvider ErrorProvider = new ErrorProvider();

        private Point InitPosLIE;
        private Point InitPosTIE;
        private Point InitPosCI;

        public CadastroUsuarios() {
            InitializeComponent();

            InitPosLIE = lblInscricaoEstadual.Location;
            InitPosTIE = textInscricaoEstadual.Location;
            InitPosCI = checkIsento.Location;

            combTipoCadastro.ValueMember = "Value";
            combTipoCadastro.DisplayMember = "Name";
            combTipoCadastro.DataSource = ComboBoxValue.TipoCadastro;

            combTipoPessoa.ValueMember = "Value";
            combTipoPessoa.DisplayMember = "Name";
            combTipoPessoa.DataSource = ComboBoxValue.TipoPessoa;

            combEstado.ValueMember = "Value";
            combEstado.DisplayMember = "Name";
            combEstado.DataSource = ComboBoxValue.Estados;
        }

        private void OnClickSalvar(object sender, EventArgs e) {
            try {
                Validate Validate = new Validate(this, ErrorProvider);

                Validate.AddRule(combTipoCadastro,          "Tipo de Cadastro",         "required|in:C,F,A");
                Validate.AddRule(combTipoPessoa,            "Tipo de Pessoa",           "required|in:PF,PJ");
                Validate.AddRule(textCNPJ,                  "CNPJ",                     "required|cnpj");
                Validate.AddRule(textRazaoSocial,           "Razão Social",             "required|min:10|max:100");
                Validate.AddRule(textNomeFantasia,          "Nome Fantasia",            "min:10|max:100");
                Validate.AddRule(textInscricaoMunicipal,    "Inscrição Municipal",      "numeric|max:12");
                Validate.AddRule(textInscricaoEstadual,     "Inscrição Estadual",       "numeric|max:12");

                Validate.AddRule(textCEP,                   "CEP",                      "cep");
                Validate.AddRule(textEndereco,              "Endereço",                 "required_if:textCEP|min:2|max:100");
                Validate.AddRule(textNumero,                "Nº",                       "max:10");
                Validate.AddRule(textBairro,                "Bairro",                   "required_if:textCEP|min:2|max:60");
                Validate.AddRule(textComplemento,           "Complemento",              "min:2|max:80");
                Validate.AddRule(textCidade,                "Cidade",                   "required_if:textCEP|min:2|max:80");
                Validate.AddRule(combEstado,                "Estado",                   "required_if:textCidade|exact:2");


                Validate.AddRule(textTelefone,              "Telefone",                 "telefone");
                Validate.AddRule(textRamal,                 "Ramal",                    "numeric|max:5");
                Validate.AddRule(textCelular,               "Celular",                  "telefone");
                Validate.AddRule(textEmail,                 "E-mail",                   "email");

                Validate.Validation();

                if (Validate.IsValid()) {
                    MessageBox.Show("Cadastro Efetuado com sucesso.");
                }
                else {
                    Validate.ErrorProviderShow(12, 12, -17);
                    Validate.ErrorMessageBox();
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void OnSelectTipoPessoa(object sender, EventArgs e) {
            string Selected = (string)combTipoPessoa.SelectedValue;

            if (Selected == "PF") {
                textCNPJ.Mask = "000.000.000-00";

                lblCNPJ.Text = "CPF";
                lblRazaoSocial.Text = "Nome";
                lblInscricaoEstadual.Text = "Insc. Produtor Rural";

                lblNomeFantasia.Visible = false;
                textNomeFantasia.Visible = false;
                lblInscricaoMunicipal.Visible = false;
                textInscricaoMunicipal.Visible = false;

                lblNomeFantasia.Enabled = false;
                textNomeFantasia.Enabled = false;
                lblInscricaoMunicipal.Enabled = false;
                textInscricaoMunicipal.Enabled = false;

                lblInscricaoEstadual.Location = new Point(20, lblInscricaoEstadual.Location.Y);
                textInscricaoEstadual.Location = new Point(20, textInscricaoEstadual.Location.Y);
                checkIsento.Location = new Point(180, checkIsento.Location.Y);
            }
            else {
                combTipoPessoa.SelectedValue = "PJ";

                textCNPJ.Mask = "00.000.000/0000-00";

                lblCNPJ.Text = "CNPJ";
                lblRazaoSocial.Text = "Razão Social";
                lblInscricaoEstadual.Text = "Inscrição Estadual";

                lblNomeFantasia.Enabled = true;
                textNomeFantasia.Enabled = true;
                lblInscricaoMunicipal.Enabled = true;
                textInscricaoMunicipal.Enabled = true;

                lblNomeFantasia.Visible = true;
                textNomeFantasia.Visible = true;
                lblInscricaoMunicipal.Visible = true;
                textInscricaoMunicipal.Visible = true;

                lblInscricaoEstadual.Location = InitPosLIE;
                textInscricaoEstadual.Location = InitPosTIE;
                checkIsento.Location = InitPosCI;
            }
        }

        private void OnCheckIsento(object sender, EventArgs e) {
            bool Value = checkIsento.Checked;

            textInscricaoEstadual.Enabled = !Value;
        }
    }
}
