using System.Collections.Generic;

namespace SWAPI.Models
{
    public class People : Base
    {
        public string name { get; set; }
        public string height { get; set; }
        public string mass { get; set; }
        public string hair_color { get; set; }
        public string skin_color { get; set; }
        public string eye_color { get; set; }
        public string birth_year { get; set; }
        public string gender { get; set; }
        public string homeworld { get; set; }
        public IEnumerable<string> films { get; set; }
        public IEnumerable<string> species { get; set; }
        public IEnumerable<string> vehicles { get; set; }
        public IEnumerable<string> starships { get; set; }
    }
}