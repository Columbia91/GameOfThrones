using Newtonsoft.Json;

namespace GameOfThrones.Models
{
    public class Age
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("age", NullValueHandling = NullValueHandling.Ignore)]
        public int? AgeAge { get; set; }
    }
}
