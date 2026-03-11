namespace SURIMI.Datamodel
{
    // Describes the Target Fishing Mortality policy
    public class TargetFishingMortality
    {
        // The species that this is about
        public required Species Species { get; set; }
        // the lower limit of the biomass. When the biomass is below this, no fishing is allowed
        public double BiomassLimit { get; set; }
        // the upper limit of the biomass. When the biomass is more then this, fishing is unrestricted
        public double BiomassBase { get; set; }
        // the maximum allowed catch
        public double FMax { get; set; }
    }
}
