using System.Collections.Generic;

namespace Model
{
    public class TransitInfo
    {
        public List<string> InstallationStates { get; set; } 
        public List<string> InstallationTypes { get; set; }
        public List<StationInfo> StationInfo { get; set; }
        public string VersionNo { get; set; }
        public string ErrorMessage { get; set; }
        public string IsErrorState { get; set; }
        public string StatusTextMain { get; set; }
        public string StatusTextMainCreated { get; set; }
        public string StatusTextMainFormated { get; set; }
        public List<LineStatus> LineStatus { get; set; }
        public List<Station> Stations { get; set; }
        public List<Prices> Prices { get; set; } 

    }
}
