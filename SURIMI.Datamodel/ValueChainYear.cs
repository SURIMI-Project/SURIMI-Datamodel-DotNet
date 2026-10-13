namespace SURIMI.Datamodel
{
    public class ValueChainYear
    {
        public required int Year { get; set; }
        public List<ValueChainValue> Values { get; set; } = new List<ValueChainValue>();
    }
}
