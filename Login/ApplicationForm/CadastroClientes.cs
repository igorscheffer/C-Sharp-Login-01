using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login.Util;
using Login.Util.Validation;

namespace Login.ApplicationForm {
    public partial class CadastroClientes : Form {
        ErrorProvider ErrorProvider = new ErrorProvider();

        private Point InitPosLIE;
        private Point InitPosTIE;
        private Point InitPosCI;

        static string path = AppDomain.CurrentDomain.BaseDirectory + "database";
        static string file = path + "/clientes.txt";

        public CadastroClientes() {
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
                Validation validate = new Validation(this, ErrorProvider);

                validate.AddRule(combTipoCadastro,          "Tipo de Cadastro",         "required|in:C,F,A");
                validate.AddRule(combTipoPessoa,            "Tipo de Pessoa",           "required|in:PF,PJ");
                validate.AddRule(textCNPJ,                  "CNPJ",                     "required|" + ((string)combTipoPessoa.SelectedValue == "PJ" ? "cnpj" : "cpf"));
                validate.AddRule(textRazaoSocial,           "Razão Social",             "required|min:10|max:100");
                validate.AddRule(textNomeFantasia,          "Nome Fantasia",            "min:10|max:100");
                validate.AddRule(textInscricaoMunicipal,    "Inscrição Municipal",      "numeric|max:12");
                validate.AddRule(textInscricaoEstadual,     "Inscrição Estadual",       "numeric|max:12");

                validate.AddRule(textCEP,                   "CEP",                      "cep");
                validate.AddRule(textEndereco,              "Endereço",                 "required_if:textCEP|min:2|max:100");
                validate.AddRule(textNumero,                "Nº",                       "max:10");
                validate.AddRule(textBairro,                "Bairro",                   "required_if:textCEP|min:2|max:60");
                validate.AddRule(textComplemento,           "Complemento",              "min:2|max:80");
                validate.AddRule(textCidade,                "Cidade",                   "required_if:textCEP|min:2|max:80");
                validate.AddRule(combEstado,                "Estado",                   "required_if:textCidade|exact:2");

                validate.AddRule(textTelefone,              "Telefone",                 "telefone");
                validate.AddRule(textRamal,                 "Ramal",                    "numeric|max:5");
                validate.AddRule(textCelular,               "Celular",                  "telefone");
                validate.AddRule(textEmail,                 "E-mail",                   "email");

                validate.Validate();

                if (validate.IsValid()) {
                    string row = "@tipo|@pessoa|@cnpj|@razao_social|@nome_fantasia|@inscricao_municipal|@inscricao_estadual|@cep|@endereco|@n|@bairro|@complemento|@cidade|@estado|@telefone|@ramal|@celular|@email";
                    
                    row = row.Replace("@tipo", combTipoCadastro.SelectedValue.ToString());
                    row = row.Replace("@pessoa", combTipoPessoa.SelectedValue.ToString());
                    row = row.Replace("@cnpj", textCNPJ.Text);
                    row = row.Replace("@razao_social", textRazaoSocial.Text);
                    row = row.Replace("@nome_fantasia", textNomeFantasia.Text);
                    row = row.Replace("@inscricao_municipal", textInscricaoMunicipal.Text);
                    row = row.Replace("@inscricao_estadual", textInscricaoEstadual.Text);
                    row = row.Replace("@cep", textCEP.Text);
                    row = row.Replace("@endereco", textEndereco.Text);
                    row = row.Replace("@n", textNumero.Text);
                    row = row.Replace("@bairro", textBairro.Text);
                    row = row.Replace("@complemento", textComplemento.Text);
                    row = row.Replace("@cidade", textCidade.Text);
                    row = row.Replace("@estado", combEstado.Text);
                    row = row.Replace("@telefone", textTelefone.Text);
                    row = row.Replace("@ramal", textRamal.Text);
                    row = row.Replace("@celular", textCelular.Text);
                    row = row.Replace("@email", textEmail.Text);

                    if (!Directory.Exists(path)) {
                        Directory.CreateDirectory(path);
                    }

                    using (StreamWriter sw = (File.Exists(file) ? File.AppendText(file) : File.CreateText(file))) {
                        sw.WriteLine(row);
                    }

                    validate.ClearAllComponents();
                    
                    MessageBox.Show("Cadastro Efetuado com sucesso.");
                }
                else {
                    validate.ErrorProviderShow(12, 12, -17);
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
