using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramadorCSharp3._0_PreparaCursos
{
    //Classe criada para retornar informações de Cidade, Bairro e Estado a partir do CEP Informado
    //Vídeo de referência-https://www.youtube.com/watch?v=kZc8UU25JRY
    public class ResultadoCEP
    { 

    //Métodos de acesso as informações de Endereço
    //Como utilizaremos a API do ViaCep para coletar essas informações, será necessário instalar o pacote do JSON no projeto
        [JsonProperty(PropertyName = "cep")]
        public string PropriedadesCEP { get; set; }

        [JsonProperty(PropertyName = "logradouro")]
        public string PropriedadesLogradouro { get; set; }

        [JsonProperty(PropertyName = "bairro")]
        public string PropriedadesBairro { get; set; }

        [JsonProperty(PropertyName = "uf")]
        public string PropriedadesUF { get; set; }

        [JsonProperty(PropertyName = "localidade")]
        public string PropriedadesLocalidade { get; set; }
    }
}
