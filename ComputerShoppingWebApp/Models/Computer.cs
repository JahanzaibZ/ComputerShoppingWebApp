using System.Text.Json;
using System.Text.Json.Serialization;

namespace ComputerShoppingWebApp.Models
{
    public class Computer
    {
        [JsonPropertyName("id")]
        public int computerId { get; set; }

        [JsonPropertyName("brand")]
        public int computerBrand { get; set; }

        [JsonPropertyName("model")]
        public int computerModel { get; set; }

        [JsonPropertyName("category")]
        public int computerCategory { get; set; }
        
        public override string ToString()
        {
            return JsonSerializer.Serialize<Computer>(this);
        }
    }
}
