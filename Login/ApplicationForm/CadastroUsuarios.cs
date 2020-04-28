using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login.Util.Validate;

namespace Login.ApplicationForm {
    public partial class CadastroUsuarios : Form {
        ErrorProvider ErrorProvider = new ErrorProvider();

        public CadastroUsuarios() {
            InitializeComponent();
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
                Validate.AddRule(textEstado,                "Estado",                   "required_if:textCidade|exact:2");


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
    }
}
