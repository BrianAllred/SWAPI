using System.Collections.Generic;

namespace SWAPI.Models
{
    public class EntryList<T>
    {
        public int count { get; set; }
        public string next { get; set; }
        public string previous { get; set; }
        public IEnumerable<T> results { get; set; }

        public bool hasNext => !string.IsNullOrEmpty(next);
        public bool hasPrevious => !string.IsNullOrEmpty(previous);
    }
}