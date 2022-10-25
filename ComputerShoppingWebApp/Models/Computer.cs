using System.Text.Json;
using System.Text.Json.Serialization;

namespace ComputerShoppingWebApp.Models
{
    public class Computer
    {
        [JsonPropertyName("id")]
        public int computerId { get; set; }

        [JsonPropertyName("brand")]
        public string computerBrand { get; set; }

        [JsonPropertyName("model")]
        public string computerModel { get; set; }

        [JsonPropertyName("category")]
        public string computerCategory { get; set; }
        
        public override string ToString()
        {
            return JsonSerializer.Serialize<Computer>(this);
        }
    }
}
