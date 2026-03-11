namespace SURIMI.Datamodel
{
    // Describes the Species, and the total allowable catch for this timestep
    public class TotalAllowableCatch
    {
        public required Species Species { get; set; }
        public required FleetSegment FleetSegment { get; set; }
        public double Catch { get; set; }
    }
}
