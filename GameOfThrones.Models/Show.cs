using Newtonsoft.Json;
using System.Collections.Generic;

namespace GameOfThrones.Models
{
    public class Show
    {
        [JsonProperty("titles")]
        public List<string> Titles { get; set; }

        [JsonProperty("origin")]
        public List<string> Origin { get; set; }

        [JsonProperty("siblings")]
        public List<string> Siblings { get; set; }

        [JsonProperty("spouse")]
        public List<string> Spouse { get; set; }

        [JsonProperty("lovers")]
        public List<string> Lovers { get; set; }

        [JsonProperty("plod")]
        public int Plod { get; set; }

        [JsonProperty("longevity")]
        public List<object> Longevity { get; set; }

        [JsonProperty("plodB")]
        public double PlodB { get; set; }

        [JsonProperty("plodC")]
        public int PlodC { get; set; }

        [JsonProperty("longevityB")]
        public List<double> LongevityB { get; set; }

        [JsonProperty("longevityC")]
        public List<object> LongevityC { get; set; }

        [JsonProperty("culture")]
        public List<string> Culture { get; set; }

        [JsonProperty("religion")]
        public List<string> Religion { get; set; }

        [JsonProperty("allegiances")]
        public List<string> Allegiances { get; set; }

        [JsonProperty("seasons")]
        public List<int?> Seasons { get; set; }

        [JsonProperty("appearances")]
        public List<string> Appearances { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("alive")]
        public bool Alive { get; set; }

        [JsonProperty("death")]
        public int Death { get; set; }

        [JsonProperty("father")]
        public string Father { get; set; }

        [JsonProperty("house")]
        public string House { get; set; }

        [JsonProperty("first_seen")]
        public string FirstSeen { get; set; }

        [JsonProperty("actor")]
        public string Actor { get; set; }

        [JsonProperty("related")]
        public List<Related> Related { get; set; }

        [JsonProperty("pagerank")]
        public Pagerank Pagerank { get; set; }

        [JsonProperty("age")]
        public Age Age { get; set; }

        [JsonProperty("mother")]
        public string Mother { get; set; }

        [JsonProperty("birth")]
        public int? Birth { get; set; }

        [JsonProperty("longevityStartB")]
        public int? LongevityStartB { get; set; }
    }
}