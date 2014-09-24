using System.Collections.Generic;

namespace Model
{
    public class StationInfo
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public string RejseplanId { get; set; }
        public string Lat { get; set; }
        public string Lng { get; set; }
        public List<Track> Metros { get; set; } 
    }
}