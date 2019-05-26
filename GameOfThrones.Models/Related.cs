using Newtonsoft.Json;

namespace GameOfThrones.Models
{
    public class Related
    {
        [JsonProperty("alive")]
        public bool Alive { get; set; }

        [JsonProperty("img")]
        public bool Img { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("mentions")]
        public int Mentions { get; set; }
    }
}
