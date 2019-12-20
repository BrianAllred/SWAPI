using System.Collections.Generic;

namespace SWAPI.Models
{
    public class Film : Base
    {
        public string title { get; set; }
        public string episode_id { get; set; }
        public string opening_crawl { get; set; }
        public string director { get; set; }
        public string producer { get; set; }
        public string release_date { get; set; }
        public IEnumerable<string> species { get; set; }
        public IEnumerable<string> starships { get; set; }
        public IEnumerable<string> vehicles { get; set; }
        public IEnumerable<string> characters { get; set; }
        public IEnumerable<string> planets { get; set; }
    }
}