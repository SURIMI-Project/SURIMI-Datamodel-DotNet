namespace SURIMI.Datamodel
{
    public class TotalAllowableCatch
    {
        public required Species Species { get; set; }
        public required FleetSegment FleetSegment { get; set; }
        public double Catch { get; set; }
    }
}
