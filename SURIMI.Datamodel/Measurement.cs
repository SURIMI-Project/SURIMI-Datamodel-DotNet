namespace SURIMI.Datamodel
{
    public class Measurement
    {
        public string? System { get; set; }
        public List<UnitType> Units { get; set; } = [];
    }
}
