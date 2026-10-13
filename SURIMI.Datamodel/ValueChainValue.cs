namespace SURIMI.Datamodel
{
    public class ValueChainValue
    {
        public required ValueChainUnitType Type { get; set; }
        public required double Production { get; set; }
        public required double ProductionLiveWeight { get; set; }
        public required double ProductionValue { get; set; }
        public required double OtherProductionValue { get; set; }
        public required double TicketRevenue { get; set; }
        public required double Subsidies { get; set; }
        public required double SaleriesShares { get; set; }
        public required double InputFish { get; set; }
        public required double InputOther { get; set; }
        public required double Taxes { get; set; }
        public required double Overhead { get; set; }
        public required double JobsFemale{ get; set; }
        public required double JobsMale { get; set; }
        public required double WorkerDependents { get; set; }
        public required double OwnerDependents { get; set; }
    }
}
