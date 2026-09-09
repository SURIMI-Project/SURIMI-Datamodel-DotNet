namespace SURIMI.Datamodel
{
    public class SurimiContract
    {
        public required Simulation Simulation { get; set; }
        public required Standards Standards { get; set; }
        public required Items Items { get; set; }
    }
}
