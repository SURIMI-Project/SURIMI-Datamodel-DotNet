namespace SURIMI.Datamodel
{
    public class Species
    {
        public required string SpeciesCode { get; set; }
        public string LengthClass { get; set; } = string.Empty;
        public string Age { get; set; } = string.Empty;
        public string LifeStage { get; set; } = string.Empty;
    }

}
