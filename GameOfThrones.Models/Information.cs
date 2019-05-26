using Newtonsoft.Json;
using System.Collections.Generic;

namespace GameOfThrones.Models
{
    public class Information
    {
        [JsonProperty("success")]
        public int Success { get; set; }

        [JsonProperty("book")]
        public List<Book> Book { get; set; }

        [JsonProperty("show")]
        public List<Show> Show { get; set; }
    }
}
