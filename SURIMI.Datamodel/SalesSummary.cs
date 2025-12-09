namespace SURIMI.Datamodel
{
    public class SalesSummary
    {
        public required string MarketCode { get; set; }
        public required string Currency { get; set; }
        public List<Sale> Sales { get; set; } = new List<Sale>();
    }
}
