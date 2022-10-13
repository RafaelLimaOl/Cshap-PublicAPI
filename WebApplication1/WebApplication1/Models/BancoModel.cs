using System.Text.Json.Serialization;

namespace PublicApi.Models
{

    // Request dos Dados da API

    public class BancoModel
    {
        [JsonPropertyName("ispb")]
        public string? Ispb { get; set; }

        [JsonPropertyName("name")]
        public string? Nome { get; set; }

        [JsonPropertyName("code")]
        public int Codigo { get; set; }

        [JsonPropertyName("fullName")]
        public string? NomeCompleto { get; set; }
    }

}
