using System.Collections.Generic;

namespace Model
{
    public class Station
    {
        public List<Installation> Installations { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string HelpText { get; set; }
        public string RejsePlanId { get; set; }
        public string HasStairs { get; set; }
        public string StairsStateId { get; set; }
        public string HasElevator { get; set; }
        public string ElevatorStateId { get; set; }
        public string HasSecondElevator { get; set; }
        public string SecondElevatorStateId { get; set; }
        public string ElevatorName { get; set; }
        public string SecondElevatorName { get; set; }
        public string StatusText { get; set; }
        public string IsFullyOperational { get; set; }
    }
}