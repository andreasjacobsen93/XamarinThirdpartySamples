using System.Collections.Generic;

namespace Model
{
    public class StationTracks
    {
        public int StationId { get; set; }
        public string StationName { get; set; }
        public List<Track> Tracks { get; set; } 
    }
}