using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuscarCEP
{
    public class CepResponse
    {
        [JsonProperty("cep")]
        public string Cep { get; set; }
        [JsonProperty("logradouro")]
        public string Logradouro { get; set; }
        [JsonProperty("bairro")]
        public string Bairro { get; set; }
        [JsonProperty("localidade")]
        public string Localidade { get; set; }
        [JsonProperty("uf")]
        public string UF { get; set; }


    }
}
