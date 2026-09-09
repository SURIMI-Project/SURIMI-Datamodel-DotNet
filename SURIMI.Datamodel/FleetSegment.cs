namespace SURIMI.Datamodel
{
    public class FleetSegment
    {
        public required string GearCode { get; set; }
        public string? VesselLengthClass { get; set; }
        public string? Scale { get; set; }
        public required string CountryCode { get; set; }
        public string? Model { get; set; }
    }
}
