namespace SURIMI.Datamodel
{
    public class Sale
    {
        public required string SpeciesCode { get; set; }
        public required string GearCode { get; set; }
        public double Quantity { get; set; }
        public required string CategoryCode { get; set; }
        public double Value { get; set; }
    }
}
