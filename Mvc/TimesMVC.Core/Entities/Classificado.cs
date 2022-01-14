using System.Text.Json.Serialization;

namespace TimesMVC.Core.Entities
{
    public class Classificado
    {
        [JsonPropertyName("nome")]
        public string Time { get; set; }

        [JsonPropertyName("fundadoEm")]
        public int Criacao { get; set; }

        [JsonPropertyName("titulos")]
        public int Premio { get; set; }
    }
}