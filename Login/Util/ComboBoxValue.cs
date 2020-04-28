using System.Collections.Generic;

namespace Login.Util {
    public struct ComboBoxCustom {
        public ComboBoxCustom(string value, string name) {
            this.Value = value;
            this.Name = name;
        }
        public string Value { get; set; }
        public string Name { get; set; }
    }

    public struct TipoPessoa {
    
    }

    class ComboBoxValue {
        public static List<ComboBoxCustom> TipoCadastro = new List<ComboBoxCustom>() {
            new ComboBoxCustom { Value = "C", Name = "Cliente" },
            new ComboBoxCustom { Value = "F", Name = "Fornecedor" },
            new ComboBoxCustom { Value = "A", Name = "Ambos" }
        };

        public static List<ComboBoxCustom> TipoPessoa = new List<ComboBoxCustom>() {
            new ComboBoxCustom { Value = "PJ", Name = "Pessoa Juridica" },
            new ComboBoxCustom { Value = "PF", Name = "Pessoa Fisica" }
        };

        public static List<ComboBoxCustom> Estados = new List<ComboBoxCustom>() {
            new ComboBoxCustom { Value = "AC", Name = "Acre (AC)" },
            new ComboBoxCustom { Value = "AL", Name = "Alagoas (AL)" },
            new ComboBoxCustom { Value = "AP", Name = "Amapá (AP)" },
            new ComboBoxCustom { Value = "AM", Name = "Amazonas (AM)" },
            new ComboBoxCustom { Value = "BA", Name = "Bahia (BA)" },
            new ComboBoxCustom { Value = "CE", Name = "Ceará (CE)" },
            new ComboBoxCustom { Value = "DF", Name = "Distrito Federal (DF)" },
            new ComboBoxCustom { Value = "ES", Name = "Espírito Santo (ES)" },
            new ComboBoxCustom { Value = "GO", Name = "Goiás (GO)" },
            new ComboBoxCustom { Value = "MA", Name = "Maranhão (MA)" },
            new ComboBoxCustom { Value = "MT", Name = "Mato Grosso (MT)" },
            new ComboBoxCustom { Value = "MS", Name = "Mato Grosso do Sul (MS)" },
            new ComboBoxCustom { Value = "MG", Name = "Minas Gerais (MG)" },
            new ComboBoxCustom { Value = "PA", Name = "Pará (PA)" },
            new ComboBoxCustom { Value = "PB", Name = "Paraíba (PB)" },
            new ComboBoxCustom { Value = "PR", Name = "Paraná (PR)" },
            new ComboBoxCustom { Value = "PE", Name = "Pernambuco (PE)" },
            new ComboBoxCustom { Value = "PI", Name = "Piauí (PI)" },
            new ComboBoxCustom { Value = "RJ", Name = "Rio de Janeiro (RJ)" },
            new ComboBoxCustom { Value = "RN", Name = "Rio Grande do Norte (RN)" },
            new ComboBoxCustom { Value = "RS", Name = "Rio Grande do Sul (RS)" },
            new ComboBoxCustom { Value = "RO", Name = "Rondônia (RO)" },
            new ComboBoxCustom { Value = "RR", Name = "Roraima (RR)" },
            new ComboBoxCustom { Value = "SC", Name = "Santa Catarina (SC)" },
            new ComboBoxCustom { Value = "SP", Name = "São Paulo (SP)" },
            new ComboBoxCustom { Value = "SE", Name = "Sergipe (SE)" },
            new ComboBoxCustom { Value = "TO", Name = "Tocantins (TO)" }
        };
    }
}
