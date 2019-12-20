using System.Collections.Generic;

namespace SWAPI.Models
{
    public class Species : Base
    {
        public string average_height { get; set; }
        public string average_lifespan { get; set; }
        public string classification { get; set; }
        public string designation { get; set; }
        public string eye_colors { get; set; }
        public string hair_colors { get; set; }
        public string homeworld { get; set; }
        public string language { get; set; }
        public string name { get; set; }
        public IEnumerable<string> people { get; set; }
        public IEnumerable<string> films { get; set; }
        public string skin_colors { get; set; }
    }
}