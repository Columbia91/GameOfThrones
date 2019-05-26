using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfThrones.Models
{
    public class Book
    {
        [JsonProperty("titles")]
        public List<string> Titles { get; set; }

        [JsonProperty("spouse")]
        public List<string> Spouse { get; set; }

        [JsonProperty("children")]
        public List<string> Children { get; set; }

        [JsonProperty("allegiance")]
        public List<string> Allegiance { get; set; }

        [JsonProperty("books")]
        public List<string> Books { get; set; }

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

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("culture")]
        public string Culture { get; set; }

        [JsonProperty("house")]
        public string House { get; set; }

        [JsonProperty("alive")]
        public bool Alive { get; set; }

        [JsonProperty("pagerank")]
        public Pagerank Pagerank { get; set; }

        [JsonProperty("placeOfBirth")]
        public string PlaceOfBirth { get; set; }

        [JsonProperty("birth")]
        public int? Birth { get; set; }

        [JsonProperty("placeOfDeath")]
        public string PlaceOfDeath { get; set; }

        [JsonProperty("death")]
        public int? Death { get; set; }

        [JsonProperty("longevityStartB")]
        public int? LongevityStartB { get; set; }

        [JsonProperty("father")]
        public string Father { get; set; }

        [JsonProperty("mother")]
        public string Mother { get; set; }

        [JsonProperty("heir")]
        public string Heir { get; set; }
    }
}
